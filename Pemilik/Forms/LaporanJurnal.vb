Public Class LaporanJurnal

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
            With DGJurnal.Rows(br)
            End With
        End If
    End Sub

    Sub HitungJurnal()
        Dim jumlahDebit As Integer
        Dim jumlahKredit As Integer

        jumlahDebit = 0
        jumlahKredit = 0

        For baris As Integer = 0 To DGJurnal.Rows.Count - 1
            jumlahDebit = jumlahDebit + Val(DGJurnal.Rows(baris).Cells(4).Value)
            jumlahKredit = jumlahKredit + Val(DGJurnal.Rows(baris).Cells(4).Value)
        Next
        lblDebit.Text = jumlahDebit
        lblKredit.Text = jumlahKredit
    End Sub

    Private Sub LaporanJurnal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PemilikUtama

        Call isiCbBulan()

        btnCetak.Enabled = False

        cbBulan.SelectedIndex = -1
    End Sub

    Private Sub tampilCari(bulan As String)
        DTGrid = KontrolLaporan.lihatLaporanJurnal(bulan:=bulan).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGJurnal.DataSource = DTGrid
            DGJurnal.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGJurnal.CurrentCell = DGJurnal.Item(1, baris)

            btnCetak.Enabled = True
        ElseIf DTGrid.Rows.Count = 0 Then
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Information, "Info")
            btnCetak.Enabled = False
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call tampilCari(bulan)
        Call HitungJurnal()
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

    Private Sub lblLabaRugi_Click(sender As Object, e As EventArgs) Handles lblLabaRugi.Click
        LaporanLabaRugi.Show()
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        PrintJurnal.crJurnal1.SetParameterValue("bulan", cbBulan.SelectedItem())
        PrintJurnal.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DGJurnal.Columns.Clear()

        btnCetak.Enabled = False

        lblDebit.Text = ""
        lblKredit.Text = ""

        cbBulan.SelectedIndex = -1
    End Sub
End Class