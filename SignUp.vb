Public Class SignUp
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim home As New Accueil
        home.Show()
        Me.Close()
    End Sub

    Private Sub LbConnecter_Click(sender As Object, e As EventArgs) Handles LbConnecter.Click
        Dim signin As New Authentification
        signin.Show()
        Me.Close()
    End Sub
End Class