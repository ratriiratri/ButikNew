Imports System.Data.OleDb

Public Class ControlPendapatan
    Public Function CariDataID(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPendapatan, jmlPendapatan, ketPendapatan, convert (varchar, tglpendapatan,106), idUser " _
                                       & "from Pendapatan where idPendapatan like '%" & kunci & "%' ", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPendapatan, jmlPendapatan, ketPendapatan, convert (varchar, tglpendapatan,106), idUser " _
                                       & "from Pendapatan where idPendapatan like '%" & kunci & "%' and " _
                                       & "tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataJumlah(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPendapatan, jmlPendapatan, ketPendapatan, convert (varchar, tglpendapatan,106), idUser " _
                                       & "from Pendapatan where jmlPendapatan like '%" & kunci & "%' ", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataJumlahTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPendapatan, jmlPendapatan, ketPendapatan, convert (varchar, tglpendapatan,106), idUser " _
                                       & "from Pendapatan where jmlPendapatan like '%" & kunci & "%' and " _
                                       & "tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataKeterangan(kunci As Integer) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPendapatan, jmlPendapatan, ketPendapatan, convert (varchar, tglpendapatan,106), idUser " _
                                       & "from Pendapatan where ketPendapatan like '%" & kunci & "%' ", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataKeteranganTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPendapatan, jmlPendapatan, ketPendapatan, convert(varchar, tglpendapatan,106), idUser " _
                                       & "from Pendapatan where ketPendapatan like '%" & kunci & "%' and " _
                                       & "tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataTanggal(kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select  idPendapatan, jmlPendapatan, ketPendapatan, convert (varchar, tglpendapatan,106), idUser " _
                                       & "from Pendapatan where tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUser(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPendapatan, jmlPendapatan, ketPendapatan, convert (varchar, tglpendapatan,106), idUser " _
                                       & "from Pendapatan where idUser like '%" & kunci & "%' ", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataIDUserTanggal(kunci As String, kunci1 As Date, kunci2 As Date) As DataView
        Try
            DTA = New OleDbDataAdapter("select idPendapatan, jmlPendapatan, ketPendapatan, convert(varchar, tglpendapatan,106), idUser " _
                                       & "from Pendapatan where idUser like '%" & kunci & "%' and " _
                                       & "tglPendapatan between '" & kunci1 & "' and '" & kunci2 & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilPendapatan() As DataView
        Try
            DTA = New OleDbDataAdapter("select idPendapatan, jmlPendapatan, ketPendapatan, convert (varchar, tglpendapatan,106), idUser from Pendapatan", OpenConnection)

            Try
                DTS = New DataSet()
                DTS.Tables("tblPendapatan").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblPendapatan")
            Dim grid As New DataView(DTS.Tables("tblPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
