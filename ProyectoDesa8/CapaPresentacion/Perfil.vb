Public Class Perfil
    Public Farmacia As String


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

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Me.Show()
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
        Form1.Close()
    End Sub

    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tiposusuario As New DataView(CapaDatos.Metodos.TIPOSDEUSUARIO)
        Dim farmacias As New DataView(CapaDatos.Metodos.FARMACIAS)
        cboFarmacia.ValueMember = "nombre"
        cboFarmacia.DisplayMember = "nombre"
        cboFarmacia_Select.ValueMember = "nombre"
        cboFarmacia_Select.DisplayMember = "nombre"
        cboTiposUsuario.ValueMember = "tipo"
        cboTiposUsuario.DisplayMember = "tipo"
        cboFarmacia_Select.DataSource = farmacias
        cboFarmacia.DataSource = farmacias
        cboTiposUsuario.DataSource = tiposusuario

        If (CheckBox1.Checked) Then
            cboFarmacia_Select.Enabled = True

            Farmacia = (cboFarmacia_Select.SelectedIndex + 1).ToString
        Else
            cboFarmacia_Select.Enabled = False
            Farmacia = (cboFarmacia.SelectedIndex + 1).ToString
        End If
    End Sub

    Private Sub cboFarmacia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFarmacia.SelectedValueChanged
        Dim Data As New DataView(CapaDatos.Metodos.DATOSDEUSUARIO)
        If (cboFarmacia.SelectedValue IsNot Nothing And cboTiposUsuario.SelectedValue IsNot Nothing) Then
            Data.RowFilter = "farmacia like '" & cboFarmacia.SelectedValue.ToString & "' and tipo like '" & cboTiposUsuario.SelectedValue.ToString & "' "


            cboCedula.ValueMember = "cedula"
            cboCedula.DisplayMember = "cedula"
            cboCedula.DataSource = Data

        End If

    End Sub

    Private Sub cboTiposUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTiposUsuario.SelectedIndexChanged
        Dim Data As New DataView(CapaDatos.Metodos.DATOSDEUSUARIO)
        If (cboFarmacia.SelectedValue IsNot Nothing And cboTiposUsuario.SelectedValue IsNot Nothing) Then
            Data.RowFilter = "farmacia like '" & cboFarmacia.SelectedValue.ToString & "' and tipo like '" & cboTiposUsuario.SelectedValue.ToString & "' "
            cboCedula.ValueMember = "cedula"
            cboCedula.DisplayMember = "cedula"
            cboCedula.DataSource = Data
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim Data As New DataView(CapaDatos.Metodos.DATOSDEUSUARIO)

        Dim tiposusuario As String
        Dim toupper As String

        Data.RowFilter = "farmacia = '" & cboFarmacia.SelectedValue.ToString &
            "' and tipo = '" & cboTiposUsuario.SelectedValue.ToString &
            "' and cedula = '" & cboCedula.SelectedValue.ToString & "'"
        DataGridView1.DataSource = Data

        lblTipodeUsuario.Text = DataGridView1.Rows(0).Cells(0).Value      'TipodeUsuario'
        lblNombre.Text = DataGridView1.Rows(0).Cells(2).Value + " " + DataGridView1.Rows(0).Cells(3).Value             'Nombre'
        txtPerfilNombre.Text = DataGridView1.Rows(0).Cells(2).Value
        txtPerfilapellido.Text = DataGridView1.Rows(0).Cells(3).Value 'Apellido'

        '' txtcedula.Text = DataGridView1.Rows(0).Cells(0).Value             'Cedula' 
        txtCorreo.Text = DataGridView1.Rows(0).Cells(1).Value             'Correo'
        txtTelefono.Text = DataGridView1.Rows(0).Cells(4).Value           'Telefono'
        ''  txtFarmacia.Text = DataGridView1.Rows(0).Cells(6).Value           'Farmacia'

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox((cboFarmacia_Select.SelectedIndex + 1).ToString)

        If (CapaDatos.Metodos.ActualizarUSUARIO(DataGridView1.Rows(0).Cells(0).Value, txtPerfilNombre.Text.ToString, txtPerfilapellido.Text.ToString, txtCorreo.Text.ToString, txtTelefono.Text.ToString, Farmacia.ToString)) Then
            MsgBox("DATOS EDITADOS CORRECTAMENTE")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            cboFarmacia_Select.Enabled = True

            Farmacia = (cboFarmacia_Select.SelectedIndex + 1).ToString
        Else
            cboFarmacia_Select.Enabled = False
            Farmacia = (cboFarmacia.SelectedIndex + 1).ToString
        End If
    End Sub


End Class