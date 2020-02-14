Public Class CastigoUniformidad
    Public Overridable Sub Guardar(ByRef EntidadCastigoUniformidad As Capa_Entidad.CastigoUniformidad)
        Dim EntidadCastigoUniformidad1 As New Capa_Entidad.CastigoUniformidad
        Dim DatosCastigoUniformidad As New Capa_Datos.CastigoUniformidad
        EntidadCastigoUniformidad1 = EntidadCastigoUniformidad
        DatosCastigoUniformidad.Upsert(EntidadCastigoUniformidad1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadCastigoUniformidad As Capa_Entidad.CastigoUniformidad)
        Dim DatosCastigoUniformidad As New Capa_Datos.CastigoUniformidad
        DatosCastigoUniformidad.Consultar(EntidadCastigoUniformidad)
    End Sub
End Class
