Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class OTPverification

    Private initialSeconds As Integer ' Variable to store the initial total seconds
    Public Property mailaddress As String
    Public Property Vcode As String
    Private Sub OTPverification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.BackColor = Color.FromArgb(100, 0, 0, 0)

        txtotp1.Focus()
        ' Parse the initial value in "1:00" format to total seconds
        Dim parts As String() = lbltimer.Text.Split(":")
        If parts.Length = 2 Then
            Dim minutes As Integer
            Dim seconds As Integer
            If Integer.TryParse(parts(0), minutes) AndAlso Integer.TryParse(parts(1), seconds) Then
                initialSeconds = minutes * 60 + seconds
            End If
        End If

        Timer1.Start()

        If initialSeconds = 0 Then
            Timer1.Stop()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If initialSeconds > 0 Then
            initialSeconds -= 1
            Dim minutes As Integer = initialSeconds \ 60
            Dim seconds As Integer = initialSeconds Mod 60
            lbltimer.Text = String.Format("{0}:{1:00}", minutes, seconds)

            If initialSeconds = 0 Then
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub RestartTimer()
        ' Set the initial seconds to 60 (1 minute)
        initialSeconds = 60

        ' Restart the timer if it's not already running
        If Not Timer1.Enabled Then
            Timer1.Start()
        End If
    End Sub

    Private Sub txtotp1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtotp1.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) Then
            txtotp1.Text = e.KeyChar.ToString()
            e.Handled = True
            txtotp2.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            txtotp1.Text = ""
            txtotp1.Focus()
        End If
    End Sub

    Private Sub txtotp2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtotp2.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) Then
            txtotp2.Text = e.KeyChar.ToString()
            e.Handled = True
            txtotp3.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            txtotp2.Text = ""
            txtotp1.Focus()
        End If
    End Sub

    Private Sub txtotp3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtotp3.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) Then
            txtotp3.Text = e.KeyChar.ToString()
            e.Handled = True
            txtotp4.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            txtotp3.Text = ""
            txtotp2.Focus()
        End If
    End Sub

    Private Sub txtotp4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtotp4.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) Then
            txtotp4.Text = e.KeyChar.ToString()
            e.Handled = True
            ' You can perform further actions here after entering the last digit
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            txtotp4.Text = ""
            txtotp3.Focus()
        End If
    End Sub

    Private Sub lblresendotp_MouseEnter(sender As Object, e As EventArgs) Handles lblresendotp.MouseEnter
        lblresendotp.ForeColor = Color.Orange
        lblresendotp.Cursor = Cursors.Hand
    End Sub

    Private Sub lblresendotp_MouseLeave(sender As Object, e As EventArgs) Handles lblresendotp.MouseLeave
        lblresendotp.ForeColor = Color.White
        lblresendotp.Cursor = Cursors.Default

    End Sub

    Private Sub lblresendotp_Click(sender As Object, e As EventArgs) Handles lblresendotp.Click
        If initialSeconds <= 0 Then
            Dim emailverification As New email_verification()
            Vcode = emailverification.sendVerificationcode(mailaddress)

            ' Call the method to restart the timer
            RestartTimer()
        Else
            MsgBox("Please wait until the current timer expires before requesting a new OTP.")
        End If
    End Sub

    Private Sub btnverifyotp_Click(sender As Object, e As EventArgs) Handles btnverifyotp.Click
        Dim check As String = txtotp1.Text + txtotp2.Text + txtotp3.Text + txtotp4.Text
        If initialSeconds > 0 Then
            If Vcode = check Then
                MsgBox("OTP successfully submitted!")
                Dim obj12 As forgot_password = New forgot_password
                obj12.Emaail = mailaddress
                obj12.Show()
                Me.Close()
            Else
                MsgBox("Ivalid OTP. Please try again.")
            End If
        Else
            MsgBox("OTP verification time has expired. Please request a new OTP.")
        End If
    End Sub

End Class