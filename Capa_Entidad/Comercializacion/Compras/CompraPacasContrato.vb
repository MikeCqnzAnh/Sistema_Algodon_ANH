Public Class CompraPacasContrato
    Inherits Tarjeta
    Public IdCompra As Integer
    Public IdContrato As Integer
    Public IdProductor As Integer
    Public IdPlanta As Integer
    Public IdModalidadCompra As Integer
    Public FechaCompra As DateTime
    Public TotalPacas As Integer
    Public Observaciones As String
    Public CastigoMicros As Double
    Public CastigoLargoFibra As Double
    Public CastigoResistenciaFibra As Double
    Public TotalPesosMx As Double
    Public TotalDlls As Double
    Public InteresPesosMx As Double
    Public InteresDlls As Double
    Public PrecioQuintal As Double
    Public PrecioQuintalBorregos As Double
    Public PrecioDolar As Double
    Public Descuento As Double
    Public Total As Double
    Public IdEstatusCompra As Boolean
    Public PacasInicio As Integer
    Public PacasFin As Integer
    Public FacturaVenta As String
    Public InicioPaca As Integer
    Public FinPaca As Integer
    Public Clase As String
    'Tablas de Castigos y modalidad compra
    Public TablaCastigoMicros As DataTable
    Public TablaCastigoLargoFibra As DataTable
    Public TablaCastigoResistenciaFibra As DataTable
    Public TablaModalidadCompra As DataTable
End Class
