Public Class TambahJasaAdmin
    Private Sub TambahJasaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub

    Private Sub lblLihat_Click(sender As Object, e As EventArgs) Handles lblLihat.Click
        LihatJasaAdmin.Show()
        Me.Close()
        DataJasaAdmin.Close()
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        LihatJasaAdmin.Close()
        Me.Close()
        DataJasaAdmin.Show()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

    End Sub
End Class