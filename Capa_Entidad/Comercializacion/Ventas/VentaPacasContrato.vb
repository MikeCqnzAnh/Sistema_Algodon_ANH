﻿Imports Capa_Operacion
Public Class VentaPacasContrato
    Inherits Tarjeta
    Public IdVenta As String
    Public IdContrato As Integer
    Public IdComprador As Integer
    Public IdProductor As Integer
    Public IdLiquidacion As Integer
    Public IdPlanta As Integer
    Public IdModalidadVenta As Integer
    Public FechaVenta As DateTime
    Public TotalPacas As Integer
    Public Observaciones As String
    Public CastigoMicros As Decimal
    Public CastigoLargoFibra As Decimal
    Public CastigoResistenciaFibra As Decimal
    Public CastigoUI As Decimal
    Public CastigoBarkLevel1 As Decimal
    Public CastigoBarkLevel2 As Decimal
    Public CastigoPrepLevel1 As Decimal
    Public CastigoPrepLevel2 As Decimal
    Public CastigoOtherLevel1 As Decimal
    Public CastigoOtherLevel2 As Decimal
    Public CastigoPlasticLevel1 As Decimal
    Public CastigoPlasticLevel2 As Decimal
    Public IdUnidadPeso As Integer
    Public ValorConversion As Decimal
    Public Unidad As Integer
    Public InteresPesosMx As Decimal
    Public InteresDlls As Decimal
    Public PrecioQuintal As Decimal
    Public PrecioQuintalBorregos As Decimal
    Public SubTotal As Decimal
    Public CastigoDls As Decimal
    Public AnticipoDls As Decimal
    Public PacasInicio As Long
    Public PacasFin As Long
    Public Baleid As Long
    Public PrecioDolar As Decimal
    Public PrecioClase As Decimal
    Public TipoCambio As Decimal
    Public PrecioMxn As Decimal
    Public Kilos As Decimal
    Public Quintales As Decimal
    Public FacturaVenta As String
    Public TotalDlls As Decimal
    Public TotalPesosMx As Decimal
    Public NoPacas As Integer
    Public InicioPaca As Long
    Public FinPaca As Long
    Public Clase As String
    Public IdPaquete As Integer
    Public IdEstatusVenta As Integer
    Public EstatusVentaUpdate As Integer
    Public EstatusVentaBusqueda As Integer
    Public NombreComprador As String
    Public PacasVendidas As Integer
    Public PacasDisponibles As Integer
    Public IdModoMic As Integer
    Public IdModoRes As Integer
    Public IdModoLargo As Integer
    Public IdModoUI As Integer
    Public CkMic As Boolean
    Public CkRes As Boolean
    Public CkUI As Boolean
    Public CkLargo As Boolean
    Public IdModoEncabezado As Integer
    'Tablas de Castigos y modalidad compra
    Public TablaCastigoMicros As DataTable
    Public TablaCastigoLargoFibra As DataTable
    Public TablaCastigoResistenciaFibra As DataTable
    Public TablaModalidadCompra As DataTable
End Class
