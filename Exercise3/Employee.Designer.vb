<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Me.PubsDataSet = New Exercise3.pubsDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Exercise3.pubsDataSetTableAdapters.employeeTableAdapter()
        Me.TableAdapterManager = New Exercise3.pubsDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillBySearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SearchToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SearchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        CType(Me.PubsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBySearchToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PubsDataSet
        '
        Me.PubsDataSet.DataSetName = "pubsDataSet"
        Me.PubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.PubsDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.titlesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Exercise3.pubsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(3, 34)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.RowTemplate.Height = 24
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(632, 256)
        Me.EmployeeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "emp_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "emp_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "minit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "minit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "lname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "lname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "job_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "job_id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "job_lvl"
        Me.DataGridViewTextBoxColumn6.HeaderText = "job_lvl"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "pub_id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "pub_id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "hire_date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "hire_date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'FillBySearchToolStrip
        '
        Me.FillBySearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripLabel, Me.SearchToolStripTextBox, Me.ToolStripButton1})
        Me.FillBySearchToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBySearchToolStrip.Name = "FillBySearchToolStrip"
        Me.FillBySearchToolStrip.Size = New System.Drawing.Size(655, 27)
        Me.FillBySearchToolStrip.TabIndex = 2
        Me.FillBySearchToolStrip.Text = "FillBySearchToolStrip"
        '
        'SearchToolStripLabel
        '
        Me.SearchToolStripLabel.Name = "SearchToolStripLabel"
        Me.SearchToolStripLabel.Size = New System.Drawing.Size(54, 24)
        Me.SearchToolStripLabel.Text = "search:"
        '
        'SearchToolStripTextBox
        '
        Me.SearchToolStripTextBox.Name = "SearchToolStripTextBox"
        Me.SearchToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(84, 24)
        Me.ToolStripButton1.Text = "First Name"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(278, 296)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(103, 33)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear Search"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 341)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.FillBySearchToolStrip)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.Name = "Employee"
        Me.Text = "Employee"
        CType(Me.PubsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBySearchToolStrip.ResumeLayout(False)
        Me.FillBySearchToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PubsDataSet As Exercise3.pubsDataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As Exercise3.pubsDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents TableAdapterManager As Exercise3.pubsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillBySearchToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents SearchToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SearchToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClearButton As System.Windows.Forms.Button
End Class
