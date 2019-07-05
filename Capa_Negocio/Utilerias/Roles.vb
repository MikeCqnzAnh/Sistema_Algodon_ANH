Public Class Roles
    Public Overridable Sub Consultar(ByRef EntidadRoles As Capa_Entidad.Roles)
        Dim DatosRoles As New Capa_Datos.Roles
        DatosRoles.Consultar(EntidadRoles)
    End Sub
End Class
