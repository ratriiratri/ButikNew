Public Class LihatPengeluaran

    Dim baris As Integer

    Private Sub isiCbPencarian()
        cbPencarian.Items.Clear()
        cbPencarian.Items.Add("-Pencarian-")
        cbPencarian.Items.Add("ID Pengeluaran")
        cbPencarian.Items.Add("ID User")
        cbPencarian.Items.Add("Jumlah Pengeluaran")
        cbPencarian.Items.Add("Tanggal Pengeluaran")
        cbPencarian.SelectedItem = cbPencarian.Items(0)
    End Sub

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
            DGPengeluaran.Columns(2).HeaderText = "Tanggal"
            DGPengeluaran.Columns(3).HeaderText = "ID User"
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPengeluaran.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If cbPencarian.SelectedItem = cbPencarian.Items(1) Then
            DTGrid = KontrolPengeluaran.CariDataID(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) Then
            DTGrid = KontrolPengeluaran.CariDataIDUser(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) Then
            DTGrid = KontrolPengeluaran.CariDataJumlah(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) Then
            DTGrid = KontrolPengeluaran.CariDataTanggal(kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPengeluaran.DataSource = DTGrid
            DGPengeluaran.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPengeluaran.CurrentCell = DGPengeluaran.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
        End If
    End Sub

    Private Sub tampilCari2(kunci As String, kunci1 As Date, kunci2 As Date)
        If cbPencarian.SelectedItem = cbPencarian.Items(1) And checkBox.Checked = True Then
            DTGrid = KontrolPengeluaran.CariDataIDTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) And checkBox.Checked = True Then
            DTGrid = KontrolPengeluaran.CariDataIDUserTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) And checkBox.Checked = True Then
            DTGrid = KontrolPengeluaran.CariDataJumlahTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPengeluaran.DataSource = DTGrid
            DGPengeluaran.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPengeluaran.CurrentCell = DGPengeluaran.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
        End If
    End Sub

    Private Sub LihatPengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call AturDGPengeluaran()
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbPencarian.SelectedItem = cbPencarian.Items(4) Then
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
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) Then
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

    Private Sub lblTransaksiProduk_Click_1(sender As Object, e As EventArgs) Handles lblTransaksiProduk.Click
        Me.Close()
        LihatTransaksiProduk.Show()
    End Sub

    Private Sub lblTransaksiJasa_Click_1(sender As Object, e As EventArgs) Handles lblTransaksiJasa.Click
        Me.Close()
        LihatTransaksiJasa.Show()
    End Sub

    Private Sub lblTransaksiBiaya_Click(sender As Object, e As EventArgs) Handles lblTransaksiBiaya.Click
        Me.Close()
        LihatTransaksiBiaya.Show()
    End Sub

    Private Sub lblPendapatan_Click_1(sender As Object, e As EventArgs) Handles lblPendapatan.Click
        Me.Close()
        LihatPendapatan.Show()
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
End Class