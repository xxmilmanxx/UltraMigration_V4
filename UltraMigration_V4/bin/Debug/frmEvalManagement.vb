Public Class frmEvalManagement
    Public ClsQry As New ClsQryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmEvalManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Try
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
            DGVfrmEvalManagement.DataSource = ClsQry.DBDT
            'Loads the table into the DataGridView
            'LoadDataGrid()
            ' Loads Evaluator Name into Combobox
            LoadEvaluatorCombobox()
            ' Loads Eval Type into Combobox
            LoadTypeCombobox()
            ' Loads Eval Sub-Type into Combobox
            LoadSubTypeCombobox()
            ' Resets combobox and datetimepicker
            ResetEvalManagementFilters()
            ' Counts records and displays number in the txtRecordCount field
            UpdateEvalMngntTable()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub NameFill()

        ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistCode.wbc_BehaviorChecklistText AS [Eval Type], " &
                          "trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Eval Sub-Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], " &
                        "tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'View', 'Edit') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS Details " &
                    "FROM (((tblEvaluations LEFT OUTER JOIN trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) " &
                         "LEFT OUTER JOIN trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN " &
                        "Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId) " &
                  "WHERE '[Evaluator Name]'= '" & cmboEvaluator.SelectedIndex & "'")


        ' Report and Aprot is errors
        If NotEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

        'Fill DataGridView
        DGVfrmEvalManagement.DataSource = ClsQry.DBDT
    End Sub
    Private Sub cmboEvaluator_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboEvaluator.SelectionChangeCommitted

        'Filter data grid based on current selected index in the combobox
        NameFill()
        ' FilterName()
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

        ResetEvalManagementFilters()

        LoadDataGrid()

        UpdateEvalMngntTable()

    End Sub
End Class
