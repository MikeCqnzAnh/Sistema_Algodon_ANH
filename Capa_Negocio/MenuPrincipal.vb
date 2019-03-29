Public Class MenuPrincipal
    Public Overridable Sub Consultar(ByRef EntidadMenuPrincipal As Capa_Entidad.MenuPrincipal)
        Dim EntidadMenuPrincipal1 As New Capa_Entidad.MenuPrincipal()
        Dim DatosMenuPrincipal As New Capa_Datos.MenuPrincipal()
        EntidadMenuPrincipal1 = EntidadMenuPrincipal
        DatosMenuPrincipal.Consultar(EntidadMenuPrincipal1)
    End Sub
    Public Overridable Sub Actualizar(ByRef EntidadMenuPrincipal As Capa_Entidad.MenuPrincipal)
        Dim EntidadMenuPrincipal1 As New Capa_Entidad.MenuPrincipal()
        Dim DatosMenuPrincipal As New Capa_Datos.MenuPrincipal()
        EntidadMenuPrincipal1 = EntidadMenuPrincipal
        DatosMenuPrincipal.Actualizar(EntidadMenuPrincipal1)
    End Sub
End Class
