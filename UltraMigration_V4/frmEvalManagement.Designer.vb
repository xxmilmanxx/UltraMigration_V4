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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gpbxFilterContainer = New System.Windows.Forms.GroupBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
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
        Me.EvaluatorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvaluationTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DogsEnrolledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddEditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DogEvalsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.QryTblEvaluationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ultra_DataDataSet = New UltraMigration_V4.Ultra_DataDataSet()
        Me.txtRecordsCount = New System.Windows.Forms.TextBox()
        Me.QryTblEvaluationsTableAdapter = New UltraMigration_V4.Ultra_DataDataSetTableAdapters.qryTblEvaluationsTableAdapter()
        Me.TableAdapterManager = New UltraMigration_V4.Ultra_DataDataSetTableAdapters.TableAdapterManager()
        Me.gpbxFilterContainer.SuspendLayout()
        CType(Me.DGVfrmEvalManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryTblEvaluationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ultra_DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbxFilterContainer
        '
        Me.gpbxFilterContainer.Controls.Add(Me.dtpEnd)
        Me.gpbxFilterContainer.Controls.Add(Me.lblEndDate)
        Me.gpbxFilterContainer.Controls.Add(Me.dtpStart)
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
        'dtpEnd
        '
        Me.dtpEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEnd.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(949, 92)
        Me.dtpEnd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(238, 30)
        Me.dtpEnd.TabIndex = 25
        Me.dtpEnd.Value = New Date(2016, 5, 17, 0, 0, 0, 0)
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(944, 58)
        Me.lblEndDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(262, 29)
        Me.lblEndDate.TabIndex = 24
        Me.lblEndDate.Text = "By Evaluation End Date"
        '
        'dtpStart
        '
        Me.dtpStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStart.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(648, 92)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(263, 30)
        Me.dtpStart.TabIndex = 22
        Me.dtpStart.TabStop = False
        Me.dtpStart.Value = New Date(2016, 5, 17, 0, 0, 0, 0)
        '
        'lblByDate
        '
        Me.lblByDate.AutoSize = True
        Me.lblByDate.Location = New System.Drawing.Point(643, 58)
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
        Me.lblByEval.Location = New System.Drawing.Point(23, 58)
        Me.lblByEval.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblByEval.Name = "lblByEval"
        Me.lblByEval.Size = New System.Drawing.Size(217, 29)
        Me.lblByEval.TabIndex = 19
        Me.lblByEval.Text = "By Evaluator Name"
        '
        'cmboEvaluator
        '
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
        Me.DGVfrmEvalManagement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EvaluatorNameDataGridViewTextBoxColumn, Me.EvaluationTypeDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.DogsEnrolledDataGridViewTextBoxColumn, Me.AddEditDataGridViewTextBoxColumn, Me.DogEvalsDataGridViewTextBoxColumn})
        Me.DGVfrmEvalManagement.DataSource = Me.QryTblEvaluationsBindingSource
        Me.DGVfrmEvalManagement.Location = New System.Drawing.Point(72, 423)
        Me.DGVfrmEvalManagement.Name = "DGVfrmEvalManagement"
        Me.DGVfrmEvalManagement.ReadOnly = True
        Me.DGVfrmEvalManagement.RowTemplate.Height = 28
        Me.DGVfrmEvalManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVfrmEvalManagement.Size = New System.Drawing.Size(1508, 635)
        Me.DGVfrmEvalManagement.TabIndex = 22
        '
        'EvaluatorNameDataGridViewTextBoxColumn
        '
        Me.EvaluatorNameDataGridViewTextBoxColumn.DataPropertyName = "Evaluator Name"
        Me.EvaluatorNameDataGridViewTextBoxColumn.HeaderText = "Evaluator Name"
        Me.EvaluatorNameDataGridViewTextBoxColumn.Name = "EvaluatorNameDataGridViewTextBoxColumn"
        Me.EvaluatorNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EvaluationTypeDataGridViewTextBoxColumn
        '
        Me.EvaluationTypeDataGridViewTextBoxColumn.DataPropertyName = "Evaluation Type"
        Me.EvaluationTypeDataGridViewTextBoxColumn.HeaderText = "Evaluation Type"
        Me.EvaluationTypeDataGridViewTextBoxColumn.Name = "EvaluationTypeDataGridViewTextBoxColumn"
        Me.EvaluationTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "Start Date"
        DataGridViewCellStyle1.Format = "dd-MMM-yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.StartDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        Me.StartDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "End Date"
        DataGridViewCellStyle2.Format = "dd-MMM-yyyy"
        Me.EndDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.AddEditDataGridViewTextBoxColumn.ActiveLinkColor = System.Drawing.Color.White
        Me.AddEditDataGridViewTextBoxColumn.DataPropertyName = "AddEdit"
        Me.AddEditDataGridViewTextBoxColumn.HeaderText = "AddEdit"
        Me.AddEditDataGridViewTextBoxColumn.LinkColor = System.Drawing.Color.Blue
        Me.AddEditDataGridViewTextBoxColumn.Name = "AddEditDataGridViewTextBoxColumn"
        Me.AddEditDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddEditDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddEditDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AddEditDataGridViewTextBoxColumn.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'DogEvalsDataGridViewTextBoxColumn
        '
        Me.DogEvalsDataGridViewTextBoxColumn.ActiveLinkColor = System.Drawing.Color.White
        Me.DogEvalsDataGridViewTextBoxColumn.DataPropertyName = "Dog Evals"
        Me.DogEvalsDataGridViewTextBoxColumn.HeaderText = "Dog Evals"
        Me.DogEvalsDataGridViewTextBoxColumn.LinkColor = System.Drawing.Color.Blue
        Me.DogEvalsDataGridViewTextBoxColumn.Name = "DogEvalsDataGridViewTextBoxColumn"
        Me.DogEvalsDataGridViewTextBoxColumn.ReadOnly = True
        Me.DogEvalsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DogEvalsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DogEvalsDataGridViewTextBoxColumn.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'QryTblEvaluationsBindingSource
        '
        Me.QryTblEvaluationsBindingSource.DataMember = "qryTblEvaluations"
        Me.QryTblEvaluationsBindingSource.DataSource = Me.Ultra_DataDataSet
        '
        'Ultra_DataDataSet
        '
        Me.Ultra_DataDataSet.DataSetName = "Ultra_DataDataSet"
        Me.Ultra_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'QryTblEvaluationsTableAdapter
        '
        Me.QryTblEvaluationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = UltraMigration_V4.Ultra_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmEvalManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1654, 1075)
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
        CType(Me.QryTblEvaluationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ultra_DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbxFilterContainer As GroupBox
    Friend WithEvents dtpStart As DateTimePicker
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
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents Ultra_DataDataSet As Ultra_DataDataSet
    Friend WithEvents QryTblEvaluationsBindingSource As BindingSource
    Friend WithEvents QryTblEvaluationsTableAdapter As Ultra_DataDataSetTableAdapters.qryTblEvaluationsTableAdapter
    Friend WithEvents TableAdapterManager As Ultra_DataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EvaluatorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EvaluationTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DogsEnrolledDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddEditDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents DogEvalsDataGridViewTextBoxColumn As DataGridViewLinkColumn
End Class
