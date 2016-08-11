Public Class frmAddDogs

    Public ClsQry As New qryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LocalDogs()

        Me.TblAddDogListTableAdapter.Fill(Me.Ultra_DataDataSet.tblAddDogList)

    End Sub

    Private Sub frmAddDogs_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        LocalDogs()
        PrepDataGrids()
        LoadDogCombobox()
        CompareGrids()
        UpdateDogCount()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelDogs.Click

        Try
            If MessageBox.Show("WAIT A SECOND! Are you sure you want to cancel? This cannot be undone.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                Me.Close()
                frmEvaluation.Show()

            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbxTeam_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboTeam.SelectionChangeCommitted

        FilterDGVDogs()
        CompareGrids()
        UpdateDogCount()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearDogsFilter.Click

        ClearDogFilter()
        LoadDogs()
        CompareGrids()
        UpdateDogCount()

    End Sub

    Private Sub txtDogs_TextChanged(sender As Object, e As EventArgs) Handles txtDogs.TextChanged

        FilterDGVDogs()
        CompareGrids()
        UpdateDogCount()

    End Sub

    Private Sub txtTattoo_TextChanged(sender As Object, e As EventArgs) Handles txtTattoo.TextChanged

        FilterDGVDogs()
        CompareGrids()
        UpdateDogCount()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ResetCurrentDGV()

    End Sub

    Private Sub btnAddSelected_Click(sender As Object, e As EventArgs) Handles btnAddSelected.Click

        SubmitSelectedDogs()
        UpdateDogCount()

    End Sub

    Private Sub DGVSelectDogs_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVSelectDogs.CellMouseDoubleClick

        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow = DGVSelectDogs.Rows(e.RowIndex)
            End If
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DGVSelectDogs_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DGVSelectDogs.CurrentCellDirtyStateChanged

        If DGVSelectDogs.IsCurrentCellDirty Then
            DGVSelectDogs.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub DGVReadyDogs_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DGVReadyDogs.CurrentCellDirtyStateChanged

        If DGVReadyDogs.IsCurrentCellDirty Then
            DGVReadyDogs.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub DGVSelectDogs_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSelectDogs.CellDoubleClick

        Try

            Dim cellChecked As DataGridViewCheckBoxCell = CType(DGVSelectDogs.Rows(e.RowIndex).Cells(0), DataGridViewCheckBoxCell)

            If cellChecked.Value = True Then
                cellChecked.Value = False

            Else
                cellChecked.Value = True

            End If

            UpdateDogCount()

            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGVReadyDogs_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVReadyDogs.CellValueChanged
        Try
            If DGVReadyDogs.Columns(e.ColumnIndex).Name = "Selected" Then
                Dim count As Integer = 0
                For Each checked As DataGridViewRow In DGVReadyDogs.Rows
                    If checked.Cells("Selected").Value IsNot Nothing And checked.Cells("Selected").Value = True Then
                        count += 1
                    End If
                Next
            End If

            UpdateDogCount()
            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSubmitDogs_Click(sender As Object, e As EventArgs) Handles btnSubmitDogs.Click

        CheckIfReady()

        SubmitDogs()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmEvaluation.Show()

    End Sub
End Class