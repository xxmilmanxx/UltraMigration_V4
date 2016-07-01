<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewEval
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
        Me.btnAddDogs = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
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
        Me.pnlNewEval.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlNewEval
        '
        Me.pnlNewEval.Controls.Add(Me.btnAddDogs)
        Me.pnlNewEval.Controls.Add(Me.btnClear)
        Me.pnlNewEval.Controls.Add(Me.btnCancel)
        Me.pnlNewEval.Controls.Add(Me.btnSave)
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
        Me.pnlNewEval.Location = New System.Drawing.Point(30, 165)
        Me.pnlNewEval.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlNewEval.Name = "pnlNewEval"
        Me.pnlNewEval.Size = New System.Drawing.Size(1418, 709)
        Me.pnlNewEval.TabIndex = 4
        '
        'btnAddDogs
        '
        Me.btnAddDogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDogs.Location = New System.Drawing.Point(814, 555)
        Me.btnAddDogs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddDogs.Name = "btnAddDogs"
        Me.btnAddDogs.Size = New System.Drawing.Size(188, 82)
        Me.btnAddDogs.TabIndex = 16
        Me.btnAddDogs.Text = "Add Dogs"
        Me.btnAddDogs.UseVisualStyleBackColor = True
        Me.btnAddDogs.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(814, 414)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(188, 82)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1068, 414)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(188, 82)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1068, 555)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(188, 82)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'cmboAddEvalStatus
        '
        Me.cmboAddEvalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboAddEvalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboAddEvalStatus.FormattingEnabled = True
        Me.cmboAddEvalStatus.Items.AddRange(New Object() {"In Progress", "Complete"})
        Me.cmboAddEvalStatus.Location = New System.Drawing.Point(894, 272)
        Me.cmboAddEvalStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboAddEvalStatus.Name = "cmboAddEvalStatus"
        Me.cmboAddEvalStatus.Size = New System.Drawing.Size(360, 37)
        Me.cmboAddEvalStatus.TabIndex = 11
        '
        'cmboAddEvalSubType
        '
        Me.cmboAddEvalSubType.DisplayMember = "bcs_BehaviorChecklistText"
        Me.cmboAddEvalSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboAddEvalSubType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboAddEvalSubType.FormattingEnabled = True
        Me.cmboAddEvalSubType.Location = New System.Drawing.Point(894, 129)
        Me.cmboAddEvalSubType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboAddEvalSubType.Name = "cmboAddEvalSubType"
        Me.cmboAddEvalSubType.Size = New System.Drawing.Size(360, 37)
        Me.cmboAddEvalSubType.TabIndex = 10
        Me.cmboAddEvalSubType.ValueMember = "bcs_BehaviorChecklistText"
        '
        'cmboAddEvaluator
        '
        Me.cmboAddEvaluator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboAddEvaluator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboAddEvaluator.FormattingEnabled = True
        Me.cmboAddEvaluator.Location = New System.Drawing.Point(309, 268)
        Me.cmboAddEvaluator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboAddEvaluator.Name = "cmboAddEvaluator"
        Me.cmboAddEvaluator.Size = New System.Drawing.Size(360, 37)
        Me.cmboAddEvaluator.TabIndex = 9
        '
        'cmboAddEvalType
        '
        Me.cmboAddEvalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboAddEvalType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboAddEvalType.FormattingEnabled = True
        Me.cmboAddEvalType.Location = New System.Drawing.Point(309, 125)
        Me.cmboAddEvalType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboAddEvalType.Name = "cmboAddEvalType"
        Me.cmboAddEvalType.Size = New System.Drawing.Size(360, 37)
        Me.cmboAddEvalType.TabIndex = 8
        '
        'dtpAddEvalDateEnded
        '
        Me.dtpAddEvalDateEnded.CustomFormat = "dd-MMM-yyyy"
        Me.dtpAddEvalDateEnded.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAddEvalDateEnded.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAddEvalDateEnded.Location = New System.Drawing.Point(894, 202)
        Me.dtpAddEvalDateEnded.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpAddEvalDateEnded.Name = "dtpAddEvalDateEnded"
        Me.dtpAddEvalDateEnded.Size = New System.Drawing.Size(360, 35)
        Me.dtpAddEvalDateEnded.TabIndex = 7
        Me.dtpAddEvalDateEnded.Value = New Date(2016, 3, 23, 0, 0, 0, 0)
        '
        'dtpAddEvalDateStarted
        '
        Me.dtpAddEvalDateStarted.CustomFormat = "dd-MMM-yyyy"
        Me.dtpAddEvalDateStarted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAddEvalDateStarted.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAddEvalDateStarted.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.dtpAddEvalDateStarted.Location = New System.Drawing.Point(310, 197)
        Me.dtpAddEvalDateStarted.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpAddEvalDateStarted.Name = "dtpAddEvalDateStarted"
        Me.dtpAddEvalDateStarted.Size = New System.Drawing.Size(358, 35)
        Me.dtpAddEvalDateStarted.TabIndex = 6
        Me.dtpAddEvalDateStarted.Value = New Date(2016, 3, 23, 0, 0, 0, 0)
        '
        'lblEvalEvalStatus
        '
        Me.lblEvalEvalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvalEvalStatus.Location = New System.Drawing.Point(704, 263)
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
        Me.lblEvalDateEnd.Location = New System.Drawing.Point(710, 192)
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
        Me.lblEvalEvalSubType.Location = New System.Drawing.Point(680, 132)
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
        Me.lblEvalEvaluator.Location = New System.Drawing.Point(88, 263)
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
        Me.lblEvalDateStart.Location = New System.Drawing.Point(88, 192)
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
        Me.lblEvalType.Location = New System.Drawing.Point(88, 132)
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
        Me.lblNewEvalTitle.Location = New System.Drawing.Point(22, 116)
        Me.lblNewEvalTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewEvalTitle.Name = "lblNewEvalTitle"
        Me.lblNewEvalTitle.Size = New System.Drawing.Size(341, 40)
        Me.lblNewEvalTitle.TabIndex = 3
        Me.lblNewEvalTitle.Text = "Add New Evaluation"
        '
        'frmNewEval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1470, 1204)
        Me.Controls.Add(Me.pnlNewEval)
        Me.Controls.Add(Me.lblNewEvalTitle)
        Me.Name = "frmNewEval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Evaluation"
        Me.pnlNewEval.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlNewEval As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
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
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddDogs As Button
End Class
