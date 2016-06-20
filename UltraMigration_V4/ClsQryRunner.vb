Imports System.Configuration

Public Class ClsQryRunner
    'Connection to database
    Public connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " & "Data Source=ULTRA_Data.accdb;")
    Public DBCmd As OleDbCommand

    'Initiate database
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable
    Public DBDS As DataSet
    ' Public reader As OleDbDataReader

    'Query parameters
    Public Params As New List(Of OleDbParameter)

    'Query statistics
    Public RecordCount As Integer
    Public Exception As String


    Public Sub ExeQuery(Query As String)

        'Reset Stats
        RecordCount = 0
        Exception = ""

        Try
            connection.Open()

            'Create query command
            DBCmd = New OleDbCommand(Query, connection)

            'Load query parameters into query command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Clear parameter list
            Params.Clear()

            'Execute command and fill dataset
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            'Capture errors
            Exception = ex.Message
        End Try

        'Make sure connection is closed
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Sub

    Public Sub AddParam(Name As String, Value As Object)

        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)

    End Sub

    Public Shared Function GetConnectionString(ByVal conName As String) As String
        'variable to hold our connection string for returning it
        Dim strReturn As New String("")
        'check to see if the user provided a connection string name
        'this is for if your application has more than one connection string
        If Not String.IsNullOrEmpty(conName) Then
            'a connection string name was provided
            'get the connection string by the name provided
            strReturn = ConfigurationManager.ConnectionStrings(conName).ConnectionString
        Else
            'no connection string name was provided
            'get the default connection string
            strReturn = ConfigurationManager.ConnectionStrings("UltraMigration_V4.My.MySettings.UltraDataConnectionString").ConnectionString
        End If
        'return the connection string to the calling method
        Return strReturn
    End Function

    Public Shared Sub HandleConnection(ByVal conn As OleDbConnection)
        With conn
            'do a switch on the state of the connection
            Select Case .State
                Case ConnectionState.Open
                    'the connection is open
                    'close then re-open
                    .Close()
                    .Open()
                    Exit Select
                Case ConnectionState.Closed
                    'connection is open
                    'open the connection
                    .Open()
                    Exit Select
                Case Else
                    .Close()
                    .Open()
                    Exit Select
            End Select
        End With
    End Sub


    'Returns a BindingSource, which is used with, for example, a DataGridView control
    Public Shared Function GetBindingSource(ByVal cmd As OleDbCommand) As BindingSource
        'declare our binding source
        Dim oBindingSource As New BindingSource()
        ' Create a new data adapter based on the specified query.
        Dim daGet As New OleDbDataAdapter(cmd)
        ' Populate a new data table and bind it to the BindingSource.
        Dim dtGet As New DataTable()
        'set the timeout of the OleDbCommandObject
        cmd.CommandTimeout = 240
        dtGet.Locale = System.Globalization.CultureInfo.InvariantCulture
        Try
            'fill the DataTable with the OleDbDataAdapter
            daGet.Fill(dtGet)
        Catch ex As Exception
            'check for errors
            MsgBox(ex.Message, "Error in GetBindingSource")
            Return Nothing
        End Try
        'set the DataSource for the BindingSource to the DataTable
        oBindingSource.DataSource = dtGet
        'return the BindingSource to the calling method or control
        Return oBindingSource
    End Function

    Public Function GetRecords() As BindingSource
        'The value that will be passed to the Command Object (this is a query)
        Dim query As String = "SELECT Person_Person.FirstName & ' ' & Person_Person.LastName AS [Evaluator Name], trefDogBehaviorChecklistCode.wbc_BehaviorChecklistText AS [Eval Type], trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistText AS [Eval Sub-Type], tblEvaluations.evl_DateStart AS [Start Date], tblEvaluations.evl_DateEnd AS [End Date], 
             tblEvaluations.evl_DogsEnrolled AS [Dogs Enrolled], IIf(tblEvaluations.CompleteFlag, 'View', 'Edit') AS AddEdit, IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) AS Details
FROM   (((tblEvaluations LEFT OUTER JOIN
             trefDogBehaviorChecklistCode ON tblEvaluations.evl_ReportTypeCode = trefDogBehaviorChecklistCode.wbc_BehaviorChecklistCode) LEFT OUTER JOIN
             trefDogBehaviorChecklistSubCode ON tblEvaluations.evl_ReportTypeSubCode = trefDogBehaviorChecklistSubCode.bcs_BehaviorChecklistSubCode) LEFT OUTER JOIN
             Person_Person ON tblEvaluations.evl_EvaluatorID = Person_Person.BusinessEntityId)
WHERE (IIf(tblEvaluations.CompleteFlag, 'View', 'Edit') IS NOT NULL) OR
             (IIf(tblEvaluations.evl_DogsEnrolled, 'Dog Evals', NULL) > '0')
ORDER BY tblEvaluations.evl_DateStart DESC"
        Dim cnGetRecords As New OleDbConnection(GetConnectionString("UltraMigration_V4.My.MySettings.UltraDataConnectionString"))
        'OleDbConnection Object to use
        Dim cmdGetRecords As New OleDbCommand()
        'OleDbCommand Object to use
        Dim daGetRecords As New OleDbDataAdapter()
        Dim dsGetRecords As New DataSet()
        'Clear any parameters
        cmdGetRecords.Parameters.Clear()
        Try
            With cmdGetRecords
                'set the OleDbCommand Object Parameters
                .CommandText = query
                'tell it what to execute
                .CommandType = CommandType.Text
                'Set the Connection for the Command Object
                .Connection = cnGetRecords
            End With
            'set the state of the OleDbConnection Object
            HandleConnection(cnGetRecords)
            'create BindingSource to return for our DataGrid Control
            Dim oBindingSource As BindingSource = GetBindingSource(cmdGetRecords)
            'now check to make sure a BindingSource was returned
            If Not oBindingSource Is Nothing Then
                'return the binding source to the calling method
                Return oBindingSource
            Else
                'no binding source was returned
                'let the user know the error
                Throw New Exception("There was no BindingSource returned")
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error Retrieving Data")
            Return Nothing
        Finally
            HandleConnection(cnGetRecords)
        End Try
    End Function
End Class
