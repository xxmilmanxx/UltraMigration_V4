Public Class frmNewEval
    Public ClsQry As New ClsQryRunner


    Private Sub frmNewEval_Shown(sender As Object, e As EventArgs) Handles Me.Shown



        ' Loads Evaluator Name into Combobox
        LoadNewEvaluatorCombobox()
        ' Loads Eval Type into Combobox
        LoadNewTypeCombobox()
        ' Loads Eval Sub-Type into Combobox
        LoadNewSubTypeCombobox()
        ' Reset the combobox and datetimepicker
        ResetNewEval()
        'once all fields aare entered the add dog button will show
        ShowAddDogButton()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If MessageBox.Show("WAIT A SECOND! Are you sure you want to cancel? This cannot be undone.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Me.Close()

            frmEvalManagement.Show()

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ResetNewEval()

    End Sub

    Private Sub btnAddDogs_Click(sender As Object, e As EventArgs) Handles btnAddDogs.Click

        frmAddDogs.Show()

        Hide()

    End Sub

    Private Sub dtpAddEvalDateStarted_CloseUp(sender As Object, e As EventArgs) Handles dtpAddEvalDateStarted.CloseUp

        Dim aTime As String = DateTime.Now.ToString("dd-MMM-yyyy")
        aTime = dtpAddEvalDateStarted.Value.Date.ToString

        If dtpAddEvalDateStarted.Value.Date > DateTime.Now Then
            MessageBox.Show("Please select a day that is on or before " & aTime & "", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpAddEvalDateStarted.ResetText()

        End If

    End Sub

    Private Sub dtpAddEvalDateEnded_CloseUp(sender As Object, e As EventArgs) Handles dtpAddEvalDateEnded.CloseUp

        Dim bTime As String = DateTime.Now.ToString("dd-MMM-yyyy")
        bTime = dtpAddEvalDateEnded.Value.Date.ToString

        If dtpAddEvalDateEnded.Value.Date > DateTime.Now Then
            MessageBox.Show("Please select a day that is on or before " & bTime & "", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpAddEvalDateEnded.ResetText()

        End If

    End Sub
End Class