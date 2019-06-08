Public Class vcliente
    Dim idcliente As Integer
    Dim nombre, apellido, dui, celular As String


    Public Property gidcliente
        Get
            Return idcliente

        End Get
        Set(ByVal value)
            idcliente = value
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
    Public Property gdui
        Get
            Return dui

        End Get
        Set(ByVal value)
            dui = value
        End Set
    End Property
    Public Property gcelular
        Get
            Return celular

        End Get
        Set(ByVal value)
            celular = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal apellido As String, ByVal dui As String, ByVal celular As String)
        gidcliente = idcliente
        gnombre = nombre
        gapellido = apellido
        gdui = dui
        gcelular = celular

    End Sub

End Class
