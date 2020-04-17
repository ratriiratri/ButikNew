Public Class LihatPendapatan

    Dim baris As Integer

    Private Sub isiCbPencarian()
        cbPencarian.Items.Add("-Pencarian-")
        cbPencarian.Items.Add("ID Pendapatan")
        cbPencarian.Items.Add("ID User")
        cbPencarian.Items.Add("Jumlah Pendapatan")
        cbPencarian.Items.Add("Keterangan")
        cbPencarian.Items.Add("Tanggal Pendapatan")
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPendapatan.TampilPendapatan.ToTable
        DGPendapatan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPendapatan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPendapatan.CurrentCell = DGPendapatan.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturDGPendapatan()
        With DGPendapatan.ColumnHeadersDefaultCellStyle
            DGPendapatan.Columns(0).HeaderText = "ID Pendapatan"
            DGPendapatan.Columns(1).HeaderText = "Jumlah"
            DGPendapatan.Columns(2).HeaderText = "Keterangan"
            DGPendapatan.Columns(3).HeaderText = "Tanggal"
            DGPendapatan.Columns(4).HeaderText = "ID User"
        End With
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPendapatan.Rows(br)
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        DTGrid = KontrolPendapatan.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPendapatan.DataSource = DTGrid
            DGPendapatan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPendapatan.CurrentCell = DGPendapatan.Item(1, baris)
        End If
        MsgBox("Data Tidak Ditemukan!")
        RefreshGrid()
    End Sub

    Private Sub LihatPendapatanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call AturDGPendapatan()
        Call isiCbPencarian()
    End Sub

    Private Sub DGPendapatan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPendapatan.CellContentClick
        baris = e.RowIndex
        DGPendapatan.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        If txtSearch.Text = "" Then
            Call RefreshGrid()
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        End If
    End Sub
End Class