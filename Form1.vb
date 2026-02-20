Public Class Authentification
    'Public email As String
    'Public password As String

    'Public Sub SignIn()
    '    Dim em As String = "user@email.com"
    '    Dim pwd As String = "user123"

    '    email = TxtbEmail.Text.ToString()
    '    password = MtbPassword.Text.ToString()

    '    If em = "" OrElse pwd = "" Then
    '        MsgBox("Veuillez remplir tous les champs s'il vous plaît!")
    '    End If

    '    If email = em AndAlso password = pwd Then
    '        Dim accueil As New Accueil
    '        accueil.Show()
    '        Close()
    '    Else
    '        MsgBox("Identifiants incorrects!")
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '    SignIn()
        Dim accueil As New Accueil
        accueil.Show()
        Close()
    End Sub

    Private Sub LbInscription_Click(sender As Object, e As EventArgs) Handles LbInscription.Click
        Dim signup As New SignUp
        signup.Show()
        Close()
    End Sub
End Class
