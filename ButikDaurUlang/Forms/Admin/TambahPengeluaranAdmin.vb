Public Class TambahPengeluaranAdmin
    Private Sub TambahPengeluaranAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub

    Private Sub lblLihat_Click(sender As Object, e As EventArgs) Handles lblLihat.Click
        Me.Close()
        LihatPengeluaranAdmin.Show()
    End Sub
End Class