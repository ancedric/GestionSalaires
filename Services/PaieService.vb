Imports System.Data
Imports System.Data.SqlClient

Public Class PaieService
    Public Function CalculerSalaire(baseSalaire As Decimal, primes As Decimal, heuresSup As Decimal, retenues As Decimal) As (Brut As Decimal, Net As Decimal)
        Dim brut = baseSalaire + primes + heuresSup
        Dim net = brut - retenues
        Return (brut, net)
    End Function

    Public Function EnregistrerPaie(p As Paie) As Boolean
        Const sql As String = "INSERT INTO Paie (IdEmploye, Mois, Annee, SalaireBase, Primes, HeuresSup, Retenues, SalaireBrut, SalaireNet, DateGeneration) VALUES (@IdEmploye, @Mois, @Annee, @SalaireBase, @Primes, @HeuresSup, @Retenues, @SalaireBrut, @SalaireNet, @DateGeneration)"

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@IdEmploye", p.IdEmploye)
                    cmd.Parameters.AddWithValue("@Mois", p.Mois)
                    cmd.Parameters.AddWithValue("@Annee", p.Annee)
                    cmd.Parameters.AddWithValue("@SalaireBase", p.SalaireBase)
                    cmd.Parameters.AddWithValue("@Primes", p.Primes)
                    cmd.Parameters.AddWithValue("@HeuresSup", p.HeuresSup)
                    cmd.Parameters.AddWithValue("@Retenues", p.Retenues)
                    cmd.Parameters.AddWithValue("@SalaireBrut", p.SalaireBrut)
                    cmd.Parameters.AddWithValue("@SalaireNet", p.SalaireNet)
                    cmd.Parameters.AddWithValue("@DateGeneration", p.DateGeneration)
                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors de l'enregistrement de la paie.", ex)
        End Try
    End Function

    Public Function GetHistoriquePaies() As DataTable
        Const sql As String = "SELECT p.IdPaie, p.IdEmploye, e.Matricule, e.Nom, e.Prenom, p.Mois, p.Annee, p.SalaireBrut, p.Retenues, p.SalaireNet, p.DateGeneration FROM Paie p INNER JOIN Employes e ON p.IdEmploye = e.IdEmploye ORDER BY p.Annee DESC, p.Mois DESC"
        Dim dt As New DataTable()

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors du chargement de l'historique des paies.", ex)
        End Try

        Return dt
    End Function

    Public Function GetPaieById(idPaie As Integer) As DataRow
        Const sql As String = "SELECT p.*, e.Matricule, e.Nom, e.Prenom, e.Poste FROM Paie p INNER JOIN Employes e ON p.IdEmploye = e.IdEmploye WHERE p.IdPaie=@IdPaie"
        Dim dt As New DataTable()

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@IdPaie", idPaie)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors du chargement du bulletin.", ex)
        End Try

        If dt.Rows.Count = 0 Then Return Nothing
        Return dt.Rows(0)
    End Function
End Class
