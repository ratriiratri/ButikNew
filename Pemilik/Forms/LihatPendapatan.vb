Public Class LihatPendapatan

    Dim baris As Integer

    Private Sub isiCbPencarian()
        cbPencarian.Items.Clear()
        cbPencarian.Items.Add("-Pencarian-")
        cbPencarian.Items.Add("ID Pendapatan")
        cbPencarian.Items.Add("ID User")
        cbPencarian.Items.Add("Jumlah Pendapatan")
        cbPencarian.Items.Add("Keterangan")
        cbPencarian.Items.Add("Tanggal Pendapatan")
        cbPencarian.SelectedItem = cbPencarian.Items(0)
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPendapatan.TampilPendapatan.ToTable
        DGPendapatan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPendapatan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPendapatan.CurrentCell = DGPendapatan.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGPendapatan()
        With DGPendapatan.ColumnHeadersDefaultCellStyle
            DGPendapatan.Columns(0).HeaderText = "ID Pendapatan"
            DGPendapatan.Columns(1).HeaderText = "Jumlah"
            DGPendapatan.Columns(2).HeaderText = "Keterangan"
            DGPendapatan.Columns(3).HeaderText = "Tanggal"
            DGPendapatan.Columns(4).HeaderText = "ID User"
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPendapatan.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If cbPencarian.SelectedItem = cbPencarian.Items(1) Then
            DTGrid = KontrolPendapatan.CariDataID(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) Then
            DTGrid = KontrolPendapatan.CariDataIDUser(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) Then
            DTGrid = KontrolPendapatan.CariDataJumlah(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) Then
            DTGrid = KontrolPendapatan.CariDataKeterangan(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(5) Then
            DTGrid = KontrolPendapatan.CariDataTanggal(kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPendapatan.DataSource = DTGrid
            DGPendapatan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPendapatan.CurrentCell = DGPendapatan.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
        End If
    End Sub

    Private Sub tampilCari2(kunci As String, kunci1 As Date, kunci2 As Date)
        If cbPencarian.SelectedItem = cbPencarian.Items(1) And checkBox.Checked = True Then
            DTGrid = KontrolPendapatan.CariDataIDTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) And checkBox.Checked = True Then
            DTGrid = KontrolPendapatan.CariDataIDUserTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) And checkBox.Checked = True Then
            DTGrid = KontrolPendapatan.CariDataJumlahTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) And checkBox.Checked = True Then
            DTGrid = KontrolPendapatan.CariDataKeteranganTanggal(kunci:=txtSearch.Text, kunci1:=dateAwal.Value, kunci2:=dateAkhir.Value).ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPendapatan.DataSource = DTGrid
            DGPendapatan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPendapatan.CurrentCell = DGPendapatan.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
        End If
    End Sub

    Private Sub LihatPendapatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call RefreshGrid()
        Call AturDGPendapatan()
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

    Private Sub lblTransaksiProduk_Click(sender As Object, e As EventArgs) Handles lblTransaksiProduk.Click
        Me.Close()
        LihatTransaksiProduk.Show()
    End Sub

    Private Sub lblTransaksiJasa_Click(sender As Object, e As EventArgs) Handles lblTransaksiJasa.Click
        Me.Close()
        LihatTransaksiJasa.Show()
    End Sub

    Private Sub lblTransaksiBiaya_Click(sender As Object, e As EventArgs) Handles lblTransaksiBiaya.Click
        Me.Close()
        LihatTransaksiBiaya.Show()
    End Sub

    Private Sub lblPengeluaran_Click(sender As Object, e As EventArgs) Handles lblPengeluaran.Click
        Me.Close()
        LihatPengeluaran.Show()
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