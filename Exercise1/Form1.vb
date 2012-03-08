Public Class Form1

    Private Sub Order_DetailsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Order_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.NorthwindDataSet.Orders)
        'TODO: This line of code loads data into the 'NorthwindDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.NorthwindDataSet.Order_Details)

    End Sub
End Class
