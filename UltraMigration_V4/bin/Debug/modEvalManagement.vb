Module modEvalManagement
    Public ClsQry As New ClsQryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadDataGrid()

        ' Command that loads the data grid
        ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistCode.wbc_BehaviorChecklistText AS [Eval Type], " &
                             "trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Eval Sub-Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], " &
                             "tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'View', 'Edit') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS Details " &
                        "FROM (((tblEvaluations LEFT OUTER JOIN trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) " &
                             "LEFT OUTER JOIN trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN " &
                             "Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId) " &
                        "WHERE (IIf(tblEvaluations.CompleteFlag, 'View', 'Edit') IS NOT NULL) OR (IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) > '0') " &
                        "ORDER BY tblEvaluations.evl_DateStart DESC")

        ' Check for errors before continuung
        If Not String.IsNullOrEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

        'Fill DataGridView
        frmEvalManagement.DGVfrmEvalManagement.DataSource = ClsQry.DBDT.DefaultView

    End Sub

    Public Sub LoadEvaluatorCombobox()

        ' Clears the Evaluator Name combobox before running command
        frmEvalManagement.cmboEvaluator.Items.Clear()

        Try
            ' Command that loads the Evaluator Name Combobox
            ClsQry.ExeQuery("SELECT DISTINCT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name] " &
                            "FROM (tblEvaluations LEFT OUTER JOIN Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)")
            ' If records are found load them into the combobox
            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmEvalManagement.cmboEvaluator.Items.Add(R("Evaluator Name"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadTypeCombobox()

        ' Clears the Eval Type combobox before running command
        frmEvalManagement.cmboType.Items.Clear()

        Try
            ' Command that loads the Eval Type Combobox
            ClsQry.ExeQuery("SELECT DISTINCT trefDogBehaviorChecklistCode.wbc_BehaviorChecklistText AS [Eval Type] " &
                            "FROM (tblEvaluations LEFT OUTER JOIN trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode)")
            ' If records are found load them into the combobox
            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmEvalManagement.cmboType.Items.Add(R("Eval Type"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadSubTypeCombobox()

        ' Clears the Eval Sub-Type combobox before running command
        frmEvalManagement.cmboSubType.Items.Clear()

        Try
            ' Command that loads the Eval Sub-Type Combobox
            ClsQry.ExeQuery("SELECT DISTINCT trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Eval Sub-Type] " &
                            "FROM (tblEvaluations LEFT OUTER JOIN trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode)")
            frmEvalManagement.cmboSubType.Items.Clear()
            ' If records are found load them into the combobox
            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmEvalManagement.cmboSubType.Items.Add(R("Eval Sub-Type"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub FilterName()

        ' Add Paramaters & Run Query
        'ClsQry.AddParam("@evaluatorName", "%" & Name & "%")

        ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistCode.wbc_BehaviorChecklistText AS [Eval Type], " &
                          "trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Eval Sub-Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], " &
                        "tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'View', 'Edit') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS Details " &
                    "FROM (((tblEvaluations LEFT OUTER JOIN trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) " &
                         "LEFT OUTER JOIN trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN " &
                        "Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId) " &
                  "WHERE '[Evaluator Name]'= '" & frmEvalManagement.cmboEvaluator.Text & "'")


        ' Report and Aprot is errors
        If NotEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

        'Fill DataGridView
        frmEvalManagement.DGVfrmEvalManagement.DataSource = ClsQry.DBDT.DefaultView

    End Sub

    Public Sub ResetEvalManagementFilters()

        ' Make sure no item is selected in combobox and Date Time Picker
        frmEvalManagement.cmboEvaluator.SelectedIndex = -1
        frmEvalManagement.cmboType.SelectedIndex = -1
        frmEvalManagement.cmboSubType.SelectedIndex = -1
        frmEvalManagement.DTP1.Text = ""

    End Sub

    Public Sub UpdateEvalMngntTable()

        ' Update the current Table in the frmEvalManagement Form
        Dim evalRowCount As String = frmEvalManagement.DGVfrmEvalManagement.Rows.Count
        ' Show the number of evaluations currently in data grid
        frmEvalManagement.txtRecordsCount.Text = evalRowCount & " EVALUATIONS SHOWING"

    End Sub
End Module
