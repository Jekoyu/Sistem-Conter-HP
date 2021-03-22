Public Class Form1
    Sub SwitchPanel(ByVal panel As Form)
        PnlContent.Controls.Clear()
        panel.TopLevel = False
        PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(Loginform)
    End Sub
End Class
