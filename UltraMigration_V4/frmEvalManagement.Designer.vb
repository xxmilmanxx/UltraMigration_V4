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
        Me.gpbxFilterContainer = New System.Windows.Forms.GroupBox()
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
        Me.lblSubType = New System.Windows.Forms.Label()
        Me.cmboSubType = New System.Windows.Forms.ComboBox()
        Me.gpbxFilterContainer.SuspendLayout()
        CType(Me.DGVfrmEvalManagement, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gpbxFilterContainer.Size = New System.Drawing.Size(1508, 155)
        Me.gpbxFilterContainer.TabIndex = 19
        Me.gpbxFilterContainer.TabStop = False
        Me.gpbxFilterContainer.Text = "FILTER  EVALUATIONS"
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
        Me.lblByDate.Location = New System.Drawing.Point(943, 58)
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
        Me.cmboType.Location = New System.Drawing.Point(337, 92)
        Me.cmboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboType.Name = "cmboType"
        Me.cmboType.Size = New System.Drawing.Size(272, 33)
        Me.cmboType.TabIndex = 6
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFilter.ForeColor = System.Drawing.Color.Navy
        Me.btnClearFilter.Location = New System.Drawing.Point(1279, 70)
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
        Me.btnAddEval.Location = New System.Drawing.Point(991, 89)
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
        Me.DGVfrmEvalManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVfrmEvalManagement.Location = New System.Drawing.Point(72, 529)
        Me.DGVfrmEvalManagement.Name = "DGVfrmEvalManagement"
        Me.DGVfrmEvalManagement.ReadOnly = True
        Me.DGVfrmEvalManagement.RowTemplate.Height = 28
        Me.DGVfrmEvalManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVfrmEvalManagement.Size = New System.Drawing.Size(1508, 725)
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
        Me.txtRecordsCount.Size = New System.Drawing.Size(451, 26)
        Me.txtRecordsCount.TabIndex = 23
        Me.txtRecordsCount.TabStop = False
        Me.txtRecordsCount.WordWrap = False
        '
        'lblSubType
        '
        Me.lblSubType.AutoSize = True
        Me.lblSubType.Location = New System.Drawing.Point(635, 58)
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
        'frmEvalManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1655, 1290)
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
End Class
