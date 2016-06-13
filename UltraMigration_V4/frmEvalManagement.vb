Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmEvalManagement
    Public ClsQry As New ClsQryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmEvalManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        LoadEvaluatorCombobox()
        LoadEvalTypeCombobox()
        LoadEvalSubTypeCombobox()
        ClearEvalManagementFilters()

        Me.TblEvaluationsTableAdapter.Fill(Me.UltraEvalDataSet.tblEvaluations)
        UpdateEvalMngntTable()

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

    End Sub


End Class
