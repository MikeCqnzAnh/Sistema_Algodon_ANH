Imports Capa_Operacion
Public Class OrdenTrabajo
    Inherits Tarjeta
    Public IdOrdenTrabajo As Integer
    Public IdBoleta As Integer
    Public IdPlanta As Integer
    Public IdProductor As Integer
    Public RangoInicio As Integer
    Public RangoFin As Integer
    Public IdLote As Integer
    Public IdVariedadAlgodon As Integer
    Public IdColonia As Integer
    Public Predio As String
    Public NoModulos As Integer
    Public IdEstatus As Integer
    Public PesoBruto As Decimal
    Public PesoTara As Decimal
    Public PesoNeto As Decimal
    Public NoTransporte As Integer
    Public FlagCancelada As Boolean
    Public FlagRevisada As Boolean
    Public FechaEntrada As DateTime
    Public FechaSalida As DateTime
End Class

