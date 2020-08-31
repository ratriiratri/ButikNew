Public Class EntityDetailJasa
    Private jasa As String
    Private pendapatan As String
    Private jumlah As Integer
    Private disc As Integer

    Public Property idJasa() As String
        Get
            Return jasa
        End Get
        Set(value As String)
            jasa = value
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

    Public Property discJasa() As Integer
        Get
            Return disc
        End Get
        Set(value As Integer)
            disc = value
        End Set
    End Property
End Class
