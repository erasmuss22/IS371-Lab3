' Erin Rasmussen
' Lab 3
Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.NorthwindDataSet.Employees)
        'TODO: This line of code loads data into the 'NorthwindDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.NorthwindDataSet.Customers)
        'TODO: This line of code loads data into the 'NorthwindDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.NorthwindDataSet.Customers)
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
        Try
            If Not IsDate(OrderDateTextBox.Text) Or Not IsDate(RequiredDateTextBox.Text) Or Not IsDate(ShippedDateTextBox.Text) Then
                problems = True
            End If
        Catch ex As ArgumentException
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
        End Try
        If ShipViaTextBox.Text = "" Or FreightTextBox.Text = "" Or ShipNameTextBox.Text = "" Or ShipAddressTextBox.Text = "" Then
            problems = True
        End If
        If ShipCityTextBox.Text = "" Or ShipCountryTextBox.Text = "" Or ShipRegionTextBox.Text = "" Or ShipCountryTextBox.Text = "" Then
            problems = True
        End If
        Try
            If Not IsNumeric(Val(ShipPostalCodeTextBox.Text)) Then
                problems = True
            End If
        Catch ex As ArgumentException
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
        End Try
        If problems = False Then
            WarningLabel.Visible = False
            Try
                Me.Validate()
                Me.OrdersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)
            Catch ex As System.Data.DBConcurrencyException
                My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in ExceptionLogTest " & "with argument " & ex.ToString & ".")
            End Try
        Else
            WarningLabel.Visible = True
        End If

    End Sub

    ' allow only numbers in the text box
    Private Sub ShipPostalCodeTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ShipPostalCodeTextBox.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    ' allow the user to view all customer IDs
    Private Sub CustomerSearch_Click(sender As System.Object, e As System.EventArgs) Handles CustomerSearch.Click
        Order_DetailsDataGridView.Visible = False
        CustCombo.Visible = True
        CustCombo.SelectedIndex = -1
        OrderIDComboBox.Enabled = False
        OrderDateTextBox.Enabled = False
        RequiredDateTextBox.Enabled = False
        CustomerSearch.Enabled = False
        EmployeeSearch.Enabled = False
        ShippedDateTextBox.Enabled = False
        ShipViaTextBox.Enabled = False
        FreightTextBox.Enabled = False
        ShipNameTextBox.Enabled = False
        ShipAddressTextBox.Enabled = False
        ShipCityTextBox.Enabled = False
        ShipRegionTextBox.Enabled = False
        ShipPostalCodeTextBox.Enabled = False
        ShipCountryTextBox.Enabled = False
        SaveButton.Enabled = False
    End Sub

    ' fill customer text box with selected ID
    Private Sub CustCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CustCombo.SelectedIndexChanged
        If CustCombo.SelectedIndex <> -1 Then
            CustomerIDTextBox.Text = CustCombo.SelectedValue
            CustCombo.Visible = False
            Order_DetailsDataGridView.Visible = True
            OrderIDComboBox.Enabled = True
            OrderDateTextBox.Enabled = True
            RequiredDateTextBox.Enabled = True
            CustomerSearch.Enabled = True
            EmployeeSearch.Enabled = True
            ShippedDateTextBox.Enabled = True
            ShipViaTextBox.Enabled = True
            FreightTextBox.Enabled = True
            ShipNameTextBox.Enabled = True
            ShipAddressTextBox.Enabled = True
            ShipCityTextBox.Enabled = True
            ShipRegionTextBox.Enabled = True
            ShipPostalCodeTextBox.Enabled = True
            ShipCountryTextBox.Enabled = True
            SaveButton.Enabled = True
        End If
    End Sub

    ' allow user to search employee IDs
    Private Sub EmployeeSearch_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeSearch.Click
        EmployeeCombo.Visible = True
        Order_DetailsDataGridView.Visible = False
        EmployeeCombo.SelectedIndex = -1
        OrderIDComboBox.Enabled = False
        OrderDateTextBox.Enabled = False
        RequiredDateTextBox.Enabled = False
        CustomerSearch.Enabled = False
        EmployeeSearch.Enabled = False
        ShippedDateTextBox.Enabled = False
        ShipViaTextBox.Enabled = False
        FreightTextBox.Enabled = False
        ShipNameTextBox.Enabled = False
        ShipAddressTextBox.Enabled = False
        ShipCityTextBox.Enabled = False
        ShipRegionTextBox.Enabled = False
        ShipPostalCodeTextBox.Enabled = False
        ShipCountryTextBox.Enabled = False
        SaveButton.Enabled = False
    End Sub

    ' input selected ID into text box
    Private Sub EmployeeCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles EmployeeCombo.SelectedIndexChanged
        If EmployeeCombo.SelectedIndex <> -1 Then
            EmployeeIDTextBox.Text = EmployeeCombo.SelectedValue
            EmployeeCombo.Visible = False
            Order_DetailsDataGridView.Visible = True
            OrderIDComboBox.Enabled = True
            OrderDateTextBox.Enabled = True
            RequiredDateTextBox.Enabled = True
            CustomerSearch.Enabled = True
            EmployeeSearch.Enabled = True
            ShippedDateTextBox.Enabled = True
            ShipViaTextBox.Enabled = True
            FreightTextBox.Enabled = True
            ShipNameTextBox.Enabled = True
            ShipAddressTextBox.Enabled = True
            ShipCityTextBox.Enabled = True
            ShipRegionTextBox.Enabled = True
            ShipPostalCodeTextBox.Enabled = True
            ShipCountryTextBox.Enabled = True
            SaveButton.Enabled = True
        End If
    End Sub
End Class