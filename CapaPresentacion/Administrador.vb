Public Class Administrador
    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Perfil.Show()
        Me.Hide()
    End Sub

    Private Sub btnEncargado_Click(sender As Object, e As EventArgs) Handles btnEncargado.Click
        Encargado.Show()
        Me.Hide()
    End Sub

    Private Sub btnFarmaceuta_Click(sender As Object, e As EventArgs) Handles btnFarmaceuta.Click
        Farmaceuta.Show()
        Me.Hide()
    End Sub

    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        Paciente.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        Me.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Close()
    End Sub
End Class