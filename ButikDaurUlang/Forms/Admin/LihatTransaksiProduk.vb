Public Class LihatTransaksiProduk

    Dim baris As Integer

    Private Sub isiCbPencarian()
        cbPencarian.Items.Clear()
        cbPencarian.Items.Add("-Pencarian-")
        cbPencarian.Items.Add("ID Produk")
        cbPencarian.Items.Add("ID Pendapatan")
        cbPencarian.Items.Add("ID User")
        cbPencarian.Items.Add("Nama Produk")
        cbPencarian.Items.Add("Diskon")
        cbPencarian.Items.Add("Tanggal Pendapatan")
        cbPencarian.SelectedItem = cbPencarian.Items(0)
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolProduk.TampilDetailProduk.ToTable
        DGDetailProduk.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDetailProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDetailProduk.CurrentCell = DGDetailProduk.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub aturDGDetailProduk()
        With DGDetailProduk.ColumnHeadersDefaultCellStyle
            DGDetailProduk.Columns(0).HeaderText = "ID Produk"
            DGDetailProduk.Columns(1).HeaderText = "Nama Produk"
            DGDetailProduk.Columns(2).HeaderText = "Jumlah"
            DGDetailProduk.Columns(3).HeaderText = "Harga"
            DGDetailProduk.Columns(4).HeaderText = "Disc"
            DGDetailProduk.Columns(5).HeaderText = "ID Pendapatan"
            DGDetailProduk.Columns(6).HeaderText = "Tanggal Pendapatan"
            DGDetailProduk.Columns(7).HeaderText = "ID User"

            DGDetailProduk.Columns(0).FillWeight = 15
            DGDetailProduk.Columns(2).FillWeight = 8
            DGDetailProduk.Columns(3).FillWeight = 15
            DGDetailProduk.Columns(4).FillWeight = 7
            DGDetailProduk.Columns(5).FillWeight = 15
            DGDetailProduk.Columns(6).FillWeight = 25
            DGDetailProduk.Columns(7).FillWeight = 15
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGDetailProduk.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If cbPencarian.SelectedItem = cbPencarian.Items(1) Then
            DTGrid = KontrolProduk.CariDataIDProduk(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) Then
            DTGrid = KontrolProduk.CariDataIDPendapatan(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) Then
            DTGrid = KontrolProduk.CariDataIDUser(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) Then
            DTGrid = KontrolProduk.CariDataNamaProduk(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(5) Then
            DTGrid = KontrolProduk.CariDataDiskon(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(6) Then
            DTGrid = KontrolProduk.CariDataTanggal(kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        Else
            MsgBox("Data Tidak Ditemukan!")
            RefreshGrid()
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDetailProduk.DataSource = DTGrid
            DGDetailProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDetailProduk.CurrentCell = DGDetailProduk.Item(1, baris)
        End If
    End Sub

    Private Sub lblTransaksiJasa_Click(sender As Object, e As EventArgs) Handles lblTransaksiJasa.Click
        Me.Close()
        LihatTransaksiJasa.Show()
    End Sub

    Private Sub LihatTransaksiProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call aturDGDetailProduk()
        Call isiCbPencarian()

        dateAkhir.Enabled = False
        dateAwal.Enabled = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()

        cbPencarian.SelectedItem = cbPencarian.Items(0)
        txtSearch.Text = ""

        dateAwal.Value = Format(Now)
        dateAkhir.Value = Format(Now)
    End Sub

    Private Sub cbPencarian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPencarian.SelectedIndexChanged
        If cbPencarian.SelectedItem = cbPencarian.Items(5) Then
            txtSearch.Enabled = False
            dateAwal.Enabled = True
            dateAkhir.Enabled = True
        Else
            txtSearch.Enabled = True
            dateAwal.Enabled = False
            dateAkhir.Enabled = False
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbPencarian.SelectedItem = cbPencarian.Items(6) Then
            Call tampilCari(dateAwal.Value)
        ElseIf txtSearch.Text = "" Then
            MsgBox("Masukan Kata Kunci", MsgBoxStyle.Information, "Info")
            txtSearch.Focus()
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(0) Then
            MsgBox("Pilih Kategori Pencarian!", MsgBoxStyle.Information, "Info")
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()

            dateAkhir.Enabled = False
            dateAwal.Enabled = False

            dateAwal.Value = Format(Now)
            dateAkhir.Value = Format(Now)
        End If
    End Sub
End Class