<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatTransaksiProduk
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblJasa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.lblProduk = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DGTransaksiProduk = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGTransaksiProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Controls.Add(Me.txtSearch)
        Me.Panel5.Controls.Add(Me.btnSearch)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(19, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1154, 69)
        Me.Panel5.TabIndex = 86
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(38, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(972, 23)
        Me.txtSearch.TabIndex = 56
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1016, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 31)
        Me.btnSearch.TabIndex = 55
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblJasa)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblBiaya)
        Me.Panel1.Controls.Add(Me.lblProduk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 74)
        Me.Panel1.TabIndex = 82
        '
        'lblJasa
        '
        Me.lblJasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJasa.AutoSize = True
        Me.lblJasa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblJasa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblJasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJasa.Location = New System.Drawing.Point(996, 54)
        Me.lblJasa.Name = "lblJasa"
        Me.lblJasa.Size = New System.Drawing.Size(78, 13)
        Me.lblJasa.TabIndex = 11
        Me.lblJasa.Text = "Transaksi Jasa"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(978, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "/"
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
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.Location = New System.Drawing.Point(1080, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "/"
        '
        'lblBiaya
        '
        Me.lblBiaya.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBiaya.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiaya.Location = New System.Drawing.Point(1098, 54)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(82, 13)
        Me.lblBiaya.TabIndex = 3
        Me.lblBiaya.Text = "Transaksi Biaya"
        '
        'lblProduk
        '
        Me.lblProduk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProduk.AutoSize = True
        Me.lblProduk.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduk.Location = New System.Drawing.Point(866, 54)
        Me.lblProduk.Name = "lblProduk"
        Me.lblProduk.Size = New System.Drawing.Size(106, 13)
        Me.lblProduk.TabIndex = 2
        Me.lblProduk.Text = "Transaksi Produk"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(19, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1154, 29)
        Me.Panel4.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1173, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(19, 576)
        Me.Panel3.TabIndex = 84
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1071, 568)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 31)
        Me.btnRefresh.TabIndex = 89
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'DGTransaksiProduk
        '
        Me.DGTransaksiProduk.AllowUserToOrderColumns = True
        Me.DGTransaksiProduk.AllowUserToResizeColumns = False
        Me.DGTransaksiProduk.AllowUserToResizeRows = False
        Me.DGTransaksiProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGTransaksiProduk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGTransaksiProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTransaksiProduk.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGTransaksiProduk.Location = New System.Drawing.Point(19, 193)
        Me.DGTransaksiProduk.Name = "DGTransaksiProduk"
        Me.DGTransaksiProduk.ReadOnly = True
        Me.DGTransaksiProduk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGTransaksiProduk.Size = New System.Drawing.Size(1154, 364)
        Me.DGTransaksiProduk.TabIndex = 88
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(19, 172)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1154, 21)
        Me.Panel6.TabIndex = 87
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(19, 576)
        Me.Panel2.TabIndex = 83
        '
        'LihatTransaksiProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 650)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DGTransaksiProduk)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LihatTransaksiProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LihatTransaksiProduk"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGTransaksiProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblJasa As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents lblProduk As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DGTransaksiProduk As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
End Class
