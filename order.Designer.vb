<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(order))
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Button1 = New Button()
        Label11 = New Label()
        DateTimePicker1 = New DateTimePicker()
        txtorderno = New TextBox()
        Label10 = New Label()
        Combotableno = New ComboBox()
        Combotabletype = New ComboBox()
        Combofloor = New ComboBox()
        ComboitemCategory = New ComboBox()
        ComboItemname = New ComboBox()
        txtamnt = New TextBox()
        txtdiscounts = New TextBox()
        txtpricee = New TextBox()
        txtqty1 = New TextBox()
        Label9 = New Label()
        btnaddorder = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Txttableno = New TextBox()
        txtcount = New TextBox()
        btnprint = New Button()
        Label15 = New Label()
        txtchange = New TextBox()
        Label14 = New Label()
        txttender = New TextBox()
        Label13 = New Label()
        ComboBox1 = New ComboBox()
        btnvieworder = New Button()
        Label12 = New Label()
        txttotalamount = New TextBox()
        btnneworder = New Button()
        btnupdate = New Button()
        btnsave1 = New Button()
        deletebtn = New Button()
        Panel3 = New Panel()
        DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Column6 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(txtorderno)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Combotableno)
        Panel1.Controls.Add(Combotabletype)
        Panel1.Controls.Add(Combofloor)
        Panel1.Controls.Add(ComboitemCategory)
        Panel1.Controls.Add(ComboItemname)
        Panel1.Controls.Add(txtamnt)
        Panel1.Controls.Add(txtdiscounts)
        Panel1.Controls.Add(txtpricee)
        Panel1.Controls.Add(txtqty1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(btnaddorder)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1061, 179)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(976, 108)
        Button1.Name = "Button1"
        Button1.Size = New Size(46, 53)
        Button1.TabIndex = 65
        Button1.Text = "   "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(795, 24)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 23)
        Label11.TabIndex = 64
        Label11.Text = "Date"
        Label11.Visible = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top
        DateTimePicker1.Enabled = False
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(795, 50)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(126, 27)
        DateTimePicker1.TabIndex = 63
        DateTimePicker1.Visible = False
        ' 
        ' txtorderno
        ' 
        txtorderno.Anchor = AnchorStyles.Top
        txtorderno.BorderStyle = BorderStyle.FixedSingle
        txtorderno.Location = New Point(615, 50)
        txtorderno.Name = "txtorderno"
        txtorderno.ReadOnly = True
        txtorderno.Size = New Size(152, 27)
        txtorderno.TabIndex = 62
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(615, 24)
        Label10.Name = "Label10"
        Label10.Size = New Size(76, 23)
        Label10.TabIndex = 61
        Label10.Text = "Order ID"
        ' 
        ' Combotableno
        ' 
        Combotableno.Anchor = AnchorStyles.Top
        Combotableno.DropDownStyle = ComboBoxStyle.DropDownList
        Combotableno.FormattingEnabled = True
        Combotableno.Location = New Point(421, 49)
        Combotableno.Name = "Combotableno"
        Combotableno.Size = New Size(157, 28)
        Combotableno.TabIndex = 60
        ' 
        ' Combotabletype
        ' 
        Combotabletype.Anchor = AnchorStyles.Top
        Combotabletype.DropDownStyle = ComboBoxStyle.DropDownList
        Combotabletype.FormattingEnabled = True
        Combotabletype.Location = New Point(203, 49)
        Combotabletype.Name = "Combotabletype"
        Combotabletype.Size = New Size(191, 28)
        Combotabletype.TabIndex = 59
        ' 
        ' Combofloor
        ' 
        Combofloor.Anchor = AnchorStyles.Top
        Combofloor.DropDownStyle = ComboBoxStyle.DropDownList
        Combofloor.FormattingEnabled = True
        Combofloor.Location = New Point(33, 49)
        Combofloor.Name = "Combofloor"
        Combofloor.Size = New Size(151, 28)
        Combofloor.TabIndex = 58
        ' 
        ' ComboitemCategory
        ' 
        ComboitemCategory.Anchor = AnchorStyles.Top
        ComboitemCategory.DropDownStyle = ComboBoxStyle.DropDownList
        ComboitemCategory.FormattingEnabled = True
        ComboitemCategory.Location = New Point(33, 123)
        ComboitemCategory.Name = "ComboitemCategory"
        ComboitemCategory.Size = New Size(191, 28)
        ComboitemCategory.TabIndex = 57
        ' 
        ' ComboItemname
        ' 
        ComboItemname.Anchor = AnchorStyles.Top
        ComboItemname.DropDownStyle = ComboBoxStyle.DropDownList
        ComboItemname.FormattingEnabled = True
        ComboItemname.Location = New Point(238, 122)
        ComboItemname.Name = "ComboItemname"
        ComboItemname.Size = New Size(220, 28)
        ComboItemname.TabIndex = 53
        ' 
        ' txtamnt
        ' 
        txtamnt.Anchor = AnchorStyles.Top
        txtamnt.BackColor = Color.White
        txtamnt.BorderStyle = BorderStyle.FixedSingle
        txtamnt.Location = New Point(795, 124)
        txtamnt.Name = "txtamnt"
        txtamnt.ReadOnly = True
        txtamnt.Size = New Size(114, 27)
        txtamnt.TabIndex = 56
        txtamnt.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtdiscounts
        ' 
        txtdiscounts.Anchor = AnchorStyles.Top
        txtdiscounts.BackColor = Color.White
        txtdiscounts.BorderStyle = BorderStyle.FixedSingle
        txtdiscounts.Location = New Point(687, 124)
        txtdiscounts.Name = "txtdiscounts"
        txtdiscounts.Size = New Size(99, 27)
        txtdiscounts.TabIndex = 55
        txtdiscounts.Text = "0"
        txtdiscounts.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtpricee
        ' 
        txtpricee.Anchor = AnchorStyles.Top
        txtpricee.BackColor = Color.White
        txtpricee.BorderStyle = BorderStyle.FixedSingle
        txtpricee.Location = New Point(573, 124)
        txtpricee.Name = "txtpricee"
        txtpricee.ReadOnly = True
        txtpricee.Size = New Size(104, 27)
        txtpricee.TabIndex = 54
        txtpricee.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtqty1
        ' 
        txtqty1.Anchor = AnchorStyles.Top
        txtqty1.BackColor = Color.White
        txtqty1.BorderStyle = BorderStyle.FixedSingle
        txtqty1.Location = New Point(474, 124)
        txtqty1.Name = "txtqty1"
        txtqty1.Size = New Size(90, 27)
        txtqty1.TabIndex = 53
        txtqty1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(687, 96)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 23)
        Label9.TabIndex = 18
        Label9.Text = "Discount"
        ' 
        ' btnaddorder
        ' 
        btnaddorder.Anchor = AnchorStyles.Top
        btnaddorder.BackColor = Color.Transparent
        btnaddorder.BackgroundImage = CType(resources.GetObject("btnaddorder.BackgroundImage"), Image)
        btnaddorder.BackgroundImageLayout = ImageLayout.Zoom
        btnaddorder.FlatAppearance.BorderSize = 0
        btnaddorder.FlatStyle = FlatStyle.Flat
        btnaddorder.Location = New Point(915, 108)
        btnaddorder.Name = "btnaddorder"
        btnaddorder.Size = New Size(55, 52)
        btnaddorder.TabIndex = 17
        btnaddorder.Text = "   "
        btnaddorder.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(795, 96)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 23)
        Label8.TabIndex = 15
        Label8.Text = "Amount"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(573, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 23)
        Label7.TabIndex = 13
        Label7.Text = "Price"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(474, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 23)
        Label6.TabIndex = 11
        Label6.Text = "Qty"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(241, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 23)
        Label5.TabIndex = 9
        Label5.Text = "Item Name"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(33, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 23)
        Label4.TabIndex = 7
        Label4.Text = "Item Category"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(426, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 23)
        Label3.TabIndex = 5
        Label3.Text = "Select Table"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(216, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 23)
        Label2.TabIndex = 3
        Label2.Text = " Table Type"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 23)
        Label1.TabIndex = 0
        Label1.Text = "Select FLoor"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Txttableno)
        Panel2.Controls.Add(txtcount)
        Panel2.Controls.Add(btnprint)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(txtchange)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(txttender)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(btnvieworder)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(txttotalamount)
        Panel2.Controls.Add(btnneworder)
        Panel2.Controls.Add(btnupdate)
        Panel2.Controls.Add(btnsave1)
        Panel2.Controls.Add(deletebtn)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 511)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1061, 135)
        Panel2.TabIndex = 1
        ' 
        ' Txttableno
        ' 
        Txttableno.BorderStyle = BorderStyle.FixedSingle
        Txttableno.Location = New Point(655, 88)
        Txttableno.Name = "Txttableno"
        Txttableno.Size = New Size(132, 27)
        Txttableno.TabIndex = 102
        Txttableno.Visible = False
        ' 
        ' txtcount
        ' 
        txtcount.BorderStyle = BorderStyle.FixedSingle
        txtcount.Location = New Point(524, 87)
        txtcount.Name = "txtcount"
        txtcount.Size = New Size(125, 27)
        txtcount.TabIndex = 101
        txtcount.Visible = False
        ' 
        ' btnprint
        ' 
        btnprint.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnprint.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnprint.ForeColor = Color.DarkOrange
        btnprint.Image = CType(resources.GetObject("btnprint.Image"), Image)
        btnprint.ImageAlign = ContentAlignment.TopCenter
        btnprint.Location = New Point(428, 34)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(69, 81)
        btnprint.TabIndex = 100
        btnprint.Text = "Print"
        btnprint.TextAlign = ContentAlignment.BottomCenter
        btnprint.TextImageRelation = TextImageRelation.ImageAboveText
        btnprint.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(824, 87)
        Label15.Name = "Label15"
        Label15.Size = New Size(69, 23)
        Label15.TabIndex = 99
        Label15.Text = "Change"
        ' 
        ' txtchange
        ' 
        txtchange.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtchange.BorderStyle = BorderStyle.FixedSingle
        txtchange.Location = New Point(899, 87)
        txtchange.Name = "txtchange"
        txtchange.ReadOnly = True
        txtchange.Size = New Size(150, 27)
        txtchange.TabIndex = 98
        txtchange.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(832, 49)
        Label14.Name = "Label14"
        Label14.Size = New Size(61, 23)
        Label14.TabIndex = 97
        Label14.Text = "Tender"
        ' 
        ' txttender
        ' 
        txttender.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txttender.BorderStyle = BorderStyle.FixedSingle
        txttender.Enabled = False
        txttender.Location = New Point(899, 49)
        txttender.Name = "txttender"
        txttender.Size = New Size(150, 27)
        txttender.TabIndex = 96
        txttender.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(533, 11)
        Label13.Name = "Label13"
        Label13.Size = New Size(116, 20)
        Label13.TabIndex = 95
        Label13.Text = "Payment mode:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Cash", "Card"})
        ComboBox1.Location = New Point(650, 8)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(132, 28)
        ComboBox1.TabIndex = 94
        ' 
        ' btnvieworder
        ' 
        btnvieworder.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnvieworder.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnvieworder.ForeColor = Color.DarkOrange
        btnvieworder.Image = CType(resources.GetObject("btnvieworder.Image"), Image)
        btnvieworder.ImageAlign = ContentAlignment.TopCenter
        btnvieworder.Location = New Point(180, 33)
        btnvieworder.Name = "btnvieworder"
        btnvieworder.Size = New Size(92, 81)
        btnvieworder.TabIndex = 93
        btnvieworder.Text = "view order"
        btnvieworder.TextAlign = ContentAlignment.BottomCenter
        btnvieworder.TextImageRelation = TextImageRelation.ImageAboveText
        btnvieworder.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(788, 8)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 23)
        Label12.TabIndex = 92
        Label12.Text = "Net Amount"
        ' 
        ' txttotalamount
        ' 
        txttotalamount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txttotalamount.BorderStyle = BorderStyle.FixedSingle
        txttotalamount.Location = New Point(899, 6)
        txttotalamount.Name = "txttotalamount"
        txttotalamount.ReadOnly = True
        txttotalamount.Size = New Size(150, 27)
        txttotalamount.TabIndex = 91
        txttotalamount.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnneworder
        ' 
        btnneworder.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnneworder.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnneworder.ForeColor = Color.DarkOrange
        btnneworder.Image = CType(resources.GetObject("btnneworder.Image"), Image)
        btnneworder.ImageAlign = ContentAlignment.TopCenter
        btnneworder.Location = New Point(26, 34)
        btnneworder.Name = "btnneworder"
        btnneworder.Size = New Size(69, 81)
        btnneworder.TabIndex = 90
        btnneworder.Text = "New "
        btnneworder.TextAlign = ContentAlignment.BottomCenter
        btnneworder.TextImageRelation = TextImageRelation.ImageAboveText
        btnneworder.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnupdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnupdate.ForeColor = Color.Teal
        btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), Image)
        btnupdate.ImageAlign = ContentAlignment.TopCenter
        btnupdate.Location = New Point(278, 34)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(69, 81)
        btnupdate.TabIndex = 88
        btnupdate.Text = "update"
        btnupdate.TextAlign = ContentAlignment.BottomCenter
        btnupdate.TextImageRelation = TextImageRelation.ImageAboveText
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btnsave1
        ' 
        btnsave1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnsave1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsave1.ForeColor = Color.DarkOrange
        btnsave1.Image = CType(resources.GetObject("btnsave1.Image"), Image)
        btnsave1.ImageAlign = ContentAlignment.TopCenter
        btnsave1.Location = New Point(105, 33)
        btnsave1.Name = "btnsave1"
        btnsave1.Size = New Size(69, 81)
        btnsave1.TabIndex = 87
        btnsave1.Text = "save"
        btnsave1.TextAlign = ContentAlignment.BottomCenter
        btnsave1.TextImageRelation = TextImageRelation.ImageAboveText
        btnsave1.UseVisualStyleBackColor = True
        ' 
        ' deletebtn
        ' 
        deletebtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        deletebtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        deletebtn.ForeColor = Color.Teal
        deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), Image)
        deletebtn.ImageAlign = ContentAlignment.TopCenter
        deletebtn.Location = New Point(353, 34)
        deletebtn.Name = "deletebtn"
        deletebtn.Size = New Size(69, 81)
        deletebtn.TabIndex = 89
        deletebtn.Text = "delete"
        deletebtn.TextAlign = ContentAlignment.BottomCenter
        deletebtn.TextImageRelation = TextImageRelation.ImageAboveText
        deletebtn.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DataGridView1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 179)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1061, 332)
        Panel3.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle10.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle11.ForeColor = Color.White
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridView1.ColumnHeadersHeight = 27
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column6, Column1, Column2, Column3, Column4, Column5})
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle12.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1061, 332)
        DataGridView1.TabIndex = 40
        DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        DataGridView1.ThemeStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised
        DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView1.ThemeStyle.HeaderStyle.Height = 27
        DataGridView1.ThemeStyle.ReadOnly = True
        DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridView1.ThemeStyle.RowsStyle.Height = 29
        DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "SN"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 57
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column1.HeaderText = "Item Name"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 200
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Item Description"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Qty"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 61
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Unit Price"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 101
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Total Amount"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 128
        ' 
        ' order
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1061, 646)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "order"
        StartPosition = FormStartPosition.CenterScreen
        Text = "order"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtamount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnaddorder As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtdiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents txtqty1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtamnt As TextBox
    Friend WithEvents txtdiscounts As TextBox
    Friend WithEvents txtpricee As TextBox
    Friend WithEvents ComboItemname As ComboBox
    Friend WithEvents Combotableno As ComboBox
    Friend WithEvents Combotabletype As ComboBox
    Friend WithEvents Combofloor As ComboBox
    Friend WithEvents ComboitemCategory As ComboBox
    Friend WithEvents txtorderno As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnsave1 As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents btnneworder As Button
    Friend WithEvents txttotalamount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnvieworder As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txttender As TextBox
    Friend WithEvents btnprint As Button
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Txttableno As TextBox
    Friend WithEvents txtcount As TextBox
End Class
