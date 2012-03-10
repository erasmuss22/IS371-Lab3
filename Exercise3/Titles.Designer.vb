<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Titles
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
        Me.TitlesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AuthorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PubsDataSet = New Exercise3.pubsDataSet()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitlesTableAdapter = New Exercise3.pubsDataSetTableAdapters.titlesTableAdapter()
        Me.TableAdapterManager = New Exercise3.pubsDataSetTableAdapters.TableAdapterManager()
        Me.SalesTableAdapter = New Exercise3.pubsDataSetTableAdapters.salesTableAdapter()
        Me.AuthorsTableAdapter = New Exercise3.pubsDataSetTableAdapters.authorsTableAdapter()
        CType(Me.TitlesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PubsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitlesDataGridView
        '
        Me.TitlesDataGridView.AutoGenerateColumns = False
        Me.TitlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TitlesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TitlesDataGridView.DataSource = Me.TitlesBindingSource
        Me.TitlesDataGridView.Location = New System.Drawing.Point(0, 49)
        Me.TitlesDataGridView.Name = "TitlesDataGridView"
        Me.TitlesDataGridView.RowTemplate.Height = 24
        Me.TitlesDataGridView.Size = New System.Drawing.Size(643, 178)
        Me.TitlesDataGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Titles of type business that were published before 6/30/1991 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SalesDataGridView
        '
        Me.SalesDataGridView.AutoGenerateColumns = False
        Me.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.SalesDataGridView.DataSource = Me.SalesBindingSource
        Me.SalesDataGridView.Location = New System.Drawing.Point(0, 271)
        Me.SalesDataGridView.Name = "SalesDataGridView"
        Me.SalesDataGridView.RowTemplate.Height = 24
        Me.SalesDataGridView.Size = New System.Drawing.Size(643, 191)
        Me.SalesDataGridView.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sales with payterms Net 30 and more than 20 sold"
        '
        'AuthorsDataGridView
        '
        Me.AuthorsDataGridView.AutoGenerateColumns = False
        Me.AuthorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuthorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewCheckBoxColumn1})
        Me.AuthorsDataGridView.DataSource = Me.AuthorsBindingSource
        Me.AuthorsDataGridView.Location = New System.Drawing.Point(0, 497)
        Me.AuthorsDataGridView.Name = "AuthorsDataGridView"
        Me.AuthorsDataGridView.RowTemplate.Height = 24
        Me.AuthorsDataGridView.Size = New System.Drawing.Size(643, 189)
        Me.AuthorsDataGridView.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Authors from California with a contract"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "au_id"
        Me.DataGridViewTextBoxColumn17.HeaderText = "au_id"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "au_lname"
        Me.DataGridViewTextBoxColumn18.HeaderText = "au_lname"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "au_fname"
        Me.DataGridViewTextBoxColumn19.HeaderText = "au_fname"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn20.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn21.HeaderText = "address"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "city"
        Me.DataGridViewTextBoxColumn22.HeaderText = "city"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "state"
        Me.DataGridViewTextBoxColumn23.HeaderText = "state"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "zip"
        Me.DataGridViewTextBoxColumn24.HeaderText = "zip"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "contract"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "contract"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.DataMember = "authors"
        Me.AuthorsBindingSource.DataSource = Me.PubsDataSet
        '
        'PubsDataSet
        '
        Me.PubsDataSet.DataSetName = "pubsDataSet"
        Me.PubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "stor_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "stor_id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ord_num"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ord_num"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ord_date"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ord_date"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "qty"
        Me.DataGridViewTextBoxColumn14.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "payterms"
        Me.DataGridViewTextBoxColumn15.HeaderText = "payterms"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "title_id"
        Me.DataGridViewTextBoxColumn16.HeaderText = "title_id"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "sales"
        Me.SalesBindingSource.DataSource = Me.PubsDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "title_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "title_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pub_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "pub_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "advance"
        Me.DataGridViewTextBoxColumn6.HeaderText = "advance"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "royalty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "royalty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ytd_sales"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ytd_sales"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "notes"
        Me.DataGridViewTextBoxColumn9.HeaderText = "notes"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "pubdate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "pubdate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'TitlesBindingSource
        '
        Me.TitlesBindingSource.DataMember = "titles"
        Me.TitlesBindingSource.DataSource = Me.PubsDataSet
        '
        'TitlesTableAdapter
        '
        Me.TitlesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.titlesTableAdapter = Me.TitlesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Exercise3.pubsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'AuthorsTableAdapter
        '
        Me.AuthorsTableAdapter.ClearBeforeFill = True
        '
        'Titles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(660, 745)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AuthorsDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SalesDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitlesDataGridView)
        Me.Name = "Titles"
        Me.Text = "Titles, Sales, Authors"
        CType(Me.TitlesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PubsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PubsDataSet As Exercise3.pubsDataSet
    Friend WithEvents TitlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitlesTableAdapter As Exercise3.pubsDataSetTableAdapters.titlesTableAdapter
    Friend WithEvents TableAdapterManager As Exercise3.pubsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TitlesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As Exercise3.pubsDataSetTableAdapters.salesTableAdapter
    Friend WithEvents SalesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AuthorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuthorsTableAdapter As Exercise3.pubsDataSetTableAdapters.authorsTableAdapter
    Friend WithEvents AuthorsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
