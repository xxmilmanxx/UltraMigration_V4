Public Class frmEvalManagement
    Public ClsQry As New ClsQryRunner
    Dim myBindingSource As New DataTable

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmEvalManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        LoadEvaluatorCombobox()
        LoadEvalTypeCombobox()
        LoadEvalSubTypeCombobox()
        ClearEvalManagementFilters()
        'LoadGrid()
        'FilterAll()
        ClsQry.GetRecords()
        UpdateEvalMngntTable()

    End Sub

    Private Sub LoadGrid()

        myBindingSource = UltraEvalDataSet.tblEvaluations

        TblEvaluationsTableAdapter.Fill(myBindingSource)

        DGVfrmEvalManagement.DataSource = myBindingSource

    End Sub

    Public Sub FilterName()
        Try

            ' TODO: GET FILTER TO WORK 
            '  If cmboEvaluator.SelectedIndex > -1 Then
            ' ClsQry.ExeQuery("SELECT * FROM UltraEvalDataSet.tblEvaluations WHERE [Evaluator Name] = '" & cmboEvaluator.SelectedIndex & "'")

            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAddEval_Click(sender As Object, e As EventArgs) Handles btnAddEval.Click

        frmNewEval.Show()

        Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click

        ClearEvalManagementFilters()

        ' LoadGrid()

        UpdateEvalMngntTable()

    End Sub
End Class
