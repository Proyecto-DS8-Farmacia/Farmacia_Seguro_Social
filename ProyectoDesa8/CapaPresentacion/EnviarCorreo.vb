Imports System.Net
Imports System.Net.Mail
Module EnviarCorreo

    Private correos As New MailMessage
    Private envios As New SmtpClient

    Sub enviarCorreo(ByVal emisor As String, ByVal pass As String, ByVal asunto As String, ByVal destinatario As String)
        Try
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            'correos.Body = cuerpo
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))


            correos.Body = "<table border='3'>"
            correos.Body &= "<tr>"
            For i As Integer = 0 To Correo.dgv_ReStockC.ColumnCount - 1
                correos.Body &= "<th>" & Correo.dgv_ReStockC.Columns(i).Name & "</th>"
            Next
            correos.Body &= "</tr>"
            For Each row As DataGridViewRow In Correo.dgv_ReStockC.Rows

                correos.Body &= "<tr>"   'Defineuna nueva fila
                correos.Body &= "<td>" & row.Cells(0).Value & "</td>"
                correos.Body &= "<td>" & row.Cells(1).Value & "</td>"
                'Repite el mismo codigo por cada columna del datagridview, tambien puedes hacerlo con un for directamente
                correos.Body &= "</tr>"  'Cierra la definicion de la fila
            Next
            correos.Body &= "</table>"



            'hsvnfhcoiofuzddv"

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, pass)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Module
