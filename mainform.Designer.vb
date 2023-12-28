<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        panelmenu = New Guna.UI2.WinForms.Guna2Panel()
        btnuser = New FontAwesome.Sharp.IconButton()
        btntables = New FontAwesome.Sharp.IconButton()
        btnproduct = New FontAwesome.Sharp.IconButton()
        btnorder = New FontAwesome.Sharp.IconButton()
        btndashboard = New FontAwesome.Sharp.IconButton()
        panelogo = New Guna.UI2.WinForms.Guna2Panel()
        PictureBox1 = New PictureBox()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        panelmenu.SuspendLayout()
        panelogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelmenu
        ' 
        panelmenu.BackColor = Color.FromArgb(CByte(53), CByte(61), CByte(93))
        panelmenu.Controls.Add(btnuser)
        panelmenu.Controls.Add(btntables)
        panelmenu.Controls.Add(btnproduct)
        panelmenu.Controls.Add(btnorder)
        panelmenu.Controls.Add(btndashboard)
        panelmenu.Controls.Add(panelogo)
        panelmenu.CustomizableEdges = CustomizableEdges3
        panelmenu.Dock = DockStyle.Left
        panelmenu.Location = New Point(0, 0)
        panelmenu.Name = "panelmenu"
        panelmenu.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        panelmenu.Size = New Size(202, 784)
        panelmenu.TabIndex = 0
        ' 
        ' btnuser
        ' 
        btnuser.Dock = DockStyle.Top
        btnuser.FlatAppearance.BorderSize = 0
        btnuser.FlatStyle = FlatStyle.Flat
        btnuser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnuser.ForeColor = Color.Gainsboro
        btnuser.IconChar = FontAwesome.Sharp.IconChar.Users
        btnuser.IconColor = Color.Gainsboro
        btnuser.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnuser.IconSize = 32
        btnuser.ImageAlign = ContentAlignment.MiddleLeft
        btnuser.Location = New Point(0, 315)
        btnuser.Name = "btnuser"
        btnuser.Padding = New Padding(10, 0, 20, 0)
        btnuser.Size = New Size(202, 50)
        btnuser.TabIndex = 5
        btnuser.Text = "User"
        btnuser.TextAlign = ContentAlignment.MiddleLeft
        btnuser.TextImageRelation = TextImageRelation.ImageBeforeText
        btnuser.UseVisualStyleBackColor = True
        ' 
        ' btntables
        ' 
        btntables.Dock = DockStyle.Top
        btntables.FlatAppearance.BorderSize = 0
        btntables.FlatStyle = FlatStyle.Flat
        btntables.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntables.ForeColor = Color.Gainsboro
        btntables.IconChar = FontAwesome.Sharp.IconChar.Table
        btntables.IconColor = Color.Gainsboro
        btntables.IconFont = FontAwesome.Sharp.IconFont.Auto
        btntables.IconSize = 32
        btntables.ImageAlign = ContentAlignment.MiddleLeft
        btntables.Location = New Point(0, 265)
        btntables.Name = "btntables"
        btntables.Padding = New Padding(10, 0, 20, 0)
        btntables.Size = New Size(202, 50)
        btntables.TabIndex = 4
        btntables.Text = "Tables"
        btntables.TextAlign = ContentAlignment.MiddleLeft
        btntables.TextImageRelation = TextImageRelation.ImageBeforeText
        btntables.UseVisualStyleBackColor = True
        ' 
        ' btnproduct
        ' 
        btnproduct.Dock = DockStyle.Top
        btnproduct.FlatAppearance.BorderSize = 0
        btnproduct.FlatStyle = FlatStyle.Flat
        btnproduct.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnproduct.ForeColor = Color.Gainsboro
        btnproduct.IconChar = FontAwesome.Sharp.IconChar.Tag
        btnproduct.IconColor = Color.Gainsboro
        btnproduct.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnproduct.IconSize = 32
        btnproduct.ImageAlign = ContentAlignment.MiddleLeft
        btnproduct.Location = New Point(0, 215)
        btnproduct.Name = "btnproduct"
        btnproduct.Padding = New Padding(10, 0, 20, 0)
        btnproduct.Size = New Size(202, 50)
        btnproduct.TabIndex = 3
        btnproduct.Text = "Product"
        btnproduct.TextAlign = ContentAlignment.MiddleLeft
        btnproduct.TextImageRelation = TextImageRelation.ImageBeforeText
        btnproduct.UseVisualStyleBackColor = True
        ' 
        ' btnorder
        ' 
        btnorder.Dock = DockStyle.Top
        btnorder.FlatAppearance.BorderSize = 0
        btnorder.FlatStyle = FlatStyle.Flat
        btnorder.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnorder.ForeColor = Color.Gainsboro
        btnorder.IconChar = FontAwesome.Sharp.IconChar.Utensils
        btnorder.IconColor = Color.Gainsboro
        btnorder.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnorder.IconSize = 32
        btnorder.ImageAlign = ContentAlignment.MiddleLeft
        btnorder.Location = New Point(0, 165)
        btnorder.Name = "btnorder"
        btnorder.Padding = New Padding(10, 0, 20, 0)
        btnorder.Size = New Size(202, 50)
        btnorder.TabIndex = 2
        btnorder.Text = "Order"
        btnorder.TextAlign = ContentAlignment.MiddleLeft
        btnorder.TextImageRelation = TextImageRelation.ImageBeforeText
        btnorder.UseVisualStyleBackColor = True
        ' 
        ' btndashboard
        ' 
        btndashboard.Dock = DockStyle.Top
        btndashboard.FlatAppearance.BorderSize = 0
        btndashboard.FlatStyle = FlatStyle.Flat
        btndashboard.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndashboard.ForeColor = Color.Gainsboro
        btndashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        btndashboard.IconColor = Color.Gainsboro
        btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btndashboard.IconSize = 32
        btndashboard.ImageAlign = ContentAlignment.MiddleLeft
        btndashboard.Location = New Point(0, 115)
        btndashboard.Name = "btndashboard"
        btndashboard.Padding = New Padding(10, 0, 20, 0)
        btndashboard.Size = New Size(202, 50)
        btndashboard.TabIndex = 1
        btndashboard.Text = "Dashboard"
        btndashboard.TextAlign = ContentAlignment.MiddleLeft
        btndashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btndashboard.UseVisualStyleBackColor = True
        ' 
        ' panelogo
        ' 
        panelogo.Controls.Add(PictureBox1)
        panelogo.CustomizableEdges = CustomizableEdges1
        panelogo.Dock = DockStyle.Top
        panelogo.Location = New Point(0, 0)
        panelogo.Name = "panelogo"
        panelogo.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        panelogo.Size = New Size(202, 115)
        panelogo.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(7, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(179, 98)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.FromArgb(CByte(53), CByte(61), CByte(93))
        Guna2Panel2.CustomizableEdges = CustomizableEdges5
        Guna2Panel2.Dock = DockStyle.Top
        Guna2Panel2.Location = New Point(202, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel2.Size = New Size(936, 66)
        Guna2Panel2.TabIndex = 1
        ' 
        ' mainform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1138, 784)
        Controls.Add(Guna2Panel2)
        Controls.Add(panelmenu)
        Name = "mainform"
        Text = "mainform"
        panelmenu.ResumeLayout(False)
        panelogo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelmenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelogo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btndashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnuser As FontAwesome.Sharp.IconButton
    Friend WithEvents btntables As FontAwesome.Sharp.IconButton
    Friend WithEvents btnproduct As FontAwesome.Sharp.IconButton
    Friend WithEvents btnorder As FontAwesome.Sharp.IconButton
End Class
