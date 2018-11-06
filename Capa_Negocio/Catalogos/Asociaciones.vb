Public Class Asociaciones
    Public Overridable Sub Guardar(ByRef EntidadAsociaciones As Capa_Entidad.Asociaciones)
        Dim EntidadAsociaciones1 As New Capa_Entidad.Asociaciones
        Dim DatosAsociaciones As New Capa_Datos.Asociaciones
        EntidadAsociaciones1 = EntidadAsociaciones
        DatosAsociaciones.Upsert(EntidadAsociaciones1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadAsociaciones As Capa_Entidad.Asociaciones)
        Dim DatosAsociaciones As New Capa_Datos.Asociaciones
        DatosAsociaciones.Consultar(EntidadAsociaciones)
    End Sub
    Public Overridable Sub Eliminar(ByRef EntidadAsociaciones As Capa_Entidad.Asociaciones)
        Dim DatosAsociaciones As New Capa_Datos.Asociaciones
        DatosAsociaciones.Eliminar(EntidadAsociaciones)
    End Sub
End Class
