Imports System.Data.OleDb

Public Class ControlUser

    Public Function loginUser(kode As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Userr where statusUser = '2' and usernameUser='" & kode & "'", OpenConnection)
            DTS = New DataSet
            DTA.Fill(DTS, "cariUser")
            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UpdateDataUser(Ob As Object) As OleDbCommand
        Dim data As New EntityUser
        data = Ob
        CMD = New OleDbCommand("update Userr set namaUser='" & data.namaUser _
                               & "', hpUser='" & data.hpUser _
                               & "', usernameUser='" & data.usernameUser _
                               & "', passwordUser='" & data.passwordUser _
                               & "' where idUser='" & data.idUser & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function
End Class
