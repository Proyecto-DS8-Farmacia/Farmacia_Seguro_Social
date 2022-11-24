Public Class Registrar_Usuariovb

    Public Farmacia As String


    Private Sub Registrar_Usuariovb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tiposusuario As New DataView(CapaDatos.Metodos.TIPOSDEUSUARIO)
        Dim farmacias As New DataView(CapaDatos.Metodos.FARMACIAS)
        cboFarmacia.ValueMember = "nombre"
        cboFarmacia.DisplayMember = "nombre"

        'cboFarmacia_Select.ValueMember = "nombre"
        'cboFarmacia_Select.DisplayMember = "nombre"

        cboTiposUsuario.ValueMember = "tipo"
        cboTiposUsuario.DisplayMember = "tipo"

        '  cboFarmacia_Select.DataSource = farmacias
        cboFarmacia.DataSource = farmacias
        cboTiposUsuario.DataSource = tiposusuario


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
        Form1.Show()
        Me.Hide()
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Close()
    End Sub

    Private Sub cboFarmacia_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboFarmacia.SelectedIndexChanged
        Dim Data As New DataView(CapaDatos.Metodos.DATOSDEUSUARIO)
        If (cboFarmacia.SelectedValue IsNot Nothing And cboTiposUsuario.SelectedValue IsNot Nothing) Then
            Data.RowFilter = "farmacia like '" & cboFarmacia.SelectedValue.ToString & "' and tipo like '" & cboTiposUsuario.SelectedValue.ToString & "' "


            ''    cboCedula.ValueMember = "cedula"
            '   cboCedula.DisplayMember = "cedula"
            '   cboCedula.DataSource = Data

        End If



    End Sub


    Private Sub cboTiposUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTiposUsuario.SelectedIndexChanged
        Dim Data As New DataView(CapaDatos.Metodos.DATOSDEUSUARIO)
        If (cboFarmacia.SelectedValue IsNot Nothing And cboTiposUsuario.SelectedValue IsNot Nothing) Then
            Data.RowFilter = "farmacia like '" & cboFarmacia.SelectedValue.ToString & "' and tipo like '" & cboTiposUsuario.SelectedValue.ToString & "' "
            '  cboCedula.ValueMember = "cedula"
            '  cboCedula.DisplayMember = "cedula"
            '  cboCedula.DataSource = Data
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        'Dim Data As New DataView(CapaDatos.Metodos.DATOSDEUSUARIO)
        Dim contr, contr2, cedula, nombre, apellido, telefono, correo_e, tipo As String
        Dim farma As Integer

        contr = txtContra.Text.ToString
        contr2 = txtContra2.Text.ToString
        cedula = txt_Cedula.Text.ToString
        nombre = txtPerfilNombre.Text.ToString
        apellido = txtPerfilapellido.Text.ToString
        telefono = txtTelefono.Text.ToString
        correo_e = txtCorreo.Text.ToString
        tipo = cboTiposUsuario.SelectedValue.ToString
        farma = cboFarmacia.SelectedIndex + 1
        If (contr.Equals("") Or contr2.Equals("") Or cedula.Equals("") Or nombre.Equals("") Or apellido.Equals("") Or telefono.Equals("") Or correo_e.Equals("")) Then
            MsgBox("Debe llenar los campos")
        Else
            If (contr.Equals(contr2)) Then


                Try
                    CapaDatos.Metodos.RegistrarUsuario(cedula, nombre, apellido, correo_e, telefono, contr2, tipo, farma)
                    MsgBox("Usuario registrado con Exito")
                Catch ex As Exception
                    MsgBox("ERROR DE REGISTRO")
                    MsgBox("Error: " & ex.ToString)
                End Try


            Else
                MsgBox("Contraseña incorrecta")

            End If

        End If


    End Sub

    Private Sub lblF_Click(sender As Object, e As EventArgs) Handles lblF.Click

    End Sub





    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click

    End Sub
End Class