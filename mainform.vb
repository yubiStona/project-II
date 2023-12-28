Imports FontAwesome.Sharp

Public Class mainform
    Private currentbtn As IconButton
    Private leftBorderBtn As Panel
    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 50)
        panelmenu.Controls.Add(leftBorderBtn)
    End Sub

    'method

    Private Sub ActivateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            'button
            currentbtn = CType(senderBtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(37, 36, 81)
            currentbtn.ForeColor = customcolor
            currentbtn.IconColor = customcolor
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'left Border
            leftBorderBtn.BackColor = customcolor
            leftBorderBtn.Location = New Point(0, currentbtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'current form icon


        End If
    End Sub
End Class