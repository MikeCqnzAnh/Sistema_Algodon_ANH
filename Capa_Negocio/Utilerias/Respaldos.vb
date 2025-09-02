Imports Capa_Entidad
Imports Capa_Datos
Public Class Respaldos
    Public Overridable Sub Generar(ByRef EntidadRespaldos As Capa_Entidad.Respaldos)
        Dim EntidadRespaldos1 As New Capa_Entidad.Respaldos
        Dim DatosRespaldos As New Capa_Datos.Respaldos
        EntidadRespaldos1 = EntidadRespaldos
        DatosRespaldos.Generar(EntidadRespaldos1)
    End Sub
End Class
