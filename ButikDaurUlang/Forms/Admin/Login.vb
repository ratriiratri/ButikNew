Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DTGrid = KontrolUser.loginAdmin(txtUsername.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            With EntitasUser
                .idUser = DTGrid.Rows(0)(0).ToString
                .namaUser = DTGrid.Rows(0)(1).ToString
                .hpUser = DTGrid.Rows(0)(2).ToString
                .usernameUser = DTGrid.Rows(0)(3).ToString
                .passwordUser = DTGrid.Rows(0)(4).ToString
                .statusUser = DTGrid.Rows(0)(5).ToString

                kodeLogin = EntitasUser.idUser
                nama = EntitasUser.namaUser
                hp = EntitasUser.hpUser
                username = EntitasUser.usernameUser
                password = EntitasUser.passwordUser
            End With

            If txtUsername.Text = EntitasUser.usernameUser And txtPassword.Text = EntitasUser.passwordUser Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Info")
                AdminUtama.Show()
                Me.Hide()
            Else
                MsgBox("Username atau Password Salah", MsgBoxStyle.Exclamation, "Peringatan")
                txtPassword.Focus()
            End If
        Else
            MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Exclamation, "Peringatan")
            txtPassword.Text = ""
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnClose_Click_3(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        CloseConnection()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            DTGrid = KontrolUser.loginAdmin(txtUsername.Text).ToTable

            If DTGrid.Rows.Count > 0 Then
                With EntitasUser
                    .idUser = DTGrid.Rows(0)(0).ToString
                    .namaUser = DTGrid.Rows(0)(1).ToString
                    .hpUser = DTGrid.Rows(0)(2).ToString
                    .usernameUser = DTGrid.Rows(0)(3).ToString
                    .passwordUser = DTGrid.Rows(0)(4).ToString
                    .statusUser = DTGrid.Rows(0)(5).ToString

                    kodeLogin = EntitasUser.idUser
                    nama = EntitasUser.namaUser
                    hp = EntitasUser.hpUser
                    username = EntitasUser.usernameUser
                    password = EntitasUser.passwordUser
                End With

                If txtUsername.Text = EntitasUser.usernameUser And txtPassword.Text = EntitasUser.passwordUser Then
                    MsgBox("Login Berhasil", MsgBoxStyle.Information, "Info")
                    AdminUtama.Show()
                    Me.Hide()
                Else
                    MsgBox("Username atau Password Salah", MsgBoxStyle.Exclamation, "Peringatan")
                    txtPassword.Focus()
                End If
            Else
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Exclamation, "Peringatan")
                txtPassword.Text = ""
                txtPassword.Focus()
            End If
        End If
    End Sub
End Class