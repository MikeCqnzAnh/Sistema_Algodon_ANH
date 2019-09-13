Public Class VentaPacasContrato
    Inherits Tarjeta
    Public IdVenta As String
    Public IdContrato As Integer
    Public IdComprador As Integer
    Public IdProductor As Integer
    Public IdPlanta As Integer
    Public IdModalidadVenta As Integer
    Public FechaVenta As DateTime
    Public TotalPacas As Integer
    Public Observaciones As String
    Public CastigoMicros As Double
    Public CastigoLargoFibra As Double
    Public CastigoResistenciaFibra As Double
    Public InteresPesosMx As Double
    Public InteresDlls As Double
    Public PrecioQuintal As Double
    Public PrecioQuintalBorregos As Double
    Public SubTotal As Double
    Public CastigoDls As Double
    Public AnticipoDls As Double
    Public PacasInicio As Integer
    Public PacasFin As Integer
    Public PrecioDolar As Double
    Public FacturaVenta As String
    Public TotalDlls As Double
    Public TotalPesosMx As Double
    Public NoPacas As Integer
    Public InicioPaca As Integer
    Public FinPaca As Integer
    Public Clase As String
    Public IdEstatusVenta As Integer
    'Tablas de Castigos y modalidad compra
    Public TablaCastigoMicros As DataTable
    Public TablaCastigoLargoFibra As DataTable
    Public TablaCastigoResistenciaFibra As DataTable
    Public TablaModalidadCompra As DataTable
End Class
