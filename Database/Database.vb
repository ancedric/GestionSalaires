Imports System.Data.SqlClient

Public Module Database
    ' Adaptez la source selon votre environnement : (localdb)\MSSQLLocalDB ou .\SQLEXPRESS
    Private ReadOnly _connectionString As String = "Server=(localdb)\MSSQLLocalDB;Database=GestionSalairesDB;Integrated Security=true;TrustServerCertificate=True;"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(_connectionString)
    End Function
End Module
