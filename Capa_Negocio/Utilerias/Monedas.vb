Imports Capa_Entidad
Imports Capa_Datos
Public Class Monedas
    Public Overridable Sub Guardar(ByRef EntidadMonedas As Capa_Entidad.Monedas)
        Dim EntidadMonedas1 As New Capa_Entidad.Monedas
        Dim DatosMonedas As New Capa_Datos.Monedas
        EntidadMonedas1 = EntidadMonedas
        DatosMonedas.Upsert(EntidadMonedas1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadMonedas As Capa_Entidad.Monedas)
        Dim EntidadMonedas1 As New Capa_Entidad.Monedas()
        Dim DatosMonedas As New Capa_Datos.Monedas()
        EntidadMonedas1 = EntidadMonedas
        DatosMonedas.Consultar(EntidadMonedas1)
    End Sub
    Public Overridable Sub Eliminar(ByRef EntidadMonedas As Capa_Entidad.Monedas)
        Dim EntidadMonedas1 As New Capa_Entidad.Monedas()
        Dim DatosMonedas As New Capa_Datos.Monedas()
        EntidadMonedas1 = EntidadMonedas
        DatosMonedas.Eliminar(EntidadMonedas1)
    End Sub
End Class
