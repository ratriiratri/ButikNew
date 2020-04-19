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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Apakah Anda Yakin Ingin Keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Me.Close()
            Call CloseConnection()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Close()
        LihatTransaksiJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()

        btnDashboard.Font.Bold = True
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Show()
        LihatTransaksiJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Show()
        DataUser.Close()
        LihatTransaksiJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
    End Sub

    Private Sub btnBiaya_Click(sender As Object, e As EventArgs) Handles btnBiaya.Click
        Dashboard.Close()
        DataBiaya.Show()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Close()
        LihatTransaksiJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
    End Sub

    Private Sub btnJasa_Click(sender As Object, e As EventArgs) Handles btnJasa.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Show()
        DataProduk.Close()
        DataUser.Close()
        LihatTransaksiJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
    End Sub

    Private Sub btnPengeluaran_Click(sender As Object, e As EventArgs) Handles btnPengeluaran.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Close()
        LihatTransaksiJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Show()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Call CloseConnection()
        MsgBox("Logout Berhasil!", MsgBoxStyle.Information, "Info")
        Me.Close()
        Login.Show()
        With Login
            Login.txtUsername.Focus()
            Login.txtUsername.ResetText()
            Login.txtPassword.ResetText()
        End With
    End Sub

    Private Sub AdminUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dashboard.Show()

        lblNama.Text = nama
    End Sub

    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        Dashboard.Close()
        DataBiaya.Close()
        DataJasa.Close()
        DataProduk.Close()
        DataUser.Close()
        LihatTransaksiJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        TambahPengeluaran.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Show()
    End Sub

End Class