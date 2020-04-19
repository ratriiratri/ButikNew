Public Class UserUtama
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        Else
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        Dashboard.Close()
        TambahTransaksiProduk.Show()
        TambahTransaksiJasa.Close()
        DataProduk.Close()
    End Sub

    Private Sub btnJasa_Click(sender As Object, e As EventArgs) Handles btnJasa.Click
        Dashboard.Close()
        TambahTransaksiProduk.Close()
        TambahTransaksiJasa.Show()
        DataProduk.Close()
    End Sub

    Private Sub UserUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dashboard.Show()
        TambahTransaksiProduk.Close()
        TambahTransaksiJasa.Close()
        DataProduk.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        TambahTransaksiProduk.Close()
        TambahTransaksiJasa.Close()
        DataProduk.Close()
    End Sub

    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        Dashboard.Close()
        TambahTransaksiProduk.Close()
        TambahTransaksiJasa.Close()
        DataProduk.Show()
    End Sub
End Class