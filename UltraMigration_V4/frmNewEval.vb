Imports UltraMigration_V4

Public Class frmNewEval
    Public Shared Property trefDogBehaviorChecklistCode As NewEvalDataSet.trefDogBehaviorChecklistCodeDataTable

    Private Sub frmNewEval_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'NewEvalDataSet.trefDogBehaviorChecklistCode' table. You can move, or remove it, as needed.
        Me.TrefDogBehaviorChecklistCodeTableAdapter.Fill(Me.NewEvalDataSet.trefDogBehaviorChecklistCode)
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