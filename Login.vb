Imports System.DirectoryServices.ActiveDirectory

Public Class Login



    Private Sub txtusername_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        Dim Uname As String = txtusername.Text
        If txtusername.Text = "username" Then
            txtusername.Text = ""
            txtusername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtusername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        Dim Uname As String = txtusername.Text
        If txtusername.Text = "" Then
            txtusername.Text = "username"
            txtusername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        Dim pass As String = txtpassword.Text
        If txtpassword.Text = "password" Then
            txtpassword.Text = ""
            txtpassword.ForeColor = Color.Black
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        Dim pass As String = txtpassword.Text
        If txtpassword.Text = "" Then
            txtpassword.Text = "password"
            txtpassword.ForeColor = Color.DarkGray
            txtpassword.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub hide_Click(sender As Object, e As EventArgs) Handles hide.Click
        If txtpassword.UseSystemPasswordChar = False Then
            Show.BringToFront()
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Show_Click(sender As Object, e As EventArgs) Handles Show.Click
        If txtpassword.UseSystemPasswordChar = True Then
            hide.BringToFront()
            txtpassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub mainpanel_Paint(sender As Object, e As PaintEventArgs) Handles mainpanel.Paint
        mainpanel.BackColor = Color.FromArgb(100, 0, 0, 0)
    End Sub

    Private Sub btnforgotpass_Click(sender As Object, e As EventArgs) Handles btnforgotpass.Click

    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub
End Class