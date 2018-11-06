Public Class IncidenciaOperaciones
    Public Overridable Sub Guardar(ByRef EntidadIncidenciaOperaciones As Capa_Entidad.IncidenciaOperaciones)
        Dim EntidadIncidenciaOperaciones1 As New Capa_Entidad.IncidenciaOperaciones
        Dim DatosIncidenciaOperaciones As New Capa_Datos.IncidenciaOperaciones
        EntidadIncidenciaOperaciones1 = EntidadIncidenciaOperaciones
        DatosIncidenciaOperaciones.Upsert(EntidadIncidenciaOperaciones1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadIncidenciaOperaciones As Capa_Entidad.IncidenciaOperaciones)
        Dim DatosIncidenciaOperaciones As New Capa_Datos.IncidenciaOperaciones
        DatosIncidenciaOperaciones.Consultar(EntidadIncidenciaOperaciones)
    End Sub
End Class
