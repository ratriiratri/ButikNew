Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlPendapatan : Implements InterfaceProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InterfaceProses.InsertData
        Dim data As New EntityPendapatan
        data = Ob
        CMD = New OleDbCommand("insert into Pendapatan values('" & data.idPendapatan & "','" & data.jmlPendapatan & "','" & data.ketPendapatan & "','" & data.tglPendapatan & "','" & data.idUser & "')", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InterfaceProses.UpdateData
        Dim data As New EntityPendapatan
        data = Ob
        'hanya bisa update punya sendiri, bukan punya orang lain.
        CMD = New OleDbCommand("update Pendapatan set jmlPendapatan='" & data.jmlPendapatan _
                               & "',ketPendapatan='" & data.ketPendapatan _
                               & "' where idPendapatan='" & data.idPendapatan & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements InterfaceProses.DeleteData
        CMD = New OleDbCommand("delete from Pendapatan where idPendapatan='" & kunci & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements InterfaceProses.TampilData
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

    Public Function CariData(kunci As String) As DataView Implements InterfaceProses.CariData
        Try
            DTA = New OleDbDataAdapter("select * from Pendapatan where idPendapatan" _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariPendapatan")

            Dim grid As New DataView(DTS.Tables("cariPendapatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilDataPendapatanAdmin(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Pendapatan where idUser='" & kunci & "'", OpenConnection)

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

    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(idPendapatan) from Pendapatan " _
                                   & "where idPendapatan='" & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cekData")
            If DTS.Tables("cekData").Rows(0)(0).ToString > 0 Then cek = True

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return cek
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
