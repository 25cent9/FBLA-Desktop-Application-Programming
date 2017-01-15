
'Programmer: Innocent Niyibizi
'Date: 11-15-15
'Purpose: Create a program that will be able to print reports of the selected group of FBLA members. Each report must be able to export to an excel file

Imports System.Drawing.Printing
Imports Excel = Microsoft.Office.Interop.Excel

Public Class reportForm

    'Creating lists for each state that will be used for members owing a balance
    Dim listOfStates As New List(Of State)

    'Event that occurs when the form is loaded
    Private Sub printing_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Static list As New List(Of studentClass)
        Static total As Double = 0
        Dim States As List(Of State) = New List(Of State)
        list = gatherInput()    'Instantiating objects from the databasae
        If mainForm.getGrade = 13 Then
            CreateStates(list, States)
        End If

        'Placing the members onto the report based on the menu strip clicked
        If mainForm.getGrade = 12 Then  'Checking to see if the grade is 12
            Me.Text += " Seniors"
            Me.printingGrid.ColumnCount = 4
            Me.printingGrid.Columns(0).Name = "First Name"
            Me.printingGrid.Columns(1).Name = "Last Name"
            Me.printingGrid.Columns(2).Name = "State"
            Me.printingGrid.Columns(3).Name = "Email"
            printingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            placeStudents(list, 12, total)
            printingGrid.Sort(printingGrid.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        ElseIf mainForm.getGrade = 11 Then  'Checking to see if the grade is 11
            Me.Text += " Juniors"
            Me.printingGrid.ColumnCount = 4
            Me.printingGrid.Columns(0).Name = "First Name"
            Me.printingGrid.Columns(1).Name = "Last Name"
            Me.printingGrid.Columns(2).Name = "State"
            Me.printingGrid.Columns(3).Name = "Email"
            printingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            placeStudents(list, 11, total)
            printingGrid.Sort(printingGrid.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        ElseIf mainForm.getGrade = 10 Then  'Checking to see if the grade is 10
            Me.Text += " Sophomores"
            Me.printingGrid.ColumnCount = 4
            Me.printingGrid.Columns(0).Name = "First Name"
            Me.printingGrid.Columns(1).Name = "Last Name"
            Me.printingGrid.Columns(2).Name = "State"
            Me.printingGrid.Columns(3).Name = "Email"
            printingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            placeStudents(list, 10, total)
            printingGrid.Sort(printingGrid.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        ElseIf mainForm.getGrade = 9 Then   'Checking to see if the grade is 9
            Me.Text += " Freshmen"
            Me.printingGrid.ColumnCount = 4
            Me.printingGrid.Columns(0).Name = "First Name"
            Me.printingGrid.Columns(1).Name = "Last Name"
            Me.printingGrid.Columns(2).Name = "State"
            Me.printingGrid.Columns(3).Name = "Email"
            printingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            placeStudents(list, 9, total)
            printingGrid.Sort(printingGrid.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        ElseIf mainForm.getGrade = 13 Then  'Checking to see if the grade is 13
            Me.printingGrid.ColumnCount = 7
            Me.printingGrid.Columns(0).Name = "Number"
            Me.printingGrid.Columns(0).ValueType = Type.GetType("System.Integer")
            Me.printingGrid.Columns(1).Name = "First Name"
            Me.printingGrid.Columns(2).Name = "Last Name"
            Me.printingGrid.Columns(3).Name = "Year Joined"
            Me.printingGrid.Columns(3).ValueType = Type.GetType("System.Integer")
            Me.printingGrid.Columns(4).Name = "Grade Level"
            Me.printingGrid.Columns(5).Name = "Amount Owed"
            Me.printingGrid.Columns(5).ValueType = Type.GetType("System.Double")
            Me.printingGrid.Columns(5).DefaultCellStyle.Format = "$0.00"
            With Me.printingGrid.Columns(6) 'Changing properties of the state column
                .Name = "State"
                .Visible = True
            End With
            printingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            placeStudents(list, 13, total)  'Calling the place student function
            Me.printingGrid.Sort(printingGrid.Columns(6), System.ComponentModel.ListSortDirection.Ascending)
            listOfStates = States
            'printingGrid.Sort(printingGrid.Columns(5), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub

    'All of the events that pretain to printing
#Region "Print Actions"

    'Event that starts once the print menu strip button is pressed
    'Sets the default values for the printer such as the margins
    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDia.PrinterSettings = PrintDoc.PrinterSettings

        'Creating default printer setting when OK is clicked from the print dialog
        If PrintDia.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDoc.PrinterSettings = PrintDia.PrinterSettings
            Dim ps As New PaperSize("A4", 850, 1100)
            ps.PaperName = PaperKind.A4

            Dim pageSetup As New PageSettings
            'Creating margins for the page
            With pageSetup
                .PaperSize = ps
                .Margins.Left = 40
                .Margins.Right = 55
                .Margins.Bottom = 35
                .Margins.Top = 35
                .Landscape = False
            End With
            PrintDoc.DefaultPageSettings = pageSetup
        Else
            'Exiting the sub whenn the user decides not to print the report
            Exit Sub
        End If
        PrintPreview.Document = PrintDoc
        PrintPreview.ShowDialog()
    End Sub

    'Event that starts once the print function of the form is selected
    'This event will read the report and print each member onto a line and will create a new page once the line count reaches 50
    Private Sub PrintDoc_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        'Changing the sort of the report to list by state if the report is for all memebers owing a balance
        If mainForm.getGrade > 13 Then
            Me.printingGrid.Sort(printingGrid.Columns(6), System.ComponentModel.ListSortDirection.Ascending)
        End If

        Dim usedStates As New List(Of String)                                           'Creating a list that will hold all of the states that are already used in the program
        Dim GDate As String = Today
        Dim reportFont As Font = New Drawing.Font("Courier New", 12)                    'Creating font for the report 
        Dim headerFont As Font = New Drawing.Font("Courier New", 13, FontStyle.Bold)    'Creating font for the header
        Dim lineSpaceFont As Font = New Drawing.Font("Courier New", 13.2)
        Static intStart As Integer                                                      'Integer that indicates which row of the grid to begin printing
        Dim fntHeight As Integer = lineSpaceFont.Height                                 'Integer value of the header font
        Dim fntWidth As Integer = reportFont.Size
        Dim txtHeight As Integer
        Dim lftMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Left
        Dim rghtMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Right
        Dim topMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Top
        txtHeight = PrintDoc.DefaultPageSettings.PaperSize.Height - PrintDoc.DefaultPageSettings.Margins.Top - PrintDoc.DefaultPageSettings.Margins.Bottom  'Setting the text height for the report
        Static pageNumber As Byte = 0


        'e.Graphics.DrawRectangle(Pens.Red, e.MarginBounds)
        Dim intLineNumber As Integer
        For intCounter = intStart To printingGrid.RowCount - 1  'Creating loop to run until the counter is equal to the amount of students for the given grade level
            'The follwing block of code will execute when the grade selected it less than or equal to 12
            If mainForm.getGrade <= 12 Then
                'Printing the header when the line number is 0
                If intLineNumber = 0 Then
                    'Changing the header text based on the grade level selected 
                    If mainForm.getGrade = 12 Then
                        e.Graphics.DrawString(GDate, reportFont, Brushes.Black, lftMargin, fntHeight * intLineNumber + topMargin)
                        e.Graphics.DrawString("FBLA - Seniors", headerFont, Brushes.Black, e.MarginBounds.Width / 2.5, fntHeight * intLineNumber + topMargin)
                        e.Graphics.DrawString("Page " & pageNumber + 1.ToString, reportFont, Brushes.Black, rghtMargin * 13, fntHeight * intLineNumber + topMargin)
                        intLineNumber += 1
                    ElseIf mainForm.getGrade = 11 Then
                        e.Graphics.DrawString(GDate, reportFont, Brushes.Black, lftMargin, fntHeight * intLineNumber + topMargin)
                        e.Graphics.DrawString("FBLA - Juniors", headerFont, Brushes.Black, e.MarginBounds.Width / 2.5, fntHeight * intLineNumber + topMargin)
                        e.Graphics.DrawString("Page " & pageNumber + 1.ToString, reportFont, Brushes.Black, rghtMargin * 13, fntHeight * intLineNumber + topMargin)
                        intLineNumber += 1
                    ElseIf mainForm.getGrade = 10 Then
                        e.Graphics.DrawString(GDate, reportFont, Brushes.Black, lftMargin, fntHeight * intLineNumber + topMargin)
                        e.Graphics.DrawString("FBLA - Sophomores", headerFont, Brushes.Black, e.MarginBounds.Width / 2.5, fntHeight * intLineNumber + topMargin)
                        e.Graphics.DrawString("Page " & pageNumber + 1.ToString, reportFont, Brushes.Black, rghtMargin * 13, fntHeight * intLineNumber + topMargin)
                        intLineNumber += 1
                    ElseIf mainForm.getGrade = 9 Then
                        e.Graphics.DrawString(GDate, reportFont, Brushes.Black, lftMargin, fntHeight * intLineNumber + topMargin)
                        e.Graphics.DrawString("FBLA - Freshmen", headerFont, Brushes.Black, e.MarginBounds.Width / 2.5, fntHeight * intLineNumber + topMargin)
                        e.Graphics.DrawString("Page " & pageNumber + 1.ToString, reportFont, Brushes.Black, rghtMargin * 13, fntHeight * intLineNumber + topMargin)
                        intLineNumber += 1
                    End If
                    e.Graphics.DrawString("Name:".PadRight(23) + "State:".PadRight(12) + "Email Address:", headerFont, Brushes.Black, lftMargin, reportFont.Height * (intLineNumber + 0.2) + topMargin)
                    intLineNumber += 1
                End If

                Dim j As Byte = 0

                'Creating a list of strings that will hold the necessary values from the current row 
                Dim strings As New List(Of String)
                strings.Clear()
                strings.Add(printingGrid.Rows(intCounter).Cells(j).Value.ToString + " " + printingGrid.Rows(intCounter).Cells(j + 1).Value.ToString)
                strings.Add(printingGrid.Rows(intCounter).Cells(j + 2).Value.ToString)
                strings.Add(printingGrid.Rows(intCounter).Cells(j + 3).Value.ToString)

                'Printing the information about the member 
                If (intLineNumber Mod 2) = 0 Then
                    e.Graphics.FillRectangle(Brushes.LightGray, lftMargin, 20 * intLineNumber + topMargin, e.MarginBounds.Right, 20)
                End If
                e.Graphics.DrawString(strings(j).PadRight(25) + strings(j + 1).PadRight(13) + strings(j + 2), reportFont, Brushes.Black, lftMargin, 20 * intLineNumber + topMargin)
                intLineNumber += 1


                'Creating a new page when the number of details on page is 50 
                If intLineNumber = 50 Then
                    intStart = intCounter + 1   'Having the start variable be equal to one plus the value of the counter variable
                    e.HasMorePages = True       'Changing the value of has more pages to true
                    pageNumber += 1             'Incrementing the page number

                    Exit For
                Else
                    e.HasMorePages = False
                End If

                'The follwing block of code will execute when the grade is greater than 12 meaning all memebers owing a balance
            ElseIf mainForm.getGrade > 12 Then

                'Checking to see if the list of used states has a count greater than 0
                'If the count is greater than 0 then the list will remove any duplicates
                If usedStates.Count > 0 Then
                    usedStates = usedStates.Distinct.ToList
                End If

                Dim j As Integer = 0
                Dim check As Byte = 0

                'Creating a list of strings that will hold the information for the current memeber printing purposes
                Dim strings As New List(Of String)
                strings.Clear()

                'Adding values from the report datagridview to the strings list
                strings.Add(printingGrid.Rows(intCounter).Cells(j).Value.ToString)
                strings.Add(printingGrid.Rows(intCounter).Cells(j + 1).Value.ToString + " " + printingGrid.Rows(intCounter).Cells(j + 2).Value.ToString)
                strings.Add(printingGrid.Rows(intCounter).Cells(j + 3).Value.ToString)
                strings.Add(printingGrid.Rows(intCounter).Cells(j + 4).Value.ToString)
                strings.Add(String.Format("{0:c2}", printingGrid.Rows(intCounter).Cells(j + 5).Value))

                If intLineNumber = 0 Then   'Checking if line number is 0, if it is then the following block will occur

                    e.Graphics.DrawString(GDate, reportFont, Brushes.Black, lftMargin, fntHeight * intLineNumber + topMargin)   'Printing the date
                    e.Graphics.DrawString("FBLA - " + printingGrid.Rows(intCounter).Cells(6).Value.ToString, headerFont, Brushes.Black, e.MarginBounds.Width / 2, fntHeight * intLineNumber + topMargin)    'Printing the report title
                    e.Graphics.DrawString("Page " & pageNumber + 1.ToString, reportFont, Brushes.Black, rghtMargin * 13, fntHeight * intLineNumber + topMargin) 'Printing page number
                    intLineNumber += 1  'Incrementing line number
                    e.Graphics.DrawString("Number:".PadRight(14) + "Name:".PadRight(23) + "Year:".PadRight(10) + "Grade:".PadRight(8) + "Amount:", headerFont, Brushes.Black, lftMargin, reportFont.Height * (intLineNumber + 0.2) + topMargin) 'Printing the column headers
                    intLineNumber += 1

                    'Incrememnting thorugh the list of states until the state is the same as the current state for the report
                    'Once a match is found then the report will print the footer for that state
                    For Each st In listOfStates
                        If st.StateName = printingGrid.Rows(intCounter).Cells(6).Value.ToString Then
                            e.Graphics.DrawString("Non-Active: " + st.NonActive.ToString + " Active: " + st.Active.ToString + " Member Owing: " + st.StudentsOwing.ToString + " Total Owed: " + String.Format("{0:c2}", st.TotalAmnt), reportFont, Brushes.Black, lftMargin, e.MarginBounds.Bottom - topMargin + 18)
                            Exit For
                        End If
                    Next

                End If

                'Prrinting the member's information to the report and then incrememnting the line number
                If (intLineNumber Mod 2) = 0 Then
                    e.Graphics.FillRectangle(Brushes.LightGray, lftMargin, 20 * intLineNumber + topMargin, e.MarginBounds.Right, 20)
                End If
                e.Graphics.DrawString(strings(j).PadRight(15) + strings(j + 1).PadRight(25) + strings(j + 2).PadRight(11) + strings(j + 3).PadRight(9) + strings(j + 4), reportFont, Brushes.Black, lftMargin, 20 * intLineNumber + topMargin)
                intLineNumber += 1

                'Adding the current state to the list of used states
                usedStates.Add(printingGrid.Rows(intCounter).Cells(6).Value.ToString)

                'Checking to see if the next state is not at the end of the report
                If intCounter + 1 < printingGrid.RowCount - 1 Then
                    check = intCounter + 1
                Else
                    check = 0
                End If

                'Creating a new page when the number of lines on the page is 50 or if all of the members from current state are already on the page
                If intLineNumber = 50 Or intCounter < printingGrid.RowCount - 1 And CheckIfNewState(printingGrid.Rows(check).Cells(6).Value.ToString, usedStates) = True Then

                    intStart = intCounter + 1
                    e.HasMorePages = True
                    pageNumber += 1
                    Exit For
                Else
                    e.HasMorePages = False
                End If

            End If
        Next

        'Check to see if there are anymore pages
        'If there are no more pages then everything will be reset in order to prepare for the the printer to print the pages
        If e.HasMorePages = False Then
            intStart = 0
            pageNumber = 0
        End If

    End Sub

#End Region

    'Function to export the report to an excel file and place it onto the desktop of the current 
    Private Sub XlsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles XlsToolStripMenuItem.Click

        MsgBox("Transfering members to Excel file")

        'Creating instance of Excel
        Dim xlApp As New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i As Int16, j As Int16

        'Creating instances of the needed excel modules
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")

        'Loop to run through each cell of the report and place the value of the cell into the corresponding location of the excel file
        For i = 0 To Me.printingGrid.RowCount - 1
            For j = 0 To Me.printingGrid.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = Me.printingGrid(j, i).Value.ToString()
            Next
        Next

        Select Case mainForm.getGrade   'Case statement to create the apporiate name for the excel file based on the grade
            Case 12 'Case for 12 grade level
                Dim filepath As String = "C:\Users\" & GetUserName() & "\Desktop\SeniorReport.xls"

                If System.IO.File.Exists(filepath) Then 'Checking to see if the excel exist. If so, the old file will be deleted and the new one will be place instead
                    System.IO.File.Delete(filepath)
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                Else
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                End If
                filepath = Nothing

            Case 11 'Case for 11 grade level
                Dim filepath As String = "C:\Users\" & GetUserName() & "\Desktop\JuniorReport.xls"

                If System.IO.File.Exists(filepath) Then
                    System.IO.File.Delete(filepath)
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                Else
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                End If
                filepath = Nothing

            Case 10 'Case for 10 grade level
                Dim filepath As String = "C:\Users\" & GetUserName() & "\Desktop\SophomoreReport.xls"

                If System.IO.File.Exists(filepath) Then
                    System.IO.File.Delete(filepath)
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                Else
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                End If
                filepath = Nothing

            Case 9  'Case for 9 grade level
                Dim filepath As String = "C:\Users\" & GetUserName() & "\Desktop\FreshmanReport.xls"

                If System.IO.File.Exists(filepath) Then
                    System.IO.File.Delete(filepath)
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                Else
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                End If
                filepath = Nothing

            Case 13 'Case for members owing a balance
                Dim filepath As String = "C:\Users\" & GetUserName() & "\Desktop\AllMembersOwingBalanceReport.xls"

                If System.IO.File.Exists(filepath) Then
                    System.IO.File.Delete(filepath)
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                Else
                    xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                End If
                filepath = Nothing
        End Select

        'Closing instance of Excel to reduce system resources
        'Relasing each object and then collecting the garbage
        xlApp.Quit()
        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)
        MsgBox("Excel file saved to desktop")

    End Sub

    'All the algortihms for the current form
#Region "Algorithms"
    'Method to gather input
    'Method will take values from datagridview and create an instance of the Student class for each row
    'Each instance of the student class will then be added to a list with the type of student class
    Public Function gatherInput()

        Dim listOfStu As New List(Of studentClass)  'Creating a new instance of a list and giving it the type of studentClass
        'Declaring all of the variables that will be used for the collection of the datagrudview data
        Dim val0 As Integer = 0
        Dim val1 As String = ""
        Dim val2 As String = ""
        Dim val3 As String = ""
        Dim val4 As String = ""
        Dim val5 As String = ""
        Dim val9 As Short = 0
        Dim val6 As Integer = 0
        Dim val7 As Double = 0
        Dim val8 As String = ""

        For i As Integer = 0 To mainForm.StudentInfoDataGridView.RowCount - 1   'Loop to itterate through all of the rows of the datagridview
            For j As Integer = 0 To mainForm.StudentInfoDataGridView.ColumnCount - 1    'Loop to itterate through all of the columns of the datagridview
                Select Case j   'Switch to chek which column is detected
                    'Each case will place the value of the current cell in to the appropriate variable
                    Case 0  'Case for first column
                        val0 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 1  'Case for second column
                        val1 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 2  'Case for third column
                        val2 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 3  'Case for fourth column
                        val3 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 4  'Case for fifth column
                        val4 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 5  'Case for sixth column
                        val5 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 6  'Case for seventh column
                        val6 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 7  'Case for eighth column
                        val7 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 8  'Case for ninth column
                        val8 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                    Case 9  'Case for tenth column
                        val9 = mainForm.StudentInfoDataGridView.Rows(i).Cells(j).Value
                End Select
            Next
            listOfStu.Add(New studentClass(val0, val1, val2, val3, val4, val5, val6, val7, val8, val9)) 'Creating a new isntance of the student class with the obtained values from the datatable and adding that instance of the student class to the list of students
        Next
        Return listOfStu    'Returning the list of students
    End Function

    'Function to place members onto the report
    Private Sub placeStudents(ByVal list As List(Of studentClass), num As Short, ByRef tot As Double)

        Dim i As Integer = 0  'Variable i to be used as a counter for the rows

        'Checkig the list of members and placing the correct information into the correct column based on the number passed through
        For Each member In list
            If num < 13 Then
                If member.gradeLvl = num Then
                    Me.printingGrid.Rows.Add()
                    Me.printingGrid.Rows(i).Cells(0).Value = member.firstName
                    Me.printingGrid.Rows(i).Cells(1).Value = member.lastName
                    Me.printingGrid.Rows(i).Cells(2).Value = member.st
                    Me.printingGrid.Rows(i).Cells(3).Value = member.mail
                    i += 1
                End If
            ElseIf num = 13 Then
                If member.amount > 0 Then
                    Me.printingGrid.Rows.Add()
                    Me.printingGrid.Rows(i).Cells(0).Value = member.number
                    Me.printingGrid.Rows(i).Cells(1).Value = member.firstName
                    Me.printingGrid.Rows(i).Cells(2).Value = member.lastName
                    Me.printingGrid.Rows(i).Cells(3).Value = member.yrJ
                    Me.printingGrid.Rows(i).Cells(4).Value = member.gradeLvl
                    Me.printingGrid.Rows(i).Cells(5).Value = member.amount
                    Me.printingGrid.Rows(i).Cells(6).Value = member.st
                    tot += member.amount
                    i += 1
                End If
            End If
        Next

        'Changing the status bar text to match the apporiate grade level and amount of members from that grade level
        If num = 12 Then
            statusBarPrint.Text = (i).ToString + " seniors"
        ElseIf num = 11 Then
            statusBarPrint.Text = (i).ToString + " juniors"
        ElseIf num = 10 Then
            statusBarPrint.Text = (i).ToString + " sophomores"
        ElseIf num = 9 Then
            statusBarPrint.Text = (i).ToString + " freshmen"
        ElseIf num = 13 Then
            statusBarPrint.Text = (i).ToString + " members owing a balance." + vbTab + "Total Amount Owed: " + String.Format("{0:c2}", tot)
        End If

    End Sub

    'Function to set the object passed through equal to nothing 
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    'Function to get and return the username of the current account being used
    Function GetUserName() As String
        If TypeOf My.User.CurrentPrincipal Is
          Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function

    'Algorithms related to states
#Region "State Algorithms"

    Private Sub CreateStates(ByRef studs As List(Of studentClass), ByVal states As List(Of State))

        'Loop that will run through all of the memeber to check if they have a balance or not
        'If member has a balance then will be added to the state
        'If state does not exist then new state will be created
        For Each member In studs
            Dim found As Boolean = False
            If member.amount > 0 Then
                If states.Count > 0 Then
                    For i As Integer = 0 To states.Count - 1
                        If member.st = states(i).StateName Then
                            found = True
                            states(i).Students.Add(member)
                        End If
                    Next
                    If found = False Then
                        states.Add(New State(member.st))
                        states(states.Count - 1).Students.Add(member)
                    End If
                Else
                    states.Add(New State(member.st))
                End If
            End If
        Next

        'Itterating through each state that has at least one member that owes money
        'If current member is active then the data member for active will have one added ot it
        'If not then non-active will be added a value of one
        'Adding the amounts of all students to find the total amount for that state
        For Each st In states
            For Each member In st.Students
                If member.activ = "Yes" Then
                    st.Active += 1
                Else
                    st.NonActive += 1
                End If
                st.TotalAmnt += member.amount
                st.StudentsOwing = st.Students.Count
            Next
        Next

        'Sorting the list of the staes based on the names so that they are in alphabetical order
        states.Sort(Function(x, y) x.StateName.CompareTo(y.StateName))

    End Sub

    'Function to check if there is going to be a new state in that is associated with the next set of member
    'Returns true if there is a new state and false if there is not a new state
    Function CheckIfNewState(ByRef s, ByRef UsedStates) As Boolean
        If UsedStates.Contains(s) Then
            Return False
        Else
            Return True
        End If
    End Function


#End Region


#End Region

End Class
