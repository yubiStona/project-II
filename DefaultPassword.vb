Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class DefaultPassword
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")
    Private _userID As Integer
    Private _currentpassword As String

    Public Property UserID As Integer
        Get
            Return _userID
        End Get
        Set(value As Integer)
            _userID = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _currentpassword
        End Get
        Set(value As String)
            _currentpassword = value
        End Set
    End Property

    Private Function IsPasswordValid(password As String) As Boolean
        ' Define regular expression pattern for password validation
        Dim pattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"

        ' Create a Regex object with the pattern
        Dim regex As New Regex(pattern)

        ' Check if the password matches the pattern
        Return regex.IsMatch(password)
    End Function

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        Dim password As String = txtnewpass.Text.Trim()

        If IsPasswordValid(password) Then
            If txtnewpass.Text <> txtconfirmpass.Text Then
                MsgBox("new password doesn't match")
                Return
            End If
            Try

                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("UpdatePassword", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' Set parameters for the stored procedure
                cmd.Parameters.AddWithValue("@UserID", UserID)
                cmd.Parameters.AddWithValue("@CurrentPassword", txtcurrentpas.Text)
                cmd.Parameters.AddWithValue("@NewPassword", password) ' Assuming txtnewpass is used for new password

                Dim result As String = cmd.ExecuteScalar().ToString()

                If result = "Success" Then
                    MessageBox.Show("Password updated successfully")
                    Login.Show()
                    Me.Close()
                    ' Additional logic if needed
                ElseIf result = "IncorrectCurrentPassword" Then
                    MessageBox.Show("Incorrect current password")
                Else
                    MessageBox.Show("Error updating password")
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred updateing password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        Else
            ' Password is not valid, display an error message
            MsgBox("Password must contain at least one uppercase letter, one lowercase letter, one number, one special character, and be at least 8 characters long.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub DefaultPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)
    End Sub

End Class