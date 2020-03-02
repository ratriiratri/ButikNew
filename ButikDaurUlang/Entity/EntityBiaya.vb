Public Class EntityBiaya
    Private id As String
    Private nama As String

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
End Class
