Public Class LihatJasaAdmin
    Private Sub LihatJasaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub

    Private Sub lblTambah_Click(sender As Object, e As EventArgs) Handles lblTambah.Click
        Me.Close()
        TambahJasaAdmin.Show()
        DataJasaAdmin.Close()
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        Me.Close()
        TambahJasaAdmin.Close()
        DataJasaAdmin.Show()
    End Sub
End Class