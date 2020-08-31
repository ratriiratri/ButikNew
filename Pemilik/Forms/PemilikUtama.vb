Public Class PemilikUtama

    Dim dragable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTop.MouseDown
        dragable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub panelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTop.MouseMove
        If dragable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Apakah Anda Yakin Ingin Keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Me.Close()
            Call CloseConnection()
        End If
    End Sub

    Private Sub panelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles panelTop.MouseUp
        dragable = False
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        Else
            Me.WindowState = WindowState.Normal
            Me.StartPosition = StartPosition.CenterScreen
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = WindowState.Minimized
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

    Private Sub PemilikUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlOnPosition.Height = btnDashboard.Height
        pnlOnPosition.Top = btnDashboard.Top
        Dashboard.Show()
        DataAdmin.Close()
        LihatBiaya.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
        LihatUser.Close()
        LaporanJurnal.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        pnlOnPosition.Height = btnAdmin.Height
        pnlOnPosition.Top = btnAdmin.Top
        Dashboard.Close()
        DataAdmin.Show()
        LihatBiaya.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
        LihatUser.Close()
        LaporanJurnal.Close()
    End Sub

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        pnlOnPosition.Height = btnData.Height
        pnlOnPosition.Top = btnData.Top
        Dashboard.Close()
        DataAdmin.Close()
        LihatBiaya.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
        LihatUser.Show()
        LaporanJurnal.Close()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        pnlOnPosition.Height = btnTransaksi.Height
        pnlOnPosition.Top = btnTransaksi.Top
        Dashboard.Close()
        DataAdmin.Close()
        LihatBiaya.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Show()
        LihatUser.Close()
        LaporanJurnal.Close()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        pnlOnPosition.Height = btnLaporan.Height
        pnlOnPosition.Top = btnLaporan.Top
        Dashboard.Close()
        DataAdmin.Close()
        LihatBiaya.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
        LihatUser.Close()
        LaporanJurnal.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlOnPosition.Height = btnDashboard.Height
        pnlOnPosition.Top = btnDashboard.Top
        Dashboard.Show()
        DataAdmin.Close()
        LihatBiaya.Close()
        LihatJasa.Close()
        LihatPendapatan.Close()
        LihatPengeluaran.Close()
        LihatProduk.Close()
        LihatTransaksiBiaya.Close()
        LihatTransaksiJasa.Close()
        LihatTransaksiProduk.Close()
        LihatUser.Close()
        LaporanJurnal.Close()
    End Sub
End Class