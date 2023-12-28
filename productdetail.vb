Imports System.Security.Cryptography

Public Class productdetail
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        OpenFileDialog1.ShowDialog()
        imageholder.Text = OpenFileDialog1.FileName
        If (System.IO.File.Exists(imageholder.Text)) Then
            txtimage.Image = Image.FromFile(imageholder.Text)
        End If

    End Sub

    Private Sub productdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageholder.Hide()

    End Sub

    Private Sub txtpname_Enter(sender As Object, e As EventArgs) Handles txtpname.Enter
        If txtpname.Text = "enter item name" Then
            txtpname.Text = ""
            txtpname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpname_Leave(sender As Object, e As EventArgs) Handles txtpname.Leave
        If txtpname.Text = "" Then
            txtpname.Text = "enter item name"
            txtpname.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub txtpid_Enter(sender As Object, e As EventArgs) Handles txtpid.Enter
        If txtpid.Text = "enter item id" Then
            txtpid.Text = ""
            txtpid.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpid_Leave(sender As Object, e As EventArgs) Handles txtpid.Leave
        If txtpid.Text = "" Then
            txtpid.Text = "enter item id"
            txtpid.ForeColor = Color.DarkGray
        End If
    End Sub
End Class