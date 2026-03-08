<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCalculSalaire
    Inherits Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents numBase As NumericUpDown
    Friend WithEvents numPrimes As NumericUpDown
    Friend WithEvents numHeuresSup As NumericUpDown
    Friend WithEvents numRetenues As NumericUpDown
    Friend WithEvents lblBrut As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents numMois As NumericUpDown
    Friend WithEvents numAnnee As NumericUpDown
    Friend WithEvents btnCalculer As Button
    Friend WithEvents btnEnregistrer As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        numBase = New NumericUpDown()
        numPrimes = New NumericUpDown()
        numHeuresSup = New NumericUpDown()
        numRetenues = New NumericUpDown()
        lblBrut = New Label()
        lblNet = New Label()
        numMois = New NumericUpDown()
        numAnnee = New NumericUpDown()
        btnCalculer = New Button()
        btnEnregistrer = New Button()
        For Each n In New NumericUpDown() {numBase, numPrimes, numHeuresSup, numRetenues, numMois, numAnnee}
            CType(n, ComponentModel.ISupportInitialize).BeginInit()
        Next
        SuspendLayout()
        SetupNum(numBase, 20, 30, 1000000, 2)
        SetupNum(numPrimes, 20, 80, 1000000, 2)
        SetupNum(numHeuresSup, 20, 130, 1000000, 2)
        SetupNum(numRetenues, 20, 180, 1000000, 2)
        SetupNum(numMois, 20, 230, 12, 0)
        numMois.Minimum = 1
        SetupNum(numAnnee, 160, 230, 2100, 0)
        numAnnee.Minimum = 2000
        numAnnee.Value = DateTime.Now.Year
        Controls.Add(New Label() With {.Text = "Salaire Base", .Location = New Point(20, 10), .AutoSize = True})
        Controls.Add(New Label() With {.Text = "Primes", .Location = New Point(20, 60), .AutoSize = True})
        Controls.Add(New Label() With {.Text = "Heures Sup", .Location = New Point(20, 110), .AutoSize = True})
        Controls.Add(New Label() With {.Text = "Retenues", .Location = New Point(20, 160), .AutoSize = True})
        Controls.Add(New Label() With {.Text = "Mois", .Location = New Point(20, 210), .AutoSize = True})
        Controls.Add(New Label() With {.Text = "Année", .Location = New Point(160, 210), .AutoSize = True})
        lblBrut.Location = New Point(20, 270)
        lblBrut.AutoSize = True
        lblBrut.Text = "Salaire Brut : 0"
        lblNet.Location = New Point(20, 290)
        lblNet.AutoSize = True
        lblNet.Text = "Salaire Net : 0"
        btnCalculer.Text = "Calculer"
        btnCalculer.Location = New Point(20, 320)
        btnEnregistrer.Text = "Enregistrer"
        btnEnregistrer.Location = New Point(140, 320)
        Controls.AddRange(New Control() {numBase, numPrimes, numHeuresSup, numRetenues, numMois, numAnnee, lblBrut, lblNet, btnCalculer, btnEnregistrer})
        ClientSize = New Size(320, 380)
        StartPosition = FormStartPosition.CenterParent
        Text = "Calcul Salaire"
        For Each n In New NumericUpDown() {numBase, numPrimes, numHeuresSup, numRetenues, numMois, numAnnee}
            CType(n, ComponentModel.ISupportInitialize).EndInit()
        Next
        ResumeLayout(False)
    End Sub

    Private Sub SetupNum(ctrl As NumericUpDown, x As Integer, y As Integer, max As Decimal, decimals As Integer)
        ctrl.Location = New Point(x, y)
        ctrl.Maximum = max
        ctrl.DecimalPlaces = decimals
        ctrl.Size = New Size(120, 23)
    End Sub
End Class
