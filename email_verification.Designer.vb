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
        Label1 = New Label()
        Label2 = New Label()
        txtemail = New TextBox()
        continueto_otp = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(135, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 31)
        Label1.TabIndex = 0
        Label1.Text = "Email Verification"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(121, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(247, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter your Registered Email address"
        ' 
        ' txtemail
        ' 
        txtemail.BorderStyle = BorderStyle.None
        txtemail.ForeColor = Color.DarkGray
        txtemail.Location = New Point(3, 12)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(315, 20)
        txtemail.TabIndex = 2
        txtemail.Text = "Enter email address"
        ' 
        ' continueto_otp
        ' 
        continueto_otp.Anchor = AnchorStyles.Top
        continueto_otp.BackColor = Color.Orange
        continueto_otp.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        continueto_otp.Location = New Point(92, 271)
        continueto_otp.Name = "continueto_otp"
        continueto_otp.Size = New Size(321, 50)
        continueto_otp.TabIndex = 3
        continueto_otp.Text = "Continue"
        continueto_otp.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtemail)
        Panel1.Location = New Point(92, 222)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(321, 45)
        Panel1.TabIndex = 4
        ' 
        ' email_verification
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BurlyWood
        ClientSize = New Size(576, 486)
        Controls.Add(Panel1)
        Controls.Add(continueto_otp)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "email_verification"
        Text = "email_verification"
        WindowState = FormWindowState.Minimized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents continueto_otp As Button
    Friend WithEvents Panel1 As Panel
End Class
