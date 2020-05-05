Public Class EntityData
    Private id As String
    Private nama As String
    Private tanggal As Date
    Private jumlah As Integer

    Public Property idData() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property namaData() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property tanggalData() As Date
        Get
            Return tanggal
        End Get
        Set(value As Date)
            tanggal = value
        End Set
    End Property

    Public Property jumlahData() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property
End Class
