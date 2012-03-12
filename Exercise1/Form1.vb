Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'NorthwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            Me.Order_DetailsTableAdapter.Fill(Me.NorthwindDataSet.Order_Details)
            'TODO: This line of code loads data into the 'NorthwindDataSet.Orders' table. You can move, or remove it, as needed.
            Me.OrdersTableAdapter.Fill(Me.NorthwindDataSet.Orders)
        Catch ex As System.Data.DBConcurrencyException
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        Dim problems = False
        If Not IsDate(OrderDateTextBox.Text) Or Not IsDate(RequiredDateTextBox.Text) Or Not IsDate(ShippedDateTextBox.Text) Then
            problems = True
        End If
        'Currently validating all input texts to see if "" If 
        Try
            Me.Validate()
            Me.OrdersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)
        Catch ex As System.Data.DBConcurrencyException
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
        End Try
    End Sub

    Private Sub ShipPostalCodeTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ShipPostalCodeTextBox.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub
End Class