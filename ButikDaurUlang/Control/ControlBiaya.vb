Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlBiaya : Implements InterfaceProses

    Public Function InsertData2(ByVal Biaya As EntityBiaya, ByVal kel As Integer) As OleDbCommand
        CloseConnection()
        With Biaya
            CMD = New OleDbCommand("insert into Biaya values(dbo.FCKdBiaya('" & kel & "')'" & .idBiaya _
                                   & "','" & .namaBiaya & "','" & .jnsSaldo & "')", OpenConnection)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", CloseConnection)
        End With
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InterfaceProses.InsertData
        Dim data As New EntityBiaya
        data = Ob
        CMD = New OleDbCommand("insert into Biaya values('" & data.idBiaya & "','" & data.namaBiaya _
            & "','" & data.jnsSaldo & "')", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InterfaceProses.UpdateData
        Dim data As New EntityBiaya
        data = Ob
        CMD = New OleDbCommand("update Biaya set namaBiaya='" & data.namaBiaya & "' where idBiaya='" _
                               & data.idBiaya & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements InterfaceProses.DeleteData
        CMD = New OleDbCommand("delete from Biaya where idBiaya='" & kunci & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements InterfaceProses.TampilData
        Try
            DTA = New OleDbDataAdapter("select idBiaya, namaBiaya from Biaya where " _
                                       & "jnsSaldo != ''", OpenConnection)
            Try
                DTS = New DataSet()
                DTS.Tables("tblBiaya").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblBiaya")
            Dim grid As New DataView(DTS.Tables("tblBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDBiaya(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where b.idBiaya like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDBiayaTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where b.idBiaya like '%" & kunci & "%' and " _
                                       & "pl.tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDPengeluaranTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where pl.idPengeluaran like '%" & kunci & "%' and " _
                                       & "pl.tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDPengeluaran(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where pl.idPengeluaran like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUser(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where us.idUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUserTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where us.idUser like '%" & kunci & "%' and " _
                                       & "pl.tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNamaBiaya(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where b.namaBiaya like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNamaBiayaTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where b.namaBiaya like '%" & kunci & "%' and " _
                                       & "pl.tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataTanggalPengeluaran(kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, " _
                                       & "db.hargaBiaya, pl.idPengeluaran, " _
                                       & "convert(varchar, pl.tglPengeluaran,106), " _
                                       & "us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = " _
                                       & "db.idBiaya join Pengeluaran pl on pl.idPengeluaran " _
                                       & "= db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where pl.tglPengeluaran " _
                                       & "between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select idBiaya from DetailBiaya where idBiaya='" _
                                       & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows.Count > 0 Then
                cek = True
            End If
        Catch ex As Exception
        End Try
        Return cek
    End Function

    Function TampilDetailBiaya() As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, " _
                                       & "db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, " _
                                       & "pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya " _
                                       & "join Pengeluaran pl on pl.idPengeluaran = " _
                                       & "db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser", OpenConnection)
            Try
                DTS = New DataSet()
                DTS.Tables("tblBiaya").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblBiaya")
            Dim grid As New DataView(DTS.Tables("tblBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function FCKdBiaya(kel As String) As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select isnull(max(right(idBiaya,2)),0) from Biaya " _
                                   & "where substring(idBiaya,3,2)='" & kel & "'", OpenConnection)
        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = "BY" + kel + Strings.Right("0" & akhir + 1, 2)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements InterfaceProses.CariData
        Throw New NotImplementedException()
    End Function
End Class
