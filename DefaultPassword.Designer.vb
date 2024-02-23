<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefaultPassword
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DefaultPassword))
        Panel1 = New Panel()
        btnUpdatePassword = New Guna.UI2.WinForms.Guna2GradientButton()
        txtconfirmpass = New Guna.UI2.WinForms.Guna2TextBox()
        txtnewpass = New Guna.UI2.WinForms.Guna2TextBox()
        txtcurrentpas = New Guna.UI2.WinForms.Guna2TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel1.Controls.Add(btnUpdatePassword)
        Panel1.Controls.Add(txtconfirmpass)
        Panel1.Controls.Add(txtnewpass)
        Panel1.Controls.Add(txtcurrentpas)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(75, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 450)
        Panel1.TabIndex = 1
        ' 
        ' btnUpdatePassword
        ' 
        btnUpdatePassword.AutoRoundedCorners = True
        btnUpdatePassword.BackColor = Color.Transparent
        btnUpdatePassword.BorderRadius = 19
        btnUpdatePassword.CustomizableEdges = CustomizableEdges1
        btnUpdatePassword.DisabledState.BorderColor = Color.DarkGray
        btnUpdatePassword.DisabledState.CustomBorderColor = Color.DarkGray
        btnUpdatePassword.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUpdatePassword.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUpdatePassword.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUpdatePassword.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnUpdatePassword.FillColor2 = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        btnUpdatePassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdatePassword.ForeColor = Color.White
        btnUpdatePassword.Location = New Point(64, 341)
        btnUpdatePassword.Name = "btnUpdatePassword"
        btnUpdatePassword.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnUpdatePassword.Size = New Size(282, 40)
        btnUpdatePassword.TabIndex = 15
        btnUpdatePassword.Text = "Update password"
        ' 
        ' txtconfirmpass
        ' 
        txtconfirmpass.AutoRoundedCorners = True
        txtconfirmpass.BackColor = Color.Transparent
        txtconfirmpass.BorderRadius = 19
        txtconfirmpass.CustomizableEdges = CustomizableEdges3
        txtconfirmpass.DefaultText = ""
        txtconfirmpass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtconfirmpass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtconfirmpass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtconfirmpass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtconfirmpass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtconfirmpass.Font = New Font("Segoe UI", 9F)
        txtconfirmpass.ForeColor = Color.Black
        txtconfirmpass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtconfirmpass.Location = New Point(68, 276)
        txtconfirmpass.Margin = New Padding(3, 4, 3, 4)
        txtconfirmpass.Name = "txtconfirmpass"
        txtconfirmpass.PasswordChar = ChrW(0)
        txtconfirmpass.PlaceholderText = ""
        txtconfirmpass.SelectedText = ""
        txtconfirmpass.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtconfirmpass.Size = New Size(278, 40)
        txtconfirmpass.TabIndex = 9
        ' 
        ' txtnewpass
        ' 
        txtnewpass.AutoRoundedCorners = True
        txtnewpass.BackColor = Color.Transparent
        txtnewpass.BorderRadius = 19
        txtnewpass.CustomizableEdges = CustomizableEdges5
        txtnewpass.DefaultText = ""
        txtnewpass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtnewpass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtnewpass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtnewpass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtnewpass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtnewpass.Font = New Font("Segoe UI", 9F)
        txtnewpass.ForeColor = Color.Black
        txtnewpass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtnewpass.Location = New Point(68, 209)
        txtnewpass.Margin = New Padding(3, 4, 3, 4)
        txtnewpass.Name = "txtnewpass"
        txtnewpass.PasswordChar = ChrW(0)
        txtnewpass.PlaceholderText = ""
        txtnewpass.SelectedText = ""
        txtnewpass.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtnewpass.Size = New Size(278, 40)
        txtnewpass.TabIndex = 3
        ' 
        ' txtcurrentpas
        ' 
        txtcurrentpas.AutoRoundedCorners = True
        txtcurrentpas.BackColor = Color.Transparent
        txtcurrentpas.BorderRadius = 19
        txtcurrentpas.CustomizableEdges = CustomizableEdges7
        txtcurrentpas.DefaultText = ""
        txtcurrentpas.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtcurrentpas.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtcurrentpas.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtcurrentpas.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtcurrentpas.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtcurrentpas.Font = New Font("Segoe UI", 9F)
        txtcurrentpas.ForeColor = Color.Black
        txtcurrentpas.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtcurrentpas.Location = New Point(68, 135)
        txtcurrentpas.Margin = New Padding(3, 4, 3, 4)
        txtcurrentpas.Name = "txtcurrentpas"
        txtcurrentpas.PasswordChar = ChrW(0)
        txtcurrentpas.PlaceholderText = ""
        txtcurrentpas.SelectedText = ""
        txtcurrentpas.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtcurrentpas.Size = New Size(278, 40)
        txtcurrentpas.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(64, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(286, 31)
        Label4.TabIndex = 8
        Label4.Text = "Change Default Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(68, 249)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 23)
        Label3.TabIndex = 5
        Label3.Text = "confirm new password *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(68, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 23)
        Label2.TabIndex = 3
        Label2.Text = "new password *"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(68, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 23)
        Label1.TabIndex = 0
        Label1.Text = "Current password *"
        ' 
        ' DefaultPassword
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BurlyWood
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1008, 753)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "DefaultPassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DefaultPassword"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUpdatePassword As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtconfirmpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtnewpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcurrentpas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
