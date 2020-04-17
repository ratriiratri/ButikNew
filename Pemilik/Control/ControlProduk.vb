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
            DTA = New OleDbDataAdapter("select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, pd.tglPendapatan, us.idUser
from Produk p join DetailProduk dp on p.idProduk = dp.idProduk join Pendapatan pd on pd.idPendapatan = dp.idPendapatan join Userr us on us.idUser = pd.idUser", OpenConnection)

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

    Public Function CariData(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Produk where namaProduk" _
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
