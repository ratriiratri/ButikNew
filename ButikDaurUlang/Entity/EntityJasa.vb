Public Class EntityJasa
    Private id As String
    Private nama As String
    Private harga As String

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

    Public Property hargaJasa() As String
        Get
            Return harga
        End Get
        Set(value As String)
            harga = value
        End Set
    End Property
End Class
