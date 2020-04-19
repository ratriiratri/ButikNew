Public Class TambahTransaksiProduk

    Private Sub Bersih()
        txtId.Text = ""
        txtNama.Text = ""
        txtHarga.Text = ""
        txtQty.Text = ""
        txtDisc.Text = ""
        lblNominal.Text = 0
    End Sub

    Sub HitungTotal()
        Dim total As Integer

        total = 0

        For i = 0 To LVDetailProduk.Items.Count - 1
            total = total + (LVDetailProduk.Items(i).SubItems(5).Text)
        Next

        lblNominal.Text = total
    End Sub

    Private Sub TambahTransaksiProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = UserUtama

        Call Bersih()

        btnAdd.Enabled = False
        btnEdit.Enabled = False

        lblUser.Text = kodeLogin

        lblTanggal.Text = Format(Now, "yyyy/MM/dd hh:mm")
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        ListProduk.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'deklarasi array string
        Dim strItem(5) As String
        Dim update As Integer

        For Each id As ListViewItem In LVDetailProduk.Items
            If id.Text = txtId.Text Then
                update = txtQty.Text + LVDetailProduk.Items(0).SubItems(3).Text
            End If
        Next

        If txtNama.Text = "" Then
            MsgBox("Masukan Produk Terlebih Dahulu!", MsgBoxStyle.Information, "Info")
        ElseIf txtQty.Text = "" Then
            MsgBox("Masukan Jumlah Produk Terlebih Dahulu!", MsgBoxStyle.Information, "Info")
        ElseIf txtDisc.Text = "" Then
            txtDisc.Text = 0
        End If

        strItem(0) = txtId.Text
        strItem(1) = txtNama.Text
        strItem(2) = txtQty.Text
        strItem(3) = txtHarga.Text
        strItem(4) = txtDisc.Text
        strItem(5) = txtQty.Text * txtHarga.Text - ((txtDisc.Text / 100) * (txtQty.Text * txtHarga.Text))

        'tambahkan item add (ListViewDetailBiaya) dengan isi array
        LVDetailProduk.Items.Add(New ListViewItem(strItem))

        For Each id As ListViewItem In LVDetailProduk.Items
            If id.Text = txtId.Text Then
                update = txtQty.Text + LVDetailProduk.Items(0).SubItems(3).Text

                strItem(0) = txtId.Text
                strItem(1) = txtNama.Text
                strItem(2) = update
                strItem(3) = txtHarga.Text
                strItem(4) = txtDisc.Text
                strItem(5) = txtQty.Text * txtHarga.Text - ((txtDisc.Text / 100) * (txtQty.Text * txtHarga.Text))
            End If
        Next


        Call HitungTotal()
        Call Bersih()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        LVDetailProduk.SelectedItems(0).Remove()
        Call HitungTotal()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim listDetail As New List(Of EntityDetailProduk)()

        If LVDetailProduk.Items.Count = 0 Then
            MsgBox("Masukan Produk terlebih dulu")
            Exit Sub
        End If

        With EntitasPendapatan
            .idPendapatan = lblPendapatan.Text
            .jmlPendapatan = lblNominal.Text
            .ketPendapatan = "Produk"
            .tglPendapatan = Format(Now, "yyyy/MM/dd")
            .idUser = lblUser.Text
        End With

        For i = 0 To LVDetailProduk.Items.Count - 1
            EntitasDetailProduk = New EntityDetailProduk
            With LVDetailProduk.Items(i)
                EntitasDetailProduk.idProduk = .SubItems(0).Text
                EntitasDetailProduk.idPendapatan = lblPendapatan.Text
                EntitasDetailProduk.jumlahProduk = .SubItems(2).Text
                EntitasDetailProduk.discProduk = .SubItems(4).Text
            End With
            listDetail.Add(EntitasDetailProduk)
        Next (i)
        KontrolPendapatan.SimpanData(EntitasPendapatan, listDetail)
        MsgBox("Data Berhasil Disimpan")

        Call Bersih()

        LVDetailProduk.Items.Clear()

        lblPendapatan.Text = ""

        btnNew.Enabled = True
        btnEdit.Enabled = False
        btnAdd.Enabled = False

        txtQty.Enabled = False
        txtQty.ReadOnly = True
        txtDisc.Enabled = False
        txtDisc.ReadOnly = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call Bersih()

        LVDetailProduk.Items.Clear()

        txtQty.Focus()

        btnAdd.Enabled = True
        btnNew.Enabled = False
        btnEdit.Enabled = True
        btnProduk.Enabled = True

        txtQty.Enabled = True
        txtDisc.Enabled = True
        txtQty.ReadOnly = False
        txtDisc.ReadOnly = False

        lblPendapatan.Text = KontrolPendapatan.FCKdPendapatan
    End Sub

    Private Sub lblTambahJasa_Click(sender As Object, e As EventArgs) Handles lblTambahJasa.Click
        Me.Close()
        TambahTransaksiJasa.Show()
    End Sub
End Class