Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlPengeluaran : Implements InterfaceProses

    Dim Sql As String

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InterfaceProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InterfaceProses.UpdateData
        Dim data As New EntityPengeluaran
        data = Ob
        CMD = New OleDbCommand("update Pengeluaran set jmlPengeluaran='" & data.jmlPengeluaran _
                               & "',ketPengeluaran='" & data.ketPengeluaran _
                               & "' where idPengeluaran='" & data.idPengeluaran & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements InterfaceProses.DeleteData
        CMD = New OleDbCommand("delete from Pengeluaran where idPengeluaran='" & kunci & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
    End Function

    Public Function TampilData() As DataView Implements InterfaceProses.TampilData
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

    Public Function CariData(kunci As String) As DataView Implements InterfaceProses.CariData
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

    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(idPengeluaran) from Pengeluaran " _
                                   & "where idPengeluaran='" & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cekData")
            If DTS.Tables("cekData").Rows(0)(0).ToString > 0 Then cek = True

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return cek
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
                Sql = "insert into DetailBiaya values ('" & .idBiaya & "','" & .idPengeluaran & "','" & .jumlahBiaya & "')"
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
