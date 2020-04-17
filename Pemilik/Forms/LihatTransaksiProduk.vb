Public Class LihatTransaksiProduk
    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolProduk.TampilDetailProduk.ToTable
        DGTransaksiProduk.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTransaksiProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTransaksiProduk.CurrentCell = DGTransaksiProduk.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGTransaksiProduk()
        With DGTransaksiProduk.ColumnHeadersDefaultCellStyle
            DGTransaksiProduk.Columns(0).HeaderText = "ID Produk"
            DGTransaksiProduk.Columns(1).HeaderText = "Nama Produk"
            DGTransaksiProduk.Columns(2).HeaderText = "Jumlah"
            DGTransaksiProduk.Columns(3).HeaderText = "Harga"
            DGTransaksiProduk.Columns(4).HeaderText = "Diskon"
            DGTransaksiProduk.Columns(5).HeaderText = "Tanggal"
            DGTransaksiProduk.Columns(6).HeaderText = "ID Pendapatan"
            DGTransaksiProduk.Columns(7).HeaderText = "ID User"

            DGTransaksiProduk.Columns(0).FillWeight = 15
            DGTransaksiProduk.Columns(2).FillWeight = 20
            DGTransaksiProduk.Columns(3).FillWeight = 20
            DGTransaksiProduk.Columns(4).FillWeight = 10
            DGTransaksiProduk.Columns(5).FillWeight = 20
            DGTransaksiProduk.Columns(6).FillWeight = 15
            DGTransaksiProduk.Columns(7).FillWeight = 15
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGTransaksiProduk.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        DTGrid = KontrolJasa.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTransaksiProduk.DataSource = DTGrid
            DGTransaksiProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTransaksiProduk.CurrentCell = DGTransaksiProduk.Item(1, baris)
        End If
        MsgBox("Data Tidak Ditemukan!")
        RefreshGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call RefreshGrid()
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        End If
    End Sub

    Private Sub LihatTransaksiProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call RefreshGrid()
        Call AturDGTransaksiProduk()
    End Sub
End Class