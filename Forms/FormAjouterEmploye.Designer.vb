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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(numSalaireBase, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtMatricule
        ' 
        txtMatricule.Location = New Point(163, 57)
        txtMatricule.Name = "txtMatricule"
        txtMatricule.Size = New Size(220, 23)
        txtMatricule.TabIndex = 6
        ' 
        ' txtNom
        ' 
        txtNom.Location = New Point(163, 97)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(220, 23)
        txtNom.TabIndex = 7
        ' 
        ' txtPrenom
        ' 
        txtPrenom.Location = New Point(163, 137)
        txtPrenom.Name = "txtPrenom"
        txtPrenom.Size = New Size(220, 23)
        txtPrenom.TabIndex = 8
        ' 
        ' txtPoste
        ' 
        txtPoste.Location = New Point(163, 176)
        txtPoste.Name = "txtPoste"
        txtPoste.Size = New Size(220, 23)
        txtPoste.TabIndex = 9
        ' 
        ' numSalaireBase
        ' 
        numSalaireBase.DecimalPlaces = 2
        numSalaireBase.Location = New Point(163, 215)
        numSalaireBase.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numSalaireBase.Name = "numSalaireBase"
        numSalaireBase.Size = New Size(220, 23)
        numSalaireBase.TabIndex = 10
        ' 
        ' dtpDateEmbauche
        ' 
        dtpDateEmbauche.Location = New Point(163, 261)
        dtpDateEmbauche.Name = "dtpDateEmbauche"
        dtpDateEmbauche.Size = New Size(220, 23)
        dtpDateEmbauche.TabIndex = 11
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(58, 330)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(325, 35)
        btnSave.TabIndex = 12
        btnSave.Text = "Enregistrer"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 13
        Label1.Text = "Matricule"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 14
        Label2.Text = "Nom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(58, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 15
        Label3.Text = "Prénom"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 16
        Label4.Text = "Poste"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(58, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 15)
        Label5.TabIndex = 17
        Label5.Text = "Salaire de base"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(58, 261)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 15)
        Label6.TabIndex = 18
        Label6.Text = "Date d'embauche"
        ' 
        ' FormAjouterEmploye
        ' 
        ClientSize = New Size(429, 390)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtMatricule)
        Controls.Add(txtNom)
        Controls.Add(txtPrenom)
        Controls.Add(txtPoste)
        Controls.Add(numSalaireBase)
        Controls.Add(dtpDateEmbauche)
        Controls.Add(btnSave)
        Name = "FormAjouterEmploye"
        StartPosition = FormStartPosition.CenterParent
        Text = "Ajouter Employé"
        CType(numSalaireBase, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
