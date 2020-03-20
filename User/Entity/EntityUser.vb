Public Class EntityUser
    Private id As String
    Private nama As String
    Private hp As String
    Private username As String
    Private password As String
    Private status As String

    Public Property idUser() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property namaUser() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property hpUser() As String
        Get
            Return hp
        End Get
        Set(value As String)
            hp = value
        End Set
    End Property

    Public Property usernameUser As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property passwordUser As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property statusUser As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property
End Class
