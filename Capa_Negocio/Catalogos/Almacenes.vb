Imports Capa_Entidad
Imports Capa_Datos
Public Class Almacenes
    Public Overridable Sub Guardar(ByRef EntidadAlmacenes As Capa_Entidad.Almacenes)
        Dim EntidadAlmacenes1 As New Capa_Entidad.Almacenes
        Dim DatosAlmacenes As New Capa_Datos.Almacenes
        EntidadAlmacenes1 = EntidadAlmacenes
        DatosAlmacenes.Upsert(EntidadAlmacenes1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadAlmacenes As Capa_Entidad.Almacenes)
        Dim DatosAlmacenes As New Capa_Datos.Almacenes
        DatosAlmacenes.Consultar(EntidadAlmacenes)
    End Sub

End Class
