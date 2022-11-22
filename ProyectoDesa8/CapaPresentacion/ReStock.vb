﻿Public Class ReStock


    Private Sub Farmacia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim farmacia As New DataView(CapaDatos.Metodos.FARMACIA)
        cbx_Farmacia.ValueMember = "cod_farm"
        cbx_Farmacia.DisplayMember = "nombre"
        cbx_Farmacia.DataSource = farmacia
    End Sub

    Private Sub cbx_Farmacia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Farmacia.SelectedValueChanged
        Dim Data As New DataView(CapaDatos.Metodos.PROVEEDOR)
        If (cbx_Farmacia.SelectedValue IsNot Nothing) Then
            Data.RowFilter = " cod_farmacia = '" & cbx_Farmacia.SelectedValue.ToString & "'"
            cbx_Proveedor.ValueMember = "cod_proveedor"
            cbx_Proveedor.DisplayMember = "nproveedor"
            cbx_Proveedor.DataSource = Data
        End If
    End Sub

    Private Sub cbx_Proveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Proveedor.SelectedValueChanged
        Dim Data As New DataView(CapaDatos.Metodos.FARMACIA_SUSTANCIA)
        If (cbx_Farmacia.SelectedValue IsNot Nothing And cbx_Proveedor.SelectedValue IsNot Nothing) Then
            Data.RowFilter = "nfarmacia like '" & cbx_Farmacia.Text & "' and nproveedor like '" & cbx_Proveedor.Text & "' "
            cbx_Sustancia.ValueMember = "cod_sustancia"
            cbx_Sustancia.DisplayMember = "nsustancia"
            cbx_Sustancia.DataSource = Data
        End If
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        CapaDatos.Metodos.RESTOCK(cbx_Farmacia.SelectedValue, cbx_Sustancia.SelectedValue, txt_Cantidad.Text)
    End Sub

End Class