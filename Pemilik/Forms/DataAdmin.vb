Public Class DataAdmin

    Dim modeProses As Integer '0=tanpa mode, 1=tambah, 2=ubah
    Dim baris As Integer

    Private Sub Bersih() 'clear isi 
        txtId.Text = ""
        txtNama.Text = ""
        txtNoHp.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub RefreshGrid() 'tampil isi tabel pada DGUser
        DTGrid = KontrolUser.TampilData.ToTable
        DGAdmin.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            DGAdmin.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGAdmin.CurrentCell = DGAdmin.Item(1, DTGrid.Rows.Count - 1)
            Call IsiBox(DTGrid.Rows.Count - 1)
            Call Bersih()
        End If
    End Sub

    Private Sub AturDGUser()
        With DGAdmin.ColumnHeadersDefaultCellStyle
            DGAdmin.Columns(0).HeaderText = "ID"
            DGAdmin.Columns(1).HeaderText = "Nama"
            DGAdmin.Columns(2).HeaderText = "No. Handphone"
            DGAdmin.Columns(3).HeaderText = "Username"
            DGAdmin.Columns(4).HeaderText = "Password"

            DGAdmin.Columns(0).FillWeight = 30
            DGAdmin.Columns(2).FillWeight = 50
            DGAdmin.Columns(3).FillWeight = 40
            DGAdmin.Columns(4).FillWeight = 40
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGAdmin.Rows(br)
                txtId.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtNoHp.Text = .Cells(2).Value.ToString
                txtUsername.Text = .Cells(3).Value.ToString
                txtPassword.Text = .Cells(4).Value.ToString
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

    Private Sub DataAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call RefreshGrid()
        Call Bersih()
        Call AturDGUser()
        AturTxtBox(False)

        If DTGrid.Rows.Count = 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If

        modeProses = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasUser
            .idUser = txtId.Text
            .namaUser = txtNama.Text
            .hpUser = txtNoHp.Text
            .usernameUser = txtUsername.Text
            .passwordUser = txtPassword.Text
            .statusUser = "1"
        End With

        If txtNama.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtNama.Focus()
            btnNew.Enabled = False
        ElseIf txtNoHp.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtNoHp.Focus()
            btnNew.Enabled = False
        ElseIf txtUsername.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtUsername.Focus()
            btnNew.Enabled = False
        ElseIf txtPassword.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtPassword.Focus()
            btnNew.Enabled = False
        Else
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

        txtId.Text = KontrolUser.FCKdUser
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturTxtBox(True)

        txtUsername.Enabled = False
        txtPassword.Enabled = False

        btnNew.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False

        txtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim statusReferensi As Boolean

        statusReferensi = KontrolUser.CekDataDipakai(txtId.Text)
        If statusReferensi Then
            MsgBox("Data masih digunakan, tidak dapat dihapus!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolUser.DeleteData(txtId.Text)
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

    Private Sub DGAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAdmin.CellContentClick, DGAdmin.CellClick
        If modeProses = 0 Or modeProses = 2 Then
            DTGrid = KontrolUser.TampilData.ToTable
            baris = e.RowIndex
            DGAdmin.Rows(baris).Selected = True
            IsiBox(baris)
        ElseIf modeProses = 1 Then
            DTGrid = KontrolUser.TampilData.ToTable
            DGAdmin.Rows(baris).Selected = False
        End If
    End Sub

    Private Sub txtNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

        If (e.KeyChar = Chr(13)) Then
            With EntitasUser
                .idUser = txtId.Text
                .namaUser = txtNama.Text
                .hpUser = txtNoHp.Text
                .usernameUser = txtUsername.Text
                .passwordUser = txtPassword.Text
                .statusUser = "1"
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
                btnNew.Enabled = False
            ElseIf txtNoHp.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNoHp.Focus()
                btnNew.Enabled = False
            ElseIf txtUsername.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtUsername.Focus()
                btnNew.Enabled = False
            ElseIf txtPassword.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtPassword.Focus()
                btnNew.Enabled = False
            Else
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
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = False

                modeProses = 0
            End If
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If (e.KeyChar = Chr(13)) Then
            With EntitasUser
                .idUser = txtId.Text
                .namaUser = txtNama.Text
                .hpUser = txtNoHp.Text
                .usernameUser = txtUsername.Text
                .passwordUser = txtPassword.Text
                .statusUser = "1"
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
                btnNew.Enabled = False
            ElseIf txtNoHp.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNoHp.Focus()
                btnNew.Enabled = False
            ElseIf txtUsername.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtUsername.Focus()
                btnNew.Enabled = False
            ElseIf txtPassword.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtPassword.Focus()
                btnNew.Enabled = False
            Else
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
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = False

                modeProses = 0
            End If
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            With EntitasUser
                .idUser = txtId.Text
                .namaUser = txtNama.Text
                .hpUser = txtNoHp.Text
                .usernameUser = txtUsername.Text
                .passwordUser = txtPassword.Text
                .statusUser = "1"
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
                btnNew.Enabled = False
            ElseIf txtNoHp.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNoHp.Focus()
                btnNew.Enabled = False
            ElseIf txtUsername.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtUsername.Focus()
                btnNew.Enabled = False
            ElseIf txtPassword.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtPassword.Focus()
                btnNew.Enabled = False
            Else
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
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = False

                modeProses = 0
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            With EntitasUser
                .idUser = txtId.Text
                .namaUser = txtNama.Text
                .hpUser = txtNoHp.Text
                .usernameUser = txtUsername.Text
                .passwordUser = txtPassword.Text
                .statusUser = "1"
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
                btnNew.Enabled = False
            ElseIf txtNoHp.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNoHp.Focus()
                btnNew.Enabled = False
            ElseIf txtUsername.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtUsername.Focus()
                btnNew.Enabled = False
            ElseIf txtPassword.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtPassword.Focus()
                btnNew.Enabled = False
            Else
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
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = False

                modeProses = 0
            End If
        End If
    End Sub
End Class