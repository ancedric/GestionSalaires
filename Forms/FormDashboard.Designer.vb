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
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(20, 10)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 15)
        lblWelcome.TabIndex = 0
        ' 
        ' txtRecherche
        ' 
        txtRecherche.Location = New Point(20, 45)
        txtRecherche.Name = "txtRecherche"
        txtRecherche.PlaceholderText = "Rechercher: Nom / Matricule / Poste"
        txtRecherche.Size = New Size(350, 23)
        txtRecherche.TabIndex = 1
        ' 
        ' dgvEmployes
        ' 
        dgvEmployes.Location = New Point(20, 80)
        dgvEmployes.MultiSelect = False
        dgvEmployes.Name = "dgvEmployes"
        dgvEmployes.ReadOnly = True
        dgvEmployes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployes.Size = New Size(760, 300)
        dgvEmployes.TabIndex = 2
        ' 
        ' lblTotalEmployes
        ' 
        lblTotalEmployes.AutoSize = True
        lblTotalEmployes.Location = New Point(400, 45)
        lblTotalEmployes.Name = "lblTotalEmployes"
        lblTotalEmployes.Size = New Size(0, 15)
        lblTotalEmployes.TabIndex = 3
        ' 
        ' lblMasseSalariale
        ' 
        lblMasseSalariale.AutoSize = True
        lblMasseSalariale.Location = New Point(400, 65)
        lblMasseSalariale.Name = "lblMasseSalariale"
        lblMasseSalariale.Size = New Size(0, 15)
        lblMasseSalariale.TabIndex = 4
        ' 
        ' lblSalaireMoyen
        ' 
        lblSalaireMoyen.AutoSize = True
        lblSalaireMoyen.Location = New Point(400, 85)
        lblSalaireMoyen.Name = "lblSalaireMoyen"
        lblSalaireMoyen.Size = New Size(0, 15)
        lblSalaireMoyen.TabIndex = 5
        ' 
        ' btnAjouter
        ' 
        btnAjouter.Location = New Point(20, 395)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(114, 23)
        btnAjouter.TabIndex = 6
        btnAjouter.Text = "Ajouter Employé"
        ' 
        ' btnModifier
        ' 
        btnModifier.Location = New Point(175, 395)
        btnModifier.Name = "btnModifier"
        btnModifier.Size = New Size(125, 23)
        btnModifier.TabIndex = 7
        btnModifier.Text = "Modifier Employé"
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.Location = New Point(342, 395)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(131, 23)
        btnSupprimer.TabIndex = 8
        btnSupprimer.Text = "Supprimer Employé"
        ' 
        ' btnGenererPaie
        ' 
        btnGenererPaie.Location = New Point(503, 395)
        btnGenererPaie.Name = "btnGenererPaie"
        btnGenererPaie.Size = New Size(136, 23)
        btnGenererPaie.TabIndex = 9
        btnGenererPaie.Text = "Générer Paie du Mois"
        ' 
        ' btnHistorique
        ' 
        btnHistorique.Location = New Point(678, 395)
        btnHistorique.Name = "btnHistorique"
        btnHistorique.Size = New Size(102, 23)
        btnHistorique.TabIndex = 10
        btnHistorique.Text = "Voir Historique des Paies"
        ' 
        ' FormDashboard
        ' 
        ClientSize = New Size(810, 450)
        Controls.Add(lblWelcome)
        Controls.Add(txtRecherche)
        Controls.Add(dgvEmployes)
        Controls.Add(lblTotalEmployes)
        Controls.Add(lblMasseSalariale)
        Controls.Add(lblSalaireMoyen)
        Controls.Add(btnAjouter)
        Controls.Add(btnModifier)
        Controls.Add(btnSupprimer)
        Controls.Add(btnGenererPaie)
        Controls.Add(btnHistorique)
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        CType(dgvEmployes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
