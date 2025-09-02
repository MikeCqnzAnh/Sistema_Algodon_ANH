Imports Capa_Entidad
Imports Capa_Datos
Public Class TiposIncidencias
    Public Overridable Sub Guardar(ByRef EntidadTiposIncidencias As Capa_Entidad.TiposIncidencias)
        Dim EntidadTiposIncidencias1 As New Capa_Entidad.TiposIncidencias
        Dim DatosTiposIncidencias As New Capa_Datos.TiposIncidencias
        EntidadTiposIncidencias1 = EntidadTiposIncidencias
        DatosTiposIncidencias.Upsert(EntidadTiposIncidencias1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadTiposIncidencias As Capa_Entidad.TiposIncidencias)
        Dim DatosTiposIncidencias As New Capa_Datos.TiposIncidencias
        DatosTiposIncidencias.Consultar(EntidadTiposIncidencias)
    End Sub
End Class
