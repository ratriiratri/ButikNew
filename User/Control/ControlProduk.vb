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
