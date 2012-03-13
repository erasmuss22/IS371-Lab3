' Erin Rasmussen
' Lab 3
Public Class Titles
    ' I built queries for each thing in the Lab specification which filter on the app's load
    Private Sub Titles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PubsDataSet.authors' table. You can move, or remove it, as needed.
        Try
            Me.AuthorsTableAdapter.FillByStateContract(Me.PubsDataSet.authors)
            'TODO: This line of code loads data into the 'PubsDataSet.sales' table. You can move, or remove it, as needed.
            Me.SalesTableAdapter.FillBySoldTerm(Me.PubsDataSet.sales)
            'TODO: This line of code loads data into the 'PubsDataSet.titles' table. You can move, or remove it, as needed.
            Me.TitlesTableAdapter.FillByDateType(Me.PubsDataSet.titles)
        Catch ex As System.Data.DBConcurrencyException
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
        End Try
        Dim emp As New Employee
        emp.Show()
    End Sub
End Class
