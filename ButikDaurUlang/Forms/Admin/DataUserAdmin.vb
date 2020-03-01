Public Class DataUserAdmin

    Dim modeProses As Integer '0=tanpa mode, 1=tambah, 2=ubah
    Dim baris As Integer

    Private Sub Bersih() 'clear isi 
        txtId.Text = ""
        txtNama.Text = ""
        txtNoHp.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtLevel.Text = ""
    End Sub

    Private Sub RefreshGrid() 'tampil isi tabel pada DGUser
        DTGrid = KontrolUser.TampilData.ToTable
        DGUser.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            DGUser.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGUser.CurrentCell = DGUser.Item(1, DTGrid.Rows.Count - 1)
            Call IsiBox(DTGrid.Rows.Count - 1)
            Call Bersih()
        End If
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGUser.Rows(br)
                txtId.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtNoHp.Text = .Cells(2).Value.ToString
                txtUsername.Text = .Cells(3).Value.ToString
                txtPassword.Text = .Cells(4).Value.ToString
                txtLevel.Text = .Cells(5).Value.ToString
            End With
        End If
    End Sub

    Private Sub AturTxtBox(st As Boolean)
        btnSave.Enabled = st

        txtNama.Enabled = st
        txtNoHp.Enabled = st
        txtUsername.Enabled = st
        txtPassword.Enabled = st
    End Sub

    Private Sub DataUserAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call Bersih()
        AturTxtBox(False)

        If DTGrid.Rows.Count = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub lblLihat_Click(sender As Object, e As EventArgs) Handles lblLihat.Click
        Me.Close()
        LihatUserAdmin.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasUser
            .idUser = txtId.Text
            .namaUser = txtNama.Text
            .hpUser = txtNoHp.Text
            .usernameUser = txtUsername.Text
            .passwordUser = txtPassword.Text
            .statusUser = txtLevel.Text
        End With

        If modeProses = 1 Then
            KontrolUser.InsertData(EntitasUser)
        ElseIf modeProses = 2 Then
            KontrolUser.UpdateData(EntitasUser)
        End If

        MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")

        Call RefreshGrid()
        Call Bersih()
        AturTxtBox(False)

        btnNew.Enabled = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call AturTxtBox(True)
        Call Bersih()
        modeProses = 1

        btnNew.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True

        txtId.Text = KontrolUser.FCKdUser
        txtLevel.Text = "2"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturTxtBox(True)

        txtUsername.Enabled = False
        txtPassword.Enabled = False
        btnNew.Enabled = False

        txtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim statusReferensi As Boolean

        statusReferensi = KontrolUser.CekDataDipakai(txtId.Text)
        If statusReferensi = False Then
            MsgBox("Data masih dipakai! Tidak bisa dihapus.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolUser.DeleteData(txtId.Text)
        End If

        Call RefreshGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()
    End Sub

    Private Sub DGUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUser.CellContentClick, DGUser.CellClick
        DTGrid = KontrolUser.TampilData.ToTable
        baris = e.RowIndex
        DGUser.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub
End Class