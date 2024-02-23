Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Navigation
Imports Windows.ApplicationModel.Calls
Imports Windows.ApplicationModel.Chat
Public Class addUsers
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")

    Private Sub LoadDataIntoDataGridView()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("GetAllUsersData", con)
            cmd.CommandType = CommandType.StoredProcedure

            ' Execute the stored procedure and fill the DataTable with the results
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            DataGridView1.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred loading records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub addUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear existing rows in the DataGridView
        'DataGridView1.Rows.Clear()
        LoadDataIntoDataGridView()
    End Sub

    ' Handle the CellClick event to populate textboxes when a row is clicked
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Assuming the Name column in your DataGridView is the concatenation of Fname and Lname
            ' If not, modify accordingly
            Dim fullName As String = selectedRow.Cells("Name").Value.ToString()
            Dim names() As String = fullName.Split(" "c)
            If names.Length > 0 Then
                txtFname.Text = names(0)
                If names.Length > 1 Then
                    txtLname.Text = names(1)
                End If
            End If
            txtAddress.Text = selectedRow.Cells("Address").Value.ToString()
            txtgender.Text = selectedRow.Cells("Gender").Value.ToString()
            txtRole.Text = selectedRow.Cells("Role").Value.ToString()
            txtphone.Text = selectedRow.Cells("Phone_No").Value.ToString()
            txtEmail.Text = selectedRow.Cells("Email").Value.ToString()
            txtusername.Text = selectedRow.Cells("Username").Value.ToString()
            txtpassword.Text = selectedRow.Cells("Password").Value.ToString()
        End If
    End Sub

    Private Sub searchuser_TextChanged(sender As Object, e As EventArgs) Handles searchuser.TextChanged
        Try
            ' If the search term is not empty, perform the search
            If Not String.IsNullOrWhiteSpace(searchuser.Text) Then
                ' Use the stored procedure to search for users
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("SearchUser", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' Set parameter for the stored procedure
                cmd.Parameters.AddWithValue("@SearchTerm", searchuser.Text)

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
            MessageBox.Show("An error occurred while searching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub searchuser_Leave(sender As Object, e As EventArgs) Handles searchuser.Leave
        ' Reset the DataGridView to display the entire list when leaving the search TextBox
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Visible = True
        Next
    End Sub



    'check duplicate phone numbers
    Private Function IsDuplicatePhone(ByVal phone As String)
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("Phone_no").Value IsNot Nothing AndAlso row.Cells("Phone_no").Value.ToString() = phone Then
                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No duplicate found in the DataGridView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Try
        '    con.Open()
        '    Dim cmd As SqlCommand = New SqlCommand("select count(*) from tbl_user where Phone_no = @Phone_No", con)
        '    cmd.Parameters.AddWithValue("@Phone_No", phone)
        '    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        '    Return count
        'Catch ex As Exception
        '    MessageBox.Show("An error occurred searching for duplicate: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return True ' Assume duplicate on error
        'Finally
        '    con.Close()
        'End Try
    End Function
    Private Function IsDuplicateEmail(ByVal email As String)
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("Email").Value IsNot Nothing AndAlso row.Cells("Email").Value.ToString() = email Then
                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No duplicate found in the DataGridView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function IsDuplicateUsername(ByVal username As String)
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("Username").Value IsNot Nothing AndAlso row.Cells("Username").Value.ToString() = username Then
                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No dup
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Try
        '    con.Open()
        '    Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM tbl_user WHERE Username = @Username", con)
        '    cmd.Parameters.AddWithValue("Username", username)
        '    Dim result As Object = cmd.ExecuteScalar()

        '    If Not DBNull.Value.Equals(result) Then
        '        Dim count As Integer = Convert.ToInt32(result)
        '        Return count > 0
        '    End If

        '    Return False
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Return True ' Assume duplicate on error
        'Finally
        '    con.Close()
        'End Try
    End Function

    Private Sub InsertData()
        ' Check if all required textboxes are filled
        If String.IsNullOrWhiteSpace(txtFname.Text) OrElse
            String.IsNullOrWhiteSpace(txtLname.Text) OrElse
            String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
            String.IsNullOrWhiteSpace(txtphone.Text) OrElse
            String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
            String.IsNullOrWhiteSpace(txtpassword.Text) OrElse
            txtgender.SelectedItem Is Nothing OrElse
            String.IsNullOrWhiteSpace(txtusername.Text) Then
            MessageBox.Show("Please fill in all the required information.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                ' Get values from textboxes
                Dim name As String = txtFname.Text + " " + txtLname.Text
                Dim address As String = txtAddress.Text
                Dim gender As String = txtgender.Text
                Dim role As String = txtRole.Text
                Dim phone As String = txtphone.Text
                Dim email As String = txtEmail.Text
                Dim username As String = txtusername.Text
                Dim password As String = txtpassword.Text

                ' Check for duplicate phone number
                If IsDuplicatePhone(phone) Then
                    MessageBox.Show("Phone number already exist, Please Enter Unique phone number!")
                    Return ' Exit the method without proceeding with the insertion
                End If


                ' check for duplicate email
                If IsDuplicateEmail(email) Then
                    MessageBox.Show("email already exist, please enter unique email address!")
                    Return ' exit the method without proceeding with the insertion
                End If


                ' Check for duplicate phone number
                If IsDuplicateUsername(username) Then
                    MessageBox.Show("Username already exist, Please Enter Unique username !")
                    Return ' Exit the method without proceeding with the insertion
                End If

                ' Insert data into the database
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("InsertUser", con)
                cmd.CommandType = CommandType.StoredProcedure

                ' Set parameters for the insertion command
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@Address", address)
                cmd.Parameters.AddWithValue("@Gender", gender)
                cmd.Parameters.AddWithValue("@Role", role)
                cmd.Parameters.AddWithValue("@Phone_No", phone)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)

                cmd.ExecuteNonQuery()
                con.Close()
                LoadDataIntoDataGridView()
                MessageBox.Show("Data inserted successfully")
            Catch ex As Exception
                MessageBox.Show("An error occurred while inserting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        End If
        cleartextBox()
    End Sub
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        InsertData()
        'cleartextBox()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            ' Get the ID of the selected row
            Dim selectedID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("ID").Value)

            ' Retrieve the current values of (Phone_No, Email, Username) for the selected row
            Dim currentPhone As String = DataGridView1.SelectedRows(0).Cells("Phone_No").Value.ToString()
            Dim currentEmail As String = DataGridView1.SelectedRows(0).Cells("Email").Value.ToString()
            Dim currentUsername As String = DataGridView1.SelectedRows(0).Cells("Username").Value.ToString()

            ' Get the values entered by the user
            Dim updatedPhone As String = txtphone.Text
            Dim updatedEmail As String = txtEmail.Text
            Dim updatedUsername As String = txtusername.Text

            ' Check if the entered values match the current values of the selected row
            If currentPhone = updatedPhone AndAlso currentEmail = updatedEmail AndAlso currentUsername = updatedUsername Then
                ' No changes made, or user is updating with the same values, allow the update
                UpdateRecord(selectedID)
                cleartextBox()
            Else
                ' Changes made, check for duplicates in other rows
                If IsDuplicateInOtherRows(updatedPhone, updatedEmail, updatedUsername) Then
                    MessageBox.Show("Duplicate values found in other rows. Please provide unique values.")
                Else
                    ' No duplicates found in other rows, allow the update
                    UpdateRecord(selectedID)
                    cleartextBox()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateRecord(selectedID As Integer)
        Try
            ' Update the record in the database
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("UpdateUserDetails", con)
            cmd.CommandType = CommandType.StoredProcedure
            ' Set parameters for the update command
            cmd.Parameters.AddWithValue("@ID", selectedID)
            cmd.Parameters.AddWithValue("@Name", txtFname.Text + " " + txtLname.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Gender", txtgender.Text)
            cmd.Parameters.AddWithValue("@Role", txtRole.Text)
            cmd.Parameters.AddWithValue("@Phone_No", txtphone.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Username", txtusername.Text)
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data updated successfully")
            con.Close()
            LoadDataIntoDataGridView()
        Catch ex As Exception
            MessageBox.Show("An error occurred while updatein records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Function IsDuplicateInOtherRows(phone As String, email As String, username As String) As Boolean
        ' Check for duplicates in other rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.Selected Then ' Skip the selected row
                Dim rowPhone As String = row.Cells("Phone_No").Value.ToString()
                Dim rowEmail As String = row.Cells("Email").Value.ToString()
                Dim rowUsername As String = row.Cells("Username").Value.ToString()

                If phone = rowPhone OrElse email = rowEmail OrElse username = rowUsername Then
                    Return True ' Duplicate found in other row
                End If
            End If
        Next

        Return False ' No duplicate found in other rows
    End Function

    Private Sub cleartextBox()
        'clear all the textboxes
        txtgender.SelectedIndex = -1
        txtFname.Clear()
        txtLname.Clear()
        txtAddress.Clear()
        txtRole.Clear()
        txtphone.Clear()
        txtEmail.Clear()
        txtusername.Clear()
        txtpassword.Clear()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            ' Check if a row is selected
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Get the ID of the selected row
                Dim selectedID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("ID").Value)

                ' Ask the user for confirmation
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' User confirmed, proceed with deletion
                    con.Open()
                    Dim cmd As SqlCommand = New SqlCommand("DeleteUserWithRestriction", con)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Set parameters for the deletion command
                    cmd.Parameters.AddWithValue("@UserID", selectedID)
                    cmd.Parameters.Add("@IsSuccess", SqlDbType.Bit).Direction = ParameterDirection.Output
                    cmd.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output

                    cmd.ExecuteNonQuery()

                    Dim isSuccess As Boolean = Convert.ToBoolean(cmd.Parameters("@IsSuccess").Value)
                    Dim errorMessage As String = Convert.ToString(cmd.Parameters("@ErrorMessage").Value)

                    con.Close()

                    If isSuccess Then
                        MessageBox.Show("Record deleted successfully")
                        LoadDataIntoDataGridView()
                    Else
                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Please select a row to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        cleartextBox()
    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

        ' Check if the total number of digits is greater than or equal to 10
        If txtphone.Text.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the total number of digits is already 10, suppress the keypress
            e.Handled = True
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        cleartextBox()
        'txtgender.SelectedIndex = -1
    End Sub
End Class