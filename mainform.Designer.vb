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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        panelmenu = New Guna.UI2.WinForms.Guna2Panel()
        btnsetting = New Button()
        Button1 = New Button()
        btnusers = New Button()
        btntable = New Button()
        btnorder = New Button()
        btnproduct = New Button()
        btndashboard = New Button()
        paneltop = New Guna.UI2.WinForms.Guna2Panel()
        Label1 = New Label()
        btnminimize = New Button()
        btnmaximize = New Button()
        btnexit = New Button()
        Paneldesktop = New Panel()
        panelmenu.SuspendLayout()
        paneltop.SuspendLayout()
        Paneldesktop.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelmenu
        ' 
        panelmenu.BackColor = Color.SandyBrown
        panelmenu.Controls.Add(btnsetting)
        panelmenu.Controls.Add(Button1)
        panelmenu.Controls.Add(btnusers)
        panelmenu.Controls.Add(btntable)
        panelmenu.Controls.Add(btnorder)
        panelmenu.Controls.Add(btnproduct)
        panelmenu.Controls.Add(btndashboard)
        panelmenu.CustomizableEdges = CustomizableEdges1
        panelmenu.Dock = DockStyle.Left
        panelmenu.Location = New Point(0, 0)
        panelmenu.Name = "panelmenu"
        panelmenu.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        panelmenu.Size = New Size(212, 693)
        panelmenu.TabIndex = 0
        ' 
        ' btnsetting
        ' 
        btnsetting.BackgroundImageLayout = ImageLayout.None
        btnsetting.Dock = DockStyle.Top
        btnsetting.FlatAppearance.BorderSize = 0
        btnsetting.FlatStyle = FlatStyle.Flat
        btnsetting.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsetting.ForeColor = SystemColors.ButtonFace
        btnsetting.Image = CType(resources.GetObject("btnsetting.Image"), Image)
        btnsetting.ImageAlign = ContentAlignment.MiddleLeft
        btnsetting.Location = New Point(0, 300)
        btnsetting.Name = "btnsetting"
        btnsetting.Padding = New Padding(10, 0, 20, 0)
        btnsetting.Size = New Size(212, 60)
        btnsetting.TabIndex = 18
        btnsetting.Text = "Setting"
        btnsetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnsetting.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Dock = DockStyle.Bottom
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(0, 633)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(10, 0, 20, 0)
        Button1.Size = New Size(212, 60)
        Button1.TabIndex = 17
        Button1.Text = "Log out"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnusers
        ' 
        btnusers.BackgroundImageLayout = ImageLayout.None
        btnusers.Dock = DockStyle.Top
        btnusers.FlatAppearance.BorderSize = 0
        btnusers.FlatStyle = FlatStyle.Flat
        btnusers.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnusers.ForeColor = SystemColors.ButtonFace
        btnusers.Image = CType(resources.GetObject("btnusers.Image"), Image)
        btnusers.ImageAlign = ContentAlignment.MiddleLeft
        btnusers.Location = New Point(0, 240)
        btnusers.Name = "btnusers"
        btnusers.Padding = New Padding(10, 0, 20, 0)
        btnusers.Size = New Size(212, 60)
        btnusers.TabIndex = 15
        btnusers.Text = "  Users"
        btnusers.TextImageRelation = TextImageRelation.ImageBeforeText
        btnusers.UseVisualStyleBackColor = True
        ' 
        ' btntable
        ' 
        btntable.BackgroundImageLayout = ImageLayout.None
        btntable.Dock = DockStyle.Top
        btntable.FlatAppearance.BorderSize = 0
        btntable.FlatStyle = FlatStyle.Flat
        btntable.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntable.ForeColor = SystemColors.ButtonFace
        btntable.Image = CType(resources.GetObject("btntable.Image"), Image)
        btntable.ImageAlign = ContentAlignment.MiddleLeft
        btntable.Location = New Point(0, 180)
        btntable.Name = "btntable"
        btntable.Padding = New Padding(10, 0, 20, 0)
        btntable.Size = New Size(212, 60)
        btntable.TabIndex = 14
        btntable.Text = " Table"
        btntable.TextImageRelation = TextImageRelation.ImageBeforeText
        btntable.UseVisualStyleBackColor = True
        ' 
        ' btnorder
        ' 
        btnorder.BackgroundImageLayout = ImageLayout.None
        btnorder.Dock = DockStyle.Top
        btnorder.FlatAppearance.BorderSize = 0
        btnorder.FlatStyle = FlatStyle.Flat
        btnorder.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnorder.ForeColor = SystemColors.ButtonFace
        btnorder.Image = CType(resources.GetObject("btnorder.Image"), Image)
        btnorder.ImageAlign = ContentAlignment.MiddleLeft
        btnorder.Location = New Point(0, 120)
        btnorder.Name = "btnorder"
        btnorder.Padding = New Padding(10, 0, 20, 0)
        btnorder.Size = New Size(212, 60)
        btnorder.TabIndex = 13
        btnorder.Text = "  Orders"
        btnorder.TextImageRelation = TextImageRelation.ImageBeforeText
        btnorder.UseVisualStyleBackColor = True
        ' 
        ' btnproduct
        ' 
        btnproduct.BackgroundImageLayout = ImageLayout.None
        btnproduct.Dock = DockStyle.Top
        btnproduct.FlatAppearance.BorderSize = 0
        btnproduct.FlatStyle = FlatStyle.Flat
        btnproduct.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnproduct.ForeColor = SystemColors.ButtonFace
        btnproduct.Image = CType(resources.GetObject("btnproduct.Image"), Image)
        btnproduct.ImageAlign = ContentAlignment.MiddleLeft
        btnproduct.Location = New Point(0, 60)
        btnproduct.Name = "btnproduct"
        btnproduct.Padding = New Padding(10, 0, 20, 0)
        btnproduct.Size = New Size(212, 60)
        btnproduct.TabIndex = 12
        btnproduct.Text = " Product"
        btnproduct.TextImageRelation = TextImageRelation.ImageBeforeText
        btnproduct.UseVisualStyleBackColor = True
        ' 
        ' btndashboard
        ' 
        btndashboard.BackgroundImageLayout = ImageLayout.None
        btndashboard.Dock = DockStyle.Top
        btndashboard.FlatAppearance.BorderSize = 0
        btndashboard.FlatStyle = FlatStyle.Flat
        btndashboard.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndashboard.ForeColor = SystemColors.ButtonFace
        btndashboard.Image = CType(resources.GetObject("btndashboard.Image"), Image)
        btndashboard.ImageAlign = ContentAlignment.MiddleLeft
        btndashboard.Location = New Point(0, 0)
        btndashboard.Name = "btndashboard"
        btndashboard.Padding = New Padding(10, 0, 20, 0)
        btndashboard.Size = New Size(212, 60)
        btndashboard.TabIndex = 6
        btndashboard.Text = " Home"
        btndashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btndashboard.UseVisualStyleBackColor = True
        ' 
        ' paneltop
        ' 
        paneltop.BackColor = Color.BurlyWood
        paneltop.Controls.Add(Label1)
        paneltop.Controls.Add(btnminimize)
        paneltop.Controls.Add(btnmaximize)
        paneltop.Controls.Add(btnexit)
        paneltop.CustomizableEdges = CustomizableEdges3
        paneltop.Dock = DockStyle.Top
        paneltop.Location = New Point(0, 0)
        paneltop.Name = "paneltop"
        paneltop.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        paneltop.Size = New Size(1282, 60)
        paneltop.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        Label1.Location = New Point(402, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(486, 40)
        Label1.TabIndex = 3
        Label1.Text = "Luffy Cafe and fast food"
        ' 
        ' btnminimize
        ' 
        btnminimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnminimize.BackgroundImage = CType(resources.GetObject("btnminimize.BackgroundImage"), Image)
        btnminimize.BackgroundImageLayout = ImageLayout.Zoom
        btnminimize.FlatAppearance.BorderSize = 0
        btnminimize.FlatStyle = FlatStyle.Flat
        btnminimize.Location = New Point(1127, 12)
        btnminimize.Name = "btnminimize"
        btnminimize.Size = New Size(51, 36)
        btnminimize.TabIndex = 2
        btnminimize.Text = "   "
        btnminimize.UseVisualStyleBackColor = True
        ' 
        ' btnmaximize
        ' 
        btnmaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnmaximize.BackgroundImage = CType(resources.GetObject("btnmaximize.BackgroundImage"), Image)
        btnmaximize.BackgroundImageLayout = ImageLayout.Zoom
        btnmaximize.FlatAppearance.BorderSize = 0
        btnmaximize.FlatStyle = FlatStyle.Flat
        btnmaximize.Location = New Point(1173, 12)
        btnmaximize.Name = "btnmaximize"
        btnmaximize.Size = New Size(51, 36)
        btnmaximize.TabIndex = 1
        btnmaximize.Text = "   "
        btnmaximize.UseVisualStyleBackColor = True
        ' 
        ' btnexit
        ' 
        btnexit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnexit.BackgroundImage = CType(resources.GetObject("btnexit.BackgroundImage"), Image)
        btnexit.BackgroundImageLayout = ImageLayout.Zoom
        btnexit.FlatAppearance.BorderSize = 0
        btnexit.FlatStyle = FlatStyle.Flat
        btnexit.Location = New Point(1219, 12)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(51, 36)
        btnexit.TabIndex = 0
        btnexit.Text = "   "
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' Paneldesktop
        ' 
        Paneldesktop.Controls.Add(panelmenu)
        Paneldesktop.Dock = DockStyle.Fill
        Paneldesktop.Location = New Point(0, 60)
        Paneldesktop.Name = "Paneldesktop"
        Paneldesktop.Size = New Size(1282, 693)
        Paneldesktop.TabIndex = 2
        ' 
        ' mainform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1282, 753)
        Controls.Add(Paneldesktop)
        Controls.Add(paneltop)
        MinimumSize = New Size(1100, 600)
        Name = "mainform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "mainform"
        panelmenu.ResumeLayout(False)
        paneltop.ResumeLayout(False)
        paneltop.PerformLayout()
        Paneldesktop.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelmenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents paneltop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btndashboard As Button
    Friend WithEvents btnusers As Button
    Friend WithEvents btntable As Button
    Friend WithEvents btnorder As Button
    Friend WithEvents btnproduct As Button
    Friend WithEvents Paneldesktop As Panel
    Friend WithEvents btnexit As Button
    Friend WithEvents btnmaximize As Button
    Friend WithEvents btnminimize As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsetting As Button
End Class
