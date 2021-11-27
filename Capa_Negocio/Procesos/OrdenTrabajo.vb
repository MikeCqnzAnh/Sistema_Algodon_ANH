Imports Capa_Entidad
Imports Capa_Datos
Public Class OrdenTrabajo
    Public Overridable Sub Guardar(ByRef EntidadOrdenTrabajo As Capa_Entidad.OrdenTrabajo)
        Dim EntidadOrdenTrabajo1 As New Capa_Entidad.OrdenTrabajo
        Dim DatosOrdenTrabajo As New Capa_Datos.OrdenTrabajo
        EntidadOrdenTrabajo1 = EntidadOrdenTrabajo
        DatosOrdenTrabajo.Upsert(EntidadOrdenTrabajo1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadOrdenTrabajo As Capa_Entidad.OrdenTrabajo)
        Dim DatosOrdenTrabajo As New Capa_Datos.OrdenTrabajo
        DatosOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
    End Sub
End Class
