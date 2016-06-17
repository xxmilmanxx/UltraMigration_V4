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

        frmEvalManagement.cmboEvaluator.Items.Clear()

        Try
            frmEvalManagement.TblEvaluationsTableAdapter.FillEvaluatorName(frmEvalManagement.UltraEvalDataSet.tblEvaluations)

            For Each R As DataRow In frmEvalManagement.UltraEvalDataSet.tblEvaluations.Rows
                frmEvalManagement.cmboEvaluator.Items.Add(R("Evaluator Name"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadEvalTypeCombobox()

        frmEvalManagement.cmboType.Items.Clear()
        Try
            frmEvalManagement.TblEvaluationsTableAdapter.FillEvalType(frmEvalManagement.UltraEvalDataSet.tblEvaluations)

            For Each R As DataRow In frmEvalManagement.UltraEvalDataSet.tblEvaluations.Rows
                frmEvalManagement.cmboType.Items.Add(R("Eval Type"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadEvalSubTypeCombobox()

        frmEvalManagement.cmboSubType.Items.Clear()
        Try
            frmEvalManagement.TblEvaluationsTableAdapter.FillEvalSubType(frmEvalManagement.UltraEvalDataSet.tblEvaluations)

            For Each R As DataRow In frmEvalManagement.UltraEvalDataSet.tblEvaluations.Rows
                frmEvalManagement.cmboSubType.Items.Add(R("Eval Sub-Type"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub FilterDataGridView()

        Try
            If frmEvalManagement.cmboEvaluator.SelectedIndex > -1 Then
                ClsQry.ExeQuery("SELECT * From frmEvalManagement.UltraEvalDataSet.tblEvaluations WHERE [Evaluator Name] = '" & frmEvalManagement.cmboEvaluator.SelectedIndex & "'")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub UpdateEvalMngntTable()
        'Will update the current  Table in the frmEvalManagement Form
        Dim evalRowCount As String = frmEvalManagement.DGVfrmEvalManagement.Rows.Count
        frmEvalManagement.txtRecordsCount.Text = evalRowCount & " EVALUATIONS SHOWING"

    End Sub
End Module
