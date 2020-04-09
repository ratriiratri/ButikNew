Public Class LihatPengeluaran

    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolPengeluaran.TampilPengeluaran.ToTable
        DGPengeluaran.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPengeluaran.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPengeluaran.CurrentCell = DGPengeluaran.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGPengeluaran()
        With DGPengeluaran.ColumnHeadersDefaultCellStyle
            DGPengeluaran.Columns(0).HeaderText = "ID Pengeluaran"
            DGPengeluaran.Columns(1).HeaderText = "Jumlah"
            DGPengeluaran.Columns(2).HeaderText = "Keterangan"
            DGPengeluaran.Columns(3).HeaderText = "Tanggal"
            DGPengeluaran.Columns(4).HeaderText = "ID User"
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPengeluaran.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        DTGrid = KontrolPengeluaran.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPengeluaran.DataSource = DTGrid
            DGPengeluaran.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPengeluaran.CurrentCell = DGPengeluaran.Item(1, baris)
        End If
        MsgBox("Data Tidak Ditemukan!")
        RefreshGrid()
    End Sub

    Private Sub LihatPengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call AturDGPengeluaran()
    End Sub

    Private Sub lblTambah_Click(sender As Object, e As EventArgs) Handles lblTambah.Click
        Me.Close()
        TambahPengeluaran.Show()
        DataBiaya.Close()
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs)
        Me.Close()
        TambahPengeluaran.Close()
        DataBiaya.Show()
    End Sub

    Private Sub DGBiaya_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPengeluaran.CellContentClick
        baris = e.RowIndex
        DGPengeluaran.Rows(baris).Selected = True
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