Module modAddDogs

    Public ClsQry As New qryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadDogs()

        Try
            ClsQry.ExeQuery("SELECT DISTINCT False AS Selected, HumanResources_TrainingTeam.TeamName AS Team, tblDog.dog_CallName AS Dog, tblDog.dog_Tattoo AS Tattoo
                            FROM    ((tblDog INNER JOIN
                                    ((HumanResources_TrainingTeam RIGHT OUTER JOIN
                                    (trefDogEvaluationStatusCode RIGHT OUTER JOIN
                                    tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
                                    tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
                                    tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
                            WHERE (tblDogTrngBlock.BlockOfInstruction <> 1) AND (tblDogTrngBlock.Status = 1) AND (tblDogTrngBlock.StartDate IS NOT NULL) AND (tblDogClassAssignment.DateCompleted IS NULL)
                            ORDER BY HumanResources_TrainingTeam.TeamName")
            ' Check for errors before continuung
            If Not String.IsNullOrEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

            frmAddDogs.DGVSelectDogs.DataSource = ClsQry.DBDT.DefaultView

            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadDogCombobox()

        ' Clears the Team combobox before running command
        frmAddDogs.cmboTeam.Items.Clear()
        Try
            ClsQry.ExeQuery("SELECT HumanResources_TrainingTeam.TeamName AS Team, HumanResources_TrainingTeam.TrainingTeamId
                            FROM HumanResources_TrainingTeam
                            ORDER BY HumanResources_TrainingTeam.Order")

            If ClsQry.RecordCount > 0 Then
                For Each R As DataRow In ClsQry.DBDT.Rows
                    frmAddDogs.cmboTeam.Items.Add(R("Team"))
                Next
            End If


            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub PrepDataGrids()

        For c = 0 To frmAddDogs.DGVSelectDogs.Columns.Count - 1
            frmAddDogs.DGVReadyDogs.Columns.Add(frmAddDogs.DGVSelectDogs.Columns(c).Clone())

        Next
    End Sub

    Public Sub FilterDGVDogs()

        Dim filterTeam As String = frmAddDogs.cmboTeam.Text
        Dim filterDog As String = frmAddDogs.txtDogs.Text.Trim
        Dim filterTattoo As String = frmAddDogs.txtTattoo.Text.Trim

        Try
            If frmAddDogs.cmboTeam.SelectedIndex > -1 And frmAddDogs.txtDogs.TextLength > 0 And frmAddDogs.txtTattoo.TextLength > 0 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL)  And HumanResources_TrainingTeam.TeamName= '" & filterTeam & "' And tblDog.dog_CallName LIKE '%" & filterDog & "%' And tblDog.dog_Tattoo LIKE '%" & filterTattoo & "%'
ORDER BY tblDog.dog_CallName")
            ElseIf frmAddDogs.cmboTeam.SelectedIndex > -1 And frmAddDogs.txtDogs.TextLength > 0 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL)  And HumanResources_TrainingTeam.TeamName= '" & filterTeam & "' And tblDog.dog_CallName LIKE '%" & filterDog & "%'")
            ElseIf frmAddDogs.cmboTeam.SelectedIndex > -1 And frmAddDogs.txtTattoo.TextLength > 0 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL) And HumanResources_TrainingTeam.TeamName= '" & filterTeam & "' And tblDog.dog_Tattoo LIKE '%" & filterTattoo & "%'")
            ElseIf frmAddDogs.txtDogs.TextLength > 0 And frmAddDogs.txtTattoo.TextLength > 0 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL)  And tblDog.dog_CallName LIKE '%" & filterDog & "%' And tblDog.dog_Tattoo LIKE '%" & filterTattoo & "%'")
            ElseIf frmAddDogs.cmboTeam.SelectedIndex > -1 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL)  And HumanResources_TrainingTeam.TeamName= '" & filterTeam & "'
ORDER BY tblDog.dog_CallName")
            ElseIf frmAddDogs.txtDogs.TextLength > 0 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL)  And tblDog.dog_CallName LIKE '%" & filterDog & "%'")
            ElseIf frmAddDogs.txtTattoo.TextLength > 0 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL)  And tblDog.dog_Tattoo LIKE '%" & filterTattoo & "%'")
            Else
                ClsQry.ExeQuery("SELECT DISTINCT HumanResources_TrainingTeam.TeamName AS Team, tblDog.dog_CallName AS Dog, tblDog.dog_Tattoo AS Tattoo
                             FROM   ((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
                            WHERE (tblDogTrngBlock.BlockOfInstruction <> 1) AND (tblDogTrngBlock.Status = 1) AND (tblDogTrngBlock.StartDate IS NOT NULL) AND (tblDogClassAssignment.DateCompleted IS NULL)
                            ORDER BY HumanResources_TrainingTeam.TeamName")
            End If

            ' Check for errors before continuung
            If Not String.IsNullOrEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

            frmAddDogs.DGVSelectDogs.DataSource = ClsQry.DBDT.DefaultView

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub SubmitSelectedDogs()
        Try
            Dim c As Integer
            Dim r As Integer


            If frmAddDogs.DGVReadyDogs.SelectedRows.Count < 0 Then
                frmAddDogs.DGVReadyDogs.Columns.Clear()
            End If

            For c = frmAddDogs.DGVSelectDogs.Rows.Count() - 1 To 0 Step -1

                Dim add As Boolean = frmAddDogs.DGVSelectDogs.Rows(c).Cells(0).Value

                If add = True Then

                    frmAddDogs.DGVReadyDogs.Rows.Add(frmAddDogs.DGVSelectDogs.Rows(c).Cells(0).Value, frmAddDogs.DGVSelectDogs.Rows(c).Cells(1).Value, frmAddDogs.DGVSelectDogs.Rows(c).Cells(2).Value, frmAddDogs.DGVSelectDogs.Rows(c).Cells(3).Value)

                End If

            Next

            For r = frmAddDogs.DGVSelectDogs.Rows.Count() - 1 To 0 Step -1

                Dim delete As Boolean = frmAddDogs.DGVSelectDogs.Rows(r).Cells(0).Value

                If delete = True Then

                    Dim deleteRows As DataGridViewRow
                    deleteRows = frmAddDogs.DGVSelectDogs.Rows(r)
                    frmAddDogs.DGVSelectDogs.Rows.Remove(deleteRows)

                End If

            Next

            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub CompareGrids()

        Try

            Dim m As Integer

            For m = frmAddDogs.DGVReadyDogs.Rows.Count() - 1 To 0 Step -1

                Dim match As Boolean = frmAddDogs.DGVReadyDogs.Rows(m).Cells(0).Value

                If match = True Then

                    Dim deleteMatch As DataGridViewRow
                    deleteMatch = frmAddDogs.DGVSelectDogs.Rows(m)
                    frmAddDogs.DGVSelectDogs.Rows.Remove(deleteMatch)

                End If

            Next

            ' Report errors
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ClearDogFilter()
        Try

            frmAddDogs.cmboTeam.SelectedIndex = -1
            frmAddDogs.txtDogs.Text = ""
            frmAddDogs.txtTattoo.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub ResetCurrentDGV()

        Try

            For Each dr As DataGridViewRow In frmAddDogs.DGVSelectDogs.Rows

                If CBool(dr.Cells(0).Value) = True Then dr.Cells(0).Value = False Continue For

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub UpdateDogCount()
        Dim dogCountCheck As Integer = 0
        Dim addCountCheck As Integer = 0

        Try
            For r = frmAddDogs.DGVSelectDogs.Rows.Count() - 1 To 0 Step -1
                ' Update the current Table in the frmEvalManagement Form
                Dim dogRowCount As String = frmAddDogs.DGVSelectDogs.Rows.Count

                If frmAddDogs.DGVSelectDogs.Rows(r).Cells(0).Value = True Then

                    dogCountCheck += 1

                    frmAddDogs.txtDogCount.Text = dogRowCount & " DOGS SHOWING AND " & dogCountCheck.ToString() & " DOGS SELECTED"
                Else
                    frmAddDogs.txtDogCount.Text = dogRowCount & " DOGS SHOWING"
                End If
            Next

            For s = frmAddDogs.DGVReadyDogs.Rows.Count() - 1 To 0 Step -1
                ' Update the current Table in the frmEvalManagement Form
                Dim addCount As String = frmAddDogs.DGVReadyDogs.Rows.Count

                ' Dim checkDogReadyDogs As Boolean = frmAddDogs.DGVReadyDogs.Rows(addCountCheck).Cells(0).Value

                If frmAddDogs.DGVReadyDogs.Rows(s).Cells(0).Value = True Then

                    addCountCheck += 1
                    frmAddDogs.txtSelectCount.Text = addCount & " DOGS ADDED AND " & addCountCheck.ToString() & " DOGS SELECTED"
                Else
                    frmAddDogs.txtSelectCount.Text = addCount & " DOGS ADDED"
                End If
                ' Show the number of dogs currently in data grid
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Module
