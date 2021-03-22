Public Class UserLogout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As String
        r = MsgBox("Yakin Logout???", vbYesNo)
        If r = vbYes Then
            UserForm.Visible = False
            Form1.Show()
            Loginform.Kosongkan()
        End If
    End Sub
End Class