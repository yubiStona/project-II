<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgot_password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgot_password))
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        btnShow1 = New Button()
        btnhide1 = New Button()
        txtpassword1 = New Guna.UI2.WinForms.Guna2TextBox()
        btnShow = New Button()
        btnhide = New Button()
        txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        btnrespass = New Guna.UI2.WinForms.Guna2GradientButton()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel1.Controls.Add(btnShow1)
        Panel1.Controls.Add(btnhide1)
        Panel1.Controls.Add(txtpassword1)
        Panel1.Controls.Add(btnShow)
        Panel1.Controls.Add(btnhide)
        Panel1.Controls.Add(txtpassword)
        Panel1.Controls.Add(btnrespass)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(75, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 450)
        Panel1.TabIndex = 1
        ' 
        ' btnShow1
        ' 
        btnShow1.BackColor = Color.White
        btnShow1.BackgroundImage = CType(resources.GetObject("btnShow1.BackgroundImage"), Image)
        btnShow1.BackgroundImageLayout = ImageLayout.Zoom
        btnShow1.FlatAppearance.BorderSize = 0
        btnShow1.FlatStyle = FlatStyle.Flat
        btnShow1.Location = New Point(323, 255)
        btnShow1.Name = "btnShow1"
        btnShow1.Size = New Size(30, 25)
        btnShow1.TabIndex = 17
        btnShow1.Text = "  "
        btnShow1.UseVisualStyleBackColor = False
        ' 
        ' btnhide1
        ' 
        btnhide1.BackColor = Color.White
        btnhide1.BackgroundImage = CType(resources.GetObject("btnhide1.BackgroundImage"), Image)
        btnhide1.BackgroundImageLayout = ImageLayout.Zoom
        btnhide1.FlatAppearance.BorderSize = 0
        btnhide1.FlatStyle = FlatStyle.Flat
        btnhide1.Location = New Point(323, 255)
        btnhide1.Name = "btnhide1"
        btnhide1.Size = New Size(30, 25)
        btnhide1.TabIndex = 16
        btnhide1.Text = "  "
        btnhide1.UseVisualStyleBackColor = False
        ' 
        ' txtpassword1
        ' 
        txtpassword1.AutoRoundedCorners = True
        txtpassword1.BorderRadius = 22
        txtpassword1.CustomizableEdges = CustomizableEdges7
        txtpassword1.DefaultText = "password"
        txtpassword1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtpassword1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtpassword1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtpassword1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtpassword1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtpassword1.Font = New Font("Segoe UI", 9F)
        txtpassword1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtpassword1.IconLeft = CType(resources.GetObject("txtpassword1.IconLeft"), Image)
        txtpassword1.IconLeftOffset = New Point(8, 0)
        txtpassword1.IconRightOffset = New Point(7, 0)
        txtpassword1.Location = New Point(70, 244)
        txtpassword1.Margin = New Padding(3, 4, 3, 4)
        txtpassword1.Name = "txtpassword1"
        txtpassword1.PasswordChar = ChrW(0)
        txtpassword1.PlaceholderText = ""
        txtpassword1.SelectedText = ""
        txtpassword1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtpassword1.Size = New Size(291, 46)
        txtpassword1.TabIndex = 15
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = Color.White
        btnShow.BackgroundImage = CType(resources.GetObject("btnShow.BackgroundImage"), Image)
        btnShow.BackgroundImageLayout = ImageLayout.Zoom
        btnShow.FlatAppearance.BorderSize = 0
        btnShow.FlatStyle = FlatStyle.Flat
        btnShow.Location = New Point(327, 175)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(30, 25)
        btnShow.TabIndex = 14
        btnShow.Text = "  "
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' btnhide
        ' 
        btnhide.BackColor = Color.White
        btnhide.BackgroundImage = CType(resources.GetObject("btnhide.BackgroundImage"), Image)
        btnhide.BackgroundImageLayout = ImageLayout.Zoom
        btnhide.FlatAppearance.BorderSize = 0
        btnhide.FlatStyle = FlatStyle.Flat
        btnhide.Location = New Point(327, 175)
        btnhide.Name = "btnhide"
        btnhide.Size = New Size(30, 25)
        btnhide.TabIndex = 13
        btnhide.Text = "  "
        btnhide.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.AutoRoundedCorners = True
        txtpassword.BorderRadius = 22
        txtpassword.CustomizableEdges = CustomizableEdges9
        txtpassword.DefaultText = "password"
        txtpassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtpassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtpassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtpassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtpassword.Font = New Font("Segoe UI", 9F)
        txtpassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtpassword.IconLeft = CType(resources.GetObject("txtpassword.IconLeft"), Image)
        txtpassword.IconLeftOffset = New Point(8, 0)
        txtpassword.IconRightOffset = New Point(7, 0)
        txtpassword.Location = New Point(70, 164)
        txtpassword.Margin = New Padding(3, 4, 3, 4)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = ChrW(0)
        txtpassword.PlaceholderText = ""
        txtpassword.SelectedText = ""
        txtpassword.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtpassword.Size = New Size(291, 46)
        txtpassword.TabIndex = 12
        ' 
        ' btnrespass
        ' 
        btnrespass.AutoRoundedCorners = True
        btnrespass.BackColor = Color.Transparent
        btnrespass.BorderRadius = 20
        btnrespass.CustomizableEdges = CustomizableEdges11
        btnrespass.DisabledState.BorderColor = Color.DarkGray
        btnrespass.DisabledState.CustomBorderColor = Color.DarkGray
        btnrespass.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnrespass.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnrespass.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnrespass.Font = New Font("Segoe UI", 9F)
        btnrespass.ForeColor = Color.White
        btnrespass.Location = New Point(70, 310)
        btnrespass.Name = "btnrespass"
        btnrespass.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnrespass.Size = New Size(291, 43)
        btnrespass.TabIndex = 2
        btnrespass.Text = "Reset password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(127, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 31)
        Label4.TabIndex = 8
        Label4.Text = "Reset Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(77, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 23)
        Label3.TabIndex = 5
        Label3.Text = "confirm password *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(82, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 23)
        Label2.TabIndex = 3
        Label2.Text = "new password *"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Panel1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1008, 753)
        Panel2.TabIndex = 2
        ' 
        ' forgot_password
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BurlyWood
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1008, 753)
        Controls.Add(Panel2)
        MaximizeBox = False
        Name = "forgot_password"
        StartPosition = FormStartPosition.CenterScreen
        Text = "forgot_password"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnrespass As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnShow As Button
    Friend WithEvents btnhide As Button
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnShow1 As Button
    Friend WithEvents btnhide1 As Button
    Friend WithEvents txtpassword1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
End Class
