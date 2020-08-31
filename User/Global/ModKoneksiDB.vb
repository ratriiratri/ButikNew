Imports System.Data.OleDb

Module ModKoneksiDB
    Public DTR As OleDbDataReader
    Public CMD As New OleDbCommand
    Public DTA As New OleDbDataAdapter
    Public DTS As New DataSet
    Public DTT As New DataTable
    Public DTGrid As New DataTable
    Public strKon = "Provider=SQLNCLI11;Data Source=192.168.43.113;User ID=butik;Initial Catalog=ButikDaurUlang;Password=butik"
    Public Connection As New OleDbConnection(strKon)

    Public Function OpenConnection() As OleDbConnection
        Try
            If Connection.State = ConnectionState.Closed Then Connection.Open()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Connection
    End Function

    Public Function CloseConnection() As OleDbConnection
        Connection.Close()
        Return Connection
    End Function
End Module
