<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddDogs
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
        Me.lblSelectDogs = New System.Windows.Forms.Label()
        Me.gpbxFilterDogs = New System.Windows.Forms.GroupBox()
        Me.txtTattoo = New System.Windows.Forms.TextBox()
        Me.txtDogs = New System.Windows.Forms.TextBox()
        Me.cmboTeam = New System.Windows.Forms.ComboBox()
        Me.lblByDog = New System.Windows.Forms.Label()
        Me.lblByTattoo = New System.Windows.Forms.Label()
        Me.lblByTeam = New System.Windows.Forms.Label()
        Me.lblAddDogs = New System.Windows.Forms.Label()
        Me.DGVAddDogs = New System.Windows.Forms.DataGridView()
        Me.TeamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DogDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TattooDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblAddDogListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ultra_DataDataSet = New UltraMigration_V4.Ultra_DataDataSet()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TblAddDogListTableAdapter = New UltraMigration_V4.Ultra_DataDataSetTableAdapters.tblAddDogListTableAdapter()
        Me.txtDogCount = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.gpbxFilterDogs.SuspendLayout()
        CType(Me.DGVAddDogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAddDogListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ultra_DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectDogs
        '
        Me.lblSelectDogs.AutoSize = True
        Me.lblSelectDogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectDogs.Location = New System.Drawing.Point(34, 258)
        Me.lblSelectDogs.Name = "lblSelectDogs"
        Me.lblSelectDogs.Size = New System.Drawing.Size(150, 29)
        Me.lblSelectDogs.TabIndex = 1
        Me.lblSelectDogs.Text = "Select Dogs:"
        Me.lblSelectDogs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpbxFilterDogs
        '
        Me.gpbxFilterDogs.Controls.Add(Me.txtTattoo)
        Me.gpbxFilterDogs.Controls.Add(Me.txtDogs)
        Me.gpbxFilterDogs.Controls.Add(Me.cmboTeam)
        Me.gpbxFilterDogs.Controls.Add(Me.lblByDog)
        Me.gpbxFilterDogs.Controls.Add(Me.lblByTattoo)
        Me.gpbxFilterDogs.Controls.Add(Me.lblByTeam)
        Me.gpbxFilterDogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbxFilterDogs.Location = New System.Drawing.Point(39, 117)
        Me.gpbxFilterDogs.Name = "gpbxFilterDogs"
        Me.gpbxFilterDogs.Size = New System.Drawing.Size(1075, 111)
        Me.gpbxFilterDogs.TabIndex = 2
        Me.gpbxFilterDogs.TabStop = False
        Me.gpbxFilterDogs.Text = "FILTER DOGS"
        '
        'txtTattoo
        '
        Me.txtTattoo.Location = New System.Drawing.Point(818, 47)
        Me.txtTattoo.Name = "txtTattoo"
        Me.txtTattoo.Size = New System.Drawing.Size(142, 35)
        Me.txtTattoo.TabIndex = 5
        '
        'txtDogs
        '
        Me.txtDogs.Location = New System.Drawing.Point(493, 47)
        Me.txtDogs.Name = "txtDogs"
        Me.txtDogs.Size = New System.Drawing.Size(142, 35)
        Me.txtDogs.TabIndex = 4
        '
        'cmboTeam
        '
        Me.cmboTeam.DropDownHeight = 110
        Me.cmboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboTeam.DropDownWidth = 170
        Me.cmboTeam.FormattingEnabled = True
        Me.cmboTeam.IntegralHeight = False
        Me.cmboTeam.Location = New System.Drawing.Point(180, 47)
        Me.cmboTeam.Name = "cmboTeam"
        Me.cmboTeam.Size = New System.Drawing.Size(165, 37)
        Me.cmboTeam.TabIndex = 3
        '
        'lblByDog
        '
        Me.lblByDog.AutoSize = True
        Me.lblByDog.Location = New System.Drawing.Point(390, 50)
        Me.lblByDog.Name = "lblByDog"
        Me.lblByDog.Size = New System.Drawing.Size(97, 29)
        Me.lblByDog.TabIndex = 2
        Me.lblByDog.Text = "By Dog:"
        '
        'lblByTattoo
        '
        Me.lblByTattoo.AutoSize = True
        Me.lblByTattoo.Location = New System.Drawing.Point(691, 50)
        Me.lblByTattoo.Name = "lblByTattoo"
        Me.lblByTattoo.Size = New System.Drawing.Size(121, 29)
        Me.lblByTattoo.TabIndex = 1
        Me.lblByTattoo.Text = "By Tattoo:"
        '
        'lblByTeam
        '
        Me.lblByTeam.AutoSize = True
        Me.lblByTeam.Location = New System.Drawing.Point(59, 50)
        Me.lblByTeam.Name = "lblByTeam"
        Me.lblByTeam.Size = New System.Drawing.Size(115, 29)
        Me.lblByTeam.TabIndex = 0
        Me.lblByTeam.Text = "By Team:"
        '
        'lblAddDogs
        '
        Me.lblAddDogs.AutoSize = True
        Me.lblAddDogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddDogs.Location = New System.Drawing.Point(32, 33)
        Me.lblAddDogs.Name = "lblAddDogs"
        Me.lblAddDogs.Size = New System.Drawing.Size(405, 40)
        Me.lblAddDogs.TabIndex = 3
        Me.lblAddDogs.Text = "Add Dogs To Evaluation"
        '
        'DGVAddDogs
        '
        Me.DGVAddDogs.AllowUserToAddRows = False
        Me.DGVAddDogs.AllowUserToDeleteRows = False
        Me.DGVAddDogs.AutoGenerateColumns = False
        Me.DGVAddDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAddDogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeamDataGridViewTextBoxColumn, Me.DogDataGridViewTextBoxColumn, Me.TattooDataGridViewTextBoxColumn})
        Me.DGVAddDogs.DataSource = Me.TblAddDogListBindingSource
        Me.DGVAddDogs.Location = New System.Drawing.Point(190, 258)
        Me.DGVAddDogs.Name = "DGVAddDogs"
        Me.DGVAddDogs.ReadOnly = True
        Me.DGVAddDogs.RowHeadersVisible = False
        Me.DGVAddDogs.RowTemplate.Height = 28
        Me.DGVAddDogs.Size = New System.Drawing.Size(924, 409)
        Me.DGVAddDogs.TabIndex = 4
        '
        'TeamDataGridViewTextBoxColumn
        '
        Me.TeamDataGridViewTextBoxColumn.DataPropertyName = "Team"
        Me.TeamDataGridViewTextBoxColumn.HeaderText = "Team"
        Me.TeamDataGridViewTextBoxColumn.Name = "TeamDataGridViewTextBoxColumn"
        Me.TeamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DogDataGridViewTextBoxColumn
        '
        Me.DogDataGridViewTextBoxColumn.DataPropertyName = "Dog"
        Me.DogDataGridViewTextBoxColumn.HeaderText = "Dog"
        Me.DogDataGridViewTextBoxColumn.Name = "DogDataGridViewTextBoxColumn"
        Me.DogDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TattooDataGridViewTextBoxColumn
        '
        Me.TattooDataGridViewTextBoxColumn.DataPropertyName = "Tattoo"
        Me.TattooDataGridViewTextBoxColumn.HeaderText = "Tattoo"
        Me.TattooDataGridViewTextBoxColumn.Name = "TattooDataGridViewTextBoxColumn"
        Me.TattooDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblAddDogListBindingSource
        '
        Me.TblAddDogListBindingSource.DataMember = "tblAddDogList"
        Me.TblAddDogListBindingSource.DataSource = Me.Ultra_DataDataSet
        '
        'Ultra_DataDataSet
        '
        Me.Ultra_DataDataSet.DataSetName = "Ultra_DataDataSet"
        Me.Ultra_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(248, 700)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(192, 62)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Filter"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(558, 700)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(192, 62)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(857, 700)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(192, 62)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TblAddDogListTableAdapter
        '
        Me.TblAddDogListTableAdapter.ClearBeforeFill = True
        '
        'txtDogCount
        '
        Me.txtDogCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDogCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDogCount.Location = New System.Drawing.Point(644, 72)
        Me.txtDogCount.Name = "txtDogCount"
        Me.txtDogCount.ReadOnly = True
        Me.txtDogCount.Size = New System.Drawing.Size(355, 28)
        Me.txtDogCount.TabIndex = 8
        Me.txtDogCount.WordWrap = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(751, 38)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'frmAddDogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 788)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtDogCount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.DGVAddDogs)
        Me.Controls.Add(Me.lblAddDogs)
        Me.Controls.Add(Me.gpbxFilterDogs)
        Me.Controls.Add(Me.lblSelectDogs)
        Me.Name = "frmAddDogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Dogs To Evaluation"
        Me.gpbxFilterDogs.ResumeLayout(False)
        Me.gpbxFilterDogs.PerformLayout()
        CType(Me.DGVAddDogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAddDogListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ultra_DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectDogs As Label
    Friend WithEvents gpbxFilterDogs As GroupBox
    Friend WithEvents lblAddDogs As Label
    Friend WithEvents DGVAddDogs As DataGridView
    Friend WithEvents Ultra_DataDataSet As Ultra_DataDataSet
    Friend WithEvents TblAddDogListBindingSource As BindingSource
    Friend WithEvents TblAddDogListTableAdapter As Ultra_DataDataSetTableAdapters.tblAddDogListTableAdapter
    Friend WithEvents TeamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DogDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TattooDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblByTeam As Label
    Friend WithEvents txtTattoo As TextBox
    Friend WithEvents txtDogs As TextBox
    Friend WithEvents cmboTeam As ComboBox
    Friend WithEvents lblByDog As Label
    Friend WithEvents lblByTattoo As Label
    Friend WithEvents txtDogCount As TextBox
    Friend WithEvents RadioButton1 As RadioButton
End Class
