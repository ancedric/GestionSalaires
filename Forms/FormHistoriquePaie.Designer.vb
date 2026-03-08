<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHistoriquePaie
    Inherits Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents dgvPaies As DataGridView
    Friend WithEvents btnVoirBulletin As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvPaies = New DataGridView()
        btnVoirBulletin = New Button()
        CType(dgvPaies, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        dgvPaies.Location = New Point(15, 15)
        dgvPaies.Size = New Size(760, 340)
        dgvPaies.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPaies.MultiSelect = False
        dgvPaies.ReadOnly = True
        btnVoirBulletin.Text = "Voir bulletin"
        btnVoirBulletin.Location = New Point(15, 365)
        btnVoirBulletin.Size = New Size(140, 30)
        ClientSize = New Size(790, 410)
        Controls.AddRange(New Control() {dgvPaies, btnVoirBulletin})
        StartPosition = FormStartPosition.CenterParent
        Text = "Historique des paies"
        CType(dgvPaies, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
