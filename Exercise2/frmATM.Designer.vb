﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATM
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HeadsUpLabel = New System.Windows.Forms.Label()
        Me.PinText = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BalanceButton = New System.Windows.Forms.Button()
        Me.DoneButton = New System.Windows.Forms.Button()
        Me.WithdrawButton = New System.Windows.Forms.Button()
        Me.OkayButton = New System.Windows.Forms.Button()
        Me.TwoButton = New System.Windows.Forms.Button()
        Me.ThreeButton = New System.Windows.Forms.Button()
        Me.FourButton = New System.Windows.Forms.Button()
        Me.FiveButton = New System.Windows.Forms.Button()
        Me.SixButton = New System.Windows.Forms.Button()
        Me.SevenButton = New System.Windows.Forms.Button()
        Me.NineButton = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.EightButton = New System.Windows.Forms.Button()
        Me.OneButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AccountNumCombo = New System.Windows.Forms.ComboBox()
        Me.ATMTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NorthwindDataSet = New Exercise2.NorthwindDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ATMTableTableAdapter = New Exercise2.NorthwindDataSetTableAdapters.ATMTableTableAdapter()
        Me.TableAdapterManager = New Exercise2.NorthwindDataSetTableAdapters.TableAdapterManager()
        Me.ATMTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ATMTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATMTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ATMTableDataGridView)
        Me.Panel1.Controls.Add(Me.HeadsUpLabel)
        Me.Panel1.Location = New System.Drawing.Point(27, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 150)
        Me.Panel1.TabIndex = 0
        '
        'HeadsUpLabel
        '
        Me.HeadsUpLabel.AutoSize = True
        Me.HeadsUpLabel.Location = New System.Drawing.Point(50, 62)
        Me.HeadsUpLabel.Name = "HeadsUpLabel"
        Me.HeadsUpLabel.Size = New System.Drawing.Size(234, 17)
        Me.HeadsUpLabel.TabIndex = 0
        Me.HeadsUpLabel.Text = "Please select your account number."
        '
        'PinText
        '
        Me.PinText.Enabled = False
        Me.PinText.Location = New System.Drawing.Point(27, 207)
        Me.PinText.Name = "PinText"
        Me.PinText.Size = New System.Drawing.Size(346, 22)
        Me.PinText.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BalanceButton)
        Me.Panel2.Controls.Add(Me.DoneButton)
        Me.Panel2.Controls.Add(Me.WithdrawButton)
        Me.Panel2.Controls.Add(Me.OkayButton)
        Me.Panel2.Controls.Add(Me.TwoButton)
        Me.Panel2.Controls.Add(Me.ThreeButton)
        Me.Panel2.Controls.Add(Me.FourButton)
        Me.Panel2.Controls.Add(Me.FiveButton)
        Me.Panel2.Controls.Add(Me.SixButton)
        Me.Panel2.Controls.Add(Me.SevenButton)
        Me.Panel2.Controls.Add(Me.NineButton)
        Me.Panel2.Controls.Add(Me.ZeroButton)
        Me.Panel2.Controls.Add(Me.EightButton)
        Me.Panel2.Controls.Add(Me.OneButton)
        Me.Panel2.Location = New System.Drawing.Point(27, 251)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 177)
        Me.Panel2.TabIndex = 2
        '
        'BalanceButton
        '
        Me.BalanceButton.Enabled = False
        Me.BalanceButton.Location = New System.Drawing.Point(210, 50)
        Me.BalanceButton.Name = "BalanceButton"
        Me.BalanceButton.Size = New System.Drawing.Size(94, 23)
        Me.BalanceButton.TabIndex = 13
        Me.BalanceButton.Text = "Balance"
        Me.BalanceButton.UseVisualStyleBackColor = True
        '
        'DoneButton
        '
        Me.DoneButton.Enabled = False
        Me.DoneButton.Location = New System.Drawing.Point(210, 108)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(94, 23)
        Me.DoneButton.TabIndex = 12
        Me.DoneButton.Text = "Done"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'WithdrawButton
        '
        Me.WithdrawButton.Enabled = False
        Me.WithdrawButton.Location = New System.Drawing.Point(210, 79)
        Me.WithdrawButton.Name = "WithdrawButton"
        Me.WithdrawButton.Size = New System.Drawing.Size(94, 23)
        Me.WithdrawButton.TabIndex = 11
        Me.WithdrawButton.Text = "Withdraw"
        Me.WithdrawButton.UseVisualStyleBackColor = True
        '
        'OkayButton
        '
        Me.OkayButton.Enabled = False
        Me.OkayButton.Location = New System.Drawing.Point(210, 21)
        Me.OkayButton.Name = "OkayButton"
        Me.OkayButton.Size = New System.Drawing.Size(94, 23)
        Me.OkayButton.TabIndex = 10
        Me.OkayButton.Text = "Okay"
        Me.OkayButton.UseVisualStyleBackColor = False
        '
        'TwoButton
        '
        Me.TwoButton.Enabled = False
        Me.TwoButton.Location = New System.Drawing.Point(66, 12)
        Me.TwoButton.Name = "TwoButton"
        Me.TwoButton.Size = New System.Drawing.Size(41, 32)
        Me.TwoButton.TabIndex = 9
        Me.TwoButton.Text = "2"
        Me.TwoButton.UseVisualStyleBackColor = True
        '
        'ThreeButton
        '
        Me.ThreeButton.Enabled = False
        Me.ThreeButton.Location = New System.Drawing.Point(113, 12)
        Me.ThreeButton.Name = "ThreeButton"
        Me.ThreeButton.Size = New System.Drawing.Size(41, 32)
        Me.ThreeButton.TabIndex = 8
        Me.ThreeButton.Text = "3"
        Me.ThreeButton.UseVisualStyleBackColor = True
        '
        'FourButton
        '
        Me.FourButton.Enabled = False
        Me.FourButton.Location = New System.Drawing.Point(19, 50)
        Me.FourButton.Name = "FourButton"
        Me.FourButton.Size = New System.Drawing.Size(41, 32)
        Me.FourButton.TabIndex = 7
        Me.FourButton.Text = "4"
        Me.FourButton.UseVisualStyleBackColor = True
        '
        'FiveButton
        '
        Me.FiveButton.Enabled = False
        Me.FiveButton.Location = New System.Drawing.Point(66, 50)
        Me.FiveButton.Name = "FiveButton"
        Me.FiveButton.Size = New System.Drawing.Size(41, 32)
        Me.FiveButton.TabIndex = 6
        Me.FiveButton.Text = "5"
        Me.FiveButton.UseVisualStyleBackColor = True
        '
        'SixButton
        '
        Me.SixButton.Enabled = False
        Me.SixButton.Location = New System.Drawing.Point(113, 50)
        Me.SixButton.Name = "SixButton"
        Me.SixButton.Size = New System.Drawing.Size(41, 32)
        Me.SixButton.TabIndex = 5
        Me.SixButton.Text = "6"
        Me.SixButton.UseVisualStyleBackColor = True
        '
        'SevenButton
        '
        Me.SevenButton.Enabled = False
        Me.SevenButton.Location = New System.Drawing.Point(19, 87)
        Me.SevenButton.Name = "SevenButton"
        Me.SevenButton.Size = New System.Drawing.Size(41, 32)
        Me.SevenButton.TabIndex = 4
        Me.SevenButton.Text = "7"
        Me.SevenButton.UseVisualStyleBackColor = True
        '
        'NineButton
        '
        Me.NineButton.Enabled = False
        Me.NineButton.Location = New System.Drawing.Point(113, 87)
        Me.NineButton.Name = "NineButton"
        Me.NineButton.Size = New System.Drawing.Size(41, 32)
        Me.NineButton.TabIndex = 3
        Me.NineButton.Text = "9"
        Me.NineButton.UseVisualStyleBackColor = True
        '
        'ZeroButton
        '
        Me.ZeroButton.Enabled = False
        Me.ZeroButton.Location = New System.Drawing.Point(66, 126)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(41, 32)
        Me.ZeroButton.TabIndex = 2
        Me.ZeroButton.Text = "0"
        Me.ZeroButton.UseVisualStyleBackColor = True
        '
        'EightButton
        '
        Me.EightButton.Enabled = False
        Me.EightButton.Location = New System.Drawing.Point(66, 88)
        Me.EightButton.Name = "EightButton"
        Me.EightButton.Size = New System.Drawing.Size(41, 32)
        Me.EightButton.TabIndex = 1
        Me.EightButton.Text = "8"
        Me.EightButton.UseVisualStyleBackColor = True
        '
        'OneButton
        '
        Me.OneButton.Enabled = False
        Me.OneButton.Location = New System.Drawing.Point(19, 12)
        Me.OneButton.Name = "OneButton"
        Me.OneButton.Size = New System.Drawing.Size(41, 32)
        Me.OneButton.TabIndex = 0
        Me.OneButton.Text = "1"
        Me.OneButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.AccountNumCombo)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(27, 443)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 60)
        Me.Panel3.TabIndex = 3
        '
        'AccountNumCombo
        '
        Me.AccountNumCombo.DataSource = Me.ATMTableBindingSource
        Me.AccountNumCombo.DisplayMember = "acctNum"
        Me.AccountNumCombo.FormattingEnabled = True
        Me.AccountNumCombo.Location = New System.Drawing.Point(148, 13)
        Me.AccountNumCombo.Name = "AccountNumCombo"
        Me.AccountNumCombo.Size = New System.Drawing.Size(193, 24)
        Me.AccountNumCombo.TabIndex = 1
        Me.AccountNumCombo.ValueMember = "acctNum"
        '
        'ATMTableBindingSource
        '
        Me.ATMTableBindingSource.DataMember = "ATMTable"
        Me.ATMTableBindingSource.DataSource = Me.NorthwindDataSet
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Number:"
        '
        'ATMTableTableAdapter
        '
        Me.ATMTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ATMTableTableAdapter = Me.ATMTableTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Exercise2.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ATMTableDataGridView
        '
        Me.ATMTableDataGridView.AutoGenerateColumns = False
        Me.ATMTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ATMTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ATMTableDataGridView.DataSource = Me.ATMTableBindingSource
        Me.ATMTableDataGridView.Location = New System.Drawing.Point(18, -32)
        Me.ATMTableDataGridView.Name = "ATMTableDataGridView"
        Me.ATMTableDataGridView.RowTemplate.Height = 24
        Me.ATMTableDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ATMTableDataGridView.TabIndex = 4
        Me.ATMTableDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "acctNum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "acctNum"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "pin"
        Me.DataGridViewTextBoxColumn2.HeaderText = "pin"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "balance"
        Me.DataGridViewTextBoxColumn3.HeaderText = "balance"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmATM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 523)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PinText)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmATM"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ATMTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATMTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HeadsUpLabel As System.Windows.Forms.Label
    Friend WithEvents PinText As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BalanceButton As System.Windows.Forms.Button
    Friend WithEvents DoneButton As System.Windows.Forms.Button
    Friend WithEvents WithdrawButton As System.Windows.Forms.Button
    Friend WithEvents OkayButton As System.Windows.Forms.Button
    Friend WithEvents TwoButton As System.Windows.Forms.Button
    Friend WithEvents ThreeButton As System.Windows.Forms.Button
    Friend WithEvents FourButton As System.Windows.Forms.Button
    Friend WithEvents FiveButton As System.Windows.Forms.Button
    Friend WithEvents SixButton As System.Windows.Forms.Button
    Friend WithEvents SevenButton As System.Windows.Forms.Button
    Friend WithEvents NineButton As System.Windows.Forms.Button
    Friend WithEvents ZeroButton As System.Windows.Forms.Button
    Friend WithEvents EightButton As System.Windows.Forms.Button
    Friend WithEvents OneButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents AccountNumCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NorthwindDataSet As Exercise2.NorthwindDataSet
    Friend WithEvents ATMTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ATMTableTableAdapter As Exercise2.NorthwindDataSetTableAdapters.ATMTableTableAdapter
    Friend WithEvents ATMTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As Exercise2.NorthwindDataSetTableAdapters.TableAdapterManager

End Class
