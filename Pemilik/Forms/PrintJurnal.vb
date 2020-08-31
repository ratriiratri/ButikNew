Public Class PrintJurnal

    Dim dragable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        Else
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub PrintJurnal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paramFields As New CrystalDecisions.Shared.ParameterFields()
        Dim paramField As New CrystalDecisions.Shared.ParameterField()
        Dim discretVal As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim paramField2 As New CrystalDecisions.Shared.ParameterField()
        Dim discretVal2 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        With LaporanJurnal
            paramField.ParameterFieldName = "debit"
            Dim str As String = .lblDebit.Text
            discretVal.Value = str
            paramField.CurrentValues.Add(discretVal)
            paramFields.Add(paramField)

            paramField2.ParameterFieldName = "kredit"
            Dim str2 As String = .lblKredit.Text
            discretVal2.Value = str2
            paramField2.CurrentValues.Add(discretVal2)
            paramFields.Add(paramField2)
        End With
        CrystalReportViewer1.ParameterFieldInfo = paramFields
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        dragable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If dragable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        dragable = False
    End Sub
End Class