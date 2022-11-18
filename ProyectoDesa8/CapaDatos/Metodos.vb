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






    Public Shared Function DATOSPACIENTEPORNOMBRE() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Pa_DatosDePacientePorNombre", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)
                    Return TABLA
                End Using
            End Using
        End Using
    End Function

    Public Shared Function DATOSDEUSUARIO() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Pa_ListarDatosDeUsuario", CN)
                Using Data As New DataTable
                    DA.Fill(Data)
                    Return Data
                End Using
            End Using
        End Using
    End Function


    Public Shared Function ActualizarUSUARIO(cedula As String, nombre As String, apellido As String, correo As String, telefono As String, farmacia As String) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter(" Pa_Actualizar '" + cedula + "','" + nombre + "','" + apellido + "','" + correo + "','" + telefono + "','" + farmacia + "'", CN)
                Using Data As New DataTable
                    DA.Fill(Data)
                    Return Data
                End Using
            End Using
        End Using
    End Function

    Public Shared Function FARMACIAS() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select nombre from farmacia", CN)
                Using Data As New DataTable
                    DA.Fill(Data)

                    Return Data
                End Using
            End Using
        End Using
    End Function

    Public Shared Function TIPOSDEUSUARIO() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select DISTINCT tipo from Usuario ", CN)
                Using Data As New DataTable
                    DA.Fill(Data)
                    Return Data
                End Using
            End Using
        End Using
    End Function



End Class
