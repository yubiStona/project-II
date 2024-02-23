Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports Windows.UI.StartScreen

Public Class mainform
    Dim con As SqlConnection = New SqlConnection("Data Source=LOCALHOST;Initial Catalog=cafeteriadb;Integrated Security=True;Encrypt=False")
    Private currentbtn As Button
    Private leftBorderBtn As Panel
    Private currentChildform As Form
    Private _isAdmin As Integer
    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        panelmenu.Controls.Add(leftBorderBtn)

        'form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Public Property isAdmin As Integer
        Get
            Return _isAdmin
        End Get
        Set(value As Integer)
            _isAdmin = value
        End Set
    End Property
    'method

    Private Sub ActivateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'button
            currentbtn = CType(senderBtn, Button)
            'currentbtn.BackColor = Color.FromArgb(37, 36, 81)
            currentbtn.BackColor = Color.FromArgb(255, 125, 5)
            currentbtn.ForeColor = customcolor
            'currentbtn.IconColor = customcolor
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.ImageAlign = ContentAlignment.MiddleRight
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'left Border
            leftBorderBtn.BackColor = customcolor
            leftBorderBtn.Location = New Point(0, currentbtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'current form icon
        End If
    End Sub

    Private Sub DisableButton()
        If currentbtn IsNot Nothing Then
            'currentbtn.BackColor = Color.FromArgb(156, 71, 0)
            currentbtn.BackColor = Color.FromArgb(244, 164, 96)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Public Sub OpenChildForm(childForm As Form, parentPanel As Panel)
        ' Check if the child form is already open
        If currentChildform IsNot Nothing AndAlso currentChildform.GetType() Is childForm.GetType() Then
            ' Bring the existing form to the front
            currentChildform.BringToFront()
        Else
            ' Open a new instance of the child form
            If currentChildform IsNot Nothing Then
                currentChildform.Close()
            End If

            currentChildform = childForm
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill
            parentPanel.Controls.Add(childForm)
            parentPanel.Tag = childForm
            childForm.BringToFront()
            childForm.Show()
        End If
    End Sub

    'events
    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        ActivateButton(sender, Color.FromArgb(251, 56, 8))
        OpenChildForm(Home, Paneldesktop)

    End Sub

    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click
        ActivateButton(sender, Color.FromArgb(172, 126, 24))
        OpenChildForm(addProduct, Paneldesktop)
    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        ActivateButton(sender, Color.FromArgb(172, 126, 24))
        OpenChildForm(order, Paneldesktop)
    End Sub

    Private Sub btntable_Click(sender As Object, e As EventArgs) Handles btntable.Click
        ActivateButton(sender, Color.FromArgb(172, 126, 24))
        OpenChildForm(addTables, Paneldesktop)
    End Sub

    Private Sub btnusers_Click(sender As Object, e As EventArgs) Handles btnusers.Click
        ActivateButton(sender, Color.FromArgb(172, 126, 24))
        OpenChildForm(addUsers, Paneldesktop)
    End Sub

    'drag form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As Integer)

    End Sub

    Private Sub paneltop_MouseDown(sender As Object, e As MouseEventArgs) Handles paneltop.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub mainform_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()

    End Sub

    Private Sub btnmaximize_Click(sender As Object, e As EventArgs) Handles btnmaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isAdmin = 0 Then
            btnusers.Visible = False
            btnsetting.Visible = False
        End If
        getcafeInfo()
        OpenChildForm(Home, Paneldesktop)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim obj22 As Login = New Login
            obj22.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub btnsetting_Click(sender As Object, e As EventArgs) Handles btnsetting.Click
        ActivateButton(sender, Color.FromArgb(172, 126, 24))
        OpenChildForm(setting, Paneldesktop)
    End Sub

    Sub getcafeInfo()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("getcafeinfo", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Label1.Text = reader("Name")
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("Invalid cafe info", vbCritical)
            con.Close()
        End Try
    End Sub

End Class