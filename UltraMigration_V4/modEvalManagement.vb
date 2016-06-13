Imports System.Data.OleDb
Imports System.Data.SqlClient

Module modEvalManagement
    Public ClsQry As New ClsQryRunner


    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub ClearEvalManagementFilters()

        frmEvalManagement.cmboEvaluator.SelectedIndex = -1
        frmEvalManagement.cmboType.SelectedIndex = -1
        frmEvalManagement.cmboSubType.SelectedIndex = -1
        frmEvalManagement.DTP1.Text = ""


    End Sub

    Public Sub LoadEvaluatorCombobox()
        Dim evalName As New DataTable

        ' frmEvalManagement.TblEvaluationsTableAdapter.Fill(frmEvalManagement.UltraEvalDataSet.tblEvaluations)

        ' frmEvalManagement.TblEvaluationsTableAdapter.FillEvaluatorName(frmEvalManagement.UltraEvalDataSet.tblEvaluations)
        'Clear/Purge Combobox

        '  ClsQry.ExeQuery("SELECT DISTINCT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name]
        '                     FROM            (tblEvaluations LEFT OUTER JOIN
        '                 Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)")
        ClsQry.ExeQuery("SELECT DISTINCT [Evaluator_Name] FROM frmEvalManagement.UltraEvalDataSet.tblEvaluations")
        For Each R As DataRow In evalName.Rows
            frmEvalManagement.cmboEvaluator.Items.Add(R("Evaluator Name"))
        Next

        'If records are found add them to combobox
        'If ClsQry.RecordCount > 0 Then
        'For Each R As DataRow In ClsQry.DBDS.Tables(0).Rows
        'frmEvalManagement.cmboEvaluator.Items.Add(R("Evaluator Name"))
        'Next
        ' frmEvalManagement.cmboEvaluator.SelectedIndex = -1
        ' ElseIf ClsQry.Exception <> "" Then
        'MsgBox(ClsQry.Exception)
        ' End If

    End Sub

    Public Sub UpdateEvalMngntTable()
        'Will update the current  Table in the frmEvalManagement Form
        Dim evalRowCount As String = frmEvalManagement.DGVfrmEvalManagement.Rows.Count
        frmEvalManagement.txtRecordsCount.Text = evalRowCount & " EVALUATIONS SHOWING"

    End Sub

End Module
