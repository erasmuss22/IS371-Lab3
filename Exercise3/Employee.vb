Public Class Employee

    Private Sub Employee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PubsDataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.PubsDataSet.employee)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        Me.EmployeeTableAdapter.Fill(Me.PubsDataSet.employee)
        SearchToolStripTextBox.Clear()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.EmployeeTableAdapter.FillBySearch(Me.PubsDataSet.employee, SearchToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class