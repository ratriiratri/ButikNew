Public Class EntityJurnal
    Private id As String
    Private tgl As Date
    Private no As String
    Private ket As String

    Public Property idJurnal() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property tglJurnal() As Date
        Get
            Return tgl
        End Get
        Set(value As Date)
            tgl = value
        End Set
    End Property

    Public Property noBukti() As String
        Get
            Return no
        End Get
        Set(value As String)
            no = value
        End Set
    End Property

    Public Property ketJurnal() As String
        Get
            Return ket
        End Get
        Set(value As String)
            ket = value
        End Set
    End Property
End Class
