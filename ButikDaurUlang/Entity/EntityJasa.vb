Public Class EntityJasa
    Private id As String
    Private nama As String
    Private harga As Integer

    Private pendapatan As String
    Private jumlah As Integer
    Private disc As Double

    Public Property idJasa() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property namaJasa() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property hargaJasa() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
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

    Public Property jumlahJasa() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property discJasa As Double
        Get
            Return disc
        End Get
        Set(value As Double)
            disc = value
        End Set
    End Property
End Class
