Public Class LihatTransaksiJasa

    Dim baris As Integer

    Private Sub isiCbPencarian()
        cbPencarian.Items.Clear()
        cbPencarian.Items.Add("-Pencarian-")
        cbPencarian.Items.Add("ID Jasa")
        cbPencarian.Items.Add("ID Pendapatan")
        cbPencarian.Items.Add("ID User")
        cbPencarian.Items.Add("Nama Jasa")
        cbPencarian.Items.Add("Tanggal Pendapatan")
        cbPencarian.SelectedItem = cbPencarian.Items(0)
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolJasa.TampilDetailJasa.ToTable
        DGDetailJasa.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDetailJasa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDetailJasa.CurrentCell = DGDetailJasa.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGDetailJasa()
        With DGDetailJasa.ColumnHeadersDefaultCellStyle
            DGDetailJasa.Columns(0).HeaderText = "ID Jasa"
            DGDetailJasa.Columns(1).HeaderText = "Nama Jasa"
            DGDetailJasa.Columns(2).HeaderText = "Jumlah"
            DGDetailJasa.Columns(3).HeaderText = "Harga"
            DGDetailJasa.Columns(4).HeaderText = "Tanggal"
            DGDetailJasa.Columns(5).HeaderText = "ID User"
            DGDetailJasa.Columns(6).HeaderText = "ID Pendapatan"

            DGDetailJasa.Columns(0).FillWeight = 12
            DGDetailJasa.Columns(2).FillWeight = 8
            DGDetailJasa.Columns(3).FillWeight = 10
            DGDetailJasa.Columns(4).FillWeight = 10
            DGDetailJasa.Columns(5).FillWeight = 12
            DGDetailJasa.Columns(6).FillWeight = 12
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGDetailJasa.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If cbPencarian.SelectedItem = cbPencarian.Items(1) Then
            DTGrid = KontrolJasa.CariDataIDJasa(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) Then
            DTGrid = KontrolJasa.CariDataIDPendapatan(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) Then
            DTGrid = KontrolJasa.CariDataIDUser(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) Then
            DTGrid = KontrolJasa.CariDataNamaJasa(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(5) Then
            DTGrid = KontrolJasa.CariDataTanggalPendapatan(kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        Else
            MsgBox("Data Tidak Ditemukan!")
            RefreshGrid()
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDetailJasa.DataSource = DTGrid
            DGDetailJasa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDetailJasa.CurrentCell = DGDetailJasa.Item(1, baris)
        End If
    End Sub

    Private Sub LihatJasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call AturDGDetailJasa()
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
        If cbPencarian.SelectedItem = cbPencarian.Items(5) Then
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

    Private Sub lblTransaksiProduk_Click(sender As Object, e As EventArgs) Handles lblTransaksiProduk.Click
        Me.Close()
        LihatTransaksiProduk.Show()
    End Sub

    Private Sub lblPendapatan_Click(sender As Object, e As EventArgs) Handles lblPendapatan.Click
        Me.Close()
        LihatPendapatan.Show()
    End Sub

    Private Sub lblPengeluaran_Click(sender As Object, e As EventArgs) Handles lblPengeluaran.Click
        Me.Close()
        LihatPengeluaran.Show()
    End Sub

    Private Sub lblTransaksiBiaya_Click(sender As Object, e As EventArgs) Handles lblTransaksiBiaya.Click
        Me.Close()
        LihatTransaksiBiaya.Show()
    End Sub
End Class