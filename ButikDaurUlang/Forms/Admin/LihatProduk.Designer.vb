<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatProduk
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblLihat = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DGProduk = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Controls.Add(Me.txtSearch)
        Me.Panel5.Controls.Add(Me.btnSearch)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(19, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1154, 69)
        Me.Panel5.TabIndex = 62
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(38, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(972, 23)
        Me.txtSearch.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblLihat)
        Me.Panel1.Controls.Add(Me.lblData)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 74)
        Me.Panel1.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Produk"
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
        'lblLihat
        '
        Me.lblLihat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLihat.AutoSize = True
        Me.lblLihat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblLihat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLihat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLihat.Location = New System.Drawing.Point(1143, 55)
        Me.lblLihat.Name = "lblLihat"
        Me.lblLihat.Size = New System.Drawing.Size(35, 13)
        Me.lblLihat.TabIndex = 3
        Me.lblLihat.Text = "Lihat"
        '
        'lblData
        '
        Me.lblData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblData.AutoSize = True
        Me.lblData.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblData.Location = New System.Drawing.Point(1089, 55)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = "Data"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1071, 568)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 31)
        Me.btnRefresh.TabIndex = 65
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'DGProduk
        '
        Me.DGProduk.AllowUserToOrderColumns = True
        Me.DGProduk.AllowUserToResizeColumns = False
        Me.DGProduk.AllowUserToResizeRows = False
        Me.DGProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGProduk.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGProduk.Location = New System.Drawing.Point(19, 193)
        Me.DGProduk.Name = "DGProduk"
        Me.DGProduk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGProduk.Size = New System.Drawing.Size(1154, 364)
        Me.DGProduk.TabIndex = 64
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(19, 172)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1154, 21)
        Me.Panel6.TabIndex = 63
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(19, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1154, 29)
        Me.Panel4.TabIndex = 61
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(19, 576)
        Me.Panel2.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1173, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(19, 576)
        Me.Panel3.TabIndex = 60
        '
        'LihatProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 650)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DGProduk)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LihatProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LihatProdukAdmin"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblLihat As Label
    Friend WithEvents lblData As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DGProduk As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
