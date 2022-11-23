Public Class Correo


    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click

        EnviarCorreo.enviarCorreo(txt_Emisor.Text, txt_pass.Text, txt_Asunto.Text, txt_Destinatario.Text)
        txt_Asunto.Text = ""
        txt_Destinatario.Text = ""
        Me.Hide()
        ReStock.Show()
        dgv_ReStockC.Rows.Clear()
    End Sub


    Private Sub Correo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim emisor, pass, asunto As String

        emisor = "leonelvargas5012@gmail.com"
        pass = "hsvnfhcoiofuzddv"
        asunto = "Informe de Pedido"

        txt_Emisor.Text = emisor
        txt_pass.Text = pass
        txt_Asunto.Text = asunto

    End Sub
End Class