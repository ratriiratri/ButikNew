Public Class EntityBiaya
    Private id As String
    Private nama As String

    Private pengeluaran As String
    Private disc As Double

    Public Property idBiaya() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property namaBiaya() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
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

    Public Property discBiaya() As Double
        Get
            Return disc
        End Get
        Set(value As Double)
            disc = value
        End Set
    End Property
End Class
