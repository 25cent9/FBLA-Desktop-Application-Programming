
'Name: Innocent Niyibizi
'Date: 10-23-15
'Purpose: User login screen. Password is entered and user is given certain privleges based on their passcode

Imports System.Deployment.Application

Public Class formPasscode

    'Event that occurs when the submit button is pressed
    'Form will validate password and given appropriate permissions for the account type
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 6 Then
            If TextBox1.Text = "123456" Then
                Me.Visible = False
                mainForm.Visible = True
            Else
                MsgBox("Incorrect Passcode")
            End If
        Else
            MsgBox("Passcode entered is too short")
        End If
    End Sub

    'Event that occurs when the form is loaded
    'Text and input box is centered and properly aligned 
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button1.Top = (Me.Height / 1.85) - (Button1.Height / 2)
        Button1.Left = (Me.Width / 2) - (Button1.Width / 2)

        TextBox1.Top = (Me.Height / 2) - (TextBox1.Height / 2)
        TextBox1.Left = (Me.Width / 2) - (TextBox1.Width / 2)
        lblPasscode.Top = (Me.Height / 2) - (TextBox1.Height / 2)
        lblPasscode.Left = (Me.Width / 2) - 115
        labelCopy.Text = My.Application.Info.Copyright
        labelCopy.Left = (Me.Width / 2) - (labelCopy.Width / 2)


    End Sub

    'Event that occurs when a key is pressed in the text box
    Private Sub TextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text.Length = 6 Then
                If TextBox1.Text = "123456" Then
                    Me.Visible = False
                    mainForm.Visible = True
                Else
                    MsgBox("Incorrect Passcode")
                End If
            Else
                MsgBox("Passcode entered is too short")
            End If
        End If
    End Sub

End Class

'Maintinence Log*******************************************************************
'October 2015:  Project started, default password set
'December 2015: Centered submit button and textbox entry
'January 2016:  Added option too either press enter or the submit button when logging in
