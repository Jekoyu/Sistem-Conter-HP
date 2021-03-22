Public Class UserForm
    Sub SwitchPanel(ByVal panel As Form)
        PnlContent.Controls.Clear()
        panel.TopLevel = False
        PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles Me.Load
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
End Class