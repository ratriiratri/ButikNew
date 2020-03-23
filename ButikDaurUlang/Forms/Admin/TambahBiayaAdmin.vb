Public Class TambahBiayaAdmin

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

        btnAdd.Enabled = False
        btnEdit.Enabled = False

        lblUser.Text = kodeLogin

        lblTanggal.Text = Format(Now, "yyyy/MM/dd hh:mm")
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

        namaHari = New String() {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"}

        lblTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & " yyyy/MM/dd hh:mm:ss")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'deklarasi array string
        Dim strItem(4) As String

        strItem(0) = txtId.Text
        strItem(1) = cbBiaya.Text
        strItem(2) = txtQty.Text
        strItem(3) = txtJumlah.Text
        strItem(4) = txtJumlah.Text * txtQty.Text

        'tambahkan item add (ListViewDetailBiaya) dengan isi array
        LVDetailBiaya.Items.Add(New ListViewItem(strItem))

        Call HitungTotal()
        Call Bersih()
        Call isiCbBiaya()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        LVDetailBiaya.SelectedItems(0).Remove()
        Call HitungTotal()
    End Sub

    Private Sub btnCariBarang_Click(sender As Object, e As EventArgs)
        LihatBiayaAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim listDetail As New List(Of EntityDetailBiaya)()

        If LVDetailBiaya.Items.Count = 0 Then
            MsgBox("Masukan Biaya terlebih dulu")
            Exit Sub
        End If

        With EntitasPengeluaran
            .idPengeluaran = lblPengeluaran.Text
            .jmlPengeluaran = lblNominal.Text
            .ketPengeluaran = ""
            .tglPengeluaran = Format(Now, "yyyy/MM/dd")
            .idUser = lblUser.Text
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
        Next (i)
        KontrolPengeluaran.SimpanData(EntitasPengeluaran, listDetail)
        MsgBox("Data Berhasil Disimpan")

        Call Bersih()

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
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call Bersih()
        Call isiCbBiaya()


        LVDetailBiaya.Items.Clear()

        txtQty.Focus()
        cbBiaya.Enabled = True
        txtQty.Enabled = True
        txtQty.ReadOnly = False
        txtJumlah.Enabled = True
        txtJumlah.ReadOnly = False

        btnAdd.Enabled = True
        btnNew.Enabled = False
        btnEdit.Enabled = True

        lblPengeluaran.Text = KontrolPengeluaran.FCKdPengeluaran
    End Sub

    Private Sub cbBiaya_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBiaya.SelectedIndexChanged

        CMD = New OleDb.OleDbCommand("select * from Biaya where namaBiaya='" & cbBiaya.Text & "'", OpenConnection)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtId.Text = DTR.Item("idBiaya")
            txtQty.Focus()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'belum
    End Sub

    Private Sub lblPengeluaran_Click(sender As Object, e As EventArgs) Handles lblPengeluaran.Click

    End Sub
End Class