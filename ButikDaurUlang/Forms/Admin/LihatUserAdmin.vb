Public Class LihatUserAdmin
    Private Sub lblTambah_Click(sender As Object, e As EventArgs) Handles lblData.Click
        Me.Close()
        DataUserAdmin.Show()
    End Sub

    Private Sub LihatUserAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub
End Class