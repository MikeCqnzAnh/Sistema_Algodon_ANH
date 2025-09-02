Imports Capa_Entidad
Imports Capa_Datos
Public Class ConfiguracionParametrosContratos
    Public Overridable Sub Guardar(ByRef EntidadConfiguracionParametrosContratos As Capa_Entidad.ConfiguracionParametrosContratos)
        Dim EntidadConfiguracionParametrosContratos1 As New Capa_Entidad.ConfiguracionParametrosContratos
        Dim DatosConfiguracionParametrosContratos As New Capa_Datos.ConfiguracionParametrosContratos
        EntidadConfiguracionParametrosContratos1 = EntidadConfiguracionParametrosContratos
        DatosConfiguracionParametrosContratos.Upsert(EntidadConfiguracionParametrosContratos1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadConfiguracionParametrosContratos As Capa_Entidad.ConfiguracionParametrosContratos)
        Dim EntidadConfiguracionParametrosContratos1 As New Capa_Entidad.ConfiguracionParametrosContratos()
        Dim DatosConfiguracionParametrosContratos As New Capa_Datos.ConfiguracionParametrosContratos()
        EntidadConfiguracionParametrosContratos1 = EntidadConfiguracionParametrosContratos
        DatosConfiguracionParametrosContratos.Consultar(EntidadConfiguracionParametrosContratos1)
    End Sub
End Class
