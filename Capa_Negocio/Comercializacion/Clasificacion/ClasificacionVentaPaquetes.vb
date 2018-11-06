Public Class ClasificacionVentaPaquetes
    Public Overridable Sub Guardar(ByRef EntidadClasificacionVentaPaquetes As Capa_Entidad.ClasificacionVentaPaquetes)
        Dim EntidadClasificacionVentaPaquetes1 As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim DatosClasificacionVentaPaquetes As New Capa_Datos.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes1 = EntidadClasificacionVentaPaquetes
        'DatosClasificacionVentaPaquetes.Upsert(EntidadClasificacionVentaPaquetes1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadClasificacionVentaPaquetes As Capa_Entidad.ClasificacionVentaPaquetes)
        Dim DatosClasificacionVentaPaquetes As New Capa_Datos.ClasificacionVentaPaquetes
        DatosClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
    End Sub
    Public Overridable Sub Actualizar(ByRef EntidadClasificacionVentaPaquetes As Capa_Entidad.ClasificacionVentaPaquetes)
        Dim DatosClasificacionVentaPaquetes As New Capa_Datos.ClasificacionVentaPaquetes
        DatosClasificacionVentaPaquetes.Update(EntidadClasificacionVentaPaquetes)
    End Sub
    Public Overridable Sub GuardarTablas(ByRef EntidadClasificacionVentaPaquetes As Capa_Entidad.ClasificacionVentaPaquetes)
        Dim EntidadClasificacionVentaPaquetes1 As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim DatosClasificacionVentaPaquetes As New Capa_Datos.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes1 = EntidadClasificacionVentaPaquetes
        DatosClasificacionVentaPaquetes.Upsert(EntidadClasificacionVentaPaquetes1)
    End Sub
    Public Overridable Sub GuardarDetalle(ByRef EntidadClasificacionVentaPaquetes As Capa_Entidad.ClasificacionVentaPaquetes)
        Dim EntidadClasificacionVentaPaquetes1 As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim DatosClasificacionVentaPaquetes As New Capa_Datos.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes1 = EntidadClasificacionVentaPaquetes
        'DatosClasificacionVentaPaquetes.UpsertDetalle(EntidadClasificacionVentaPaquetes1)
    End Sub
    Public Overridable Sub GuardarHvi(ByRef EntidadClasificacionVentaPaquetes As Capa_Entidad.ClasificacionVentaPaquetes)
        Dim EntidadClasificacionVentaPaquetes1 As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim DatosClasificacionVentaPaquetes As New Capa_Datos.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes1 = EntidadClasificacionVentaPaquetes
        DatosClasificacionVentaPaquetes.UpsertHvi(EntidadClasificacionVentaPaquetes1)
    End Sub
End Class
