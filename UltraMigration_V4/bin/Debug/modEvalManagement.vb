Module modEvalManagement
    Public ClsQry As New qryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadDataGrid()
        Try
            ' Command that loads the data grid
            ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Evaluation Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], 
             tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'Edit', 'View') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS [Dog Evals]
FROM   (((tblEvaluations LEFT OUTER JOIN
             trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) LEFT OUTER JOIN
             trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN
             Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)
ORDER BY tblEvaluations.evl_DateStart DESC")

            ' Check for errors before continuung
            If Not String.IsNullOrEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

            frmEvalManagement.DGVfrmEvalManagement.DataSource = ClsQry.DBDT.DefaultView

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub LoadEvaluatorCombobox()

        Try
            ' Clears the Evaluator Name combobox before running command
            frmEvalManagement.cmboEvaluator.Items.Clear()

            ' Command that loads the Evaluator Name Combobox
            ClsQry.ExeQuery("SELECT DISTINCT Person_Person.FirstName & ' ' & Person_Person.LastName AS EvalName
            From Person_Person INNER JOIN tblEvaluations ON Person_Person.BusinessEntityId = tblEvaluations.evl_EvaluatorID")

            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmEvalManagement.cmboEvaluator.Items.Add(R("EvalName"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadTypeCombobox()

        Try
            ' Clears the Eval Type combobox before running command
            frmEvalManagement.cmboType.Items.Clear()

            ClsQry.ExeQuery("SELECT trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS EvalType, trefDogBehaviorChecklistSubCode.bcs_Evaluations
FROM trefDogBehaviorChecklistSubCode
WHERE (((trefDogBehaviorChecklistSubCode.bcs_Evaluations)=True))")

            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmEvalManagement.cmboType.Items.Add(R("EvalType"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub FilterStart()
        '  Dim sDate As String = String.Format("frmEvalManagement.dtpStart >= {dd-MMM-yyyy} ", frmEvalManagement.dtpStart.Value.Date)
        Dim cTime As String = DateTime.Now.ToString("dd-MMM-yyyy")
        Dim sDate As String = String.Format("dd-MMM-yyyy", frmEvalManagement.dtpStart.Value)
        Try


            If frmEvalManagement.dtpStart.Value < DateTime.Now Then
                ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Evaluation Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], 
                            tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'Edit', 'View') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS [Dog Evals]
                        FROM   (((tblEvaluations LEFT OUTER JOIN
                            trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) LEFT OUTER JOIN
                            trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN
                            Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)
                        WHERE tblEvaluations.evl_DateStart LIKE '#" & sDate & "#'")
            End If

            If frmEvalManagement.dtpStart.Value > DateTime.Now Then
                If MessageBox.Show("Please select a day that is on or before " & cTime & "", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                    frmEvalManagement.dtpStart.ResetText()
                End If
            End If

            ' Report and Aprot is errors
            If NotEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

            'Fill DataGridView
            frmEvalManagement.DGVfrmEvalManagement.DataSource = ClsQry.DBDT

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub FilterAll()
        Dim evalName As String = frmEvalManagement.cmboEvaluator.Text
        Dim evalType As String = frmEvalManagement.cmboType.Text


        Try

            If frmEvalManagement.cmboEvaluator.SelectedIndex > -1 And frmEvalManagement.cmboType.SelectedIndex > -1 Then
                ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Evaluation Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], 
                            tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'Edit', 'View') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS [Dog Evals]
                        FROM   (((tblEvaluations LEFT OUTER JOIN
                            trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) LEFT OUTER JOIN
                            trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN
                            Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)
                        WHERE Person_Person.FirstName & ' ' & Person_Person.LastName= '" & evalName & "'AND trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText= '" & evalType & "'")

            ElseIf frmEvalManagement.cmboEvaluator.SelectedIndex > -1 Then
                ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Evaluation Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], 
             tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'Edit', 'View') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS [Dog Evals]
                        FROM   (((tblEvaluations LEFT OUTER JOIN
             trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) LEFT OUTER JOIN
             trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN
             Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)
                        WHERE Person_Person.FirstName & ' ' & Person_Person.LastName= '" & evalName & "'")

            ElseIf frmEvalManagement.cmboType.SelectedIndex > -1 Then
                ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Evaluation Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], 
                            tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'Edit', 'View') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS [Dog Evals]
                        FROM   (((tblEvaluations LEFT OUTER JOIN
                            trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) LEFT OUTER JOIN
                            trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN
                            Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)
                        WHERE trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText= '" & evalType & "'")

            Else
                ClsQry.ExeQuery("SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Evaluation Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], 
                            tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'Edit', 'View') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS [Dog Evals]
                        FROM   (((tblEvaluations LEFT OUTER JOIN
                            trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) LEFT OUTER JOIN
                            trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN
                            Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)")

            End If


            ' Report and Aprot is errors
            If NotEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

            'Fill DataGridView
            frmEvalManagement.DGVfrmEvalManagement.DataSource = ClsQry.DBDT.DefaultView

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub ResetEvalManagementFilters()

        Try

            ' Make sure no item is selected in combobox and Date Time Picker
            frmEvalManagement.cmboEvaluator.SelectedIndex = -1
            frmEvalManagement.cmboType.SelectedIndex = -1
            frmEvalManagement.dtpStart.ResetText()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub UpdateEvalMngntTable()

        Try
            ' Update the current Table in the frmEvalManagement Form
            Dim evalRowCount As String = frmEvalManagement.DGVfrmEvalManagement.Rows.Count
            ' Show the number of evaluations currently in data grid
            frmEvalManagement.txtRecordsCount.Text = evalRowCount & " EVALUATIONS SHOWING"
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

End Module
