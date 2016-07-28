Public Class frmEvalManagement
    Public ClsQry As New qryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmEvalManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' frmAddDogs.TblAddDogListTableAdapter.Fill(frmAddDogs.Ultra_DataDataSet.tblAddDogList)
        'Loads the table into the DataGridView
        LoadDataGrid()
        ' Loads Evaluator Name into Combobox
        LoadEvaluatorCombobox()
        ' Loads Eval Type into Combobox
        LoadTypeCombobox()
        ' Counts records and displays number in the txtRecordCount field
        UpdateEvalMngntTable()
        ' Clear the filters after table is loaded
        ResetEvalManagementFilters()

    End Sub

    Private Sub cmboEvaluator_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboEvaluator.SelectionChangeCommitted

        'Filter data grid based on current selected index in the combobox
        FilterAll()
        'Filter Start Date
        ' FilterStart()
        ' Counts records and displays number in the txtRecordCount field
        UpdateEvalMngntTable()

    End Sub

    Private Sub cmboType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboType.SelectionChangeCommitted

        'Filter data grid based on current selected index in the combobox
        FilterAll()
        'Filter Start Date
        ' FilterStart()
        ' Counts records and displays number in the txtRecordCount field
        UpdateEvalMngntTable()

    End Sub

    Private Sub dtpStart_CloseUp(sender As Object, e As EventArgs) Handles dtpStart.CloseUp
        'Filter data grid based on current selected index in the combobox
        ' FilterAll()
        'Filter Start Date
        FilterStart()

        'Counts records and displays number in the txtRecordCount field
        UpdateEvalMngntTable()

    End Sub

    Private Sub btnAddEval_Click(sender As Object, e As EventArgs) Handles btnAddEval.Click

        'Shows the New Eval Form
        frmEvaluation.Show()
        'Hides the Eval Management Form
        Hide()
        'Loads the table into the DataGridView
        LoadDataGrid()
        'Loads Evaluator Name into Combobox
        LoadEvaluatorCombobox()
        'Loads Eval Type into Combobox
        LoadTypeCombobox()
        'Counts records and displays number in the txtRecordCount field
        UpdateEvalMngntTable()
        'Clear the filters after table is loaded
        ResetEvalManagementFilters()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearEvalFilter.Click

        'Loads the table into the DataGridView
        LoadDataGrid()
        'Counts records and displays number in the txtRecordCount field
        UpdateEvalMngntTable()
        'Clear the filters after table is loaded
        ResetEvalManagementFilters()

    End Sub

    Private Sub DGVfrmEvalManagement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVfrmEvalManagement.CellContentClick

        On Error Resume Next

        If Me.AddEditDataGridViewTextBoxColumn.Selected = True Then

            '            If SetLastForm(GetWorkspaceForm) Then
            '           If em.Load(Me.txtEvaluationCode) Then
            '          evalEditFlag = True
            '         SetWspaceSource "frmEvaluation"
            '    Else
            '       MsgBox "Failed to load evaluation, Please try again... If problem persists contact your admin", vbExclamation
        End If

        '      End If
        ' End If

    End Sub
End Class
