<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addTables
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addTables))
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txtF_name = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtfloor = New Guna.UI2.WinForms.Guna2TextBox()
        DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Label3 = New Label()
        searchtable = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txttableNo = New Guna.UI2.WinForms.Guna2TextBox()
        tablet = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txttabletype = New Guna.UI2.WinForms.Guna2TextBox()
        btnsave1 = New Button()
        btnupdate = New Button()
        deletebtn = New Button()
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtF_name
        ' 
        txtF_name.BackColor = Color.Transparent
        txtF_name.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtF_name.Location = New Point(7, 44)
        txtF_name.Name = "txtF_name"
        txtF_name.Size = New Size(42, 25)
        txtF_name.TabIndex = 71
        txtF_name.Text = "Floor"
        ' 
        ' txtfloor
        ' 
        txtfloor.BorderColor = Color.Black
        txtfloor.CustomizableEdges = CustomizableEdges1
        txtfloor.DefaultText = ""
        txtfloor.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtfloor.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtfloor.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtfloor.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtfloor.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtfloor.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtfloor.ForeColor = Color.Black
        txtfloor.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtfloor.Location = New Point(7, 71)
        txtfloor.Margin = New Padding(3, 4, 3, 4)
        txtfloor.Name = "txtfloor"
        txtfloor.PasswordChar = ChrW(0)
        txtfloor.PlaceholderText = ""
        txtfloor.SelectedText = ""
        txtfloor.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtfloor.Size = New Size(220, 29)
        txtfloor.TabIndex = 70
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 22
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
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
        DataGridView1.Size = New Size(962, 307)
        DataGridView1.TabIndex = 69
        DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        DataGridView1.ThemeStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView1.ThemeStyle.HeaderStyle.Height = 22
        DataGridView1.ThemeStyle.ReadOnly = True
        DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridView1.ThemeStyle.RowsStyle.Height = 29
        DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(727, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 23)
        Label3.TabIndex = 68
        Label3.Text = "Search table"
        ' 
        ' searchtable
        ' 
        searchtable.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        searchtable.BorderColor = Color.Black
        searchtable.CustomizableEdges = CustomizableEdges3
        searchtable.DefaultText = ""
        searchtable.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        searchtable.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        searchtable.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        searchtable.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        searchtable.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        searchtable.Font = New Font("Segoe UI", 9F)
        searchtable.ForeColor = Color.Black
        searchtable.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        searchtable.IconLeft = CType(resources.GetObject("searchtable.IconLeft"), Image)
        searchtable.Location = New Point(727, 45)
        searchtable.Margin = New Padding(3, 4, 3, 4)
        searchtable.Name = "searchtable"
        searchtable.PasswordChar = ChrW(0)
        searchtable.PlaceholderText = ""
        searchtable.SelectedText = ""
        searchtable.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        searchtable.Size = New Size(203, 29)
        searchtable.TabIndex = 67
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(252, 44)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(76, 25)
        Guna2HtmlLabel1.TabIndex = 81
        Guna2HtmlLabel1.Text = "Table No."
        ' 
        ' txttableNo
        ' 
        txttableNo.BorderColor = Color.Black
        txttableNo.CustomizableEdges = CustomizableEdges5
        txttableNo.DefaultText = ""
        txttableNo.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txttableNo.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txttableNo.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txttableNo.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txttableNo.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txttableNo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txttableNo.ForeColor = Color.Black
        txttableNo.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txttableNo.Location = New Point(252, 71)
        txttableNo.Margin = New Padding(3, 4, 3, 4)
        txttableNo.Name = "txttableNo"
        txttableNo.PasswordChar = ChrW(0)
        txttableNo.PlaceholderText = ""
        txttableNo.SelectedText = ""
        txttableNo.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txttableNo.Size = New Size(172, 29)
        txttableNo.TabIndex = 80
        ' 
        ' tablet
        ' 
        tablet.BackColor = Color.Transparent
        tablet.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tablet.Location = New Point(6, 120)
        tablet.Name = "tablet"
        tablet.Size = New Size(83, 25)
        tablet.TabIndex = 83
        tablet.Text = "Table type"
        ' 
        ' txttabletype
        ' 
        txttabletype.BorderColor = Color.Black
        txttabletype.CustomizableEdges = CustomizableEdges7
        txttabletype.DefaultText = ""
        txttabletype.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txttabletype.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txttabletype.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txttabletype.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txttabletype.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txttabletype.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txttabletype.ForeColor = Color.Black
        txttabletype.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txttabletype.Location = New Point(7, 149)
        txttabletype.Margin = New Padding(3, 4, 3, 4)
        txttabletype.Name = "txttabletype"
        txttabletype.PasswordChar = ChrW(0)
        txttabletype.PlaceholderText = ""
        txttabletype.SelectedText = ""
        txttabletype.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txttabletype.Size = New Size(321, 29)
        txttabletype.TabIndex = 82
        ' 
        ' btnsave1
        ' 
        btnsave1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnsave1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsave1.ForeColor = Color.DarkOrange
        btnsave1.Image = CType(resources.GetObject("btnsave1.Image"), Image)
        btnsave1.ImageAlign = ContentAlignment.TopCenter
        btnsave1.Location = New Point(662, 18)
        btnsave1.Name = "btnsave1"
        btnsave1.Size = New Size(69, 81)
        btnsave1.TabIndex = 84
        btnsave1.Text = "save"
        btnsave1.TextAlign = ContentAlignment.BottomCenter
        btnsave1.TextImageRelation = TextImageRelation.ImageAboveText
        btnsave1.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnupdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnupdate.ForeColor = Color.Teal
        btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), Image)
        btnupdate.ImageAlign = ContentAlignment.TopCenter
        btnupdate.Location = New Point(759, 17)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(69, 81)
        btnupdate.TabIndex = 85
        btnupdate.Text = "update"
        btnupdate.TextAlign = ContentAlignment.BottomCenter
        btnupdate.TextImageRelation = TextImageRelation.ImageAboveText
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' deletebtn
        ' 
        deletebtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        deletebtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        deletebtn.ForeColor = Color.Teal
        deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), Image)
        deletebtn.ImageAlign = ContentAlignment.TopCenter
        deletebtn.Location = New Point(856, 17)
        deletebtn.Name = "deletebtn"
        deletebtn.Size = New Size(69, 81)
        deletebtn.TabIndex = 86
        deletebtn.Text = "delete"
        deletebtn.TextAlign = ContentAlignment.BottomCenter
        deletebtn.TextImageRelation = TextImageRelation.ImageAboveText
        deletebtn.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlLight
        GroupBox1.Controls.Add(txttableNo)
        GroupBox1.Controls.Add(txtfloor)
        GroupBox1.Controls.Add(txtF_name)
        GroupBox1.Controls.Add(Guna2HtmlLabel1)
        GroupBox1.Controls.Add(tablet)
        GroupBox1.Controls.Add(txttabletype)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(11, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(507, 205)
        GroupBox1.TabIndex = 87
        GroupBox1.TabStop = False
        GroupBox1.Text = "Table Info"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(searchtable)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(962, 224)
        Panel1.TabIndex = 88
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnupdate)
        Panel2.Controls.Add(btnsave1)
        Panel2.Controls.Add(deletebtn)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 531)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(962, 115)
        Panel2.TabIndex = 89
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DataGridView1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 224)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(962, 307)
        Panel3.TabIndex = 90
        ' 
        ' addTables
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(962, 646)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "addTables"
        Text = "addTables"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtF_name As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtfloor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents searchtable As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txttableNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tablet As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txttabletype As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsave1 As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
