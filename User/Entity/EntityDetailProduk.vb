Public Class EntityDetailProduk
    Private produk As String
    Private pendapatan As String
    Private jumlah As Integer
    Private disc As Integer

    Public Property idProduk() As String
        Get
            Return produk
        End Get
        Set(value As String)
            produk = value
        End Set
    End Property

    Public Property idPendapatan() As String
        Get
            Return pendapatan
        End Get
        Set(value As String)
            pendapatan = value
        End Set
    End Property

    Public Property jumlahProduk() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property discProduk As Integer
        Get
            Return disc
        End Get
        Set(value As Integer)
            disc = value
        End Set
    End Property
End Class
