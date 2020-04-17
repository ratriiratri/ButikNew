Public Class LihatJasa

    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolJasa.TampilDetailJasa.ToTable
        DGDetailJasa.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDetailJasa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDetailJasa.CurrentCell = DGDetailJasa.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGDetailJasa()
        With DGDetailJasa.ColumnHeadersDefaultCellStyle
            DGDetailJasa.Columns(0).HeaderText = "ID Jasa"
            DGDetailJasa.Columns(1).HeaderText = "Nama Jasa"
            DGDetailJasa.Columns(2).HeaderText = "Jumlah"
            DGDetailJasa.Columns(3).HeaderText = "Harga"
            DGDetailJasa.Columns(4).HeaderText = "Tanggal"
            DGDetailJasa.Columns(5).HeaderText = "ID User"
            DGDetailJasa.Columns(6).HeaderText = "ID Pendapatan"

            DGDetailJasa.Columns(0).FillWeight = 12
            DGDetailJasa.Columns(2).FillWeight = 8
            DGDetailJasa.Columns(3).FillWeight = 10
            DGDetailJasa.Columns(4).FillWeight = 10
            DGDetailJasa.Columns(5).FillWeight = 12
            DGDetailJasa.Columns(6).FillWeight = 12
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGDetailJasa.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        DTGrid = KontrolPendapatan.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDetailJasa.DataSource = DTGrid
            DGDetailJasa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDetailJasa.CurrentCell = DGDetailJasa.Item(1, baris)
        End If
        MsgBox("Data Tidak Ditemukan!")
        RefreshGrid()
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        Me.Close()
        DataJasa.Show()
    End Sub

    Private Sub LihatJasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call AturDGDetailJasa()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call RefreshGrid()
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshGrid()
    End Sub

End Class