<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ButikDaurUlang.My.Resources.Resources.Logo_Butik_Daur_Ulang
        Me.PictureBox1.Location = New System.Drawing.Point(182, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Location = New System.Drawing.Point(61, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 212)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(73, 80)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(73, 41)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(87, 127)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(250, 35)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(121, 80)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(216, 24)
        Me.txtPassword.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(121, 41)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(216, 24)
        Me.txtUsername.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 388)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
