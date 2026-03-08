<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblWelcome As Label
    Friend WithEvents txtRecherche As TextBox
    Friend WithEvents dgvEmployes As DataGridView
    Friend WithEvents lblTotalEmployes As Label
    Friend WithEvents lblMasseSalariale As Label
    Friend WithEvents lblSalaireMoyen As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnGenererPaie As Button
    Friend WithEvents btnHistorique As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblWelcome = New Label()
        txtRecherche = New TextBox()
        dgvEmployes = New DataGridView()
        lblTotalEmployes = New Label()
        lblMasseSalariale = New Label()
        lblSalaireMoyen = New Label()
        btnAjouter = New Button()
        btnModifier = New Button()
        btnSupprimer = New Button()
        btnGenererPaie = New Button()
        btnHistorique = New Button()
        CType(dgvEmployes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        lblWelcome.Location = New Point(20, 10)
        lblWelcome.AutoSize = True
        txtRecherche.Location = New Point(20, 45)
        txtRecherche.Size = New Size(350, 23)
        txtRecherche.PlaceholderText = "Rechercher: Nom / Matricule / Poste"
        lblTotalEmployes.Location = New Point(400, 45)
        lblTotalEmployes.AutoSize = True
        lblMasseSalariale.Location = New Point(400, 65)
        lblMasseSalariale.AutoSize = True
        lblSalaireMoyen.Location = New Point(400, 85)
        lblSalaireMoyen.AutoSize = True
        dgvEmployes.Location = New Point(20, 80)
        dgvEmployes.Size = New Size(760, 300)
        dgvEmployes.ReadOnly = True
        dgvEmployes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployes.MultiSelect = False
        btnAjouter.Text = "Ajouter Employé"
        btnAjouter.Location = New Point(20, 395)
        btnModifier.Text = "Modifier Employé"
        btnModifier.Location = New Point(160, 395)
        btnSupprimer.Text = "Supprimer Employé"
        btnSupprimer.Location = New Point(300, 395)
        btnGenererPaie.Text = "Générer Paie du Mois"
        btnGenererPaie.Location = New Point(440, 395)
        btnHistorique.Text = "Voir Historique des Paies"
        btnHistorique.Location = New Point(620, 395)
        ClientSize = New Size(810, 450)
        Controls.AddRange(New Control() {lblWelcome, txtRecherche, dgvEmployes, lblTotalEmployes, lblMasseSalariale, lblSalaireMoyen, btnAjouter, btnModifier, btnSupprimer, btnGenererPaie, btnHistorique})
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        CType(dgvEmployes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
