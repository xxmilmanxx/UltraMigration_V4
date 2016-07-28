Module modAddDogs

    Public ClsQry As New qryRunner


    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadDogs()

        Try
            ClsQry.ExeQuery("SELECT DISTINCT HumanResources_TrainingTeam.TeamName AS Team, tblDog.dog_CallName AS Dog, tblDog.dog_Tattoo AS Tattoo
                             FROM   ((tblDog INNER JOIN
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

    Public Sub LoadAdded()

        Try
            ClsQry.ExeQuery("SELECT * FROM [tblReadyDogs]")

            ' Check for errors before continuung
            If Not String.IsNullOrEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

            frmAddDogs.DGVReadyDogs.DataSource = ClsQry.DBDT.DefaultView
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
            Dim e As DataGridViewCellEventArgs = New DataGridViewCellEventArgs(0, -1)


            For Each row As DataGridViewRow In frmAddDogs.DGVSelectDogs.Rows

                If frmAddDogs.DGVSelectDogs.Rows(e.RowIndex).Cells(0).Value = True Then
                    ClsQry.ExeQuery("UPDATE tblReadyDogs
                               SET Added = (SELECT Selected
                                            FROM tblAddDogList)")

                End If

            Next
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

        Try

            ' Update the current Table in the frmEvalManagement Form
            Dim dogRowCount As String = frmAddDogs.DGVSelectDogs.Rows.Count
            ' Show the number of dogs currently in data grid
            frmAddDogs.txtDogCount.Text = dogRowCount & " DOGS SHOWING"
            ' Update the current Table in the frmEvalManagement Form
            Dim addCount As String = frmAddDogs.DGVReadyDogs.Rows.Count
            ' Show the number of dogs currently in data grid
            frmAddDogs.txtSelectCount.Text = addCount & " DOGS ADDED"

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Module
