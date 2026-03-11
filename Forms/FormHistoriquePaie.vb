Public Class FormHistoriquePaie
    Private ReadOnly _service As New PaieService()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FormHistoriquePaie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerHistorique()
    End Sub

    Private Sub ChargerHistorique()
        Try
            dgvPaies.DataSource = _service.GetHistoriquePaies()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVoirBulletin_Click(sender As Object, e As EventArgs) Handles btnVoirBulletin.Click
        Try
            If dgvPaies.SelectedRows.Count = 0 Then
                MessageBox.Show("Sélectionnez une paie.")
                Return
            End If

            Dim idPaie = CInt(dgvPaies.SelectedRows(0).Cells("IdPaie").Value)
            Dim row = _service.GetPaieById(idPaie)
            If row Is Nothing Then
                MessageBox.Show("Bulletin introuvable.")
                Return
            End If

            Dim bulletin = $"Bulletin de paie" & Environment.NewLine &
                           $"Employé: {row("Nom")} {row("Prenom")} ({row("Matricule")})" & Environment.NewLine &
                           $"Poste: {row("Poste")}" & Environment.NewLine &
                           $"Période: {row("Mois")}/{row("Annee")}" & Environment.NewLine &
                           $"Brut: {CDec(row("SalaireBrut")):N2}" & Environment.NewLine &
                           $"Retenues: {CDec(row("Retenues")):N2}" & Environment.NewLine &
                           $"Net: {CDec(row("SalaireNet")):N2}" & Environment.NewLine &
                           $"Généré le: {CDate(row("DateGeneration")):dd/MM/yyyy HH:mm}"

            MessageBox.Show(bulletin, "Bulletin")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
