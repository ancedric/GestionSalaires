<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLoading
    Inherits Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents progressInit As ProgressBar

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitre = New Label()
        lblStatus = New Label()
        progressInit = New ProgressBar()
        SuspendLayout()
        lblTitre.AutoSize = True
        lblTitre.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        lblTitre.Location = New Point(38, 24)
        lblTitre.Text = "Gestionnaire de Paie"
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(38, 74)
        lblStatus.Text = "Initialisation en cours..."
        progressInit.Location = New Point(38, 102)
        progressInit.Size = New Size(330, 22)
        progressInit.Style = ProgressBarStyle.Marquee
        progressInit.MarqueeAnimationSpeed = 30
        ClientSize = New Size(410, 160)
        Controls.AddRange(New Control() {lblTitre, lblStatus, progressInit})
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chargement"
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
