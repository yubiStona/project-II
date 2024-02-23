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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnforgotpass = New Guna.UI2.WinForms.Guna2GradientButton()
        Label1 = New Label()
        Loginbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        btnShow = New Button()
        btnhide = New Button()
        txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        SuspendLayout()
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
        btnforgotpass.Location = New Point(107, 432)
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
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(132, 192)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 31)
        Label1.TabIndex = 12
        Label1.Text = "Login your Account"
        ' 
        ' Loginbtn
        ' 
        Loginbtn.AutoRoundedCorners = True
        Loginbtn.BackColor = Color.Transparent
        Loginbtn.BorderRadius = 22
        Loginbtn.CustomizableEdges = CustomizableEdges3
        Loginbtn.DisabledState.BorderColor = Color.DarkGray
        Loginbtn.DisabledState.CustomBorderColor = Color.DarkGray
        Loginbtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Loginbtn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Loginbtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Loginbtn.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Loginbtn.FillColor2 = Color.Red
        Loginbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Loginbtn.ForeColor = Color.White
        Loginbtn.Location = New Point(107, 372)
        Loginbtn.Name = "Loginbtn"
        Loginbtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Loginbtn.Size = New Size(291, 46)
        Loginbtn.TabIndex = 5
        Loginbtn.Text = "Login"
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = Color.White
        btnShow.BackgroundImage = CType(resources.GetObject("btnShow.BackgroundImage"), Image)
        btnShow.BackgroundImageLayout = ImageLayout.Zoom
        btnShow.FlatAppearance.BorderSize = 0
        btnShow.FlatStyle = FlatStyle.Flat
        btnShow.Location = New Point(364, 312)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(30, 25)
        btnShow.TabIndex = 11
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
        btnhide.Location = New Point(364, 312)
        btnhide.Name = "btnhide"
        btnhide.Size = New Size(30, 25)
        btnhide.TabIndex = 9
        btnhide.Text = "  "
        btnhide.UseVisualStyleBackColor = False
        ' 
        ' txtusername
        ' 
        txtusername.AutoRoundedCorners = True
        txtusername.BackColor = Color.Transparent
        txtusername.BorderColor = Color.Black
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
        txtusername.Location = New Point(107, 241)
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
        txtpassword.BackColor = Color.Transparent
        txtpassword.BorderColor = Color.Black
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
        txtpassword.Location = New Point(107, 301)
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
        AcceptButton = Loginbtn
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1008, 753)
        Controls.Add(btnforgotpass)
        Controls.Add(Loginbtn)
        Controls.Add(Label1)
        Controls.Add(btnShow)
        Controls.Add(txtusername)
        Controls.Add(btnhide)
        Controls.Add(txtpassword)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Loginbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnhide As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnforgotpass As Guna.UI2.WinForms.Guna2GradientButton
End Class
