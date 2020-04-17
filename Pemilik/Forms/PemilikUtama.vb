Public Class PemilikUtama

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        Else
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAdmin(sender As Object, e As EventArgs)
        DataAdmin.Show()
        LihatBiaya.Close()
        LihatJasa.Close()
        LihatTransaksiProduk.Close()
        LihatUser.Close()
    End Sub

    Private Sub btnData(sender As Object, e As EventArgs)
        DataAdmin.Close()
        LihatBiaya.Close()
        LihatJasa.Show()
        LihatTransaksiProduk.Close()
        LihatUser.Show()
    End Sub

    Private Sub btnTransaksi(sender As Object, e As EventArgs)
        DataAdmin.Close()
        LihatBiaya.Close()
        LihatJasa.Close()
        LihatTransaksiProduk.Show()
        LihatUser.Close()
    End Sub
End Class