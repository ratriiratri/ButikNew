Imports System.Data.OleDb

Public Class ControlLaporan
    Public Function lihatLaporanJurnal(bulan As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select j.idJurnal as 'ID Jurnal', convert(varchar, j.tglJurnal,106) as 'Tanggal', dj.ref, b.namaBiaya as 'Keterangan' , case dj.jnsNominal when 'D' " _
                                       & "then dj.nominal else 0 end as 'Debet', case dj.jnsNominal when 'K' then dj.nominal else 0 end as 'Kredit' from Jurnal J join DetailJurnal dj on j.idJurnal = dj.idJurnal " _
                                       & "join Biaya b on substring(b.idBiaya,3,4) = dj.ref where j.tglJurnal like '%____-" & bulan & "-__%' order by j.idJurnal ASC", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariLaporanJurnal")

            Dim grid As New DataView(DTS.Tables("cariLaporanJurnal"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function lihatLaporanPendapatan(bulan As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select dj.ref, jr.ketJurnal as Keterangan, convert (varchar, jr.tglJurnal,106) as Tanggal, dj.nominal as Jumlah from Jurnal jr join " _
                                       & "DetailJurnal dj on dj.idJurnal = jr.idJurnal where dj.ref = '4101' and jr.tglJurnal like '%____-" & bulan & "-__%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariLaporanPendapatan")

            Dim grid As New DataView(DTS.Tables("cariLaporanPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function lihatLaporanPengeluaran(bulan As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select substring(b.idBiaya,3,4) as ref, b.namaBiaya as Keterangan, convert (varchar, pl.tglPengeluaran,106) as Tanggal, db.hargaBiaya as Jumlah from Biaya b " _
                                       & "join DetailBiaya db on b.idBiaya = db.idBiaya join Pengeluaran pl on pl.idPengeluaran = db.idPengeluaran where pl.tglPengeluaran like '%____-" & bulan & "-__%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariLaporanPengeluaran")

            Dim grid As New DataView(DTS.Tables("cariLaporanPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
