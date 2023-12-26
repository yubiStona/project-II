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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        showconfirm = New Button()
        hideconfirm = New Button()
        newshow = New Button()
        newhide = New Button()
        res_newpass = New Guna.UI2.WinForms.Guna2TextBox()
        btnrespass = New Guna.UI2.WinForms.Guna2GradientButton()
        resconfirmnewpass = New Guna.UI2.WinForms.Guna2TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel1.Controls.Add(showconfirm)
        Panel1.Controls.Add(hideconfirm)
        Panel1.Controls.Add(newshow)
        Panel1.Controls.Add(newhide)
        Panel1.Controls.Add(res_newpass)
        Panel1.Controls.Add(btnrespass)
        Panel1.Controls.Add(resconfirmnewpass)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(204, 102)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(370, 355)
        Panel1.TabIndex = 1
        ' 
        ' showconfirm
        ' 
        showconfirm.BackColor = Color.White
        showconfirm.BackgroundImage = CType(resources.GetObject("showconfirm.BackgroundImage"), Image)
        showconfirm.BackgroundImageLayout = ImageLayout.Zoom
        showconfirm.FlatAppearance.BorderSize = 0
        showconfirm.FlatStyle = FlatStyle.Flat
        showconfirm.Location = New Point(296, 220)
        showconfirm.Name = "showconfirm"
        showconfirm.Size = New Size(30, 30)
        showconfirm.TabIndex = 3
        showconfirm.Text = "  "
        showconfirm.UseVisualStyleBackColor = False
        ' 
        ' hideconfirm
        ' 
        hideconfirm.BackColor = Color.White
        hideconfirm.BackgroundImage = CType(resources.GetObject("hideconfirm.BackgroundImage"), Image)
        hideconfirm.BackgroundImageLayout = ImageLayout.Zoom
        hideconfirm.FlatAppearance.BorderSize = 0
        hideconfirm.FlatStyle = FlatStyle.Flat
        hideconfirm.Location = New Point(296, 220)
        hideconfirm.Name = "hideconfirm"
        hideconfirm.Size = New Size(30, 30)
        hideconfirm.TabIndex = 4
        hideconfirm.Text = "  "
        hideconfirm.UseVisualStyleBackColor = False
        ' 
        ' newshow
        ' 
        newshow.BackColor = Color.White
        newshow.BackgroundImage = CType(resources.GetObject("newshow.BackgroundImage"), Image)
        newshow.BackgroundImageLayout = ImageLayout.Zoom
        newshow.FlatAppearance.BorderSize = 0
        newshow.FlatStyle = FlatStyle.Flat
        newshow.Location = New Point(294, 151)
        newshow.Name = "newshow"
        newshow.Size = New Size(30, 30)
        newshow.TabIndex = 2
        newshow.Text = "  "
        newshow.UseVisualStyleBackColor = False
        ' 
        ' newhide
        ' 
        newhide.BackColor = Color.White
        newhide.BackgroundImage = CType(resources.GetObject("newhide.BackgroundImage"), Image)
        newhide.BackgroundImageLayout = ImageLayout.Zoom
        newhide.FlatAppearance.BorderSize = 0
        newhide.FlatStyle = FlatStyle.Flat
        newhide.Location = New Point(294, 151)
        newhide.Name = "newhide"
        newhide.Size = New Size(30, 30)
        newhide.TabIndex = 3
        newhide.Text = "  "
        newhide.UseVisualStyleBackColor = False
        ' 
        ' res_newpass
        ' 
        res_newpass.AutoRoundedCorners = True
        res_newpass.BackColor = Color.Transparent
        res_newpass.BorderRadius = 20
        res_newpass.CustomizableEdges = CustomizableEdges1
        res_newpass.DefaultText = ""
        res_newpass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        res_newpass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        res_newpass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        res_newpass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        res_newpass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        res_newpass.Font = New Font("Segoe UI", 9F)
        res_newpass.ForeColor = Color.Black
        res_newpass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        res_newpass.Location = New Point(34, 145)
        res_newpass.Margin = New Padding(3, 4, 3, 4)
        res_newpass.Name = "res_newpass"
        res_newpass.PasswordChar = "●"c
        res_newpass.PlaceholderText = ""
        res_newpass.SelectedText = ""
        res_newpass.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        res_newpass.Size = New Size(301, 43)
        res_newpass.TabIndex = 9
        ' 
        ' btnrespass
        ' 
        btnrespass.AutoRoundedCorners = True
        btnrespass.BackColor = Color.Transparent
        btnrespass.BorderRadius = 20
        btnrespass.CustomizableEdges = CustomizableEdges3
        btnrespass.DisabledState.BorderColor = Color.DarkGray
        btnrespass.DisabledState.CustomBorderColor = Color.DarkGray
        btnrespass.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnrespass.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnrespass.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnrespass.Font = New Font("Segoe UI", 9F)
        btnrespass.ForeColor = Color.White
        btnrespass.Location = New Point(34, 278)
        btnrespass.Name = "btnrespass"
        btnrespass.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnrespass.Size = New Size(301, 43)
        btnrespass.TabIndex = 2
        btnrespass.Text = "Reset password"
        ' 
        ' resconfirmnewpass
        ' 
        resconfirmnewpass.AutoRoundedCorners = True
        resconfirmnewpass.BackColor = Color.Transparent
        resconfirmnewpass.BorderRadius = 20
        resconfirmnewpass.CustomizableEdges = CustomizableEdges5
        resconfirmnewpass.DefaultText = ""
        resconfirmnewpass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        resconfirmnewpass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        resconfirmnewpass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        resconfirmnewpass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        resconfirmnewpass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        resconfirmnewpass.Font = New Font("Segoe UI", 9F)
        resconfirmnewpass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        resconfirmnewpass.Location = New Point(34, 215)
        resconfirmnewpass.Margin = New Padding(3, 4, 3, 4)
        resconfirmnewpass.Name = "resconfirmnewpass"
        resconfirmnewpass.PasswordChar = "●"c
        resconfirmnewpass.PlaceholderText = ""
        resconfirmnewpass.SelectedText = ""
        resconfirmnewpass.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        resconfirmnewpass.Size = New Size(301, 43)
        resconfirmnewpass.TabIndex = 5
        resconfirmnewpass.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(92, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 31)
        Label4.TabIndex = 8
        Label4.Text = "Reset Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(34, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 23)
        Label3.TabIndex = 5
        Label3.Text = "confirm password *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 23)
        Label2.TabIndex = 3
        Label2.Text = "new password *"
        ' 
        ' forgot_password
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BurlyWood
        ClientSize = New Size(800, 579)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "forgot_password"
        Text = "forgot_password"
        WindowState = FormWindowState.Minimized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents res_newpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents resconfirmnewpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnrespass As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents newshow As Button
    Friend WithEvents newhide As Button
    Friend WithEvents hideconfirm As Button
    Friend WithEvents showconfirm As Button
End Class
