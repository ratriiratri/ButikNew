<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminUtama
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picDuarUlang = New System.Windows.Forms.PictureBox()
        Me.btnLihat = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnPengeluaran = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnJasa = New System.Windows.Forms.Button()
        Me.btnBiaya = New System.Windows.Forms.Button()
        Me.btnProduk = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.pnlOnPosition = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Panel3.Controls.Add(Me.pnlOnPosition)
        Me.Panel3.Controls.Add(Me.picDuarUlang)
        Me.Panel3.Controls.Add(Me.btnLihat)
        Me.Panel3.Controls.Add(Me.btnLogOut)
        Me.Panel3.Controls.Add(Me.btnPengeluaran)
        Me.Panel3.Controls.Add(Me.btnUser)
        Me.Panel3.Controls.Add(Me.btnJasa)
        Me.Panel3.Controls.Add(Me.btnBiaya)
        Me.Panel3.Controls.Add(Me.btnProduk)
        Me.Panel3.Controls.Add(Me.btnDashboard)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(169, 572)
        Me.Panel3.TabIndex = 5
        '
        'picDuarUlang
        '
        Me.picDuarUlang.BackColor = System.Drawing.Color.Transparent
        Me.picDuarUlang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDuarUlang.Image = Global.ButikDaurUlang.My.Resources.Resources.Logo_Butik_Daur_Ulang
        Me.picDuarUlang.Location = New System.Drawing.Point(3, 6)
        Me.picDuarUlang.Name = "picDuarUlang"
        Me.picDuarUlang.Size = New System.Drawing.Size(163, 68)
        Me.picDuarUlang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDuarUlang.TabIndex = 1
        Me.picDuarUlang.TabStop = False
        '
        'btnLihat
        '
        Me.btnLihat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnLihat.FlatAppearance.BorderSize = 0
        Me.btnLihat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLihat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihat.Image = Global.ButikDaurUlang.My.Resources.Resources.iconfinder_16_agreement_paperDocument_note_report_24px
        Me.btnLihat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLihat.Location = New System.Drawing.Point(0, 401)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLihat.Size = New System.Drawing.Size(169, 45)
        Me.btnLihat.TabIndex = 9
        Me.btnLihat.Text = "   Lihat Transaksi"
        Me.btnLihat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLihat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLihat.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Image = Global.ButikDaurUlang.My.Resources.Resources.iconfinder_sign_out_24px
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 527)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(169, 45)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = "   Log Out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnPengeluaran
        '
        Me.btnPengeluaran.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnPengeluaran.FlatAppearance.BorderSize = 0
        Me.btnPengeluaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPengeluaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengeluaran.Image = Global.ButikDaurUlang.My.Resources.Resources.iconfinder_money_bag_24px
        Me.btnPengeluaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPengeluaran.Location = New System.Drawing.Point(0, 350)
        Me.btnPengeluaran.Name = "btnPengeluaran"
        Me.btnPengeluaran.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnPengeluaran.Size = New System.Drawing.Size(169, 45)
        Me.btnPengeluaran.TabIndex = 7
        Me.btnPengeluaran.Text = "   Pengeluaran"
        Me.btnPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPengeluaran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPengeluaran.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Image = Global.ButikDaurUlang.My.Resources.Resources.iconfinder_user_24px
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(0, 146)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnUser.Size = New System.Drawing.Size(169, 45)
        Me.btnUser.TabIndex = 1
        Me.btnUser.Text = "   User"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnJasa
        '
        Me.btnJasa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnJasa.FlatAppearance.BorderSize = 0
        Me.btnJasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJasa.Image = Global.ButikDaurUlang.My.Resources.Resources.iconfinder_people_24px
        Me.btnJasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJasa.Location = New System.Drawing.Point(0, 248)
        Me.btnJasa.Name = "btnJasa"
        Me.btnJasa.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnJasa.Size = New System.Drawing.Size(169, 45)
        Me.btnJasa.TabIndex = 5
        Me.btnJasa.Text = "   Jasa"
        Me.btnJasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJasa.UseVisualStyleBackColor = True
        '
        'btnBiaya
        '
        Me.btnBiaya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnBiaya.FlatAppearance.BorderSize = 0
        Me.btnBiaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBiaya.Image = Global.ButikDaurUlang.My.Resources.Resources.iconfinder_aiga_cashier_134157__1_
        Me.btnBiaya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBiaya.Location = New System.Drawing.Point(0, 299)
        Me.btnBiaya.Name = "btnBiaya"
        Me.btnBiaya.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnBiaya.Size = New System.Drawing.Size(169, 45)
        Me.btnBiaya.TabIndex = 4
        Me.btnBiaya.Text = "   Biaya"
        Me.btnBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBiaya.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBiaya.UseVisualStyleBackColor = True
        '
        'btnProduk
        '
        Me.btnProduk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnProduk.FlatAppearance.BorderSize = 0
        Me.btnProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduk.Image = Global.ButikDaurUlang.My.Resources.Resources.iconfinder_recycle_24px
        Me.btnProduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduk.Location = New System.Drawing.Point(0, 197)
        Me.btnProduk.Name = "btnProduk"
        Me.btnProduk.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnProduk.Size = New System.Drawing.Size(169, 45)
        Me.btnProduk.TabIndex = 2
        Me.btnProduk.Text = "   Produk"
        Me.btnProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProduk.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDashboard.Image = Global.ButikDaurUlang.My.Resources.Resources.iconfinder_home_24px1
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 95)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(169, 45)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMin)
        Me.Panel1.Controls.Add(Me.btnMax)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 23)
        Me.Panel1.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.ButikDaurUlang.My.Resources.Resources.Ex
        Me.btnClose.Location = New System.Drawing.Point(757, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Image = Global.ButikDaurUlang.My.Resources.Resources.Min
        Me.btnMin.Location = New System.Drawing.Point(705, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(27, 23)
        Me.btnMin.TabIndex = 2
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Image = Global.ButikDaurUlang.My.Resources.Resources.Max
        Me.btnMax.Location = New System.Drawing.Point(731, 0)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(27, 23)
        Me.btnMax.TabIndex = 1
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'pnlOnPosition
        '
        Me.pnlOnPosition.BackColor = System.Drawing.Color.Black
        Me.pnlOnPosition.Location = New System.Drawing.Point(0, 95)
        Me.pnlOnPosition.Name = "pnlOnPosition"
        Me.pnlOnPosition.Size = New System.Drawing.Size(10, 45)
        Me.pnlOnPosition.TabIndex = 7
        '
        'AdminUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 595)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "AdminUtama"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AdminUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnPengeluaran As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents btnBiaya As Button
    Friend WithEvents btnProduk As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnJasa As Button
    Friend WithEvents picDuarUlang As PictureBox
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLihat As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlOnPosition As Panel
End Class
