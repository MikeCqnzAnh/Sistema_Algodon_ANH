Imports Capa_Operacion
Public Class Produccion
    Inherits Tarjeta
    '---------------------------------Produccion
    Public IdProduccion As Integer
    Public IdOrdenTrabajo As Integer
    Public IdPlantaOrigen As Integer
    Public IdPlantaDestino As Integer
    Public IdCliente As Integer
    Public Fecha As Date
    Public IdEstatus As Integer
    Public FolioInicial As Long
    Public NumeroRegistro As Integer
    Public PesoElegir As Boolean

    Public TotalHueso As Double
    Public Pacas As Integer
    Public PlumaPacas As Double
    Public PlumaBorregos As Double
    Public Pluma As Double
    Public Semilla As Double
    Public Merma As Double
    Public Borra As Double
    Public PorcentajePluma As Double
    Public PorcentajeSemilla As Double
    Public PorcentajeMerma As Double
    Public NombreProductor As String

    '---------------------------------Produccion Detalle
    Public IdProduccionDetalle As Integer
    Public Tipo As String
    Public Kilos As Double
    Public FolioCIA As Long
    Public BandExiste As Boolean
    Public IdTurno As Integer
    Public IdBaja As Integer
    Public FechaBaja As Date
    Public ClaveClasificacion As Integer
    Public Micros As Double
    Public Castigo As Double
    Public CastigoMicCpa As Double
    Public CastigoMicVta As Double
    Public CastigoLargoFibra As Double
    Public CastigoLargoFibraCpa As Double
    Public CastigoLargoFibraVta As Double
    Public CastigoResistenciaFibra As Double
    Public CastigoResistenciaFibraCpa As Double
    Public CastigoResistenciaFibraVta As Double
    Public ClaveClasificacionCpa As Double
    Public ClaveClasificacionVta As Double
    Public FechaClasificacion As Date
    Public Libras As Double
    Public ClaveCertificado As Integer
    Public ClaveContratoAlgodon As Integer
    Public ClaveContratoAlgodon2 As Integer
    Public ClavePaqueteHVI As Integer
    Public LargoFibra As Double
    Public ResistenciaFibra As Double
    Public LeerEtiqueta As Boolean

    '---------------------------------Turno
    Public idincidencia As Integer
    Public idturnoenc As Integer
    Public fechaincidencia As DateTime
    Public idresponsableturno As Integer
    Public idresponsableprensa As Integer
    Public hora As TimeSpan
End Class