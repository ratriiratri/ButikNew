Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlPendapatan

    Public Function CariData(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Pendapatan where idPendapatan like '%" & kunci & "%' " _
                                        & "or jmlPendapatan like '" & kunci & "' or ketPendapatan like '%" & kunci & "%' " _
                                        & "or tglPendapatan like '" & kunci & "' or idUser like '%" & kunci & "%' ", OpenConnection)
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
            DTA = New OleDbDataAdapter("select * from Pendapatan", OpenConnection)

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

    Function FCKdPendapatan() As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select max(right(idPendapatan,4)) from Pendapatan", OpenConnection)

        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = "PD" & Strings.Right("0000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
