Imports System.Data
Imports System.Data.SqlClient

Public Class EmployeService
    Public Function GetAllEmployes(Optional recherche As String = "") As DataTable
        Dim dt As New DataTable()
        Dim sql As String = "SELECT IdEmploye, Matricule, Nom, Prenom, Poste, SalaireBase, DateEmbauche FROM Employes"

        If Not String.IsNullOrWhiteSpace(recherche) Then
            sql &= " WHERE Nom LIKE @Recherche OR Matricule LIKE @Recherche OR Poste LIKE @Recherche"
        End If

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    If Not String.IsNullOrWhiteSpace(recherche) Then
                        cmd.Parameters.AddWithValue("@Recherche", "%" & recherche & "%")
                    End If

                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors du chargement des employés.", ex)
        End Try

        Return dt
    End Function

    Public Function AddEmploye(emp As Employe) As Boolean
        Const sql As String = "INSERT INTO Employes (Matricule, Nom, Prenom, Poste, SalaireBase, DateEmbauche) VALUES (@Matricule, @Nom, @Prenom, @Poste, @SalaireBase, @DateEmbauche)"

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    BindEmployeParams(cmd, emp)
                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors de l'ajout de l'employé.", ex)
        End Try
    End Function

    Public Function UpdateEmploye(emp As Employe) As Boolean
        Const sql As String = "UPDATE Employes SET Matricule=@Matricule, Nom=@Nom, Prenom=@Prenom, Poste=@Poste, SalaireBase=@SalaireBase, DateEmbauche=@DateEmbauche WHERE IdEmploye=@IdEmploye"

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    BindEmployeParams(cmd, emp)
                    cmd.Parameters.AddWithValue("@IdEmploye", emp.IdEmploye)
                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors de la mise à jour de l'employé.", ex)
        End Try
    End Function

    Public Function DeleteEmploye(idEmploye As Integer) As Boolean
        Const sql As String = "DELETE FROM Employes WHERE IdEmploye=@IdEmploye"

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@IdEmploye", idEmploye)
                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors de la suppression de l'employé.", ex)
        End Try
    End Function

    Public Function GetStatistiques() As (TotalEmployes As Integer, MasseSalariale As Decimal, SalaireMoyen As Decimal)
        Const sql As String = "SELECT COUNT(*) AS TotalEmployes, ISNULL(SUM(SalaireBase),0) AS MasseSalariale, ISNULL(AVG(SalaireBase),0) AS SalaireMoyen FROM Employes"

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    conn.Open()
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return (
                                CInt(reader("TotalEmployes")),
                                CDec(reader("MasseSalariale")),
                                CDec(reader("SalaireMoyen"))
                            )
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors du calcul des statistiques.", ex)
        End Try

        Return (0, 0D, 0D)
    End Function

    Private Sub BindEmployeParams(cmd As SqlCommand, emp As Employe)
        cmd.Parameters.AddWithValue("@Matricule", emp.Matricule)
        cmd.Parameters.AddWithValue("@Nom", emp.Nom)
        cmd.Parameters.AddWithValue("@Prenom", emp.Prenom)
        cmd.Parameters.AddWithValue("@Poste", emp.Poste)
        cmd.Parameters.AddWithValue("@SalaireBase", emp.SalaireBase)
        cmd.Parameters.AddWithValue("@DateEmbauche", emp.DateEmbauche.Date)
    End Sub
End Class
