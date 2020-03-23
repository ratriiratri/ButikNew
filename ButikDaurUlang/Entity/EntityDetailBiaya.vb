Public Class EntityDetailBiaya
    Private biaya As String
    Private pengeluaran As String
    Private jumlah As Integer
    Private harga As Integer

    Public Property idBiaya() As String
        Get
            Return biaya
        End Get
        Set(value As String)
            biaya = value
        End Set
    End Property

    Public Property idPengeluaran() As String
        Get
            Return pengeluaran
        End Get
        Set(value As String)
            pengeluaran = value
        End Set
    End Property

    Public Property jumlahBiaya() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property hargaBiaya() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property
End Class
