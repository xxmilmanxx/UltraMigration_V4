Public Class frmEvalManagement
    Public ClsQry As New ClsQryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmEvalManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Show the number of evluations based on parameters
        LoadGrid()
        UpdateEvalMngntTable()
        LoadEvaluatorCombobox()

        ' FillCmboEvaluator()
        'FillCmboType()

    End Sub

    Private Sub cmboEvaluator_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboEvaluator.SelectionChangeCommitted



    End Sub

    Private Sub btnAddEval_Click(sender As Object, e As EventArgs) Handles btnAddEval.Click

        frmNewEval.Show()

        Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click

    End Sub

    Private Sub cmboEvaluator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboEvaluator.SelectedIndexChanged

    End Sub
End Class
