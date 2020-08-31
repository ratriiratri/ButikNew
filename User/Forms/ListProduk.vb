Public Class ListProduk

    Dim dragable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Dim baris As Integer

    Dim copyID As String
    Dim copyNama As String
    Dim copyHarga As String

    Private Sub RefreshGrid()
        DTGrid = KontrolProduk.TampilData.ToTable
        DGProduk.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGProduk.CurrentCell = DGProduk.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGProduk.Rows(br)
                copyID = .Cells(0).Value.ToString
                copyNama = .Cells(1).Value.ToString
                copyHarga = .Cells(2).Value.ToString
            End With
        End If
    End Sub

    Private Sub tampilCari(kunci As String)
        If rbID.Checked = True Then
            DTGrid = KontrolProduk.CariDataID(kunci).ToTable
        ElseIf rbNama.Checked = True Then
            DTGrid = KontrolProduk.CariDataNama(kunci).ToTable
        Else
            MsgBox("Data Tidak Ditemukan!")
            RefreshGrid()
        End If

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGProduk.DataSource = DTGrid
            DGProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGProduk.CurrentCell = DGProduk.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub ListProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbNama.Checked = True
        rbID.Checked = False

        Call RefreshGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call RefreshGrid()
        Else
            Call tampilCari(txtSearch.Text)
            txtSearch.Focus()
        End If
    End Sub


    Private Sub DGProduk_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProduk.CellDoubleClick
        baris = DGProduk.CurrentCell.RowIndex

        With TambahTransaksiProduk
            .txtId.Text = DGProduk.Item(0, baris).Value.ToString
            .txtNama.Text = DGProduk.Item(1, baris).Value.ToString
            .txtHarga.Text = DGProduk.Item(2, baris).Value.ToString
            Me.Close()
            .txtQty.Focus()
        End With
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If (e.KeyChar = Chr(13)) Then
            If txtSearch.Text = "" Then
                Call RefreshGrid()
            Else
                Call tampilCari(txtSearch.Text)
                txtSearch.Focus()
            End If
        End If
    End Sub
End Class