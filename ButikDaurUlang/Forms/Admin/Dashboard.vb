Public Class Dashboard
    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

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
            .statusUser = "1"
        End With

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

        KontrolUser.UpdateDataUser(EntitasUser)
    End Sub
End Class