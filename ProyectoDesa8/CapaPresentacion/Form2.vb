Imports System.Net
Imports System.Net.Mail
Imports Microsoft.VisualBasic.Devices

Public Class Form2
    Dim RandowCode As String
    Public Shared toUser As String
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim from, pass, messageBody As String
        Dim rand As Random = New Random()
        RandowCode = (rand.Next(999999)).ToString()
        Dim message As MailMessage = New MailMessage()
        toUser = txtEmail.Text
        from = "leonelvargas5012@gmail.com"
        pass = "hsvnfhcoiofuzddv"
        messageBody = "tu codigo es" + RandowCode
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messageBody
        message.Subject = "codigo contraseña de recuperacion"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = smtp.DeliveryMethod.Network
        smtp.Credentials = New NetworkCredential(from, pass)
        Try
            smtp.Send(message)
            MessageBox.Show("verifica tu correo electronico y introduce el codigo ")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If (txtVerify.Text.Equals(RandowCode)) Then
            toUser = txtEmail.Text
            Dim Reset As Reset = New Reset()
            Reset.Show()
            Dim sc As Form2 = New Form2()
            sc.Hide()
        Else
            MessageBox.Show("codigo equivocado")


        End If

    End Sub
End Class