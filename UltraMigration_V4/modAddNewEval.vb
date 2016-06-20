Module modAddNewEval

    Public ClsQry As New ClsQryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub ClearNewEval()

        frmNewEval.cmboAddEvalType.SelectedIndex = -1
        frmNewEval.cmboAddEvalSubType.SelectedIndex = -1
        frmNewEval.dtpAddEvalDateStarted.Text = ""
        frmNewEval.dtpAddEvalDateEnded.Text = ""
        frmNewEval.cmboAddEvaluator.SelectedIndex = -1
        frmNewEval.cmboAddEvalStatus.SelectedIndex = -1

    End Sub

    Public Sub LoadNewEvalCombobox()
        frmNewEval.cmboAddEvalType.Items.Clear()

        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
























End Module
