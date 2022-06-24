Imports Capa_Entidad
Imports Capa_Datos
Public Class ConfigMic
    Public Overridable Sub Guardar(ByRef EntidadConfigMic As Capa_Entidad.ConfigMic)
        Dim EntidadConfigMic1 As New Capa_Entidad.ConfigMic
        Dim DatosConfigMic As New Capa_Datos.ConfigMic
        EntidadConfigMic1 = EntidadConfigMic
        DatosConfigMic.Upsert(EntidadConfigMic1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadConfigMic As Capa_Entidad.ConfigMic)
        Dim DatosConfigMic As New Capa_Datos.ConfigMic
        DatosConfigMic.Consultar(EntidadConfigMic)
    End Sub
End Class
