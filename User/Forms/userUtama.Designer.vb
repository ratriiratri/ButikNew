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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picGirl = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.picDuarUlang = New System.Windows.Forms.PictureBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnProduk = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnJasa = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picGirl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(249, Byte), Integer))
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
        Me.Panel2.Controls.Add(Me.picGirl)
        Me.Panel2.Controls.Add(Me.lblUser)
        Me.Panel2.Controls.Add(Me.picDuarUlang)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 89)
        Me.Panel2.TabIndex = 7
        '
        'picGirl
        '
        Me.picGirl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picGirl.Location = New System.Drawing.Point(607, 32)
        Me.picGirl.Name = "picGirl"
        Me.picGirl.Size = New System.Drawing.Size(32, 32)
        Me.picGirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGirl.TabIndex = 3
        Me.picGirl.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUser.Location = New System.Drawing.Point(645, 36)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUser.Size = New System.Drawing.Size(95, 25)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Hi, User!"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'btnProduk
        '
        Me.btnProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduk.Location = New System.Drawing.Point(0, 63)
        Me.btnProduk.Name = "btnProduk"
        Me.btnProduk.Size = New System.Drawing.Size(169, 52)
        Me.btnProduk.TabIndex = 2
        Me.btnProduk.Text = "Transaksi Produk"
        Me.btnProduk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProduk.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 12)
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
        Me.Panel3.Controls.Add(Me.btnJasa)
        Me.Panel3.Controls.Add(Me.btnLogOut)
        Me.Panel3.Controls.Add(Me.btnProduk)
        Me.Panel3.Controls.Add(Me.btnDashboard)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 112)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(169, 483)
        Me.Panel3.TabIndex = 8
        '
        'btnJasa
        '
        Me.btnJasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJasa.Location = New System.Drawing.Point(0, 114)
        Me.btnJasa.Name = "btnJasa"
        Me.btnJasa.Size = New System.Drawing.Size(169, 52)
        Me.btnJasa.TabIndex = 9
        Me.btnJasa.Text = "Transaksi Jasa"
        Me.btnJasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJasa.UseVisualStyleBackColor = True
        '
        'UserUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 595)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "UserUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picGirl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDuarUlang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picGirl As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents picDuarUlang As PictureBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnProduk As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnJasa As Button
End Class
