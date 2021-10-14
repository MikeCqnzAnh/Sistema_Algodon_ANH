Imports Capa_Datos
Imports Capa_Entidad
Public Class Roles
    Public Overridable Sub Consultar(ByRef EntidadRoles As Capa_Entidad.Roles)
        Dim DatosRoles As New Capa_Datos.Roles
        DatosRoles.Consultar(EntidadRoles)
    End Sub
    Public Overridable Sub Agregar(ByRef EntidadRoles As Capa_Entidad.Roles)
        Dim DatosRoles As New Capa_Datos.Roles
        DatosRoles.Upsert(EntidadRoles)
    End Sub
End Class
