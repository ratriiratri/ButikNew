Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlPengeluaran

    Dim Sql As String

    Public Function CariData(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Pengeluaran where idPengeluaran" _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPengeluaran")

            Dim grid As New DataView(DTS.Tables("cariPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilPengeluaran() As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Pengeluaran", OpenConnection)

            Try
                DTS = New DataSet()
                DTS.Tables("tblPengeluaran").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblPengeluaran")
            Dim grid As New DataView(DTS.Tables("tblPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function SimpanData(ByVal _pengeluaran As EntityPengeluaran, ByVal _listBiaya As List(Of EntityDetailBiaya)) As String
        Dim idb As String
        idb = ""
        CloseConnection()

        With _pengeluaran
            Sql = "insert into Pengeluaran values ('" & .idPengeluaran & "','" & .jmlPengeluaran & "','" & .ketPengeluaran & "','" & .tglPengeluaran & "','" & .idUser & "')"
            CMD = New OleDbCommand(Sql, OpenConnection)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", CloseConnection)
        End With

        CloseConnection()

        For i = 0 To _listBiaya.Count - 1
            With _listBiaya(i)
                Sql = "insert into DetailBiaya values ('" & .idBiaya & "','" & .idPengeluaran & "','" & .jumlahBiaya & "','" & .hargaBiaya & "')"
                CMD = New OleDbCommand(Sql, OpenConnection)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OleDbCommand("", CloseConnection)
            End With
        Next

        Return idb

    End Function

    Function FCKdPengeluaran() As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select max(right(idPengeluaran,4)) from Pengeluaran", OpenConnection)

        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = "PL" & Strings.Right("0000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
