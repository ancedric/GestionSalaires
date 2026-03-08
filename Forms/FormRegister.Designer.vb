<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
    Inherits Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtMotDePasse As TextBox
    Friend WithEvents btnRegister As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNom = New TextBox()
        txtEmail = New TextBox()
        txtMotDePasse = New TextBox()
        btnRegister = New Button()
        SuspendLayout()
        Controls.Add(New Label() With {.Text = "Nom", .Location = New Point(20, 20), .AutoSize = True})
        txtNom.Location = New Point(20, 40)
        txtNom.Size = New Size(280, 23)
        Controls.Add(New Label() With {.Text = "Email", .Location = New Point(20, 75), .AutoSize = True})
        txtEmail.Location = New Point(20, 95)
        txtEmail.Size = New Size(280, 23)
        Controls.Add(New Label() With {.Text = "Mot de passe", .Location = New Point(20, 130), .AutoSize = True})
        txtMotDePasse.Location = New Point(20, 150)
        txtMotDePasse.Size = New Size(280, 23)
        txtMotDePasse.PasswordChar = "*"c
        btnRegister.Text = "Enregistrer"
        btnRegister.Location = New Point(20, 190)
        btnRegister.Size = New Size(280, 32)
        Controls.AddRange(New Control() {txtNom, txtEmail, txtMotDePasse, btnRegister})
        ClientSize = New Size(330, 250)
        StartPosition = FormStartPosition.CenterParent
        Text = "Inscription admin"
        ResumeLayout(False)
    End Sub
End Class
