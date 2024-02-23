Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Reflection.Metadata.Ecma335
Imports Org.BouncyCastle.Crypto.Engines
Public Class order
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")
    Dim itemName As String
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Private receiptPrinted As Boolean = False

    Public Property OrderID As String
    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        txtcount.Text = i.ToString()
        Loadfloors()
        getitemCategory()
        'clear existing row in datagridview
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Loadfloors()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("getfloor", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Combofloor.Items.Add(reader("Floor"))
            End While
            con.Close()
        Catch ex As Exception
            MsgBox("error in floor loading" & ex.Message)
            con.Close()

        End Try
    End Sub
    Private Sub calculatetotal()
        'Dim total As Double = (CDbl(txtqty1.Text) * CDbl(txtpricee.Text))
        'Dim discount As Double = (CDbl(txtdiscounts.Text)) * total * 0.01
        Try
            txtamnt.Text = Format((CDbl(txtqty1.Text) * CDbl(txtpricee.Text)) - (CDbl(txtdiscounts.Text) * 0.01 * (CDbl(txtqty1.Text) * CDbl(txtpricee.Text))), "#,##0.00")
        Catch ex As Exception
            txtamnt.Text = "0.00"
        End Try
    End Sub
    Private Sub txtpricee_TextChanged(sender As Object, e As EventArgs) Handles txtpricee.TextChanged
        calculatetotal()
    End Sub

    Private Sub txtdiscounts_TextChanged(sender As Object, e As EventArgs) Handles txtdiscounts.TextChanged
        calculatetotal()
    End Sub

    Private Sub txtqty1_TextChanged(sender As Object, e As EventArgs) Handles txtqty1.TextChanged
        calculatetotal()
    End Sub

    Private Sub Combofloor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combofloor.SelectedIndexChanged
        ' Clear existing items in other ComboBoxes
        Combotabletype.Items.Clear()
        Combotableno.Items.Clear()
        gettableType()
    End Sub

    Private Sub gettableType()
        Dim selectedFloor As String = Combofloor.SelectedItem
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("gettabletype", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Floor", selectedFloor)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                ' Populate cmbtabletype with fetched table types
                While reader.Read()
                    Combotabletype.Items.Add(reader("TableType"))
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox("Error in gettin table type" & ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub gettableNo()
        Dim selectedFloor As String = Combofloor.SelectedItem
        Dim selectedTableType As String = Combotabletype.SelectedItem
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("gettableNo", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Floor", selectedFloor)
            cmd.Parameters.AddWithValue("@TableType", selectedTableType)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                ' Populate cmbtabletype with fetched table types
                While reader.Read()
                    Combotableno.Items.Add(reader("TableNo"))
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox("Error getting table no" & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Combotabletype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combotabletype.SelectedIndexChanged
        Combotableno.Items.Clear()
        gettableNo()

    End Sub

    Dim uniquecategory As New HashSet(Of String)()
    Private Sub getitemCategory()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("getproductdata", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim itemcategory As String = reader("ItemCategory").ToString()

                ' Add the table number to the HashSet if it's not already present
                If Not uniquecategory.Contains(itemcategory) Then
                    ComboitemCategory.Items.Add(itemcategory)
                    uniquecategory.Add(itemcategory)
                End If
                'ComboitemCategory.Items.Add(reader("ItemCategory"))
            End While
            con.Close()
        Catch ex As Exception
            MsgBox("Error getting itemcategory" & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub getItemname()
        Dim selectedcategory As String = ComboitemCategory.SelectedItem
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("getItemname", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@category", selectedcategory)
            Using reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ComboItemname.Items.Add(reader("ItemName"))
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox("Error getting itemname" & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub ComboitemCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboitemCategory.SelectedIndexChanged
        ComboItemname.Items.Clear()
        getItemname()
    End Sub

    Private Sub getItemprice()
        Dim selectedcategory As String = ComboitemCategory.SelectedItem
        Dim selecteditem As String = ComboItemname.SelectedItem
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("getitemprice", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@category", selectedcategory)
            cmd.Parameters.AddWithValue("@itemname", selecteditem)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    txtpricee.Text = reader("ItemPrice")
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox("Error getting item price" & ex.Message)
            con.Close()
        End Try
    End Sub

    'for item price
    Private Sub ComboItemname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboItemname.SelectedIndexChanged
        txtpricee.Clear()
        txtqty1.Clear()
        getItemprice()
    End Sub

    Private Sub getNewOrderID()
        Try
            con.Open()
            Dim newOrderNumber As String = ""
            Dim countcmd As SqlCommand = New SqlCommand("getBillitems", con)
            countcmd.CommandType = CommandType.StoredProcedure
            countcmd.ExecuteNonQuery()
            Dim sda As SqlDataAdapter = New SqlDataAdapter(countcmd)
            Dim dt As DataTable = New DataTable
            sda.Fill(dt)
            If dt.Rows.Count = 0 Then
                ' If no orders are present, set the initial order number to "Ord-100"
                newOrderNumber = "Ord-100"
            Else
                Dim cmd As SqlCommand = New SqlCommand("getOrderno", con)
                cmd.CommandType = CommandType.StoredProcedure
                Dim lastOrderNumber As String = Convert.ToString(cmd.ExecuteScalar())
                ' Increment the integer part of the last order number to create a new order number
                Dim parts As String() = lastOrderNumber.Split("-"c)
                Dim lastOrderNumberValue As Integer = Convert.ToInt32(parts(1))
                Dim newOrderNumberValue As Integer = lastOrderNumberValue + 1

                ' Create the new order number by combining the prefix and the incremented integer part
                newOrderNumber = parts(0) & "-" & newOrderNumberValue.ToString()

            End If

            ' Display the generated order number in the txtorderno TextBox
            txtorderno.Text = newOrderNumber

        Catch ex As Exception
            MsgBox("Error getting new order id" & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnneworder_Click(sender As Object, e As EventArgs) Handles btnneworder.Click
        ' Check if DataGridView has any rows
        Dim i As Integer = 0
        txtcount.Text = i.ToString()
        If DataGridView1.Rows.Count > 0 Then
            ' If DataGridView has data, show a message box
            MessageBox.Show("Please save the data before new order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return ' Exit the event handler
        End If

        getNewOrderID()
        Combofloor.Enabled = True
        Combotableno.Enabled = True
        Combotabletype.Enabled = True

    End Sub

    Public Sub Loadrecords()
        Try
            Dim _subtotal As Double = 0
            DataGridView1.Rows.Clear()
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("getOrdereditems", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@oderID", txtorderno.Text)
            Dim dr As SqlDataReader = cmd.ExecuteReader()

            ' Loop through the result set and add rows to the DataGridView
            Dim i As Integer = 0
            While dr.Read()
                i += 1
                _subtotal += CDbl(dr.Item("Amount").ToString)
                DataGridView1.Rows.Add(i, dr.Item("ItemName").ToString, dr.Item("ItemDesc").ToString, dr.Item("Qty").ToString, Format(CDbl(dr.Item("Price").ToString), "#,##0.00"), Format(CDbl(dr.Item("Amount").ToString), "#,##0.00"))

            End While
            dr.Close()
            con.Close()
            txttotalamount.Text = Format(_subtotal, "#,##0.00")
        Catch ex As Exception
            MessageBox.Show("An error occurred loading order records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()

        End Try

    End Sub

    Private Sub btnaddorder_Click(sender As Object, e As EventArgs) Handles btnaddorder.Click
        If Combofloor.SelectedItem = String.Empty Or Combotabletype.SelectedItem = String.Empty Then
            MsgBox("Required  missing fields!", vbCritical)
            Return
        End If
        If ComboitemCategory.SelectedItem = String.Empty Or ComboItemname.SelectedItem = String.Empty Or txtqty1.Text = String.Empty Or txtorderno.Text = String.Empty Then
            MsgBox("Required  missing fields!", vbCritical)
            Return
        End If

        If txtpricee.Text = String.Empty Then
            Return
        End If

        Dim category As String = ComboitemCategory.SelectedItem
        Dim itemname As String = ComboItemname.SelectedItem
        Dim itemdescription As String = ""
        Dim amountValue, priceValue As Decimal
        Dim qtyValue As Integer = Convert.ToInt32(txtqty1.Text)

        Decimal.TryParse(txtamnt.Text, amountValue)
        Decimal.TryParse(txtpricee.Text, priceValue)


        'getting item description
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("getitemdescription", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@category", category)
            cmd.Parameters.AddWithValue("@itemname", itemname)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    itemdescription = reader("ItemDescription")
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox("Error getting item description" & ex.Message)
            con.Close()
        End Try

        'inserting order

        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("insertOrder", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@OrderID", txtorderno.Text)
            cmd.Parameters.AddWithValue("@ItemName", itemname)
            cmd.Parameters.AddWithValue("@ItemDesc", itemdescription)
            cmd.Parameters.AddWithValue("@Qty", qtyValue)
            cmd.Parameters.AddWithValue("@Price", priceValue)
            cmd.Parameters.AddWithValue("@Amount", amountValue)
            cmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Error inserting order" & ex.Message)
            con.Close()
        End Try

        Loadrecords()   'load saved records into the datagridview
        UpdateSavedOrder()  'load saved records into the datagridview
        Dim count As Integer = 1
        Combofloor.Enabled = False
        Combotabletype.Enabled = False
        Combotableno.Enabled = False
    End Sub
    Private Sub UpdateSavedOrder()
        Dim counts As Integer = 0
        Dim tblNO As String
        Dim counting As Integer = Convert.ToInt32(txtcount.Text)
        If counting = 0 Then
            tblNO = Combotableno.SelectedItem
        Else
            tblNO = Txttableno.Text
        End If
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("Checksavedorders", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@OrderID", txtorderno.Text)
            cmd.ExecuteNonQuery()
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            sda.Fill(dt)
            If dt.Rows.Count > 0 Then
                counts += 1
            End If
            con.Close()
            If counts = 1 Then
                con.Open()
                Dim cmd1 As SqlCommand = New SqlCommand("UpdateOrderssaved", con)
                cmd1.CommandType = CommandType.StoredProcedure
                With cmd1.Parameters
                    .AddWithValue("@OrderID", txtorderno.Text)
                    .AddWithValue("@floor", Combofloor.SelectedItem)
                    .AddWithValue("@TableType", Combotabletype.SelectedItem)
                    .AddWithValue("@TableNO", tblNO)
                End With
                cmd1.ExecuteNonQuery()
                con.Close()
            Else
                con.Open()
                Dim cmd2 As SqlCommand = New SqlCommand("insertordersaved", con)
                cmd2.CommandType = CommandType.StoredProcedure
                With cmd2.Parameters
                    .AddWithValue("@OrderID", txtorderno.Text)
                    .AddWithValue("@floor", Combofloor.SelectedItem)
                    .AddWithValue("@TableType", Combotabletype.SelectedItem)
                    .AddWithValue("@TableNO", tblNO)
                End With
                cmd2.ExecuteNonQuery()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("Error updateing saved order" & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        If DataGridView1.Rows.Count = 0 Then
            Return
        End If
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("DeleteBillitems", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@OrderID", txtorderno.Text)
                cmd.Parameters.AddWithValue("@ItemName", itemName)
                cmd.ExecuteNonQuery()
                con.Close()
                Loadrecords()
            Catch ex As Exception
                MsgBox("delete failed!" & ex.Message)
                con.Close()
            End Try
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Assuming the "Item Name" column is the first column (index 0) in your DataGridView
        If e.RowIndex >= 0 Then
            itemName = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtpricee.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            Dim quantity As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtqty1.Text = quantity
        End If
    End Sub

    Private Sub txtqty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty1.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub

    Private Sub txtdiscounts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiscounts.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub

    Private Sub UpdateQty()
        If txtqty1.Text = String.Empty Or DataGridView1.Rows.Count = 0 Then
            Return
        End If
        Dim amountValue As Decimal
        Decimal.TryParse(txtamnt.Text, amountValue)
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("UpdateBillQty", con)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@OrderID", txtorderno.Text)
                .AddWithValue("@ItemName", itemName)
                .AddWithValue("@Amount", amountValue)
                .AddWithValue("@Qty", txtqty1.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                Loadrecords()
            End With
        Catch ex As Exception
            MsgBox("update quantity  failed!" & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        UpdateQty()
    End Sub

    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        If DataGridView1.Rows.Count = 0 Then
            ' If DataGridView is empty, show a message box
            MessageBox.Show("Please enter data before saving.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return ' Exit the event handler
        Else
            DataGridView1.Rows.Clear()
            MessageBox.Show("Order Saved Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtorderno.Clear()
        End If
    End Sub

    Private Sub btnvieworder_Click(sender As Object, e As EventArgs) Handles btnvieworder.Click
        If DataGridView1.Rows.Count > 0 Then
            MsgBox("Please save the current order!", vbInformation)
            Return
        End If
        With SavedOrders
            .Loadrecords()
            .ShowDialog()
        End With
        Combofloor.Enabled = True
        Combotableno.Enabled = True
        Combotabletype.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Combofloor.Enabled = True
        Combotableno.Enabled = True
        Combotabletype.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Cash" Then
            txttender.Enabled = True
        Else
            txttender.Text = "0.00"
            txtchange.Text = "0.00"
            txttender.Enabled = False
        End If
    End Sub

    Private Sub txttender_TextChanged(sender As Object, e As EventArgs) Handles txttender.TextChanged
        If txttender.Text <> String.Empty Then
            txtchange.Text = Format(CDbl(txttender.Text) - CDbl(txttotalamount.Text), "#,##0.00")
        End If
    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = rowcount * 15 + 700
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("please select order first", vbCritical)
            Return
        End If
        If ComboBox1.SelectedItem = String.Empty Then
            MsgBox("Please select payment method", vbInformation)
            Return
        End If
        ' Ask user for confirmation with customized message
        Dim result As DialogResult = MessageBox.Show("Please make sure to select a valid order to print the receipt." & vbCrLf & "Click 'Yes' to confirm deletion or 'No' to cancel.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Check user's response
        If result = DialogResult.Yes Then
            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()
        End If

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 300, longpaper) ' Adjust the width and height as needed
        PD.DefaultPageSettings = pagesetup

    End Sub

    Private Sub deletedprintedOrder()
        OrderID = txtorderno.Text
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("DeletePrintedOrder", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@OrderID", OrderID)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Printed order deletion failed!")
            con.Close()
        End Try
        DataGridView1.Rows.Clear()
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftMargin As Integer = 10
        Dim topMargin As Integer = 10

        Dim lineHeight As Integer = 20
        getcafeinto()

        Dim orderno As String = txtorderno.Text
        Dim parts As String() = orderno.Split("-"c)
        Dim invoiceno As String = parts(1)



        ' Draw header
        e.Graphics.DrawString(cafename.ToUpper(), f14, Brushes.Black, 100, topMargin)
        e.Graphics.DrawString(cafeaddress.ToUpper(), f10, Brushes.Black, 110, topMargin + 20)
        e.Graphics.DrawString("Ph.Not:" & cafecontact, f10, Brushes.Black, 120, topMargin + 40)

        ' Draw invoice details
        e.Graphics.DrawString("Invoice #:", f8, Brushes.Black, leftMargin, topMargin + 100)
        e.Graphics.DrawString("inv-" & invoiceno, f8, Brushes.Black, leftMargin + 60, topMargin + 100)

        'e.Graphics.DrawString("Cashier:", f8, Brushes.Black, leftMargin, topMargin + 100)
        'e.Graphics.DrawString("Yubi Stona", f8, Brushes.Black, leftMargin + 60, topMargin + 100)

        e.Graphics.DrawString("Transaction Date:", f8, Brushes.Black, leftMargin, topMargin + 120)
        e.Graphics.DrawString(DateTime.Now.ToString(), f8, Brushes.Black, leftMargin + 100, topMargin + 120)

        ' Draw table header
        e.Graphics.DrawString("SN", f10b, Brushes.Black, leftMargin, topMargin + 160)
        e.Graphics.DrawString("Items", f10b, Brushes.Black, leftMargin + 30, topMargin + 160)
        e.Graphics.DrawString("Qty", f10b, Brushes.Black, leftMargin + 130, topMargin + 160)
        e.Graphics.DrawString("Rate", f10b, Brushes.Black, leftMargin + 180, topMargin + 160)
        e.Graphics.DrawString("Amount", f10b, Brushes.Black, leftMargin + 230, topMargin + 160)

        ' Draw table rows
        Dim currentY As Integer = topMargin + 180
        Dim rowIndex As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If rowIndex = DataGridView1.NewRowIndex Then Exit For ' Skip new row
            Dim sn As String = (rowIndex + 1).ToString()
            Dim item As String = row.Cells(1).Value.ToString()
            Dim qty As String = row.Cells(3).Value.ToString()
            Dim rate As String = row.Cells(4).Value.ToString()
            Dim amount As String = row.Cells(5).Value.ToString()

            e.Graphics.DrawString(sn, f10, Brushes.Black, leftMargin, currentY)
            e.Graphics.DrawString(item, f10, Brushes.Black, leftMargin + 30, currentY)
            e.Graphics.DrawString(qty, f10, Brushes.Black, leftMargin + 130, currentY)
            e.Graphics.DrawString(rate, f10, Brushes.Black, leftMargin + 180, currentY)
            e.Graphics.DrawString(amount, f10, Brushes.Black, leftMargin + 230, currentY)

            currentY += lineHeight
            rowIndex += 1
        Next

        ' Draw total section
        Dim totalY As Integer = currentY + lineHeight
        e.Graphics.DrawString("Net Amount :", f10, Brushes.Black, 150, totalY)
        e.Graphics.DrawString(txttotalamount.Text, f10, Brushes.Black, leftMargin + 230, totalY)

        totalY += lineHeight
        e.Graphics.DrawString("Tender           :", f10, Brushes.Black, 150, totalY)
        'e.Graphics.DrawString(txttender.Text, f10, Brushes.Black, leftMargin + 230, totalY)
        e.Graphics.DrawString(Convert.ToDecimal(txttender.Text).ToString("0.00"), f10, Brushes.Black, leftMargin + 230, totalY)

        totalY += lineHeight
        e.Graphics.DrawString("Change          :", f10, Brushes.Black, 150, totalY)
        e.Graphics.DrawString(txtchange.Text, f10, Brushes.Black, leftMargin + 230, totalY)

        ' Draw closing message
        totalY += lineHeight
        e.Graphics.DrawString("THANK YOU FOR VISITING", f10b, Brushes.Black, leftMargin + 70, totalY + 10)
        deletedprintedOrder()
    End Sub

    Dim cafename As String
    Dim cafeaddress As String
    Dim cafecontact As Double
    Sub getcafeinto()
        Try
            con.Open()
            Dim cmd As New SqlCommand("getcafeinfo", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cafename = reader("Name")
                cafeaddress = reader("Address")
                cafecontact = reader("contact")
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("failed to load cafe information")
            con.Close()
        End Try
    End Sub

    Private Sub txttender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttender.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub
End Class