﻿Imports System.Data.OleDb

Public Class ControlUser

    Public Function InsertData(Ob As Object) As OleDbCommand
        Dim data As New EntityUser
        data = Ob
        CMD = New OleDbCommand("insert into Userr values('" & data.idUser & "','" & data.namaUser & "','" & data.hpUser & "','" & data.usernameUser & "','" & data.passwordUser & "','" & data.statusUser & "')", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand
        CMD = New OleDbCommand("delete from Userr where idUser ='" & kunci & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand
        Dim data As New EntityUser
        data = Ob
        CMD = New OleDbCommand("update Userr set namaUser='" & data.namaUser _
                               & "', hpUser='" & data.hpUser _
                               & "' where idUser='" & data.idUser & "'", OpenConnection)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CloseConnection)
        Return CMD
    End Function

    Public Function TampilData() As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, usernameUser, passwordUser from Userr where statusUser = '1'", OpenConnection)

            Try
                DTS = New DataSet()
                DTS.Tables("tblUser").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblUser")
            Dim grid As New DataView(DTS.Tables("tblUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilDataUser() As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser != '3'", OpenConnection)

            Try
                DTS = New DataSet()
                DTS.Tables("tblUser").Clear()
            Catch ex As Exception
            End Try

            DTA.Fill(DTS, "tblUser")
            Dim grid As New DataView(DTS.Tables("tblUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Userr where namaUser" _
                                       & "like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(idUser) from Userr " _
                                   & "where idUser='" & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cekData")
            If DTS.Tables("cekData").Rows(0)(0).ToString > 0 Then cek = True

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return cek
        End Try
    End Function

    Function FCKdUser() As String
        Dim baru As String
        Dim akhir As Integer

        DTA = New OleDbDataAdapter("select max(right(idUser,4)) from Userr", OpenConnection)

        Try
            DTS = New DataSet()
            DTA.Fill(DTS, "kdBaru")
            akhir = Val(DTS.Tables("kdBaru").Rows(0).Item(0))
            baru = "US" & Strings.Right("0000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function login(kode As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select * from Userr where statusUser = '3' and usernameUser='" & kode & "'", OpenConnection)
            DTS = New DataSet
            DTA.Fill(DTS, "cariUser")
            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
