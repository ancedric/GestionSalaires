<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        LblUsername = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        BtnBulletin = New Button()
        BtnSalaire = New Button()
        BtnAddEmploye = New Button()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LblUsername)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(16, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(826, 44)
        Panel1.TabIndex = 2
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Location = New Point(595, 20)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(41, 15)
        LblUsername.TabIndex = 3
        LblUsername.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Gothic Std B", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(3, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 26)
        Label1.TabIndex = 2
        Label1.Text = "GESTIONNAIRE DE PAIE"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(BtnBulletin)
        Panel2.Controls.Add(BtnSalaire)
        Panel2.Controls.Add(BtnAddEmploye)
        Panel2.Location = New Point(15, 64)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(827, 54)
        Panel2.TabIndex = 3
        ' 
        ' BtnBulletin
        ' 
        BtnBulletin.Location = New Point(596, 7)
        BtnBulletin.Name = "BtnBulletin"
        BtnBulletin.Size = New Size(210, 39)
        BtnBulletin.TabIndex = 2
        BtnBulletin.Text = "Bulletins de Paie"
        BtnBulletin.UseVisualStyleBackColor = True
        ' 
        ' BtnSalaire
        ' 
        BtnSalaire.Location = New Point(308, 7)
        BtnSalaire.Name = "BtnSalaire"
        BtnSalaire.Size = New Size(210, 39)
        BtnSalaire.TabIndex = 1
        BtnSalaire.Text = "Gérer les Salaires"
        BtnSalaire.UseVisualStyleBackColor = True
        ' 
        ' BtnAddEmploye
        ' 
        BtnAddEmploye.Location = New Point(20, 8)
        BtnAddEmploye.Name = "BtnAddEmploye"
        BtnAddEmploye.Size = New Size(210, 38)
        BtnAddEmploye.TabIndex = 0
        BtnAddEmploye.Text = "Ajouter Nouvel Employé"
        BtnAddEmploye.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(17, 159)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(827, 335)
        Panel3.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(5, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(820, 332)
        DataGridView1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(35, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 20)
        Label2.TabIndex = 5
        Label2.Text = "LISTE DES SALARIES"
        ' 
        ' Accueil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(857, 519)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Accueil"
        Text = "Accueil"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnBulletin As Button
    Friend WithEvents BtnSalaire As Button
    Friend WithEvents BtnAddEmploye As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
End Class
