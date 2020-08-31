Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlPendapatan
    Dim Sql As String

    Public Function SimpanData(ByVal _pendapatan As EntityPendapatan,
                               ByVal _listProduk As List(Of EntityDetailProduk)) As String
        Dim idb As String
        idb = ""
        CloseConnection()

        With _pendapatan
            Sql = "insert into Pendapatan values ('" & .idPendapatan & "','" & .jmlPendapatan _
                  & "','" & .ketPendapatan & "','" & .tglPendapatan & "','" & .idUser & "')"
            CMD = New OleDbCommand(Sql, OpenConnection)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", CloseConnection)
        End With

        CloseConnection()

        For i = 0 To _listProduk.Count - 1
            With _listProduk(i)
                Sql = "insert into DetailProduk values ('" & .idProduk & "','" & .idPendapatan _
                      & "','" & .jumlahProduk & "','" & .discProduk & "')"
                CMD = New OleDbCommand(Sql, OpenConnection)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OleDbCommand("", CloseConnection)
            End With
        Next
        CloseConnection()
        Return idb
    End Function

    Public Function SimpanData2(ByVal _pendapatan As EntityPendapatan,
                                ByVal _listJasa As List(Of EntityDetailJasa)) As String
        Dim idb As String
        idb = ""
        CloseConnection()

        With _pendapatan
            Sql = "insert into Pendapatan values ('" & .idPendapatan & "','" & .jmlPendapatan _
                & "','" & .ketPendapatan & "','" & .tglPendapatan & "','" & .idUser & "')"
            CMD = New OleDbCommand(Sql, OpenConnection)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", CloseConnection)
        End With

        CloseConnection()

        For i = 0 To _listJasa.Count - 1
            With _listJasa(i)
                Sql = "insert into DetailJasa values ('" & .idJasa & "','" & .idPendapatan _
                    & "','" & .jumlahJasa & "','" & .discJasa & "')"
                CMD = New OleDbCommand(Sql, OpenConnection)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OleDbCommand("", CloseConnection)
            End With
        Next
        Return idb
    End Function

    Function FCKdPendapatan() As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select isnull(max(right(idPendapatan,4)),0) from Pendapatan", OpenConnection)

        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = "PD" & Strings.Right("0000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
