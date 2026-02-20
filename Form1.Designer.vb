<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Authentification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        MtbPassword = New MaskedTextBox()
        LbInscription = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        TxtbEmail = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Gothic Std B", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(228, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(391, 44)
        Label1.TabIndex = 0
        Label1.Text = "GESTIONNAIRE DE PAIE"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(MtbPassword)
        Panel1.Controls.Add(LbInscription)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TxtbEmail)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(69, 74)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(722, 341)
        Panel1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(111, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 9
        Label4.Text = "Mot de Passe"
        ' 
        ' MtbPassword
        ' 
        MtbPassword.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold)
        MtbPassword.Location = New Point(101, 194)
        MtbPassword.Name = "MtbPassword"
        MtbPassword.Size = New Size(529, 39)
        MtbPassword.TabIndex = 8
        ' 
        ' LbInscription
        ' 
        LbInscription.AutoSize = True
        LbInscription.Cursor = Cursors.Hand
        LbInscription.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        LbInscription.ForeColor = Color.Blue
        LbInscription.Location = New Point(410, 319)
        LbInscription.Name = "LbInscription"
        LbInscription.Size = New Size(54, 15)
        LbInscription.TabIndex = 7
        LbInscription.Text = "S'inscrire"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(271, 319)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 15)
        Label5.TabIndex = 6
        Label5.Text = "Nouvel administrateur ?"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(101, 259)
        Button1.Name = "Button1"
        Button1.Size = New Size(529, 41)
        Button1.TabIndex = 5
        Button1.Text = "SE CONNECTER"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(108, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 3
        Label3.Text = "Adresse email"
        ' 
        ' TxtbEmail
        ' 
        TxtbEmail.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtbEmail.Location = New Point(101, 118)
        TxtbEmail.Name = "TxtbEmail"
        TxtbEmail.Size = New Size(529, 39)
        TxtbEmail.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Adobe Gothic Std B", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(204, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(311, 26)
        Label2.TabIndex = 0
        Label2.Text = "CONNEXION ADMINISTRATEUR"
        ' 
        ' Authentification
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(858, 450)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Authentification"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Authentification"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtbEmail As TextBox
    Friend WithEvents LbInscription As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MtbPassword As MaskedTextBox

End Class
