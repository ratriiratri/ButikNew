Imports System.Data.OleDb

Public Class ControlJurnal
    Dim sql As String

    Public Function SimpanData(ByVal _jurnal As EntityJurnal, ByVal _detail As EntityDetailJurnal2,
                               ByVal _listDetailJurnal As List(Of EntityDetailJurnal)) As OleDbCommand
        With _jurnal
            sql = "SPInsertJurnal '" & Format(.tglJurnal, "yyyy/MM/dd") & "','" & .noBukti & "','" & .ketJurnal & "'"
            DTA = New OleDbDataAdapter(sql, OpenConnection)
            Try
                DTS = New DataSet
                DTS.Tables("tblJurnal").Clear()
            Catch ex As Exception
            End Try
            DTA.Fill(DTS, "tblJurnal")
            .idJurnal = DTS.Tables("tblJurnal").Rows(0)(0).ToString
        End With

        CloseConnection()

        With _detail
            sql = "SpInsertDetailJurnal '" & _jurnal.idJurnal & "','K'," & .nominal & ",'1101'"
            CMD = New OleDbCommand(sql, OpenConnection)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", CloseConnection)
        End With

        CloseConnection()

        For i = 0 To _listDetailJurnal.Count - 1
            With _listDetailJurnal(i)
                sql = "SpInsertDetailJurnal '" & _jurnal.idJurnal & "','" & .jnsNominal _
                    & "'," & .nominal & ",'" & .ref & "'"
                CMD = New OleDbCommand(sql, OpenConnection)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OleDbCommand("", CloseConnection)
            End With
        Next
        Return CMD
    End Function

    Public Function SimpanData2(ByVal _jurnal As EntityJurnal) As OleDbCommand
        With _jurnal
            sql = "SPInsertJurnal '" & Format(.tglJurnal, "yyyy/MM/dd") & "','" & .noBukti & "','" & .ketJurnal & "'"
            CMD = New OleDbCommand(sql, OpenConnection)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", CloseConnection)
        End With

        Return CMD
    End Function


End Class
