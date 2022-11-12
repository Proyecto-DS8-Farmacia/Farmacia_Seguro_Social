Imports System.Data.SqlClient

Public Class Metodos
    Public Shared Function LISTARSUSTANCIASPORFARMACIA() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Pa_ListarTablaSustanciaPorNombreFarmacia", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using
    End Function

    Public Shared Function INICIAR_SESION(CORREO As String, CONTRASEÑA As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("inicio_sesion", CN)
                CMD.CommandType = CommandType.StoredProcedure
                'CMD.Parameters.AddWithValue("@ENSQLSERVER", ENVISUALSTUDIO)
                CMD.Parameters.AddWithValue("@CORREO_E", CORREO)
                CMD.Parameters.AddWithValue("@CONTRASEÑA", CONTRASEÑA)
                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString

            End Using
        End Using

    End Function


End Class
