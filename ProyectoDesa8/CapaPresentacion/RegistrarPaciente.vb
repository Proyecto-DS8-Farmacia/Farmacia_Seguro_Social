Public Class RegistrarPaciente


    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint
        PanelMenu.BackColor = Color.FromArgb(100, 0, 35, 0)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub
    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Me.Show()
    End Sub

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

    Private Sub calendarioFV_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendarioFV.DateChanged
        txtFechav.Text = calendarioFV.SelectionStart.Day.ToString() + "-" + calendarioFV.SelectionStart.Month.ToString() + "-" + calendarioFV.SelectionStart.Year.ToString()
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If (txtContraseña.Text.Equals(txtContraseñaDN.Text)) Then

            CapaDatos.Metodos.REGISTRARPACIENTE(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtCarneS.Text,
                                                txtFechav.Text, cboBeneficiario.SelectedItem().ToString, txtFamiliarP.Text,
                                                txtCorreo.Text, txtContraseña.Text, txtTelefono.Text)
            MessageBox.Show("Paciente registrado exitosamente.", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Las contraseñas deben coincidir.", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Close()
    End Sub

    Private Sub cboBeneficiario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBeneficiario.SelectedIndexChanged
        If (cboBeneficiario.SelectedItem.Equals("No")) Then
            txtFamiliarP.ReadOnly = True
        Else
            txtFamiliarP.ReadOnly = False
        End If
    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        Administrador.Show()
        Me.Hide()
    End Sub
End Class