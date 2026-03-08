Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class AuthService
    Public Function RegisterAdmin(nom As String, email As String, motDePasse As String) As Boolean
        Const sql As String = "INSERT INTO Administrateurs (Nom, Email, MotDePasse) VALUES (@Nom, @Email, @MotDePasse)"

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Nom", nom)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@MotDePasse", HashPassword(motDePasse))

                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors de l'inscription administrateur.", ex)
        End Try
    End Function

    Public Function Login(email As String, motDePasse As String) As Admin
        Const sql As String = "SELECT IdAdmin, Nom, Email, MotDePasse FROM Administrateurs WHERE Email = @Email"

        Try
            Using conn = Database.GetConnection()
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Email", email)
                    conn.Open()

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim storedHash = reader("MotDePasse").ToString()
                            Dim inputHash = HashPassword(motDePasse)

                            If String.Equals(storedHash, inputHash, StringComparison.OrdinalIgnoreCase) Then
                                Return New Admin With {
                                    .IdAdmin = CInt(reader("IdAdmin")),
                                    .Nom = reader("Nom").ToString(),
                                    .Email = reader("Email").ToString(),
                                    .MotDePasse = storedHash
                                }
                            End If
                        End If
                    End Using
                End Using
            End Using

            Return Nothing
        Catch ex As Exception
            Throw New ApplicationException("Erreur lors de la connexion.", ex)
        End Try
    End Function

    Public Shared Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim hash = sha.ComputeHash(bytes)
            Return Convert.ToHexString(hash)
        End Using
    End Function
End Class
