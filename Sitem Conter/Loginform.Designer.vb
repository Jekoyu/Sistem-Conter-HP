<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginform
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
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.0!)
        Me.Label1.Location = New System.Drawing.Point(225, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'TbEmail
        '
        Me.TbEmail.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.TbEmail.Location = New System.Drawing.Point(247, 228)
        Me.TbEmail.Multiline = True
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.Size = New System.Drawing.Size(228, 43)
        Me.TbEmail.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(77, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username / Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(77, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'TbPassword
        '
        Me.TbPassword.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.TbPassword.Location = New System.Drawing.Point(247, 290)
        Me.TbPassword.Multiline = True
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.Size = New System.Drawing.Size(228, 43)
        Me.TbPassword.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(228, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 42)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 481)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dont Have An Account?"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(314, 481)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(49, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Register"
        '
        'Loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 700)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbEmail)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loginform"
        Me.Text = "Loginform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TbEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
