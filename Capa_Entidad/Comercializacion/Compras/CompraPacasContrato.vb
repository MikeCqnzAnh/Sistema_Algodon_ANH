Public Class CompraPacasContrato
    Inherits Tarjeta
    Public IdCompraContrato As Integer
    Public IdContrato As Integer
    Public IdProductor As Integer
    Public IdPlanta As Integer
    Public IdModalidadCompra As Integer
    Public PacasInicio As Integer
    Public PacasFin As Integer
    Public PrecioQuintal As Double
    Public PrecioDolar As Double
    Public FacturaVenta As String
    Public NoPacas As Integer
    Public InicioPaca As Integer
    Public FinPaca As Integer
    Public Clase As String
    'Tablas de Castigos y modalidad compra
    Public TablaCastigoMicros As DataTable
    Public TablaCastigoLargoFibra As DataTable
    Public TablaCastigoResistenciaFibra As DataTable
    Public TablaModalidadCompra As DataTable
End Class
