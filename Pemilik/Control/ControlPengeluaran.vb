Imports System.Data.OleDb

Public Class ControlPengeluaran

    Dim Sql As String

    Public Function CariDataID(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Pengeluaran where idPengeluaran like '%" & kunci & "%' ", OpenConnection)
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
            DTA = New OleDbDataAdapter("select * from Pengeluaran where jmlPengeluaran like " & kunci & "", OpenConnection)
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
            DTA = New OleDbDataAdapter("select * from Pengeluaran where tglPengeluaran between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
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
            DTA = New OleDbDataAdapter("select * from Pengeluaran where idUser like '%" & kunci & "%' ", OpenConnection)
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
            DTA = New OleDbDataAdapter("select * from Pengeluaran", OpenConnection)

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
