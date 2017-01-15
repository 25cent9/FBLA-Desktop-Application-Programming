Public Class progress

    Private Sub StudentInfoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StudentInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_InformationDataSet)

    End Sub

    Private Sub entryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_InformationDataSet.StudentInfo' table. You can move, or remove it, as needed.
        Me.StudentInfoTableAdapter.Fill(Me.Student_InformationDataSet.StudentInfo)

    End Sub
End Class