Public Class DataJasa

    Dim modeProses As Integer '0=tanpa mode, 1=tambah, 2=ubah
    Dim baris As Integer

    Private Sub Bersih()
        txtId.Text = ""
        txtNama.Text = ""
        txtHarga.Text = ""
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolJasa.TampilData.ToTable
        DGJasa.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            DGJasa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGJasa.CurrentCell = DGJasa.Item(1, DTGrid.Rows.Count - 1)
            Call IsiBox(DTGrid.Rows.Count - 1)
            Call Bersih()
        End If
    End Sub

    Private Sub AturDgJasa()
        With DGJasa.ColumnHeadersDefaultCellStyle
            DGJasa.Columns(0).HeaderText = "ID"
            DGJasa.Columns(1).HeaderText = "Nama Jasa"
            DGJasa.Columns(2).HeaderText = "Harga"
            DGJasa.Columns(0).Width = 90
            DGJasa.Columns(2).Width = 150
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGJasa.Rows(br)
                txtId.Text = .Cells(0).Value
                txtNama.Text = .Cells(1).Value
                txtHarga.Text = .Cells(2).Value
            End With
        End If
    End Sub

    Private Sub AturTxtBox(st As Boolean)
        btnSave.Enabled = st

        txtNama.Enabled = st
        txtHarga.Enabled = st
    End Sub

    Private Sub DataJasaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call Bersih()
        Call AturDgJasa()
        AturTxtBox(False)

        If DTGrid.Rows.Count = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If

        modeProses = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasJasa
            .idJasa = txtId.Text
            .namaJasa = txtNama.Text
            .hargaJasa = txtHarga.Text
        End With

        If txtNama.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtNama.Focus()
        ElseIf txtHarga.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtHarga.Focus()
        Else
            If modeProses = 1 Then
                KontrolJasa.InsertData(EntitasJasa)
            ElseIf modeProses = 2 Then
                KontrolJasa.UpdateData(EntitasJasa)
            End If

            MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")

            btnNew.Enabled = True

            Call RefreshGrid()
            Call Bersih()
            AturTxtBox(False)

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

        txtId.Text = KontrolJasa.FCKdJasa
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturTxtBox(True)

        btnNew.Enabled = False
        btnDelete.Enabled = False

        txtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim statusReferensi As Boolean

        statusReferensi = KontrolJasa.CekDataDipakai(txtId.Text)
        If statusReferensi Then
            MsgBox("Data masih dipakai! Tidak bisa dihapus.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
        "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolJasa.DeleteData(txtId.Text)
        End If

        Call RefreshGrid()
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

    Private Sub DGJasa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJasa.CellContentClick, DGJasa.CellClick
        If modeProses = 0 Or modeProses = 2 Then
            DTGrid = KontrolJasa.TampilData.ToTable
            baris = e.RowIndex
            DGJasa.Rows(baris).Selected = True
            IsiBox(baris)
        ElseIf modeProses = 1 Then
            DTGrid = KontrolJasa.TampilData.ToTable
            DGJasa.Rows(baris).Selected = False
        End If
    End Sub

    Private Sub lblLihat_Click(sender As Object, e As EventArgs) Handles lblLihat.Click
        Me.Close()
        LihatJasa.Show()
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class