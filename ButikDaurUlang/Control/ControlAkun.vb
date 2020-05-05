Imports System.Data.OleDb
Imports ButikDaurUlang

Public Class ControlAkun : Implements InterfaceProses

    Public Function Insert(Ob As Object, ByVal kel As String) As OleDbCommand
        Dim data As New EntityAkun
        data = Ob
        CMD = New OleDbCommand("insert into RekAkun values (dbo.FCKdAkun('" & kel & "'),'" & data.namaAkun _
                               & "','" & data.jnsSaldo & "','" & data.saldo & "')", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InterfaceProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InterfaceProses.UpdateData
        Dim data As New EntityAkun
        data = Ob
        CMD = New OleDbCommand("update RekAkun set namaAkun='" & data.namaAkun _
                               & "', jnsSaldo='" & data.jnsSaldo _
                               & "', saldo='" & data.saldo _
                               & "' where idAkun='" & data.idAkun & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements InterfaceProses.DeleteData
        CMD = New OleDbCommand("delete from RekAkun where idAkun='" & kunci & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements InterfaceProses.TampilData
        Try
            DTA = New OleDbDataAdapter("select * from RekAkun order by idAkun", OpenConnection)

            Try
                DTS = New DataSet()
                DTS.Tables("tblAkun").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblAkun")
            Dim grid As New DataView(DTS.Tables("tblAkun"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements InterfaceProses.CariData
        Throw New NotImplementedException()
    End Function

    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False

        Try
            DTA = New OleDbDataAdapter("select ref from DetailJurnal " _
                                   & "where ref='" & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cekData")
            If DTS.Tables("cekData").Rows.ToString > 0 Then
                cek = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function

    Function FCKdAkun(kel As Integer) As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select isnull(max(right(idAkun,2)),0) from RekAkun " _
                                  & "where left(idAkun,2) = " & kel & "", OpenConnection)

        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = kel & Strings.Right("0" & akhir + 1, 2)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
