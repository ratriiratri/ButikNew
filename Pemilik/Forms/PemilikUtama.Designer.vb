<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PemilikUtama
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
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picDuarUlang = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlOnPosition = New System.Windows.Forms.Panel()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.panelTop.SuspendLayout()
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.panelTop.Controls.Add(Me.btnMin)
        Me.panelTop.Controls.Add(Me.btnMax)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(784, 23)
        Me.panelTop.TabIndex = 9
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackgroundImage = Global.Pemilik.My.Resources.Resources.Min
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(705, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(27, 23)
        Me.btnMin.TabIndex = 2
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackgroundImage = Global.Pemilik.My.Resources.Resources.Max
        Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Location = New System.Drawing.Point(731, 0)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(27, 23)
        Me.btnMax.TabIndex = 1
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = Global.Pemilik.My.Resources.Resources.Ex
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(757, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'picDuarUlang
        '
        Me.picDuarUlang.BackColor = System.Drawing.Color.Transparent
        Me.picDuarUlang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDuarUlang.Image = Global.Pemilik.My.Resources.Resources.Logo_Butik_Daur_Ulang
        Me.picDuarUlang.Location = New System.Drawing.Point(3, 6)
        Me.picDuarUlang.Name = "picDuarUlang"
        Me.picDuarUlang.Size = New System.Drawing.Size(163, 68)
        Me.picDuarUlang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDuarUlang.TabIndex = 1
        Me.picDuarUlang.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Panel3.Controls.Add(Me.pnlOnPosition)
        Me.Panel3.Controls.Add(Me.picDuarUlang)
        Me.Panel3.Controls.Add(Me.btnLaporan)
        Me.Panel3.Controls.Add(Me.btnAdmin)
        Me.Panel3.Controls.Add(Me.btnData)
        Me.Panel3.Controls.Add(Me.btnLogOut)
        Me.Panel3.Controls.Add(Me.btnTransaksi)
        Me.Panel3.Controls.Add(Me.btnDashboard)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(169, 572)
        Me.Panel3.TabIndex = 11
        '
        'pnlOnPosition
        '
        Me.pnlOnPosition.BackColor = System.Drawing.Color.Black
        Me.pnlOnPosition.Location = New System.Drawing.Point(0, 95)
        Me.pnlOnPosition.Name = "pnlOnPosition"
        Me.pnlOnPosition.Size = New System.Drawing.Size(10, 45)
        Me.pnlOnPosition.TabIndex = 13
        '
        'btnLaporan
        '
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.Image = Global.Pemilik.My.Resources.Resources.iconfinder_87_notepad_report_card_result_presentation_24px
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(0, 299)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLaporan.Size = New System.Drawing.Size(169, 45)
        Me.btnLaporan.TabIndex = 11
        Me.btnLaporan.Text = "   Laporan"
        Me.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.Image = Global.Pemilik.My.Resources.Resources.iconfinder_plus_24px
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.Location = New System.Drawing.Point(0, 146)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnAdmin.Size = New System.Drawing.Size(169, 45)
        Me.btnAdmin.TabIndex = 10
        Me.btnAdmin.Text = "   Tambah Admin"
        Me.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.FlatAppearance.BorderSize = 0
        Me.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnData.Image = Global.Pemilik.My.Resources.Resources.iconfinder_database_24px
        Me.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnData.Location = New System.Drawing.Point(0, 197)
        Me.btnData.Name = "btnData"
        Me.btnData.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnData.Size = New System.Drawing.Size(169, 45)
        Me.btnData.TabIndex = 9
        Me.btnData.Text = "   Lihat Data"
        Me.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnData.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Image = Global.Pemilik.My.Resources.Resources.iconfinder_sign_out_24px
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
        'btnTransaksi
        '
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.Image = Global.Pemilik.My.Resources.Resources.iconfinder_money_bag_24px
        Me.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.Location = New System.Drawing.Point(0, 248)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnTransaksi.Size = New System.Drawing.Size(169, 45)
        Me.btnTransaksi.TabIndex = 2
        Me.btnTransaksi.Text = "   Lihat Transaksi"
        Me.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Image = Global.Pemilik.My.Resources.Resources.iconfinder_home_24px
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 95)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(169, 45)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PemilikUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 595)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "PemilikUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PemilikUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelTop.ResumeLayout(False)
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents picDuarUlang As PictureBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnData As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents pnlOnPosition As Panel
End Class
