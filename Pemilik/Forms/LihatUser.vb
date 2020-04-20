Public Class LihatUser
    Dim baris As Integer

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
        If rbID.Checked = True Then
            DTGrid = KontrolUser.CariDataID(kunci).ToTable
        ElseIf rbNama.Checked = True Then
            DTGrid = KontrolUser.CariDataNama(kunci).ToTable
        ElseIf rbHp.Checked = True Then
            DTGrid = KontrolUser.CariDataHp(kunci).ToTable
        Else
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            RefreshGrid()
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGUser.DataSource = DTGrid
            DGUser.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGUser.CurrentCell = DGUser.Item(1, baris)
        End If
    End Sub

    Private Sub LihatUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call RefreshGrid()
        Call AturDGUser()

        rbID.Checked = False
        rbNama.Checked = True
        rbHp.Checked = False
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

        rbID.Checked = False
        rbNama.Checked = True
        rbHp.Checked = False

        txtSearch.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then

            Call RefreshGrid()
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        End If
    End Sub
End Class