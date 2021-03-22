Public Class RegisterForm
    Dim id As String
    Sub Kosongkan()
        TbUsername.Clear()
        TbEmail.Clear()
        TbPassword.Clear()
        TbAlamat.Clear()
        TbNoHp.Clear()
        TbUsername.Focus()
    End Sub
    Sub GetId()
        q = "select * from tb_users order by id desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "USR" + Format(Microsoft.VisualBasic.Right(dr.Item("id"), 6) + 1, "000000")
        Else
            TbId.Text = "USR000001"
        End If
    End Sub
    Sub Reg()
        GetId()
        q = "insert into tb_users(id,username,email,password,alamat,nohp,role) values('" & TbId.Text & "','" & TbUsername.Text & "','" & TbEmail.Text & "','" & TbPassword.Text & "','" & TbAlamat.Text & "','" & TbNoHp.Text & "',2)"
        Msg(q)
        ENQ(q)
        Kosongkan()
    End Sub
    Sub SwitchPanel(ByVal panel As Form)
        Form1.PnlContent.Controls.Clear()
        panel.TopLevel = False
        Form1.PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SwitchPanel(Loginform)
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()
        GetId()
    End Sub

    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        If TbEmail.Text = "" Or TbUsername.Text = "" Or TbPassword.Text = "" Or TbAlamat.Text = "" Or TbNoHp.Text = "" Then
            m = "Terdapat Kolom Yang Kosong"
            Msg(m)
        Else
            Try
                Reg()
                SwitchPanel(Loginform)
            Catch ex As Exception
                m = ex.ToString
                Msg(m)
            End Try
        End If
    End Sub

    Private Sub TbEmail_TextChanged(sender As Object, e As EventArgs) Handles TbEmail.TextChanged

    End Sub
End Class