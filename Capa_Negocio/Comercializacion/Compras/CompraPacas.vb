Imports Capa_Entidad
Imports Capa_Datos
Public Class CompraPacas
    Public Overridable Sub Guardar(ByRef EntidadClasificacionPacasExcel As Capa_Entidad.ClasificacionPacasExcel)
        Dim EntidadClasificacionPacasExcel1 As New Capa_Entidad.ClasificacionPacasExcel
        Dim DatosClasificacionPacasExcel As New Capa_Datos.ClasificacionPacasExcel
        EntidadClasificacionPacasExcel1 = EntidadClasificacionPacasExcel
        DatosClasificacionPacasExcel.Upsert(EntidadClasificacionPacasExcel)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCompraPacas As Capa_Entidad.VentaPacas)
        Dim DatosCompraPacas As New Capa_Datos.CompraPacas
        DatosCompraPacas.Consultar(EntidadCompraPacas)
    End Sub
End Class
