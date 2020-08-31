Public Class EntityDetailJurnal
    Private id As String
    Private jns As String
    Private no As Integer
    Private rf As String

    Public Property idJurnal() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property jnsNominal() As String
        Get
            Return jns
        End Get
        Set(value As String)
            jns = value
        End Set
    End Property

    Public Property nominal() As Integer
        Get
            Return no
        End Get
        Set(value As Integer)
            no = value
        End Set
    End Property

    Public Property ref() As String
        Get
            Return rf
        End Get
        Set(value As String)
            rf = value
        End Set
    End Property
End Class
