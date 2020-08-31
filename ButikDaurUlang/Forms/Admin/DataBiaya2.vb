Public Class DataBiaya2
    Dim modeProses As Integer '0=tanpa mode, 1=tambah, 2=ubah
    Dim baris As Integer
    Dim _kode As String
    Dim kelAk As String

    Private Sub isiCbKel()
        cbKel.Items.Clear()
        cbKel.Items.Add("51 - Pembelian")
        cbKel.Items.Add("61 - Beban")
        cbKel.Items.Add("81 - Beban Lain-lain")
        cbKel.SelectedItem = cbKel.Items(0)
    End Sub

    Private Sub Bersih()
        txtId.Text = ""
        txtNama.Text = ""

        cbKel.SelectedIndex = -1
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

            DGBiaya.Columns(0).FillWeight = 20
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
        txtNama.ReadOnly = Not st
        cbKel.Enabled = st
    End Sub

    Private Sub DataBiaya2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call isiCbKel()
        Call Bersih()
        Call AturDgBiaya()
        AturTxtBox(False)

        If DTGrid.Rows.Count = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If

        modeProses = 0
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call AturTxtBox(True)
        Call Bersih()

        modeProses = 1

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasBiaya
            .idBiaya = txtId.Text
            .namaBiaya = txtNama.Text
            .jnsSaldo = "D"
        End With

        If txtNama.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtNama.Focus()
            btnNew.Enabled = False
        Else
            If modeProses = 1 Then
                KontrolBiaya.InsertData(EntitasBiaya)
            ElseIf modeProses = 2 Then
                KontrolBiaya.UpdateData(EntitasBiaya)
            End If
            MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
            Call Bersih()
            AturTxtBox(False)

            btnNew.Enabled = True
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False

            modeProses = 0
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturTxtBox(True)

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        cbKel.Enabled = False

        txtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim statusReferensi As Boolean

        statusReferensi = KontrolBiaya.CekDataDipakai(txtId.Text)

        If statusReferensi Then
            MsgBox("Data masih digunakan, tidak dapat dihapus!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolBiaya.DeleteData(txtId.Text)
        End If

        Call RefreshGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()
        Call Bersih()
        AturTxtBox(False)

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False

        modeProses = 0
    End Sub

    Private Sub DGBiaya_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBiaya.CellContentClick

    End Sub

    Private Sub DGBiaya_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBiaya.CellContentDoubleClick
        If modeProses = 0 Or modeProses = 2 Then
            DTGrid = KontrolBiaya.TampilData.ToTable
            baris = e.RowIndex
            DGBiaya.Rows(baris).Selected = True
            IsiBox(baris)
        ElseIf modeProses = 1 Then
            DTGrid = KontrolBiaya.TampilData.ToTable
            DGBiaya.Rows(baris).Selected = False
        End If
    End Sub

    Private Sub cbKel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKel.SelectedIndexChanged
        Dim arrKel() As String
        Dim kel As String
        Dim h As String

        If cbKel.SelectedIndex = -1 Then
            Call Bersih()
            txtNama.Enabled = False
            txtNama.ReadOnly = True
        Else
            txtNama.Enabled = True
            txtNama.ReadOnly = False
            txtNama.Focus()

            arrKel = cbKel.Text.Split(" - ")
            kel = arrKel(0)
            h = kel.Substring(0, 2)

            txtNama.Enabled = True
            txtId.Text = KontrolBiaya.FCKdBiaya(kel:=h)
        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If (e.KeyChar = Chr(13)) Then
            With EntitasBiaya
                .idBiaya = txtId.Text
                .namaBiaya = txtNama.Text
                .jnsSaldo = "D"
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
                btnNew.Enabled = False
            Else
                If modeProses = 1 Then
                    KontrolBiaya.InsertData(EntitasBiaya)
                ElseIf modeProses = 2 Then
                    KontrolBiaya.UpdateData(EntitasBiaya)
                End If
                MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")
                Call RefreshGrid()
                Call Bersih()
                AturTxtBox(False)

                btnNew.Enabled = True
                btnDelete.Enabled = True
                btnEdit.Enabled = True
                btnSave.Enabled = False

                modeProses = 0
            End If
        End If
    End Sub

    Private Sub DGBiaya_Sorted(sender As Object, e As EventArgs) Handles DGBiaya.Sorted
        DGBiaya.ReadOnly = SortOrder.None
    End Sub
End Class