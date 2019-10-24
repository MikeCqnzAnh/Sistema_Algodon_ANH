
Public Class Produccion
    Public Overridable Sub Guardar(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        Dim DatosProduccion As New Capa_Datos.Produccion
        EntidadProduccion1 = EntidadProduccion
        DatosProduccion.Upsert(EntidadProduccion1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim DatosProduccion As New Capa_Datos.Produccion
        DatosProduccion.Consultar(EntidadProduccion)
    End Sub
    Public Overridable Sub GuardarDetalle(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        Dim DatosProduccion As New Capa_Datos.Produccion
        EntidadProduccion1 = EntidadProduccion
        DatosProduccion.UpsertDetalle(EntidadProduccion1)
    End Sub
    Public Overridable Sub GuardarEtiqueta(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        Dim DatosProduccion As New Capa_Datos.Produccion
        EntidadProduccion1 = EntidadProduccion
        DatosProduccion.UpsertEtiqueta(EntidadProduccion1)
    End Sub
    Public Overridable Sub ActualizarEtiqueta(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        Dim DatosProduccion As New Capa_Datos.Produccion
        EntidadProduccion1 = EntidadProduccion
        DatosProduccion.UpsertActualizaEtiqueta(EntidadProduccion1)
    End Sub
    Public Overridable Sub UpsertFolioInicial(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        Dim DatosProduccion As New Capa_Datos.Produccion
        EntidadProduccion1 = EntidadProduccion
        DatosProduccion.UpsertFolioInicial(EntidadProduccion1)
    End Sub
    Public Overridable Sub UpsertLeerEtiqueta(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        Dim DatosProduccion As New Capa_Datos.Produccion
        EntidadProduccion1 = EntidadProduccion
        DatosProduccion.UpsertLeerEtiqueta(EntidadProduccion1)
    End Sub
    Public Overridable Sub EliminarPaca(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        Dim DatosProduccion As New Capa_Datos.Produccion
        EntidadProduccion1 = EntidadProduccion
        DatosProduccion.Eliminar(EntidadProduccion1)
    End Sub
End Class
