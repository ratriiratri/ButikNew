Public Class TambahPendapatanAdmin
    Private Sub TambahPendapatanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub

    Private Sub lblLihat_Click(sender As Object, e As EventArgs) Handles lblLihat.Click
        Me.Close()
        LihatPendapatanAdmin.Show()
    End Sub
End Class