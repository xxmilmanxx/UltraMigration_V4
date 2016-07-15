Module modAddDogs

    Public ClsQry As New ClsQryRunner

    Public Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadDogs()
        '  frmAddDogs.TblAddDogListTableAdapter.Fill(frmAddDogs.Ultra_DataDataSet.tblAddDogList)
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

            frmAddDogs.DGVAddDogs.DataSource = ClsQry.DBDT.DefaultView

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

        Dim filterTeam As String = frmAddDogs.cmboTeam.SelectedItem
        Dim filterDog As String = frmAddDogs.txtDogs.Text.Trim
        Dim filterTattoo As String = frmAddDogs.txtTattoo.Text.Trim

        Try
            If frmAddDogs.cmboTeam.SelectedIndex > -1 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL)  And HumanResources_TrainingTeam.TeamName= '" & filterTeam & "'
ORDER BY tblDog.dog_CallName")
            End If
            If frmAddDogs.txtDogs.TextLength > 0 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL)  And tblDog.dog_CallName LIKE '%" & filterDog & "%'")
            End If
            If frmAddDogs.txtTattoo.TextLength > 0 Then
                ClsQry.ExeQuery("Select DISTINCT HumanResources_TrainingTeam.TeamName As Team, tblDog.dog_CallName As Dog, tblDog.dog_Tattoo As Tattoo
FROM((tblDog INNER JOIN
             ((HumanResources_TrainingTeam RIGHT OUTER JOIN
             (trefDogEvaluationStatusCode RIGHT OUTER JOIN
             tblDogClassAssignment ON trefDogEvaluationStatusCode.esc_EvaluationStatusCode = tblDogClassAssignment.QualificationStatusId) ON HumanResources_TrainingTeam.TrainingTeamId = tblDogClassAssignment.TeamId) INNER JOIN
             tblDogTrngBlock ON tblDogClassAssignment.DogClassAssignmentId = tblDogTrngBlock.DogClassEnrollmentId) ON tblDog.dog_DogID = tblDogClassAssignment.DogId) LEFT OUTER JOIN
             tblDogEvaluations ON tblDogTrngBlock.BlockId = tblDogEvaluations.DogBlockId)
WHERE(tblDogTrngBlock.BlockOfInstruction <> 1) And (tblDogTrngBlock.Status = 1) And (tblDogTrngBlock.StartDate Is Not NULL) And (tblDogClassAssignment.DateCompleted Is NULL)  And tblDog.dog_Tattoo LIKE '%" & filterTattoo & "%'")
            End If
            ' Check for errors before continuung
            If Not String.IsNullOrEmpty(ClsQry.Exception) Then MsgBox(ClsQry.Exception) : Exit Sub

            frmAddDogs.DGVAddDogs.DataSource = ClsQry.DBDT.DefaultView

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

    Public Sub UpdateDogCount()

        Try

            ' Update the current Table in the frmEvalManagement Form
            Dim dogRowCount As String = frmAddDogs.DGVAddDogs.Rows.Count
            ' Show the number of evaluations currently in data grid
            frmAddDogs.txtDogCount.Text = dogRowCount & " DOGS SHOWING"
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Module
