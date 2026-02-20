Public Class Accueil
    Private Sub BtnAddEmploye_Click(sender As Object, e As EventArgs) Handles BtnAddEmploye.Click
        Dim em As New AjouterEmploye
        em.Show()
    End Sub
End Class