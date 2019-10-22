Public Class Etiquetas
    Public Overridable Sub Consultar(ByRef EntidadEtiquetas As Capa_Entidad.Etiquetas)
        Dim DatosEtiquetas As New Capa_Datos.Etiquetas
        DatosEtiquetas.Consultar(EntidadEtiquetas)
    End Sub
    Public Overridable Sub Actualizar(ByRef EntidadEtiquetas As Capa_Entidad.Etiquetas)
        Dim DatosEtiquetas As New Capa_Datos.Etiquetas
        DatosEtiquetas.Actualizar(EntidadEtiquetas)
    End Sub
    Public Overridable Sub ActualizarEtiqueta(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        Dim DatosProduccion As New Capa_Datos.Produccion
        EntidadProduccion1 = EntidadProduccion
        DatosProduccion.UpsertActualizaEtiqueta(EntidadProduccion1)
    End Sub
End Class
