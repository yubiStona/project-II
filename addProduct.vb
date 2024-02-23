Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Windows.Win32.System

Public Class addProduct
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")

    Dim serialNumber As Integer = 1
    Dim selectedRowIndex As Integer = -1
    Dim isAddingRow As Boolean = False ' Flag to prevent automatic row addition

    Private Sub addProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear existing rows in the DataGridView
        'DataGridView1.Rows.Clear()
        LoadDataIntoDataGridView()
    End Sub

    Private Sub insertproduct()
        If String.IsNullOrWhiteSpace(txtpname.Text) OrElse
            String.IsNullOrWhiteSpace(txtpdesc.Text) OrElse
            String.IsNullOrWhiteSpace(txtcategory.Text) OrElse
            String.IsNullOrWhiteSpace(txtprice.Text) Then
            MessageBox.Show("Please fill in all the required information.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try

                'get valuse from textboxes
                Dim Iname As String = txtpname.Text
                Dim Idesc As String = txtpdesc.Text
                Dim icategory As String = txtcategory.Text
                Dim price As Decimal = Convert.ToDecimal(txtprice.Text)

                If IsDuplicateInDataGridView(Iname, icategory) Then
                    MessageBox.Show("Duplicate values found in other rows. Please provide unique values.")
                Else

                    ' Insert data into the database
                    con.Open()
                    Dim cmd As SqlCommand = New SqlCommand("insertProduct", con)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Set parameters for the insertion command
                    cmd.Parameters.AddWithValue("@Name", Iname)
                    cmd.Parameters.AddWithValue("@desc", Idesc)
                    cmd.Parameters.AddWithValue("@category", icategory)
                    cmd.Parameters.AddWithValue("@price", price)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data inserted successfully")
                    con.Close()
                    LoadDataIntoDataGridView()
                End If

            Catch ex As Exception
                MsgBox("Insertion failed!", vbCritical)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub UpdateRecord(selectedID As Integer)
        Try
            Dim Price As Decimal = Convert.ToDecimal(txtprice.Text)
            ' Update the record in the database
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("updateproduct", con)
            cmd.CommandType = CommandType.StoredProcedure
            ' Set parameters for the update command
            cmd.Parameters.AddWithValue("@itemid", selectedID)
            cmd.Parameters.AddWithValue("@itemname", txtpname.Text)
            cmd.Parameters.AddWithValue("@itemdesc", txtpdesc.Text)
            cmd.Parameters.AddWithValue("@itemcategory", txtcategory.Text)
            cmd.Parameters.AddWithValue("@itemprice", Price)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data updated successfully")
            con.Close()
            LoadDataIntoDataGridView()
        Catch ex As Exception
            MsgBox("Product Update failed!", vbRetry)
            con.Close()
        End Try
    End Sub
    Private Sub deleteproduct()
        Try
            ' Check if a row is selected
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("ItemID").Value)
                ' Ask the user for confirmation
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' User confirmed, proceed with deletion
                    con.Open()
                    Dim cmd As SqlCommand = New SqlCommand("deleteproduct", con)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Set parameters for the deletion command
                    cmd.Parameters.AddWithValue("@itemid", selectedID)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    LoadDataIntoDataGridView()
                    MessageBox.Show("Record deleted successfully")
                End If
            End If
        Catch ex As Exception
            MsgBox("deletion failed", vbCritical)
            con.Close()
        End Try
    End Sub
    Private Sub LoadDataIntoDataGridView()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("getproductdata", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            ' Execute the stored procedure and fill the DataTable with the results
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            DataGridView1.DataSource = dt
            con.Close()

        Catch ex As Exception
            MsgBox("Data loading failed", vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub cleartextbox()
        txtcategory.Clear()
        txtpdesc.Clear()
        txtpname.Clear()
        txtprice.Clear()

    End Sub

    Private Sub searchitem_TextChanged(sender As Object, e As EventArgs) Handles searchitem.TextChanged
        Try
            ' If the search term is not empty, perform the search
            If Not String.IsNullOrWhiteSpace(searchitem.Text) Then
                ' Use the stored procedure to search for users
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("searchitem", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' Set parameter for the stored procedure
                cmd.Parameters.AddWithValue("@SearchTerm", searchitem.Text)

                ' Execute the stored procedure and fill a DataTable with the search results
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)

                con.Close()

                ' Set the DataTable as the DataGridView's data source
                DataGridView1.DataSource = dt
            Else
                ' If the search term is empty, load all users
                LoadDataIntoDataGridView()
            End If
        Catch ex As Exception
            MsgBox("Failed to search!", vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub searchitem_Leave(sender As Object, e As EventArgs) Handles searchitem.Leave
        ' Reset the DataGridView to display the entire list when leaving the search TextBox
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Visible = True
        Next
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtpname.Text = selectedRow.Cells("ItemName").Value.ToString()
            txtpdesc.Text = selectedRow.Cells("ItemDescription").Value.ToString()
            txtcategory.Text = selectedRow.Cells("ItemCategory").Value.ToString()
            txtprice.Text = selectedRow.Cells("ItemPrice").Value.ToString()
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        deleteproduct()
        cleartextbox()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        insertproduct()
        cleartextbox()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            ' Get the ID of the selected row
            Dim selectedID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("ItemID").Value)

            ' Retrieve the current values of (Phone_No, Email, Username) for the selected row
            Dim Name As String = DataGridView1.SelectedRows(0).Cells("ItemName").Value.ToString()
            Dim category As String = DataGridView1.SelectedRows(0).Cells("ItemCategory").Value.ToString()

            ' Get the values entered by the user
            Dim updatedname As String = txtpname.Text
            Dim updatedcategory As String = txtcategory.Text

            ' Check if the entered values match the current values of the selected row
            If Name = updatedname AndAlso category = updatedcategory Then
                ' No changes made, or user is updating with the same values, allow the update
                UpdateRecord(selectedID)
                cleartextbox()
            Else
                ' Changes made, check for duplicates in other rows
                If IsDuplicateInOtherRows(updatedname, updatedcategory) Then
                    MessageBox.Show("Duplicate values found in other rows. Please provide unique values.")
                Else
                    ' No duplicates found in other rows, allow the update
                    UpdateRecord(selectedID)
                    cleartextbox()
                End If
            End If
        Catch ex As Exception
            MsgBox("update failed-No record selected!", vbInformation)
        End Try
    End Sub
    Private Function IsDuplicateInOtherRows(Name As String, category As String) As Boolean
        ' Check for duplicates in other rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.Selected Then ' Skip the selected row
                Dim itname As String = row.Cells("ItemName").Value.ToString()
                Dim itcategory As String = row.Cells("ItemCategory").Value.ToString()

                If Name = itname AndAlso category = itcategory Then
                    Return True ' Duplicate found in other row
                End If
            End If
        Next

        Return False ' No duplicate found in other rows
    End Function

    Private Function IsDuplicateInDataGridView(Name As String, category As String) As Boolean
        ' Check for duplicates in the DataGridView
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim itname As String = row.Cells("ItemName").Value.ToString()
            Dim itcategory As String = row.Cells("ItemCategory").Value.ToString()

            If Name = itname AndAlso category = itcategory Then
                Return True ' Duplicate found in DataGridView
            End If
        Next

        Return False ' No duplicate found in DataGridView
    End Function

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            ' If the entered key is not a digit, a control key, or a decimal point, suppress the keypress
            e.Handled = True
        ElseIf e.KeyChar = "." AndAlso (sender.Text.Contains(".") OrElse sender.Text.Length = 0) Then
            ' If the entered key is a decimal point and it's already present in the text or the text is empty, suppress the keypress
            e.Handled = True
        End If
    End Sub
End Class