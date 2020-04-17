<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataBiaya
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
        Me.DGBiaya = New System.Windows.Forms.DataGridView()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7.SuspendLayout()
        CType(Me.DGBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel7.Controls.Add(Me.DGBiaya)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(19, 269)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1154, 333)
        Me.Panel7.TabIndex = 62
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(803, 266)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 31)
        Me.btnRefresh.TabIndex = 34
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(711, 266)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 31)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(619, 266)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 31)
        Me.btnEdit.TabIndex = 31
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'DGBiaya
        '
        Me.DGBiaya.AllowUserToOrderColumns = True
        Me.DGBiaya.AllowUserToResizeColumns = False
        Me.DGBiaya.AllowUserToResizeRows = False
        Me.DGBiaya.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGBiaya.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGBiaya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBiaya.Location = New System.Drawing.Point(308, 23)
        Me.DGBiaya.Name = "DGBiaya"
        Me.DGBiaya.ReadOnly = True
        Me.DGBiaya.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGBiaya.Size = New System.Drawing.Size(581, 219)
        Me.DGBiaya.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(570, 98)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(86, 31)
        Me.btnNew.TabIndex = 35
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Controls.Add(Me.btnNew)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Controls.Add(Me.txtNama)
        Me.Panel5.Controls.Add(Me.txtId)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(19, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1154, 145)
        Me.Panel5.TabIndex = 60
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(662, 98)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 31)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
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
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Nama Biaya"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 74)
        Me.Panel1.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Biaya"
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
        Me.Panel6.Location = New System.Drawing.Point(19, 248)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1154, 21)
        Me.Panel6.TabIndex = 61
        '
        'DataBiaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 650)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DataBiaya"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DataBiayaAdmin"
        Me.Panel7.ResumeLayout(False)
        CType(Me.DGBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents DGBiaya As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NamaBiaya As DataGridViewTextBoxColumn
End Class
