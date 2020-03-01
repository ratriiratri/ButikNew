Public Class LihatPengeluaranAdmin
    Private Sub LihatPengeluaranAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub

    Private Sub lblTambah_Click(sender As Object, e As EventArgs) Handles lblTambah.Click
        Me.Close()
        TambahPengeluaranAdmin.Show()
    End Sub
End Class