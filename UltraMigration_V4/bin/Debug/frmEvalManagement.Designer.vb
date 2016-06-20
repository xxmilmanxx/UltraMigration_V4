<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvalManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gpbxFilterContainer = New System.Windows.Forms.GroupBox()
        Me.lblSubType = New System.Windows.Forms.Label()
        Me.cmboSubType = New System.Windows.Forms.ComboBox()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.lblByDate = New System.Windows.Forms.Label()
        Me.lblByType = New System.Windows.Forms.Label()
        Me.lblByEval = New System.Windows.Forms.Label()
        Me.cmboEvaluator = New System.Windows.Forms.ComboBox()
        Me.cmboType = New System.Windows.Forms.ComboBox()
        Me.btnClearFilter = New System.Windows.Forms.Button()
        Me.lblEvalMngmntTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAddEval = New System.Windows.Forms.Button()
        Me.DGVfrmEvalManagement = New System.Windows.Forms.DataGridView()
        Me.txtRecordsCount = New System.Windows.Forms.TextBox()
        Me.EvaluatorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvalTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvalSubTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DogsEnrolledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddEditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QryTblEvaluationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraEvalDataSet = New UltraMigration_V4.UltraEvalDataSet()
        Me.QryTblEvaluationTableAdapter = New UltraMigration_V4.UltraEvalDataSetTableAdapters.qryTblEvaluationTableAdapter()
        Me.TableAdapterManager = New UltraMigration_V4.UltraEvalDataSetTableAdapters.TableAdapterManager()
        Me.FillByEvalNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByEvalNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.gpbxFilterContainer.SuspendLayout()
        CType(Me.DGVfrmEvalManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryTblEvaluationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraEvalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByEvalNameToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbxFilterContainer
        '
        Me.gpbxFilterContainer.Controls.Add(Me.lblSubType)
        Me.gpbxFilterContainer.Controls.Add(Me.cmboSubType)
        Me.gpbxFilterContainer.Controls.Add(Me.DTP1)
        Me.gpbxFilterContainer.Controls.Add(Me.lblByDate)
        Me.gpbxFilterContainer.Controls.Add(Me.lblByType)
        Me.gpbxFilterContainer.Controls.Add(Me.lblByEval)
        Me.gpbxFilterContainer.Controls.Add(Me.cmboEvaluator)
        Me.gpbxFilterContainer.Controls.Add(Me.cmboType)
        Me.gpbxFilterContainer.Controls.Add(Me.btnClearFilter)
        Me.gpbxFilterContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbxFilterContainer.Location = New System.Drawing.Point(72, 232)
        Me.gpbxFilterContainer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpbxFilterContainer.Name = "gpbxFilterContainer"
        Me.gpbxFilterContainer.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpbxFilterContainer.Size = New System.Drawing.Size(1508, 160)
        Me.gpbxFilterContainer.TabIndex = 19
        Me.gpbxFilterContainer.TabStop = False
        Me.gpbxFilterContainer.Text = "FILTER  EVALUATIONS"
        '
        'lblSubType
        '
        Me.lblSubType.AutoSize = True
        Me.lblSubType.Location = New System.Drawing.Point(634, 58)
        Me.lblSubType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubType.Name = "lblSubType"
        Me.lblSubType.Size = New System.Drawing.Size(269, 29)
        Me.lblSubType.TabIndex = 24
        Me.lblSubType.Text = "By Evaluation Sub-Type"
        '
        'cmboSubType
        '
        Me.cmboSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboSubType.DropDownWidth = 200
        Me.cmboSubType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboSubType.FormattingEnabled = True
        Me.cmboSubType.Location = New System.Drawing.Point(640, 91)
        Me.cmboSubType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboSubType.Name = "cmboSubType"
        Me.cmboSubType.Size = New System.Drawing.Size(272, 33)
        Me.cmboSubType.TabIndex = 23
        '
        'DTP1
        '
        Me.DTP1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTP1.CustomFormat = "dd-MMM-yyyy"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(948, 92)
        Me.DTP1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(242, 33)
        Me.DTP1.TabIndex = 22
        Me.DTP1.Value = New Date(2016, 5, 17, 14, 35, 25, 0)
        '
        'lblByDate
        '
        Me.lblByDate.AutoSize = True
        Me.lblByDate.Location = New System.Drawing.Point(944, 58)
        Me.lblByDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblByDate.Name = "lblByDate"
        Me.lblByDate.Size = New System.Drawing.Size(268, 29)
        Me.lblByDate.TabIndex = 21
        Me.lblByDate.Text = "By Evaluation Start Date"
        '
        'lblByType
        '
        Me.lblByType.AutoSize = True
        Me.lblByType.Location = New System.Drawing.Point(332, 58)
        Me.lblByType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblByType.Name = "lblByType"
        Me.lblByType.Size = New System.Drawing.Size(218, 29)
        Me.lblByType.TabIndex = 20
        Me.lblByType.Text = "By Evaluation Type"
        '
        'lblByEval
        '
        Me.lblByEval.AutoSize = True
        Me.lblByEval.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblByEval.Location = New System.Drawing.Point(38, 58)
        Me.lblByEval.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblByEval.Name = "lblByEval"
        Me.lblByEval.Size = New System.Drawing.Size(217, 29)
        Me.lblByEval.TabIndex = 19
        Me.lblByEval.Text = "By Evaluator Name"
        '
        'cmboEvaluator
        '
        Me.cmboEvaluator.DataSource = Me.QryTblEvaluationBindingSource
        Me.cmboEvaluator.DisplayMember = "Evaluator Name"
        Me.cmboEvaluator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboEvaluator.DropDownWidth = 200
        Me.cmboEvaluator.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboEvaluator.FormattingEnabled = True
        Me.cmboEvaluator.Location = New System.Drawing.Point(28, 91)
        Me.cmboEvaluator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboEvaluator.MaxDropDownItems = 15
        Me.cmboEvaluator.Name = "cmboEvaluator"
        Me.cmboEvaluator.Size = New System.Drawing.Size(272, 33)
        Me.cmboEvaluator.TabIndex = 5
        Me.cmboEvaluator.TabStop = False
        '
        'cmboType
        '
        Me.cmboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboType.DropDownWidth = 200
        Me.cmboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboType.FormattingEnabled = True
        Me.cmboType.Location = New System.Drawing.Point(338, 92)
        Me.cmboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboType.Name = "cmboType"
        Me.cmboType.Size = New System.Drawing.Size(272, 33)
        Me.cmboType.TabIndex = 6
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFilter.ForeColor = System.Drawing.Color.Navy
        Me.btnClearFilter.Location = New System.Drawing.Point(1280, 69)
        Me.btnClearFilter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(183, 54)
        Me.btnClearFilter.TabIndex = 12
        Me.btnClearFilter.Text = "&Clear Filter"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'lblEvalMngmntTitle
        '
        Me.lblEvalMngmntTitle.AutoSize = True
        Me.lblEvalMngmntTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblEvalMngmntTitle.Location = New System.Drawing.Point(64, 111)
        Me.lblEvalMngmntTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvalMngmntTitle.Name = "lblEvalMngmntTitle"
        Me.lblEvalMngmntTitle.Size = New System.Drawing.Size(405, 40)
        Me.lblEvalMngmntTitle.TabIndex = 18
        Me.lblEvalMngmntTitle.Text = "Evaluation Management"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1282, 89)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(192, 62)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddEval
        '
        Me.btnAddEval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEval.Location = New System.Drawing.Point(992, 89)
        Me.btnAddEval.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddEval.Name = "btnAddEval"
        Me.btnAddEval.Size = New System.Drawing.Size(192, 62)
        Me.btnAddEval.TabIndex = 20
        Me.btnAddEval.Text = "&Add Eval"
        Me.btnAddEval.UseVisualStyleBackColor = True
        '
        'DGVfrmEvalManagement
        '
        Me.DGVfrmEvalManagement.AllowUserToAddRows = False
        Me.DGVfrmEvalManagement.AllowUserToDeleteRows = False
        Me.DGVfrmEvalManagement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVfrmEvalManagement.AutoGenerateColumns = False
        Me.DGVfrmEvalManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVfrmEvalManagement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EvaluatorNameDataGridViewTextBoxColumn, Me.EvalTypeDataGridViewTextBoxColumn, Me.EvalSubTypeDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.DogsEnrolledDataGridViewTextBoxColumn, Me.AddEditDataGridViewTextBoxColumn, Me.DetailsDataGridViewTextBoxColumn})
        Me.DGVfrmEvalManagement.DataSource = Me.QryTblEvaluationBindingSource
        Me.DGVfrmEvalManagement.Location = New System.Drawing.Point(72, 423)
        Me.DGVfrmEvalManagement.Name = "DGVfrmEvalManagement"
        Me.DGVfrmEvalManagement.ReadOnly = True
        Me.DGVfrmEvalManagement.RowTemplate.Height = 28
        Me.DGVfrmEvalManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVfrmEvalManagement.Size = New System.Drawing.Size(1508, 635)
        Me.DGVfrmEvalManagement.TabIndex = 22
        '
        'txtRecordsCount
        '
        Me.txtRecordsCount.AcceptsReturn = True
        Me.txtRecordsCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecordsCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecordsCount.Location = New System.Drawing.Point(944, 186)
        Me.txtRecordsCount.Margin = New System.Windows.Forms.Padding(15)
        Me.txtRecordsCount.Name = "txtRecordsCount"
        Me.txtRecordsCount.ReadOnly = True
        Me.txtRecordsCount.ShortcutsEnabled = False
        Me.txtRecordsCount.Size = New System.Drawing.Size(452, 26)
        Me.txtRecordsCount.TabIndex = 23
        Me.txtRecordsCount.TabStop = False
        Me.txtRecordsCount.WordWrap = False
        '
        'EvaluatorNameDataGridViewTextBoxColumn
        '
        Me.EvaluatorNameDataGridViewTextBoxColumn.DataPropertyName = "Evaluator Name"
        Me.EvaluatorNameDataGridViewTextBoxColumn.HeaderText = "Evaluator Name"
        Me.EvaluatorNameDataGridViewTextBoxColumn.Name = "EvaluatorNameDataGridViewTextBoxColumn"
        Me.EvaluatorNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EvalTypeDataGridViewTextBoxColumn
        '
        Me.EvalTypeDataGridViewTextBoxColumn.DataPropertyName = "Eval Type"
        Me.EvalTypeDataGridViewTextBoxColumn.HeaderText = "Eval Type"
        Me.EvalTypeDataGridViewTextBoxColumn.Name = "EvalTypeDataGridViewTextBoxColumn"
        Me.EvalTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EvalSubTypeDataGridViewTextBoxColumn
        '
        Me.EvalSubTypeDataGridViewTextBoxColumn.DataPropertyName = "Eval Sub-Type"
        Me.EvalSubTypeDataGridViewTextBoxColumn.HeaderText = "Eval Sub-Type"
        Me.EvalSubTypeDataGridViewTextBoxColumn.Name = "EvalSubTypeDataGridViewTextBoxColumn"
        Me.EvalSubTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        Me.StartDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "End Date"
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "End Date"
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        Me.EndDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DogsEnrolledDataGridViewTextBoxColumn
        '
        Me.DogsEnrolledDataGridViewTextBoxColumn.DataPropertyName = "Dogs Enrolled"
        Me.DogsEnrolledDataGridViewTextBoxColumn.HeaderText = "Dogs Enrolled"
        Me.DogsEnrolledDataGridViewTextBoxColumn.Name = "DogsEnrolledDataGridViewTextBoxColumn"
        Me.DogsEnrolledDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddEditDataGridViewTextBoxColumn
        '
        Me.AddEditDataGridViewTextBoxColumn.DataPropertyName = "AddEdit"
        Me.AddEditDataGridViewTextBoxColumn.HeaderText = "AddEdit"
        Me.AddEditDataGridViewTextBoxColumn.Name = "AddEditDataGridViewTextBoxColumn"
        Me.AddEditDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetailsDataGridViewTextBoxColumn
        '
        Me.DetailsDataGridViewTextBoxColumn.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn.Name = "DetailsDataGridViewTextBoxColumn"
        Me.DetailsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QryTblEvaluationBindingSource
        '
        Me.QryTblEvaluationBindingSource.DataMember = "qryTblEvaluation"
        Me.QryTblEvaluationBindingSource.DataSource = Me.UltraEvalDataSet
        '
        'UltraEvalDataSet
        '
        Me.UltraEvalDataSet.DataSetName = "UltraEvalDataSet"
        Me.UltraEvalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QryTblEvaluationTableAdapter
        '
        Me.QryTblEvaluationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = UltraMigration_V4.UltraEvalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FillByEvalNameToolStrip
        '
        Me.FillByEvalNameToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillByEvalNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByEvalNameToolStripButton})
        Me.FillByEvalNameToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByEvalNameToolStrip.Name = "FillByEvalNameToolStrip"
        Me.FillByEvalNameToolStrip.Size = New System.Drawing.Size(1654, 32)
        Me.FillByEvalNameToolStrip.TabIndex = 24
        Me.FillByEvalNameToolStrip.Text = "FillByEvalNameToolStrip"
        '
        'FillByEvalNameToolStripButton
        '
        Me.FillByEvalNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByEvalNameToolStripButton.Name = "FillByEvalNameToolStripButton"
        Me.FillByEvalNameToolStripButton.Size = New System.Drawing.Size(23, 23)
        Me.FillByEvalNameToolStripButton.Text = "FillByEvalName"
        '
        'frmEvalManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1654, 1075)
        Me.Controls.Add(Me.FillByEvalNameToolStrip)
        Me.Controls.Add(Me.txtRecordsCount)
        Me.Controls.Add(Me.DGVfrmEvalManagement)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddEval)
        Me.Controls.Add(Me.gpbxFilterContainer)
        Me.Controls.Add(Me.lblEvalMngmntTitle)
        Me.Name = "frmEvalManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluation Management"
        Me.gpbxFilterContainer.ResumeLayout(False)
        Me.gpbxFilterContainer.PerformLayout()
        CType(Me.DGVfrmEvalManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryTblEvaluationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraEvalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByEvalNameToolStrip.ResumeLayout(False)
        Me.FillByEvalNameToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbxFilterContainer As GroupBox
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents lblByDate As Label
    Friend WithEvents lblByType As Label
    Friend WithEvents lblByEval As Label
    Friend WithEvents cmboEvaluator As ComboBox
    Friend WithEvents cmboType As ComboBox
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents lblEvalMngmntTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddEval As Button
    Friend WithEvents DGVfrmEvalManagement As DataGridView
    Friend WithEvents txtRecordsCount As TextBox
    Friend WithEvents lblSubType As Label
    Friend WithEvents cmboSubType As ComboBox
    Friend WithEvents UltraEvalDataSet As UltraEvalDataSet
    Friend WithEvents QryTblEvaluationBindingSource As BindingSource
    Friend WithEvents QryTblEvaluationTableAdapter As UltraEvalDataSetTableAdapters.qryTblEvaluationTableAdapter
    Friend WithEvents TableAdapterManager As UltraEvalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EvaluatorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EvalTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EvalSubTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DogsEnrolledDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddEditDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FillByEvalNameToolStrip As ToolStrip
    Friend WithEvents FillByEvalNameToolStripButton As ToolStripButton
End Class
