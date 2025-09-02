Imports Capa_Entidad
Imports Capa_Datos
Public Class CastigoResistenciaFibra
    Public Overridable Sub Guardar(ByRef EntidadCastigoResistenciaFibra As Capa_Entidad.CastigoResistenciaFibra)
        Dim EntidadCastigoResistenciaFibra1 As New Capa_Entidad.CastigoResistenciaFibra
        Dim DatosCastigoResistenciaFibra As New Capa_Datos.CastigoResistenciaFibra
        EntidadCastigoResistenciaFibra1 = EntidadCastigoResistenciaFibra
        DatosCastigoResistenciaFibra.Upsert(EntidadCastigoResistenciaFibra1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadCastigoResistenciaFibra As Capa_Entidad.CastigoResistenciaFibra)
        Dim DatosCastigoResistenciaFibra As New Capa_Datos.CastigoResistenciaFibra
        DatosCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
    End Sub
End Class
