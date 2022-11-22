Imports System.Data
Imports System.Data.SqlClient
Public Class Reset
    Dim username As String = Form2.toUser
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If (txtVerPass.Text.Equals(txtVerNewPass.Text)) Then


            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-INBCNJQ\SQL;Initial Catalog=prueba;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[Usuarios]
   SET [Usuario] = '" + username + "',
      [Contrasena] = '" + txtVerNewPass.Text + "'
 WHERE [Usuario] ='" + username + "' ", con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("contraseña recuperada completado ", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Else
            MessageBox.Show("por favor ingresa las dos contraseña")
        End If
    End Sub
End Class