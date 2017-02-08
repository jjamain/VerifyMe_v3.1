Imports System.IO
Imports System.Threading
Imports System.Configuration
Imports System.Net

Public Class frmLogin

    Dim strLicenseKey As String = ConfigurationManager.AppSettings("LicenseKey")
    Dim strReaderCode As String = ConfigurationManager.AppSettings("ReaderCode")
    Dim strSubmit As String = ConfigurationManager.AppSettings("Submit")
    Dim strPageType As String = ConfigurationManager.AppSettings("PageType")
    '--open to any webservices page
    Dim strWebPage As String = ConfigurationManager.AppSettings("WebPage")          '-- & "getdata.aspx?"
    Dim strBiometric As String = ConfigurationManager.AppSettings("Biometric")      '--0=both,1=left,2=right
    Dim strFinger As String = "LEFT"
    Dim gstrTitle As String = "VerifyMe v3.0"

    '--read MYKAD
    Dim oMYKAD As New mykadprobio_jpj.mykadprobio.jpn
    Dim nResult As Integer = 0

    Dim byteThumbLeft As Byte()
    Dim byteThumbRight As Byte()

    Dim strMatchedFPImageLeft As String = Application.StartupPath & "\out\MatchFPLeft.bmp"
    Dim strMatchedFPImageRight As String = Application.StartupPath & "\out\MatchFPRight.bmp"
    Dim strMatchedFPImage As String = Application.StartupPath & "\out\MatchFP.bmp"

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ClearScreen()
            ParseCommandLineArgs()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            '--DONE
            If btnLogin.Text = "Ok" Then
                End
            End If

            '--must select LEFT or RIGHT
            If rbLeft.Checked = False And rbRight.Checked = False Then
                lblMsg.Text = "Please select Thumbprint to verify!"
                Exit Sub
            End If

            '--left or right
            If rbLeft.Checked = True Then
                strFinger = "LEFT"
            Else
                strFinger = "RIGHT"
            End If

            '--reset screen
            btnLogin.Text = "Ok"
            btnLogin.Enabled = False
            btnLogout.Text = "Cancel"

            Dim myThread As New Thread(AddressOf VerifyMe)
            Form.CheckForIllegalCrossThreadCalls = False

            myThread.Start()
            Thread.Sleep(0)

        Catch ex As Exception
            '--manual data entry
            lblMsg.Text = "Err:" & ex.ToString
        End Try

    End Sub

    Private Sub ClearScreen()
        lblStatus.Text = ""
        lblMsg.Text = "Please insert MYKAD into biometric reader before click on Start..."


        Select Case strBiometric
            Case "0"    '--both. left default
                lblCapJari.Visible = True
                rbLeft.Visible = True
                rbRight.Visible = True

                rbLeft.Checked = True
            Case "1"    '--left
                lblCapJari.Visible = True
                rbLeft.Visible = True
                rbRight.Visible = False

                rbLeft.Checked = True
            Case "2"    '--right
                lblCapJari.Visible = True
                rbLeft.Visible = False
                rbRight.Visible = True

                rbRight.Checked = True

                rbRight.Left = rbLeft.Left
                rbRight.Top = rbLeft.Top

            Case Else
                lblCapJari.Visible = True
                rbLeft.Visible = True
                rbRight.Visible = True

                rbLeft.Checked = True
        End Select

    End Sub

    Private Sub VerifyMe()
        Dim nRet As Integer = 0
        Dim strRet As String = ""

        '--init verification
        isSuccess = False
        lblStatus.Text = "Please wait. Connecting to MYKAD Reader...."

        '--create new object
        oMYKAD = New mykadprobio_jpj.mykadprobio.jpn
        Try
            '--connect to reader
            strRet = oMYKAD.BeginJPN()
            If strRet <> "0" Then
                lblMsg.Text = "Err: " & strRet
                Exit Sub
            End If

            '--get mykad, name and photo
            lblIDNum.Text = oMYKAD.getIDNum
            lblKPTName.Text = oMYKAD.getGMPCName

            lblStatus.Text = "MYKAD belong to " & lblKPTName.Text

            '--refresh photo
            lblMsg.Text = "Place " & strFinger & " thumb for verification.."

            picMatchLeft.Refresh()
            picMatchRight.Refresh()

            '--reset before usage
            byteThumbLeft = New Byte(511) {}
            byteThumbRight = New Byte(511) {}

            '--read LEFT and RIGHT minutiae
            byteThumbLeft = oMYKAD.getThumbLeftByte
            byteThumbRight = oMYKAD.getThumbRightByte

            '--check file inuse
            If FileInUse(strMatchedFPImage) = True Then
                lblMsg.Text = "File In use. Please close image file first!"
                Exit Sub
            End If

            '--match LEFT/RIGHT finger
            If rbLeft.Checked = True Then
                nRet = oMYKAD.isVerifyLeft(byteThumbLeft, byteThumbLeft, strMatchedFPImage)
            Else
                nRet = oMYKAD.isVerifyRight(byteThumbRight, byteThumbRight, strMatchedFPImage)
            End If

            If nRet = 0 Then
                '--save image for print-out
                If File.Exists(strMatchedFPImage) Then
                    Dim buffer As [Byte]() = File.ReadAllBytes(strMatchedFPImage)

                    Dim stream As New MemoryStream(buffer)
                    Dim photoBmp As New Bitmap(stream, False)
                    picMatch.Image = photoBmp
                    picMatch.Refresh()
                End If
                'isSuccess = True
                lblVerifyStatus.Text = "SUCCESS"
            Else
                'isSuccess = False
                lblVerifyStatus.Text = "FAILED"
            End If

            ''--display message
            'If isSuccess = True Then
            '    '--SUCCESS
            '    lblVerifyStatus.Text = "SUCCESS"
            'Else
            '    '--FAILED
            '    lblVerifyStatus.Text = "FAILED"
            'End If

            If strSubmit = "Y" Then
                '--submit SUCCESS OR FAIL to webservices
                strRet = SubmitRequest()
                If strRet = "0" Then
                    lblMsg.Text = "Submit verification completed. Status:" & lblVerifyStatus.Text
                Else
                    lblMsg.Text = "System error. Please try again! " & strRet
                End If
            Else
                lblMsg.Text = "Verification completed. Status:" & lblVerifyStatus.Text
            End If

        Catch ex As Exception
            lblMsg.Text = "Err:" & ex.Message
        Finally
            '--close reader connection
            strRet = oMYKAD.EndJPN
            btnLogin.Enabled = True
        End Try

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If btnLogout.Text = "Cancel" Then
            btnLogin.Text = "Login"
            btnLogout.Text = "Logout"

            ClearScreen()
        End If

    End Sub

    Private Function SubmitRequest() As String
        Dim strLink As String = ""

        Select Case strPageType
            Case "ASPX"
                '--http://mykadpro.onlineapp.com.my/getdata.aspx?
                strLink = strWebPage & "sessionid=" & lblSessionID.Text & "&&mykad=" & lblIDNum.Text & "&&kptname=" & lblKPTName.Text & "&&verifystatus=" & lblVerifyStatus.Text
            Case "PHP"
                '--http://jjpjdomain/login/getdata/
                strLink = strWebPage & lblSessionID.Text & "/" & lblIDNum.Text & "/" & lblKPTName.Text & "/" & lblVerifyStatus.Text
            Case Else

        End Select
        Try
            ' Create a request using a URL that can receive a post. 
            Dim request As WebRequest = WebRequest.Create(strLink)

            ' Set the Method property of the request to POST.
            request.Method = "POST"
            ' Create POST data and convert it to a byte array.
            Dim postData As String = "VerifyMe test string!"
            Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)
            ' Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded"
            ' Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length
            ' Get the request stream.
            Dim dataStream As Stream = request.GetRequestStream()
            ' Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length)
            ' Close the Stream object.
            dataStream.Close()
            ' Get the response.
            Dim response As WebResponse = request.GetResponse()
            ' Display the status.
            'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            'lblMsg.Text = CType(response, HttpWebResponse).StatusDescription & vbCrLf

            ' Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.
            Dim reader As New StreamReader(dataStream)
            ' Read the content.
            Dim responseFromServer As String = reader.ReadLine()
            'Dim responseFromServer As String = reader.ReadToEnd
            'lblMsg.Text += responseFromServer
            ' Display the content.
            'Console.WriteLine(responseFromServer)
            ' Clean up the streams.
            reader.Close()
            dataStream.Close()
            response.Close()

            Return "0"

        Catch ex As Exception
            Return ex.Message
        End Try


    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ParseCommandLineArgs()

    End Sub

    Private Sub ParseCommandLineArgs()
        Dim inputArgument As String = "/input="
        Dim inputName As String = ""

        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith(inputArgument) Then
                inputName = s.Remove(0, inputArgument.Length)
            End If
        Next
        lblSessionID.Text = inputName
        lblStatus.Text = "SessionID:" & lblSessionID.Text

    End Sub

End Class