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
        DashboardAdmin.Show()
        DataUserAdmin.Close()
        LihatUserAdmin.Close()
        DataProdukAdmin.Close()
        LihatProdukAdmin.Close()
        DataJasaAdmin.Close()
        LihatJasaAdmin.Close()
        DataBiayaAdmin.Close()
        TambahBiayaAdmin.Close()
        LihatBiayaAdmin.Close()
        TambahPendapatanAdmin.Close()
        LihatPendapatanAdmin.Close()
        TambahPengeluaranAdmin.Close()
        LihatPengeluaranAdmin.Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        DashboardAdmin.Close()
        DataUserAdmin.Show()
        LihatUserAdmin.Close()
        DataProdukAdmin.Close()
        LihatProdukAdmin.Close()
        DataJasaAdmin.Close()
        LihatJasaAdmin.Close()
        DataBiayaAdmin.Close()
        TambahBiayaAdmin.Close()
        LihatBiayaAdmin.Close()
        TambahPendapatanAdmin.Close()
        LihatPendapatanAdmin.Close()
        TambahPengeluaranAdmin.Close()
        LihatPengeluaranAdmin.Close()
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        DashboardAdmin.Close()
        DataUserAdmin.Close()
        LihatUserAdmin.Close()
        DataProdukAdmin.Show()
        LihatProdukAdmin.Close()
        DataJasaAdmin.Close()
        LihatJasaAdmin.Close()
        DataBiayaAdmin.Close()
        TambahBiayaAdmin.Close()
        LihatBiayaAdmin.Close()
        TambahPendapatanAdmin.Close()
        LihatPendapatanAdmin.Close()
        TambahPengeluaranAdmin.Close()
        LihatPengeluaranAdmin.Close()
    End Sub

    Private Sub btnBiaya_Click(sender As Object, e As EventArgs) Handles btnBiaya.Click
        DashboardAdmin.Close()
        DataUserAdmin.Close()
        LihatUserAdmin.Close()
        DataProdukAdmin.Close()
        LihatProdukAdmin.Close()
        DataJasaAdmin.Close()
        LihatJasaAdmin.Close()
        DataBiayaAdmin.Show()
        TambahBiayaAdmin.Close()
        LihatBiayaAdmin.Close()
        TambahPendapatanAdmin.Close()
        LihatPendapatanAdmin.Close()
        TambahPengeluaranAdmin.Close()
        LihatPengeluaranAdmin.Close()
    End Sub

    Private Sub btnJasa_Click(sender As Object, e As EventArgs) Handles btnJasa.Click
        DashboardAdmin.Close()
        DataUserAdmin.Close()
        LihatUserAdmin.Close()
        DataProdukAdmin.Close()
        LihatProdukAdmin.Close()
        DataJasaAdmin.Show()
        LihatJasaAdmin.Close()
        DataBiayaAdmin.Close()
        TambahBiayaAdmin.Close()
        LihatBiayaAdmin.Close()
        TambahPendapatanAdmin.Close()
        LihatPendapatanAdmin.Close()
        TambahPengeluaranAdmin.Close()
        LihatPengeluaranAdmin.Close()
    End Sub

    Private Sub btnPendapatan_Click(sender As Object, e As EventArgs) Handles btnPendapatan.Click
        DashboardAdmin.Close()
        DataUserAdmin.Close()
        LihatUserAdmin.Close()
        DataProdukAdmin.Close()
        LihatProdukAdmin.Close()
        DataJasaAdmin.Close()
        LihatJasaAdmin.Close()
        DataBiayaAdmin.Close()
        TambahBiayaAdmin.Close()
        LihatBiayaAdmin.Close()
        TambahPendapatanAdmin.Show()
        LihatPendapatanAdmin.Close()
        TambahPengeluaranAdmin.Close()
        LihatPengeluaranAdmin.Close()
    End Sub

    Private Sub btnPengeluaran_Click(sender As Object, e As EventArgs) Handles btnPengeluaran.Click
        DashboardAdmin.Close()
        DataUserAdmin.Close()
        LihatUserAdmin.Close()
        DataProdukAdmin.Close()
        LihatProdukAdmin.Close()
        DataJasaAdmin.Close()
        LihatJasaAdmin.Close()
        DataBiayaAdmin.Close()
        TambahBiayaAdmin.Close()
        LihatBiayaAdmin.Close()
        TambahPendapatanAdmin.Close()
        LihatPendapatanAdmin.Close()
        TambahPengeluaranAdmin.Show()
        LihatPengeluaranAdmin.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
    End Sub

    Private Sub AdminUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class