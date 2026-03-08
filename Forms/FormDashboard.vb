Public Class FormDashboard
    Private ReadOnly _employeService As New EmployeService()
    Private ReadOnly _admin As Admin

    Public Sub New(admin As Admin)
        _admin = admin
        InitializeComponent()
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = $"Bienvenue {_admin.Nom}"
        ChargerEmployes()
    End Sub

    Private Sub txtRecherche_TextChanged(sender As Object, e As EventArgs) Handles txtRecherche.TextChanged
        ChargerEmployes(txtRecherche.Text.Trim())
    End Sub

    Private Sub ChargerEmployes(Optional recherche As String = "")
        Try
            dgvEmployes.DataSource = _employeService.GetAllEmployes(recherche)
            RafraichirStatistiques()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RafraichirStatistiques()
        Dim stats = _employeService.GetStatistiques()
        lblTotalEmployes.Text = $"Total employés : {stats.TotalEmployes}"
        lblMasseSalariale.Text = $"Masse salariale : {stats.MasseSalariale:N2}"
        lblSalaireMoyen.Text = $"Salaire moyen : {stats.SalaireMoyen:N2}"
    End Sub

    Private Function GetSelectedIdEmploye() As Integer?
        If dgvEmployes.SelectedRows.Count = 0 Then Return Nothing
        Return CInt(dgvEmployes.SelectedRows(0).Cells("IdEmploye").Value)
    End Function

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Using form As New FormAjouterEmploye()
            If form.ShowDialog() = DialogResult.OK Then ChargerEmployes(txtRecherche.Text.Trim())
        End Using
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Dim id = GetSelectedIdEmploye()
        If Not id.HasValue Then
            MessageBox.Show("Sélectionnez un employé.")
            Return
        End If

        Using form As New FormModifierEmploye(id.Value)
            If form.ShowDialog() = DialogResult.OK Then ChargerEmployes(txtRecherche.Text.Trim())
        End Using
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Dim id = GetSelectedIdEmploye()
        If Not id.HasValue Then
            MessageBox.Show("Sélectionnez un employé.")
            Return
        End If

        If MessageBox.Show("Confirmer la suppression ?", "Suppression", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                _employeService.DeleteEmploye(id.Value)
                ChargerEmployes(txtRecherche.Text.Trim())
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnGenererPaie_Click(sender As Object, e As EventArgs) Handles btnGenererPaie.Click
        Dim id = GetSelectedIdEmploye()
        If Not id.HasValue Then
            MessageBox.Show("Sélectionnez un employé.")
            Return
        End If

        Using form As New FormCalculSalaire(id.Value)
            form.ShowDialog()
        End Using
    End Sub

    Private Sub btnHistorique_Click(sender As Object, e As EventArgs) Handles btnHistorique.Click
        Using form As New FormHistoriquePaie()
            form.ShowDialog()
        End Using
    End Sub
End Class
