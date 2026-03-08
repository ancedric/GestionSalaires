Public Class FormRegister
    Private ReadOnly _authService As New AuthService()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            If String.IsNullOrWhiteSpace(txtNom.Text) OrElse String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtMotDePasse.Text) Then
                MessageBox.Show("Tous les champs sont obligatoires.")
                Return
            End If

            Dim ok = _authService.RegisterAdmin(txtNom.Text.Trim(), txtEmail.Text.Trim(), txtMotDePasse.Text)
            If ok Then
                MessageBox.Show("Administrateur créé avec succès.")
                Close()
            Else
                MessageBox.Show("Création impossible.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
