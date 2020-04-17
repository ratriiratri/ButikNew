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
        Me.SuspendLayout()
        '
        'PemilikUtama
        '
        Me.ClientSize = New System.Drawing.Size(897, 450)
        Me.Name = "PemilikUtama"
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
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnData As Button
    Friend WithEvents btnTransaksi As Button
End Class
