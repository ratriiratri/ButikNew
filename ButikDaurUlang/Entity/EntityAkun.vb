Public Class EntityAkun
    Private id As String
    Private nama As String
    Private jns As String
    Private nominalSaldo As Integer

    Public Property idAkun() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property namaAkun() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property jnsSaldo() As String
        Get
            Return jns
        End Get
        Set(value As String)
            jns = value
        End Set
    End Property

    Public Property saldo() As Integer
        Get
            Return nominalSaldo
        End Get
        Set(value As Integer)
            nominalSaldo = value
        End Set
    End Property
End Class
