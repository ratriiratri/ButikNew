Public Class LihatBiayaAdmin

    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolBiaya.TampilBiaya.ToTable
        DGBiaya.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBiaya.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBiaya.CurrentCell = DGBiaya.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBiaya.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        DTGrid = KontrolBiaya.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBiaya.DataSource = DTGrid
            DGBiaya.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBiaya.CurrentCell = DGBiaya.Item(1, baris)
        End If
        MsgBox("Data Tidak Ditemukan!")
        RefreshGrid()
    End Sub

    Private Sub LihatBiayaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
    End Sub

    Private Sub lblTambah_Click(sender As Object, e As EventArgs) Handles lblTambah.Click
        Me.Close()
        TambahBiayaAdmin.Show()
        DataBiayaAdmin.Close()
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        Me.Close()
        TambahBiayaAdmin.Close()
        DataBiayaAdmin.Show()
    End Sub

    Private Sub DGBiaya_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBiaya.CellContentClick
        baris = e.RowIndex
        DGBiaya.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call RefreshGrid()
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        End If
    End Sub
End Class