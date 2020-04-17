Public Class LihatJasa

    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolJasa.TampilData.ToTable
        DGJasa.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGJasa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGJasa.CurrentCell = DGJasa.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGJasa()
        With DGJasa.ColumnHeadersDefaultCellStyle
            DGJasa.Columns(0).HeaderText = "ID"
            DGJasa.Columns(1).HeaderText = "Nama"
            DGJasa.Columns(2).HeaderText = "Harga"

            DGJasa.Columns(0).FillWeight = 20
            DGJasa.Columns(2).FillWeight = 35

        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGJasa.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        DTGrid = KontrolJasa.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGJasa.DataSource = DTGrid
            DGJasa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGJasa.CurrentCell = DGJasa.Item(1, baris)
        End If
        MsgBox("Data Tidak Ditemukan!")
        RefreshGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call RefreshGrid()
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        End If
    End Sub

    Private Sub LihatJasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call RefreshGrid()
        Call AturDGJasa()
    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click
        LihatUser.Show()
        Me.Close()
    End Sub

    Private Sub lblProduk_Click(sender As Object, e As EventArgs) Handles lblProduk.Click
        LihatProduk.Show()
        Me.Close()
    End Sub

    Private Sub lblBiaya_Click(sender As Object, e As EventArgs) Handles lblBiaya.Click
        LihatBiaya.Show()
        Me.Close()
    End Sub
End Class