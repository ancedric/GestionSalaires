Public Class FormLogin
    Private ReadOnly _authService As New AuthService()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Try
            If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtMotDePasse.Text) Then
                MessageBox.Show("Veuillez remplir tous les champs.")
                Return
            End If

            Dim admin = _authService.Login(txtEmail.Text.Trim(), txtMotDePasse.Text)

            If admin Is Nothing Then
                MessageBox.Show("Identifiants invalides.")
                Return
            End If

            Dim dashboard As New FormDashboard(admin)
            dashboard.Show()
            Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInscription_Click(sender As Object, e As EventArgs) Handles btnInscription.Click
        Dim register As New FormRegister()
        register.ShowDialog()
    End Sub
End Class
