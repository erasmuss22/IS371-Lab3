<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim OrderIDLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim OrderDateLabel As System.Windows.Forms.Label
        Dim RequiredDateLabel As System.Windows.Forms.Label
        Dim ShippedDateLabel As System.Windows.Forms.Label
        Dim ShipViaLabel As System.Windows.Forms.Label
        Dim FreightLabel As System.Windows.Forms.Label
        Dim ShipNameLabel As System.Windows.Forms.Label
        Dim ShipAddressLabel As System.Windows.Forms.Label
        Dim ShipCityLabel As System.Windows.Forms.Label
        Dim ShipRegionLabel As System.Windows.Forms.Label
        Dim ShipPostalCodeLabel As System.Windows.Forms.Label
        Dim ShipCountryLabel As System.Windows.Forms.Label
        Me.NorthwindDataSet = New Exercise1.NorthwindDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New Exercise1.NorthwindDataSetTableAdapters.OrdersTableAdapter()
        Me.TableAdapterManager = New Exercise1.NorthwindDataSetTableAdapters.TableAdapterManager()
        Me.Order_DetailsTableAdapter = New Exercise1.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter()
        Me.OrderIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.OrderDateTextBox = New System.Windows.Forms.TextBox()
        Me.RequiredDateTextBox = New System.Windows.Forms.TextBox()
        Me.ShippedDateTextBox = New System.Windows.Forms.TextBox()
        Me.ShipViaTextBox = New System.Windows.Forms.TextBox()
        Me.FreightTextBox = New System.Windows.Forms.TextBox()
        Me.ShipNameTextBox = New System.Windows.Forms.TextBox()
        Me.ShipAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ShipCityTextBox = New System.Windows.Forms.TextBox()
        Me.ShipRegionTextBox = New System.Windows.Forms.TextBox()
        Me.ShipPostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ShipCountryTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.EmployeeSearch = New System.Windows.Forms.Button()
        Me.CustomerSearch = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        OrderIDLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        OrderDateLabel = New System.Windows.Forms.Label()
        RequiredDateLabel = New System.Windows.Forms.Label()
        ShippedDateLabel = New System.Windows.Forms.Label()
        ShipViaLabel = New System.Windows.Forms.Label()
        FreightLabel = New System.Windows.Forms.Label()
        ShipNameLabel = New System.Windows.Forms.Label()
        ShipAddressLabel = New System.Windows.Forms.Label()
        ShipCityLabel = New System.Windows.Forms.Label()
        ShipRegionLabel = New System.Windows.Forms.Label()
        ShipPostalCodeLabel = New System.Windows.Forms.Label()
        ShipCountryLabel = New System.Windows.Forms.Label()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderIDLabel
        '
        OrderIDLabel.AutoSize = True
        OrderIDLabel.Location = New System.Drawing.Point(3, 31)
        OrderIDLabel.Name = "OrderIDLabel"
        OrderIDLabel.Size = New System.Drawing.Size(66, 17)
        OrderIDLabel.TabIndex = 1
        OrderIDLabel.Text = "Order ID:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(4, 33)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel.TabIndex = 3
        CustomerIDLabel.Text = "Customer ID:"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(4, 59)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(91, 17)
        EmployeeIDLabel.TabIndex = 5
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'OrderDateLabel
        '
        OrderDateLabel.AutoSize = True
        OrderDateLabel.Location = New System.Drawing.Point(3, 61)
        OrderDateLabel.Name = "OrderDateLabel"
        OrderDateLabel.Size = New System.Drawing.Size(83, 17)
        OrderDateLabel.TabIndex = 7
        OrderDateLabel.Text = "Order Date:"
        '
        'RequiredDateLabel
        '
        RequiredDateLabel.AutoSize = True
        RequiredDateLabel.Location = New System.Drawing.Point(4, 89)
        RequiredDateLabel.Name = "RequiredDateLabel"
        RequiredDateLabel.Size = New System.Drawing.Size(104, 17)
        RequiredDateLabel.TabIndex = 9
        RequiredDateLabel.Text = "Required Date:"
        '
        'ShippedDateLabel
        '
        ShippedDateLabel.AutoSize = True
        ShippedDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShippedDateLabel.Location = New System.Drawing.Point(4, 39)
        ShippedDateLabel.Name = "ShippedDateLabel"
        ShippedDateLabel.Size = New System.Drawing.Size(98, 17)
        ShippedDateLabel.TabIndex = 11
        ShippedDateLabel.Text = "Shipped Date:"
        '
        'ShipViaLabel
        '
        ShipViaLabel.AutoSize = True
        ShipViaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipViaLabel.Location = New System.Drawing.Point(3, 67)
        ShipViaLabel.Name = "ShipViaLabel"
        ShipViaLabel.Size = New System.Drawing.Size(64, 17)
        ShipViaLabel.TabIndex = 13
        ShipViaLabel.Text = "Ship Via:"
        '
        'FreightLabel
        '
        FreightLabel.AutoSize = True
        FreightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FreightLabel.Location = New System.Drawing.Point(4, 98)
        FreightLabel.Name = "FreightLabel"
        FreightLabel.Size = New System.Drawing.Size(56, 17)
        FreightLabel.TabIndex = 15
        FreightLabel.Text = "Freight:"
        '
        'ShipNameLabel
        '
        ShipNameLabel.AutoSize = True
        ShipNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipNameLabel.Location = New System.Drawing.Point(4, 126)
        ShipNameLabel.Name = "ShipNameLabel"
        ShipNameLabel.Size = New System.Drawing.Size(81, 17)
        ShipNameLabel.TabIndex = 17
        ShipNameLabel.Text = "Ship Name:"
        '
        'ShipAddressLabel
        '
        ShipAddressLabel.AutoSize = True
        ShipAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipAddressLabel.Location = New System.Drawing.Point(4, 151)
        ShipAddressLabel.Name = "ShipAddressLabel"
        ShipAddressLabel.Size = New System.Drawing.Size(96, 17)
        ShipAddressLabel.TabIndex = 19
        ShipAddressLabel.Text = "Ship Address:"
        '
        'ShipCityLabel
        '
        ShipCityLabel.AutoSize = True
        ShipCityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipCityLabel.Location = New System.Drawing.Point(3, 182)
        ShipCityLabel.Name = "ShipCityLabel"
        ShipCityLabel.Size = New System.Drawing.Size(67, 17)
        ShipCityLabel.TabIndex = 21
        ShipCityLabel.Text = "Ship City:"
        '
        'ShipRegionLabel
        '
        ShipRegionLabel.AutoSize = True
        ShipRegionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipRegionLabel.Location = New System.Drawing.Point(3, 210)
        ShipRegionLabel.Name = "ShipRegionLabel"
        ShipRegionLabel.Size = New System.Drawing.Size(89, 17)
        ShipRegionLabel.TabIndex = 23
        ShipRegionLabel.Text = "Ship Region:"
        '
        'ShipPostalCodeLabel
        '
        ShipPostalCodeLabel.AutoSize = True
        ShipPostalCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipPostalCodeLabel.Location = New System.Drawing.Point(4, 238)
        ShipPostalCodeLabel.Name = "ShipPostalCodeLabel"
        ShipPostalCodeLabel.Size = New System.Drawing.Size(101, 17)
        ShipPostalCodeLabel.TabIndex = 25
        ShipPostalCodeLabel.Text = "Ship Zip Code:"
        '
        'ShipCountryLabel
        '
        ShipCountryLabel.AutoSize = True
        ShipCountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipCountryLabel.Location = New System.Drawing.Point(3, 268)
        ShipCountryLabel.Name = "ShipCountryLabel"
        ShipCountryLabel.Size = New System.Drawing.Size(93, 17)
        ShipCountryLabel.TabIndex = 27
        ShipCountryLabel.Text = "Ship Country:"
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.NorthwindDataSet
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Me.Order_DetailsTableAdapter
        Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Exercise1.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'OrderIDComboBox
        '
        Me.OrderIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderID", True))
        Me.OrderIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OrdersBindingSource, "OrderID", True))
        Me.OrderIDComboBox.DataSource = Me.OrdersBindingSource
        Me.OrderIDComboBox.DisplayMember = "OrderID"
        Me.OrderIDComboBox.FormattingEnabled = True
        Me.OrderIDComboBox.Location = New System.Drawing.Point(114, 28)
        Me.OrderIDComboBox.Name = "OrderIDComboBox"
        Me.OrderIDComboBox.Size = New System.Drawing.Size(82, 24)
        Me.OrderIDComboBox.TabIndex = 2
        Me.OrderIDComboBox.ValueMember = "OrderID"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Enabled = False
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(114, 28)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(82, 22)
        Me.CustomerIDTextBox.TabIndex = 4
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox.Enabled = False
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(115, 56)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(81, 22)
        Me.EmployeeIDTextBox.TabIndex = 6
        '
        'OrderDateTextBox
        '
        Me.OrderDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderDate", True))
        Me.OrderDateTextBox.Location = New System.Drawing.Point(114, 58)
        Me.OrderDateTextBox.Name = "OrderDateTextBox"
        Me.OrderDateTextBox.Size = New System.Drawing.Size(82, 22)
        Me.OrderDateTextBox.TabIndex = 8
        '
        'RequiredDateTextBox
        '
        Me.RequiredDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "RequiredDate", True))
        Me.RequiredDateTextBox.Location = New System.Drawing.Point(114, 86)
        Me.RequiredDateTextBox.Name = "RequiredDateTextBox"
        Me.RequiredDateTextBox.Size = New System.Drawing.Size(82, 22)
        Me.RequiredDateTextBox.TabIndex = 10
        '
        'ShippedDateTextBox
        '
        Me.ShippedDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShippedDate", True))
        Me.ShippedDateTextBox.Location = New System.Drawing.Point(115, 36)
        Me.ShippedDateTextBox.Name = "ShippedDateTextBox"
        Me.ShippedDateTextBox.Size = New System.Drawing.Size(81, 22)
        Me.ShippedDateTextBox.TabIndex = 12
        '
        'ShipViaTextBox
        '
        Me.ShipViaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipVia", True))
        Me.ShipViaTextBox.Location = New System.Drawing.Point(115, 64)
        Me.ShipViaTextBox.Name = "ShipViaTextBox"
        Me.ShipViaTextBox.Size = New System.Drawing.Size(81, 22)
        Me.ShipViaTextBox.TabIndex = 14
        '
        'FreightTextBox
        '
        Me.FreightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Freight", True))
        Me.FreightTextBox.Location = New System.Drawing.Point(115, 95)
        Me.FreightTextBox.Name = "FreightTextBox"
        Me.FreightTextBox.Size = New System.Drawing.Size(81, 22)
        Me.FreightTextBox.TabIndex = 16
        '
        'ShipNameTextBox
        '
        Me.ShipNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipName", True))
        Me.ShipNameTextBox.Location = New System.Drawing.Point(115, 123)
        Me.ShipNameTextBox.Name = "ShipNameTextBox"
        Me.ShipNameTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ShipNameTextBox.TabIndex = 18
        '
        'ShipAddressTextBox
        '
        Me.ShipAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipAddress", True))
        Me.ShipAddressTextBox.Location = New System.Drawing.Point(115, 151)
        Me.ShipAddressTextBox.Name = "ShipAddressTextBox"
        Me.ShipAddressTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ShipAddressTextBox.TabIndex = 20
        '
        'ShipCityTextBox
        '
        Me.ShipCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipCity", True))
        Me.ShipCityTextBox.Location = New System.Drawing.Point(115, 179)
        Me.ShipCityTextBox.Name = "ShipCityTextBox"
        Me.ShipCityTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ShipCityTextBox.TabIndex = 22
        '
        'ShipRegionTextBox
        '
        Me.ShipRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipRegion", True))
        Me.ShipRegionTextBox.Location = New System.Drawing.Point(115, 207)
        Me.ShipRegionTextBox.Name = "ShipRegionTextBox"
        Me.ShipRegionTextBox.Size = New System.Drawing.Size(81, 22)
        Me.ShipRegionTextBox.TabIndex = 24
        '
        'ShipPostalCodeTextBox
        '
        Me.ShipPostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipPostalCode", True))
        Me.ShipPostalCodeTextBox.Location = New System.Drawing.Point(115, 235)
        Me.ShipPostalCodeTextBox.Name = "ShipPostalCodeTextBox"
        Me.ShipPostalCodeTextBox.Size = New System.Drawing.Size(81, 22)
        Me.ShipPostalCodeTextBox.TabIndex = 26
        '
        'ShipCountryTextBox
        '
        Me.ShipCountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipCountry", True))
        Me.ShipCountryTextBox.Location = New System.Drawing.Point(115, 263)
        Me.ShipCountryTextBox.Name = "ShipCountryTextBox"
        Me.ShipCountryTextBox.Size = New System.Drawing.Size(81, 22)
        Me.ShipCountryTextBox.TabIndex = 28
        '
        'Order_DetailsBindingSource
        '
        Me.Order_DetailsBindingSource.DataMember = "FK_Order_Details_Orders"
        Me.Order_DetailsBindingSource.DataSource = Me.OrdersBindingSource
        '
        'Order_DetailsDataGridView
        '
        Me.Order_DetailsDataGridView.AutoGenerateColumns = False
        Me.Order_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Order_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Order_DetailsDataGridView.DataSource = Me.Order_DetailsBindingSource
        Me.Order_DetailsDataGridView.Location = New System.Drawing.Point(316, 8)
        Me.Order_DetailsDataGridView.Name = "Order_DetailsDataGridView"
        Me.Order_DetailsDataGridView.RowTemplate.Height = 24
        Me.Order_DetailsDataGridView.Size = New System.Drawing.Size(544, 568)
        Me.Order_DetailsDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OrderID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "OrderID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Discount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Order Info:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.OrderIDComboBox)
        Me.Panel1.Controls.Add(OrderIDLabel)
        Me.Panel1.Controls.Add(Me.OrderDateTextBox)
        Me.Panel1.Controls.Add(Me.RequiredDateTextBox)
        Me.Panel1.Controls.Add(OrderDateLabel)
        Me.Panel1.Controls.Add(RequiredDateLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 118)
        Me.Panel1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Shipping Info:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(ShippedDateLabel)
        Me.Panel2.Controls.Add(Me.ShippedDateTextBox)
        Me.Panel2.Controls.Add(ShipViaLabel)
        Me.Panel2.Controls.Add(Me.ShipViaTextBox)
        Me.Panel2.Controls.Add(FreightLabel)
        Me.Panel2.Controls.Add(Me.FreightTextBox)
        Me.Panel2.Controls.Add(ShipNameLabel)
        Me.Panel2.Controls.Add(Me.ShipNameTextBox)
        Me.Panel2.Controls.Add(ShipAddressLabel)
        Me.Panel2.Controls.Add(Me.ShipAddressTextBox)
        Me.Panel2.Controls.Add(ShipCityLabel)
        Me.Panel2.Controls.Add(Me.ShipCityTextBox)
        Me.Panel2.Controls.Add(ShipRegionLabel)
        Me.Panel2.Controls.Add(Me.ShipRegionTextBox)
        Me.Panel2.Controls.Add(ShipPostalCodeLabel)
        Me.Panel2.Controls.Add(Me.ShipPostalCodeTextBox)
        Me.Panel2.Controls.Add(ShipCountryLabel)
        Me.Panel2.Controls.Add(Me.ShipCountryTextBox)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(298, 305)
        Me.Panel2.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "ID Search:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.EmployeeSearch)
        Me.Panel3.Controls.Add(Me.CustomerSearch)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(CustomerIDLabel)
        Me.Panel3.Controls.Add(Me.CustomerIDTextBox)
        Me.Panel3.Controls.Add(EmployeeIDLabel)
        Me.Panel3.Controls.Add(Me.EmployeeIDTextBox)
        Me.Panel3.Location = New System.Drawing.Point(12, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(298, 93)
        Me.Panel3.TabIndex = 35
        '
        'EmployeeSearch
        '
        Me.EmployeeSearch.Location = New System.Drawing.Point(202, 56)
        Me.EmployeeSearch.Name = "EmployeeSearch"
        Me.EmployeeSearch.Size = New System.Drawing.Size(70, 23)
        Me.EmployeeSearch.TabIndex = 36
        Me.EmployeeSearch.Text = "Search"
        Me.EmployeeSearch.UseVisualStyleBackColor = True
        '
        'CustomerSearch
        '
        Me.CustomerSearch.Location = New System.Drawing.Point(202, 27)
        Me.CustomerSearch.Name = "CustomerSearch"
        Me.CustomerSearch.Size = New System.Drawing.Size(70, 23)
        Me.CustomerSearch.TabIndex = 35
        Me.CustomerSearch.Text = "Search"
        Me.CustomerSearch.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(128, 545)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 36
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 580)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Order_DetailsDataGridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NorthwindDataSet As Exercise1.NorthwindDataSet
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersTableAdapter As Exercise1.NorthwindDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents TableAdapterManager As Exercise1.NorthwindDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RequiredDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShippedDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipViaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FreightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipRegionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipPostalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipCountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Order_DetailsTableAdapter As Exercise1.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents Order_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Order_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents EmployeeSearch As System.Windows.Forms.Button
    Friend WithEvents CustomerSearch As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
End Class
