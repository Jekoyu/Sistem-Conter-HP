Public Class Loginform
    Sub Kosongkan()
        TbEmail.Clear()
        TbPassword.Clear()
        TbEmail.Focus()
    End Sub
    Sub SwitchPanel(ByVal panel As Form)
        Form1.PnlContent.Controls.Clear()
        panel.TopLevel = False
        Form1.PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub
    Sub Masuk()
        q = "select name from tb_role where id = '" & dr.Item("role") & "'"
        'Msg(q)
        Cari(q)
        role = dr.Item("name")
        If role = "admin" Then
            AdminForm.Show()
            Form1.Visible = False
            Kosongkan()
        ElseIf role = "user" Then
            UserForm.Show()
            Form1.Visible = False
            Kosongkan()
        End If
    End Sub

    Sub Loginkan()
        q = "select * from tb_users where username = '" & TbEmail.Text & "' and password = '" & TbPassword.Text & "'"
        Cari(q)
        If dr.HasRows Then
            Masuk()
            Kosongkan()
        Else
            q = "select * from tb_users where email = '" & TbEmail.Text & "' and password = '" & TbPassword.Text & "'"
            Msg(q)
            Cari(q)
            If dr.HasRows Then
                Masuk()
                Kosongkan()
            Else
                m = "Username email/password salah"
                Msg(m)
            End If
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SwitchPanel(RegisterForm)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TbEmail.Text = "" Or TbPassword.Text = "" Then
            m = "Terdapat kolom Yang Kosong"
            Msg(m)
        Else
            Loginkan()
        End If
    End Sub

    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()
    End Sub
End Class