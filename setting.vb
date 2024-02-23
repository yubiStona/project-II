Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Globalization

Public Class setting
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        If txtaddress.Text = String.Empty Or txtname.Text = String.Empty Or txtcontact.Text = String.Empty Then
            Return
        End If
        Dim contact As Decimal = Convert.ToDecimal(txtcontact.Text)
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("Cafeinformation", con)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@Name", txtname.Text)
                .AddWithValue("@Address", txtaddress.Text)
                .AddWithValue("@contact", contact)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("reatart the application to see changes", vbInformation)
            con.Close()
        Catch ex As Exception
            MsgBox("Error inserting data" & ex.Message, vbCritical)
            con.Close()
        End Try
        With mainform
            .getcafeInfo()
        End With
    End Sub
    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

        ' Check if the total number of digits is greater than or equal to 10
        If txtcontact.Text.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the total number of digits is already 10, suppress the keypress
            e.Handled = True
        End If
    End Sub

    Public Sub Loadrecords()
        Try
            Dim _subtotal As Double = 0
            DataGridView1.Rows.Clear()
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("DataReport", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader = cmd.ExecuteReader()

            ' Loop through the result set and add rows to the DataGridView
            Dim i As Integer = 0
            While dr.Read()
                i += 1
                _subtotal += CDbl(dr.Item("Amount").ToString)
                DataGridView1.Rows.Add(i, dr.Item("ItemName").ToString, dr.Item("Qty").ToString, Format(CDbl(dr.Item("Price").ToString), "#,##0.00"), Format(CDbl(dr.Item("Amount").ToString), "#,##0.00"), dr.Item("Date").ToString)

            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred loading order records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()

        End Try

    End Sub

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadrecords()
    End Sub

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Private receiptPrinted As Boolean = False
    Private Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = rowcount * 15 + 700
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        ' Ask user for confirmation with customized message
        Dim result As DialogResult = MessageBox.Show("Are you sure to generate the report." & vbCrLf & "Click 'Yes' to confirm or 'No' to cancel.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Check user's response
        If result = DialogResult.Yes Then
            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()
        End If
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 400, longpaper) ' Adjust the width and height as needed
        PD.DefaultPageSettings = pagesetup
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

        ' Draw header
        e.Graphics.DrawString(cafename.ToUpper(), f14, Brushes.Black, 80, topMargin)
        e.Graphics.DrawString(cafeaddress.ToUpper(), f10, Brushes.Black, 100, topMargin + 20)
        e.Graphics.DrawString(cafecontact.ToString(), f10, Brushes.Black, 105, topMargin + 40)

        ' Draw table header
        e.Graphics.DrawString("SN", f10b, Brushes.Black, leftMargin, topMargin + 80)
        e.Graphics.DrawString("Item Name", f10b, Brushes.Black, leftMargin + 30, topMargin + 80)
        e.Graphics.DrawString("Qty", f10b, Brushes.Black, leftMargin + 130, topMargin + 80)
        e.Graphics.DrawString("Price", f10b, Brushes.Black, leftMargin + 180, topMargin + 80)
        e.Graphics.DrawString("Amount", f10b, Brushes.Black, leftMargin + 230, topMargin + 80)
        e.Graphics.DrawString("Date", f10b, Brushes.Black, leftMargin + 300, topMargin + 80)

        ' Draw table rows
        Dim currentY As Integer = topMargin + 100
        Dim rowIndex As Integer = 0
        Dim netTotal As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If rowIndex = DataGridView1.NewRowIndex Then Exit For ' Skip new row
            Dim sn As String = (rowIndex + 1).ToString()
            Dim itemName As String = row.Cells(1).Value.ToString()
            Dim qty As String = row.Cells(2).Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(row.Cells(3).Value)
            Dim amount As Decimal = Convert.ToDecimal(row.Cells(4).Value)
            Dim dateValue As Date = Date.ParseExact(row.Cells(5).Value.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
            Dim formattedDate As String = dateValue.ToString("M/d/yyyy")

            e.Graphics.DrawString(sn, f10, Brushes.Black, leftMargin, currentY)
            e.Graphics.DrawString(itemName, f10, Brushes.Black, leftMargin + 30, currentY)
            e.Graphics.DrawString(qty, f10, Brushes.Black, leftMargin + 130, currentY)
            e.Graphics.DrawString(price.ToString("0.00"), f10, Brushes.Black, leftMargin + 180, currentY)
            e.Graphics.DrawString(amount.ToString("0.00"), f10, Brushes.Black, leftMargin + 230, currentY)
            e.Graphics.DrawString(formattedDate, f10, Brushes.Black, leftMargin + 280, currentY)


            netTotal += amount ' Accumulate net total
            currentY += lineHeight
            rowIndex += 1
        Next

        ' Draw net total
        Dim totalY As Integer = currentY + lineHeight
        e.Graphics.DrawString("Net Total :", f10, Brushes.Black, leftMargin + 180, totalY)
        e.Graphics.DrawString(netTotal.ToString("0.00"), f10, Brushes.Black, leftMargin + 240, totalY)

        ' Draw closing message
        totalY += lineHeight
        e.Graphics.DrawString("TOTAL SALES REPORT", f10b, Brushes.Black, leftMargin + 70, totalY + 10)
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


End Class