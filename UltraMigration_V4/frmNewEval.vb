Public Class frmNewEval
    Public ClsQry As New ClsQryRunner
    Dim myNewEval As New DataTable

    Private Sub frmNewEval_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadNewEvalCombobox()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Close()

        frmEvalManagement.Show()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearNewEval()

    End Sub
End Class