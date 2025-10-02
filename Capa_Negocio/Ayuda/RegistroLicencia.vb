Public Class RegistroLicencia
    Public Overridable Sub Consultar(ByRef EntidadRegistroLicencia As Capa_Entidad.RegistroLicencia)
        Dim DatosRegistroLicencia As New Capa_Datos.RegistroLicencia
        DatosRegistroLicencia.Consultar(EntidadRegistroLicencia)
    End Sub
End Class
