Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlBiaya : Implements InterfaceProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InterfaceProses.InsertData
        Dim data As New EntityBiaya
        data = Ob
        CMD = New OleDbCommand("insert into Biaya values('" & data.idBiaya & "','" & data.namaBiaya & "')", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InterfaceProses.UpdateData
        Dim data As New EntityBiaya
        data = Ob
        CMD = New OleDbCommand("update Biaya set namaBiaya='" & data.namaBiaya & "' where idBiaya='" & data.idBiaya _
                               & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements InterfaceProses.DeleteData
        CMD = New OleDbCommand("delete from Biaya where idBiaya='" & kunci & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements InterfaceProses.TampilData
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

    Public Function CariData(kunci As String) As DataView Implements InterfaceProses.CariData
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

    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(idBiaya) from DetailBiaya " _
                                   & "where idBiaya='" & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cekData")
            If DTS.Tables("cekData").Rows(0)(0).ToString > 0 Then cek = True

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return cek
        End Try
    End Function

    Function TampilBiaya() As DataView
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

    Function FCKdBiaya() As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select max(right(idBiaya,4)) from Biaya", OpenConnection)

        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = "BY" & Strings.Right("0000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
