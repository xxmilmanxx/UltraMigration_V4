Public Class frmEvalManagement
    Public ClsQry As New ClsQryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmEvalManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Try
            'Loads the table into the DataGridView
            LoadDataGrid()
            ' Loads Evaluator Name into Combobox
            LoadEvaluatorCombobox()
            ' Loads Eval Type into Combobox
            LoadTypeCombobox()
            ' Loads Eval Sub-Type into Combobox
            LoadSubTypeCombobox()
            ' Resets combobox and datetimepicker
            ResetEvalManagementFilters()
            ' Counts records and displays number in the txtRecordCount field
            UpdateEvalMngntTable()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmboEvaluator_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboEvaluator.SelectionChangeCommitted

        'Filter data grid based on current selected index in the combobox
        FilterName(cmboEvaluator.Text)


    End Sub

    Private Sub btnAddEval_Click(sender As Object, e As EventArgs) Handles btnAddEval.Click

        frmNewEval.Show()

        Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click

        ResetEvalManagementFilters()

        UpdateEvalMngntTable()

    End Sub
End Class
