Public Class DataBiaya

    Dim modeProses As Integer '0=tanpa mode, 1=tambah, 2=ubah
    Dim baris As Integer

    Private Sub Bersih()
        txtId.Text = ""
        txtNama.Text = ""
    End Sub

    Private Sub RefreshGrid() 'tampil isi tabel pada DGUser
        DTGrid = KontrolBiaya.TampilData.ToTable
        DGBiaya.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            DGBiaya.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBiaya.CurrentCell = DGBiaya.Item(1, DTGrid.Rows.Count - 1)
            Call IsiBox(DTGrid.Rows.Count - 1)
            Call Bersih()
        End If
    End Sub

    Private Sub AturDgBiaya()
        With DGBiaya.ColumnHeadersDefaultCellStyle
            DGBiaya.Columns(0).HeaderText = "ID"
            DGBiaya.Columns(1).HeaderText = "Nama Biaya"
            DGBiaya.Columns(0).Width = 124
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBiaya.Rows(br)
                txtId.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
            End With
        End If
    End Sub

    Private Sub AturTxtBox(st As Boolean)
        btnSave.Enabled = st

        txtNama.Enabled = st
    End Sub

    Private Sub DataBiayaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call Bersih()
        Call AturDgBiaya()
        AturTxtBox(False)

        If DTGrid.Rows.Count = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub lblTambah_Click(sender As Object, e As EventArgs)
        Me.Close()
        TambahPengeluaran.Show()
    End Sub

    Private Sub lblLihat_Click(sender As Object, e As EventArgs)
        Me.Close()
        TambahPengeluaran.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasBiaya
            .idBiaya = txtId.Text
            .namaBiaya = txtNama.Text
        End With

        If modeProses = 1 Then
            KontrolBiaya.InsertData(EntitasBiaya)
        ElseIf modeProses = 2 Then
            KontrolBiaya.UpdateData(EntitasBiaya)
        End If

        MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")

        btnNew.Enabled = True
        Call RefreshGrid()
        Call Bersih()
        AturTxtBox(False)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call AturTxtBox(True)
        Call Bersih()
        modeProses = 1

        btnNew.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True

        txtId.Text = KontrolBiaya.FCKdBiaya
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturTxtBox(True)

        btnNew.Enabled = False

        txtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim statusReferensi As Boolean

        statusReferensi = KontrolBiaya.CekDataDipakai(txtId.Text)
        If statusReferensi Then
            MsgBox("Data masih dipakai! Tidak bisa dihapus.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
        "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolBiaya.DeleteData(txtId.Text)
        End If

        Call RefreshGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()
    End Sub

    Private Sub DGBiaya_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBiaya.CellContentClick, DGBiaya.CellClick
        DTGrid = KontrolBiaya.TampilData.ToTable
        baris = e.RowIndex
        DGBiaya.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class