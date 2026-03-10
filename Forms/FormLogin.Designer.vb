<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblMotDePasse As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtMotDePasse As TextBox
    Friend WithEvents btnConnexion As Button
    Friend WithEvents btnInscription As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitre = New Label()
        lblEmail = New Label()
        lblMotDePasse = New Label()
        txtEmail = New TextBox()
        txtMotDePasse = New TextBox()
        btnConnexion = New Button()
        btnInscription = New Button()
        SuspendLayout()
        ' 
        ' lblTitre
        ' 
        lblTitre.AutoSize = True
        lblTitre.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTitre.Location = New Point(70, 20)
        lblTitre.Name = "lblTitre"
        lblTitre.Size = New Size(249, 25)
        lblTitre.TabIndex = 0
        lblTitre.Text = "Connexion Administrateur"
        ' 
        ' lblEmail
        ' 
        lblEmail.Location = New Point(44, 91)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 16)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblMotDePasse
        ' 
        lblMotDePasse.Location = New Point(44, 149)
        lblMotDePasse.Name = "lblMotDePasse"
        lblMotDePasse.Size = New Size(80, 19)
        lblMotDePasse.TabIndex = 3
        lblMotDePasse.Text = "Mot de passe"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(35, 100)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(300, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtMotDePasse
        ' 
        txtMotDePasse.Location = New Point(35, 160)
        txtMotDePasse.Name = "txtMotDePasse"
        txtMotDePasse.PasswordChar = "*"c
        txtMotDePasse.Size = New Size(300, 23)
        txtMotDePasse.TabIndex = 4
        ' 
        ' btnConnexion
        ' 
        btnConnexion.Location = New Point(35, 205)
        btnConnexion.Name = "btnConnexion"
        btnConnexion.Size = New Size(300, 32)
        btnConnexion.TabIndex = 5
        btnConnexion.Text = "Se connecter"
        ' 
        ' btnInscription
        ' 
        btnInscription.Location = New Point(35, 245)
        btnInscription.Name = "btnInscription"
        btnInscription.Size = New Size(300, 30)
        btnInscription.TabIndex = 6
        btnInscription.Text = "Créer un compte admin"
        ' 
        ' FormLogin
        ' 
        ClientSize = New Size(380, 300)
        Controls.Add(lblTitre)
        Controls.Add(lblEmail)
        Controls.Add(txtEmail)
        Controls.Add(lblMotDePasse)
        Controls.Add(txtMotDePasse)
        Controls.Add(btnConnexion)
        Controls.Add(btnInscription)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
