Imports System.Data

Public Class FormModifierEmploye
    Inherits FormAjouterEmploye

    Private ReadOnly _service As New EmployeService()
    Private ReadOnly _idEmploye As Integer

    Public Sub New(idEmploye As Integer)
        MyBase.New()
        _idEmploye = idEmploye
        Text = "Modifier Employé"
    End Sub

    Private Sub FormModifierEmploye_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerEmploye()
    End Sub

    Private Sub ChargerEmploye()
        Try
            Dim dt As DataTable = _service.GetAllEmployes()
            Dim rows = dt.Select($"IdEmploye = {_idEmploye}")
            If rows.Length = 0 Then
                MessageBox.Show("Employé introuvable.")
                Close()
                Return
            End If

            Dim row = rows(0)
            txtMatricule.Text = row("Matricule").ToString()
            txtNom.Text = row("Nom").ToString()
            txtPrenom.Text = row("Prenom").ToString()
            txtPoste.Text = row("Poste").ToString()
            numSalaireBase.Value = CDec(row("SalaireBase"))
            dtpDateEmbauche.Value = CDate(row("DateEmbauche"))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overrides Function BuildEmploye() As Employe
        Dim emp = MyBase.BuildEmploye()
        emp.IdEmploye = _idEmploye
        Return emp
    End Function

    Protected Overrides Function SaveEmploye(emp As Employe) As Boolean
        Return _service.UpdateEmploye(emp)
    End Function
End Class
