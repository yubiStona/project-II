Imports Mysqlx.XDevAPI.Relational

Public Class productlist
    Private Sub txtsearch_Enter(sender As Object, e As EventArgs) Handles txtsearch.Enter
        If txtsearch.Text = "search here" Then
            txtsearch.Text = ""
            txtsearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtsearch_Leave(sender As Object, e As EventArgs) Handles txtsearch.Leave
        If txtsearch.Text = "" Then
            txtsearch.Text = "search here"
            txtsearch.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub btnaddd_Click(sender As Object, e As EventArgs) Handles btnaddd.Click
        Dim obj As New productdetail
        obj.Show()

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Column1.ReadOnly = True
        Column2.ReadOnly = True
        Column3.ReadOnly = True
        Column4.ReadOnly = True
        Column5.ReadOnly = True
        Column6.ReadOnly = True


    End Sub
End Class