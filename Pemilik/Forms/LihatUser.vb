Public Class LihatUser
    Dim baris As Integer

    Private Sub isiCbPencarian()
        cbPencarian.Items.Clear()
        cbPencarian.Items.Add("-Pencarian-")
        cbPencarian.Items.Add("ID")
        cbPencarian.Items.Add("Nama")
        cbPencarian.Items.Add("No. Handphone")
        cbPencarian.Items.Add("Status")
        cbPencarian.SelectedItem = cbPencarian.Items(0)
    End Sub

    Private Sub bersih()
        checkUser.Checked = False
        checkAdmin.Checked = False
        txtSearch.Text = ""
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolUser.TampilDataUser.ToTable
        DGUser.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGUser.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGUser.CurrentCell = DGUser.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGUser()
        With DGUser.ColumnHeadersDefaultCellStyle
            DGUser.Columns(0).HeaderText = "ID"
            DGUser.Columns(1).HeaderText = "Nama"
            DGUser.Columns(2).HeaderText = "No. Handphone"
            DGUser.Columns(3).HeaderText = "Status"

            DGUser.Columns(0).FillWeight = 20
            DGUser.Columns(2).FillWeight = 40
            DGUser.Columns(3).FillWeight = 35
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGUser.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If cbPencarian.SelectedItem = cbPencarian.Items(1) Then
            DTGrid = KontrolUser.CariDataID(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) Then
            DTGrid = KontrolUser.CariDataNama(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) Then
            DTGrid = KontrolUser.CariDataHp(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(1) And checkAdmin.Checked = True Then
            DTGrid = KontrolUser.CariDataIDAdmin(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) And checkAdmin.Checked = True Then
            DTGrid = KontrolUser.CariDataNamaAdmin(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) And checkAdmin.Checked = True Then
            DTGrid = KontrolUser.CariDataHpAdmin(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(1) And checkUser.Checked = True Then
            DTGrid = KontrolUser.CariDataIDUser(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(2) And checkUser.Checked = True Then
            DTGrid = KontrolUser.CariDataNamaUser(kunci).ToTable
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(3) And checkUser.Checked = True Then
            DTGrid = KontrolUser.CariDataHpUser(kunci).ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGUser.DataSource = DTGrid
            DGUser.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGUser.CurrentCell = DGUser.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
        End If
    End Sub

    Private Sub tampilCari2()
        If checkAdmin.Checked = True Then
            DTGrid = KontrolUser.CariDataStatusAdmin().ToTable
        ElseIf checkUser.Checked = True Then
            DTGrid = KontrolUser.CariDataStatusUser().ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGUser.DataSource = DTGrid
            DGUser.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGUser.CurrentCell = DGUser.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
        End If
    End Sub

    Private Sub LihatUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call RefreshGrid()
        Call isiCbPencarian()
        Call AturDGUser()
        Call bersih()

        cbPencarian.SelectedItem = cbPencarian.Items(0)
    End Sub

    Private Sub lblProduk_Click(sender As Object, e As EventArgs) Handles lblProduk.Click
        LihatProduk.Show()
        Me.Close()
    End Sub

    Private Sub lblJasa_Click(sender As Object, e As EventArgs) Handles lblJasa.Click
        LihatJasa.Show()
        Me.Close()
    End Sub

    Private Sub lblBiaya_Click(sender As Object, e As EventArgs) Handles lblBiaya.Click
        LihatBiaya.Show()
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()
        Call bersih()

        cbPencarian.SelectedItem = cbPencarian.Items(0)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbPencarian.SelectedItem = cbPencarian.Items(4) Then
            Call tampilCari2()
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) And checkAdmin.Checked = False And checkUser.Checked = False Then
            MsgBox("Pilih Status yang Ingin Dicari", MsgBoxStyle.Information, "Info")
        ElseIf txtSearch.Text = "" Then
            MsgBox("Masukan Kata Kunci", MsgBoxStyle.Information, "Info")
            txtSearch.Focus()
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        End If
    End Sub

    Private Sub cbPencarian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPencarian.SelectedIndexChanged
        If cbPencarian.SelectedItem = cbPencarian.Items(0) Then
            txtSearch.Enabled = False
            checkAdmin.Enabled = False
            checkUser.Enabled = False
        ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) Then
            txtSearch.Enabled = False
            checkAdmin.Enabled = True
            checkUser.Enabled = True
        Else
            txtSearch.Enabled = True
            checkAdmin.Enabled = True
            checkUser.Enabled = True
        End If
    End Sub

    Private Sub checkAdmin_Click(sender As Object, e As EventArgs) Handles checkAdmin.Click
        If checkAdmin.Checked = True Then
            checkUser.Checked = False
        End If
    End Sub

    Private Sub checkUser_Click(sender As Object, e As EventArgs) Handles checkUser.Click
        If checkUser.Checked = True Then
            checkAdmin.Checked = False
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If (e.KeyChar = Chr(13)) Then
            If cbPencarian.SelectedItem = cbPencarian.Items(4) Then
                Call tampilCari2()
            ElseIf cbPencarian.SelectedItem = cbPencarian.Items(4) And checkAdmin.Checked = False And checkUser.Checked = False Then
                MsgBox("Pilih Status yang Ingin Dicari", MsgBoxStyle.Information, "Info")
            ElseIf txtSearch.Text = "" Then
                MsgBox("Masukan Kata Kunci", MsgBoxStyle.Information, "Info")
                txtSearch.Focus()
            Else
                Call tampilCari(txtSearch.Text)
                txtSearch.Focus()
            End If
        End If
    End Sub
End Class