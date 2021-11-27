Imports Capa_Entidad
Imports Capa_Datos
Public Class CastigoMicros
    Public Overridable Sub Guardar(ByRef EntidadCastigoMicros As Capa_Entidad.CastigoMicros)
        Dim EntidadCastigoMicros1 As New Capa_Entidad.CastigoMicros
        Dim DatosCastigoMicros As New Capa_Datos.CastigoMicros
        EntidadCastigoMicros1 = EntidadCastigoMicros
        DatosCastigoMicros.Upsert(EntidadCastigoMicros1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadCastigoMicros As Capa_Entidad.CastigoMicros)
        Dim DatosCastigoMicros As New Capa_Datos.CastigoMicros
        DatosCastigoMicros.Consultar(EntidadCastigoMicros)
    End Sub
End Class
