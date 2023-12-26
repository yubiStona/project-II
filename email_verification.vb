Public Class email_verification

    Private Sub txtemail_Enter(sender As Object, e As EventArgs) Handles txtemail.Enter
        If txtemail.Text = "Enter email address" Then
            txtemail.Text = ""
            txtemail.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtemail_Leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        If txtemail.Text = "" Then
            txtemail.Text = "Enter email address"
            txtemail.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub continueto_otp_Click(sender As Object, e As EventArgs) Handles continueto_otp.Click

    End Sub
End Class