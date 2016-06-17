Public Class frmEvalManagement
    Public ClsQry As New ClsQryRunner
    Dim myBindingSource As New DataTable

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmEvalManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'TblEvaluationsBindingSource.DataSource = UltraEvalDataSet.tblEvaluations.DefaultView()

        ' DGVfrmEvalManagement.DataSource = TblEvaluationsBindingSource


        LoadEvaluatorCombobox()
        LoadEvalTypeCombobox()
        LoadEvalSubTypeCombobox()
        ClearEvalManagementFilters()
        LoadGrid()
        'FilterAll()

        UpdateEvalMngntTable()

    End Sub

    Private Sub LoadGrid()

        myBindingSource = UltraEvalDataSet.tblEvaluations

        TblEvaluationsTableAdapter.Fill(myBindingSource)

        DGVfrmEvalManagement.DataSource = myBindingSource


        'Me.TblEvaluationsTableAdapter.Fill(Me.UltraEvalDataSet.tblEvaluations)


    End Sub

    Public Sub FilterName()
        Try
            '  If cmboEvaluator.SelectedIndex > -1 Then
            ' ClsQry.ExeQuery("SELECT * FROM UltraEvalDataSet.tblEvaluations WHERE [Evaluator Name] = '" & cmboEvaluator.SelectedIndex & "'")

            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub FilterType()
        Try
            '    If cmboType.SelectedIndex > -1 Then
            '   ClsQry.ExeQuery("SELECT * FROM tblEvaluations WHERE [Eval Type] = '" & cmboType.SelectedIndex & "'")
            '  End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub FilterAll()
        Dim criteria As New List(Of String)

        If cmboEvaluator.SelectedIndex > -1 Then
            criteria.Add(String.Format("[Evaluator Name] LIKE '{0}%'", cmboEvaluator.SelectedText))
        End If

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

        LoadGrid()

        UpdateEvalMngntTable()

    End Sub

    Private Sub cmboEvaluator_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboEvaluator.SelectionChangeCommitted
        FilterName()

        UpdateEvalMngntTable()

    End Sub
End Class
