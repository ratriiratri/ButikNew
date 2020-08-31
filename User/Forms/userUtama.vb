Public Class UserUtama

    Dim dragable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Apakah Anda Yakin Ingin Keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Me.Close()
            Call CloseConnection()
        End If
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
        pnlOnPosition.Height = btnProduk.Height
        pnlOnPosition.Top = btnProduk.Top
        Dashboard.Close()
        TambahTransaksiProduk.Show()
        TambahTransaksiJasa.Close()
        DataProduk.Close()
    End Sub

    Private Sub btnJasa_Click(sender As Object, e As EventArgs) Handles btnJasa.Click
        pnlOnPosition.Height = btnJasa.Height
        pnlOnPosition.Top = btnJasa.Top
        Dashboard.Close()
        TambahTransaksiProduk.Close()
        TambahTransaksiJasa.Show()
        DataProduk.Close()
    End Sub

    Private Sub UserUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlOnPosition.Height = btnDashboard.Height
        pnlOnPosition.Top = btnDashboard.Top
        Dashboard.Show()
        TambahTransaksiProduk.Close()
        TambahTransaksiJasa.Close()
        DataProduk.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlOnPosition.Height = btnDashboard.Height
        pnlOnPosition.Top = btnDashboard.Top
        Dashboard.Show()
        TambahTransaksiProduk.Close()
        TambahTransaksiJasa.Close()
        DataProduk.Close()
    End Sub

    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        pnlOnPosition.Height = btnLihat.Height
        pnlOnPosition.Top = btnLihat.Top
        Dashboard.Close()
        TambahTransaksiProduk.Close()
        TambahTransaksiJasa.Close()
        DataProduk.Show()
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

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        dragable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If dragable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        dragable = False
    End Sub
End Class