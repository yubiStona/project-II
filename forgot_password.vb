Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Windows.Services.Maps.LocalSearch
Public Class forgot_password
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")
    Private _currentemail As String


    Public Property Emaail As String
        Get
            Return _currentemail
        End Get
        Set(value As String)
            _currentemail = value
        End Set
    End Property
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

    Private Sub btnhide1_Click(sender As Object, e As EventArgs) Handles btnhide1.Click
        If txtpassword1.UseSystemPasswordChar = False Then
            btnShow1.BringToFront()
            txtpassword1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnShow1_Click(sender As Object, e As EventArgs) Handles btnShow1.Click
        If txtpassword1.UseSystemPasswordChar = True Then
            btnhide1.BringToFront()
            txtpassword1.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtpassword1_Enter(sender As Object, e As EventArgs) Handles txtpassword1.Enter
        If txtpassword1.Text = "password" Then
            txtpassword1.Text = ""
            txtpassword1.ForeColor = Color.Black
            txtpassword1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpassword1_Leave(sender As Object, e As EventArgs) Handles txtpassword1.Leave
        If txtpassword1.Text = "" Then
            txtpassword1.Text = "password"
            txtpassword1.ForeColor = Color.DarkGray
            txtpassword1.UseSystemPasswordChar = False
        End If
    End Sub

    Private Function IsPasswordValid(password As String) As Boolean
        ' Define regular expression pattern for password validation
        Dim pattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"

        ' Create a Regex object with the pattern
        Dim regex As New Regex(pattern)

        ' Check if the password matches the pattern
        Return regex.IsMatch(password)
    End Function

    Private Sub btnrespass_Click(sender As Object, e As EventArgs) Handles btnrespass.Click
        Dim password As String = txtpassword.Text.Trim()

        ' Check if the password is valid
        If IsPasswordValid(password) Then
            If txtpassword.Text <> txtpassword1.Text Then
                MsgBox("password does not match!", vbInformation)
                Return
            End If
            Try
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("resetpassword", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@password", txtpassword1.Text)
                cmd.Parameters.AddWithValue("@email", Emaail)
                cmd.ExecuteNonQuery()
                MsgBox("Password changes succesfully", vbInformation, vbOK)
                Login.Show()
                Me.Hide()


            Catch ex As Exception
                MessageBox.Show("An error occurred resetting password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()

            End Try
        Else
            ' Password is not valid, display an error message
            MsgBox("Password must contain at least one uppercase letter, one lowercase letter, one number, one special character, and be at least 8 characters long.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub forgot_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)
    End Sub

    Private Sub forgot_password_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Login.Show()
    End Sub

    Private Sub forgot_password_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Dim result = MessageBox.Show("Please make sure you've updated the password.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True ' Cancel the form closing action
        End If
    End Sub
End Class