Imports Capa_Entidad
Imports Capa_Datos
Public Class Plantas
    Public Overridable Sub Guardar(ByRef EntidadPlantas As Capa_Entidad.Plantas)
        Dim EntidadPlantas1 As New Capa_Entidad.Plantas
        Dim DatosPlantas As New Capa_Datos.Plantas
        EntidadPlantas1 = EntidadPlantas
        DatosPlantas.Upsert(EntidadPlantas1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadPlantas As Capa_Entidad.Plantas)
        Dim DatosPlantas As New Capa_Datos.Plantas
        DatosPlantas.Consultar(EntidadPlantas)
    End Sub
End Class
