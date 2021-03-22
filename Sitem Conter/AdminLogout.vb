Public Class AdminLogout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As String
        r = MsgBox("Yakin Logout???", vbYesNo)
        If r = vbYes Then
            AdminForm.Visible = False
            Form1.Show()
            Loginform.Kosongkan()
        End If
    End Sub
End Class