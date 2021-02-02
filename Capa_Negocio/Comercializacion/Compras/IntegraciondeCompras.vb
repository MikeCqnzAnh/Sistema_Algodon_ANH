Public Class IntegraciondeCompras
    Public Overridable Sub Consultar(ByRef EntidadIntegraciondeCompras As Capa_Entidad.IntegraciondeCompras)
        Dim DatosIntegraciondeCompras As New Capa_Datos.IntegraciondeCompras
        DatosIntegraciondeCompras.Consultar(EntidadIntegraciondeCompras)
    End Sub
End Class
