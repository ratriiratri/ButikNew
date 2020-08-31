Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = UserUtama

        btnSave.Enabled = False

        txtId.Text = kodeLogin
        txtNama.Text = nama
        txtNoHp.Text = hp
        txtUsername.Text = username
        txtPassword.Text = password

        txtNama.Enabled = False
        txtNoHp.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False

        txtNama.ReadOnly = True
        txtNoHp.ReadOnly = True
        txtUsername.ReadOnly = True
        txtPassword.ReadOnly = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtNama.Enabled = True
        txtNoHp.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True

        txtNama.ReadOnly = False
        txtNoHp.ReadOnly = False
        txtUsername.ReadOnly = False
        txtPassword.ReadOnly = False

        btnSave.Enabled = True
        btnEdit.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasUser
            .idUser = txtId.Text
            .namaUser = txtNama.Text
            .hpUser = txtNoHp.Text
            .usernameUser = txtUsername.Text
            .passwordUser = txtPassword.Text
            .statusUser = "2"
        End With

        If txtNama.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtNama.Focus()
            btnEdit.Enabled = False
        ElseIf txtNoHp.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtNoHp.Focus()
            btnEdit.Enabled = False
        ElseIf txtUsername.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtUsername.Focus()
            btnEdit.Enabled = False
        ElseIf txtPassword.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
            txtPassword.Focus()
            btnEdit.Enabled = False
        Else
            KontrolUser.UpdateDataUser(EntitasUser)
            MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")

            btnSave.Enabled = False
            btnEdit.Enabled = True

            txtNama.Enabled = False
            txtNoHp.Enabled = False
            txtUsername.Enabled = False
            txtPassword.Enabled = False
            txtNama.ReadOnly = True
            txtNoHp.ReadOnly = True
            txtUsername.ReadOnly = True
            txtPassword.ReadOnly = True
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
                .statusUser = "2"
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
                btnEdit.Enabled = False
            ElseIf txtNoHp.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNoHp.Focus()
                btnEdit.Enabled = False
            ElseIf txtUsername.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtUsername.Focus()
                btnEdit.Enabled = False
            ElseIf txtPassword.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtPassword.Focus()
                btnEdit.Enabled = False
            Else
                KontrolUser.UpdateDataUser(EntitasUser)

                MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")

                btnSave.Enabled = False
                btnEdit.Enabled = True

                txtNama.Enabled = False
                txtNoHp.Enabled = False
                txtUsername.Enabled = False
                txtPassword.Enabled = False

                txtNama.ReadOnly = True
                txtNoHp.ReadOnly = True
                txtUsername.ReadOnly = True
                txtPassword.ReadOnly = True
            End If
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
                .statusUser = "2"
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
                btnEdit.Enabled = False
            ElseIf txtNoHp.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNoHp.Focus()
                btnEdit.Enabled = False
            ElseIf txtUsername.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtUsername.Focus()
                btnEdit.Enabled = False
            ElseIf txtPassword.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtPassword.Focus()
                btnEdit.Enabled = False
            Else
                KontrolUser.UpdateDataUser(EntitasUser)

                MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")

                btnSave.Enabled = False
                btnEdit.Enabled = True

                txtNama.Enabled = False
                txtNoHp.Enabled = False
                txtUsername.Enabled = False
                txtPassword.Enabled = False

                txtNama.ReadOnly = True
                txtNoHp.ReadOnly = True
                txtUsername.ReadOnly = True
                txtPassword.ReadOnly = True
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
                .statusUser = "2"
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
                btnEdit.Enabled = False
            ElseIf txtNoHp.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNoHp.Focus()
                btnEdit.Enabled = False
            ElseIf txtUsername.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtUsername.Focus()
                btnEdit.Enabled = False
            ElseIf txtPassword.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtPassword.Focus()
                btnEdit.Enabled = False
            Else
                KontrolUser.UpdateDataUser(EntitasUser)

                MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")

                btnSave.Enabled = False
                btnEdit.Enabled = True

                txtNama.Enabled = False
                txtNoHp.Enabled = False
                txtUsername.Enabled = False
                txtPassword.Enabled = False

                txtNama.ReadOnly = True
                txtNoHp.ReadOnly = True
                txtUsername.ReadOnly = True
                txtPassword.ReadOnly = True
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
                .statusUser = "2"
            End With

            If txtNama.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNama.Focus()
                btnEdit.Enabled = False
            ElseIf txtNoHp.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtNoHp.Focus()
                btnEdit.Enabled = False
            ElseIf txtUsername.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtUsername.Focus()
                btnEdit.Enabled = False
            ElseIf txtPassword.Text = "" Then
                MsgBox("Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Information, "Peringatan")
                txtPassword.Focus()
                btnEdit.Enabled = False
            Else
                KontrolUser.UpdateDataUser(EntitasUser)

                MsgBox("Data telah tersimpan!", MsgBoxStyle.Information, "Info")

                btnSave.Enabled = False
                btnEdit.Enabled = True

                txtNama.Enabled = False
                txtNoHp.Enabled = False
                txtUsername.Enabled = False
                txtPassword.Enabled = False

                txtNama.ReadOnly = True
                txtNoHp.ReadOnly = True
                txtUsername.ReadOnly = True
                txtPassword.ReadOnly = True
            End If
        End If
    End Sub
End Class