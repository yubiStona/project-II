<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class email_verification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(email_verification))
        Label1 = New Label()
        Label2 = New Label()
        submit_otp = New Button()
        txtemail1 = New Guna.UI2.WinForms.Guna2TextBox()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(130, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 31)
        Label1.TabIndex = 0
        Label1.Text = "Email Verification"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.LightSeaGreen
        Label2.Location = New Point(109, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(254, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter your Registered Email address"
        ' 
        ' submit_otp
        ' 
        submit_otp.Anchor = AnchorStyles.Top
        submit_otp.BackColor = Color.Orange
        submit_otp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        submit_otp.Location = New Point(61, 230)
        submit_otp.Name = "submit_otp"
        submit_otp.Size = New Size(321, 50)
        submit_otp.TabIndex = 3
        submit_otp.Text = "Submit"
        submit_otp.UseVisualStyleBackColor = False
        ' 
        ' txtemail1
        ' 
        txtemail1.CustomizableEdges = CustomizableEdges1
        txtemail1.DefaultText = "Enter email address"
        txtemail1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtemail1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtemail1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtemail1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtemail1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtemail1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtemail1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtemail1.Location = New Point(61, 173)
        txtemail1.Margin = New Padding(3, 4, 3, 4)
        txtemail1.Name = "txtemail1"
        txtemail1.PasswordChar = ChrW(0)
        txtemail1.PlaceholderText = ""
        txtemail1.SelectedText = ""
        txtemail1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtemail1.Size = New Size(321, 50)
        txtemail1.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtemail1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(submit_otp)
        Panel1.Location = New Point(547, 180)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(434, 406)
        Panel1.TabIndex = 6
        ' 
        ' email_verification
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1008, 753)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "email_verification"
        StartPosition = FormStartPosition.CenterScreen
        Text = "email_verification"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents submit_otp As Button
    Friend WithEvents txtemail1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
End Class
