<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label6 = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        Label8 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        TbPhone = New TextBox()
        TBEmail = New TextBox()
        LbConnecter = New Label()
        Label5 = New Label()
        BtnRegister = New Button()
        TxtbPhone = New TextBox()
        TxtbAdminName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(MaskedTextBox1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TbPhone)
        Panel1.Controls.Add(TBEmail)
        Panel1.Controls.Add(LbConnecter)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(BtnRegister)
        Panel1.Controls.Add(TxtbPhone)
        Panel1.Controls.Add(TxtbAdminName)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(67, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(722, 457)
        Panel1.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(112, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 19
        Label6.Text = "Poste"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold)
        MaskedTextBox1.Location = New Point(101, 313)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(529, 39)
        MaskedTextBox1.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(112, 243)
        Label8.Name = "Label8"
        Label8.Size = New Size(36, 15)
        Label8.TabIndex = 17
        Label8.Text = "Poste"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(112, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 15)
        Label4.TabIndex = 16
        Label4.Text = "Téléphone"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(112, 129)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 15)
        Label7.TabIndex = 15
        Label7.Text = "Adresse email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(112, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 15)
        Label3.TabIndex = 14
        Label3.Text = "Nom de l'administrateur"
        ' 
        ' TbPhone
        ' 
        TbPhone.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TbPhone.Location = New Point(101, 252)
        TbPhone.Name = "TbPhone"
        TbPhone.Size = New Size(529, 39)
        TbPhone.TabIndex = 10
        ' 
        ' TBEmail
        ' 
        TBEmail.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TBEmail.Location = New Point(101, 138)
        TBEmail.Name = "TBEmail"
        TBEmail.Size = New Size(529, 39)
        TBEmail.TabIndex = 8
        ' 
        ' LbConnecter
        ' 
        LbConnecter.AutoSize = True
        LbConnecter.Cursor = Cursors.Hand
        LbConnecter.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        LbConnecter.ForeColor = Color.Blue
        LbConnecter.Location = New Point(366, 426)
        LbConnecter.Name = "LbConnecter"
        LbConnecter.Size = New Size(75, 15)
        LbConnecter.TabIndex = 7
        LbConnecter.Text = "Se connecter"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(287, 426)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 6
        Label5.Text = "Déjà inscrit ?"
        ' 
        ' BtnRegister
        ' 
        BtnRegister.Cursor = Cursors.Hand
        BtnRegister.Location = New Point(101, 366)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(529, 41)
        BtnRegister.TabIndex = 5
        BtnRegister.Text = "S'ENREGISTRER"
        BtnRegister.UseVisualStyleBackColor = True
        ' 
        ' TxtbPhone
        ' 
        TxtbPhone.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtbPhone.Location = New Point(101, 195)
        TxtbPhone.Name = "TxtbPhone"
        TxtbPhone.Size = New Size(529, 39)
        TxtbPhone.TabIndex = 2
        ' 
        ' TxtbAdminName
        ' 
        TxtbAdminName.Font = New Font("Adobe Fan Heiti Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtbAdminName.Location = New Point(101, 82)
        TxtbAdminName.Name = "TxtbAdminName"
        TxtbAdminName.Size = New Size(529, 39)
        TxtbAdminName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Adobe Gothic Std B", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(204, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(319, 26)
        Label2.TabIndex = 0
        Label2.Text = "INSCRIPTION ADMINISTRATEUR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Gothic Std B", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(236, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(391, 44)
        Label1.TabIndex = 2
        Label1.Text = "GESTIONNAIRE DE PAIE"
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(856, 539)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "SignUp"
        Padding = New Padding(10, 0, 0, 0)
        Text = "SignUp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbPhone As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents LbConnecter As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnRegister As Button
    Friend WithEvents TxtbPhone As TextBox
    Friend WithEvents TxtbAdminName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
