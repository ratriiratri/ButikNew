<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataJasa
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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.DGJasa = New System.Windows.Forms.DataGridView()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblLihat = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7.SuspendLayout()
        CType(Me.DGJasa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnRefresh)
        Me.Panel7.Controls.Add(Me.btnDelete)
        Me.Panel7.Controls.Add(Me.btnEdit)
        Me.Panel7.Controls.Add(Me.DGJasa)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(19, 300)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1154, 313)
        Me.Panel7.TabIndex = 62
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(781, 267)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 31)
        Me.btnRefresh.TabIndex = 34
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(689, 267)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 31)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(597, 267)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 31)
        Me.btnEdit.TabIndex = 31
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'DGJasa
        '
        Me.DGJasa.AllowUserToOrderColumns = True
        Me.DGJasa.AllowUserToResizeColumns = False
        Me.DGJasa.AllowUserToResizeRows = False
        Me.DGJasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGJasa.Location = New System.Drawing.Point(286, 27)
        Me.DGJasa.Name = "DGJasa"
        Me.DGJasa.ReadOnly = True
        Me.DGJasa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGJasa.Size = New System.Drawing.Size(581, 219)
        Me.DGJasa.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(570, 123)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(86, 31)
        Me.btnNew.TabIndex = 35
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Controls.Add(Me.btnNew)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.txtHarga)
        Me.Panel5.Controls.Add(Me.txtNama)
        Me.Panel5.Controls.Add(Me.txtId)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(19, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1154, 176)
        Me.Panel5.TabIndex = 60
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(662, 123)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 31)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(305, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(404, 95)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(156, 23)
        Me.txtHarga.TabIndex = 46
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(404, 59)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(344, 23)
        Me.txtNama.TabIndex = 40
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(404, 20)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(89, 23)
        Me.txtId.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(305, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Nama Jasa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblLihat)
        Me.Panel1.Controls.Add(Me.lblData)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 74)
        Me.Panel1.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.Location = New System.Drawing.Point(1125, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "/"
        '
        'lblLihat
        '
        Me.lblLihat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLihat.AutoSize = True
        Me.lblLihat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblLihat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLihat.Location = New System.Drawing.Point(1143, 55)
        Me.lblLihat.Name = "lblLihat"
        Me.lblLihat.Size = New System.Drawing.Size(30, 13)
        Me.lblLihat.TabIndex = 15
        Me.lblLihat.Text = "Lihat"
        '
        'lblData
        '
        Me.lblData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblData.AutoSize = True
        Me.lblData.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(1085, 55)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(34, 13)
        Me.lblData.TabIndex = 10
        Me.lblData.Text = "Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Jasa"
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
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1173, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(19, 576)
        Me.Panel3.TabIndex = 58
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(19, 279)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1154, 21)
        Me.Panel6.TabIndex = 61
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(19, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1154, 29)
        Me.Panel4.TabIndex = 59
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(19, 576)
        Me.Panel2.TabIndex = 57
        '
        'DataJasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 650)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DataJasa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DataJasaAdmin"
        Me.Panel7.ResumeLayout(False)
        CType(Me.DGJasa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents DGJasa As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblData As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents lblLihat As Label
End Class
