Public Class DataProduk

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub Bersih() 'clear isi 
        txtId.Text = ""
        txtNama.Text = ""
        txtHarga.Text = ""
        txtStock.Text = ""
    End Sub

    Private Sub RefreshGrid() 'tampil isi tabel pada DGProduk
        DTGrid = KontrolProduk.TampilData2.ToTable
        DGProduk.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            DGProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGProduk.CurrentCell = DGProduk.Item(1, DTGrid.Rows.Count - 1)
            Call IsiBox(DTGrid.Rows.Count - 1)
            Call Bersih()
        End If
    End Sub

    Private Sub AturDGProduk()
        With DGProduk.ColumnHeadersDefaultCellStyle
            DGProduk.Columns(0).HeaderText = "ID"
            DGProduk.Columns(1).HeaderText = "Nama Produk"
            DGProduk.Columns(2).HeaderText = "Harga"
            DGProduk.Columns(3).HeaderText = "Stock"
            DGProduk.Columns(0).Width = 124
            DGProduk.Columns(2).Width = 165
            DGProduk.Columns(3).Width = 100
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGProduk.Rows(br)
                txtId.Text = .Cells(0).Value
                txtNama.Text = .Cells(1).Value
                txtHarga.Text = .Cells(2).Value
                txtStock.Text = .Cells(3).Value
            End With
        End If
    End Sub

    Private Sub AturTxtBox(st As Boolean)
        btnSave.Enabled = st

        txtNama.Enabled = st
        txtHarga.Enabled = st
        txtStock.Enabled = st
    End Sub

    Private Sub DataProdukAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        modeProses = 0
        Call RefreshGrid()
        Call Bersih()
        Call AturDGProduk()
        AturTxtBox(False)

        If DTGrid.Rows.Count = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub DGProduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProduk.CellContentClick
        If modeProses = 0 Or modeProses = 2 Then
            DTGrid = KontrolProduk.TampilData2.ToTable
            baris = e.RowIndex
            DGProduk.Rows(baris).Selected = True
            IsiBox(baris)
        ElseIf modeProses = 1 Then
            DTGrid = KontrolProduk.TampilData2.ToTable
            DGProduk.Rows(baris).Selected = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasProduk
            .idProduk = txtId.Text
            .namaProduk = txtNama.Text
            .hargaProduk = txtHarga.Text
            .stockProduk = txtStock.Text
        End With

        If txtNama.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtNama.Focus()
        ElseIf txtHarga.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtHarga.Focus()
        ElseIf txtStock.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtStock.Focus()
        Else
            If modeProses = 1 Then
                KontrolProduk.InsertData(EntitasProduk)
            ElseIf modeProses = 2 Then
                KontrolProduk.UpdateData(EntitasProduk)
            End If
            MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
            Call AturTxtBox(False)
            Call Bersih()

            btnNew.Enabled = True
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False

            modeProses = 0
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call AturTxtBox(True)
        Call Bersih()
        modeProses = 1

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        txtId.Text = KontrolProduk.FCKdProduk
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturTxtBox(True)

        btnNew.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False

        txtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim statusReferensi As Boolean

        statusReferensi = KontrolProduk.CekDataDipakai(txtId.Text)

        If statusReferensi Then
            MsgBox("Data masih digunakan, tidak dapat dihapus!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin menghapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolProduk.DeleteData(txtId.Text)
        End If

        Call RefreshGrid()
    End Sub

    Private Sub lblLihat_Click(sender As Object, e As EventArgs) Handles lblLihat.Click
        Call RefreshGrid()
        Me.Hide()
        LihatProduk.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()
        Call AturTxtBox(False)
        Call Bersih()

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False

        modeProses = 0
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

        If (e.KeyChar = Chr(13)) Then
            With EntitasProduk
                .idProduk = txtId.Text
                .namaProduk = txtNama.Text
                .hargaProduk = txtHarga.Text
                .stockProduk = txtStock.Text
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
            ElseIf txtHarga.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtHarga.Focus()
            ElseIf txtStock.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtStock.Focus()
            Else
                If modeProses = 1 Then
                    KontrolProduk.InsertData(EntitasProduk)
                ElseIf modeProses = 2 Then
                    KontrolProduk.UpdateData(EntitasProduk)
                End If
                MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")
                Call RefreshGrid()
                Call AturTxtBox(False)
                Call Bersih()

                btnNew.Enabled = True
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = False

                modeProses = 0
            End If
        End If
    End Sub

    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

        If (e.KeyChar = Chr(13)) Then
            With EntitasProduk
                .idProduk = txtId.Text
                .namaProduk = txtNama.Text
                .hargaProduk = txtHarga.Text
                .stockProduk = txtStock.Text
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
            ElseIf txtHarga.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtHarga.Focus()
            ElseIf txtStock.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtStock.Focus()
            Else
                If modeProses = 1 Then
                    KontrolProduk.InsertData(EntitasProduk)
                ElseIf modeProses = 2 Then
                    KontrolProduk.UpdateData(EntitasProduk)
                End If
                MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")
                Call RefreshGrid()
                Call AturTxtBox(False)
                Call Bersih()

                btnNew.Enabled = True
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = False

                modeProses = 0
            End If
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If (e.KeyChar = Chr(13)) Then
            With EntitasProduk
                .idProduk = txtId.Text
                .namaProduk = txtNama.Text
                .hargaProduk = txtHarga.Text
                .stockProduk = txtStock.Text
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
            ElseIf txtHarga.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtHarga.Focus()
            ElseIf txtStock.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtStock.Focus()
            Else
                If modeProses = 1 Then
                    KontrolProduk.InsertData(EntitasProduk)
                ElseIf modeProses = 2 Then
                    KontrolProduk.UpdateData(EntitasProduk)
                End If
                MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")
                Call RefreshGrid()
                Call AturTxtBox(False)
                Call Bersih()

                btnNew.Enabled = True
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = False

                modeProses = 0
            End If
        End If
    End Sub
End Class