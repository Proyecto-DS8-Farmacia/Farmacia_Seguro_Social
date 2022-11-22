Imports System.Text.RegularExpressions

Public Class Form1
    Dim correo_e, contraseña, tipoUsuario As String

    Private Sub PanelContenidoSmall_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenidoSmall.Paint
        PanelContenidoSmall.BackColor = Color.FromArgb(100, 0, 45, 0)
    End Sub

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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim validocorreo As Boolean = regex.IsMatch(txtCorreo.Text.Trim)

        'correo_e = txtCorreo.Text
        'contraseña = txtContraseña.Text

        If (txtCorreo.Text.Equals("") Or txtContraseña.Text.Equals("")) Then
            MessageBox.Show("Ingrese sus datos correctamente.", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Not validocorreo Then
                MessageBox.Show("Ingrese un correo valido.", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else


                If (CapaDatos.Metodos.INICIAR_SESION(txtCorreo.Text.ToString, txtContraseña.Text.ToString, "administrador")) Then
                    Administrador.Show()
                    Me.Hide()
                ElseIf (CapaDatos.Metodos.INICIAR_SESION(txtCorreo.Text.ToString, txtContraseña.Text.ToString, " encargado_inventario")) Then
                    Encargado.Show()
                    Me.Hide()
                ElseIf (CapaDatos.Metodos.INICIAR_SESION(txtCorreo.Text.ToString, txtContraseña.Text.ToString, "farmaceuta")) Then
                    Farmaceuta.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("No se inicio sesion. Revise sus credenciales.", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If


                    'Administrador.Show()
                    'Me.Hide()
                End If

            'If (optAdmin.Checked) Then
            'Administrador.Show()
            'End If
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Registrar_Usuariovb.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim sc As Form2 = New Form2()
        sc.Show()
        Dim f As Form1 = New Form1()
        f.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RegistrarPaciente.Show()
        Me.Hide()
    End Sub

    Private Sub btnRecuperarContra_Click(sender As Object, e As EventArgs) Handles btnRecuperarContra.Click
        Dim sc As Form2 = New Form2()
        sc.Show()
        Dim f As Form1 = New Form1()
        f.Hide()

    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        Administrador.Show()
        Me.Hide()
    End Sub
End Class
