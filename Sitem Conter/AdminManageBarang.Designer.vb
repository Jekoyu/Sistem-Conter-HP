<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminManageBarang
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbGambar = New System.Windows.Forms.TextBox()
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbKet = New System.Windows.Forms.TextBox()
        Me.TbStok = New System.Windows.Forms.TextBox()
        Me.TbHarga = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(133, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Manage Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Gambar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nama "
        '
        'TbGambar
        '
        Me.TbGambar.Location = New System.Drawing.Point(137, 262)
        Me.TbGambar.Name = "TbGambar"
        Me.TbGambar.Size = New System.Drawing.Size(124, 20)
        Me.TbGambar.TabIndex = 23
        '
        'TbNama
        '
        Me.TbNama.Location = New System.Drawing.Point(137, 234)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(124, 20)
        Me.TbNama.TabIndex = 22
        '
        'TbId
        '
        Me.TbId.Location = New System.Drawing.Point(137, 206)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(124, 20)
        Me.TbId.TabIndex = 21
        Me.TbId.Visible = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(399, 103)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(545, 534)
        Me.DGV.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(417, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 46)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "BARANG"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 19)
        Me.Button1.TabIndex = 38
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(238, 437)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 29)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(147, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 29)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(56, 437)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 29)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Insert"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Keterangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Harga"
        '
        'TbKet
        '
        Me.TbKet.Location = New System.Drawing.Point(137, 344)
        Me.TbKet.Name = "TbKet"
        Me.TbKet.Size = New System.Drawing.Size(124, 20)
        Me.TbKet.TabIndex = 41
        '
        'TbStok
        '
        Me.TbStok.Location = New System.Drawing.Point(137, 316)
        Me.TbStok.Name = "TbStok"
        Me.TbStok.Size = New System.Drawing.Size(124, 20)
        Me.TbStok.TabIndex = 40
        '
        'TbHarga
        '
        Me.TbHarga.Location = New System.Drawing.Point(137, 288)
        Me.TbHarga.Name = "TbHarga"
        Me.TbHarga.Size = New System.Drawing.Size(124, 20)
        Me.TbHarga.TabIndex = 39
        '
        'AdminManageBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 669)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbKet)
        Me.Controls.Add(Me.TbStok)
        Me.Controls.Add(Me.TbHarga)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbGambar)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminManageBarang"
        Me.Text = "AdminManageBarang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbGambar As TextBox
    Friend WithEvents TbNama As TextBox
    Friend WithEvents TbId As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbKet As TextBox
    Friend WithEvents TbStok As TextBox
    Friend WithEvents TbHarga As TextBox
End Class
