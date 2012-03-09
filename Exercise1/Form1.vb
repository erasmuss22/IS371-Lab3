Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.NorthwindDataSet.Order_Details)
        'TODO: This line of code loads data into the 'NorthwindDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.NorthwindDataSet.Orders)
    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        Try
            Me.Validate()
            Me.OrdersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)
        Catch ex As DBConcurrencyException

        End Try
    End Sub
End Class