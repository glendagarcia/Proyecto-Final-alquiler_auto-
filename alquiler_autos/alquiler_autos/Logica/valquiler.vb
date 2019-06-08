Public Class valquiler
    Dim idalquiler As Integer
    Dim idcliente, idflota, idsucursal As Integer
    Dim fsalida, fentrada As Date

    Public Property gidalquiler
        Get
            Return idalquiler
        End Get
        Set(ByVal value)
            idalquiler = value
        End Set
    End Property
    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property

    Public Property gidflota
        Get
            Return idflota
        End Get
        Set(ByVal value)
            idflota = value
        End Set
    End Property
    Public Property gidsucursal
        Get
            Return idsucursal
        End Get
        Set(ByVal value)
            idsucursal = value
        End Set
    End Property
    Public Property gsalida
        Get
            Return fsalida
        End Get
        Set(ByVal value)
            fsalida = value
        End Set
    End Property
    Public Property gentrada
        Get
            Return fentrada
        End Get
        Set(ByVal value)
            fentrada = value
        End Set
    End Property

    Public Sub New(ByVal idalquiler As Integer, ByVal idcliente As Integer, ByVal idflota As Integer, ByVal idsucursal As Integer, ByVal fsalida As Date, ByVal fentrada As Date)
        gidalquiler = idalquiler
        gidcliente = idcliente
        gidflota = idflota
        gidsucursal = idsucursal
        gsalida = fsalida
        gentrada = fentrada
    End Sub



End Class
