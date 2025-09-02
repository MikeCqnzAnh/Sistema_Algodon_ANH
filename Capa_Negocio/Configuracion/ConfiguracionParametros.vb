Imports Capa_Entidad
Imports Capa_Datos
Public Class ConfiguracionParametros
    Public Overridable Sub Guardar(ByRef EntidadConfiguracionParametros As Capa_Entidad.ConfiguracionParametros)
        Dim EntidadConfiguracionParametros1 As New Capa_Entidad.ConfiguracionParametros
        Dim DatosConfiguracionParametros As New Capa_Datos.ConfiguracionParametros
        EntidadConfiguracionParametros1 = EntidadConfiguracionParametros
        DatosConfiguracionParametros.Upsert(EntidadConfiguracionParametros1)
    End Sub
    Public Overridable Sub GuardarBanxico(ByRef EntidadConfiguracionParametros As Capa_Entidad.ConfiguracionParametros)
        Dim EntidadConfiguracionParametros1 As New Capa_Entidad.ConfiguracionParametros
        Dim DatosConfiguracionParametros As New Capa_Datos.ConfiguracionParametros
        EntidadConfiguracionParametros1 = EntidadConfiguracionParametros
        DatosConfiguracionParametros.UpsertBanxico(EntidadConfiguracionParametros1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadConfiguracionParametros As Capa_Entidad.ConfiguracionParametros)
        Dim EntidadConfiguracionParametros1 As New Capa_Entidad.ConfiguracionParametros()
        Dim DatosConfiguracionParametros As New Capa_Datos.ConfiguracionParametros()
        EntidadConfiguracionParametros1 = EntidadConfiguracionParametros
        DatosConfiguracionParametros.Consultar(EntidadConfiguracionParametros1)
    End Sub
End Class
