Imports System.IO

Module general
    '--configuration
    Public gbLogin As Boolean = True
    Public gstrDBConnection As String
    Public gstrIDNum As String = ""
    Public isSuccess As Boolean = False

    '-- user
    Public gstrTerminalID As String = ""
    Public gstrCheckInBy As String = ""

    '--FULL Version
    Public gbDemo As Boolean = False
    Public gstrTitle As String = "VerifyMe v3.0"

    ''--Lite Version
    'Public gbDemo As Boolean = True
    'Public gstrTitle As String = "VerifyMe Lite v3.0"

    Public gnLimit As Integer = 5
    Public gstrExpiryDate As String = "20201231"


    '--mySTAFF setup
    Public gstrSendMail As String = "mykadpro@onlineapp.com.my"


    Public gstrSupport As String = "Invalid License Key. Please email to " & gstrSendMail
    Public gstrDemo As String = "Demo version! Please purchase to remove this message. Email to " & gstrSendMail
    Public gstrStep As String = "Step 1.Slot in MYKAD 2.Click [Load MYKAD] 3.Save 4.Check IN/Check OUT"

    '-- db connection
    Public gstrOleConnection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password='mykad123';Data Source="
    Public gstrDatabase As String = Application.StartupPath & "\db\mykadpro.mdb"
    Public gstrPhoto As String = Application.StartupPath & "\config\blank_user.png"
    Public gstrTempPhoto As String = Application.StartupPath & "\config\tempPhoto.bmp"
    Public gstrTempPDF As String = Application.StartupPath & "\config\tempPDF.pdf"
    Public gstrReport As String = Application.StartupPath & "\out\ExportList-" & getRandom() & ".csv"

    Public Function getNow() As String
        Return Now.ToString("dd-MM-yyyy HH:mm")

    End Function

    Public Function getTime() As String
        Return Now.ToString("hh:mm:ss tt")

    End Function

    Public Function getDay() As String
        Return Now.ToString("dddd")

    End Function

    Public Function getDate() As String
        Return Now.ToString("dd-MM-yyyy")

    End Function

    Public Function getDateYMD() As String
        Return Now.ToString("yyyyMMdd")

    End Function

    Public Function getRandom() As String
        Dim strTemp As String = Now.Year & Now.Month & Now.Day & Now.Second

        Return strTemp
    End Function

    Public Function FileInUse(ByVal sFile As String) As Boolean
        Dim thisFileInUse As Boolean = False
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If
        Return thisFileInUse
    End Function


End Module
