Public Class LaporanLabaRugi

    Dim bulan As String
    Dim baris As Integer

    Private Sub isiCbBulan()
        cbBulan.Items.Clear()
        cbBulan.Items.Add("Januari")
        cbBulan.Items.Add("Februari")
        cbBulan.Items.Add("Maret")
        cbBulan.Items.Add("April")
        cbBulan.Items.Add("Mei")
        cbBulan.Items.Add("Juni")
        cbBulan.Items.Add("Juli")
        cbBulan.Items.Add("Agustus")
        cbBulan.Items.Add("September")
        cbBulan.Items.Add("Oktober")
        cbBulan.Items.Add("November")
        cbBulan.Items.Add("Desember")
        cbBulan.SelectedItem = cbBulan.Items(0)
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPendapatan.Rows(br)
            End With
        End If

        If br < DTGrid.Rows.Count Then
            With DGPengeluaran.Rows(br)
            End With
        End If
    End Sub

    Sub HitungLabaRugi()
        Dim jumlahPendapatan As Integer
        Dim jumlahPengeluaran As Integer
        Dim jumlahPengurangan As Integer

        jumlahPendapatan = 0
        jumlahPengeluaran = 0

        For baris As Integer = 0 To DGPendapatan.Rows.Count - 1
            jumlahPendapatan = jumlahPendapatan + Val(DGPendapatan.Rows(baris).Cells(3).Value)
        Next

        For baris As Integer = 0 To DGPengeluaran.Rows.Count - 1
            jumlahPengeluaran = jumlahPengeluaran + Val(DGPengeluaran.Rows(baris).Cells(3).Value)
        Next

        jumlahPengurangan = jumlahPendapatan - jumlahPengeluaran

        lblPendapatan.Text = jumlahPendapatan
        lblPengeluaran.Text = jumlahPengeluaran
        lblPengurangan.Text = jumlahPengurangan
    End Sub

    Private Sub cbBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBulan.SelectedIndexChanged
        If cbBulan.SelectedItem = cbBulan.Items(0) Then
            bulan = "01"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(1) Then
            bulan = "02"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(2) Then
            bulan = "03"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(3) Then
            bulan = "04"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(4) Then
            bulan = "05"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(5) Then
            bulan = "06"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(6) Then
            bulan = "07"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(7) Then
            bulan = "08"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(8) Then
            bulan = "09"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(9) Then
            bulan = "10"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(10) Then
            bulan = "11"
        ElseIf cbBulan.SelectedItem = cbBulan.Items(11) Then
            bulan = "12"
        End If
    End Sub

    Private Sub LaporanLabaRugi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call isiCbBulan()
        btnCetak.Enabled = False

        cbBulan.SelectedIndex = -1
    End Sub

    Private Sub tampilCariPendapatan(bulan As String)
        DTGrid = KontrolLaporan.lihatLaporanPendapatan(bulan:=bulan).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPendapatan.DataSource = DTGrid
            DGPendapatan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPendapatan.CurrentCell = DGPendapatan.Item(1, baris)

        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Tidak ada Pendapatan pada Bulan Ini!", MsgBoxStyle.Information, "Info")
        End If

        DTGrid = KontrolLaporan.lihatLaporanPengeluaran(bulan:=bulan).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPengeluaran.DataSource = DTGrid
            DGPengeluaran.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPengeluaran.CurrentCell = DGPengeluaran.Item(1, baris)
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Tidak ada Pengeluaran pada Bulan Ini!", MsgBoxStyle.Information, "Info")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call tampilCariPendapatan(bulan)
        Call HitungLabaRugi()

        If DGPendapatan.Rows.Count > 0 Or DGPengeluaran.Rows.Count > 0 Then
            btnCetak.Enabled = True
        End If
    End Sub

    Private Sub lblJurnal_Click(sender As Object, e As EventArgs) Handles lblJurnal.Click
        LaporanJurnal.Show()
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        PrintLabaRugi.crMain1.SetParameterValue("bulan", bulan)
        PrintLabaRugi.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DGPendapatan.Columns.Clear()
        DGPengeluaran.Columns.Clear()

        btnCetak.Enabled = False

        lblPendapatan.Text = ""
        lblPengeluaran.Text = ""
        lblPengurangan.Text = ""

        cbBulan.SelectedIndex = -1
    End Sub
End Class