<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserUtama
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picDuarUlang = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLihat = New System.Windows.Forms.Button()
        Me.btnJasa = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnProduk = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlOnPosition = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMin)
        Me.Panel1.Controls.Add(Me.btnMax)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 23)
        Me.Panel1.TabIndex = 6
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackgroundImage = Global.User.My.Resources.Resources.Min
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
        Me.btnMax.BackgroundImage = Global.User.My.Resources.Resources.Max
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
        Me.btnClose.BackgroundImage = Global.User.My.Resources.Resources.Ex
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
        Me.picDuarUlang.Image = Global.User.My.Resources.Resources.Logo_Butik_Daur_Ulang
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
        Me.Panel3.Controls.Add(Me.btnLihat)
        Me.Panel3.Controls.Add(Me.btnJasa)
        Me.Panel3.Controls.Add(Me.btnLogOut)
        Me.Panel3.Controls.Add(Me.btnProduk)
        Me.Panel3.Controls.Add(Me.btnDashboard)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(169, 572)
        Me.Panel3.TabIndex = 8
        '
        'btnLihat
        '
        Me.btnLihat.BackColor = System.Drawing.Color.Transparent
        Me.btnLihat.FlatAppearance.BorderSize = 0
        Me.btnLihat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLihat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihat.Image = Global.User.My.Resources.Resources.iconfinder_recycle_24px
        Me.btnLihat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLihat.Location = New System.Drawing.Point(0, 248)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnLihat.Size = New System.Drawing.Size(169, 45)
        Me.btnLihat.TabIndex = 10
        Me.btnLihat.Text = " Lihat Produk"
        Me.btnLihat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLihat.UseVisualStyleBackColor = False
        '
        'btnJasa
        '
        Me.btnJasa.BackColor = System.Drawing.Color.Transparent
        Me.btnJasa.FlatAppearance.BorderSize = 0
        Me.btnJasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJasa.Image = Global.User.My.Resources.Resources.iconfinder_money_bag_24px
        Me.btnJasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJasa.Location = New System.Drawing.Point(0, 197)
        Me.btnJasa.Name = "btnJasa"
        Me.btnJasa.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnJasa.Size = New System.Drawing.Size(169, 45)
        Me.btnJasa.TabIndex = 9
        Me.btnJasa.Text = " Transaksi Jasa"
        Me.btnJasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJasa.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Image = Global.User.My.Resources.Resources.iconfinder_sign_out_24px
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 527)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(169, 45)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = " Log Out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnProduk
        '
        Me.btnProduk.BackColor = System.Drawing.Color.Transparent
        Me.btnProduk.FlatAppearance.BorderSize = 0
        Me.btnProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduk.Image = Global.User.My.Resources.Resources.iconfinder_money_bag_24px
        Me.btnProduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduk.Location = New System.Drawing.Point(0, 146)
        Me.btnProduk.Name = "btnProduk"
        Me.btnProduk.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnProduk.Size = New System.Drawing.Size(169, 45)
        Me.btnProduk.TabIndex = 2
        Me.btnProduk.Text = " Transaksi Produk"
        Me.btnProduk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProduk.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Image = Global.User.My.Resources.Resources.iconfinder_home_24px
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 95)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(169, 45)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = " Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlOnPosition
        '
        Me.pnlOnPosition.BackColor = System.Drawing.Color.Black
        Me.pnlOnPosition.Location = New System.Drawing.Point(0, 95)
        Me.pnlOnPosition.Name = "pnlOnPosition"
        Me.pnlOnPosition.Size = New System.Drawing.Size(10, 45)
        Me.pnlOnPosition.TabIndex = 10
        '
        'UserUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 595)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "UserUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents picDuarUlang As PictureBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnProduk As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnJasa As Button
    Friend WithEvents btnLihat As Button
    Friend WithEvents pnlOnPosition As Panel
End Class
