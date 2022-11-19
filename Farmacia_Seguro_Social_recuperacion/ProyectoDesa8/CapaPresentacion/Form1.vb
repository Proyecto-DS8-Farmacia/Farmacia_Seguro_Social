Imports System.Data.SqlClient
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

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-INBCNJQ\SQL;Initial Catalog=prueba;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from Usuarios where Usuario='" + txtUser.Text + "'and Contrasena='" + txtPass.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("inicio de sesion correctamente")
            Perfil.Show()
            Me.Hide()
        Else
            MessageBox.Show("error")
        End If

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Registrar.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim sc As Form2 = New Form2()
        sc.Show()
        Dim f As Form1 = New Form1()
        f.Hide()

    End Sub


    Private Sub btnRecuperarContra_Click(sender As Object, e As EventArgs)
        Recuperar_Contraseña.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        Administrador.Show()
        Me.Hide()
    End Sub
End Class
