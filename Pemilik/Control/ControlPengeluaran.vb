Imports System.Data.OleDb

Public Class ControlPengeluaran

    Public Function CariDataID(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPengeluaran, jmlPengeluaran, convert(varchar, tglPengeluaran,106), idUser " _
                                       & "from Pengeluaran where idPengeluaran like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPengeluaran")

            Dim grid As New DataView(DTS.Tables("cariPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPengeluaran, jmlPengeluaran, convert(varchar, tglPengeluaran,106), idUser " _
                                       & "from Pengeluaran where idPengeluaran like '%" & kunci & "%' and " _
                                       & "tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPengeluaran")

            Dim grid As New DataView(DTS.Tables("cariPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataJumlah(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPengeluaran, jmlPengeluaran, convert(varchar, tglPengeluaran,106), idUser " _
                                       & "from Pengeluaran where jmlPengeluaran like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPengeluaran")

            Dim grid As New DataView(DTS.Tables("cariPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataJumlahTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPengeluaran, jmlPengeluaran, convert(varchar, tglPengeluaran,106), idUser " _
                                       & "from Pengeluaran where jmlPengeluaran like '%" & kunci & "%' and " _
                                       & "tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPengeluaran")

            Dim grid As New DataView(DTS.Tables("cariPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataTanggal(kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPengeluaran, jmlPengeluaran, convert(varchar, tglPengeluaran,106), idUser " _
                                       & "from Pengeluaran where tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPengeluaran")

            Dim grid As New DataView(DTS.Tables("cariPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUser(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPengeluaran, jmlPengeluaran, convert(varchar, tglPengeluaran,106), idUser " _
                                       & "from Pengeluaran where idUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPengeluaran")

            Dim grid As New DataView(DTS.Tables("cariPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUserTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPengeluaran, jmlPengeluaran, convert(varchar, tglPengeluaran,106), idUser " _
                                       & "from Pengeluaran where idUser like '%" & kunci & "%' and " _
                                       & "tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPengeluaran")

            Dim grid As New DataView(DTS.Tables("cariPengeluaran"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilPengeluaran() As DataView
        Try
            DTA = New OleDbDataAdapter("select idPengeluaran, jmlPengeluaran, convert(varchar, tglPengeluaran,106), idUser from Pengeluaran", OpenConnection)
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
End Class
