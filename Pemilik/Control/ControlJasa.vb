Imports System.Data.OleDb

Public Class ControlJasa
    Public Function TampilData() As DataView
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

    Public Function CariDataIDJasa(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where js.idJasa like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDJasaTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where js.idJasa like '%" & kunci & "%' and " _
                                       & "pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)

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
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where us.idUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUserTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where us.idUser like '%" & kunci & "%' and " _
                                       & "pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)

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
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where pd.idPendapatan like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDPendapatanTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where pd.idPendapatan like '%" & kunci & "%' and " _
                                       & "pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)

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
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where js.namaJasa like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNamaJasaTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
                                       & "from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa join Pendapatan pd on pd.idPendapatan = dj.idPendapatan " _
                                       & "join Userr us on us.idUser = pd.idUser where js.namaJasa like '%" & kunci & "%' and " _
                                       & "pd.tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)

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
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
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
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, convert(varchar, pd.tglPendapatan,106), us.idUser, pd.idPendapatan " _
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

    Public Function CariDataID(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Jasa where idJasa " _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNama(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Jasa where namaJasa " _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
