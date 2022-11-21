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

    Public Shared Function INICIAR_SESION(CORREO As String, CONTRASEÑA As String, TIPO As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("inicio_sesionB", CN)
                CMD.CommandType = CommandType.StoredProcedure
                'CMD.Parameters.AddWithValue("@ENSQLSERVER", ENVISUALSTUDIO)
                CMD.Parameters.AddWithValue("@CORREO_E", CORREO)
                CMD.Parameters.AddWithValue("@CONTRASEÑA", CONTRASEÑA)
                CMD.Parameters.AddWithValue("@TIPO", TIPO)
                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString

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


    Public Shared Function ActualizarUSUARIO(cedula As String, nombre As String, apellido As String, correo As String, telefono As String, farmacia As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Pa_Actualizar", CN)
                CMD.CommandType = CommandType.StoredProcedure
                'CMD.Parameters.AddWithValue("@ENSQLSERVER", ENVISUALSTUDIO)
                CMD.Parameters.AddWithValue("@Cedula", cedula)
                CMD.Parameters.AddWithValue("@nombre", nombre)
                CMD.Parameters.AddWithValue("@apellido", apellido)
                CMD.Parameters.AddWithValue("@telefono", telefono)
                CMD.Parameters.AddWithValue("@correo", correo)
                CMD.Parameters.AddWithValue("@farma", farmacia)
                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString

            End Using
        End Using



    End Function

    Public Shared Function RegistrarUsuario(cedula As String, nombre As String, apellido As String, correo As String, telefono As String, contraseña As String, tipo As String, farmacia As Integer) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Registrar", CN)
                CMD.CommandType = CommandType.StoredProcedure
                'CMD.Parameters.AddWithValue("@ENSQLSERVER", ENVISUALSTUDIO)
                CMD.Parameters.AddWithValue("@Cedula", cedula)
                CMD.Parameters.AddWithValue("@nombre", nombre)
                CMD.Parameters.AddWithValue("@apellido", apellido)
                CMD.Parameters.AddWithValue("@telefono", telefono)
                CMD.Parameters.AddWithValue("@correo", correo)
                CMD.Parameters.AddWithValue("@Contraseña", contraseña)
                CMD.Parameters.AddWithValue("@tipo", tipo)
                CMD.Parameters.AddWithValue("@farma", farmacia)

                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString

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
