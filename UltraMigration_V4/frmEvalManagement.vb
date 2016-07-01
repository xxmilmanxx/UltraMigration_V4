Public Class frmEvalManagement
    Public ClsQry As New ClsQryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadTable()

        Try

            Me.QryTblEvaluationsTableAdapter.Fill(Me.Ultra_DataDataSet.qryTblEvaluations)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub frmEvalManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Loads the table into the DataGridView
        LoadTable()
        ' Loads Evaluator Name into Combobox
        LoadEvaluatorCombobox()
        ' Loads Eval Type into Combobox
        LoadTypeCombobox()
        ' Resets combobox and datetimepicker
        ResetEvalManagementFilters()
        ' Counts records and displays number in the txtRecordCount field
        UpdateEvalMngntTable()

    End Sub

    Private Sub cmboEvaluator_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboEvaluator.SelectionChangeCommitted

        'Filter data grid based on current selected index in the combobox
        FilterAll()
        ' Counts records and displays number in the txtRecordCount field
        UpdateEvalMngntTable()

    End Sub

    Private Sub cmboType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboType.SelectionChangeCommitted

        'Filter data grid based on current selected index in the combobox
        FilterAll()
        ' Counts records and displays number in the txtRecordCount field
        UpdateEvalMngntTable()

    End Sub

    Private Sub dtpStart_CloseUp(sender As Object, e As EventArgs) Handles dtpStart.CloseUp

        Dim cTime As String = DateTime.Now.ToString("dd-MMM-yyyy")

        If Me.dtpStart.Value.Date < DateTime.Now Then
            FilterStart()
        Else
            MessageBox.Show("Please select a day that is on or before " & cTime & "")
            Me.dtpStart.ResetText()
        End If
        ' FilterAll()

        UpdateEvalMngntTable()


    End Sub

    Private Sub dtpEnd_CloseUp(sender As Object, e As EventArgs) Handles dtpEnd.CloseUp



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

        LoadDataGrid()
        ' LoadTable()

        UpdateEvalMngntTable()

    End Sub
End Class
