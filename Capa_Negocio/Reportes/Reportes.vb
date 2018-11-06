Public Class Reportes
    Public Overridable Sub Consultar(ByRef EntidadReportes As Capa_Entidad.Reportes)
        Dim DatosReportes As New Capa_Datos.Reportes
        DatosReportes.Consultar(EntidadReportes)
    End Sub
End Class
