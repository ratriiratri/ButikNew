<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatTransaksiBiaya
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPencarian = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dateAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dateAwal = New System.Windows.Forms.DateTimePicker()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGDetailBiaya = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkBox = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTransaksiBiaya = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPengeluaran = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPendapatan = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTransaksiProduk = New System.Windows.Forms.Label()
        Me.lblTransaksiJasa = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDetailBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Kata Kunci"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Berdasarkan"
        '
        'cbPencarian
        '
        Me.cbPencarian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPencarian.FormattingEnabled = True
        Me.cbPencarian.Location = New System.Drawing.Point(131, 29)
        Me.cbPencarian.Name = "cbPencarian"
        Me.cbPencarian.Size = New System.Drawing.Size(463, 24)
        Me.cbPencarian.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(863, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 17)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "s.d"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1038, 61)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 31)
        Me.btnSearch.TabIndex = 59
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(893, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Sampai Tanggal : "
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(131, 65)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(901, 23)
        Me.txtSearch.TabIndex = 60
        '
        'dateAkhir
        '
        Me.dateAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateAkhir.Location = New System.Drawing.Point(896, 31)
        Me.dateAkhir.Name = "dateAkhir"
        Me.dateAkhir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dateAkhir.Size = New System.Drawing.Size(228, 21)
        Me.dateAkhir.TabIndex = 63
        '
        'dateAwal
        '
        Me.dateAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateAwal.Location = New System.Drawing.Point(633, 31)
        Me.dateAwal.Name = "dateAwal"
        Me.dateAwal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dateAwal.Size = New System.Drawing.Size(224, 21)
        Me.dateAwal.TabIndex = 61
        Me.dateAwal.Value = New Date(2020, 4, 23, 19, 36, 59, 0)
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1082, 594)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 31)
        Me.btnRefresh.TabIndex = 90
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(626, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Dari Tanggal :"
        '
        'DGDetailBiaya
        '
        Me.DGDetailBiaya.AllowUserToOrderColumns = True
        Me.DGDetailBiaya.AllowUserToResizeColumns = False
        Me.DGDetailBiaya.AllowUserToResizeRows = False
        Me.DGDetailBiaya.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGDetailBiaya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDetailBiaya.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGDetailBiaya.Location = New System.Drawing.Point(19, 224)
        Me.DGDetailBiaya.Name = "DGDetailBiaya"
        Me.DGDetailBiaya.ReadOnly = True
        Me.DGDetailBiaya.Size = New System.Drawing.Size(1154, 364)
        Me.DGDetailBiaya.TabIndex = 92
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(19, 203)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1154, 21)
        Me.Panel6.TabIndex = 91
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.checkBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbPencarian)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.dateAkhir)
        Me.GroupBox1.Controls.Add(Me.dateAwal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1154, 100)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian"
        '
        'checkBox
        '
        Me.checkBox.AutoSize = True
        Me.checkBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox.Location = New System.Drawing.Point(612, 35)
        Me.checkBox.Name = "checkBox"
        Me.checkBox.Size = New System.Drawing.Size(15, 14)
        Me.checkBox.TabIndex = 67
        Me.checkBox.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(19, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1154, 29)
        Me.Panel4.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Transaksi Biaya"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1173, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(19, 576)
        Me.Panel3.TabIndex = 88
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(19, 576)
        Me.Panel2.TabIndex = 87
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblTransaksiBiaya)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblPengeluaran)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblPendapatan)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblTransaksiProduk)
        Me.Panel1.Controls.Add(Me.lblTransaksiJasa)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 74)
        Me.Panel1.TabIndex = 86
        '
        'lblTransaksiBiaya
        '
        Me.lblTransaksiBiaya.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTransaksiBiaya.AutoSize = True
        Me.lblTransaksiBiaya.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTransaksiBiaya.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTransaksiBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksiBiaya.Location = New System.Drawing.Point(896, 57)
        Me.lblTransaksiBiaya.Name = "lblTransaksiBiaya"
        Me.lblTransaksiBiaya.Size = New System.Drawing.Size(97, 13)
        Me.lblTransaksiBiaya.TabIndex = 33
        Me.lblTransaksiBiaya.Text = "Transaksi Biaya"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(878, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "/"
        '
        'lblPengeluaran
        '
        Me.lblPengeluaran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPengeluaran.AutoSize = True
        Me.lblPengeluaran.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPengeluaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPengeluaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPengeluaran.Location = New System.Drawing.Point(1106, 57)
        Me.lblPengeluaran.Name = "lblPengeluaran"
        Me.lblPengeluaran.Size = New System.Drawing.Size(67, 13)
        Me.lblPengeluaran.TabIndex = 30
        Me.lblPengeluaran.Text = "Pengeluaran"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(1088, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "/"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(999, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "/"
        '
        'lblPendapatan
        '
        Me.lblPendapatan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendapatan.AutoSize = True
        Me.lblPendapatan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPendapatan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPendapatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendapatan.Location = New System.Drawing.Point(1017, 57)
        Me.lblPendapatan.Name = "lblPendapatan"
        Me.lblPendapatan.Size = New System.Drawing.Size(65, 13)
        Me.lblPendapatan.TabIndex = 28
        Me.lblPendapatan.Text = "Pendapatan"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.Location = New System.Drawing.Point(776, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "/"
        '
        'lblTransaksiProduk
        '
        Me.lblTransaksiProduk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTransaksiProduk.AutoSize = True
        Me.lblTransaksiProduk.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTransaksiProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTransaksiProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksiProduk.Location = New System.Drawing.Point(680, 57)
        Me.lblTransaksiProduk.Name = "lblTransaksiProduk"
        Me.lblTransaksiProduk.Size = New System.Drawing.Size(90, 13)
        Me.lblTransaksiProduk.TabIndex = 26
        Me.lblTransaksiProduk.Text = "Transaksi Produk"
        '
        'lblTransaksiJasa
        '
        Me.lblTransaksiJasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTransaksiJasa.AutoSize = True
        Me.lblTransaksiJasa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTransaksiJasa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTransaksiJasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksiJasa.Location = New System.Drawing.Point(794, 57)
        Me.lblTransaksiJasa.Name = "lblTransaksiJasa"
        Me.lblTransaksiJasa.Size = New System.Drawing.Size(78, 13)
        Me.lblTransaksiJasa.TabIndex = 25
        Me.lblTransaksiJasa.Text = "Transaksi Jasa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(113, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 17)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(113, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 17)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = ":"
        '
        'LihatTransaksiBiaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 650)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DGDetailBiaya)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LihatTransaksiBiaya"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LihatTransaksiBiaya"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGDetailBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbPencarian As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dateAkhir As DateTimePicker
    Friend WithEvents dateAwal As DateTimePicker
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DGDetailBiaya As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTransaksiBiaya As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPengeluaran As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTransaksiProduk As Label
    Friend WithEvents lblTransaksiJasa As Label
    Friend WithEvents checkBox As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
End Class
