Public Class frmNewEval
    Public ClsQry As New ClsQryRunner

    Private Sub frmNewEval_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' Loads Evaluator Name into Combobox
        LoadNewEvaluatorCombobox()
        ' Loads Eval Type into Combobox
        LoadNewTypeCombobox()
        ' Loads Eval Sub-Type into Combobox
        LoadNewSubTypeCombobox()
        ' Reset the combobox and datetimepicker
        ResetNewEval()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Close()

        frmEvalManagement.Show()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ResetNewEval()

    End Sub


End Class