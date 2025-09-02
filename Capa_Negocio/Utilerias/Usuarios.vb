Imports Capa_Entidad
Imports Capa_Datos
Public Class Usuarios
    Public Overridable Sub Guardar(ByRef EntidadUsuarios As Capa_Entidad.Usuarios)
        Dim EntidadUsuarios1 As New Capa_Entidad.Usuarios
        Dim DatosUsuarios As New Capa_Datos.Usuarios
        EntidadUsuarios1 = EntidadUsuarios
        DatosUsuarios.Upsert(EntidadUsuarios1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadUsuarios As Capa_Entidad.Usuarios)
        Dim DatosUsuarios As New Capa_Datos.Usuarios
        DatosUsuarios.Consultar(EntidadUsuarios)
    End Sub

    Public Overridable Sub ActualizaVariableBdd(ByRef EntidadUsuarios As Capa_Entidad.Usuarios)
        Dim DatosUsuarios As New Capa_Datos.Usuarios
        DatosUsuarios.ActualizaVariableBdd(EntidadUsuarios)
    End Sub
End Class
