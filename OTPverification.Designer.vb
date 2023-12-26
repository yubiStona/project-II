<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OTPverification
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OTPverification))
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        btnsubmit = New Bunifu.Framework.UI.BunifuThinButton2()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(28, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(305, 73)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(24, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 20)
        Label3.TabIndex = 5
        Label3.Text = "just sent to your email address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(23, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(270, 20)
        Label2.TabIndex = 4
        Label2.Text = "Please enter the verification code we've"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MintCream
        Label1.Location = New Point(83, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 31)
        Label1.TabIndex = 3
        Label1.Text = "OTP Verification"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.SaddleBrown
        Panel3.Controls.Add(Guna2TextBox4)
        Panel3.Controls.Add(Guna2TextBox3)
        Panel3.Controls.Add(Guna2TextBox2)
        Panel3.Controls.Add(Guna2TextBox1)
        Panel3.Controls.Add(btnsubmit)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Panel1)
        Panel3.Location = New Point(158, 134)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(369, 337)
        Panel3.TabIndex = 5
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BackColor = Color.White
        Guna2TextBox1.CustomizableEdges = CustomizableEdges9
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(30, 154)
        Guna2TextBox1.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2TextBox1.Size = New Size(60, 60)
        Guna2TextBox1.TabIndex = 7
        ' 
        ' btnsubmit
        ' 
        btnsubmit.ActiveBorderThickness = 1
        btnsubmit.ActiveCornerRadius = 20
        btnsubmit.ActiveFillColor = Color.Orange
        btnsubmit.ActiveForecolor = Color.Black
        btnsubmit.ActiveLineColor = Color.Transparent
        btnsubmit.BackColor = Color.SaddleBrown
        btnsubmit.BackgroundImage = CType(resources.GetObject("btnsubmit.BackgroundImage"), Image)
        btnsubmit.ButtonText = "Submit"
        btnsubmit.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsubmit.ForeColor = Color.Black
        btnsubmit.IdleBorderThickness = 1
        btnsubmit.IdleCornerRadius = 20
        btnsubmit.IdleFillColor = Color.DarkOrange
        btnsubmit.IdleForecolor = Color.White
        btnsubmit.IdleLineColor = Color.SeaGreen
        btnsubmit.Location = New Point(28, 227)
        btnsubmit.Margin = New Padding(7, 5, 7, 5)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(305, 60)
        btnsubmit.TabIndex = 6
        btnsubmit.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.BackColor = Color.White
        Guna2TextBox2.CustomizableEdges = CustomizableEdges11
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F)
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(108, 154)
        Guna2TextBox2.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderText = ""
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2TextBox2.Size = New Size(60, 60)
        Guna2TextBox2.TabIndex = 8
        ' 
        ' Guna2TextBox3
        ' 
        Guna2TextBox3.BackColor = Color.White
        Guna2TextBox3.CustomizableEdges = CustomizableEdges13
        Guna2TextBox3.DefaultText = ""
        Guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox3.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Font = New Font("Segoe UI", 9F)
        Guna2TextBox3.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Location = New Point(188, 154)
        Guna2TextBox3.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox3.Name = "Guna2TextBox3"
        Guna2TextBox3.PasswordChar = ChrW(0)
        Guna2TextBox3.PlaceholderText = ""
        Guna2TextBox3.SelectedText = ""
        Guna2TextBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2TextBox3.Size = New Size(60, 60)
        Guna2TextBox3.TabIndex = 9
        ' 
        ' Guna2TextBox4
        ' 
        Guna2TextBox4.BackColor = Color.White
        Guna2TextBox4.CustomizableEdges = CustomizableEdges15
        Guna2TextBox4.DefaultText = ""
        Guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox4.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox4.Font = New Font("Segoe UI", 9F)
        Guna2TextBox4.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox4.Location = New Point(273, 154)
        Guna2TextBox4.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox4.Name = "Guna2TextBox4"
        Guna2TextBox4.PasswordChar = ChrW(0)
        Guna2TextBox4.PlaceholderText = ""
        Guna2TextBox4.SelectedText = ""
        Guna2TextBox4.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2TextBox4.Size = New Size(60, 60)
        Guna2TextBox4.TabIndex = 10
        ' 
        ' OTPverification
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(684, 665)
        Controls.Add(Panel3)
        DoubleBuffered = True
        MaximizeBox = False
        Name = "OTPverification"
        Text = "OTPverification"
        WindowState = FormWindowState.Minimized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnsubmit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
End Class
