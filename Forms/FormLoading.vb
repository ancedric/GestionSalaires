Imports System.Threading.Tasks

Public Class FormLoading
    Private ReadOnly _initializer As New DatabaseInitializerService()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub FormLoading_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            lblStatus.Text = "Vérification de la base de données..."
            Await Task.Run(Sub() _initializer.EnsureDatabaseAndTables())

            lblStatus.Text = "Initialisation terminée."
            Await Task.Delay(300)

            Dim login As New FormLogin()
            login.Show()
            Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur d'initialisation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub
End Class
