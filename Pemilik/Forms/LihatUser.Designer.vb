<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LihatUser
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
        Me.DGUser = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJasa = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.lblProduk = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkAdmin = New System.Windows.Forms.CheckBox()
        Me.checkUser = New System.Windows.Forms.CheckBox()
        Me.cbPencarian = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.DGUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGUser
        '
        Me.DGUser.AllowUserToOrderColumns = True
        Me.DGUser.AllowUserToResizeColumns = False
        Me.DGUser.AllowUserToResizeRows = False
        Me.DGUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGUser.Location = New System.Drawing.Point(19, 224)
        Me.DGUser.Name = "DGUser"
        Me.DGUser.ReadOnly = True
        Me.DGUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGUser.Size = New System.Drawing.Size(1154, 364)
        Me.DGUser.TabIndex = 72
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblJasa)
        Me.Panel1.Controls.Add(Me.lblUser)
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
        Me.Panel1.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(1007, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "/"
        '
        'lblJasa
        '
        Me.lblJasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJasa.AutoSize = True
        Me.lblJasa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblJasa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblJasa.Location = New System.Drawing.Point(1090, 55)
        Me.lblJasa.Name = "lblJasa"
        Me.lblJasa.Size = New System.Drawing.Size(29, 13)
        Me.lblJasa.TabIndex = 11
        Me.lblJasa.Text = "Jasa"
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(968, 55)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(33, 13)
        Me.lblUser.TabIndex = 10
        Me.lblUser.Text = "User"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(1072, 55)
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
        Me.Label1.Size = New System.Drawing.Size(146, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Data User"
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
        Me.Label13.Location = New System.Drawing.Point(1125, 55)
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
        Me.lblBiaya.Location = New System.Drawing.Point(1143, 55)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(33, 13)
        Me.lblBiaya.TabIndex = 3
        Me.lblBiaya.Text = "Biaya"
        '
        'lblProduk
        '
        Me.lblProduk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProduk.AutoSize = True
        Me.lblProduk.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProduk.Location = New System.Drawing.Point(1025, 55)
        Me.lblProduk.Name = "lblProduk"
        Me.lblProduk.Size = New System.Drawing.Size(41, 13)
        Me.lblProduk.TabIndex = 2
        Me.lblProduk.Text = "Produk"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1081, 594)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 31)
        Me.btnRefresh.TabIndex = 73
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(19, 203)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1154, 21)
        Me.Panel6.TabIndex = 71
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(19, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1154, 29)
        Me.Panel4.TabIndex = 69
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1173, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(19, 576)
        Me.Panel3.TabIndex = 68
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(19, 576)
        Me.Panel2.TabIndex = 67
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.checkAdmin)
        Me.GroupBox1.Controls.Add(Me.checkUser)
        Me.GroupBox1.Controls.Add(Me.cbPencarian)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1154, 100)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian"
        '
        'checkAdmin
        '
        Me.checkAdmin.AutoSize = True
        Me.checkAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAdmin.Location = New System.Drawing.Point(703, 31)
        Me.checkAdmin.Name = "checkAdmin"
        Me.checkAdmin.Size = New System.Drawing.Size(66, 21)
        Me.checkAdmin.TabIndex = 73
        Me.checkAdmin.Text = "Admin"
        Me.checkAdmin.UseVisualStyleBackColor = True
        '
        'checkUser
        '
        Me.checkUser.AutoSize = True
        Me.checkUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkUser.Location = New System.Drawing.Point(638, 31)
        Me.checkUser.Name = "checkUser"
        Me.checkUser.Size = New System.Drawing.Size(57, 21)
        Me.checkUser.TabIndex = 72
        Me.checkUser.Text = "User"
        Me.checkUser.UseVisualStyleBackColor = True
        '
        'cbPencarian
        '
        Me.cbPencarian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPencarian.FormattingEnabled = True
        Me.cbPencarian.Location = New System.Drawing.Point(131, 29)
        Me.cbPencarian.Name = "cbPencarian"
        Me.cbPencarian.Size = New System.Drawing.Size(463, 24)
        Me.cbPencarian.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 18)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 18)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Kata Kunci "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Berdasarkan "
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
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(131, 65)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(901, 23)
        Me.txtSearch.TabIndex = 60
        '
        'LihatUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 650)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DGUser)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LihatUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LihatUser"
        CType(Me.DGUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGUser As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblJasa As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblProduk As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cbPencarian As ComboBox
    Friend WithEvents checkAdmin As CheckBox
    Friend WithEvents checkUser As CheckBox
End Class
