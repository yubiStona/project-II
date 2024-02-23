<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavedOrders
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SavedOrders))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Column5 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        searchorder = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        deletebtn = New Button()
        Panel1 = New Panel()
        btnexit = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.BackgroundColor = Color.WhiteSmoke
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column5, Column1, Column2, Column3, Column4})
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
        DataGridView1.Size = New Size(748, 336)
        DataGridView1.TabIndex = 41
        DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        DataGridView1.ThemeStyle.BackColor = Color.WhiteSmoke
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
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "SN"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 57
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Order ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Floor"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Table Type"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Table No"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' searchorder
        ' 
        searchorder.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        searchorder.BorderColor = Color.Black
        searchorder.CustomizableEdges = CustomizableEdges1
        searchorder.DefaultText = ""
        searchorder.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        searchorder.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        searchorder.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        searchorder.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        searchorder.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        searchorder.Font = New Font("Segoe UI", 9F)
        searchorder.ForeColor = Color.Black
        searchorder.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        searchorder.IconLeft = CType(resources.GetObject("searchorder.IconLeft"), Image)
        searchorder.Location = New Point(533, 38)
        searchorder.Margin = New Padding(3, 4, 3, 4)
        searchorder.Name = "searchorder"
        searchorder.PasswordChar = ChrW(0)
        searchorder.PlaceholderText = ""
        searchorder.SelectedText = ""
        searchorder.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        searchorder.Size = New Size(203, 29)
        searchorder.TabIndex = 69
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(533, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 23)
        Label3.TabIndex = 70
        Label3.Text = "Search table"
        ' 
        ' deletebtn
        ' 
        deletebtn.Anchor = AnchorStyles.Left
        deletebtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        deletebtn.ForeColor = Color.Teal
        deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), Image)
        deletebtn.ImageAlign = ContentAlignment.TopCenter
        deletebtn.Location = New Point(12, 19)
        deletebtn.Name = "deletebtn"
        deletebtn.Size = New Size(52, 53)
        deletebtn.TabIndex = 90
        deletebtn.TextAlign = ContentAlignment.BottomCenter
        deletebtn.TextImageRelation = TextImageRelation.ImageAboveText
        deletebtn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientInactiveCaption
        Panel1.Controls.Add(btnexit)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(748, 52)
        Panel1.TabIndex = 91
        ' 
        ' btnexit
        ' 
        btnexit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnexit.BackgroundImage = CType(resources.GetObject("btnexit.BackgroundImage"), Image)
        btnexit.BackgroundImageLayout = ImageLayout.Zoom
        btnexit.FlatAppearance.BorderSize = 0
        btnexit.FlatStyle = FlatStyle.Flat
        btnexit.Location = New Point(686, 7)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(51, 36)
        btnexit.TabIndex = 1
        btnexit.Text = "   "
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(DataGridView1)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 132)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(748, 336)
        Panel2.TabIndex = 92
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(deletebtn)
        Panel3.Controls.Add(searchorder)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 52)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(748, 80)
        Panel3.TabIndex = 93
        ' 
        ' SavedOrders
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(748, 468)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SavedOrders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SavedOrders"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents searchorder As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents deletebtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnexit As Button
End Class
