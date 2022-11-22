Public Class USUARIO


    Public Function USUARIO_LOGIN(ByVal Correo As String, ByVal Contraseña As String) As Boolean
        Dim OUSUARIO As New CapaDatos.Usuario
        Return OUSUARIO.USUARIO_LOGIN(Correo, Contraseña)

    End Function
End Class
