Public Class TambahPengeluaran

    Private Sub isiCbBiaya()
        DTGrid = KontrolBiaya.TampilData.ToTable

        Dim bdBiaya As New BindingSource

        bdBiaya.DataSource = DTGrid

        With cbBiaya
            .DataSource = DTGrid
            .DisplayMember = "namaBiaya"
            .ValueMember = "idBiaya"
        End With
    End Sub

    Private Sub Bersih() 'clear isi 
        txtId.Text = ""
        txtQty.Text = ""
        txtJumlah.Text = ""

        cbBiaya.SelectedIndex = -1
    End Sub

    Sub HitungTotal()
        Dim total As Integer

        total = 0

        For i = 0 To LVDetailBiaya.Items.Count - 1
            total = total + (LVDetailBiaya.Items(i).SubItems(4).Text)
        Next

        lblNominal.Text = total
    End Sub

    Private Sub TambahBiayaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call Bersih()

        btnNew.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim hari As String()
        Dim bulan As String()

        hari = New String() {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"}
        bulan = New String() {"", "J\a\n\u\a\r\i", "F\e\b\r\u\a\r\i", "M\a\r\e\t", "A\p\r\i\l", "M\e\i", "J\u\n\i", "J\u\l\i", "A\g\u\s\t\u\s", "S\e\p\t\e\m\b\e\r", "O\k\t\o\b\\r\e", "N\o\v\e\m\b\e\r", "D\e\s\e\m\b\e\r"}

        lblTanggal.Text = hari(Now.DayOfWeek) & ", " & Format(Now, "dd " & bulan(Now.Month) & " yyyy   hh:mm")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'deklarasi array string
        Dim strItem(4) As String

        If txtJumlah.Text = "" Then
            MsgBox("Masukan Nominal Biaya Terlebih Dahulu!", MsgBoxStyle.Information, "Info")
        ElseIf txtQty.Text = "" Then
            txtQty.Text = 1
        End If

        strItem(0) = txtId.Text
        strItem(1) = cbBiaya.Text
        strItem(2) = txtQty.Text
        strItem(3) = txtJumlah.Text
        strItem(4) = txtJumlah.Text * txtQty.Text

        'tambahkan item add (ListViewDetailBiaya) dengan isi array
        LVDetailBiaya.Items.Add(New ListViewItem(strItem))

        Call HitungTotal()
        Call Bersih()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        LVDetailBiaya.SelectedItems(0).Remove()
        Call HitungTotal()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim listDetail As New List(Of EntityDetailBiaya)()
        Dim listDetail1 As New List(Of EntityData)()

        If LVDetailBiaya.Items.Count = 0 Then
            MsgBox("Masukan Biaya terlebih dulu")
            Exit Sub
        End If

        With EntitasPengeluaran
            .idPengeluaran = lblPengeluaran.Text
            .jmlPengeluaran = lblNominal.Text
            .ketPengeluaran = "Biaya"
            .tglPengeluaran = Format(Now, "yyyy/MM/dd")
            .idUser = kodeLogin
        End With

        For i = 0 To LVDetailBiaya.Items.Count - 1
            EntitasDetailBiaya = New EntityDetailBiaya
            With LVDetailBiaya.Items(i)
                EntitasDetailBiaya.idBiaya = .SubItems(0).Text
                EntitasDetailBiaya.idPengeluaran = lblPengeluaran.Text
                EntitasDetailBiaya.jumlahBiaya = .SubItems(2).Text
                EntitasDetailBiaya.hargaBiaya = .SubItems(3).Text
            End With
            listDetail.Add(EntitasDetailBiaya)

            EntitasData = New EntityData
            With LVDetailBiaya.Items(i)
                EntitasData.idData = .SubItems(0).Text
                EntitasData.namaData = .SubItems(1).Text
                EntitasData.tanggalData = Format(Now, "yyyy/MM/dd")
                EntitasData.jumlahData = .SubItems(4).Text
            End With
            listDetail1.Add(EntitasData)
        Next (i)
        KontrolPengeluaran.SimpanData(EntitasPengeluaran, listDetail)
        KontrolPengeluaran.SimpanData2(listDetail1)
        MsgBox("Data Berhasil Disimpan")

        Call Bersih()

        lblNominal.Text = 0
        LVDetailBiaya.Items.Clear()

        cbBiaya.Enabled = False
        txtQty.Enabled = False
        txtQty.ReadOnly = True
        txtJumlah.Enabled = False
        txtJumlah.ReadOnly = True

        lblPengeluaran.Text = ""

        btnNew.Enabled = True
        btnEdit.Enabled = False
        btnAdd.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call isiCbBiaya()
        Call Bersih()

        LVDetailBiaya.Items.Clear()

        cbBiaya.Enabled = True
        txtQty.Enabled = True
        txtQty.ReadOnly = False
        txtJumlah.Enabled = True
        txtJumlah.ReadOnly = False

        btnNew.Enabled = False
        btnEdit.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = True

        lblPengeluaran.Text = KontrolPengeluaran.FCKdPengeluaran
    End Sub

    Private Sub cbBiaya_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBiaya.SelectedIndexChanged
        CMD = New OleDb.OleDbCommand("select * from Biaya where namaBiaya='" & cbBiaya.Text & "'", OpenConnection)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtId.Text = DTR.Item("idBiaya")
            txtJumlah.Focus()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Bersih()

        lblNominal.Text = 0
        LVDetailBiaya.Items.Clear()

        cbBiaya.Enabled = False
        txtQty.Enabled = False
        txtQty.ReadOnly = True
        txtJumlah.Enabled = False
        txtJumlah.ReadOnly = True

        lblPengeluaran.Text = ""

        btnNew.Enabled = True
        btnEdit.Enabled = False
        btnAdd.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
    End Sub
End Class