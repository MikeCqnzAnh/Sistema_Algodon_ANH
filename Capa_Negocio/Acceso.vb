Public Class Acceso
    Public Overridable Sub Consultar(ByRef EntidadAcceso As Capa_Entidad.Acceso)
        Dim EntidadAcceso1 As New Capa_Entidad.Acceso()
        Dim DatosAcceso As New Capa_Datos.Acceso()
        EntidadAcceso1 = EntidadAcceso
        DatosAcceso.Consultar(EntidadAcceso1)
    End Sub
    Public Overridable Sub ConsultarPerfiles(ByRef EntidadAcceso As Capa_Entidad.Acceso)
        Dim EntidadAcceso1 As New Capa_Entidad.Acceso()
        Dim DatosAcceso As New Capa_Datos.Acceso()
        EntidadAcceso1 = EntidadAcceso
        DatosAcceso.ConsultarPerfiles(EntidadAcceso1)
    End Sub
End Class
