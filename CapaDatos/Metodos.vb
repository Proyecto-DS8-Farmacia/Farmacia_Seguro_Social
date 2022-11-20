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


    Public Shared Function FARMACIA() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Pa_Farmacia", CN)
                Using Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using
    End Function

    Public Shared Function FARMACIA_SUSTANCIA() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Pa_ProveedoresPorFarmacia", CN)
                Using Data As New DataTable
                    DA.Fill(Data)

                    Return Data
                End Using
            End Using
        End Using
    End Function

    Public Shared Function PROVEEDOR() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Pa_Proveedor", CN)
                Using Data As New DataTable
                    DA.Fill(Data)

                    Return Data
                End Using
            End Using
        End Using
    End Function

    Public Shared Function RESTOCK(codf As Integer, cods As Integer, cants As Integer)

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Pa_ReStock", CN)
                CMD.Parameters.AddWithValue("@cf", codf)
                CMD.Parameters.AddWithValue("@cs", cods)
                CMD.Parameters.AddWithValue("@cants", cants)

                Try
                    If CN.State = ConnectionState.Closed Then
                        CN.Open()
                    End If
                    CMD.ExecuteNonQuery()
                Catch ex As Exception
                End Try
                CN.Close()
            End Using
        End Using
    End Function

End Class

