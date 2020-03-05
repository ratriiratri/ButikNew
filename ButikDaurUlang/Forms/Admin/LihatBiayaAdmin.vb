Public Class LihatBiayaAdmin

    Private Sub RefreshGrid()
        DTGrid = KontrolBiaya.TampilData.ToTable
        LVBiaya.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            LVBiaya.Rows(DTGrid.Rows.Count - 1).Selected = True
            LVBiaya.CurrentCell = LVBiaya.Item(1, baris)
            'AturButton(True)
            IsiBox(baris)
        End If

    End Sub


    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPudding.Rows(br)

                CopyId = .Cells(0).Value.ToString
                CopyNama = .Cells(1).Value.ToString
                CopyHarga = .Cells(4).Value.ToString
            End With

        End If
    End Sub

    Private Sub LihatBiayaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
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