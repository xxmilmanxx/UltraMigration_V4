Module modUltraUtilities
    Public ClsQry As New qryRunner
    Public avarKeyID(MAX_KEYS) As Object

    Public glbFiscalYear As Object
    Public glbClassID As Object
    Public glbClassComputerID As Object
    Public glbTeamID As Object

    '   ***** Global Report Data *****
    Public glbMode As Integer '0 = All, 1 = By Region; 2 = By PE; 3 = Breed
    Public glbModeS As String
    Public glbGroupCode As Integer 'reg_GroupCode from tbl_Regions
    Public glbRegion As Long 'reg_RegionCode from tbl_Regions
    Public glbRegionS As String
    Public glbPE As Long 'reg_StaffSupervisorCode from tbl_Regions
    Public glbBreed As Integer '1 = GR; 2 = GS; 4 = LR; 5 = GLAB
    Public glbOrderBy As Integer '0 = dog_DOB; 1 = dog_CallName
    Public glbActive As Integer '0 = Inactive; 1 = Active
    Public glbEmail As Integer '0 = No Email; 1 = Email

    '   ***** Global Program Data *****
    Public glbGEBID As Long
    Public glbRetVal As Object
    Public glbLogging As Integer
    Public glbLogData As Object
    Public glbPersonDogKey As String
    Public glbResPlHold As Long
    Public glbHelpOpen As Integer
    Public glbHelpKey As Object
    Public glbFileName As String
    Public glbSQLString As String
    Public glbSQLParam As Long
    Public glbSQLParam2 As Long
    Public glbSQLParam3 As Long
    Public glbSQLParam4 As Long
    Public glbSQLParamString As Object
    Public glbSQLParamString2 As Object
    Public glbSQLParamString3 As Object
    Public glbSQLParamString4 As Object
    Public glbSQLParamString5 As Object
    Public glbSQLParamString6 As Object
    Public glbSQLParamString7 As Object
    Public glbSQLParamString8 As Object
    Public glbSavePrm1 As Object
    Public glbSavePrm2 As Object
    Public glbDateParam As Object
    Public glbEditFlag As Boolean
    Public glbTitle As Object
    Public glbWhereCode As Integer
    Public glbFindCode As Integer
    Public glbWhatNext As Integer
    Public glbWhatNext2 As Integer
    Public glbLinkCode As Object
    Public glbNextForm As Object
    Public glbMemoSave As Object
    Public glbNbrSave As Object
    Public glbTextSave As Object
    Public glbDateSave As Object
    Public glbKeySave As Object
    Public glb516Key As Object
    Public glb517Key As Object
    Public glbL1Code As Integer
    Public glbL2Code As Integer
    Public glbRequeryFlag As Boolean

    Public glbWebFileID As Object
    Public glbWebFileName As Object
    Public glbWebPersonID As Object
    Public glbWebApplicID As Object

    Public Const MAX_USERS = 150  'Maximum number of users in the database
    Public Const MAX_EVENT = 200  'Maximum number of defined events.
    Public Const MAX_USER = 10    'Maximum number of users each event can post to.

    Public astrUserName(MAX_USERS) As String
    Public astrUserType(MAX_USERS) As Object
    Public astrUserAdmn(MAX_USERS) As Object
    Public astrUserUtilities(MAX_USERS) As Object
    Public astrUserConf(MAX_USERS) As Object
    Public astrUserDog(MAX_USERS) As Object
    Public astrUserLitter(MAX_USERS) As Object
    Public astrUserPerson(MAX_USERS) As Object
    Public aintEventUser(MAX_EVENT, MAX_USER) As Integer
    Public astrGrpName(MAX_USERS) As String

    Public Const cBreakOnAll As Long = 0
    Public Const cBreakInClass As Long = 1
    Public Const cBreakUnhandled As Long = 2
    Public Const cGap As Long = 100
    Private DOG_KEY As Integer
    Private ReadOnly MyLogSet As Object
    Public Property MAX_KEYS As Object
    Public Property PERSON_KEY As Integer

    Public Const NullDate As String = "12:00:00 AM"
    Public evalEditFlag As Boolean
    Public TestEditFlag As Boolean
    Public TrngAidFlag As Boolean
    Public tmpRecordset As String
    Public tmpSort As String
    Private m_FilterFlag As Boolean

    Public be As New Ultra_DataDataSet.Person_BusinessEntityDataTable

    Public Function GetGUID() As String
        GetGUID = Mid$(CreateObject("Scriptlet.TypeLib").Guid, 2, 36)
    End Function

    Function SetLastForm(frm As Form) As Boolean
        ' Dim MyLogSet As New RecordsetWrapper
        Dim glbLastForm As Object = frm
        Dim glbLastFormName As Object = frm.Name

        If glbLogging Then
            If MyLogSet.OpenRecordset("tblAALogData") Then
                With MyLogSet.RecordSet
                    If Not IsDBNull(avarKeyID(PERSON_KEY)) Then
                        glbPersonDogKey = Str(avarKeyID(PERSON_KEY)) & " "
                    Else
                        glbPersonDogKey = "Null "
                    End If
                    If Not IsDBNull(avarKeyID(DOG_KEY)) Then
                        glbPersonDogKey = glbPersonDogKey & Str(avarKeyID(DOG_KEY))
                    Else
                        glbPersonDogKey = glbPersonDogKey & "Null"
                    End If
                    .AddNew
                    '!log_UserID = sec.UserId
                    !log_DateTime = Now
                    !log_Type = 1
                    !log_Form = glbLastFormName
                    !log_LogData = glbPersonDogKey
                    .Update
                End With
            End If
        End If
        SetLastForm = True
    End Function
End Module
