Public Class EntityProduk
    Private id As String
    Private nama As String
    Private harga As String
    Private stock As String

    Public Property idProduk() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property namaProduk() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property hargaProduk As String
        Get
            Return harga
        End Get
        Set(value As String)
            harga = value
        End Set
    End Property

    Public Property stockProduk As String
        Get
            Return stock
        End Get
        Set(value As String)
            stock = value
        End Set
    End Property
End Class
