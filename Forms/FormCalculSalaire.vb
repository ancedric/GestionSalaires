Imports System.Data

Public Class FormCalculSalaire
    Private ReadOnly _idEmploye As Integer
    Private ReadOnly _paieService As New PaieService()
    Private ReadOnly _employeService As New EmployeService()
    Private _salaireBrut As Decimal
    Private _salaireNet As Decimal

    Public Sub New(idEmploye As Integer)
        _idEmploye = idEmploye
        InitializeComponent()
    End Sub

    Private Sub FormCalculSalaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As DataTable = _employeService.GetAllEmployes()
            Dim rows = dt.Select($"IdEmploye = {_idEmploye}")
            If rows.Length > 0 Then numBase.Value = CDec(rows(0)("SalaireBase"))
            numMois.Value = Date.Now.Month
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCalculer_Click(sender As Object, e As EventArgs) Handles btnCalculer.Click
        Dim result = _paieService.CalculerSalaire(numBase.Value, numPrimes.Value, numHeuresSup.Value, numRetenues.Value)
        _salaireBrut = result.Brut
        _salaireNet = result.Net
        lblBrut.Text = $"Salaire Brut : {_salaireBrut:N2}"
        lblNet.Text = $"Salaire Net : {_salaireNet:N2}"
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        Try
            If _salaireBrut = 0D AndAlso _salaireNet = 0D Then
                btnCalculer.PerformClick()
            End If

            Dim paie As New Paie With {
                .IdEmploye = _idEmploye,
                .Mois = CInt(numMois.Value),
                .Annee = CInt(numAnnee.Value),
                .SalaireBase = numBase.Value,
                .Primes = numPrimes.Value,
                .HeuresSup = numHeuresSup.Value,
                .Retenues = numRetenues.Value,
                .SalaireBrut = _salaireBrut,
                .SalaireNet = _salaireNet,
                .DateGeneration = DateTime.Now
            }

            If _paieService.EnregistrerPaie(paie) Then
                MessageBox.Show("Paie enregistrée.")
                Close()
            Else
                MessageBox.Show("Échec enregistrement paie.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
