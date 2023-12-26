<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        mainpanel = New Guna.UI2.WinForms.Guna2Panel()
        btnforgotpass = New Guna.UI2.WinForms.Guna2GradientButton()
        Label1 = New Label()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Show = New Button()
        hide = New Button()
        txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Panel2.SuspendLayout()
        mainpanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.Transparent
        Guna2Panel2.BackgroundImage = CType(resources.GetObject("Guna2Panel2.BackgroundImage"), Image)
        Guna2Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Guna2Panel2.BorderColor = Color.White
        Guna2Panel2.Controls.Add(mainpanel)
        Guna2Panel2.CustomizableEdges = CustomizableEdges11
        Guna2Panel2.Dock = DockStyle.Right
        Guna2Panel2.FillColor = Color.Transparent
        Guna2Panel2.Location = New Point(-34, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel2.Size = New Size(609, 757)
        Guna2Panel2.TabIndex = 1
        ' 
        ' mainpanel
        ' 
        mainpanel.BackColor = SystemColors.ControlDark
        mainpanel.Controls.Add(btnforgotpass)
        mainpanel.Controls.Add(Label1)
        mainpanel.Controls.Add(Guna2GradientButton1)
        mainpanel.Controls.Add(Show)
        mainpanel.Controls.Add(hide)
        mainpanel.Controls.Add(txtusername)
        mainpanel.Controls.Add(txtpassword)
        mainpanel.CustomizableEdges = CustomizableEdges9
        mainpanel.Location = New Point(159, 158)
        mainpanel.Name = "mainpanel"
        mainpanel.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        mainpanel.Size = New Size(343, 353)
        mainpanel.TabIndex = 2
        ' 
        ' btnforgotpass
        ' 
        btnforgotpass.AutoRoundedCorners = True
        btnforgotpass.BackColor = Color.Transparent
        btnforgotpass.BorderRadius = 22
        btnforgotpass.CustomizableEdges = CustomizableEdges1
        btnforgotpass.DisabledState.BorderColor = Color.DarkGray
        btnforgotpass.DisabledState.CustomBorderColor = Color.DarkGray
        btnforgotpass.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnforgotpass.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnforgotpass.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnforgotpass.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnforgotpass.FillColor2 = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        btnforgotpass.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnforgotpass.ForeColor = Color.White
        btnforgotpass.Location = New Point(22, 283)
        btnforgotpass.Name = "btnforgotpass"
        btnforgotpass.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnforgotpass.Size = New Size(291, 46)
        btnforgotpass.TabIndex = 14
        btnforgotpass.Text = "Forgot password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(28, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 31)
        Label1.TabIndex = 12
        Label1.Text = "Login your Account"
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.AutoRoundedCorners = True
        Guna2GradientButton1.BackColor = Color.Transparent
        Guna2GradientButton1.BorderRadius = 22
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges3
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Guna2GradientButton1.FillColor2 = Color.Red
        Guna2GradientButton1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2GradientButton1.ForeColor = Color.White
        Guna2GradientButton1.Location = New Point(22, 226)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton1.Size = New Size(291, 46)
        Guna2GradientButton1.TabIndex = 5
        Guna2GradientButton1.Text = "Login"
        ' 
        ' Show
        ' 
        Show.BackColor = Color.White
        Show.BackgroundImage = CType(resources.GetObject("Show.BackgroundImage"), Image)
        Show.BackgroundImageLayout = ImageLayout.Zoom
        Show.FlatAppearance.BorderSize = 0
        Show.FlatStyle = FlatStyle.Flat
        Show.Location = New Point(279, 173)
        Show.Name = "Show"
        Show.Size = New Size(30, 25)
        Show.TabIndex = 11
        Show.Text = "  "
        Show.UseVisualStyleBackColor = False
        ' 
        ' hide
        ' 
        hide.BackColor = Color.White
        hide.BackgroundImage = CType(resources.GetObject("hide.BackgroundImage"), Image)
        hide.BackgroundImageLayout = ImageLayout.Zoom
        hide.FlatAppearance.BorderSize = 0
        hide.FlatStyle = FlatStyle.Flat
        hide.Location = New Point(279, 173)
        hide.Name = "hide"
        hide.Size = New Size(30, 25)
        hide.TabIndex = 9
        hide.Text = "  "
        hide.UseVisualStyleBackColor = False
        ' 
        ' txtusername
        ' 
        txtusername.AutoRoundedCorners = True
        txtusername.BackColor = Color.Transparent
        txtusername.BorderRadius = 22
        txtusername.CustomizableEdges = CustomizableEdges5
        txtusername.DefaultText = "username"
        txtusername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtusername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtusername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtusername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtusername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtusername.Font = New Font("Segoe UI", 9F)
        txtusername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtusername.IconLeft = CType(resources.GetObject("txtusername.IconLeft"), Image)
        txtusername.IconLeftOffset = New Point(8, 0)
        txtusername.Location = New Point(22, 108)
        txtusername.Margin = New Padding(3, 4, 3, 4)
        txtusername.Name = "txtusername"
        txtusername.PasswordChar = ChrW(0)
        txtusername.PlaceholderText = ""
        txtusername.SelectedText = ""
        txtusername.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtusername.Size = New Size(291, 46)
        txtusername.TabIndex = 0
        ' 
        ' txtpassword
        ' 
        txtpassword.AutoRoundedCorners = True
        txtpassword.BorderRadius = 22
        txtpassword.CustomizableEdges = CustomizableEdges7
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
        txtpassword.Location = New Point(22, 162)
        txtpassword.Margin = New Padding(3, 4, 3, 4)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = ChrW(0)
        txtpassword.PlaceholderText = ""
        txtpassword.SelectedText = ""
        txtpassword.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtpassword.Size = New Size(291, 46)
        txtpassword.TabIndex = 1
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(575, 757)
        Controls.Add(Guna2Panel2)
        MaximizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Guna2Panel2.ResumeLayout(False)
        mainpanel.ResumeLayout(False)
        mainpanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents hide As Button
    Friend WithEvents Show As Button
    Friend WithEvents mainpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnforgotpass As Guna.UI2.WinForms.Guna2GradientButton
End Class
