<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvaluation
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
        Me.pnlNewEval = New System.Windows.Forms.Panel()
        Me.btnViewAidsArea = New System.Windows.Forms.Button()
        Me.btnEvalResults = New System.Windows.Forms.Button()
        Me.btnAddDogs = New System.Windows.Forms.Button()
        Me.btnClearNewEval = New System.Windows.Forms.Button()
        Me.btnCancelNewEval = New System.Windows.Forms.Button()
        Me.btnSaveNewEval = New System.Windows.Forms.Button()
        Me.cmboAddEvalStatus = New System.Windows.Forms.ComboBox()
        Me.cmboAddEvalSubType = New System.Windows.Forms.ComboBox()
        Me.cmboAddEvaluator = New System.Windows.Forms.ComboBox()
        Me.cmboAddEvalType = New System.Windows.Forms.ComboBox()
        Me.dtpAddEvalDateEnded = New System.Windows.Forms.DateTimePicker()
        Me.dtpAddEvalDateStarted = New System.Windows.Forms.DateTimePicker()
        Me.lblEvalEvalStatus = New System.Windows.Forms.Label()
        Me.lblEvalDateEnd = New System.Windows.Forms.Label()
        Me.lblEvalEvalSubType = New System.Windows.Forms.Label()
        Me.lblEvalEvaluator = New System.Windows.Forms.Label()
        Me.lblEvalDateStart = New System.Windows.Forms.Label()
        Me.lblEvalType = New System.Windows.Forms.Label()
        Me.lblNewEvalTitle = New System.Windows.Forms.Label()
        Me.sfrmEvaluationDogIndex = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Ultra_DataDataSet = New UltraMigration_V4.Ultra_DataDataSet()
        Me.pnlNewEval.SuspendLayout()
        Me.sfrmEvaluationDogIndex.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ultra_DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlNewEval
        '
        Me.pnlNewEval.Controls.Add(Me.btnViewAidsArea)
        Me.pnlNewEval.Controls.Add(Me.btnEvalResults)
        Me.pnlNewEval.Controls.Add(Me.btnAddDogs)
        Me.pnlNewEval.Controls.Add(Me.btnClearNewEval)
        Me.pnlNewEval.Controls.Add(Me.btnCancelNewEval)
        Me.pnlNewEval.Controls.Add(Me.btnSaveNewEval)
        Me.pnlNewEval.Controls.Add(Me.cmboAddEvalStatus)
        Me.pnlNewEval.Controls.Add(Me.cmboAddEvalSubType)
        Me.pnlNewEval.Controls.Add(Me.cmboAddEvaluator)
        Me.pnlNewEval.Controls.Add(Me.cmboAddEvalType)
        Me.pnlNewEval.Controls.Add(Me.dtpAddEvalDateEnded)
        Me.pnlNewEval.Controls.Add(Me.dtpAddEvalDateStarted)
        Me.pnlNewEval.Controls.Add(Me.lblEvalEvalStatus)
        Me.pnlNewEval.Controls.Add(Me.lblEvalDateEnd)
        Me.pnlNewEval.Controls.Add(Me.lblEvalEvalSubType)
        Me.pnlNewEval.Controls.Add(Me.lblEvalEvaluator)
        Me.pnlNewEval.Controls.Add(Me.lblEvalDateStart)
        Me.pnlNewEval.Controls.Add(Me.lblEvalType)
        Me.pnlNewEval.Location = New System.Drawing.Point(273, 122)
        Me.pnlNewEval.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlNewEval.Name = "pnlNewEval"
        Me.pnlNewEval.Size = New System.Drawing.Size(1250, 554)
        Me.pnlNewEval.TabIndex = 4
        '
        'btnViewAidsArea
        '
        Me.btnViewAidsArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAidsArea.Location = New System.Drawing.Point(430, 429)
        Me.btnViewAidsArea.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnViewAidsArea.Name = "btnViewAidsArea"
        Me.btnViewAidsArea.Size = New System.Drawing.Size(192, 75)
        Me.btnViewAidsArea.TabIndex = 18
        Me.btnViewAidsArea.Text = "View Aids by Area"
        Me.btnViewAidsArea.UseVisualStyleBackColor = True
        '
        'btnEvalResults
        '
        Me.btnEvalResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvalResults.Location = New System.Drawing.Point(684, 429)
        Me.btnEvalResults.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEvalResults.Name = "btnEvalResults"
        Me.btnEvalResults.Size = New System.Drawing.Size(192, 75)
        Me.btnEvalResults.TabIndex = 17
        Me.btnEvalResults.Text = "View Eval Results"
        Me.btnEvalResults.UseVisualStyleBackColor = True
        '
        'btnAddDogs
        '
        Me.btnAddDogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDogs.Location = New System.Drawing.Point(939, 429)
        Me.btnAddDogs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddDogs.Name = "btnAddDogs"
        Me.btnAddDogs.Size = New System.Drawing.Size(192, 75)
        Me.btnAddDogs.TabIndex = 16
        Me.btnAddDogs.Text = "Add Dogs"
        Me.btnAddDogs.UseVisualStyleBackColor = True
        '
        'btnClearNewEval
        '
        Me.btnClearNewEval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearNewEval.Location = New System.Drawing.Point(430, 304)
        Me.btnClearNewEval.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClearNewEval.Name = "btnClearNewEval"
        Me.btnClearNewEval.Size = New System.Drawing.Size(192, 75)
        Me.btnClearNewEval.TabIndex = 15
        Me.btnClearNewEval.Text = "Clear"
        Me.btnClearNewEval.UseVisualStyleBackColor = True
        '
        'btnCancelNewEval
        '
        Me.btnCancelNewEval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelNewEval.Location = New System.Drawing.Point(684, 304)
        Me.btnCancelNewEval.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelNewEval.Name = "btnCancelNewEval"
        Me.btnCancelNewEval.Size = New System.Drawing.Size(192, 75)
        Me.btnCancelNewEval.TabIndex = 14
        Me.btnCancelNewEval.Text = "&Cancel"
        Me.btnCancelNewEval.UseVisualStyleBackColor = True
        '
        'btnSaveNewEval
        '
        Me.btnSaveNewEval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNewEval.Location = New System.Drawing.Point(939, 304)
        Me.btnSaveNewEval.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSaveNewEval.Name = "btnSaveNewEval"
        Me.btnSaveNewEval.Size = New System.Drawing.Size(192, 75)
        Me.btnSaveNewEval.TabIndex = 13
        Me.btnSaveNewEval.Text = "&Save"
        Me.btnSaveNewEval.UseVisualStyleBackColor = True
        '
        'cmboAddEvalStatus
        '
        Me.cmboAddEvalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboAddEvalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboAddEvalStatus.FormattingEnabled = True
        Me.cmboAddEvalStatus.Items.AddRange(New Object() {"In Progress", "Complete"})
        Me.cmboAddEvalStatus.Location = New System.Drawing.Point(826, 192)
        Me.cmboAddEvalStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboAddEvalStatus.Name = "cmboAddEvalStatus"
        Me.cmboAddEvalStatus.Size = New System.Drawing.Size(360, 33)
        Me.cmboAddEvalStatus.TabIndex = 11
        '
        'cmboAddEvalSubType
        '
        Me.cmboAddEvalSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboAddEvalSubType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboAddEvalSubType.FormattingEnabled = True
        Me.cmboAddEvalSubType.Location = New System.Drawing.Point(826, 49)
        Me.cmboAddEvalSubType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboAddEvalSubType.Name = "cmboAddEvalSubType"
        Me.cmboAddEvalSubType.Size = New System.Drawing.Size(360, 33)
        Me.cmboAddEvalSubType.TabIndex = 10
        '
        'cmboAddEvaluator
        '
        Me.cmboAddEvaluator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboAddEvaluator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboAddEvaluator.FormattingEnabled = True
        Me.cmboAddEvaluator.Location = New System.Drawing.Point(241, 188)
        Me.cmboAddEvaluator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboAddEvaluator.Name = "cmboAddEvaluator"
        Me.cmboAddEvaluator.Size = New System.Drawing.Size(360, 33)
        Me.cmboAddEvaluator.TabIndex = 9
        '
        'cmboAddEvalType
        '
        Me.cmboAddEvalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboAddEvalType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboAddEvalType.FormattingEnabled = True
        Me.cmboAddEvalType.Location = New System.Drawing.Point(241, 45)
        Me.cmboAddEvalType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboAddEvalType.Name = "cmboAddEvalType"
        Me.cmboAddEvalType.Size = New System.Drawing.Size(360, 33)
        Me.cmboAddEvalType.TabIndex = 8
        '
        'dtpAddEvalDateEnded
        '
        Me.dtpAddEvalDateEnded.CustomFormat = "dd-MMM-yyyy"
        Me.dtpAddEvalDateEnded.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAddEvalDateEnded.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAddEvalDateEnded.Location = New System.Drawing.Point(826, 122)
        Me.dtpAddEvalDateEnded.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpAddEvalDateEnded.Name = "dtpAddEvalDateEnded"
        Me.dtpAddEvalDateEnded.Size = New System.Drawing.Size(360, 30)
        Me.dtpAddEvalDateEnded.TabIndex = 7
        Me.dtpAddEvalDateEnded.Value = New Date(2016, 3, 23, 0, 0, 0, 0)
        '
        'dtpAddEvalDateStarted
        '
        Me.dtpAddEvalDateStarted.CustomFormat = "dd-MMM-yyyy"
        Me.dtpAddEvalDateStarted.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAddEvalDateStarted.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAddEvalDateStarted.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.dtpAddEvalDateStarted.Location = New System.Drawing.Point(242, 117)
        Me.dtpAddEvalDateStarted.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpAddEvalDateStarted.Name = "dtpAddEvalDateStarted"
        Me.dtpAddEvalDateStarted.Size = New System.Drawing.Size(358, 30)
        Me.dtpAddEvalDateStarted.TabIndex = 6
        Me.dtpAddEvalDateStarted.Value = New Date(2016, 3, 23, 0, 0, 0, 0)
        '
        'lblEvalEvalStatus
        '
        Me.lblEvalEvalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalEvalStatus.Location = New System.Drawing.Point(636, 183)
        Me.lblEvalEvalStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvalEvalStatus.Name = "lblEvalEvalStatus"
        Me.lblEvalEvalStatus.Size = New System.Drawing.Size(182, 48)
        Me.lblEvalEvalStatus.TabIndex = 5
        Me.lblEvalEvalStatus.Text = "Eval Status:"
        Me.lblEvalEvalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEvalDateEnd
        '
        Me.lblEvalDateEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalDateEnd.Location = New System.Drawing.Point(642, 112)
        Me.lblEvalDateEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvalDateEnd.Name = "lblEvalDateEnd"
        Me.lblEvalDateEnd.Size = New System.Drawing.Size(176, 46)
        Me.lblEvalDateEnd.TabIndex = 4
        Me.lblEvalDateEnd.Text = "Date Ended:"
        Me.lblEvalDateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEvalEvalSubType
        '
        Me.lblEvalEvalSubType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalEvalSubType.Location = New System.Drawing.Point(612, 52)
        Me.lblEvalEvalSubType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvalEvalSubType.Name = "lblEvalEvalSubType"
        Me.lblEvalEvalSubType.Size = New System.Drawing.Size(206, 35)
        Me.lblEvalEvalSubType.TabIndex = 3
        Me.lblEvalEvalSubType.Text = "Eval Sub Type:"
        Me.lblEvalEvalSubType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEvalEvaluator
        '
        Me.lblEvalEvaluator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalEvaluator.Location = New System.Drawing.Point(20, 183)
        Me.lblEvalEvaluator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvalEvaluator.Name = "lblEvalEvaluator"
        Me.lblEvalEvaluator.Size = New System.Drawing.Size(212, 48)
        Me.lblEvalEvaluator.TabIndex = 2
        Me.lblEvalEvaluator.Text = "Evaluator:"
        Me.lblEvalEvaluator.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEvalDateStart
        '
        Me.lblEvalDateStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEvalDateStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalDateStart.Location = New System.Drawing.Point(20, 112)
        Me.lblEvalDateStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvalDateStart.Name = "lblEvalDateStart"
        Me.lblEvalDateStart.Size = New System.Drawing.Size(212, 46)
        Me.lblEvalDateStart.TabIndex = 1
        Me.lblEvalDateStart.Text = "Date Started:"
        Me.lblEvalDateStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEvalType
        '
        Me.lblEvalType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalType.Location = New System.Drawing.Point(20, 52)
        Me.lblEvalType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvalType.Name = "lblEvalType"
        Me.lblEvalType.Size = New System.Drawing.Size(212, 35)
        Me.lblEvalType.TabIndex = 0
        Me.lblEvalType.Text = "Evaluation Type:"
        Me.lblEvalType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNewEvalTitle
        '
        Me.lblNewEvalTitle.AutoSize = True
        Me.lblNewEvalTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewEvalTitle.Location = New System.Drawing.Point(23, 45)
        Me.lblNewEvalTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewEvalTitle.Name = "lblNewEvalTitle"
        Me.lblNewEvalTitle.Size = New System.Drawing.Size(363, 40)
        Me.lblNewEvalTitle.TabIndex = 3
        Me.lblNewEvalTitle.Text = "Enter New Evaluation"
        '
        'sfrmEvaluationDogIndex
        '
        Me.sfrmEvaluationDogIndex.Controls.Add(Me.DataGridView1)
        Me.sfrmEvaluationDogIndex.Location = New System.Drawing.Point(65, 727)
        Me.sfrmEvaluationDogIndex.Name = "sfrmEvaluationDogIndex"
        Me.sfrmEvaluationDogIndex.Size = New System.Drawing.Size(1801, 583)
        Me.sfrmEvaluationDogIndex.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1432, 447)
        Me.DataGridView1.TabIndex = 0
        '
        'Ultra_DataDataSet
        '
        Me.Ultra_DataDataSet.DataSetName = "Ultra_DataDataSet"
        Me.Ultra_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmEvaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1940, 1325)
        Me.Controls.Add(Me.sfrmEvaluationDogIndex)
        Me.Controls.Add(Me.pnlNewEval)
        Me.Controls.Add(Me.lblNewEvalTitle)
        Me.Name = "frmEvaluation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluation"
        Me.pnlNewEval.ResumeLayout(False)
        Me.sfrmEvaluationDogIndex.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ultra_DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlNewEval As Panel
    Friend WithEvents btnCancelNewEval As Button
    Friend WithEvents btnSaveNewEval As Button
    Friend WithEvents cmboAddEvalStatus As ComboBox
    Friend WithEvents cmboAddEvalSubType As ComboBox
    Friend WithEvents cmboAddEvaluator As ComboBox
    Friend WithEvents cmboAddEvalType As ComboBox
    Friend WithEvents dtpAddEvalDateEnded As DateTimePicker
    Friend WithEvents dtpAddEvalDateStarted As DateTimePicker
    Friend WithEvents lblEvalEvalStatus As Label
    Friend WithEvents lblEvalDateEnd As Label
    Friend WithEvents lblEvalEvalSubType As Label
    Friend WithEvents lblEvalEvaluator As Label
    Friend WithEvents lblEvalDateStart As Label
    Friend WithEvents lblEvalType As Label
    Friend WithEvents lblNewEvalTitle As Label
    Friend WithEvents btnClearNewEval As Button
    Friend WithEvents btnAddDogs As Button
    Friend WithEvents sfrmEvaluationDogIndex As Panel
    Friend WithEvents btnViewAidsArea As Button
    Friend WithEvents btnEvalResults As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Ultra_DataDataSet As Ultra_DataDataSet
End Class
