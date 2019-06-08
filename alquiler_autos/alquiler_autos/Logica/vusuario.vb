Public Class vusuario
    Dim idusuario As Integer
    Dim nombre, apellido, login, password, acceso As String

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value
        End Set
    End Property
    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property
    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(ByVal value)
            apellido = value
        End Set
    End Property
    Public Property glogin
        Get
            Return login
        End Get
        Set(ByVal value)
            login = value
        End Set
    End Property
    Public Property gpassword
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property
    Public Property gacceso
        Get
            Return acceso
        End Get
        Set(ByVal value)
            acceso = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal nombre As String, ByVal apellido As String, ByVal login As String, ByVal password As String, ByVal acceso As String)
        gidusuario = idusuario
        gnombre = nombre
        gapellido = apellido
        glogin = login
        gpassword = password
        gacceso = acceso
    End Sub
End Class
