<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TambahTransaksiProduk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.LVDetailProduk = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblPendapatan = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNominal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.btnProduk = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 74)
        Me.Panel1.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Transaksi Produk"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(645, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Qty"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(648, 95)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(42, 23)
        Me.txtQty.TabIndex = 94
        '
        'LVDetailProduk
        '
        Me.LVDetailProduk.AutoArrange = False
        Me.LVDetailProduk.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.LVDetailProduk.FullRowSelect = True
        Me.LVDetailProduk.GridLines = True
        Me.LVDetailProduk.Location = New System.Drawing.Point(79, 135)
        Me.LVDetailProduk.Name = "LVDetailProduk"
        Me.LVDetailProduk.Size = New System.Drawing.Size(1000, 262)
        Me.LVDetailProduk.TabIndex = 92
        Me.LVDetailProduk.UseCompatibleStateImageBehavior = False
        Me.LVDetailProduk.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 97
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 405
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Qty"
        Me.ColumnHeader4.Width = 63
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Harga"
        Me.ColumnHeader3.Width = 137
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Disc"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sub Total"
        Me.ColumnHeader5.Width = 232
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(943, 23)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(74, 17)
        Me.lblTanggal.TabIndex = 90
        Me.lblTanggal.Text = "lblTanggal"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(19, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1154, 29)
        Me.Panel4.TabIndex = 64
        '
        'lblPendapatan
        '
        Me.lblPendapatan.AutoSize = True
        Me.lblPendapatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendapatan.Location = New System.Drawing.Point(171, 30)
        Me.lblPendapatan.Name = "lblPendapatan"
        Me.lblPendapatan.Size = New System.Drawing.Size(60, 17)
        Me.lblPendapatan.TabIndex = 89
        Me.lblPendapatan.Text = "             "
        '
        'txtHarga
        '
        Me.txtHarga.Enabled = False
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(696, 96)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(260, 23)
        Me.txtHarga.TabIndex = 85
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(79, 23)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(86, 31)
        Me.btnNew.TabIndex = 83
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(901, 464)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 31)
        Me.btnDelete.TabIndex = 81
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(717, 464)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 31)
        Me.btnSave.TabIndex = 80
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(809, 464)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 31)
        Me.btnEdit.TabIndex = 79
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(19, 576)
        Me.Panel2.TabIndex = 62
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblNominal
        '
        Me.lblNominal.AutoSize = True
        Me.lblNominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNominal.Location = New System.Drawing.Point(994, 416)
        Me.lblNominal.Name = "lblNominal"
        Me.lblNominal.Size = New System.Drawing.Size(23, 25)
        Me.lblNominal.TabIndex = 78
        Me.lblNominal.Text = "0"
        Me.lblNominal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(963, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 17)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Rp."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(903, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Nama Produk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "ID Produk"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(79, 96)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(97, 23)
        Me.txtId.TabIndex = 66
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1026, 92)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 31)
        Me.btnAdd.TabIndex = 58
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1173, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(19, 576)
        Me.Panel3.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(693, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Harga"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Controls.Add(Me.btnRefresh)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.txtDisc)
        Me.Panel5.Controls.Add(Me.btnProduk)
        Me.Panel5.Controls.Add(Me.txtNama)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.txtQty)
        Me.Panel5.Controls.Add(Me.LVDetailProduk)
        Me.Panel5.Controls.Add(Me.lblTanggal)
        Me.Panel5.Controls.Add(Me.lblPendapatan)
        Me.Panel5.Controls.Add(Me.txtHarga)
        Me.Panel5.Controls.Add(Me.btnNew)
        Me.Panel5.Controls.Add(Me.btnDelete)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Controls.Add(Me.btnEdit)
        Me.Panel5.Controls.Add(Me.lblNominal)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.txtId)
        Me.Panel5.Controls.Add(Me.btnAdd)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(19, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1154, 512)
        Me.Panel5.TabIndex = 65
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1005, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 17)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(959, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 17)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Disc"
        '
        'txtDisc
        '
        Me.txtDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.Location = New System.Drawing.Point(962, 95)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.ReadOnly = True
        Me.txtDisc.Size = New System.Drawing.Size(42, 23)
        Me.txtDisc.TabIndex = 98
        '
        'btnProduk
        '
        Me.btnProduk.Enabled = False
        Me.btnProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduk.Location = New System.Drawing.Point(179, 96)
        Me.btnProduk.Name = "btnProduk"
        Me.btnProduk.Size = New System.Drawing.Size(34, 23)
        Me.btnProduk.TabIndex = 97
        Me.btnProduk.Text = "..."
        Me.btnProduk.UseVisualStyleBackColor = True
        '
        'txtNama
        '
        Me.txtNama.Enabled = False
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(219, 95)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(423, 23)
        Me.txtNama.TabIndex = 96
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(993, 464)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 31)
        Me.btnRefresh.TabIndex = 101
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'TambahTransaksiProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 650)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TambahTransaksiProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents LVDetailProduk As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblNominal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnProduk As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDisc As TextBox
    Friend WithEvents btnRefresh As Button
End Class
