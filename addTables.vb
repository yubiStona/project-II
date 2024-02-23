Imports System.Data
Imports System.Data.SqlClient

Public Class addTables
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")


    Private Sub addTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddatagridview()
    End Sub

    Private Sub Loaddatagridview()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("gettabledata", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            sda.Fill(dt)

            DataGridView1.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data failed to load" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub Inserttbldata()
        Dim floor As String = txtfloor.Text
        Dim tableType As String = txttabletype.Text
        Dim tableNo As String = "T" & txttableNo.Text
        Dim errorMessage As String = ""

        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("insrtTblInfo", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@floor", floor)
            cmd.Parameters.AddWithValue("@tbltype", tableType)
            cmd.Parameters.AddWithValue("@tblno", tableNo)

            ' Add OUTPUT parameter for error message
            Dim errorMessageParameter As New SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 255)
            errorMessageParameter.Direction = ParameterDirection.Output
            cmd.Parameters.Add(errorMessageParameter)

            cmd.ExecuteNonQuery()
            con.Close()

            ' Check the error message from the stored procedure
            errorMessage = errorMessageParameter.Value.ToString()

            If String.IsNullOrEmpty(errorMessage) Then
                ' No error, proceed with success message
                Loaddatagridview()
                MessageBox.Show("Data inserted successfully")
            Else
                ' Display the error message
                MessageBox.Show(errorMessage)
            End If
        Catch ex As Exception
            MessageBox.Show("Insertion failed:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub

    Private Function IsDuplicatetable(ByVal tblno As String)
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("TableNo").Value IsNot Nothing AndAlso row.Cells("TableNo").Value.ToString() = tblno Then
                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No duplicate found in the DataGridView
        Catch ex As Exception
            MessageBox.Show("An error occurred checking duplicate table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtfloor.Text = selectedRow.Cells("Floor").Value.ToString()
            txttableNo.Text = selectedRow.Cells("TableNo").Value.ToString()
            txttabletype.Text = selectedRow.Cells("TableType").Value.ToString()
        End If
    End Sub

    Private Sub searchtable_TextChanged(sender As Object, e As EventArgs) Handles searchtable.TextChanged
        Try
            ' If the search term is not empty, perform the search
            If Not String.IsNullOrWhiteSpace(searchtable.Text) Then
                ' Use the stored procedure to search for users
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("searchtbl", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' Set parameter for the stored procedure
                cmd.Parameters.AddWithValue("@SearchTerm", searchtable.Text)

                ' Execute the stored procedure and fill a DataTable with the search results
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)

                con.Close()

                ' Set the DataTable as the DataGridView's data source
                DataGridView1.DataSource = dt
            Else
                ' If the search term is empty, load all users
                Loaddatagridview()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred searching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub searchtable_Leave(sender As Object, e As EventArgs) Handles searchtable.Leave
        ' Reset the DataGridView to display the entire list when leaving the search TextBox
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Visible = True
        Next
    End Sub

    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        Inserttbldata()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            'Dim selectedID As String = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("TableNo").Value)
            ' Retrieve the current values of table no for the selected row
            Dim tableno As String = DataGridView1.SelectedRows(0).Cells("TableNo").Value.ToString()

            ' Get the values entered by the user
            Dim updatetblno As String = "T" & txttableNo.Text

            ' Check if the entered values match the current values of the selected row
            If tableno = updatetblno Then
                ' No changes made, or user is updating with the same values, allow the update
                UpdateRecord(tableno)
                cleartextbox()
            Else
                ' Changes made, check for duplicates in other rows
                If IsDuplicateInOtherRows(updatetblno) Then
                    MessageBox.Show("Records already exists!")
                Else
                    ' No duplicates found in other rows, allow the update
                    UpdateRecord(tableno)
                    cleartextbox()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function IsDuplicateInOtherRows(tblNo As String) As Boolean
        ' Check for duplicates in other rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.Selected Then ' Skip the selected row
                Dim tableno As String = row.Cells("TableNo").Value.ToString()


                If tblNo = tableno Then
                    Return True ' Duplicate found in other row
                End If
            End If
        Next

        Return False ' No duplicate found in other rows
    End Function

    Private Sub UpdateRecord(selectedID As String)

        Try
            ' Update the record in the database
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("updatetable", con)
            cmd.CommandType = CommandType.StoredProcedure
            ' Set parameters for the update command
            cmd.Parameters.AddWithValue("@tblno", selectedID)
            cmd.Parameters.AddWithValue("@floor", txtfloor.Text)
            cmd.Parameters.AddWithValue("@tbltype", txttabletype.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            Loaddatagridview()
            MessageBox.Show("Data updated successfully")
        Catch ex As Exception
            MessageBox.Show("An error occurred updating: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub deletetable()
        Try
            ' Check if a row is selected
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selecttblno As String = DataGridView1.SelectedRows(0).Cells("TableNo").Value.ToString()
                ' Ask the user for confirmation
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' User confirmed, proceed with deletion
                    con.Open()
                    Dim cmd As SqlCommand = New SqlCommand("deletetblinfo", con)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Set parameters for the deletion command
                    cmd.Parameters.AddWithValue("@tblno", selecttblno)
                    cmd.ExecuteNonQuery()
                    con.Close()

                    Loaddatagridview()
                    MessageBox.Show("Record deleted successfully")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub cleartextbox()
        txtfloor.Clear()
        txttableNo.Clear()
        txttabletype.Clear()
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        deletetable()
        cleartextbox()
    End Sub

End Class