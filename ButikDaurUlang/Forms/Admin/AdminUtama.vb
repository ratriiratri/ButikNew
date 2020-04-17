Public Class AdminUtama
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        Else
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Show()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Show()
        DataUser.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
    End Sub

    Private Sub btnBiaya_Click(sender As Object, e As EventArgs) Handles btnBiaya.Click
        Dashboard.Close()
        DataBiaya.Show()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
    End Sub

    Private Sub btnJasa_Click(sender As Object, e As EventArgs) Handles btnJasa.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Show()
        DataProduk.Close()
        DataUser.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
    End Sub

    Private Sub btnPendapatan_Click(sender As Object, e As EventArgs) Handles btnPendapatan.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Close()
        LihatJasa.Close()
        LihatPendapatan.Show()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
    End Sub

    Private Sub btnPengeluaran_Click(sender As Object, e As EventArgs) Handles btnPengeluaran.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
    End Sub

    Private Sub AdminUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dashboard.Show()
    End Sub
End Class