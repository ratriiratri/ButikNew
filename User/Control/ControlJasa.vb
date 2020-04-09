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

End Class
