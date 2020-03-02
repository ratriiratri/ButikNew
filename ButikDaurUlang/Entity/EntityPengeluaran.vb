Public Class EntityPengeluaran
    Private id As String
    Private jumlah As Integer
    Private ket As String
    Private tanggal As DateTime
    Private user As String

    Public Property idPengeluaran() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property jmlPengeluaran() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property ketPengeluaran() As String
        Get
            Return ket
        End Get
        Set(value As String)
            ket = value
        End Set
    End Property

    Public Property tglPengeluaran() As DateTime
        Get
            Return tanggal
        End Get
        Set(value As DateTime)
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
