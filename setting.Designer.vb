<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setting))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnsave1 = New Button()
        Label4 = New Label()
        txtcontact = New TextBox()
        Label3 = New Label()
        txtaddress = New TextBox()
        Label2 = New Label()
        txtname = New TextBox()
        Panel1 = New Panel()
        Label5 = New Label()
        btnprint = New Button()
        Panel2 = New Panel()
        DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Column6 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        Panel4 = New Panel()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 23)
        Label1.TabIndex = 65
        Label1.Text = "click here to add cafe details"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnsave1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtcontact)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtaddress)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtname)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(70, 9)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(955, 102)
        GroupBox1.TabIndex = 66
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cafe Details"
        GroupBox1.Visible = False
        ' 
        ' btnsave1
        ' 
        btnsave1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnsave1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsave1.ForeColor = Color.DarkOrange
        btnsave1.Image = CType(resources.GetObject("btnsave1.Image"), Image)
        btnsave1.ImageAlign = ContentAlignment.TopCenter
        btnsave1.Location = New Point(867, 22)
        btnsave1.Name = "btnsave1"
        btnsave1.Size = New Size(62, 62)
        btnsave1.TabIndex = 88
        btnsave1.TextAlign = ContentAlignment.BottomCenter
        btnsave1.TextImageRelation = TextImageRelation.ImageAboveText
        btnsave1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(423, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 5
        Label4.Text = "Contact:"
        ' 
        ' txtcontact
        ' 
        txtcontact.BorderStyle = BorderStyle.FixedSingle
        txtcontact.Location = New Point(507, 26)
        txtcontact.Name = "txtcontact"
        txtcontact.Size = New Size(336, 27)
        txtcontact.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 3
        Label3.Text = "Address :"
        ' 
        ' txtaddress
        ' 
        txtaddress.BorderStyle = BorderStyle.FixedSingle
        txtaddress.Location = New Point(81, 61)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(336, 27)
        txtaddress.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name :"
        ' 
        ' txtname
        ' 
        txtname.BorderStyle = BorderStyle.FixedSingle
        txtname.Location = New Point(81, 26)
        txtname.Name = "txtname"
        txtname.Size = New Size(336, 27)
        txtname.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnprint)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1154, 69)
        Panel1.TabIndex = 67
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(562, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(284, 23)
        Label5.TabIndex = 102
        Label5.Text = "Click on the icon to generate report"
        ' 
        ' btnprint
        ' 
        btnprint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnprint.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnprint.ForeColor = Color.DarkOrange
        btnprint.Image = CType(resources.GetObject("btnprint.Image"), Image)
        btnprint.ImageAlign = ContentAlignment.TopCenter
        btnprint.Location = New Point(857, 10)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(69, 54)
        btnprint.TabIndex = 101
        btnprint.TextAlign = ContentAlignment.BottomCenter
        btnprint.TextImageRelation = TextImageRelation.ImageAboveText
        btnprint.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1154, 577)
        Panel2.TabIndex = 68
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 27
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column6, Column1, Column3, Column4, Column5, Column7})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1154, 450)
        DataGridView1.TabIndex = 41
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
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Item Name"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
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
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Unit Price"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Total Amount"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column7.HeaderText = "Date"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(GroupBox1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1154, 127)
        Panel3.TabIndex = 67
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(DataGridView1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 127)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1154, 450)
        Panel4.TabIndex = 68
        ' 
        ' setting
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(243), CByte(228))
        ClientSize = New Size(1154, 646)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "setting"
        Text = "setting"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents btnsave1 As Button
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnprint As Button
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
End Class
