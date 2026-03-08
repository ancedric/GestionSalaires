<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAjouterEmploye
    Inherits Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents txtMatricule As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtPoste As TextBox
    Friend WithEvents numSalaireBase As NumericUpDown
    Friend WithEvents dtpDateEmbauche As DateTimePicker
    Friend WithEvents btnSave As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtMatricule = New TextBox()
        txtNom = New TextBox()
        txtPrenom = New TextBox()
        txtPoste = New TextBox()
        numSalaireBase = New NumericUpDown()
        dtpDateEmbauche = New DateTimePicker()
        btnSave = New Button()
        CType(numSalaireBase, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        Controls.Add(New Label() With {.Text = "Matricule", .Location = New Point(20, 20), .AutoSize = True})
        txtMatricule.Location = New Point(20, 40)
        Controls.Add(New Label() With {.Text = "Nom", .Location = New Point(20, 70), .AutoSize = True})
        txtNom.Location = New Point(20, 90)
        Controls.Add(New Label() With {.Text = "Prénom", .Location = New Point(20, 120), .AutoSize = True})
        txtPrenom.Location = New Point(20, 140)
        Controls.Add(New Label() With {.Text = "Poste", .Location = New Point(20, 170), .AutoSize = True})
        txtPoste.Location = New Point(20, 190)
        Controls.Add(New Label() With {.Text = "Salaire de base", .Location = New Point(20, 220), .AutoSize = True})
        numSalaireBase.Location = New Point(20, 240)
        numSalaireBase.Maximum = 1000000
        numSalaireBase.DecimalPlaces = 2
        Controls.Add(New Label() With {.Text = "Date d'embauche", .Location = New Point(20, 270), .AutoSize = True})
        dtpDateEmbauche.Location = New Point(20, 290)
        btnSave.Text = "Enregistrer"
        btnSave.Location = New Point(20, 330)
        btnSave.Size = New Size(250, 35)
        Controls.AddRange(New Control() {txtMatricule, txtNom, txtPrenom, txtPoste, numSalaireBase, dtpDateEmbauche, btnSave})
        ClientSize = New Size(300, 390)
        StartPosition = FormStartPosition.CenterParent
        Text = "Ajouter Employé"
        CType(numSalaireBase, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
