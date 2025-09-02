Imports Capa_Entidad
Imports Capa_Datos
Public Class Camiones
    Public Overridable Sub Guardar(ByRef EntidadCamiones As Capa_Entidad.Camiones)
        Dim EntidadCamiones1 As New Capa_Entidad.Camiones
        Dim DatosCamiones As New Capa_Datos.Camiones
        EntidadCamiones1 = EntidadCamiones
        DatosCamiones.Upsert(EntidadCamiones1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCamiones As Capa_Entidad.Camiones)
        Dim DatosCamiones As New Capa_Datos.Camiones
        DatosCamiones.Consultar(EntidadCamiones)
    End Sub
End Class
