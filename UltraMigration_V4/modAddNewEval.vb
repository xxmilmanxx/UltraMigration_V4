Module modAddNewEval

    Public ClsQry As New ClsQryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadNewEvaluatorCombobox()

        ' Clears the Evaluator Name combobox before running command
        frmNewEval.cmboAddEvaluator.Items.Clear()

        Try
            ' Command that loads the Evaluator Name Combobox
            ClsQry.ExeQuery("SELECT DISTINCT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name] " &
                            "FROM (tblEvaluations LEFT OUTER JOIN Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)")
            ' If records are found load them into the combobox
            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmNewEval.cmboAddEvaluator.Items.Add(R("Evaluator Name"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadNewTypeCombobox()

        ' Clears the Eval Type combobox before running command
        frmNewEval.cmboAddEvalType.Items.Clear()

        Try
            ' Command that loads the Eval Type Combobox
            ClsQry.ExeQuery("SELECT DISTINCT trefDogBehaviorChecklistCode.wbc_BehaviorChecklistText AS [Eval Type] " &
                            "FROM (tblEvaluations LEFT OUTER JOIN trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode)")
            ' If records are found load them into the combobox
            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmNewEval.cmboAddEvalType.Items.Add(R("Eval Type"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadNewSubTypeCombobox()

        ' Clears the Eval Sub-Type combobox before running command
        frmNewEval.cmboAddEvalSubType.Items.Clear()

        Try
            ' Command that loads the Eval Sub-Type Combobox
            ClsQry.ExeQuery("SELECT DISTINCT trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Eval Sub-Type] " &
                            "FROM (tblEvaluations LEFT OUTER JOIN trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode)")
            frmNewEval.cmboAddEvalSubType.Items.Clear()
            ' If records are found load them into the combobox
            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmNewEval.cmboAddEvalSubType.Items.Add(R("Eval Sub-Type"))
                Next
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub ResetNewEval()

        ' Make sure no item is selected in combobox and Date Time Picker
        frmNewEval.cmboAddEvalType.SelectedIndex = -1
        frmNewEval.cmboAddEvalSubType.SelectedIndex = -1
        frmNewEval.dtpAddEvalDateStarted.Text = ""
        frmNewEval.dtpAddEvalDateEnded.Text = ""
        frmNewEval.cmboAddEvaluator.SelectedIndex = -1
        frmNewEval.cmboAddEvalStatus.SelectedIndex = -1

    End Sub

End Module
