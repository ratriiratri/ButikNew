Public Class LihatBiayaAdmin

    Private Sub LihatBiayaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        DTGrid = KontrolBiaya.TampilData.ToTable
    End Sub

    Private Sub lblTambah_Click(sender As Object, e As EventArgs) Handles lblTambah.Click
        Me.Close()
        TambahBiayaAdmin.Show()
        DataBiayaAdmin.Close()
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        Me.Close()
        TambahBiayaAdmin.Close()
        DataBiayaAdmin.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DTGrid = KontrolBiaya.CariData(txtSearch.Text).ToTable
        LVBiaya.Items.Clear()

        Dim strItem(1) As String

        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
            Next
            LVBiaya.Items.Add(New ListViewItem(strItem))
        Else
            MsgBox("Data Tidak Ditemukan!")
        End If
    End Sub

    Private Sub LVBiaya_DoubleClick(sender As Object, e As EventArgs) Handles LVBiaya.DoubleClick
        With TambahBiayaAdmin
            .txtId.Text = LVBiaya.SelectedItems(0).SubItems(0).Text
            .txtNama.Text = LVBiaya.SelectedItems(0).SubItems(1).Text
            Me.Close()
            .txtNama.Focus()
        End With
    End Sub
End Class