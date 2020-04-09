Public Class ListProduk
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DTGrid = KontrolProduk.CariData(txtSearch.Text).ToTable
        LVProduk.Items.Clear()
        Dim strItem(3) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString
            Next
            LVProduk.Items.Add(New ListViewItem(strItem))
        Else
            MsgBox("Data Tidak Di Temukan")
        End If
    End Sub

    Private Sub LVProduk_DoubleClick(sender As Object, e As EventArgs) Handles LVProduk.DoubleClick
        With TambahTransaksiProduk
            .txtId.Text = LVProduk.SelectedItems(0).SubItems(0).Text
            .txtNama.Text = LVProduk.SelectedItems(0).SubItems(1).Text
            .txtHarga.Text = LVProduk.SelectedItems(0).SubItems(2).Text
            Me.Close()
            .txtQty.Focus()
        End With
    End Sub
End Class