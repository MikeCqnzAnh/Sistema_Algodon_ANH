Public Class IntegraciondeCompras
    Public Overridable Sub Consultar(ByRef EntidadIntegraciondeCompras As Capa_Entidad.IntegraciondeCompras)
        Dim DatosIntegraciondeCompras As New Capa_Datos.IntegraciondeCompras
        DatosIntegraciondeCompras.Consultar(EntidadIntegraciondeCompras)
    End Sub
    Public Overridable Sub Guardar(ByRef EntidadIntegraciondeCompras As Capa_Entidad.IntegraciondeCompras)
        Dim EntidadIntegraciondeCompras1 As New Capa_Entidad.IntegraciondeCompras
        Dim DatosIntegraciondeCompras As New Capa_Datos.IntegraciondeCompras
        EntidadIntegraciondeCompras1 = EntidadIntegraciondeCompras
        DatosIntegraciondeCompras.Upsert(EntidadIntegraciondeCompras1)
    End Sub
    Public Overridable Sub Eliminar(ByRef EntidadIntegraciondeCompras As Capa_Entidad.IntegraciondeCompras)
        Dim EntidadIntegraciondeCompras1 As New Capa_Entidad.IntegraciondeCompras
        Dim DatosIntegraciondeCompras As New Capa_Datos.IntegraciondeCompras
        EntidadIntegraciondeCompras1 = EntidadIntegraciondeCompras
        DatosIntegraciondeCompras.Eliminar(EntidadIntegraciondeCompras1)
    End Sub
End Class
