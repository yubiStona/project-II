Public Class userdetail
    Private Sub userdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageholder.Hide()

    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        OpenFileDialog12.ShowDialog()
        imageholder.Text = OpenFileDialog12.FileName
        If (System.IO.File.Exists(imageholder.Text)) Then
            txtimage.Image = Image.FromFile(imageholder.Text)
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
End Class