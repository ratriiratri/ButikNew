Public Class LihatTransaksiBiaya

    Dim baris As Integer

    Private Sub isiCbPencarian()
        cbPencarian.Items.Clear()
        cbPencarian.Items.Add("-Pencarian-")
        cbPencarian.Items.Add("ID Biaya")
        cbPencarian.Items.Add("ID Pengeluaran")
        cbPencarian.Items.Add("ID User")
        cbPencarian.Items.Add("Nama Biaya")
        cbPencarian.Items.Add("Tanggal Pengeluaran")
        cbPencarian.SelectedItem = cbPencarian.Items(0)
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolBiaya.TampilDetailBiaya.ToTable
        DGDetailBiaya.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDetailBiaya.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDetailBiaya.CurrentCell = DGDetailBiaya.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGDetailBiaya()
        With DGDetailBiaya.ColumnHeadersDefaultCellStyle
            DGDetailBiaya.Columns(0).HeaderText = "ID Biaya"
            DGDetailBiaya.Columns(1).HeaderText = "Nama Biaya "
            DGDetailBiaya.Columns(2).HeaderText = "Jumlah"
            DGDetailBiaya.Columns(3).HeaderText = "Harga"
            DGDetailBiaya.Columns(4).HeaderText = "ID Pengeluaran"
            DGDetailBiaya.Columns(5).HeaderText = "Tanggal Pengeluaran"
            DGDetailBiaya.Columns(6).HeaderText = "ID User"

            DGDetailBiaya.Columns(0).FillWeight = 12
            DGDetailBiaya.Columns(2).FillWeight = 8
            DGDetailBiaya.Columns(3).FillWeight = 10
            DGDetailBiaya.Columns(4).FillWeight = 12
            DGDetailBiaya.Columns(5).FillWeight = 15
            DGDetailBiaya.Columns(6).FillWeight = 12
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGDetailBiaya.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If cbPencarian.SelectedItem = cbPencarian.Items(1) And checkBox.Checked = False Then
            DTGrid = KontrolBiaya.CariDataIDBiaya(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) And checkBox.Checked = False Then
            DTGrid = KontrolBiaya.CariDataIDPengeluaran(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) And checkBox.Checked = False Then
            DTGrid = KontrolBiaya.CariDataIDUser(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) And checkBox.Checked = False Then
            DTGrid = KontrolBiaya.CariDataNamaBiaya(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(5) Then
            DTGrid = KontrolBiaya.CariDataTanggalPengeluaran(kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDetailBiaya.DataSource = DTGrid
            DGDetailBiaya.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDetailBiaya.CurrentCell = DGDetailBiaya.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
        End If
    End Sub

    Private Sub tampilCari2(kunci As String, kunci1 As Date, kunci2 As Date)
        If cbPencarian.SelectedItem = cbPencarian.Items(1) And checkBox.Checked = True Then
            DTGrid = KontrolBiaya.CariDataIDBiayaTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) And checkBox.Checked = True Then
            DTGrid = KontrolBiaya.CariDataIDPengeluaranTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) And checkBox.Checked = True Then
            DTGrid = KontrolBiaya.CariDataIDUserTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) And checkBox.Checked = True Then
            DTGrid = KontrolBiaya.CariDataNamaBiayaTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDetailBiaya.DataSource = DTGrid
            DGDetailBiaya.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDetailBiaya.CurrentCell = DGDetailBiaya.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
        End If
    End Sub

    Private Sub lblTransaksiProduk_Click(sender As Object, e As EventArgs) Handles lblTransaksiProduk.Click
        Me.Close()
        LihatTransaksiProduk.Show()
    End Sub

    Private Sub lblTransaksiJasa_Click(sender As Object, e As EventArgs) Handles lblTransaksiJasa.Click
        Me.Close()
        LihatTransaksiJasa.Show()
    End Sub

    Private Sub lblPendapatan_Click(sender As Object, e As EventArgs) Handles lblPendapatan.Click
        Me.Close()
        LihatPendapatan.Show()
    End Sub

    Private Sub lblPengeluaran_Click(sender As Object, e As EventArgs) Handles lblPengeluaran.Click
        Me.Close()
        LihatPengeluaran.Show()
    End Sub

    Private Sub LihatTransaksiBiaya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call AturDGDetailBiaya()
        Call isiCbPencarian()

        cbPencarian.SelectedItem = cbPencarian.Items(0)
        txtSearch.Text = ""

        dateAwal.Enabled = False
        dateAkhir.Enabled = False
        txtSearch.Enabled = False
        checkBox.Enabled = False

        checkBox.Checked = False

        dateAwal.Value = Format(Now)
        dateAkhir.Value = Format(Now)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()

        cbPencarian.SelectedItem = cbPencarian.Items(0)
        txtSearch.Text = ""
        txtSearch.Enabled = False
        checkBox.Enabled = False
        checkBox.Checked = False

        dateAwal.Value = Format(Now)
        dateAkhir.Value = Format(Now)
    End Sub

    Private Sub cbPencarian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPencarian.SelectedIndexChanged
        If cbPencarian.SelectedItem = cbPencarian.Items(0) Then
            txtSearch.Enabled = False
            checkBox.Checked = False
            checkBox.Enabled = False
            dateAwal.Enabled = False
            dateAkhir.Enabled = False
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(5) Then
            txtSearch.Enabled = False
            checkBox.Checked = False
            checkBox.Enabled = False
            dateAwal.Enabled = True
            dateAkhir.Enabled = True
        Else
            txtSearch.Enabled = True
            txtSearch.Focus()
            checkBox.Checked = False
            checkBox.Enabled = True
            dateAwal.Enabled = False
            dateAkhir.Enabled = False
        End If
    End Sub

    Private Sub checkBox_CheckStateChanged(sender As Object, e As EventArgs) Handles checkBox.CheckStateChanged
        If checkBox.Checked = True Then
            dateAkhir.Enabled = True
            dateAwal.Enabled = True
        Else
            dateAkhir.Enabled = False
            dateAwal.Enabled = False
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbPencarian.SelectedItem = cbPencarian.Items(5) Then
            Call tampilCari(dateAwal.Value)
        ElseIf txtSearch.Text = "" Then
            MsgBox("Masukan Kata Kunci", MsgBoxStyle.Information, "Info")
            txtSearch.Focus()
        ElseIf cbPencarian.Enabled = True And checkBox.Checked = False Then
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        ElseIf cbPencarian.Enabled = True And checkBox.Checked = True Then
            Call tampilCari2(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value)
            txtSearch.Focus()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If (e.KeyChar = Chr(13)) Then
            If cbPencarian.SelectedItem = cbPencarian.Items(5) Then
                Call tampilCari(dateAwal.Value)
            ElseIf txtSearch.Text = "" Then
                MsgBox("Masukan Kata Kunci", MsgBoxStyle.Information, "Info")
                txtSearch.Focus()
            ElseIf cbPencarian.Enabled = True And checkBox.Checked = False Then
                Call tampilCari(txtSearch.Text)
                txtSearch.Focus()
            ElseIf cbPencarian.Enabled = True And checkBox.Checked = True Then
                Call tampilCari2(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value)
                txtSearch.Focus()
            End If
        End If
    End Sub
End Class