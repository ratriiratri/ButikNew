Public Class EntityPendapatan
    Private id As String
    Private jumlah As Integer
    Private ket As String
    Private tanggal As Date
    Private user As String

    Public Property idPendapatan() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property jmlPendapatan() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property ketPendapatan() As String
        Get
            Return ket
        End Get
        Set(value As String)
            ket = value
        End Set
    End Property

    Public Property tglPendapatan() As Date
        Get
            Return tanggal
        End Get
        Set(value As Date)
            tanggal = value
        End Set
    End Property

    Public Property idUser() As String
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property
End Class
