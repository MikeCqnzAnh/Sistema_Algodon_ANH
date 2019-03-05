Public Class Acceso
    Public Overridable Sub Consultar(ByRef Acceso As Capa_Entidad.Acceso)
        Dim DatosAcceso As New Capa_Datos.Acceso
        DatosAcceso.Consultar(Acceso)
    End Sub
End Class
