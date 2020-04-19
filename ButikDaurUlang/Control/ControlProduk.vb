Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlProduk : Implements InterfaceProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InterfaceProses.InsertData
        Dim data As New EntityProduk
        data = Ob
        CMD = New OleDbCommand("insert into Produk values('" & data.idProduk & "','" & data.namaProduk & "','" & data.hargaProduk & "','" & data.stockProduk & "')", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InterfaceProses.UpdateData
        Dim data As New EntityProduk
        data = Ob
        CMD = New OleDbCommand("update Produk set namaProduk='" & data.namaProduk _
                               & "',hargaProduk='" & data.hargaProduk _
                               & "',stockProduk='" & data.stockProduk _
                               & "' where idProduk='" & data.idProduk & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements InterfaceProses.DeleteData
        CMD = New OleDbCommand("delete from Produk where idProduk='" & kunci & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements InterfaceProses.TampilData
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
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, pd.tglPendapatan, " _
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
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, pd.tglPendapatan, " _
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

    Public Function CariDataIDPendapatan(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, pd.tglPendapatan, " _
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

    Public Function CariDataIDUser(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, pd.tglPendapatan, " _
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

    Public Function CariDataNamaProduk(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, pd.tglPendapatan, " _
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

    Public Function CariDataDiskon(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, pd.tglPendapatan, " _
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

    Public Function CariDataTanggal(kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, pd.tglPendapatan, " _
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


    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select p.idProduk from Produk p join DetailProduk dp" _
                                       & "on p.idProduk = dp.idProduk" _
                                       & "where p.idProduk='" & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function

    Function FCKdProduk() As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select max(right(idProduk,4)) from Produk", OpenConnection)

        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = "PR" & Strings.Right("0000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements InterfaceProses.CariData
        Throw New NotImplementedException()
    End Function
End Class
