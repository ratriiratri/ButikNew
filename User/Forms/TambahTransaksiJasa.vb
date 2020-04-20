Public Class TambahTransaksiJasa

    Private Sub isiCbJasa()
        DTGrid = KontrolJasa.TampilData.ToTable

        Dim bdJasa As New BindingSource

        bdJasa.DataSource = DTGrid

        With cbJasa
            .DataSource = DTGrid
            .DisplayMember = "namaJasa"
            .ValueMember = "idJasa"
        End With
    End Sub

    Private Sub Bersih() 'clear isi 
        txtId.Text = ""
        txtQty.Text = ""
        txtHarga.Text = ""
        txtDisc.Text = ""
    End Sub

    Sub HitungTotal()
        Dim total As Integer

        total = 0

        For i = 0 To LVDetailJasa.Items.Count - 1
            total = total + (LVDetailJasa.Items(i).SubItems(5).Text)
        Next

        lblNominal.Text = total
    End Sub

    Private Sub TambahTransaksiJasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = UserUtama

        Call Bersih()

        btnNew.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False

        lblUser.Text = kodeLogin

        lblTanggal.Text = Format(Now, "yyyy/MM/dd hh:mm")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'deklarasi array string
        Dim strItem(5) As String

        If txtQty.Text = "" Then
            txtQty.Text = 1
        ElseIf txtDisc.Text = "" Then
            txtDisc.Text = 0
        End If

        strItem(0) = txtId.Text
        strItem(1) = cbJasa.Text
        strItem(2) = txtQty.Text
        strItem(3) = txtHarga.Text
        strItem(4) = txtDisc.Text
        strItem(5) = txtQty.Text * txtHarga.Text - ((txtDisc.Text / 100) * (txtQty.Text * txtHarga.Text))

        'tambahkan item add (ListViewDetailBiaya) dengan isi array
        LVDetailJasa.Items.Add(New ListViewItem(strItem))

        Call HitungTotal()
        Call Bersih()
        Call isiCbJasa()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        LVDetailJasa.SelectedItems(0).Remove()
        Call HitungTotal()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim listDetail As New List(Of EntityDetailJasa)()

        If LVDetailJasa.Items.Count = 0 Then
            MsgBox("Masukan Jasa terlebih dulu")
            Exit Sub
        End If

        With EntitasPendapatan
            .idPendapatan = lblPendapatan.Text
            .jmlPendapatan = lblNominal.Text
            .ketPendapatan = "Jasa"
            .tglPendapatan = Format(Now, "yyyy/MM/dd")
            .idUser = lblUser.Text
        End With

        For i = 0 To LVDetailJasa.Items.Count - 1
            EntitasDetailJasa = New EntityDetailJasa
            With LVDetailJasa.Items(i)
                EntitasDetailJasa.idJasa = .SubItems(0).Text
                EntitasDetailJasa.idPendapatan = lblPendapatan.Text
                EntitasDetailJasa.jumlahJasa = .SubItems(2).Text
                EntitasDetailJasa.discJasa = .SubItems(4).Text
            End With
            listDetail.Add(EntitasDetailJasa)
        Next (i)

        KontrolPendapatan.SimpanData2(EntitasPendapatan, listDetail)
        MsgBox("Data Berhasil Disimpan")

        Call Bersih()

        lblNominal.Text = 0
        LVDetailJasa.Items.Clear()

        cbJasa.Enabled = False
        txtQty.Enabled = False
        txtQty.ReadOnly = True
        txtDisc.Enabled = False
        txtDisc.ReadOnly = True

        lblPendapatan.Text = ""

        btnNew.Enabled = True
        btnEdit.Enabled = False
        btnAdd.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False

        cbJasa.Enabled = False
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call Bersih()
        Call isiCbJasa()

        LVDetailJasa.Items.Clear()

        txtQty.Focus()

        cbJasa.Enabled = True
        txtQty.Enabled = True
        txtQty.ReadOnly = False
        txtDisc.Enabled = True
        txtDisc.ReadOnly = False

        btnNew.Enabled = False
        btnEdit.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = True

        cbJasa.Enabled = True

        lblPendapatan.Text = KontrolPendapatan.FCKdPendapatan
    End Sub

    Private Sub cbJasa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJasa.SelectedIndexChanged
        CMD = New OleDb.OleDbCommand("select * from Jasa where namaJasa='" & cbJasa.Text & "'", OpenConnection)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtId.Text = DTR.Item("idJasa")
            txtHarga.Text = DTR.Item("hargaJasa")
            txtQty.Focus()
        End If
    End Sub
End Class