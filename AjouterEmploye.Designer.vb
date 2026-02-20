<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterEmploye
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
        Label1 = New Label()
        Panel2 = New Panel()
        GroupBox1 = New GroupBox()
        TxtBNomEmploye = New TextBox()
        TxtBTelEmploye = New TextBox()
        Label = New Label()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        Label4 = New Label()
        TxtBSalireEmploye = New TextBox()
        TxtBPosteEmploye = New TextBox()
        Label5 = New Label()
        TxtBDatePaiement = New TextBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(7, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(557, 48)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Gothic Std B", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(186, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 30)
        Label1.TabIndex = 0
        Label1.Text = "Ajouter Employé"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(GroupBox2)
        Panel2.Controls.Add(GroupBox1)
        Panel2.Location = New Point(7, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(557, 455)
        Panel2.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label)
        GroupBox1.Controls.Add(TxtBTelEmploye)
        GroupBox1.Controls.Add(TxtBNomEmploye)
        GroupBox1.Location = New Point(40, 20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(477, 142)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informations Personnelles"
        ' 
        ' TxtBNomEmploye
        ' 
        TxtBNomEmploye.Location = New Point(33, 47)
        TxtBNomEmploye.Name = "TxtBNomEmploye"
        TxtBNomEmploye.Size = New Size(409, 23)
        TxtBNomEmploye.TabIndex = 0
        ' 
        ' TxtBTelEmploye
        ' 
        TxtBTelEmploye.Location = New Point(33, 103)
        TxtBTelEmploye.Name = "TxtBTelEmploye"
        TxtBTelEmploye.Size = New Size(409, 23)
        TxtBTelEmploye.TabIndex = 1
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(41, 26)
        Label.Name = "Label"
        Label.Size = New Size(105, 15)
        Label.TabIndex = 2
        Label.Text = "Nom de l'employé"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 15)
        Label3.TabIndex = 3
        Label3.Text = "Numéro de téléphone de l'employé"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(TxtBDatePaiement)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(TxtBSalireEmploye)
        GroupBox2.Controls.Add(TxtBPosteEmploye)
        GroupBox2.Location = New Point(40, 168)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(477, 201)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Informations Professionnelles"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 15)
        Label2.TabIndex = 3
        Label2.Text = "Salaire de base de l'employé"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 15)
        Label4.TabIndex = 2
        Label4.Text = "Poste de l'employé"
        ' 
        ' TxtBSalireEmploye
        ' 
        TxtBSalireEmploye.Location = New Point(33, 103)
        TxtBSalireEmploye.Name = "TxtBSalireEmploye"
        TxtBSalireEmploye.Size = New Size(409, 23)
        TxtBSalireEmploye.TabIndex = 1
        ' 
        ' TxtBPosteEmploye
        ' 
        TxtBPosteEmploye.Location = New Point(33, 47)
        TxtBPosteEmploye.Name = "TxtBPosteEmploye"
        TxtBPosteEmploye.Size = New Size(409, 23)
        TxtBPosteEmploye.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 15)
        Label5.TabIndex = 5
        Label5.Text = "Date de paiement de l'employé"
        ' 
        ' TxtBDatePaiement
        ' 
        TxtBDatePaiement.Location = New Point(33, 159)
        TxtBDatePaiement.Name = "TxtBDatePaiement"
        TxtBDatePaiement.Size = New Size(409, 23)
        TxtBDatePaiement.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(73, 388)
        Button1.Name = "Button1"
        Button1.Size = New Size(409, 29)
        Button1.TabIndex = 5
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AjouterEmploye
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(576, 535)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "AjouterEmploye"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ajouter Employe"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label As Label
    Friend WithEvents TxtBTelEmploye As TextBox
    Friend WithEvents TxtBNomEmploye As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBDatePaiement As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBSalireEmploye As TextBox
    Friend WithEvents TxtBPosteEmploye As TextBox
    Friend WithEvents Button1 As Button
End Class
