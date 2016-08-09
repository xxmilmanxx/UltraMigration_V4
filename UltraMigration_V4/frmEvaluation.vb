Public Class frmEvaluation
    Public ClsQry As New qryRunner
    Private complete As Boolean

    Private Sub frmNewEval_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' Loads Evaluator Name into Combobox
        LoadNewEvaluatorCombobox()
        ' Loads Eval Type into Combobox
        LoadNewTypeCombobox()
        ' Reset the combobox and datetimepicker
        ResetNewEval()

    End Sub

    Private Sub dtpAddEvalDateStarted_CloseUp(sender As Object, e As EventArgs) Handles dtpAddEvalDateStarted.CloseUp

        Dim aTime As String = DateTime.Now.ToString("dd-MMM-yyyy")
        aTime = dtpAddEvalDateStarted.Value.Date.ToString("dd-MMM-yyyy")

        If dtpAddEvalDateStarted.Value.Date > DateTime.Now Then
            MessageBox.Show("Please select a day that is on or before " & aTime & "", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpAddEvalDateStarted.ResetText()

        End If

    End Sub

    Private Sub dtpAddEvalDateEnded_CloseUp(sender As Object, e As EventArgs) Handles dtpAddEvalDateEnded.CloseUp

        Dim bTime As String = DateTime.Now.ToString("dd-MMM-yyyy")
        bTime = dtpAddEvalDateEnded.Value.Date.ToString("dd-MMM-yyyy")

        If dtpAddEvalDateEnded.Value.Date > DateTime.Now Then
            MessageBox.Show("Please select a day that is on or before " & bTime & "", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpAddEvalDateEnded.ResetText()

        End If

    End Sub

    Private Sub btnSaveNewEval_Click(sender As Object, e As EventArgs) Handles btnSaveNewEval.Click

        checkIfValid()

        Try

            If Me.cmboAddEvalStatus.SelectedIndex = 0 Then
                If MessageBox.Show("Are you sure you want to continue? You have not added any dogs to this evaluation. You can add dogs as long as the status is 'In Progress'. To add evaluation without adding dogs select Yes.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    frmEvalManagement.Show()

                    Me.Close()

                End If
            End If
            If Me.cmboAddEvalStatus.SelectedIndex = 1 Then
                If MessageBox.Show("Are you sure this evaluation is complete? You have not endered any dogs into the evaluation. You will have the ability to add dogs but you will no longer have the ability to edit this data.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    frmEvalManagement.Show()

                    Me.Close()
                End If
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddDogs_Click(sender As Object, e As EventArgs) Handles btnAddDogs.Click

        checkIfValid()

        Try
            If Me.cmboAddEvalStatus.SelectedIndex = 0 Then

                frmAddDogs.Show()

                Me.Hide()
            End If

            If Me.cmboAddEvalStatus.SelectedIndex = 1 Then
                If MessageBox.Show("Are you sure this evaluation is complete after adding dogs? You will no longer have the ability to edit this data.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    frmAddDogs.Show()

                    Me.Hide()
                End If
            End If

            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelNewEval.Click

        If MessageBox.Show("WAIT A SECOND! Are you sure you want to cancel? This cannot be undone.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Me.Close()

            frmEvalManagement.Show()

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearNewEval.Click

        ResetNewEval()

    End Sub

    Private Sub cmboAddEvalType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboAddEvalType.SelectionChangeCommitted

        ' Loads Eval Sub-Type into Combobox
        LoadNewSubTypeCombobox()

    End Sub

    Private Sub frmEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ultra_DataDataSet1.qryTblDogIndex' table. You can move, or remove it, as needed.
        Me.QryTblDogIndexTableAdapter.Fill(Me.Ultra_DataDataSet1.qryTblDogIndex)

    End Sub
End Class