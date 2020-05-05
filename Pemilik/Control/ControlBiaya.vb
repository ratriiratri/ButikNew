Imports System.Data.OleDb

Public Class ControlBiaya
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
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
                                       & "on us.idUser = pl.idUser where pl.tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilData() As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Biaya", OpenConnection)

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

    Function TampilDetailBiaya() As DataView
        Try
            DTA = New OleDbDataAdapter("select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, " _
                                       & "pl.idPengeluaran, convert(varchar, pl.tglPengeluaran,106), us.idUser from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran " _
                                       & "pl on pl.idPengeluaran = db.idPengeluaran join Userr us " _
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

    Public Function CariDataID(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Biaya where idBiaya " _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNama(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Biaya where namaBiaya " _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
