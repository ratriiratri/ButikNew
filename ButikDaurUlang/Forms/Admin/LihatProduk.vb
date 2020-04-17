Public Class LihatProduk

    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolProduk.TampilData.ToTable
        DGProduk.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGProduk.CurrentCell = DGProduk.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGProduk()
        With DGProduk.ColumnHeadersDefaultCellStyle
            DGProduk.Columns(0).HeaderText = "ID"
            DGProduk.Columns(1).HeaderText = "Nama Produk"
            DGProduk.Columns(2).HeaderText = "Harga"
            DGProduk.Columns(3).HeaderText = "Stock"

            DGProduk.Columns(0).FillWeight = 30
            DGProduk.Columns(2).FillWeight = 30
            DGProduk.Columns(3).FillWeight = 30
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGProduk.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        DTGrid = KontrolProduk.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGProduk.DataSource = DTGrid
            DGProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGProduk.CurrentCell = DGProduk.Item(1, baris)
        End If
        MsgBox("Data Tidak Ditemukan!")
        RefreshGrid()
    End Sub

    Private Sub LihatProdukAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call AturDGProduk()
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        Me.Close()
        DataProduk.Show()
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