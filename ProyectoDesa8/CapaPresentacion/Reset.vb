Imports System.Data
Imports System.Data.SqlClient
Public Class Reset
    Dim username As String = Form2.toUser
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        If (txtVerPass.Text.Equals(txtVerNewPass.Text)) Then


            If (CapaDatos.Metodos.BUSCAR_CORREO_USUARIO(username)) Then
                Dim con As SqlConnection = New SqlConnection("Data Source=MICHELLEANAYA;Initial Catalog=Proyecto_Final_Desa8;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[Usuario]
   SET [correo_e] = '" + username + "',
      [contraseña] = '" + txtVerNewPass.Text + "'
 WHERE [correo_e] ='" + username + "' ", con)
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("contraseña recuperada completado ", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()


            ElseIf (CapaDatos.Metodos.BUSCAR_CORREO_PACIENTE(username)) Then
                Dim con As SqlConnection = New SqlConnection("Data Source=MICHELLEANAYA;Initial Catalog=Proyecto_Final_Desa8;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[Paciente]
   SET [correo_e] = '" + username + "',
      [contraseña] = '" + txtVerNewPass.Text + "'
 WHERE [correo_e] ='" + username + "' ", con)
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("contraseña recuperada completado ", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
            End If
        Else
            MessageBox.Show("por favor ingresa las dos contraseña")
        End If

    End Sub
End Class