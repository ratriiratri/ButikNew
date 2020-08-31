Public Class PrintTransaksiProduk
    Dim dragable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub PrintTransaksiProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paramFields As New CrystalDecisions.Shared.ParameterFields()
        Dim paramField As New CrystalDecisions.Shared.ParameterField()
        Dim discretVal As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim paramField2 As New CrystalDecisions.Shared.ParameterField()
        Dim discretVal2 As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim paramField3 As New CrystalDecisions.Shared.ParameterField()
        Dim discretVal3 As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim paramField4 As New CrystalDecisions.Shared.ParameterField()
        Dim discretVal4 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        With TambahTransaksiProduk
            paramField.ParameterFieldName = "idUser"
            Dim str As String = kodeLogin
            discretVal.Value = str
            paramField.CurrentValues.Add(discretVal)
            paramFields.Add(paramField)

            paramField2.ParameterFieldName = "subTotal"
            Dim str2 As String = .lblNominal.Text
            discretVal2.Value = str2
            paramField2.CurrentValues.Add(discretVal2)
            paramFields.Add(paramField2)

            paramField3.ParameterFieldName = "bayar"
            Dim str3 As String = .txtBayar.Text
            discretVal3.Value = str3
            paramField3.CurrentValues.Add(discretVal3)
            paramFields.Add(paramField3)

            paramField4.ParameterFieldName = "kembali"
            Dim str4 As String = .lblKembali.Text
            discretVal4.Value = str4
            paramField4.CurrentValues.Add(discretVal4)
            paramFields.Add(paramField4)
        End With
        CrystalReportViewer1.ParameterFieldInfo = paramFields
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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