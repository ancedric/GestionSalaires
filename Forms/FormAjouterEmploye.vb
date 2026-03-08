Public Class FormAjouterEmploye
    Private ReadOnly _service As New EmployeService()

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overridable Function BuildEmploye() As Employe
        Return New Employe With {
            .Matricule = txtMatricule.Text.Trim(),
            .Nom = txtNom.Text.Trim(),
            .Prenom = txtPrenom.Text.Trim(),
            .Poste = txtPoste.Text.Trim(),
            .SalaireBase = numSalaireBase.Value,
            .DateEmbauche = dtpDateEmbauche.Value.Date
        }
    End Function

    Protected Overridable Function SaveEmploye(emp As Employe) As Boolean
        Return _service.AddEmploye(emp)
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim emp = BuildEmploye()
            If String.IsNullOrWhiteSpace(emp.Matricule) OrElse String.IsNullOrWhiteSpace(emp.Nom) OrElse String.IsNullOrWhiteSpace(emp.Prenom) OrElse String.IsNullOrWhiteSpace(emp.Poste) Then
                MessageBox.Show("Tous les champs texte sont obligatoires.")
                Return
            End If

            If SaveEmploye(emp) Then
                DialogResult = DialogResult.OK
                Close()
            Else
                MessageBox.Show("Enregistrement impossible.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
