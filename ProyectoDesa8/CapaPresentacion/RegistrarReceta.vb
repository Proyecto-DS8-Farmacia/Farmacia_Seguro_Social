Public Class RegistrarReceta
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
        Perfil.Show()
        Me.Hide()
    End Sub

    Private Sub btnFarmaceuta_Click(sender As Object, e As EventArgs) Handles btnFarmaceuta.Click
        Me.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Close()
    End Sub

    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        Paciente.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Lista As ListViewItem = New ListViewItem(cbxSustancia.SelectedValue.ToString)
        Dim id = cbxSustancia.SelectedValue.ToString
        Dim nombre = cbxSustancia.Text
        If (lvAgregados.FindItemWithText(nombre) Is Nothing) Then
            Lista.SubItems.Add(nombre)
            Lista.SubItems.Add(nudCant.Value)
            lvAgregados.Items.Add(Lista)
        Else
            Dim cant As Decimal
            cant = Convert.ToDecimal(lvAgregados.FindItemWithText(nombre).SubItems.Item(2).Text)
            Lista.SubItems.Add(nombre)
            Lista.SubItems.Add(cant + nudCant.Value)
            lvAgregados.Items.Remove(lvAgregados.FindItemWithText(nombre))
            lvAgregados.Items.Add(Lista)
        End If
        nudCant.Value = 1
    End Sub

    Private Sub RegistrarReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New DataView(CapaDatos.Metodos.SUSTANCIAS)
        Dim farmacias As New DataView(CapaDatos.Metodos.FARMACIAS)
        cbxSustancia.ValueMember = "cod_sustancia"
        cbxSustancia.DisplayMember = "nombre"
        cbxSustancia.DataSource = data
        cbxFarmacia.ValueMember = "cod_farm"
        cbxFarmacia.DisplayMember = "nombre"
        cbxFarmacia.DataSource = farmacias
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim dia As String, mes As String, an As String
        dia = dtpFecha.Value.Day
        mes = dtpFecha.Value.Month
        an = dtpFecha.Value.Year
        Dim Farmacia = cbxFarmacia.SelectedValue.ToString
        Dim Medico = txtMedico.Text
        Dim Cedula = txtCedula.Text
        Dim Fecha = an & "-" & mes & "-" & dia
        Dim sustancias((lvAgregados.Items.Count - 1), 2) As String
        For Each item As ListViewItem In lvAgregados.Items
            sustancias(item.Index, 0) = item.Text
            For i2 As Integer = 1 To 2
                sustancias(item.Index, i2) = item.SubItems.Item(i2).Text
            Next
        Next

        CapaDatos.Metodos.REGISTRARRECETA(Farmacia, Medico, Cedula, Fecha, sustancias)
        lvAgregados.Items.Clear()
        txtMedico.Text = ""
        txtCedula.Text = ""
        nudCant.Value = 1
    End Sub
End Class