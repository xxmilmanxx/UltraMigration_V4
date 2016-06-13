Imports System.Data.OleDb
Imports System.Data.SqlClient


Public Class ClsQryRunner
    'Connection to database
    Public connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " & "Data Source=ULTRA_Data.accdb;")
    Public DBCmd As OleDbCommand

    'Initiate database
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable
    Public DBDS As DataSet

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
End Class
