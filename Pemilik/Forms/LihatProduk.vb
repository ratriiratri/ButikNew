Public Class LihatProduk

    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolProduk.TampilData.ToTable
        DGProduk.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGProduk.CurrentCell = DGProduk.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGProduk()
        With DGProduk.ColumnHeadersDefaultCellStyle
            DGProduk.Columns(0).HeaderText = "ID"
            DGProduk.Columns(1).HeaderText = "Nama"
            DGProduk.Columns(2).HeaderText = "Harga"
            DGProduk.Columns(3).HeaderText = "Stock"

            DGProduk.Columns(0).FillWeight = 30
            DGProduk.Columns(2).FillWeight = 30
            DGProduk.Columns(3).FillWeight = 30
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGProduk.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If rbID.Checked = True Then
            DTGrid = KontrolProduk.CariDataID(kunci).ToTable
        ElseIf rbNama.Checked = True Then
            DTGrid = KontrolProduk.CariDataNama(kunci).ToTable
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGProduk.DataSource = DTGrid
            DGProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGProduk.CurrentCell = DGProduk.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            RefreshGrid()
        End If
    End Sub

    Private Sub LihatProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call RefreshGrid()
        Call AturDGProduk()

        txtSearch.Text = ""

        rbID.Checked = False
        rbNama.Checked = True
    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click
        LihatUser.Show()
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

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
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
End Class