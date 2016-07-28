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
        Me.btnClearDogsFilter = New System.Windows.Forms.Button()
        Me.lblByDog = New System.Windows.Forms.Label()
        Me.lblByTattoo = New System.Windows.Forms.Label()
        Me.lblByTeam = New System.Windows.Forms.Label()
        Me.lblAddDogs = New System.Windows.Forms.Label()
        Me.DGVSelectDogs = New System.Windows.Forms.DataGridView()
        Me.TblAddDogListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ultra_DataDataSet = New UltraMigration_V4.Ultra_DataDataSet()
        Me.btnSubmitDogs = New System.Windows.Forms.Button()
        Me.btnCancelDogs = New System.Windows.Forms.Button()
        Me.txtDogCount = New System.Windows.Forms.TextBox()
        Me.lblAddeddogs = New System.Windows.Forms.Label()
        Me.DGVReadyDogs = New System.Windows.Forms.DataGridView()
        Me.AddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AddedTeamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddedDogDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddedTattooDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblReadyDogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAddSelected = New System.Windows.Forms.Button()
        Me.TblAddDogListTableAdapter = New UltraMigration_V4.Ultra_DataDataSetTableAdapters.tblAddDogListTableAdapter()
        Me.txtSelectCount = New System.Windows.Forms.TextBox()
        Me.SelectedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TeamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DogDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TattooDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbxFilterDogs.SuspendLayout()
        CType(Me.DGVSelectDogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAddDogListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ultra_DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVReadyDogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblReadyDogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectDogs
        '
        Me.lblSelectDogs.AutoSize = True
        Me.lblSelectDogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectDogs.Location = New System.Drawing.Point(34, 329)
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
        Me.gpbxFilterDogs.Controls.Add(Me.btnClearDogsFilter)
        Me.gpbxFilterDogs.Controls.Add(Me.lblByDog)
        Me.gpbxFilterDogs.Controls.Add(Me.lblByTattoo)
        Me.gpbxFilterDogs.Controls.Add(Me.lblByTeam)
        Me.gpbxFilterDogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbxFilterDogs.Location = New System.Drawing.Point(39, 94)
        Me.gpbxFilterDogs.Name = "gpbxFilterDogs"
        Me.gpbxFilterDogs.Size = New System.Drawing.Size(1316, 152)
        Me.gpbxFilterDogs.TabIndex = 2
        Me.gpbxFilterDogs.TabStop = False
        Me.gpbxFilterDogs.Text = "FILTER DOGS"
        '
        'txtTattoo
        '
        Me.txtTattoo.Location = New System.Drawing.Point(841, 47)
        Me.txtTattoo.Name = "txtTattoo"
        Me.txtTattoo.Size = New System.Drawing.Size(142, 35)
        Me.txtTattoo.TabIndex = 5
        '
        'txtDogs
        '
        Me.txtDogs.Location = New System.Drawing.Point(538, 47)
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
        Me.cmboTeam.Location = New System.Drawing.Point(202, 47)
        Me.cmboTeam.Name = "cmboTeam"
        Me.cmboTeam.Size = New System.Drawing.Size(196, 37)
        Me.cmboTeam.TabIndex = 3
        '
        'btnClearDogsFilter
        '
        Me.btnClearDogsFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearDogsFilter.ForeColor = System.Drawing.Color.Navy
        Me.btnClearDogsFilter.Location = New System.Drawing.Point(1030, 47)
        Me.btnClearDogsFilter.Name = "btnClearDogsFilter"
        Me.btnClearDogsFilter.Size = New System.Drawing.Size(169, 58)
        Me.btnClearDogsFilter.TabIndex = 5
        Me.btnClearDogsFilter.Text = "&Clear Filter"
        Me.btnClearDogsFilter.UseVisualStyleBackColor = True
        '
        'lblByDog
        '
        Me.lblByDog.AutoSize = True
        Me.lblByDog.Location = New System.Drawing.Point(435, 50)
        Me.lblByDog.Name = "lblByDog"
        Me.lblByDog.Size = New System.Drawing.Size(97, 29)
        Me.lblByDog.TabIndex = 2
        Me.lblByDog.Text = "By Dog:"
        '
        'lblByTattoo
        '
        Me.lblByTattoo.AutoSize = True
        Me.lblByTattoo.Location = New System.Drawing.Point(714, 50)
        Me.lblByTattoo.Name = "lblByTattoo"
        Me.lblByTattoo.Size = New System.Drawing.Size(121, 29)
        Me.lblByTattoo.TabIndex = 1
        Me.lblByTattoo.Text = "By Tattoo:"
        '
        'lblByTeam
        '
        Me.lblByTeam.AutoSize = True
        Me.lblByTeam.Location = New System.Drawing.Point(81, 55)
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
        'DGVSelectDogs
        '
        Me.DGVSelectDogs.AllowUserToAddRows = False
        Me.DGVSelectDogs.AllowUserToDeleteRows = False
        Me.DGVSelectDogs.AllowUserToResizeRows = False
        Me.DGVSelectDogs.AutoGenerateColumns = False
        Me.DGVSelectDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSelectDogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelectedDataGridViewTextBoxColumn, Me.TeamDataGridViewTextBoxColumn, Me.DogDataGridViewTextBoxColumn, Me.TattooDataGridViewTextBoxColumn})
        Me.DGVSelectDogs.DataSource = Me.TblAddDogListBindingSource
        Me.DGVSelectDogs.Location = New System.Drawing.Point(190, 317)
        Me.DGVSelectDogs.Name = "DGVSelectDogs"
        Me.DGVSelectDogs.RowHeadersVisible = False
        Me.DGVSelectDogs.RowTemplate.Height = 28
        Me.DGVSelectDogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSelectDogs.Size = New System.Drawing.Size(656, 409)
        Me.DGVSelectDogs.TabIndex = 4
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
        'btnSubmitDogs
        '
        Me.btnSubmitDogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitDogs.Location = New System.Drawing.Point(1259, 810)
        Me.btnSubmitDogs.Name = "btnSubmitDogs"
        Me.btnSubmitDogs.Size = New System.Drawing.Size(192, 62)
        Me.btnSubmitDogs.TabIndex = 6
        Me.btnSubmitDogs.Text = "Submit Dogs"
        Me.btnSubmitDogs.UseVisualStyleBackColor = True
        '
        'btnCancelDogs
        '
        Me.btnCancelDogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDogs.Location = New System.Drawing.Point(1511, 810)
        Me.btnCancelDogs.Name = "btnCancelDogs"
        Me.btnCancelDogs.Size = New System.Drawing.Size(192, 62)
        Me.btnCancelDogs.TabIndex = 7
        Me.btnCancelDogs.Text = "Cancel"
        Me.btnCancelDogs.UseVisualStyleBackColor = True
        '
        'txtDogCount
        '
        Me.txtDogCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDogCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDogCount.Location = New System.Drawing.Point(337, 264)
        Me.txtDogCount.Name = "txtDogCount"
        Me.txtDogCount.ReadOnly = True
        Me.txtDogCount.Size = New System.Drawing.Size(355, 28)
        Me.txtDogCount.TabIndex = 8
        Me.txtDogCount.WordWrap = False
        '
        'lblAddeddogs
        '
        Me.lblAddeddogs.AutoSize = True
        Me.lblAddeddogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddeddogs.Location = New System.Drawing.Point(888, 329)
        Me.lblAddeddogs.Name = "lblAddeddogs"
        Me.lblAddeddogs.Size = New System.Drawing.Size(153, 29)
        Me.lblAddeddogs.TabIndex = 10
        Me.lblAddeddogs.Text = "Added Dogs:"
        Me.lblAddeddogs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DGVReadyDogs
        '
        Me.DGVReadyDogs.AllowUserToAddRows = False
        Me.DGVReadyDogs.AllowUserToDeleteRows = False
        Me.DGVReadyDogs.AutoGenerateColumns = False
        Me.DGVReadyDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVReadyDogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddedDataGridViewTextBoxColumn, Me.AddedTeamDataGridViewTextBoxColumn, Me.AddedDogDataGridViewTextBoxColumn, Me.AddedTattooDataGridViewTextBoxColumn})
        Me.DGVReadyDogs.DataSource = Me.TblReadyDogsBindingSource
        Me.DGVReadyDogs.Location = New System.Drawing.Point(1047, 317)
        Me.DGVReadyDogs.Name = "DGVReadyDogs"
        Me.DGVReadyDogs.RowHeadersVisible = False
        Me.DGVReadyDogs.RowTemplate.Height = 28
        Me.DGVReadyDogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVReadyDogs.Size = New System.Drawing.Size(656, 409)
        Me.DGVReadyDogs.TabIndex = 11
        '
        'AddedDataGridViewTextBoxColumn
        '
        Me.AddedDataGridViewTextBoxColumn.DataPropertyName = "Added"
        Me.AddedDataGridViewTextBoxColumn.HeaderText = "Added"
        Me.AddedDataGridViewTextBoxColumn.Name = "AddedDataGridViewTextBoxColumn"
        Me.AddedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AddedTeamDataGridViewTextBoxColumn
        '
        Me.AddedTeamDataGridViewTextBoxColumn.DataPropertyName = "AddedTeam"
        Me.AddedTeamDataGridViewTextBoxColumn.HeaderText = "Team"
        Me.AddedTeamDataGridViewTextBoxColumn.Name = "AddedTeamDataGridViewTextBoxColumn"
        Me.AddedTeamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddedDogDataGridViewTextBoxColumn
        '
        Me.AddedDogDataGridViewTextBoxColumn.DataPropertyName = "AddedDog"
        Me.AddedDogDataGridViewTextBoxColumn.HeaderText = "Dog"
        Me.AddedDogDataGridViewTextBoxColumn.Name = "AddedDogDataGridViewTextBoxColumn"
        Me.AddedDogDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddedTattooDataGridViewTextBoxColumn
        '
        Me.AddedTattooDataGridViewTextBoxColumn.DataPropertyName = "AddedTattoo"
        Me.AddedTattooDataGridViewTextBoxColumn.HeaderText = "Tattoo"
        Me.AddedTattooDataGridViewTextBoxColumn.Name = "AddedTattooDataGridViewTextBoxColumn"
        Me.AddedTattooDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblReadyDogsBindingSource
        '
        Me.TblReadyDogsBindingSource.DataMember = "tblReadyDogs"
        Me.TblReadyDogsBindingSource.DataSource = Me.Ultra_DataDataSet
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(654, 810)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(192, 62)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset List"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAddSelected
        '
        Me.btnAddSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSelected.Location = New System.Drawing.Point(423, 810)
        Me.btnAddSelected.Name = "btnAddSelected"
        Me.btnAddSelected.Size = New System.Drawing.Size(192, 62)
        Me.btnAddSelected.TabIndex = 13
        Me.btnAddSelected.Text = "Add Selected"
        Me.btnAddSelected.UseVisualStyleBackColor = True
        '
        'TblAddDogListTableAdapter
        '
        Me.TblAddDogListTableAdapter.ClearBeforeFill = True
        '
        'txtSelectCount
        '
        Me.txtSelectCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSelectCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectCount.Location = New System.Drawing.Point(1177, 264)
        Me.txtSelectCount.Name = "txtSelectCount"
        Me.txtSelectCount.ReadOnly = True
        Me.txtSelectCount.Size = New System.Drawing.Size(355, 28)
        Me.txtSelectCount.TabIndex = 14
        Me.txtSelectCount.WordWrap = False
        '
        'SelectedDataGridViewTextBoxColumn
        '
        Me.SelectedDataGridViewTextBoxColumn.DataPropertyName = "Selected"
        Me.SelectedDataGridViewTextBoxColumn.HeaderText = "Selected"
        Me.SelectedDataGridViewTextBoxColumn.Name = "SelectedDataGridViewTextBoxColumn"
        Me.SelectedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SelectedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        'frmAddDogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1847, 952)
        Me.Controls.Add(Me.txtSelectCount)
        Me.Controls.Add(Me.btnAddSelected)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.DGVReadyDogs)
        Me.Controls.Add(Me.lblAddeddogs)
        Me.Controls.Add(Me.txtDogCount)
        Me.Controls.Add(Me.btnCancelDogs)
        Me.Controls.Add(Me.btnSubmitDogs)
        Me.Controls.Add(Me.DGVSelectDogs)
        Me.Controls.Add(Me.lblAddDogs)
        Me.Controls.Add(Me.gpbxFilterDogs)
        Me.Controls.Add(Me.lblSelectDogs)
        Me.Name = "frmAddDogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Dogs To Evaluation"
        Me.gpbxFilterDogs.ResumeLayout(False)
        Me.gpbxFilterDogs.PerformLayout()
        CType(Me.DGVSelectDogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAddDogListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ultra_DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVReadyDogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblReadyDogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectDogs As Label
    Friend WithEvents gpbxFilterDogs As GroupBox
    Friend WithEvents lblAddDogs As Label
    Friend WithEvents Ultra_DataDataSet As Ultra_DataDataSet
    Friend WithEvents btnClearDogsFilter As Button
    Friend WithEvents btnSubmitDogs As Button
    Friend WithEvents btnCancelDogs As Button
    Friend WithEvents lblByTeam As Label
    Friend WithEvents txtTattoo As TextBox
    Friend WithEvents txtDogs As TextBox
    Friend WithEvents cmboTeam As ComboBox
    Friend WithEvents lblByDog As Label
    Friend WithEvents lblByTattoo As Label
    Friend WithEvents txtDogCount As TextBox
    Friend WithEvents lblAddeddogs As Label
    Friend WithEvents DGVReadyDogs As DataGridView
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAddSelected As Button
    Friend WithEvents TblReadyDogsBindingSource As BindingSource
    Friend WithEvents TblAddDogListBindingSource As BindingSource
    Friend WithEvents TblAddDogListTableAdapter As Ultra_DataDataSetTableAdapters.tblAddDogListTableAdapter
    Friend WithEvents AddedDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AddedTeamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddedDogDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddedTattooDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGVSelectDogs As DataGridView
    Friend WithEvents txtSelectCount As TextBox
    Friend WithEvents SelectedDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TeamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DogDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TattooDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
