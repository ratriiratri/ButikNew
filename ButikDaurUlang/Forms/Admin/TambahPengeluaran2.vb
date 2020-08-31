Public Class TambahPengeluaran2
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
        txtJns.Text = ""

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

    Private Sub TambahPengeluaran2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call Bersih()

        btnNew.Enabled = True
        btnAdd.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim hari As String()
        Dim bulan As String()

        hari = New String() {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"}
        bulan = New String() {"", "J\a\n\u\a\r\i", "F\e\b\r\u\a\r\i", "M\a\r\e\t", "A\p\r\i\l", "M\e\i", "J\u\n\i", "J\u\l\i", "A\g\u\s\t\u\s", "S\e\p\t\e\m\b\e\r", "O\k\t\o\b\e\r", "N\o\v\e\m\b\e\r", "D\e\s\e\m\b\e\r"}

        lblTanggal.Text = hari(Now.DayOfWeek) & ", " & Format(Now, "dd " & bulan(Now.Month) & " yyyy   hh:mm")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strItem(7) As String

        If txtJumlah.Text = "" Then
            MsgBox("Masukan Nominal Biaya Terlebih Dahulu!", MsgBoxStyle.Information, "Info")
        ElseIf txtQty.Text = "" Then
            txtQty.Text = 1
        End If

        strItem(0) = txtId.Text
        strItem(1) = Strings.Right(txtId.Text, 4)
        strItem(2) = cbBiaya.Text
        strItem(3) = txtQty.Text
        strItem(4) = txtJumlah.Text

        If txtJns.Text = "D" Then
            strItem(5) = txtJumlah.Text * txtQty.Text
        Else
            strItem(6) = txtJumlah.Text * txtQty.Text
        End If

        'tambahkan item add (ListViewDetailBiaya) dengan isi array
        LVDetailBiaya.Items.Add(New ListViewItem(strItem))

        Call HitungTotal()
        Call Bersih()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim listDetail As New List(Of EntityDetailBiaya)()
        Dim listDetail2 As New List(Of EntityDetailJurnal)()

        If LVDetailBiaya.Items.Count = 0 Then
            MsgBox("Masukan Biaya terlebih dulu", MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        With EntitasPengeluaran
            .idPengeluaran = lblPengeluaran.Text
            .jmlPengeluaran = lblNominal.Text
            .ketPengeluaran = "Biaya"
            .tglPengeluaran = Format(Now, "yyyy/MM/dd")
            .idUser = kodeLogin
        End With

        With EntitasJurnal
            .tglJurnal = Format(Now, "yyyy/MM/dd")
            .noBukti = lblPengeluaran.Text
            .ketJurnal = "Dikeluarkan Pengeluaran"
        End With

        With EntitasDetailJurnal2
            .nominal = lblNominal.Text
        End With

        For i = 0 To LVDetailBiaya.Items.Count - 1
            EntitasDetailBiaya = New EntityDetailBiaya
            With LVDetailBiaya.Items(i)
                EntitasDetailBiaya.idBiaya = .SubItems(0).Text
                EntitasDetailBiaya.idPengeluaran = lblPengeluaran.Text
                EntitasDetailBiaya.jumlahBiaya = .SubItems(3).Text
                EntitasDetailBiaya.hargaBiaya = .SubItems(4).Text
            End With
            listDetail.Add(EntitasDetailBiaya)

            EntitasDetailJurnal = New EntityDetailJurnal
            With LVDetailBiaya.Items(i)
                EntitasDetailJurnal.jnsNominal = "D"
                EntitasDetailJurnal.nominal = .SubItems(5).Text
                EntitasDetailJurnal.ref = .SubItems(1).Text
            End With
            listDetail2.Add(EntitasDetailJurnal)
        Next (i)
        KontrolPengeluaran.SimpanData(EntitasPengeluaran, listDetail)
        KontrolJurnal.SimpanData(EntitasJurnal, EntitasDetailJurnal2, listDetail2)
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Info")

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
            txtJns.Text = DTR.Item("jnsSaldo")
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
        btnAdd.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        LVDetailBiaya.SelectedItems(0).Remove()
        Call HitungTotal()
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

        If (e.KeyChar = Chr(13)) Then
            Dim strItem(7) As String

            If txtJumlah.Text = "" Then
                MsgBox("Masukan Nominal Biaya Terlebih Dahulu!", MsgBoxStyle.Information, "Info")
            Else
                strItem(0) = txtId.Text
                strItem(1) = Strings.Right(txtId.Text, 4)
                strItem(2) = cbBiaya.Text
                strItem(3) = txtQty.Text
                strItem(4) = txtJumlah.Text

                If txtJns.Text = "D" Then
                    strItem(5) = txtJumlah.Text * txtQty.Text
                Else
                    strItem(6) = txtJumlah.Text * txtQty.Text
                End If

                'tambahkan item add (ListViewDetailBiaya) dengan isi array
                LVDetailBiaya.Items.Add(New ListViewItem(strItem))

                Call HitungTotal()
                Call Bersih()
            End If
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

        If (e.KeyChar = Chr(13)) Then
            Dim strItem(7) As String

            If txtJumlah.Text = "" Then
                MsgBox("Masukan Nominal Biaya Terlebih Dahulu!", MsgBoxStyle.Information, "Info")
            Else
                txtQty.Text = 1
                strItem(0) = txtId.Text
                strItem(1) = Strings.Right(txtId.Text, 4)
                strItem(2) = cbBiaya.Text
                strItem(3) = txtQty.Text
                strItem(4) = txtJumlah.Text

                If txtJns.Text = "D" Then
                    strItem(5) = txtJumlah.Text * txtQty.Text
                Else
                    strItem(6) = txtJumlah.Text * txtQty.Text
                End If

                'tambahkan item add (ListViewDetailBiaya) dengan isi array
                LVDetailBiaya.Items.Add(New ListViewItem(strItem))

                Call HitungTotal()
                Call Bersih()
            End If
        End If
    End Sub

    Private Sub LVDetailBiaya_DoubleClick(sender As Object, e As EventArgs) Handles LVDetailBiaya.DoubleClick
        txtId.Text = LVDetailBiaya.SelectedItems(0).SubItems(0).Text
        txtJns.Text = LVDetailBiaya.SelectedItems(0).SubItems(1).Text
        cbBiaya.Text = LVDetailBiaya.SelectedItems(0).SubItems(2).Text
        txtJumlah.Text = LVDetailBiaya.SelectedItems(0).SubItems(4).Text
        txtQty.Text = LVDetailBiaya.SelectedItems(0).SubItems(3).Text
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) 
        LVDetailBiaya.SelectedItems(0).SubItems(0).Text = txtId.Text
        LVDetailBiaya.SelectedItems(0).SubItems(1).Text = txtJns.Text
        LVDetailBiaya.SelectedItems(0).SubItems(2).Text = cbBiaya.Text
        LVDetailBiaya.SelectedItems(0).SubItems(3).Text = txtQty.Text
        LVDetailBiaya.SelectedItems(0).SubItems(4).Text = txtJumlah.Text

        Call HitungTotal()
    End Sub
End Class