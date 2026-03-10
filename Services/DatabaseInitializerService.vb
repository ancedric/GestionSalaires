Imports System.Data.SqlClient

Public Class DatabaseInitializerService
    Public Sub EnsureDatabaseAndTables()
        Try
            EnsureDatabaseExists()
            EnsureTablesAndIndexes()
        Catch ex As Exception
            Throw New ApplicationException("Erreur pendant l'initialisation de la base de données.", ex)
        End Try
    End Sub

    Private Sub EnsureDatabaseExists()
        Dim sql As String = $"
IF DB_ID('{Database.DatabaseName}') IS NULL
BEGIN
    CREATE DATABASE [{Database.DatabaseName}]
END"

        Using conn = Database.GetMasterConnection()
            Using cmd As New SqlCommand(sql, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub EnsureTablesAndIndexes()
        Const sql As String = "
IF OBJECT_ID('dbo.Administrateurs', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Administrateurs (
        IdAdmin INT IDENTITY(1,1) PRIMARY KEY,
        Nom NVARCHAR(100) NOT NULL,
        Email NVARCHAR(150) NOT NULL UNIQUE,
        MotDePasse NVARCHAR(256) NOT NULL
    )
END

IF OBJECT_ID('dbo.Employes', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Employes (
        IdEmploye INT IDENTITY(1,1) PRIMARY KEY,
        Matricule NVARCHAR(50) NOT NULL UNIQUE,
        Nom NVARCHAR(100) NOT NULL,
        Prenom NVARCHAR(100) NOT NULL,
        Poste NVARCHAR(100) NOT NULL,
        SalaireBase DECIMAL(18,2) NOT NULL,
        DateEmbauche DATE NOT NULL
    )
END

IF OBJECT_ID('dbo.Paie', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Paie (
        IdPaie INT IDENTITY(1,1) PRIMARY KEY,
        IdEmploye INT NOT NULL,
        Mois INT NOT NULL,
        Annee INT NOT NULL,
        SalaireBase DECIMAL(18,2) NOT NULL,
        Primes DECIMAL(18,2) NOT NULL,
        HeuresSup DECIMAL(18,2) NOT NULL,
        Retenues DECIMAL(18,2) NOT NULL,
        SalaireBrut DECIMAL(18,2) NOT NULL,
        SalaireNet DECIMAL(18,2) NOT NULL,
        DateGeneration DATETIME NOT NULL DEFAULT GETDATE(),
        CONSTRAINT FK_Paie_Employes FOREIGN KEY (IdEmploye) REFERENCES dbo.Employes(IdEmploye)
    )
END

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name='IX_Employes_Matricule' AND object_id = OBJECT_ID('dbo.Employes'))
BEGIN
    CREATE INDEX IX_Employes_Matricule ON dbo.Employes(Matricule)
END

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name='IX_Paie_IdEmploye_Mois_Annee' AND object_id = OBJECT_ID('dbo.Paie'))
BEGIN
    CREATE INDEX IX_Paie_IdEmploye_Mois_Annee ON dbo.Paie(IdEmploye, Mois, Annee)
END"

        Using conn = Database.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
