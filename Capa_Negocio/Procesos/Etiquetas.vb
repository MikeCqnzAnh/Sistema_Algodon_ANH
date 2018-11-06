Public Class Etiquetas
    Public Overridable Sub Consultar(ByRef EntidadEtiquetas As Capa_Entidad.Etiquetas)
        Dim DatosEtiquetas As New Capa_Datos.Etiquetas
        DatosEtiquetas.Consultar(EntidadEtiquetas)
    End Sub
    Public Overridable Sub Actualizar(ByRef EntidadEtiquetas As Capa_Entidad.Etiquetas)
        Dim DatosEtiquetas As New Capa_Datos.Etiquetas
        DatosEtiquetas.Actualizar(EntidadEtiquetas)
    End Sub
End Class
