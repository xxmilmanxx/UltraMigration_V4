Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmEvalManagement
    Public ClsQry As New ClsQryRunner
    Public evalDT As New DataTable

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmEvalManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Me.TblEvaluationsTableAdapter.Fill(Me.UltraEvalDataSet.tblEvaluations)

        UpdateEvalMngntTable()
        ClearEvalManagementFilters()
        'EvaluatorLoad()
        LoadEvalCombobox(evalDT)

    End Sub

    Private Sub EvaluatorLoad()


        ' frmEvalManagement.TblEvaluationsTableAdapter.Fill(frmEvalManagement.UltraEvalDataSet.tblEvaluations)

        '("SELECT DISTINCT [Evaluator Name] FROM tblEvaluations")



        'Me.TblEvaluationsTableAdapter.FillEvaluatorName(Me.UltraEvalDataSet.tblEvaluations)
        'Clear/Purge Combobox

        '  ClsQry.ExeQuery("SELECT DISTINCT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name]
        '                     FROM            (tblEvaluations LEFT OUTER JOIN
        '                 Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)")
        ' ClsQry.ExeQuery("SELECT DISTINCT [Evaluator Name] FROM UltraEvalDataSet.tblEvaluations")


        'If records are found add them to combobox
        ' If ClsQry.RecordCount > 0 Then
        'For Each R As DataRow In ClsQry.DBDS.Tables(0).Rows
        'frmEvalManagement.cmboEvaluator.Items.Add(R("Evaluator Name"))
        'Next
        ' frmEvalManagement.cmboEvaluator.SelectedIndex = -1
        ' ElseIf ClsQry.Exception <> "" Then
        'MsgBox(ClsQry.Exception)
        'End If


    End Sub

    Private Sub LoadEvalCombobox(evalDT As DataTable)
        For Each R As DataRow In evalDT.Rows
            Me.cmboEvaluator.Items.Add(R("Evaluator Name"))
        Next
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
