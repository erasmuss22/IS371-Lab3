Public Class Employee

    Private Sub Employee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PubsDataSet.employee' table. You can move, or remove it, as needed.
        Try
            Me.EmployeeTableAdapter.Fill(Me.PubsDataSet.employee)
        Catch ex As System.Data.DBConcurrencyException
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        Try
            Me.EmployeeTableAdapter.Fill(Me.PubsDataSet.employee)
        Catch ex As System.Data.DBConcurrencyException
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
        End Try
        SearchToolStripTextBox.Clear()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.EmployeeTableAdapter.FillBySearch(Me.PubsDataSet.employee, SearchToolStripTextBox.Text)
        Catch ex As System.Data.DBConcurrencyException
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
        Catch ex As NullReferenceException
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
        End Try
    End Sub
End Class