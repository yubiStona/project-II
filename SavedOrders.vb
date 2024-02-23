Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class SavedOrders
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")
    Dim orderid As String
    Public Sub Loadrecords()
        DataGridView1.Rows.Clear()
        Try
            Dim i As Integer = 0
            con.Open()
            Dim cmd As New SqlCommand("GetsavedOrders", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("OrderID").ToString, dr.Item("Floor").ToString, dr.Item("TableType").ToString, dr.Item("TableNO").ToString)
            End While
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox("dataload failed" & ex.Message)
        End Try
    End Sub
    Private Sub searchorder_TextChanged(sender As Object, e As EventArgs) Handles searchorder.TextChanged
        Dim searchText As String = searchorder.Text.Trim().ToLower()
        ' Iterate through each row in the DataGridView
        For Each row As DataGridViewRow In DataGridView1.Rows
            ' Check if the value in any of the cells contains the search text
            Dim matchFound As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchText) Then
                    matchFound = True
                    Exit For ' Exit the inner loop if a match is found in any cell
                End If
            Next

            ' Show/hide the row based on the match found status
            row.Visible = matchFound
        Next
    End Sub

    Private Sub searchorder_Leave(sender As Object, e As EventArgs) Handles searchorder.Leave
        ' Reset the DataGridView to display the entire list when leaving the search TextBox
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Visible = True
        Next
    End Sub

    'Private orderForm As order

    'Public Sub New(ByVal orderForm As order)
    '    InitializeComponent()
    '    Me.orderForm = orderForm
    'End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim counting As Integer = 1
        If e.RowIndex >= 0 Then
            With order
                .txtorderno.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .Combofloor.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .Combotabletype.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .Txttableno.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .txtcount.Text = counting.ToString()
                .Loadrecords()
                Me.Dispose()
            End With
        End If
    End Sub

    Private Sub DeleteRecord(OrderID As String)
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("DeleteSavedOrder", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@OrderID", OrderID)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Deletion failed!" & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        orderid = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        DeleteRecord(orderid)
        Loadrecords()
    End Sub

    Private Sub SavedOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadrecords()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub


    'drag form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As Integer)

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub SavedOrders_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Keep the form's size constant
        Size = New Size(748, 468) ' Set your desired size here
    End Sub


End Class