<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatPendapatan
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
        Me.DGPendapatan = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLihat = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPencarian = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGPendapatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGPendapatan
        '
        Me.DGPendapatan.AllowUserToOrderColumns = True
        Me.DGPendapatan.AllowUserToResizeColumns = False
        Me.DGPendapatan.AllowUserToResizeRows = False
        Me.DGPendapatan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGPendapatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPendapatan.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGPendapatan.Location = New System.Drawing.Point(19, 217)
        Me.DGPendapatan.Name = "DGPendapatan"
        Me.DGPendapatan.ReadOnly = True
        Me.DGPendapatan.Size = New System.Drawing.Size(1154, 364)
        Me.DGPendapatan.TabIndex = 72
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.DateTimePicker2)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.DateTimePicker1)
        Me.Panel5.Controls.Add(Me.txtSearch)
        Me.Panel5.Controls.Add(Me.btnSearch)
        Me.Panel5.Controls.Add(Me.cbPencarian)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(19, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1154, 93)
        Me.Panel5.TabIndex = 70
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblLihat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 74)
        Me.Panel1.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pendapatan"
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
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1081, 607)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 31)
        Me.btnRefresh.TabIndex = 73
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(19, 196)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Pencarian Berdasarkan : "
        '
        'cbPencarian
        '
        Me.cbPencarian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPencarian.FormattingEnabled = True
        Me.cbPencarian.Location = New System.Drawing.Point(192, 17)
        Me.cbPencarian.Name = "cbPencarian"
        Me.cbPencarian.Size = New System.Drawing.Size(332, 24)
        Me.cbPencarian.TabIndex = 58
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(37, 53)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(988, 23)
        Me.txtSearch.TabIndex = 60
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1031, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 31)
        Me.btnSearch.TabIndex = 59
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(540, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker1.Size = New System.Drawing.Size(163, 21)
        Me.DateTimePicker1.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(537, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Dari Tanggal :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(706, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Sampai Tanggal : "
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(709, 20)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker2.Size = New System.Drawing.Size(163, 21)
        Me.DateTimePicker2.TabIndex = 63
        '
        'LihatPendapatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 650)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DGPendapatan)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LihatPendapatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LihatPendapatan"
        CType(Me.DGPendapatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGPendapatan As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLihat As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbPencarian As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
