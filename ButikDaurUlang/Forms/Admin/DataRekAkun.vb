Public Class DataRekAkun

    Dim modeProses As Integer
    Dim baris As Integer
    Dim kode As String
    Dim kelAkun As String
    Dim jns As String

    Private Sub isiCbKel()
        cbKel.Items.Clear()
        cbKel.Items.Add("-Pilih Akun-")
        cbKel.Items.Add("11 - Harta Lancar")
        cbKel.Items.Add("12 - Harta Tetap")
        cbKel.Items.Add("21 - Hutang Lancar")
        cbKel.Items.Add("22 - Hutang Jk. Panjang")
        cbKel.Items.Add("31 - Modal")
        cbKel.Items.Add("41 - Pendapatan")
        cbKel.Items.Add("51 - Pembelian")
        cbKel.Items.Add("61 - Beban")
        cbKel.Items.Add("71 - Pendapatan lain-lain")
        cbKel.Items.Add("81 - Beban lain-lain")
    End Sub

    Private Sub bersih()
        txtNama.Text = ""
        txtSaldo.Text = 0
        txtKode.Text = ""
    End Sub

    Private Sub RefreshGrid() 'tampil isi tabel pada DGProduk
        DTGrid = KontrolAkun.TampilData.ToTable
        DGRekAkun.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            DGRekAkun.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGRekAkun.CurrentCell = DGRekAkun.Item(1, DTGrid.Rows.Count - 1)
            Call IsiBox(DTGrid.Rows.Count - 1)
            Call bersih()
        End If
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGRekAkun.Rows(br)
                txtKode.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtSaldo.Text = .Cells(3).Value.ToString
            End With
        End If
    End Sub

    Private Sub test()

        ' kode = .Cells(0).Value
        'kelAkun = kode.Substring(0, 2)

        For i = 1 To cbKel.Items.Count - 1
            If cbKel.Items(i).ToString.Substring(0, 2) = kelAkun Then
                cbKel.SelectedItem = cbKel.Items(i)
                Exit For
            End If
        Next
    End Sub

    Private Sub AturTxtBox(st As Boolean)
        cbKel.Enabled = st
        txtNama.Enabled = st
        txtSaldo.Enabled = st
    End Sub

    Private Sub AturDGAkun()
        With DGRekAkun.ColumnHeadersDefaultCellStyle
            DGRekAkun.Columns(0).HeaderText = "ID"
            DGRekAkun.Columns(1).HeaderText = "Nama Akun"
            DGRekAkun.Columns(2).HeaderText = "Kode"
            DGRekAkun.Columns(3).HeaderText = "Saldo"
            DGRekAkun.Columns(0).Width = 124
            DGRekAkun.Columns(2).Width = 165
            DGRekAkun.Columns(3).Width = 100
        End With
    End Sub

    Private Sub DataRekAkun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        modeProses = 0
        Call RefreshGrid()
        Call bersih()
        Call AturDGAkun()
        Call isiCbKel()
        AturTxtBox(False)

        If DTGrid.Rows.Count = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If

        cbKel.SelectedItem = cbKel.Items(0)
    End Sub

    Private Sub DGRekAkun_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRekAkun.CellContentClick, DGRekAkun.CellClick
        If modeProses = 0 Or modeProses = 2 Then
            DTGrid = KontrolAkun.TampilData.ToTable
            baris = e.RowIndex
            DGRekAkun.Rows(baris).Selected = True
            IsiBox(baris)
        ElseIf modeProses = 1 Then
            DTGrid = KontrolAkun.TampilData.ToTable
            DGRekAkun.Rows(baris).Selected = False
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call AturTxtBox(True)
        Call bersih()
        modeProses = 1

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim arrayKel() As String
        Dim kel As String
        Dim h As String

        arrayKel = cbKel.Text.Split(" - ")
        kel = arrayKel(0)
        h = kel.Substring(0, 1)

        If h = 1 Or h = 5 Or h = 6 Or h = 8 Then
            jns = "D"
        Else
            jns = "K"
        End If

        With EntitasAkun
            .idAkun = txtKode.Text
            .namaAkun = txtNama.Text
            .jnsSaldo = jns
            .saldo = txtSaldo.Text
        End With

        If cbKel.SelectedItem = cbKel.Items(0) Then
            MsgBox("Pilih Kelompok Akun Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
        ElseIf txtNama.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtNama.Focus()
        ElseIf txtSaldo.Text = "" Then
            txtSaldo.Text = 0
        Else
            If modeProses = 1 Then
                KontrolAkun.Insert(EntitasAkun, kel)
            ElseIf modeProses = 2 Then
                KontrolAkun.UpdateData(EntitasAkun)
            End If
            MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
            Call bersih()
            AturTxtBox(False)

            btnNew.Enabled = True
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False

            cbKel.Enabled = False

            modeProses = 0

            cbKel.SelectedItem = cbKel.Items(0)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturTxtBox(True)

        btnNew.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True

        txtNama.Focus()

        cbKel.Enabled = False
        modeProses = 2
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim statusReferensi As Boolean

        statusReferensi = KontrolAkun.CekDataDipakai(txtKode.Text)

        If statusReferensi = True Then
            MsgBox("Data masih digunakan, tidak dapat dihapus!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        Else
            MsgBox("Apakah anda yakin menghapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
            If MsgBoxResult.Yes Then
                KontrolAkun.DeleteData(txtKode.Text)
            End If
        End If

        Call RefreshGrid()
        cbKel.SelectedItem = cbKel.Items(0)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()
        Call AturTxtBox(False)
        Call bersih()

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False

        cbKel.Enabled = False

        modeProses = 0

        cbKel.SelectedItem = cbKel.Items(0)
    End Sub

    Private Sub txtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtSaldo_Click(sender As Object, e As EventArgs) Handles txtSaldo.Click
        txtSaldo.Text = ""
    End Sub

    Private Sub cbKel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKel.SelectedIndexChanged
        If cbKel.SelectedItem = cbKel.Items(1) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=11)
        ElseIf cbKel.SelectedItem = cbKel.Items(2) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=12)
        ElseIf cbKel.SelectedItem = cbKel.Items(3) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=21)
        ElseIf cbKel.SelectedItem = cbKel.Items(4) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=22)
        ElseIf cbKel.SelectedItem = cbKel.Items(5) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=31)
        ElseIf cbKel.SelectedItem = cbKel.Items(6) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=41)
        ElseIf cbKel.SelectedItem = cbKel.Items(7) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=51)
        ElseIf cbKel.SelectedItem = cbKel.Items(8) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=61)
        ElseIf cbKel.SelectedItem = cbKel.Items(9) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=71)
        ElseIf cbKel.SelectedItem = cbKel.Items(10) Then
            txtKode.Text = KontrolAkun.FCKdAkun(kel:=81)
        End If
    End Sub
End Class