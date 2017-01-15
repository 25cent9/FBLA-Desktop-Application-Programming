
'Programmer: Innocent Niyibizi
'Date: 10/23/15
'Purpose: Create a program that can able to do the following: Add, delete, and edit any information on an FBLA member

Imports System.Text.RegularExpressions
Imports System.IO.Path
Public Class mainForm

    'All of the global variables and properties in relation to this class
#Region "Global variables and Properties"
    'Global variables used thorughout the program 
    Private cellTemp As String
    Private grade As Byte = 0
    Protected listMemebers As List(Of studentClass)
    Dim stateSource As New AutoCompleteStringCollection()

    'Property that is used by the report form to get the selected grade
    Property getGrade As Byte
        Get
            Return grade
        End Get
        Set(value As Byte)

        End Set
    End Property
#End Region


    'Event that occurs when the form is loaded 
    'Basic values are set and the database is read into datagridview element
    Private Sub mainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        formPasscode.Close()    'CLosing the passcode form
        Me.StudentInfoTableAdapter.Fill(Me.Student_InformationDataSet.StudentInfo)  'Filling the datagrid with the data from the database
        Me.StudentInfoDataGridView.Columns(7).DefaultCellStyle.Format = "$0.00" 'Changing formating of the cell that holds the amount owed to show the dollar amount 

        'Aligning the last four columns of the datagridview to the middle right
        Me.StudentInfoDataGridView.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.StudentInfoDataGridView.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.StudentInfoDataGridView.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.StudentInfoDataGridView.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        BindingNavigator1.BindingSource = StudentInfoBindingSource  'Setting the binding source 

        gatherInput() 'Calling function to instantiate new objects of the student class
    End Sub


    'Opening up the form that holds the report information based on the grade level selected
#Region "Opening reports"
    'Opening the report form with the grade property set to 12 for seniors
    Private Sub SeniorsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles menustripSenior.Click
        grade = 12
        reportForm.Visible = True

    End Sub

    'Opening the report form with the grade property set to 11 for juniors
    Private Sub JuniorsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JuniorsToolStripMenuItem.Click
        grade = 11
        reportForm.Visible = True
    End Sub

    'Opening the report form with the grade property set to 10 for sophomores
    Private Sub SophmoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SophmoresToolStripMenuItem.Click
        grade = 10
        reportForm.Visible = True
    End Sub

    'Opening the report form with the grade property set to 9 for freshmen
    Private Sub FreshmenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FreshmenToolStripMenuItem.Click
        grade = 9
        reportForm.Visible = True
    End Sub

    'Opening the report form with the grade property set to 13 for all members owing a balance
    Private Sub MembersOwingABalanceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MembersOwingABalanceToolStripMenuItem.Click
        grade = 13
        reportForm.Visible = True
    End Sub
#End Region

    'Subroutines that occur when the current cell is undergoing some sort of event
#Region "Current Cell Changing"

    'Changing the values of the input boxes when the user selects a new cell on the grid
    Private Sub StudentInfoDataGridView_Click(sender As System.Object, e As System.EventArgs) Handles StudentInfoDataGridView.Click
        'Changing the values of the text boxes to match the current row that is selected when the add user button is not visible
        If btnAdd.Visible = False Then
            txtBoxNum.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(0).Value.ToString
            txtBoxFName.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(1).Value.ToString
            txtBoxLName.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(2).Value.ToString
            txtBoxSchool.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(3).Value.ToString
            cmboState.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(4).Value.ToString
            txtBoxEmail.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(5).Value.ToString
            txtBoxYr.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(6).Value.ToString
            txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(7).Value).ToString
            If StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(8).Value.ToString = "Yes" Then
                cmboActive.SelectedIndex = 0
            Else
                cmboActive.SelectedIndex = 1
            End If
            cmboGrade.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(9).Value.ToString
        End If
    End Sub


    'Changing the value of the text box when the binding source navigator buttons are clicked
    Private Sub BindingNavigatorMoveLastItem_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles BindingNavigatorMovePreviousItem.MouseUp, BindingNavigatorMoveNextItem.MouseUp, BindingNavigatorMoveLastItem.MouseUp, BindingNavigatorMoveFirstItem.MouseUp
        If btnAdd.Visible = False Then  'Checking to see if the add new button is visible 
            txtBoxNum.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(0).Value.ToString
            txtBoxFName.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(1).Value.ToString
            txtBoxLName.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(2).Value.ToString
            txtBoxSchool.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(3).Value.ToString
            cmboState.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(4).Value.ToString
            txtBoxEmail.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(5).Value.ToString
            txtBoxYr.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(6).Value.ToString
            txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(7).Value).ToString
            If StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(8).Value.ToString = "Yes" Then
                cmboActive.SelectedIndex = 0
            Else
                cmboActive.SelectedIndex = 1
            End If
            cmboGrade.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(9).Value.ToString
        End If
    End Sub

    'Subroutine to handle the enter key being pressed on the text boxes
    Private Sub txtBoxNum_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBoxNum.KeyDown, txtBoxLName.KeyDown, txtBoxFName.KeyDown, txtBoxEmail.KeyDown
        Dim temp As String = " "
        Dim first As Char = " "c
        Dim found As Boolean = False
        'Checking to see if the user clicked the enter when inputing text into the text box
        If e.KeyCode = Keys.F1 Then
            getHelp()
        ElseIf e.KeyCode = Keys.Enter And btnAdd.Visible = False Then
            'Checking to see which text box has been changed
            If sender Is txtBoxNum Then
                'Nested loops to run to check each cell in the database in order to find the value from the textbox
                For i As Integer = 0 To StudentInfoDataGridView.RowCount - 1
                    If StudentInfoDataGridView.Rows(i).Cells(0).Value = txtBoxNum.Text Then
                        'If cell is found, then textboxes will be filled with corresponding data from that student
                        found = True
                        txtBoxFName.Text = StudentInfoDataGridView.Rows(i).Cells(1).Value.ToString
                        txtBoxLName.Text = StudentInfoDataGridView.Rows(i).Cells(2).Value.ToString
                        txtBoxSchool.Text = StudentInfoDataGridView.Rows(i).Cells(3).Value.ToString
                        cmboState.Text = StudentInfoDataGridView.Rows(i).Cells(4).Value.ToString
                        txtBoxEmail.Text = StudentInfoDataGridView.Rows(i).Cells(5).Value.ToString
                        txtBoxYr.Text = StudentInfoDataGridView.Rows(i).Cells(6).Value.ToString
                        txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(i).Cells(7).Value).ToString
                        If StudentInfoDataGridView.Rows(i).Cells(8).Value.ToString = "Yes" Then 'Checking to see if the seventh cell in the row is "yes" or "no" then changing the cell index of the active combobox accordingly
                            cmboActive.SelectedIndex = 0
                        Else
                            cmboActive.SelectedIndex = 1
                        End If
                        If StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "9" Then   'Checking the value of the eighth cell and changing the index of the grade level combobox accordignly
                            cmboGrade.SelectedIndex = 0
                        ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "10" Then
                            cmboGrade.SelectedIndex = 1
                        ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "11" Then
                            cmboGrade.SelectedIndex = 2
                        Else
                            cmboGrade.SelectedIndex = 3
                        End If
                        StudentInfoDataGridView.CurrentCell = StudentInfoDataGridView.Rows(i).Cells(0)
                        Exit For
                    End If
                Next
                If found = False Then   'Checking to see if variable for found is false, if it is then the follow actions will be preformed
                    If memberNotFound(txtBoxNum) = False Then   'If th memberNotFound function returns false then the current sub will exit
                        Exit Sub
                    End If
                End If
            ElseIf sender Is txtBoxFName Then
                'The following statements are to take the first letter of each input box and convert it to an uppercase letter in order to properly search the database for it
                subTheString(sender)
                For i As Integer = 0 To StudentInfoDataGridView.RowCount - 1    'Loop to itterate through every row of the datagridview 
                    If StudentInfoDataGridView.Rows(i).Cells(1).Value.ToString = txtBoxFName.Text Then  'If the value of the first name text box is equal to the current text box then the following will occur
                        'Changing found to true and setting the values of each text box to the corresponding values of the found row
                        found = True
                        txtBoxNum.Text = StudentInfoDataGridView.Rows(i).Cells(0).Value.ToString
                        txtBoxLName.Text = StudentInfoDataGridView.Rows(i).Cells(2).Value.ToString
                        txtBoxSchool.Text = StudentInfoDataGridView.Rows(i).Cells(3).Value.ToString
                        cmboState.Text = StudentInfoDataGridView.Rows(i).Cells(4).Value.ToString
                        txtBoxEmail.Text = StudentInfoDataGridView.Rows(i).Cells(5).Value.ToString
                        txtBoxYr.Text = StudentInfoDataGridView.Rows(i).Cells(6).Value.ToString
                        txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(i).Cells(7).Value).ToString
                        If StudentInfoDataGridView.Rows(i).Cells(8).Value.ToString = "Yes" Then
                            cmboActive.SelectedIndex = 0
                        Else
                            cmboActive.SelectedIndex = 1
                        End If
                        If StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "9" Then
                            cmboGrade.SelectedIndex = 0
                        ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "10" Then
                            cmboGrade.SelectedIndex = 1
                        ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "11" Then
                            cmboGrade.SelectedIndex = 2
                        Else
                            cmboGrade.SelectedIndex = 3
                        End If
                        StudentInfoDataGridView.CurrentCell = StudentInfoDataGridView.Rows(i).Cells(1)
                        Exit For
                    End If
                Next
                If found = False Then   'This will happen when found is false
                    If memberNotFound(txtBoxFName) = False Then   'If th memberNotFound function returns false then the current sub will exit
                        Exit Sub
                    End If
                End If
            ElseIf sender Is txtBoxLName Then   'Trying to find the member based on the last name entered
                subTheString(sender)
                For i As Integer = 0 To StudentInfoDataGridView.RowCount - 1
                    If StudentInfoDataGridView.Rows(i).Cells(2).Value.ToString = txtBoxLName.Text Then
                        found = True
                        txtBoxNum.Text = StudentInfoDataGridView.Rows(i).Cells(0).Value.ToString
                        txtBoxFName.Text = StudentInfoDataGridView.Rows(i).Cells(1).Value.ToString
                        txtBoxSchool.Text = StudentInfoDataGridView.Rows(i).Cells(3).Value.ToString
                        cmboState.Text = StudentInfoDataGridView.Rows(i).Cells(4).Value.ToString
                        txtBoxEmail.Text = StudentInfoDataGridView.Rows(i).Cells(5).Value.ToString
                        txtBoxYr.Text = StudentInfoDataGridView.Rows(i).Cells(6).Value.ToString
                        txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(i).Cells(7).Value).ToString
                        If StudentInfoDataGridView.Rows(i).Cells(8).Value.ToString = "Yes" Then
                            cmboActive.SelectedIndex = 0
                        Else
                            cmboActive.SelectedIndex = 1
                        End If
                        If StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "9" Then
                            cmboGrade.SelectedIndex = 0
                        ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "10" Then
                            cmboGrade.SelectedIndex = 1
                        ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "11" Then
                            cmboGrade.SelectedIndex = 2
                        Else
                            cmboGrade.SelectedIndex = 3
                        End If
                        StudentInfoDataGridView.CurrentCell = StudentInfoDataGridView.Rows(i).Cells(1)
                        Exit For
                    End If
                Next
                If found = False Then
                    If memberNotFound(txtBoxLName) = False Then   'If th memberNotFound function returns false then the current sub will exit
                        Exit Sub
                    End If
                End If
            ElseIf sender Is txtBoxEmail Then   'Trying to find the member in the datagridview based on the entered email
                For i As Integer = 0 To StudentInfoDataGridView.RowCount - 1
                    If StudentInfoDataGridView.Rows(i).Cells(5).Value.ToString = txtBoxEmail.Text Then
                        found = True
                        txtBoxNum.Text = StudentInfoDataGridView.Rows(i).Cells(0).Value.ToString
                        txtBoxFName.Text = StudentInfoDataGridView.Rows(i).Cells(1).Value.ToString
                        txtBoxSchool.Text = StudentInfoDataGridView.Rows(i).Cells(3).Value.ToString
                        cmboState.Text = StudentInfoDataGridView.Rows(i).Cells(4).Value.ToString
                        txtBoxLName.Text = StudentInfoDataGridView.Rows(i).Cells(2).Value.ToString
                        txtBoxYr.Text = StudentInfoDataGridView.Rows(i).Cells(6).Value.ToString
                        txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(i).Cells(7).Value).ToString
                        If StudentInfoDataGridView.Rows(i).Cells(8).Value.ToString = "Yes" Then
                            cmboActive.SelectedIndex = 0
                        Else
                            cmboActive.SelectedIndex = 1
                        End If
                        If StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "9" Then
                            cmboGrade.SelectedIndex = 0
                        ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "10" Then
                            cmboGrade.SelectedIndex = 1
                        ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "11" Then
                            cmboGrade.SelectedIndex = 2
                        Else
                            cmboGrade.SelectedIndex = 3
                        End If
                        StudentInfoDataGridView.CurrentCell = StudentInfoDataGridView.Rows(i).Cells(1)
                        Exit For
                    End If
                Next
                If found = False Then
                    If memberNotFound(txtBoxEmail) = False Then   'If th memberNotFound function returns false then the current sub will exit
                        Exit Sub
                    End If
                End If
            End If

        End If

    End Sub

    'Event that handles when the current cell of the grid is changed
    Private Sub StudentInfoDataGridView_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles StudentInfoDataGridView.CurrentCellChanged
        If btnAdd.Visible = False And StudentInfoDataGridView.CurrentRow IsNot Nothing Then
            txtBoxNum.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(0).Value.ToString
            txtBoxFName.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(1).Value.ToString
            txtBoxLName.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(2).Value.ToString
            txtBoxSchool.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(3).Value.ToString
            cmboState.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(4).Value.ToString
            txtBoxEmail.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(5).Value.ToString
            txtBoxYr.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(6).Value.ToString
            txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(7).Value).ToString
            If StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(8).Value.ToString = "Yes" Then
                cmboActive.SelectedIndex = 0
            Else
                cmboActive.SelectedIndex = 1
            End If
            cmboGrade.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentRow.Index).Cells(9).Value.ToString
        End If
    End Sub


#End Region

    'Events that occur when edits to any member information occurs 
#Region "Database Edits"

    'Subroutine to update the database once the user has ended editing a cell
    Private Sub StudentInfoDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentInfoDataGridView.CellEndEdit
        'Checking to see which cell was changed
        'Validation for the cell type will be done after type is found
        If StudentInfoDataGridView.CurrentCell.OwningColumn.DataPropertyName = "State" Then
            Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper
        ElseIf StudentInfoDataGridView.CurrentCell.OwningColumn.DataPropertyName = "Active" Then
            Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = subTheCell(Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        ElseIf StudentInfoDataGridView.CurrentCell.OwningColumn.DataPropertyName = "First Name" Or StudentInfoDataGridView.CurrentCell.OwningColumn.DataPropertyName = "Last Name" Then
            Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = subTheCell(Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            If StudentInfoDataGridView.CurrentCell.OwningColumn.DataPropertyName = "First Name" Then    'Checking to see if the current cell type is first name
                For i As Integer = 0 To txtBoxFName.AutoCompleteCustomSource.Count - 1  'Loop to run through the autocomplete list of the first names
                    If txtBoxFName.AutoCompleteCustomSource.Item(i) = cellTemp Then     'If the value of the current item in the list is equal to the temp value then the temp value will be removed
                        txtBoxFName.AutoCompleteCustomSource.RemoveAt(i)
                        Exit For
                    End If
                Next
                txtBoxFName.AutoCompleteCustomSource.Add(Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)    'Adding the value of the cell to the autocomplete list
            Else
                For i As Integer = 0 To txtBoxLName.AutoCompleteCustomSource.Count - 1  'Loop that runs through the autocomplete list of the last names 
                    If txtBoxLName.AutoCompleteCustomSource.Item(i) = cellTemp Then     'If value of current item in list is equal to the temp value then the temp value will be removed
                        txtBoxLName.AutoCompleteCustomSource.RemoveAt(i)
                        Exit For
                    End If
                Next
                txtBoxLName.AutoCompleteCustomSource.Add(Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)    'Value of cell will be added to the last name autocomplete list
            End If
        ElseIf StudentInfoDataGridView.CurrentCell.OwningColumn.DataPropertyName = "Number" Then
            For i As Integer = 0 To txtBoxNum.AutoCompleteCustomSource.Count - 1    'Loop that runs through the autocomplete list of the member numbers 
                If txtBoxNum.AutoCompleteCustomSource.Item(i) = Convert.ToInt64(cellTemp) Then  'Checking to see if the current item in the list is equal to the temp value then the temp value will be removed
                    txtBoxNum.AutoCompleteCustomSource.RemoveAt(i)
                    Exit For
                End If
            Next
            txtBoxNum.AutoCompleteCustomSource.Add(Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)  'Value of the cell will be added to the number autocomplete list
        ElseIf StudentInfoDataGridView.CurrentCell.OwningColumn.DataPropertyName = "Email" Then
            For i As Integer = 0 To txtBoxEmail.AutoCompleteCustomSource.Count - 1  'Loop that runs through the autocomplete list of the emails 
                If txtBoxEmail.AutoCompleteCustomSource.Item(i) = cellTemp Then 'If value of current item in the list is equal to the temp value then the temp value will be removed
                    txtBoxEmail.AutoCompleteCustomSource.RemoveAt(i)
                    Exit For
                End If
            Next
            txtBoxEmail.AutoCompleteCustomSource.Add(Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)    'Adding new email to email autocomplete list
        End If
        StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = Nothing
        cellTemp = Nothing  'Setting the value of cellTemp equal to nothing to save memory
        StudentInfoTableAdapter.Update(Student_InformationDataSet.StudentInfo)  'Updating the datatable 

    End Sub

    'Event that occurs once the current cell has finished validating
    'Checks which coloumn the cell resides in, then returns the proper error to the user
    Private Sub StudentInfoDataGridView_CellValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles StudentInfoDataGridView.CellValidating
        Dim currentCol As String = StudentInfoDataGridView.CurrentCell.OwningColumn.DataPropertyName    'String that stores the value of the current cell
        If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then 'Checking to see if the current cell is empty
            StudentInfoDataGridView.Rows(e.RowIndex).ErrorText =
                "Cell must not be empty!"
            e.Cancel = True
        End If
        'Switch statement used to error chcek the approriate cell based on the column of the current cell
        'Each case will provide an approiate error message to the user
        Select Case (currentCol)
            Case "Number"   'Case for the member number
                If IsNumeric(e.FormattedValue) = False Then
                        StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "Cell must an integer value!"
                        e.Cancel = True
                    End If
            Case "Year Joined"  'Case for the year joined
                If IsNumeric(e.FormattedValue) = False Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "Cell must an integer value!"
                    e.Cancel = True
                ElseIf Today.Year - e.FormattedValue > 4 Or e.FormattedValue > Today.Year Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "Year must be within four years!"
                    e.Cancel = True
                End If
            Case "Grade Level"  'Case for the grade level
                If IsNumeric(e.FormattedValue) = False Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "Cell must an integer value!"
                    e.Cancel = True
                ElseIf e.FormattedValue > 12 Or e.FormattedValue < 9 Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "Grade must be 9-12!"
                    e.Cancel = True
                End If
            Case "State"    'Case for state
                If CheckForAlphaCharacters(e.FormattedValue) = False Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "Cell must have only letters!"
                    e.Cancel = True
                ElseIf e.FormattedValue.ToString.Length > 2 Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "State must be in abbreviation!"
                    e.Cancel = True
                ElseIf stateSource.Contains(e.FormattedValue.ToString.ToUpper) = False Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "Entry must be a valid state!"
                    e.Cancel = True
                End If
            Case "Email"    ' Case for email
                If EmailAddressCheck(e.FormattedValue) = False Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "Cell must have a valid email address!"
                    e.Cancel = True
                End If
            Case "Active"   'Case for active value
                Dim active As String = e.FormattedValue.ToString
                If CheckForAlphaCharacters(e.FormattedValue) = False Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "Cell must have only letters!"
                    e.Cancel = True
                ElseIf active.ToUpper <> "YES" And active.ToUpper <> "NO" Then
                    StudentInfoDataGridView.Rows(e.RowIndex).ErrorText = "value of active must be 'Yes' or 'No'!"
                    e.Cancel = True
                End If
        End Select

    End Sub

    'Event that occurs once the current cell has begun editing
    'Saving the value of the current cell to a temp varaiable for later use
    Private Sub StudentInfoDataGridView_CellBeginEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles StudentInfoDataGridView.CellBeginEdit
        cellTemp = Me.StudentInfoDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value   'Setting cellTemp equal the current cell of the datagridview
    End Sub

    'Subroutine that deletes rows
    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        For Each row As DataGridViewRow In StudentInfoDataGridView.SelectedRows 'Loop that runs for each selected row
            StudentInfoDataGridView.Rows.Remove(row)    'Remoivng the currenting row of the selected row collection
        Next
        StudentInfoTableAdapter.Update(Me.Student_InformationDataSet.StudentInfo)   'Updating the datatable
    End Sub

    'Function to save data when called
    Private Sub Save()
        'Try Catch that tries to save the data to the dtatbase file
        'If it is unable to save then an error message will be displayed to the user
        Try
            StudentInfoBindingSource.EndEdit()
            StudentInfoTableAdapter.Update(Me.Student_InformationDataSet.StudentInfo)
        Catch ex As Exception
            MessageBox.Show("Error occured while saving data")
        End Try
    End Sub

    'Event that occurs when the add new button on the navigation button is pressed
    'All textboxes will be cleared and default values will be set accordingly
    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        txtBoxNum.Text = ""
        txtBoxFName.Text = ""
        txtBoxLName.Text = ""
        txtBoxSchool.Text = ""
        cmboState.SelectedIndex = 0
        txtBoxEmail.Text = ""
        txtBoxYr.Text = ""
        txtBoxAmnt.Text = ""
        cmboActive.SelectedIndex = 0
        cmboGrade.SelectedIndex = 0
        btnSearch.Visible = False
        btnAdd.Visible = True
        txtBoxSchool.ReadOnly = False
        cmboState.Enabled = True
        txtBoxYr.ReadOnly = False
        txtBoxYr.Text = Today.Year
        txtBoxAmnt.ReadOnly = False
        txtBoxAmnt.Text = 0
        cmboActive.Enabled = True
        cmboGrade.Enabled = True
        StudentInfoDataGridView.ReadOnly = True
    End Sub

    'Subroutine to save the information of the database when the user selects the save tool
    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            StudentInfoBindingSource.EndEdit()
            StudentInfoTableAdapter.Update(Me.Student_InformationDataSet.StudentInfo)
            MessageBox.Show("Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while saving data")
        End Try
    End Sub

#End Region

    'Events that occur when either the "Search" or "Add" buttons are pressed
#Region "Button Events"

    'Checking each textbox for possible errors before adding the member to the database
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim randInt As Integer  'Integer used to check the if a value that is being compared to it is an integer
        Dim boolValidInput As Boolean = False    'Boolean variable used to check if all the input values are valid
        Dim boolAmountCheck As Boolean = Double.TryParse(txtBoxAmnt.Text, randInt)  'Boolean that is used to check if the value of the amount text box can be parsed to an integer

        'Changing the value of amount and year to default values if they are empty
        If txtBoxAmnt.Text.Length = 0 And txtBoxYr.Text.Length = 0 Then
            txtBoxAmnt.Text = 0
            txtBoxYr.Text = Today.Year
        End If

        Dim intYearInput = Convert.ToInt32(txtBoxYr.Text) 'Integer that is used to hold the value of the inputed year 

        'Error checking all the input from the user
        'If any are false, an error message is thrown and sub is exited
        If txtBoxNum.Text.Length = 0 Then   'Checking to see if the length of the number text box's value is equal 0, if it is then an error message is displayed
            MsgBox("The member must have a member number!")
            boolValidInput = False
            Exit Sub
        ElseIf txtBoxFName.Text.Length = 0 Then   'Checking to see if the length of the first name text box's value is equal 0, if it is then an error message is displayed
            MsgBox("The member must have a first name!")
            boolValidInput = False
            Exit Sub
        ElseIf txtBoxLName.Text.Length <= 0 Then    'Checking to see if the length of the last name text box's value is equal 0, if it is then an error message is displayed
            MsgBox("The member must have a last name!")
            boolValidInput = False
            Exit Sub
        ElseIf txtBoxSchool.Text.Length <= 0 Then   'Checking to see if the length of the school text box's value is equal 0, if it is then an error message is displayed
            MsgBox("The member must have a school!")
            boolValidInput = False
            Exit Sub
        ElseIf txtBoxYr.Text.Length <= 0 Then       'Checking to see if the length of the year text box's value is equal 0, if it is then an error message is displayed
            MsgBox("The member must have a year joined!")
            boolValidInput = False
            Exit Sub
        ElseIf txtBoxEmail.Text.Length = 0 Then     'Checking to see if the length of the email text box's value is equal 0, if it is then an error message is displayed
            MsgBox("The member must have an email!")
            boolValidInput = False
            Exit Sub
        ElseIf EmailAddressCheck(txtBoxEmail.Text) = False Then 'Checking to see if the value returned from the EmailAddressCheck function is false, if it is false then an error message is displayed
            MsgBox("The member must have a valid email!")
            boolValidInput = False
            Exit Sub
        End If

        If boolAmountCheck = False Then 'Checking to see if the boolean boolAmountCheck is false, if it is false then an error message is displayed
            MsgBox("The member must have a valid amount!")
            boolValidInput = False
            Exit Sub
        End If

        If txtBoxYr.Text.Length > 0 And Today.Year - intYearInput > 4 Or intYearInput > Today.Year Then 'Checking to see if the year entered is within the last four years, if it is not then an error message will be shown
            MsgBox("The member's year of joinnig must have been in the last four years!")
            boolValidInput = False
            Exit Sub
        ElseIf txtBoxYr.Text.Length > 4 Or txtBoxYr.Text.Length = 0 Or txtBoxYr.Text.Length = 1 Then    'Checking to see if the length of the year text box's length is greater than 4 or less than 4, if it is then an error message will be shown
            MsgBox("The member's year of joining must be four digits!")
            boolValidInput = False
            Exit Sub
        End If

        'Setting the value of boolValidInput to true when it is false and the program reaches this point
        boolValidInput = True

        'Substringing the values of the first name, last name, and school
        If boolValidInput = True Then
            subTheString(txtBoxFName)
            subTheString(txtBoxLName)
            subTheString(txtBoxSchool)

            MsgBox("Adding " + txtBoxFName.Text + " " + txtBoxLName.Text + " to the database.") 'Notifying the user that the current memebr is being added to the database
            Try 'Trying to add the user to the current dataset 
                Me.Student_InformationDataSet.Tables(0).Rows.Add(txtBoxNum.Text, txtBoxFName.Text, txtBoxLName.Text, txtBoxSchool.Text, cmboState.Text, txtBoxEmail.Text, txtBoxYr.Text, txtBoxAmnt.Text, cmboActive.Text, Nothing, cmboGrade.Text)
            Catch   'Catch statement that catches when any exception is thrown and displays and error message
                MsgBox("Error; Input was invalid")
            End Try
            StudentInfoTableAdapter.Update(Student_InformationDataSet.StudentInfo)  'Updating the table adapter
            gatherInput()   'Running the gatherInput method to recreate instances of the student class object and refresh the autocomplete lists
            MsgBox("Successfully added " + txtBoxFName.Text + " " + txtBoxLName.Text + " to the database.") 'Informing the user that the member was added to the database
            'Setting the buttons and comboboxes back to their default values
            btnAdd.Visible = False
            btnSearch.Visible = True
            txtBoxSchool.ReadOnly = True
            cmboState.Enabled = False
            txtBoxYr.ReadOnly = True
            txtBoxAmnt.ReadOnly = True
            cmboActive.Enabled = False
            cmboGrade.Enabled = False
            StudentInfoDataGridView.ReadOnly = False
            StudentInfoDataGridView.CurrentCell = StudentInfoDataGridView(0, StudentInfoDataGridView.RowCount - 1)  'Setting the current cell of the datagridview equal to the las
            Save()  'Running the save function to save the database changes
        End If
    End Sub

    'Function to handle the button press to search for a user based on email, first name, last name, or member number
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click

        Dim boolMemberFound As Boolean = False  'Boolean that will be used to check if the member was found

        If txtBoxNum.Modified = True Then   'Checking to see if the number text box was modified
            'Loop to run to check each cell in the database in order to find the value from the textbox
            For i As Integer = 0 To StudentInfoDataGridView.RowCount - 1
                If StudentInfoDataGridView.Rows(i).Cells(0).Value = txtBoxNum.Text Then
                    'If cell is found, then textboxes will be filled with corresponding data from that student
                    boolMemberFound = True
                    txtBoxFName.Text = StudentInfoDataGridView.Rows(i).Cells(1).Value.ToString
                    txtBoxLName.Text = StudentInfoDataGridView.Rows(i).Cells(2).Value.ToString
                    txtBoxSchool.Text = StudentInfoDataGridView.Rows(i).Cells(3).Value.ToString
                    cmboState.Text = StudentInfoDataGridView.Rows(i).Cells(4).Value.ToString
                    txtBoxEmail.Text = StudentInfoDataGridView.Rows(i).Cells(5).Value.ToString
                    txtBoxYr.Text = StudentInfoDataGridView.Rows(i).Cells(6).Value.ToString
                    txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(i).Cells(7).Value).ToString
                    If StudentInfoDataGridView.Rows(i).Cells(8).Value.ToString = "Yes" Then
                        cmboActive.SelectedIndex = 0
                    Else
                        cmboActive.SelectedIndex = 1
                    End If
                    If StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "9" Then
                        cmboGrade.SelectedIndex = 0
                    ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "10" Then
                        cmboGrade.SelectedIndex = 1
                    ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "11" Then
                        cmboGrade.SelectedIndex = 2
                    Else
                        cmboGrade.SelectedIndex = 3
                    End If
                    StudentInfoDataGridView.CurrentCell = StudentInfoDataGridView.Rows(i).Cells(0)
                    Exit For
                End If
            Next
            If boolMemberFound = False Then   'Checking to see if boolean boolMemberFound is false
                If memberNotFound(txtBoxNum) = False Then   'If th memberNotFound function returns false then the current sub will exit
                    Exit Sub
                End If
            End If

        ElseIf txtBoxFName.Modified = True Then
            subTheString(txtBoxFName)   'Calling the substring method to take the first letter of the first name and capitalize it in order to properly search the database
            For i As Integer = 0 To StudentInfoDataGridView.RowCount - 1    'Loop that itterates through each row of the database
                If StudentInfoDataGridView.Rows(i).Cells(1).Value.ToString = txtBoxFName.Text Then  'Statement to check if the value of the second cell in the row is equal to the value of the first name text box
                    'Changing boolMemberFound to true 
                    'Setting the rest of the text boxes to have the value of the cell in the database that corresponds to it
                    boolMemberFound = True
                    txtBoxNum.Text = StudentInfoDataGridView.Rows(i).Cells(0).Value.ToString
                    txtBoxLName.Text = StudentInfoDataGridView.Rows(i).Cells(2).Value.ToString
                    txtBoxSchool.Text = StudentInfoDataGridView.Rows(i).Cells(3).Value.ToString
                    cmboState.Text = StudentInfoDataGridView.Rows(i).Cells(4).Value.ToString
                    txtBoxEmail.Text = StudentInfoDataGridView.Rows(i).Cells(5).Value.ToString
                    txtBoxYr.Text = StudentInfoDataGridView.Rows(i).Cells(6).Value.ToString
                    txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(i).Cells(7).Value).ToString
                    If StudentInfoDataGridView.Rows(i).Cells(8).Value.ToString = "Yes" Then
                        cmboActive.SelectedIndex = 0
                    Else
                        cmboActive.SelectedIndex = 1
                    End If
                    If StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "9" Then
                        cmboGrade.SelectedIndex = 0
                    ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "10" Then
                        cmboGrade.SelectedIndex = 1
                    ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "11" Then
                        cmboGrade.SelectedIndex = 2
                    Else
                        cmboGrade.SelectedIndex = 3
                    End If
                    StudentInfoDataGridView.CurrentCell = StudentInfoDataGridView.Rows(i).Cells(1)
                    Exit For
                End If
            Next
            If boolMemberFound = False Then   'Checking to see if the found boolean is false
                If memberNotFound(txtBoxFName) = False Then 'If the memberNotFound function returns false then the sub will exit
                    Exit Sub
                End If
            End If

        ElseIf txtBoxLName.Modified = True Then
            subTheString(txtBoxLName)
            For i As Integer = 0 To StudentInfoDataGridView.RowCount - 1
                If StudentInfoDataGridView.Rows(i).Cells(2).Value.ToString = txtBoxLName.Text Then
                    'Changing boolMemberFound to true 
                    'Setting the rest of the text boxes to have the value of the cell in the database that corresponds to it
                    boolMemberFound = True
                    txtBoxNum.Text = StudentInfoDataGridView.Rows(i).Cells(0).Value.ToString
                    txtBoxFName.Text = StudentInfoDataGridView.Rows(i).Cells(1).Value.ToString
                    txtBoxSchool.Text = StudentInfoDataGridView.Rows(i).Cells(3).Value.ToString
                    cmboState.Text = StudentInfoDataGridView.Rows(i).Cells(4).Value.ToString
                    txtBoxEmail.Text = StudentInfoDataGridView.Rows(i).Cells(5).Value.ToString
                    txtBoxYr.Text = StudentInfoDataGridView.Rows(i).Cells(6).Value.ToString
                    txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(i).Cells(7).Value).ToString
                    If StudentInfoDataGridView.Rows(i).Cells(8).Value.ToString = "Yes" Then
                        cmboActive.SelectedIndex = 0
                    Else
                        cmboActive.SelectedIndex = 1
                    End If
                    If StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "9" Then
                        cmboGrade.SelectedIndex = 0
                    ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "10" Then
                        cmboGrade.SelectedIndex = 1
                    ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "11" Then
                        cmboGrade.SelectedIndex = 2
                    Else
                        cmboGrade.SelectedIndex = 3
                    End If
                    StudentInfoDataGridView.CurrentCell = StudentInfoDataGridView.Rows(i).Cells(1)
                    Exit For
                End If
            Next
            If boolMemberFound = False Then   'Checking to see if the found boolean is false
                If (memberNotFound(txtBoxLName) = False) Then   'If the memberNotFound function returns a false then the current sub will exit
                    Exit Sub
                End If
            End If

        ElseIf txtBoxEmail.Modified = True Then
            If EmailAddressCheck(txtBoxEmail.Text) = False Then
                MsgBox("Invalid email format")
                Exit Sub
            End If
            For i As Integer = 0 To StudentInfoDataGridView.RowCount - 1
                If StudentInfoDataGridView.Rows(i).Cells(5).Value.ToString = txtBoxEmail.Text Then
                    'Changing boolMemberFound to true 
                    'Setting the rest of the text boxes to have the value of the cell in the database that corresponds to it
                    boolMemberFound = True
                    txtBoxNum.Text = StudentInfoDataGridView.Rows(i).Cells(0).Value.ToString
                    txtBoxFName.Text = StudentInfoDataGridView.Rows(i).Cells(1).Value.ToString
                    txtBoxSchool.Text = StudentInfoDataGridView.Rows(i).Cells(3).Value.ToString
                    cmboState.Text = StudentInfoDataGridView.Rows(i).Cells(4).Value.ToString
                    txtBoxLName.Text = StudentInfoDataGridView.Rows(i).Cells(2).Value.ToString
                    txtBoxYr.Text = StudentInfoDataGridView.Rows(i).Cells(6).Value.ToString
                    txtBoxAmnt.Text = String.Format("{0:c}", StudentInfoDataGridView.Rows(i).Cells(7).Value).ToString
                    If StudentInfoDataGridView.Rows(i).Cells(8).Value.ToString = "Yes" Then
                        cmboActive.SelectedIndex = 0
                    Else
                        cmboActive.SelectedIndex = 1
                    End If
                    If StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "9" Then
                        cmboGrade.SelectedIndex = 0
                    ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "10" Then
                        cmboGrade.SelectedIndex = 1
                    ElseIf StudentInfoDataGridView.Rows(i).Cells(9).Value.ToString = "11" Then
                        cmboGrade.SelectedIndex = 2
                    Else
                        cmboGrade.SelectedIndex = 3
                    End If
                    StudentInfoDataGridView.CurrentCell = StudentInfoDataGridView.Rows(i).Cells(1)
                    Exit For
                End If
            Next

            If boolMemberFound = False Then   'Checking to see if the memeber was found
                If (memberNotFound(txtBoxEmail) = False) Then 'If the memberNotFound function returns a false then the current sub will exit
                    Exit Sub
                End If
            End If

        End If

    End Sub


#End Region

    'All of the functions and algorithms
#Region "Algorithms and functions"
    'Method that will ask the user if they would like to add the member
    Function memberNotFound(ByVal memberTxtBox As TextBox) As Boolean
        Dim result As DialogResult = MessageBox.Show("Would you like to add him/her?", "Student not found", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then 'If the select decides to enter the new user then a sumbit button will be displayed
            'Clearing all of the textboxes except for the one with inputed data
            txtBoxFName.Text = ""
            txtBoxLName.Text = ""
            txtBoxSchool.Text = ""
            cmboState.SelectedIndex = 0
            txtBoxEmail.Text = ""
            txtBoxYr.Text = ""
            txtBoxAmnt.Text = ""
            cmboActive.SelectedIndex = 0
            cmboGrade.SelectedIndex = 0
            btnSearch.Visible = False
            btnAdd.Visible = True
            txtBoxSchool.ReadOnly = False
            cmboState.Enabled = True
            txtBoxYr.ReadOnly = False
            txtBoxAmnt.ReadOnly = False
            cmboActive.Enabled = True
            cmboGrade.Enabled = True
            StudentInfoDataGridView.ReadOnly = True
        Else
            Select Case memberTxtBox.Name
                Case "txtBoxNum"
                    txtBoxNum.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentCell.RowIndex).Cells(0).Value
                Case "txtBoxFName"
                    txtBoxFName.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentCell.RowIndex).Cells(1).Value
                Case "txtBoxLName"
                    txtBoxLName.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentCell.RowIndex).Cells(2).Value
                Case "txtBoxEmail"
                    txtBoxEmail.Text = StudentInfoDataGridView.Rows(StudentInfoDataGridView.CurrentCell.RowIndex).Cells(5).Value
            End Select
            Return False
        End If
        Return True
    End Function

    'Both methods for substringing
#Region "Substring Methods"

    'Function to take the first letter of the word from the text box that was passed through and properly format it
    Public Sub subTheString(ByVal sender As TextBox)
        Dim temp As String
        Dim first
        temp = sender.Text.Trim
        first = temp.Substring(0, 1)
        first = Char.ToUpper(first)
        temp = temp.Remove(0, 1)
        temp = temp.Insert(0, first)
        sender.Text = temp
        temp = Nothing
        first = Nothing
    End Sub

    'Function to substring the first character of a cell
    Public Function subTheCell(ByRef sender As String)
        Dim temp As String
        Dim first
        temp = sender.Trim.ToLower
        first = temp.Substring(0, 1)
        first = Char.ToUpper(first)
        temp = temp.Remove(0, 1)
        temp = temp.Insert(0, first)
        Return temp
    End Function

#End Region

    'Function to check if the inputed string contains only alpha characters
    Function CheckForAlphaCharacters(ByVal StringToCheck As String)

        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next

        Return False

    End Function

    'Function to check whether or not the user entered a 
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If

    End Function

    'Method to gather the input from the database and instanstiate objects for each student for later uses
    Public Sub gatherInput()
        Dim studentCount = StudentInfoDataGridView.RowCount 'Variable to hold the amount of members based on the rows present in the database
        Dim listOfStu As New List(Of studentClass)          'List to hold each student for later use

        'Declaring variables that will tempoaraily hold the data from each cell
        Dim intVal0 As Integer = 0
        Dim stringVal1 As String = ""
        Dim stringVal2 As String = ""
        Dim stringVal3 As String = ""
        Dim stringVal4 As String = ""
        Dim stringVal5 As String = ""
        Dim shortVal9 As Short = 0
        Dim intVal6 As Integer = 0
        Dim doubleVal7 As Double = 0
        Dim stringVal8 As String = ""

        'Nested loops to read through the entire database and seperate the cells into their individual variables
        For i As Integer = 0 To StudentInfoDataGridView.RowCount - 1
            For j As Integer = 0 To StudentInfoDataGridView.ColumnCount - 1
                Select Case j
                    Case 0
                        intVal0 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 1
                        stringVal1 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 2
                        stringVal2 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 3
                        stringVal3 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 4
                        stringVal4 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 5
                        stringVal5 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 6
                        intVal6 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 7
                        doubleVal7 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 8
                        stringVal8 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 9
                        shortVal9 = StudentInfoDataGridView.Rows(i).Cells(j).Value
                End Select
            Next

            statusLbl.Text = "Collecting member " + (i + 1).ToString + " out of " + studentCount.ToString   'Changing text of the window footer
            listOfStu.Add(New studentClass(intVal0, stringVal1, stringVal2, stringVal3, stringVal4, stringVal5, intVal6, doubleVal7, stringVal8, shortVal9))     'Creating a new instance of the student class based on the given data and storing that student into a list for later use
        Next
        statusLbl.Text = StudentInfoDataGridView.RowCount.ToString + " Total Members"
        listMemebers = listOfStu
        'Creating sources to auto complete the text boxes found at the bottom of the form
        Static numberSource As New AutoCompleteStringCollection()
        Static fNameSource As New AutoCompleteStringCollection()
        Static lNameSource As New AutoCompleteStringCollection()
        Static schoolSource As New AutoCompleteStringCollection()
        Static emailSource As New AutoCompleteStringCollection()

        'Adding values to the sources from the data of each student in the list of members
        For Each student In listOfStu
            numberSource.Add(student.number)
            fNameSource.Add(student.firstName)
            lNameSource.Add(student.lastName)
            schoolSource.Add(student.school)
            stateSource.Add(student.st)
            emailSource.Add(student.mail)
        Next

        'Changing the properties of the autocomplete sources 
        'All of these text boxes have autocomplete sources because they are unique values
        With txtBoxEmail    'Changing properties for the email text box
            .AutoCompleteCustomSource = emailSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        With txtBoxFName    'Changing properties for the first name text box
            .AutoCompleteCustomSource = fNameSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        With txtBoxLName    'Changing properties for the last name text box
            .AutoCompleteCustomSource = lNameSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        With txtBoxNum      'Changing properties for the number text box
            .AutoCompleteCustomSource = numberSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        With txtBoxSchool   'Changing properties for the school text box
            .AutoCompleteCustomSource = schoolSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
    End Sub

#End Region

    'Events that occur when F1 or the help button are pressed
    'Events will open the corresponding help document based on the current form
#Region "Hellp Needed"

    Private Sub getHelp()   'Function that will open the help pdf
        Help.Visible = True
        Dim path As String = My.Application.Info.DirectoryPath  'Finding the path of the application
        Dim pdfFile As String = IO.Path.Combine(path, "MainHelp.pdf")   'Setting the path of the help pdf equal to the variable pdfFile
        Help.WebBrowser1.Url = New Uri("file://" + pdfFile) 'Opening an instance of the Help form with the url set as the path for the help pdf
    End Sub

    Private Sub HelpToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripButton.Click 'Handles the help button press on the binding navigator
        getHelp()   'Calling the getHelp method
    End Sub

    Private Sub mainForm_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, StudentInfoDataGridView.KeyDown   'Handles a key press
        If e.KeyCode = Keys.F1 Then 'If the keypress is "F1" then the getHelp method will be called
            getHelp()
        End If
    End Sub

    Private Sub StudentInfoDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles StudentInfoDataGridView.DataError
        If e.ColumnIndex = 0 Then
            MsgBox("Number is too large! Please re-enter")
        End If
    End Sub
#End Region

End Class

'Maintinence Log*******************************************************************
'October 2015:  Project started
'November 2015: Database created with demo memebers
'December 2015: Printing  and exporting to an excel file finished, class for student added
'January 2016:  Textboxes added to help aide with user input, searchability created, class for states added
'February 2016: Polish before publishing, search methods optimized, splash screen added, help window added when user presses 'F1' or the help button on the menu strip
'April 2016:    Adding more comments and refining 
'May 2016:      Added more comments and added color to the reports so it is easier to distingish lines, took some repeated lines of code and put them into a function