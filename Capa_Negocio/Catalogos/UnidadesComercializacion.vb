Imports Capa_Entidad
Imports Capa_Datos
Public Class UnidadesComercializacion
    Public Overridable Sub Guardar(ByRef EntidadUnidadesComercializacion As Capa_Entidad.UnidadesComercializacion)
        Dim EntidadUnidadesComercializacion1 As New Capa_Entidad.UnidadesComercializacion
        Dim DatosUnidadesComercializacion As New Capa_Datos.UnidadesComercializacion
        EntidadUnidadesComercializacion1 = EntidadUnidadesComercializacion
        DatosUnidadesComercializacion.Upsert(EntidadUnidadesComercializacion1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadUnidadesComercializacion As Capa_Entidad.UnidadesComercializacion)
        Dim DatosUnidadesComercializacion As New Capa_Datos.UnidadesComercializacion
        DatosUnidadesComercializacion.Consultar(EntidadUnidadesComercializacion)
    End Sub
End Class
