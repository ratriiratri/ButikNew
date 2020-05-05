Imports System.Data.OleDb

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

#Region "Cari Berdasarkan User"

    Public Function CariDataIDUser(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser = '2' " _
                                       & "and idUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNamaUser(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser = '2' " _
                                       & "and namaUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataHpUser(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser = '2' " _
                                       & "and hpUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataStatusUser() As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser = '2' " _
                                       & "", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region

#Region "Cari Berdasarkan Admin"

    Public Function CariDataIDAdmin(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser = '1' " _
                                       & "and idUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNamaAdmin(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser = '1' " _
                                       & "and namaUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataHpAdmin(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser = '1' " _
                                       & "and hpUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataStatusAdmin() As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser = '1' " _
                                       & "", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region

#Region "Cari Berdasarkan Semua"

    Public Function CariDataID(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser != '3' " _
                                       & "and idUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataNama(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser != '3' " _
                                       & "and namaUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariDataHp(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("select idUser, namaUser, hpUser, case statusUser when '1' then 'Admin' " _
                                       & "when '2' then 'User' end as Status from Userr where statusUser != '3' " _
                                       & "and hpUser like '%" & kunci & "%'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cariUser")

            Dim grid As New DataView(DTS.Tables("cariUser"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region

    Function CekDataDipakai(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select idUser from Pengeluaran where idUser='" & kunci & "'", OpenConnection)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows.Count > 0 Then
                cek = True
            End If
        Catch ex As Exception
        End Try
        Return cek
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
