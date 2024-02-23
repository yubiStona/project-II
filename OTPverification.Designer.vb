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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OTPverification))
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        btnverifyotp = New Guna.UI2.WinForms.Guna2GradientButton()
        lblresendotp = New Label()
        lbltimer = New Label()
        Label4 = New Label()
        txtotp4 = New Guna.UI2.WinForms.Guna2TextBox()
        txtotp3 = New Guna.UI2.WinForms.Guna2TextBox()
        txtotp2 = New Guna.UI2.WinForms.Guna2TextBox()
        txtotp1 = New Guna.UI2.WinForms.Guna2TextBox()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(68, 85)
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
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MintCream
        Label1.Location = New Point(123, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 31)
        Label1.TabIndex = 3
        Label1.Text = "OTP Verification"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.SaddleBrown
        Panel3.Controls.Add(btnverifyotp)
        Panel3.Controls.Add(lblresendotp)
        Panel3.Controls.Add(lbltimer)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txtotp4)
        Panel3.Controls.Add(txtotp3)
        Panel3.Controls.Add(txtotp2)
        Panel3.Controls.Add(txtotp1)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Panel1)
        Panel3.Location = New Point(547, 180)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(434, 406)
        Panel3.TabIndex = 5
        ' 
        ' btnverifyotp
        ' 
        btnverifyotp.AutoRoundedCorners = True
        btnverifyotp.BackColor = Color.Transparent
        btnverifyotp.BorderRadius = 22
        btnverifyotp.CustomizableEdges = CustomizableEdges1
        btnverifyotp.DisabledState.BorderColor = Color.DarkGray
        btnverifyotp.DisabledState.CustomBorderColor = Color.DarkGray
        btnverifyotp.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnverifyotp.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnverifyotp.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnverifyotp.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnverifyotp.FillColor2 = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        btnverifyotp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnverifyotp.ForeColor = Color.White
        btnverifyotp.Location = New Point(68, 296)
        btnverifyotp.Name = "btnverifyotp"
        btnverifyotp.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnverifyotp.Size = New Size(302, 46)
        btnverifyotp.TabIndex = 16
        btnverifyotp.Text = "Verify OTP"
        ' 
        ' lblresendotp
        ' 
        lblresendotp.AutoSize = True
        lblresendotp.BackColor = Color.Transparent
        lblresendotp.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblresendotp.ForeColor = Color.White
        lblresendotp.Location = New Point(281, 252)
        lblresendotp.Name = "lblresendotp"
        lblresendotp.Size = New Size(92, 20)
        lblresendotp.TabIndex = 14
        lblresendotp.Text = "Resend OTP"
        ' 
        ' lbltimer
        ' 
        lbltimer.AutoSize = True
        lbltimer.BackColor = Color.Transparent
        lbltimer.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltimer.ForeColor = Color.White
        lbltimer.Location = New Point(195, 253)
        lbltimer.Name = "lbltimer"
        lbltimer.Size = New Size(40, 20)
        lbltimer.TabIndex = 13
        lbltimer.Text = "1:00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(68, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 20)
        Label4.TabIndex = 12
        Label4.Text = "Time Remaining :"
        ' 
        ' txtotp4
        ' 
        txtotp4.BackColor = Color.White
        txtotp4.CustomizableEdges = CustomizableEdges3
        txtotp4.DefaultText = ""
        txtotp4.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtotp4.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtotp4.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtotp4.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtotp4.FillColor = Color.Snow
        txtotp4.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtotp4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtotp4.ForeColor = Color.Black
        txtotp4.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtotp4.Location = New Point(312, 181)
        txtotp4.Margin = New Padding(4, 5, 4, 5)
        txtotp4.Name = "txtotp4"
        txtotp4.PasswordChar = ChrW(0)
        txtotp4.PlaceholderText = ""
        txtotp4.SelectedText = ""
        txtotp4.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtotp4.Size = New Size(61, 55)
        txtotp4.TabIndex = 10
        txtotp4.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtotp3
        ' 
        txtotp3.BackColor = Color.White
        txtotp3.CustomizableEdges = CustomizableEdges5
        txtotp3.DefaultText = ""
        txtotp3.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtotp3.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtotp3.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtotp3.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtotp3.FillColor = Color.Snow
        txtotp3.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtotp3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtotp3.ForeColor = Color.Black
        txtotp3.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtotp3.Location = New Point(231, 181)
        txtotp3.Margin = New Padding(4, 5, 4, 5)
        txtotp3.Name = "txtotp3"
        txtotp3.PasswordChar = ChrW(0)
        txtotp3.PlaceholderText = ""
        txtotp3.SelectedText = ""
        txtotp3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtotp3.Size = New Size(61, 55)
        txtotp3.TabIndex = 9
        txtotp3.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtotp2
        ' 
        txtotp2.BackColor = Color.White
        txtotp2.CustomizableEdges = CustomizableEdges7
        txtotp2.DefaultText = ""
        txtotp2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtotp2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtotp2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtotp2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtotp2.FillColor = Color.Snow
        txtotp2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtotp2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtotp2.ForeColor = Color.Black
        txtotp2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtotp2.Location = New Point(151, 181)
        txtotp2.Margin = New Padding(4, 5, 4, 5)
        txtotp2.Name = "txtotp2"
        txtotp2.PasswordChar = ChrW(0)
        txtotp2.PlaceholderText = ""
        txtotp2.SelectedText = ""
        txtotp2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtotp2.Size = New Size(61, 55)
        txtotp2.TabIndex = 8
        txtotp2.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtotp1
        ' 
        txtotp1.BackColor = Color.White
        txtotp1.CustomizableEdges = CustomizableEdges9
        txtotp1.DefaultText = ""
        txtotp1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtotp1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtotp1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtotp1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtotp1.FillColor = Color.Snow
        txtotp1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtotp1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtotp1.ForeColor = Color.Black
        txtotp1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtotp1.Location = New Point(71, 182)
        txtotp1.Margin = New Padding(3, 5, 3, 5)
        txtotp1.Name = "txtotp1"
        txtotp1.PasswordChar = ChrW(0)
        txtotp1.PlaceholderText = ""
        txtotp1.SelectedText = ""
        txtotp1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtotp1.Size = New Size(61, 55)
        txtotp1.TabIndex = 7
        txtotp1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' OTPverification
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1026, 800)
        Controls.Add(Panel3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "OTPverification"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OTPverification"
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
    Friend WithEvents txtotp1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtotp4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtotp3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtotp2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltimer As Label
    Friend WithEvents lblresendotp As Label
    Friend WithEvents btnverifyotp As Guna.UI2.WinForms.Guna2GradientButton
End Class
