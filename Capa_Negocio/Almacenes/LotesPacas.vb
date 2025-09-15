Public Class LotesPacas
    Public Overridable Sub Consultar(ByRef EntidadLotesPacas As Capa_Entidad.LotesPacas)
        Dim DatosLotesPacas As New Capa_Datos.LotesPacas
        DatosLotesPacas.Consultar(EntidadLotesPacas)
    End Sub
    Public Overridable Sub Guardar(ByRef EntidadLotesPacas As Capa_Entidad.LotesPacas)
        Dim EntidadLotesPacas1 As New Capa_Entidad.LotesPacas
        Dim DatosLotesPacas As New Capa_Datos.LotesPacas
        DatosLotesPacas.Upsert(EntidadLotesPacas)
    End Sub
End Class
