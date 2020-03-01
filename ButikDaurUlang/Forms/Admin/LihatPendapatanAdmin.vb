Public Class LihatPendapatanAdmin
    Private Sub LihatPendapatanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub

    Private Sub lblTambah_Click(sender As Object, e As EventArgs) Handles lblTambah.Click
        Me.Close()
        TambahPendapatanAdmin.Show()
    End Sub
End Class