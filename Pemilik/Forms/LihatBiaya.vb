Public Class LihatBiaya

    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolBiaya.TampilData.ToTable
        DGBiaya.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBiaya.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBiaya.CurrentCell = DGBiaya.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGBiaya()
        With DGBiaya.ColumnHeadersDefaultCellStyle
            DGBiaya.Columns(0).HeaderText = "ID"
            DGBiaya.Columns(1).HeaderText = "Nama"
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBiaya.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If rbID.Checked = True Then
            DTGrid = KontrolBiaya.CariDataID(kunci).ToTable
        ElseIf rbNama.Checked = True Then
            DTGrid = KontrolBiaya.CariDataNama(kunci).ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBiaya.DataSource = DTGrid
            DGBiaya.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBiaya.CurrentCell = DGBiaya.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            RefreshGrid()
        End If
    End Sub

    Private Sub LihatBiaya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call RefreshGrid()
        Call AturDGBiaya()

        txtSearch.Text = ""

        rbID.Checked = False
        rbNama.Checked = True
    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click
        LihatUser.Show()
        Me.Close()
    End Sub

    Private Sub lblProduk_Click(sender As Object, e As EventArgs) Handles lblProduk.Click
        LihatProduk.Show()
        Me.Close()
    End Sub

    Private Sub lblJasa_Click(sender As Object, e As EventArgs) Handles lblJasa.Click
        LihatJasa.Show()
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            MsgBox("Masukan Kata Kunci!", MsgBoxStyle.Information, "Info")
            Call RefreshGrid()
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()

        rbID.Checked = False
        rbNama.Checked = True

        txtSearch.Text = ""
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If (e.KeyChar = Chr(13)) Then
            If txtSearch.Text = "" Then
                MsgBox("Masukan Kata Kunci!", MsgBoxStyle.Information, "Info")
                Call RefreshGrid()
            Else
                Call tampilCari(txtSearch.Text)
                txtSearch.Focus()
            End If
        End If
    End Sub
End Class