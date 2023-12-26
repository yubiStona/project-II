<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pass_recovery
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Label4 = New Label()
        TextBox5 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtcyrrentpas = New Guna.UI2.WinForms.Guna2TextBox()
        txtnewpass = New Guna.UI2.WinForms.Guna2TextBox()
        txtconfirmpass = New Guna.UI2.WinForms.Guna2TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel1.Controls.Add(txtconfirmpass)
        Panel1.Controls.Add(txtnewpass)
        Panel1.Controls.Add(txtcyrrentpas)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(75, 90)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(392, 379)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(49, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(286, 31)
        Label4.TabIndex = 8
        Label4.Text = "Change Default Password"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Orange
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(34, 309)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(301, 38)
        TextBox5.TabIndex = 7
        TextBox5.Text = "Reset Password"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(34, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 23)
        Label3.TabIndex = 5
        Label3.Text = "confirm new password *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 23)
        Label2.TabIndex = 3
        Label2.Text = "new password *"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 23)
        Label1.TabIndex = 0
        Label1.Text = "Current password *"
        ' 
        ' txtcyrrentpas
        ' 
        txtcyrrentpas.AutoRoundedCorners = True
        txtcyrrentpas.BackColor = Color.Transparent
        txtcyrrentpas.BorderRadius = 20
        txtcyrrentpas.CustomizableEdges = CustomizableEdges7
        txtcyrrentpas.DefaultText = ""
        txtcyrrentpas.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtcyrrentpas.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtcyrrentpas.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtcyrrentpas.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtcyrrentpas.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtcyrrentpas.Font = New Font("Segoe UI", 9F)
        txtcyrrentpas.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtcyrrentpas.Location = New Point(34, 110)
        txtcyrrentpas.Margin = New Padding(3, 4, 3, 4)
        txtcyrrentpas.Name = "txtcyrrentpas"
        txtcyrrentpas.PasswordChar = ChrW(0)
        txtcyrrentpas.PlaceholderText = ""
        txtcyrrentpas.SelectedText = ""
        txtcyrrentpas.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtcyrrentpas.Size = New Size(301, 43)
        txtcyrrentpas.TabIndex = 1
        ' 
        ' txtnewpass
        ' 
        txtnewpass.AutoRoundedCorners = True
        txtnewpass.BackColor = Color.Transparent
        txtnewpass.BorderRadius = 20
        txtnewpass.CustomizableEdges = CustomizableEdges9
        txtnewpass.DefaultText = ""
        txtnewpass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtnewpass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtnewpass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtnewpass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtnewpass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtnewpass.Font = New Font("Segoe UI", 9F)
        txtnewpass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtnewpass.Location = New Point(34, 181)
        txtnewpass.Margin = New Padding(3, 4, 3, 4)
        txtnewpass.Name = "txtnewpass"
        txtnewpass.PasswordChar = ChrW(0)
        txtnewpass.PlaceholderText = ""
        txtnewpass.SelectedText = ""
        txtnewpass.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtnewpass.Size = New Size(301, 43)
        txtnewpass.TabIndex = 3
        ' 
        ' txtconfirmpass
        ' 
        txtconfirmpass.AutoRoundedCorners = True
        txtconfirmpass.BackColor = Color.Transparent
        txtconfirmpass.BorderRadius = 20
        txtconfirmpass.CustomizableEdges = CustomizableEdges11
        txtconfirmpass.DefaultText = ""
        txtconfirmpass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtconfirmpass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtconfirmpass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtconfirmpass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtconfirmpass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtconfirmpass.Font = New Font("Segoe UI", 9F)
        txtconfirmpass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtconfirmpass.Location = New Point(34, 251)
        txtconfirmpass.Margin = New Padding(3, 4, 3, 4)
        txtconfirmpass.Name = "txtconfirmpass"
        txtconfirmpass.PasswordChar = ChrW(0)
        txtconfirmpass.PlaceholderText = ""
        txtconfirmpass.SelectedText = ""
        txtconfirmpass.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txtconfirmpass.Size = New Size(301, 43)
        txtconfirmpass.TabIndex = 9
        ' 
        ' pass_recovery
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BurlyWood
        ClientSize = New Size(561, 572)
        Controls.Add(Panel1)
        ForeColor = Color.Black
        Name = "pass_recovery"
        Text = "pass_recovery"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcyrrentpas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtnewpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtconfirmpass As Guna.UI2.WinForms.Guna2TextBox
End Class
