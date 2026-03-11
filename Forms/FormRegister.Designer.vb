<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
    Inherits Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents btnRegister As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnRegister = New Button()
        Panel1 = New Panel()
        txtNom = New TextBox()
        txtEmail = New TextBox()
        txtMotDePasse = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(65, 290)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(523, 32)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Enregistrer"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtNom)
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(txtMotDePasse)
        Panel1.Location = New Point(65, 67)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(523, 217)
        Panel1.TabIndex = 7
        ' 
        ' txtNom
        ' 
        txtNom.Location = New Point(24, 39)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(473, 23)
        txtNom.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(24, 94)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(473, 23)
        txtEmail.TabIndex = 7
        ' 
        ' txtMotDePasse
        ' 
        txtMotDePasse.Location = New Point(24, 155)
        txtMotDePasse.Name = "txtMotDePasse"
        txtMotDePasse.PasswordChar = "*"c
        txtMotDePasse.Size = New Size(473, 23)
        txtMotDePasse.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(177, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 25)
        Label1.TabIndex = 8
        Label1.Text = "INSCRIPTION ADMINISTRATEUR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 9
        Label2.Text = "Nom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 10
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 11
        Label4.Text = "Mot de passe"
        ' 
        ' FormRegister
        ' 
        ClientSize = New Size(663, 334)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(btnRegister)
        Name = "FormRegister"
        StartPosition = FormStartPosition.CenterParent
        Text = "Inscription admin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtMotDePasse As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
