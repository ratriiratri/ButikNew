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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picDuarUlang = New System.Windows.Forms.PictureBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.panelTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
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
        Me.btnMin.Location = New System.Drawing.Point(684, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(26, 26)
        Me.btnMin.TabIndex = 2
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.Location = New System.Drawing.Point(714, 0)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(26, 26)
        Me.btnMax.TabIndex = 1
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(746, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 26)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picDuarUlang)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 89)
        Me.Panel2.TabIndex = 10
        '
        'picDuarUlang
        '
        Me.picDuarUlang.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.picDuarUlang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDuarUlang.Location = New System.Drawing.Point(12, 14)
        Me.picDuarUlang.Name = "picDuarUlang"
        Me.picDuarUlang.Size = New System.Drawing.Size(141, 61)
        Me.picDuarUlang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDuarUlang.TabIndex = 1
        Me.picDuarUlang.TabStop = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 439)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(169, 52)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.Location = New System.Drawing.Point(0, 153)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(169, 52)
        Me.btnTransaksi.TabIndex = 2
        Me.btnTransaksi.Text = "Lihat Transaksi"
        Me.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(169, 52)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnLaporan)
        Me.Panel3.Controls.Add(Me.btnAdmin)
        Me.Panel3.Controls.Add(Me.btnData)
        Me.Panel3.Controls.Add(Me.btnLogOut)
        Me.Panel3.Controls.Add(Me.btnTransaksi)
        Me.Panel3.Controls.Add(Me.btnDashboard)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 112)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(169, 483)
        Me.Panel3.TabIndex = 11
        '
        'btnLaporan
        '
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(0, 204)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(169, 52)
        Me.btnLaporan.TabIndex = 11
        Me.btnLaporan.Text = "Laporan Laba Rugi"
        Me.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.Location = New System.Drawing.Point(0, 51)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(169, 52)
        Me.btnAdmin.TabIndex = 10
        Me.btnAdmin.Text = "Tambah Admin"
        Me.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnData.Location = New System.Drawing.Point(0, 102)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(169, 52)
        Me.btnData.TabIndex = 9
        Me.btnData.Text = "Lihat Data"
        Me.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnData.UseVisualStyleBackColor = True
        '
        'PemilikUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 595)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "PemilikUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PemilikUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelTop.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picDuarUlang As PictureBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnData As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnLaporan As Button
End Class
