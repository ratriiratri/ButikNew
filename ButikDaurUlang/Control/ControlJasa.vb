﻿Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlJasa : Implements InterfaceProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InterfaceProses.InsertData
        Dim data As New EntityJasa
        data = Ob
        CMD = New OleDbCommand("insert into Jasa values('" & data.idJasa & "','" & data.namaJasa & "','" & data.hargaJasa & "')", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InterfaceProses.UpdateData
        Dim data As New EntityJasa
        data = Ob
        CMD = New OleDbCommand("update Jasa set namaJasa ='" & data.namaJasa _
                               & "',hargaJasa='" & data.hargaJasa _
                               & "' where idJasa='" & data.idJasa & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements InterfaceProses.DeleteData
        CMD = New OleDbCommand("delete from Jasa where idJasa='" & kunci & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements InterfaceProses.TampilData
        Try
            DTA = New OleDbDataAdapter("select * from Jasa", OpenConnection)

            Try
                DTS = New DataSet()
                DTS.Tables("tblJasa").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblJasa")
            Dim grid As New DataView(DTS.Tables("tblJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(idJasa) from DetailJasa " _
                                   & "where idJasa='" & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cekData")
            If DTS.Tables("cekData").Rows(0)(0).ToString > 0 Then cek = True

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return cek
        End Try
    End Function

    Public Function CariDataIDJasa(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where js.idJasa Like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUser(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where us.idUser Like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDPendapatan(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where pd.idPendapatan Like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNamaJasa(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where js.namaJasa Like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataTanggalPendapatan(kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilDetailJasa() As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser", OpenConnection)
            Try
                DTS = New DataSet()
                DTS.Tables("tblDetailJasa").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblDetailJasa")

            Dim grid As New DataView(DTS.Tables("tblDetailJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function FCKdJasa() As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select max(right(idJasa,4)) from Jasa", OpenConnection)

        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = "JS" & Strings.Right("0000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements InterfaceProses.CariData
        Throw New NotImplementedException()
    End Function
End Class
