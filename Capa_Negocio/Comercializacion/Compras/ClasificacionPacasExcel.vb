Public Class ClasificacionPacasExcel
    Public Overridable Sub Guardar(ByRef EntidadClasificacionPacasExcel As Capa_Entidad.ClasificacionPacasExcel)
        Dim EntidadClasificacionPacasExcel1 As New Capa_Entidad.ClasificacionPacasExcel
        Dim DatosClasificacionPacasExcel As New Capa_Datos.ClasificacionPacasExcel
        EntidadClasificacionPacasExcel1 = EntidadClasificacionPacasExcel
        DatosClasificacionPacasExcel.Upsert(EntidadClasificacionPacasExcel)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadClasificacionPacasExcel As Capa_Entidad.ClasificacionPacasExcel)
        Dim DatosClasificacionPacasExcel As New Capa_Datos.ClasificacionPacasExcel
        DatosClasificacionPacasExcel.Consultar(EntidadClasificacionPacasExcel)
    End Sub
End Class
