Public Class LihatProduk

    Dim baris As Integer

    Dim copyID As String
    Dim copyNama As String
    Dim copyHarga As String
    Dim copyStock As String

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
            DGProduk.Columns(1).HeaderText = "Nama Produk"
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
                copyID = .Cells(0).Value.ToString
                copyNama = .Cells(1).Value.ToString
                copyHarga = .Cells(2).Value.ToString
                copyStock = .Cells(3).Value.ToString
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If rbID.Checked = True Then
            DTGrid = KontrolProduk.CariDataID(kunci).ToTable
        ElseIf rbNama.Checked = True Then
            DTGrid = KontrolProduk.CariDataNama(kunci).ToTable
        Else
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            RefreshGrid()
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGProduk.DataSource = DTGrid
            DGProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGProduk.CurrentCell = DGProduk.Item(1, baris)
        End If
    End Sub

    Private Sub LihatProdukAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call RefreshGrid()
        Call AturDGProduk()

        rbID.Checked = False
        rbNama.Checked = True
    End Sub

    Private Sub lblTambah_Click(sender As Object, e As EventArgs) Handles lblTambah.Click
        Me.Close()
        DataProduk.Show()
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        baris = DGProduk.CurrentCell.RowIndex

        With DataProduk
            .txtId.Text = DGProduk.Item(0, baris).Value.ToString
            .txtNama.Text = DGProduk.Item(1, baris).Value.ToString
            .txtHarga.Text = DGProduk.Item(2, baris).Value.ToString
            .txtStock.Text = DGProduk.Item(3, baris).Value.ToString
            Me.Close()
            DataProduk.Show()

            .txtNama.Enabled = True
            .txtHarga.Enabled = True
            .txtStock.Enabled = True

            .btnNew.Enabled = False
            .btnSave.Enabled = True
            .btnEdit.Enabled = False
            .btnDelete.Enabled = False
        End With
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If (e.KeyChar = Chr(13)) Then
            If txtSearch.Text = "" Then

                Call RefreshGrid()
            Else
                Call tampilCari(txtSearch.Text)
                txtSearch.Focus()
            End If
        End If
    End Sub
End Class