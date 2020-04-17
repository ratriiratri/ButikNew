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

    Public Function TampilDetailJasa() As DataView
        Try
            DTA = New OleDbDataAdapter("select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan " _
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

    Public Function CariData(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Jasa where namaJasa" _
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
