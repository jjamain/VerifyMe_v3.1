<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.picMatchLeft = New System.Windows.Forms.PictureBox()
        Me.picMatchRight = New System.Windows.Forms.PictureBox()
        Me.picMatch = New System.Windows.Forms.PictureBox()
        Me.lblIDNum = New System.Windows.Forms.Label()
        Me.lblKPTName = New System.Windows.Forms.Label()
        Me.lblVerifyStatus = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblSessionID = New System.Windows.Forms.Label()
        Me.rbLeft = New System.Windows.Forms.RadioButton()
        Me.rbRight = New System.Windows.Forms.RadioButton()
        Me.lblCapJari = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picMatchLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMatchRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(541, 101)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(201, 75)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Start"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1401, 97)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(201, 75)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(9, 14)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(944, 84)
        Me.lblMsg.TabIndex = 2
        Me.lblMsg.Text = "Please insert myKAD to biometric reader before click on Start..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.lblMsg)
        Me.Panel1.Location = New System.Drawing.Point(0, 346)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 112)
        Me.Panel1.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(0, 217)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(961, 39)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "System message..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picMatchLeft
        '
        Me.picMatchLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMatchLeft.Location = New System.Drawing.Point(1113, 97)
        Me.picMatchLeft.Name = "picMatchLeft"
        Me.picMatchLeft.Size = New System.Drawing.Size(85, 84)
        Me.picMatchLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMatchLeft.TabIndex = 82
        Me.picMatchLeft.TabStop = False
        '
        'picMatchRight
        '
        Me.picMatchRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMatchRight.Location = New System.Drawing.Point(1202, 97)
        Me.picMatchRight.Name = "picMatchRight"
        Me.picMatchRight.Size = New System.Drawing.Size(85, 84)
        Me.picMatchRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMatchRight.TabIndex = 81
        Me.picMatchRight.TabStop = False
        '
        'picMatch
        '
        Me.picMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMatch.Location = New System.Drawing.Point(1293, 97)
        Me.picMatch.Name = "picMatch"
        Me.picMatch.Size = New System.Drawing.Size(85, 84)
        Me.picMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMatch.TabIndex = 83
        Me.picMatch.TabStop = False
        '
        'lblIDNum
        '
        Me.lblIDNum.AutoSize = True
        Me.lblIDNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNum.ForeColor = System.Drawing.Color.Black
        Me.lblIDNum.Location = New System.Drawing.Point(1119, 195)
        Me.lblIDNum.Name = "lblIDNum"
        Me.lblIDNum.Size = New System.Drawing.Size(100, 25)
        Me.lblIDNum.TabIndex = 90
        Me.lblIDNum.Text = "MYKAD#"
        '
        'lblKPTName
        '
        Me.lblKPTName.AutoSize = True
        Me.lblKPTName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKPTName.ForeColor = System.Drawing.Color.Black
        Me.lblKPTName.Location = New System.Drawing.Point(1119, 236)
        Me.lblKPTName.Name = "lblKPTName"
        Me.lblKPTName.Size = New System.Drawing.Size(168, 25)
        Me.lblKPTName.TabIndex = 89
        Me.lblKPTName.Text = "MYKAD Name..."
        '
        'lblVerifyStatus
        '
        Me.lblVerifyStatus.AutoSize = True
        Me.lblVerifyStatus.Location = New System.Drawing.Point(1128, 281)
        Me.lblVerifyStatus.Name = "lblVerifyStatus"
        Me.lblVerifyStatus.Size = New System.Drawing.Size(56, 25)
        Me.lblVerifyStatus.TabIndex = 91
        Me.lblVerifyStatus.Text = "FAIL"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(1113, 46)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(201, 45)
        Me.btnRefresh.TabIndex = 92
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblSessionID
        '
        Me.lblSessionID.AutoSize = True
        Me.lblSessionID.Location = New System.Drawing.Point(1139, 322)
        Me.lblSessionID.Name = "lblSessionID"
        Me.lblSessionID.Size = New System.Drawing.Size(24, 25)
        Me.lblSessionID.TabIndex = 93
        Me.lblSessionID.Text = "0"
        '
        'rbLeft
        '
        Me.rbLeft.AutoSize = True
        Me.rbLeft.Location = New System.Drawing.Point(75, 111)
        Me.rbLeft.Name = "rbLeft"
        Me.rbLeft.Size = New System.Drawing.Size(95, 29)
        Me.rbLeft.TabIndex = 94
        Me.rbLeft.TabStop = True
        Me.rbLeft.Text = "LEFT"
        Me.rbLeft.UseVisualStyleBackColor = True
        '
        'rbRight
        '
        Me.rbRight.AutoSize = True
        Me.rbRight.Location = New System.Drawing.Point(75, 147)
        Me.rbRight.Name = "rbRight"
        Me.rbRight.Size = New System.Drawing.Size(107, 29)
        Me.rbRight.TabIndex = 95
        Me.rbRight.TabStop = True
        Me.rbRight.Text = "RIGHT"
        Me.rbRight.UseVisualStyleBackColor = True
        '
        'lblCapJari
        '
        Me.lblCapJari.AutoSize = True
        Me.lblCapJari.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapJari.Location = New System.Drawing.Point(70, 69)
        Me.lblCapJari.Name = "lblCapJari"
        Me.lblCapJari.Size = New System.Drawing.Size(205, 25)
        Me.lblCapJari.TabIndex = 96
        Me.lblCapJari.Text = "Verify Thumbprint:"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(825, 470)
        Me.Controls.Add(Me.lblCapJari)
        Me.Controls.Add(Me.rbRight)
        Me.Controls.Add(Me.rbLeft)
        Me.Controls.Add(Me.lblSessionID)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblVerifyStatus)
        Me.Controls.Add(Me.lblIDNum)
        Me.Controls.Add(Me.lblKPTName)
        Me.Controls.Add(Me.picMatch)
        Me.Controls.Add(Me.picMatchLeft)
        Me.Controls.Add(Me.picMatchRight)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picMatchLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMatchRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblMsg As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStatus As Label
    Private WithEvents picMatchLeft As PictureBox
    Private WithEvents picMatchRight As PictureBox
    Private WithEvents picMatch As PictureBox
    Friend WithEvents lblIDNum As Label
    Friend WithEvents lblKPTName As Label
    Friend WithEvents lblVerifyStatus As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblSessionID As Label
    Friend WithEvents rbLeft As RadioButton
    Friend WithEvents rbRight As RadioButton
    Friend WithEvents lblCapJari As Label
End Class
