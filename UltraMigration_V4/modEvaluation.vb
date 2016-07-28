Module modEvaluation

    Public ClsQry As New qryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadNewEvaluatorCombobox()

        ' Clears the Evaluator Name combobox before running command
        frmEvaluation.cmboAddEvaluator.Items.Clear()

        Try
            ' Command that loads the Evaluator Name Combobox
            ClsQry.ExeQuery("SELECT DISTINCT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name] " &
                            "FROM (tblEvaluations LEFT OUTER JOIN Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)")
            ' If records are found load them into the combobox
            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmEvaluation.cmboAddEvaluator.Items.Add(R("Evaluator Name"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadNewTypeCombobox()

        ' Clears the Eval Type combobox before running command
        frmEvaluation.cmboAddEvalType.Items.Clear()

        Try
            ' Command that loads the Eval Type Combobox
            ClsQry.ExeQuery("SELECT wbc_BehaviorChecklistCode AS SubIndex, wbc_BehaviorChecklistText AS [Eval Type], wbc_Evaluations
                            FROM   trefDogBehaviorChecklistCode
                            WHERE (wbc_Evaluations = True)")
            ' If records are found load them into the combobox
            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmEvaluation.cmboAddEvalType.Items.Add(R("Eval Type"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadNewSubTypeCombobox()

        ' Clears the Eval Sub-Type combobox before running command
        frmEvaluation.cmboAddEvalSubType.Items.Clear()

        Try
            If frmEvaluation.cmboAddEvalType.SelectedIndex = 0 Then
                ' Command that loads the Eval Sub-Type Combobox
                ClsQry.ExeQuery("SELECT bcs_BehaviorChecklistSubCode, bcs_BehaviorChecklistText, bcs_BehaviorChecklistCode, bcs_EvalSuccessCode
                                FROM   trefDogBehaviorChecklistSubCode
                                WHERE (bcs_BehaviorChecklistCode = 2)
                                ORDER BY bcs_BehaviorChecklistText")
            ElseIf frmEvaluation.cmboAddEvalType.SelectedIndex = 1 Then
                ClsQry.ExeQuery("SELECT bcs_BehaviorChecklistSubCode, bcs_BehaviorChecklistText, bcs_BehaviorChecklistCode, bcs_EvalSuccessCode
                                From   trefDogBehaviorChecklistSubCode
                                Where (bcs_BehaviorChecklistCode = 3)
                                Order By bcs_BehaviorChecklistText")
            ElseIf frmEvaluation.cmboAddEvalType.SelectedIndex = 2 Then
                ' Command that loads the Eval Sub-Type Combobox
                ClsQry.ExeQuery("SELECT bcs_BehaviorChecklistSubCode, bcs_BehaviorChecklistText, bcs_BehaviorChecklistCode, bcs_EvalSuccessCode
                                From   trefDogBehaviorChecklistSubCode
                                Where (bcs_BehaviorChecklistCode = 6)
                                Order By bcs_BehaviorChecklistText")
            ElseIf frmEvaluation.cmboAddEvalType.SelectedIndex = 3 Then
                ' Command that loads the Eval Sub-Type Combobox
                ClsQry.ExeQuery("SELECT bcs_BehaviorChecklistSubCode, bcs_BehaviorChecklistText, bcs_BehaviorChecklistCode, bcs_EvalSuccessCode
                                From   trefDogBehaviorChecklistSubCode
                                Where (bcs_BehaviorChecklistCode = 7)
                                Order By bcs_BehaviorChecklistText")
            ElseIf frmEvaluation.cmboAddEvalType.SelectedIndex = 4 Then
                ' Command that loads the Eval Sub-Type Combobox
                ClsQry.ExeQuery("SELECT bcs_BehaviorChecklistSubCode, bcs_BehaviorChecklistText, bcs_BehaviorChecklistCode, bcs_EvalSuccessCode
                                From   trefDogBehaviorChecklistSubCode
                                Where (bcs_BehaviorChecklistCode = 8)
                                Order By bcs_BehaviorChecklistText")
            Else
                frmEvaluation.cmboAddEvalSubType.SelectedIndex = -1
            End If
            'If records Then are found load them into the combobox
            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmEvaluation.cmboAddEvalSubType.Items.Add(R("bcs_BehaviorChecklistText"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub ResetNewEval()
        Try
            ' Make sure no item is selected in combobox and Date Time Picker
            frmEvaluation.cmboAddEvalType.SelectedIndex = -1
            frmEvaluation.cmboAddEvalSubType.SelectedIndex = -1
            frmEvaluation.dtpAddEvalDateStarted.ResetText()
            frmEvaluation.dtpAddEvalDateEnded.ResetText()
            frmEvaluation.cmboAddEvaluator.SelectedIndex = -1
            frmEvaluation.cmboAddEvalStatus.SelectedIndex = -1

            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub checkIfValid()

        Try
            If frmEvaluation.cmboAddEvalType.SelectedIndex = -1 Then
                MessageBox.Show("Evaluation Type is Required!!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf frmEvaluation.cmboAddEvalSubType.SelectedIndex = -1 Then
                MessageBox.Show("Evaluation Sub Type is Required!!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf frmEvaluation.dtpAddEvalDateStarted.Value.Date > DateTime.Now Then
                MessageBox.Show("Evaluation start date is Required!!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf frmEvaluation.cmboAddEvaluator.SelectedIndex = -1 Then
                MessageBox.Show("Please select an evaluator!!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf frmEvaluation.cmboAddEvalStatus.SelectedIndex = -1 Then
                MessageBox.Show("Select the status of this evaluation!!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
