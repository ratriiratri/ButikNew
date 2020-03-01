Public Class LihatProdukAdmin
    Private Sub LihatProdukAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        Me.Close()
        DataProdukAdmin.Show()
    End Sub
End Class