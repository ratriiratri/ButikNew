Public Class LihatJasaAdmin
    Private Sub LihatJasaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub

    Private Sub lblTambah_Click(sender As Object, e As EventArgs) Handles lblTambah.Click
        Me.Close()
        DataJasaAdmin.Close()
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        Me.Close()
        DataJasaAdmin.Show()
    End Sub

    Private Sub DGJasa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJasa.CellContentClick

    End Sub
End Class