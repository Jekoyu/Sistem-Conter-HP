﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllAbout
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(274, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KAMI ADALAH PERUSAHAAN YANG BERGERAK DI "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(33, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(955, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BIDANG PENYEDIA LAYANAN DAN BARANG ELEKTRONIK DENGAN BERBAGAI MACAM MERK DAN PILI" &
    "HAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label3.Location = New System.Drawing.Point(388, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 46)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "OKE CELL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(265, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(394, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "JL. JALANINAJADULU NO.15 PULOGEDANG"
        '
        'AllAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 669)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllAbout"
        Me.Text = "AllAbout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
