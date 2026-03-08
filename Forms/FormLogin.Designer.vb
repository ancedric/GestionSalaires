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
        lblTitre.Text = "Connexion Administrateur"
        lblTitre.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        lblTitre.Location = New Point(70, 20)
        lblTitre.AutoSize = True
        lblEmail.Text = "Email"
        lblEmail.Location = New Point(35, 80)
        txtEmail.Location = New Point(35, 100)
        txtEmail.Size = New Size(300, 23)
        lblMotDePasse.Text = "Mot de passe"
        lblMotDePasse.Location = New Point(35, 140)
        txtMotDePasse.Location = New Point(35, 160)
        txtMotDePasse.Size = New Size(300, 23)
        txtMotDePasse.PasswordChar = "*"c
        btnConnexion.Text = "Se connecter"
        btnConnexion.Location = New Point(35, 205)
        btnConnexion.Size = New Size(300, 32)
        btnInscription.Text = "Créer un compte admin"
        btnInscription.Location = New Point(35, 245)
        btnInscription.Size = New Size(300, 30)
        ClientSize = New Size(380, 300)
        Controls.AddRange(New Control() {lblTitre, lblEmail, txtEmail, lblMotDePasse, txtMotDePasse, btnConnexion, btnInscription})
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
