Imports System.DirectoryServices.ActiveDirectory
Imports System.Data
Imports System.Data.SqlClient
Imports Mysqlx.XDevAPI.Common
Imports System.Runtime.CompilerServices
Imports Windows.Networking.NetworkOperators


Public Class Login


    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")

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

    Private Sub btnhide_Click(sender As Object, e As EventArgs) Handles btnhide.Click
        If txtpassword.UseSystemPasswordChar = False Then
            btnShow.BringToFront()
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If txtpassword.UseSystemPasswordChar = True Then
            btnhide.BringToFront()
            txtpassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btnforgotpass_Click(sender As Object, e As EventArgs) Handles btnforgotpass.Click
        Dim emailverify As New email_verification
        emailverify.Show()
        Me.Hide()

    End Sub

    Private Sub checkLogin()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("CheckLogin", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Username", txtusername.Text)
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("@IsAdmin", SqlDbType.Int).Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("@countLogin", SqlDbType.Int).Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("@TempUserID", SqlDbType.Int).Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery()
            Dim userID As Integer
            Dim is_admin As Integer
            If cmd.Parameters("@TempUserID").Value IsNot DBNull.Value Then
                userID = CInt(cmd.Parameters("@TempUserID").Value) 'assign value to the variable
                is_admin = CInt(cmd.Parameters("@IsAdmin").Value)
            End If


            If CInt(cmd.Parameters("@result").Value = 1) Then
                If CInt(cmd.Parameters("@IsAdmin").Value = 1) Then
                    ' User is admin, redirect to MainForm
                    Dim mForm As mainform = New mainform
                    mForm.isAdmin = is_admin
                    mForm.Show()
                    Me.Hide()



                Else
                    ' User is not admin, check login count
                    If CInt(cmd.Parameters("@countLogin").Value = 0) Then
                        ' First login, redirect to ChangePassword form

                        Dim dFpassword As DefaultPassword = New DefaultPassword
                        dFpassword.UserID = userID
                        dFpassword.Password = txtpassword.Text
                        dFpassword.Show()
                        Me.Hide()

                    Else
                        ' Subsequent logins, redirect to MainForm
                        Dim mForm As mainform = New mainform
                        mForm.isAdmin = is_admin
                        mForm.Show()
                        Me.Hide()

                    End If
                End If
            Else
                ' Invalid login credentials
                MessageBox.Show("Invalid username or password.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As SqlException
            ' Handle SQL exceptions
            MessageBox.Show("SQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Handle other exceptions
            MessageBox.Show("An error occurred while login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        checkLogin()

    End Sub
End Class