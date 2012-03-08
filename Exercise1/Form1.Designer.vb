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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim ShipViaLabel As System.Windows.Forms.Label
        Dim FreightLabel As System.Windows.Forms.Label
        Dim ShipNameLabel As System.Windows.Forms.Label
        Dim ShipAddressLabel As System.Windows.Forms.Label
        Dim ShipCityLabel As System.Windows.Forms.Label
        Dim ShipRegionLabel As System.Windows.Forms.Label
        Dim ShipPostalCodeLabel As System.Windows.Forms.Label
        Dim ShipCountryLabel As System.Windows.Forms.Label
        Dim OrderDateLabel As System.Windows.Forms.Label
        Dim RequiredDateLabel As System.Windows.Forms.Label
        Dim ShippedDateLabel As System.Windows.Forms.Label
        Dim OrderIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NorthwindDataSet = New Exercise1.NorthwindDataSet()
        Me.Order_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_DetailsTableAdapter = New Exercise1.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter()
        Me.TableAdapterManager = New Exercise1.NorthwindDataSetTableAdapters.TableAdapterManager()
        Me.OrdersTableAdapter = New Exercise1.NorthwindDataSetTableAdapters.OrdersTableAdapter()
        Me.Order_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Order_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.ShipViaTextBox = New System.Windows.Forms.TextBox()
        Me.FreightTextBox = New System.Windows.Forms.TextBox()
        Me.ShipNameTextBox = New System.Windows.Forms.TextBox()
        Me.ShipAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ShipCityTextBox = New System.Windows.Forms.TextBox()
        Me.ShipRegionTextBox = New System.Windows.Forms.TextBox()
        Me.ShipPostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ShipCountryTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OrderIDComboBox = New System.Windows.Forms.ComboBox()
        Me.RequiredDateTextBox = New System.Windows.Forms.TextBox()
        Me.OrderDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EmployeeSearch = New System.Windows.Forms.Button()
        Me.CustomerSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ShippedDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Order_DetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByOrderIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByOrderIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        CustomerIDLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        ShipViaLabel = New System.Windows.Forms.Label()
        FreightLabel = New System.Windows.Forms.Label()
        ShipNameLabel = New System.Windows.Forms.Label()
        ShipAddressLabel = New System.Windows.Forms.Label()
        ShipCityLabel = New System.Windows.Forms.Label()
        ShipRegionLabel = New System.Windows.Forms.Label()
        ShipPostalCodeLabel = New System.Windows.Forms.Label()
        ShipCountryLabel = New System.Windows.Forms.Label()
        OrderDateLabel = New System.Windows.Forms.Label()
        RequiredDateLabel = New System.Windows.Forms.Label()
        ShippedDateLabel = New System.Windows.Forms.Label()
        OrderIDLabel = New System.Windows.Forms.Label()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Order_DetailsBindingNavigator.SuspendLayout()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Order_DetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByOrderIDToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(14, 42)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel.TabIndex = 4
        CustomerIDLabel.Text = "Customer ID:"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(17, 70)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(91, 17)
        EmployeeIDLabel.TabIndex = 6
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'ShipViaLabel
        '
        ShipViaLabel.AutoSize = True
        ShipViaLabel.Location = New System.Drawing.Point(17, 65)
        ShipViaLabel.Name = "ShipViaLabel"
        ShipViaLabel.Size = New System.Drawing.Size(64, 17)
        ShipViaLabel.TabIndex = 14
        ShipViaLabel.Text = "Ship Via:"
        '
        'FreightLabel
        '
        FreightLabel.AutoSize = True
        FreightLabel.Location = New System.Drawing.Point(17, 93)
        FreightLabel.Name = "FreightLabel"
        FreightLabel.Size = New System.Drawing.Size(56, 17)
        FreightLabel.TabIndex = 16
        FreightLabel.Text = "Freight:"
        '
        'ShipNameLabel
        '
        ShipNameLabel.AutoSize = True
        ShipNameLabel.Location = New System.Drawing.Point(17, 121)
        ShipNameLabel.Name = "ShipNameLabel"
        ShipNameLabel.Size = New System.Drawing.Size(81, 17)
        ShipNameLabel.TabIndex = 18
        ShipNameLabel.Text = "Ship Name:"
        '
        'ShipAddressLabel
        '
        ShipAddressLabel.AutoSize = True
        ShipAddressLabel.Location = New System.Drawing.Point(17, 149)
        ShipAddressLabel.Name = "ShipAddressLabel"
        ShipAddressLabel.Size = New System.Drawing.Size(96, 17)
        ShipAddressLabel.TabIndex = 20
        ShipAddressLabel.Text = "Ship Address:"
        '
        'ShipCityLabel
        '
        ShipCityLabel.AutoSize = True
        ShipCityLabel.Location = New System.Drawing.Point(17, 177)
        ShipCityLabel.Name = "ShipCityLabel"
        ShipCityLabel.Size = New System.Drawing.Size(67, 17)
        ShipCityLabel.TabIndex = 22
        ShipCityLabel.Text = "Ship City:"
        '
        'ShipRegionLabel
        '
        ShipRegionLabel.AutoSize = True
        ShipRegionLabel.Location = New System.Drawing.Point(17, 205)
        ShipRegionLabel.Name = "ShipRegionLabel"
        ShipRegionLabel.Size = New System.Drawing.Size(89, 17)
        ShipRegionLabel.TabIndex = 24
        ShipRegionLabel.Text = "Ship Region:"
        '
        'ShipPostalCodeLabel
        '
        ShipPostalCodeLabel.AutoSize = True
        ShipPostalCodeLabel.Location = New System.Drawing.Point(17, 233)
        ShipPostalCodeLabel.Name = "ShipPostalCodeLabel"
        ShipPostalCodeLabel.Size = New System.Drawing.Size(120, 17)
        ShipPostalCodeLabel.TabIndex = 26
        ShipPostalCodeLabel.Text = "Ship Postal Code:"
        '
        'ShipCountryLabel
        '
        ShipCountryLabel.AutoSize = True
        ShipCountryLabel.Location = New System.Drawing.Point(15, 261)
        ShipCountryLabel.Name = "ShipCountryLabel"
        ShipCountryLabel.Size = New System.Drawing.Size(93, 17)
        ShipCountryLabel.TabIndex = 28
        ShipCountryLabel.Text = "Ship Country:"
        '
        'OrderDateLabel
        '
        OrderDateLabel.AutoSize = True
        OrderDateLabel.Location = New System.Drawing.Point(12, 70)
        OrderDateLabel.Name = "OrderDateLabel"
        OrderDateLabel.Size = New System.Drawing.Size(83, 17)
        OrderDateLabel.TabIndex = 32
        OrderDateLabel.Text = "Order Date:"
        '
        'RequiredDateLabel
        '
        RequiredDateLabel.AutoSize = True
        RequiredDateLabel.Location = New System.Drawing.Point(12, 98)
        RequiredDateLabel.Name = "RequiredDateLabel"
        RequiredDateLabel.Size = New System.Drawing.Size(104, 17)
        RequiredDateLabel.TabIndex = 33
        RequiredDateLabel.Text = "Required Date:"
        '
        'ShippedDateLabel
        '
        ShippedDateLabel.AutoSize = True
        ShippedDateLabel.Location = New System.Drawing.Point(17, 38)
        ShippedDateLabel.Name = "ShippedDateLabel"
        ShippedDateLabel.Size = New System.Drawing.Size(98, 17)
        ShippedDateLabel.TabIndex = 30
        ShippedDateLabel.Text = "Shipped Date:"
        '
        'OrderIDLabel
        '
        OrderIDLabel.AutoSize = True
        OrderIDLabel.Location = New System.Drawing.Point(15, 44)
        OrderIDLabel.Name = "OrderIDLabel"
        OrderIDLabel.Size = New System.Drawing.Size(66, 17)
        OrderIDLabel.TabIndex = 34
        OrderIDLabel.Text = "Order ID:"
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_DetailsBindingSource
        '
        Me.Order_DetailsBindingSource.DataMember = "Order Details"
        Me.Order_DetailsBindingSource.DataSource = Me.NorthwindDataSet
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
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
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'Order_DetailsBindingNavigator
        '
        Me.Order_DetailsBindingNavigator.AddNewItem = Nothing
        Me.Order_DetailsBindingNavigator.BindingSource = Me.Order_DetailsBindingSource
        Me.Order_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Order_DetailsBindingNavigator.DeleteItem = Nothing
        Me.Order_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Order_DetailsBindingNavigatorSaveItem})
        Me.Order_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Order_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Order_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Order_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Order_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Order_DetailsBindingNavigator.Name = "Order_DetailsBindingNavigator"
        Me.Order_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Order_DetailsBindingNavigator.Size = New System.Drawing.Size(955, 27)
        Me.Order_DetailsBindingNavigator.TabIndex = 0
        Me.Order_DetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Order_DetailsBindingNavigatorSaveItem
        '
        Me.Order_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Order_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Order_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Order_DetailsBindingNavigatorSaveItem.Name = "Order_DetailsBindingNavigatorSaveItem"
        Me.Order_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Order_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.NorthwindDataSet
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(138, 39)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CustomerIDTextBox.TabIndex = 5
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(138, 67)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(101, 22)
        Me.EmployeeIDTextBox.TabIndex = 7
        '
        'ShipViaTextBox
        '
        Me.ShipViaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipVia", True))
        Me.ShipViaTextBox.Location = New System.Drawing.Point(143, 62)
        Me.ShipViaTextBox.Name = "ShipViaTextBox"
        Me.ShipViaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ShipViaTextBox.TabIndex = 15
        '
        'FreightTextBox
        '
        Me.FreightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Freight", True))
        Me.FreightTextBox.Location = New System.Drawing.Point(143, 90)
        Me.FreightTextBox.Name = "FreightTextBox"
        Me.FreightTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FreightTextBox.TabIndex = 17
        '
        'ShipNameTextBox
        '
        Me.ShipNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipName", True))
        Me.ShipNameTextBox.Location = New System.Drawing.Point(143, 118)
        Me.ShipNameTextBox.Name = "ShipNameTextBox"
        Me.ShipNameTextBox.Size = New System.Drawing.Size(151, 22)
        Me.ShipNameTextBox.TabIndex = 19
        '
        'ShipAddressTextBox
        '
        Me.ShipAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipAddress", True))
        Me.ShipAddressTextBox.Location = New System.Drawing.Point(143, 146)
        Me.ShipAddressTextBox.Name = "ShipAddressTextBox"
        Me.ShipAddressTextBox.Size = New System.Drawing.Size(151, 22)
        Me.ShipAddressTextBox.TabIndex = 21
        '
        'ShipCityTextBox
        '
        Me.ShipCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipCity", True))
        Me.ShipCityTextBox.Location = New System.Drawing.Point(143, 174)
        Me.ShipCityTextBox.Name = "ShipCityTextBox"
        Me.ShipCityTextBox.Size = New System.Drawing.Size(151, 22)
        Me.ShipCityTextBox.TabIndex = 23
        '
        'ShipRegionTextBox
        '
        Me.ShipRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipRegion", True))
        Me.ShipRegionTextBox.Location = New System.Drawing.Point(143, 202)
        Me.ShipRegionTextBox.Name = "ShipRegionTextBox"
        Me.ShipRegionTextBox.Size = New System.Drawing.Size(151, 22)
        Me.ShipRegionTextBox.TabIndex = 25
        '
        'ShipPostalCodeTextBox
        '
        Me.ShipPostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipPostalCode", True))
        Me.ShipPostalCodeTextBox.Location = New System.Drawing.Point(143, 230)
        Me.ShipPostalCodeTextBox.Name = "ShipPostalCodeTextBox"
        Me.ShipPostalCodeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ShipPostalCodeTextBox.TabIndex = 27
        '
        'ShipCountryTextBox
        '
        Me.ShipCountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipCountry", True))
        Me.ShipCountryTextBox.Location = New System.Drawing.Point(143, 258)
        Me.ShipCountryTextBox.Name = "ShipCountryTextBox"
        Me.ShipCountryTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ShipCountryTextBox.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(OrderIDLabel)
        Me.Panel1.Controls.Add(Me.OrderIDComboBox)
        Me.Panel1.Controls.Add(RequiredDateLabel)
        Me.Panel1.Controls.Add(Me.RequiredDateTextBox)
        Me.Panel1.Controls.Add(OrderDateLabel)
        Me.Panel1.Controls.Add(Me.OrderDateTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(31, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 150)
        Me.Panel1.TabIndex = 30
        '
        'OrderIDComboBox
        '
        Me.OrderIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderID", True))
        Me.OrderIDComboBox.FormattingEnabled = True
        Me.OrderIDComboBox.Location = New System.Drawing.Point(122, 37)
        Me.OrderIDComboBox.MaxLength = 100
        Me.OrderIDComboBox.Name = "OrderIDComboBox"
        Me.OrderIDComboBox.Size = New System.Drawing.Size(116, 24)
        Me.OrderIDComboBox.TabIndex = 35
        '
        'RequiredDateTextBox
        '
        Me.RequiredDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "RequiredDate", True))
        Me.RequiredDateTextBox.Location = New System.Drawing.Point(122, 95)
        Me.RequiredDateTextBox.Name = "RequiredDateTextBox"
        Me.RequiredDateTextBox.Size = New System.Drawing.Size(117, 22)
        Me.RequiredDateTextBox.TabIndex = 34
        '
        'OrderDateTextBox
        '
        Me.OrderDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderDate", True))
        Me.OrderDateTextBox.Location = New System.Drawing.Point(122, 67)
        Me.OrderDateTextBox.Name = "OrderDateTextBox"
        Me.OrderDateTextBox.Size = New System.Drawing.Size(116, 22)
        Me.OrderDateTextBox.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Info:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.EmployeeSearch)
        Me.Panel2.Controls.Add(Me.CustomerSearch)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(CustomerIDLabel)
        Me.Panel2.Controls.Add(Me.CustomerIDTextBox)
        Me.Panel2.Controls.Add(EmployeeIDLabel)
        Me.Panel2.Controls.Add(Me.EmployeeIDTextBox)
        Me.Panel2.Location = New System.Drawing.Point(31, 210)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 123)
        Me.Panel2.TabIndex = 31
        '
        'EmployeeSearch
        '
        Me.EmployeeSearch.Location = New System.Drawing.Point(247, 67)
        Me.EmployeeSearch.Name = "EmployeeSearch"
        Me.EmployeeSearch.Size = New System.Drawing.Size(75, 23)
        Me.EmployeeSearch.TabIndex = 10
        Me.EmployeeSearch.Text = "Search"
        Me.EmployeeSearch.UseVisualStyleBackColor = True
        '
        'CustomerSearch
        '
        Me.CustomerSearch.Location = New System.Drawing.Point(246, 38)
        Me.CustomerSearch.Name = "CustomerSearch"
        Me.CustomerSearch.Size = New System.Drawing.Size(75, 23)
        Me.CustomerSearch.TabIndex = 9
        Me.CustomerSearch.Text = "Search"
        Me.CustomerSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ID Search:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(ShippedDateLabel)
        Me.Panel3.Controls.Add(Me.ShippedDateTextBox)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(ShipViaLabel)
        Me.Panel3.Controls.Add(Me.ShipViaTextBox)
        Me.Panel3.Controls.Add(FreightLabel)
        Me.Panel3.Controls.Add(Me.FreightTextBox)
        Me.Panel3.Controls.Add(ShipNameLabel)
        Me.Panel3.Controls.Add(Me.ShipNameTextBox)
        Me.Panel3.Controls.Add(ShipAddressLabel)
        Me.Panel3.Controls.Add(Me.ShipAddressTextBox)
        Me.Panel3.Controls.Add(ShipCityLabel)
        Me.Panel3.Controls.Add(Me.ShipCityTextBox)
        Me.Panel3.Controls.Add(ShipRegionLabel)
        Me.Panel3.Controls.Add(Me.ShipRegionTextBox)
        Me.Panel3.Controls.Add(ShipPostalCodeLabel)
        Me.Panel3.Controls.Add(Me.ShipPostalCodeTextBox)
        Me.Panel3.Controls.Add(ShipCountryLabel)
        Me.Panel3.Controls.Add(Me.ShipCountryTextBox)
        Me.Panel3.Location = New System.Drawing.Point(31, 355)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(329, 304)
        Me.Panel3.TabIndex = 32
        '
        'ShippedDateTextBox
        '
        Me.ShippedDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShippedDate", True))
        Me.ShippedDateTextBox.Location = New System.Drawing.Point(143, 33)
        Me.ShippedDateTextBox.Name = "ShippedDateTextBox"
        Me.ShippedDateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ShippedDateTextBox.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Shipping Info:"
        '
        'Order_DetailsBindingSource1
        '
        Me.Order_DetailsBindingSource1.DataMember = "FK_Order_Details_Orders"
        Me.Order_DetailsBindingSource1.DataSource = Me.OrdersBindingSource
        '
        'Order_DetailsDataGridView
        '
        Me.Order_DetailsDataGridView.AutoGenerateColumns = False
        Me.Order_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Order_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Order_DetailsDataGridView.DataSource = Me.Order_DetailsBindingSource1
        Me.Order_DetailsDataGridView.Location = New System.Drawing.Point(375, 50)
        Me.Order_DetailsDataGridView.Name = "Order_DetailsDataGridView"
        Me.Order_DetailsDataGridView.RowTemplate.Height = 24
        Me.Order_DetailsDataGridView.Size = New System.Drawing.Size(543, 609)
        Me.Order_DetailsDataGridView.TabIndex = 32
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
        'FillByOrderIDToolStrip
        '
        Me.FillByOrderIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByOrderIDToolStripButton})
        Me.FillByOrderIDToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.FillByOrderIDToolStrip.Name = "FillByOrderIDToolStrip"
        Me.FillByOrderIDToolStrip.Size = New System.Drawing.Size(955, 27)
        Me.FillByOrderIDToolStrip.TabIndex = 33
        Me.FillByOrderIDToolStrip.Text = "FillByOrderIDToolStrip"
        '
        'FillByOrderIDToolStripButton
        '
        Me.FillByOrderIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByOrderIDToolStripButton.Name = "FillByOrderIDToolStripButton"
        Me.FillByOrderIDToolStripButton.Size = New System.Drawing.Size(101, 24)
        Me.FillByOrderIDToolStripButton.Text = "FillByOrderID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 679)
        Me.Controls.Add(Me.FillByOrderIDToolStrip)
        Me.Controls.Add(Me.Order_DetailsDataGridView)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Order_DetailsBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Order_DetailsBindingNavigator.ResumeLayout(False)
        Me.Order_DetailsBindingNavigator.PerformLayout()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Order_DetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByOrderIDToolStrip.ResumeLayout(False)
        Me.FillByOrderIDToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NorthwindDataSet As Exercise1.NorthwindDataSet
    Friend WithEvents Order_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Order_DetailsTableAdapter As Exercise1.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As Exercise1.NorthwindDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Order_DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Order_DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OrdersTableAdapter As Exercise1.NorthwindDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipViaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FreightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipRegionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipPostalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipCountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EmployeeSearch As System.Windows.Forms.Button
    Friend WithEvents CustomerSearch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RequiredDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShippedDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Order_DetailsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Order_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FillByOrderIDToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByOrderIDToolStripButton As System.Windows.Forms.ToolStripButton

End Class
