Imports System.Data.OleDb

Public Class ControlProduk
    Public Function TampilData() As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Produk", OpenConnection)

            Try
                DTS = New DataSet()
                DTS.Tables("tblProduk").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblProduk")
            Dim grid As New DataView(DTS.Tables("tblProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilDetailProduk() As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser", OpenConnection)
            Try
                DTS = New DataSet()
                DTS.Tables("tblDetailProduk").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblDetailProduk")
            Dim grid As New DataView(DTS.Tables("tblDetailProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDProduk(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where p.idProduk like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDProdukTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where p.idProduk like '%" & kunci & "%' and pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDPendapatan(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where dp.idPendapatan like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDPendapatanTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where dp.idPendapatan like '%" & kunci & "%' and pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUser(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where us.idUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUserTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where us.idUser like '%" & kunci & "%' and pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNamaProduk(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where p.namaProduk like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNamaProdukTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where p.namaProduk like '%" & kunci & "%' and pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataDiskon(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where dp.discProduk like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataDiskonTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where dp.discProduk like '%" & kunci & "%' and pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataTanggal(kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, convert(varchar, pd.tglPendapatan,106), " _
                                       & "us.idUser from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on " _
                                       & "pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser " _
                                       & "where pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataID(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Produk where idProduk " _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNama(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Produk where namaProduk " _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariProduk")

            Dim grid As New DataView(DTS.Tables("cariProduk"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
