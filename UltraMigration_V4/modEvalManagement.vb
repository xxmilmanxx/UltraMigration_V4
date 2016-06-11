Module modEvalManagement
    Public ClsQry As New ClsQryRunner


    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadGrid()

        ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Eval Sub-Type], " &
                            "tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], " &
                            "IIf(tblEvaluations.CompleteFlag, 'View', 'Edit') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS Details, " &
                            "trefDogBehaviorChecklistCode.wbc_BehaviorChecklistText AS [Eval Type] " &
                        "FROM   (((tblEvaluations LEFT OUTER JOIN trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) " &
                            "LEFT OUTER JOIN trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) " &
                            "LEFT OUTER JOIN Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId) " &
                        "WHERE (IIf(tblEvaluations.CompleteFlag, 'View', 'Edit') IS NOT NULL) OR (IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) > '0') " &
                        "ORDER BY tblEvaluations.evl_DateStart DESC")


        If Not String.IsNullOrEmpty(ClsQry.Exception) Then Exit Sub
        If ClsQry.RecordCount < 1 Then Exit Sub

        frmEvalManagement.DGVfrmEvalManagement.DataSource = ClsQry.DBDT


    End Sub

    Public Sub LoadEvaluatorCombobox()
        'Clear/Purge Combobox
        ' frmEvalManagement.cmboEvaluator.Items.Clear()
        ' ClsQry.AddParam("@evaluatorName", "%" & FilterEvaluatorName & "%")
        ClsQry.RecordCount = 0
        'Fill Combobox with Evaluator Name
        ClsQry.ExeQuery("SELECT DISTINCT [Evaluator_Name] FROM tblEvaluations")

        For Each R As DataRow In ClsQry.DBDT.Rows
            frmEvalManagement.cmboEvaluator.Items.Add(R("Evaluator Name"))
        Next

        'If records are found add them to combobox
        If ClsQry.RecordCount > 0 Then
            'For Each R As DataRow In ClsQry.DBDS.Tables(0).Rows
            'frmEvalManagement.cmboEvaluator.Items.Add(R("Evaluator Name"))
            'Next
            ' frmEvalManagement.cmboEvaluator.SelectedIndex = -1
            ' ElseIf ClsQry.Exception <> "" Then
            MsgBox(ClsQry.Exception)
        End If
    End Sub

    Public Sub UpdateEvalMngntTable()
        'Will update the current  Table in the frmEvalManagement Form
        Dim evalRowCount As String = frmEvalManagement.DGVfrmEvalManagement.Rows.Count
        frmEvalManagement.txtRecordsCount.Text = evalRowCount & " EVALUATIONS SHOWING"

    End Sub

End Module
