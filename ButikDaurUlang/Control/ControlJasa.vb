Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlJasa : Implements InterfaceProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InterfaceProses.InsertData
        Dim data As New EntityJasa
        data = Ob
        CMD = New OleDbCommand("insert into Jasa values('" & data.idJasa & "','" & data.namaJasa & "','" & data.hargaJasa & "')", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InterfaceProses.UpdateData
        Dim data As New EntityJasa
        data = Ob
        CMD = New OleDbCommand("update Jasa set namaJasa ='" & data.namaJasa _
                               & "',hargaJasa='" & data.hargaJasa _
                               & "' where idJasa='" & data.idJasa & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements InterfaceProses.DeleteData
        CMD = New OleDbCommand("delete from Jasa where idJasa='" & kunci & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements InterfaceProses.TampilData
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

    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(idJasa) from DetailJasa " _
                                   & "where idJasa='" & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cekData")
            If DTS.Tables("cekData").Rows(0)(0).ToString > 0 Then cek = True

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return cek
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements InterfaceProses.CariData
        Try
            DTA = New OleDbDataAdapter("select * from Jasa where namaJasa like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariJasa")

            Dim grid As New DataView(DTS.Tables("cariJasa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function FCKdJasa() As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select max(right(idJasa,4)) from Jasa", OpenConnection)

        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = "JS" & Strings.Right("0000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
