Public Class forgot_password

    Private Sub newhide_Click(sender As Object, e As EventArgs) Handles newhide.Click
        If res_newpass.UseSystemPasswordChar = False Then
            newshow.BringToFront()
            res_newpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub newshow_Click(sender As Object, e As EventArgs) Handles newshow.Click
        If res_newpass.UseSystemPasswordChar = True Then
            newhide.BringToFront()
            res_newpass.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub hideconfirm_Click(sender As Object, e As EventArgs) Handles hideconfirm.Click

    End Sub

    Private Sub showconfirm_Click(sender As Object, e As EventArgs) Handles showconfirm.Click

    End Sub


    Private Sub res_newpass_Enter(sender As Object, e As EventArgs) Handles res_newpass.Enter
        If res_newpass.Text = "password" Then
            res_newpass.Text = ""
            res_newpass.ForeColor = Color.Black
            res_newpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub res_newpass_Leave(sender As Object, e As EventArgs) Handles res_newpass.Leave
        If res_newpass.Text = "" Then
            res_newpass.Text = "password"
            res_newpass.ForeColor = Color.DarkGray
            res_newpass.UseSystemPasswordChar = False
        End If
    End Sub
End Class