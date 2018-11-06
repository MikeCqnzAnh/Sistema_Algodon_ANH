Public Class Rendimientos
    Public Overridable Sub Guardar(ByRef EntidadRendimientos As Capa_Entidad.Rendimientos)
        Dim EntidadRendimientos1 As New Capa_Entidad.Rendimientos
        Dim DatosRendimientos As New Capa_Datos.Rendimientos
        EntidadRendimientos1 = EntidadRendimientos
        DatosRendimientos.Upsert(EntidadRendimientos1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadRendimientos As Capa_Entidad.Rendimientos)
        Dim DatosRendimientos As New Capa_Datos.Rendimientos
        DatosRendimientos.Consultar(EntidadRendimientos)
    End Sub
End Class
