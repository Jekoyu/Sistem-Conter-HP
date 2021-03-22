Public Class AdminForm
    Sub SwitchPanel(ByVal panel As Form)
        PnlContent.Controls.Clear()
        panel.TopLevel = False
        PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(AllHome)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As String
        r = MsgBox("Yakin Tutup", vbYesNo)
        If r = vbYes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = WindowState.Minimized

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SwitchPanel(AdminManageBarang)
        AdminManageBarang.Kosongkan()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SwitchPanel(AdminManageUser)
        AdminManageUser.Kosongkan()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SwitchPanel(AllAbout)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SwitchPanel(AdminLogout)
    End Sub
End Class