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


End Class