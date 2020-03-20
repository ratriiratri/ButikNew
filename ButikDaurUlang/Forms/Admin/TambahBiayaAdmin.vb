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
        txtJumlah.Text = ""
    End Sub

    Sub HitungTotal()
        Dim total As Integer

        total = 0

        For i = 0 To LVDetailBiaya.Items.Count - 1
            total = total + (LVDetailBiaya.Items(i).SubItems(2).Text)
        Next

        lblNominal.Text = total
    End Sub

    Private Sub TambahBiayaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = AdminUtama

        Call Bersih()

        lblUser.Text = kodeLogin
        lblPengeluaran.Text = KontrolPengeluaran.FCKdPengeluaran

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
        Dim strItem(2) As String

        strItem(0) = txtId.Text
        strItem(1) = cbBiaya.Text
        strItem(2) = txtJumlah.Text

        'tambahkan item add (ListViewDetailBiaya) dengan isi array
        LVDetailBiaya.Items.Add(New ListViewItem(strItem))

        Call HitungTotal()
        Call Bersih()
        Call isiCbBiaya()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        LVDetailBiaya.SelectedItems(0).Remove()

        'pengurangannya masih salah 

        Dim total As Integer

        total = 0
        For i = 0 To LVDetailBiaya.Items.Count - 1
            total = (LVDetailBiaya.Items(i).SubItems(2).Text) - total
        Next

        lblNominal.Text = total
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
            With LVDetailBiaya.Items(i)
                EntitasBiaya.idBiaya = .SubItems(0).Text
                EntitasDetailBiaya.idPengeluaran = lblPengeluaran.Text
                EntitasDetailBiaya.jumlahBiaya = .SubItems(2).Text
            End With
            listDetail.Add(EntitasDetailBiaya)
        Next
        KontrolPengeluaran.SimpanData(EntitasPengeluaran, listDetail)
        MsgBox("Data Berhasil Disimpan")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call isiCbBiaya()

        cbBiaya.Enabled = True
        txtJumlah.Enabled = True
        txtJumlah.ReadOnly = False
        btnAdd.Enabled = True
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
End Class