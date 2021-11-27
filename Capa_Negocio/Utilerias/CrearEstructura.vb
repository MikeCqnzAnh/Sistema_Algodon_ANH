Imports Capa_Entidad
Imports Capa_Datos
Public Class CrearEstructura
    Public Overridable Sub Consultar(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura()
        Dim DatosCrearEstructura As New Capa_Datos.CrearEstructura()
        EntidadCrearEstructura1 = EntidadCrearEstructura
        DatosCrearEstructura.Consultar(EntidadCrearEstructura1)
    End Sub
    Public Overridable Sub ConsultarDB(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura()
        Dim DatosCrearEstructura As New Capa_Datos.CrearEstructura()
        EntidadCrearEstructura1 = EntidadCrearEstructura
        DatosCrearEstructura.ConsultarDB(EntidadCrearEstructura1)
    End Sub
    Public Overridable Sub ConsultarInstancia(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura()
        Dim DatosCrearEstructura As New Capa_Datos.CrearEstructura()
        EntidadCrearEstructura1 = EntidadCrearEstructura
        DatosCrearEstructura.ConsultarInstancia(EntidadCrearEstructura1)
    End Sub
    Public Overridable Sub Importa(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura()
        Dim DatosCrearEstructura As New Capa_Datos.CrearEstructura()
        EntidadCrearEstructura1 = EntidadCrearEstructura
        DatosCrearEstructura.Importa(EntidadCrearEstructura1)
    End Sub
    Public Overridable Sub Guardar(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura
        Dim DatosCrearEstructura As New Capa_Datos.CrearEstructura
        EntidadCrearEstructura1 = EntidadCrearEstructura
        DatosCrearEstructura.Upsert(EntidadCrearEstructura1)
    End Sub
    Public Overridable Sub GuardarTablasEstructura(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura
        Dim DatosCrearEstructura As New Capa_Datos.CrearEstructura
        EntidadCrearEstructura1 = EntidadCrearEstructura
        DatosCrearEstructura.UpsertEstructura(EntidadCrearEstructura1)
    End Sub
End Class
