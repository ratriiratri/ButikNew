Imports System.Data.OleDb

Public Class ControlBiaya
    Public Function TampilData() As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Biaya", OpenConnection)

            Try
                DTS = New DataSet()
                DTS.Tables("tblBiaya").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblBiaya")
            Dim grid As New DataView(DTS.Tables("tblBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function TampilDetailBiaya() As DataView
        Try
            DTA = New OleDbDataAdapter("select db.idBiaya, pl.ketPengeluaran, db.idPengeluaran, db.jumlahBiaya, pl.tglPengeluaran 
from Pengeluaran pl join DetailBiaya db on pl.idPengeluaran = db.idPengeluaran", OpenConnection)

            Try
                DTS = New DataSet()
                DTS.Tables("tblBiaya").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblBiaya")
            Dim grid As New DataView(DTS.Tables("tblBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Biaya where namaBiaya" _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariBiaya")

            Dim grid As New DataView(DTS.Tables("cariBiaya"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
