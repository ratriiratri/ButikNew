Imports System.Data.OleDb

Public Class TambahBiayaAdmin

    Private Sub Bersih() 'clear isi 
        txtId.Text = ""
        txtNama.Text = ""
        txtDisc.Text = ""
        txtJumlah.Text = ""
    End Sub

    Sub HitungTotal()
        Dim total As Integer
        total = 0

        For i = 0 To DGDetailBiaya.Rows.Item.Count - 1
            total = total + DGDetailBiaya.Item(baris).Cells(4).Text
        Next

        lblNominal.Text = total
    End Sub

    Private Sub TambahBiayaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama
    End Sub

    Private Sub lblLihat_Click(sender As Object, e As EventArgs) Handles lblLihat.Click
        LihatBiayaAdmin.Show()
        Me.Close()
        DataBiayaAdmin.Close()
    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        LihatBiayaAdmin.Close()
        Me.Close()
        DataBiayaAdmin.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim namaHari As String()

        namaHari = New String() {"Minggu", "Senin", "Selasa", "Rabu", "Kmais", "Jumat", "Sabtu"}

        lblTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & "yyyy/MM/dd")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'deklarasi array string
        Dim strItem(4) As String

        strItem(0) = txtId.Text
        strItem(1) = txtNama.Text
        strItem(2) = txtJumlah.Text
        strItem(3) = txtDisc.Text
        strItem(4) = txtJumlah.Text - (txtJumlah.Text * txtDisc.Text)

        'tambahkan item add (DGDetailBiaya) dengan isi array
        DGDetailBiaya.Item.Add(New ListViewItem(strItem))

        Call Bersih()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            DGDetailBiaya.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub btnCariBarang_Click(sender As Object, e As EventArgs) Handles btnCariBarang.Click
        LihatBiayaAdmin.Show()
        Me.Close()
    End Sub
End Class