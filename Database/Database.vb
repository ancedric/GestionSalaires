Imports System.Data.SqlClient

Public Module Database
    Private ReadOnly _server As String = "(localdb)\MSSQLLocalDB"
    Private ReadOnly _databaseName As String = "GestionSalairesDB"

    ' Connexion vers la base métier.
    Private ReadOnly _connectionString As String = $"Server={_server};Database={_databaseName};Integrated Security=true;TrustServerCertificate=True;"

    ' Connexion master pour les opérations de création/initialisation.
    Private ReadOnly _masterConnectionString As String = $"Server={_server};Database=master;Integrated Security=true;TrustServerCertificate=True;"

    Public ReadOnly Property DatabaseName As String
        Get
            Return _databaseName
        End Get
    End Property

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(_connectionString)
    End Function

    Public Function GetMasterConnection() As SqlConnection
        Return New SqlConnection(_masterConnectionString)
    End Function
End Module
