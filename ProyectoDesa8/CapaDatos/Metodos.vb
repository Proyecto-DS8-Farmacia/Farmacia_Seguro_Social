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

    Public Shared Function REGISTRARPACIENTE(cedula As String, nombre As String, apellido As String, carne_salud As String, fvence_Cs As String,
                                             beneficiario As String, ced_familiar As String, correo As String, contraseña As String, telefono As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Pa_Registro_paciente", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@cedula", cedula)
                CMD.Parameters.AddWithValue("@nombre", nombre)
                CMD.Parameters.AddWithValue("@apellido", apellido)
                CMD.Parameters.AddWithValue("@carne_salud ", carne_salud)
                CMD.Parameters.AddWithValue("@fvence_cs", fvence_Cs)
                CMD.Parameters.AddWithValue("@beneficiario", beneficiario)
                CMD.Parameters.AddWithValue("@f_principal", ced_familiar)
                CMD.Parameters.AddWithValue("@correo_e", correo)
                CMD.Parameters.AddWithValue("@contraseña ", contraseña)
                CMD.Parameters.AddWithValue("@telefono", telefono)

                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using

    End Function

    Public Shared Function INICIAR_SESIONPACIENTE(CORREO As String, CONTRASEÑA As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Pa_Login_paciente", CN)
                CMD.CommandType = CommandType.StoredProcedure
                'CMD.Parameters.AddWithValue("@ENSQLSERVER", ENVISUALSTUDIO)
                CMD.Parameters.AddWithValue("@CORREO_E", CORREO)
                CMD.Parameters.AddWithValue("@CONTRASEÑA", CONTRASEÑA)
                CN.Open()
                Return CMD.ExecuteReader().HasRows.ToString

            End Using
        End Using

    End Function

    Public Shared Function HISTORIALRECETAPACIENTE(CORREO As String) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Pa_HistorialR_paciente  '" & CORREO & "'", CN)
                ' Using DA As New SqlDataAdapter("Pa_HistorialR_paciente ", CN)
                Using TABLA As New DataTable
                    Try
                        DA.Fill(TABLA)
                    Catch ex As Exception
                        MsgBox("Error: " & ex.ToString)
                    End Try

                    Return TABLA
                End Using
            End Using
        End Using
    End Function

End Class
