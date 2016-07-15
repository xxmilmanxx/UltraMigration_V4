Imports System.ComponentModel

Public Class frmAddDogs

    Private Sub frmAddDogs_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        LoadDogs()
        LoadDogCombobox()
        UpdateDogCount()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If MessageBox.Show("WAIT A SECOND! Are you sure you want to cancel? This cannot be undone.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Me.Close()
            frmNewEval.Show()

        End If

    End Sub

    Private Sub cmbxTeam_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboTeam.SelectionChangeCommitted

        FilterDGVDogs()
        UpdateDogCount()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearDogFilter()
        LoadDogs()
        UpdateDogCount()

    End Sub

    Private Sub txtDogs_TextChanged(sender As Object, e As EventArgs) Handles txtDogs.TextChanged

        FilterDGVDogs()
        UpdateDogCount()

    End Sub

    Private Sub txtTattoo_TextChanged(sender As Object, e As EventArgs) Handles txtTattoo.TextChanged

        FilterDGVDogs()
        UpdateDogCount()

    End Sub
End Class