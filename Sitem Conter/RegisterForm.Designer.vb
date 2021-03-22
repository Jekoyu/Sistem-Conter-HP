<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.TbAlamat = New System.Windows.Forms.TextBox()
        Me.TbNoHp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(225, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTER"
        '
        'TbUsername
        '
        Me.TbUsername.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbUsername.Location = New System.Drawing.Point(232, 180)
        Me.TbUsername.Multiline = True
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(154, 35)
        Me.TbUsername.TabIndex = 1
        '
        'TbEmail
        '
        Me.TbEmail.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbEmail.Location = New System.Drawing.Point(232, 230)
        Me.TbEmail.Multiline = True
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.Size = New System.Drawing.Size(154, 35)
        Me.TbEmail.TabIndex = 6
        '
        'TbPassword
        '
        Me.TbPassword.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbPassword.Location = New System.Drawing.Point(232, 280)
        Me.TbPassword.Multiline = True
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.Size = New System.Drawing.Size(154, 35)
        Me.TbPassword.TabIndex = 7
        '
        'TbAlamat
        '
        Me.TbAlamat.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbAlamat.Location = New System.Drawing.Point(232, 330)
        Me.TbAlamat.Multiline = True
        Me.TbAlamat.Name = "TbAlamat"
        Me.TbAlamat.Size = New System.Drawing.Size(154, 74)
        Me.TbAlamat.TabIndex = 8
        '
        'TbNoHp
        '
        Me.TbNoHp.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbNoHp.Location = New System.Drawing.Point(232, 420)
        Me.TbNoHp.Multiline = True
        Me.TbNoHp.Name = "TbNoHp"
        Me.TbNoHp.Size = New System.Drawing.Size(154, 35)
        Me.TbNoHp.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(127, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(127, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 28)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(127, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 28)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(127, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 28)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(127, 427)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 28)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "No Hp"
        '
        'BtnReg
        '
        Me.BtnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReg.Location = New System.Drawing.Point(201, 481)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(107, 36)
        Me.BtnReg.TabIndex = 15
        Me.BtnReg.Text = "REGISTER"
        Me.BtnReg.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 536)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Already Have An Account?"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(289, 535)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(36, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Login"
        '
        'TbId
        '
        Me.TbId.Location = New System.Drawing.Point(282, 141)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 22)
        Me.TbId.TabIndex = 18
        Me.TbId.Visible = False
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 700)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnReg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbNoHp)
        Me.Controls.Add(Me.TbAlamat)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbEmail)
        Me.Controls.Add(Me.TbUsername)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents TbEmail As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents TbAlamat As TextBox
    Friend WithEvents TbNoHp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnReg As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TbId As TextBox
End Class
