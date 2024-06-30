Imports System.Net
Imports System.Net.Mail
Imports System.Data
Imports System.Data.SqlClient
Imports Windows.UI.Notifications

Public Class email_verification
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")
    Dim verificationcode As String '= Guid.NewGuid().ToString
    Dim username As String = "dhunganahr.88@gmail.com"
    Dim password As String = "your google app password"



    Public Function sendVerificationcode(ByVal mails As String) As String
        Dim R As New Random()
        verificationcode = R.Next(10000).ToString("D4")

        Try
            Dim fromAddres As New MailAddress("noreply@cafeteria.com", "Cafeteria Billing System")
            Dim toAddress As New MailAddress(mails)
            Dim subject As String = "Verify your email address"
            Dim body As String = String.Format("Please use the following code to verfiy you email address for knock creation: {0}", verificationcode)

            Dim smtp As New SmtpClient
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(username, password)
            Dim message As New MailMessage(fromAddres, toAddress)
            message.Subject = subject
            message.Body = body
            smtp.Send(message)
            MsgBox("OTP sent successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Return verificationcode
        Catch ex As Exception
            MessageBox.Show("OTP sending failed: " & ex.Message & Environment.NewLine & "Please check your internet connection and try again.", "OTP Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub txtemail1_Enter(sender As Object, e As EventArgs) Handles txtemail1.Enter
        If txtemail1.Text = "Enter email address" Then
            txtemail1.Text = ""
            txtemail1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtemail1_Leave(sender As Object, e As EventArgs) Handles txtemail1.Leave
        If txtemail1.Text = "" Then
            txtemail1.Text = "Enter email address"
            txtemail1.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub submit_otp_Click(sender As Object, e As EventArgs) Handles submit_otp.Click

        Try
            con.Open()
            If txtemail1.Text = "Enter email address" Then
                MsgBox("Please enter a valid email address", MsgBoxStyle.Critical)
            Else
                Dim cmd As SqlCommand = New SqlCommand("checkEmail", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@email", txtemail1.Text)
                cmd.ExecuteNonQuery()
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                sda.Fill(dt)
                If dt.Rows.Count > 0 Then
                    sendVerificationcode(txtemail1.Text)
                    Dim otpverification As New OTPverification
                    otpverification.mailaddress = txtemail1.Text
                    otpverification.Vcode = verificationcode
                    otpverification.Show()
                    Me.Hide()
                Else
                    MsgBox("Please enter registered email address", MsgBoxStyle.Critical)
                End If


            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred checking email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub email_verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)
    End Sub
End Class
