Imports Capa_Entidad
Imports Capa_Datos
Public Class Reportes
    Public Overridable Sub Consultar(ByRef EntidadReportes As Capa_Entidad.Reportes)
        Dim DatosReportes As New Capa_Datos.Reportes
        DatosReportes.Consultar(EntidadReportes)
    End Sub
    Public Overridable Sub Guardar(ByRef EntidadReportes As Capa_Entidad.Reportes)
        Dim EntidadReportes1 As New Capa_Entidad.Reportes
        Dim DatosReportes As New Capa_Datos.Reportes
        EntidadReportes1 = EntidadReportes
        DatosReportes.Upsert(EntidadReportes1)
    End Sub
End Class
