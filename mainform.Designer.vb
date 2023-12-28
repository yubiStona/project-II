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
        IconButton5 = New FontAwesome.Sharp.IconButton()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
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
        panelmenu.Controls.Add(IconButton5)
        panelmenu.Controls.Add(IconButton4)
        panelmenu.Controls.Add(IconButton3)
        panelmenu.Controls.Add(IconButton2)
        panelmenu.Controls.Add(IconButton1)
        panelmenu.Controls.Add(panelogo)
        panelmenu.CustomizableEdges = CustomizableEdges3
        panelmenu.Dock = DockStyle.Left
        panelmenu.Location = New Point(0, 0)
        panelmenu.Name = "panelmenu"
        panelmenu.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        panelmenu.Size = New Size(202, 784)
        panelmenu.TabIndex = 0
        ' 
        ' IconButton5
        ' 
        IconButton5.Dock = DockStyle.Top
        IconButton5.FlatAppearance.BorderSize = 0
        IconButton5.FlatStyle = FlatStyle.Flat
        IconButton5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton5.ForeColor = Color.Gainsboro
        IconButton5.IconChar = FontAwesome.Sharp.IconChar.FastForward
        IconButton5.IconColor = Color.Gainsboro
        IconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton5.IconSize = 32
        IconButton5.ImageAlign = ContentAlignment.MiddleLeft
        IconButton5.Location = New Point(0, 315)
        IconButton5.Name = "IconButton5"
        IconButton5.Padding = New Padding(10, 0, 20, 0)
        IconButton5.Size = New Size(202, 50)
        IconButton5.TabIndex = 5
        IconButton5.Text = "User"
        IconButton5.TextAlign = ContentAlignment.MiddleLeft
        IconButton5.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton5.UseVisualStyleBackColor = True
        ' 
        ' IconButton4
        ' 
        IconButton4.Dock = DockStyle.Top
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton4.ForeColor = Color.Gainsboro
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.FastForward
        IconButton4.IconColor = Color.Gainsboro
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.IconSize = 32
        IconButton4.ImageAlign = ContentAlignment.MiddleLeft
        IconButton4.Location = New Point(0, 265)
        IconButton4.Name = "IconButton4"
        IconButton4.Padding = New Padding(10, 0, 20, 0)
        IconButton4.Size = New Size(202, 50)
        IconButton4.TabIndex = 4
        IconButton4.Text = "Tables"
        IconButton4.TextAlign = ContentAlignment.MiddleLeft
        IconButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = True
        ' 
        ' IconButton3
        ' 
        IconButton3.Dock = DockStyle.Top
        IconButton3.FlatAppearance.BorderSize = 0
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton3.ForeColor = Color.Gainsboro
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.FastForward
        IconButton3.IconColor = Color.Gainsboro
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.IconSize = 32
        IconButton3.ImageAlign = ContentAlignment.MiddleLeft
        IconButton3.Location = New Point(0, 215)
        IconButton3.Name = "IconButton3"
        IconButton3.Padding = New Padding(10, 0, 20, 0)
        IconButton3.Size = New Size(202, 50)
        IconButton3.TabIndex = 3
        IconButton3.Text = "Product"
        IconButton3.TextAlign = ContentAlignment.MiddleLeft
        IconButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton3.UseVisualStyleBackColor = True
        ' 
        ' IconButton2
        ' 
        IconButton2.Dock = DockStyle.Top
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton2.ForeColor = Color.Gainsboro
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.FastForward
        IconButton2.IconColor = Color.Gainsboro
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 32
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(0, 165)
        IconButton2.Name = "IconButton2"
        IconButton2.Padding = New Padding(10, 0, 20, 0)
        IconButton2.Size = New Size(202, 50)
        IconButton2.TabIndex = 2
        IconButton2.Text = "Order"
        IconButton2.TextAlign = ContentAlignment.MiddleLeft
        IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.Dock = DockStyle.Top
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton1.ForeColor = Color.Gainsboro
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.FastForward
        IconButton1.IconColor = Color.Gainsboro
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 32
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(0, 115)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(10, 0, 20, 0)
        IconButton1.Size = New Size(202, 50)
        IconButton1.TabIndex = 1
        IconButton1.Text = "Dashboard"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = True
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
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
