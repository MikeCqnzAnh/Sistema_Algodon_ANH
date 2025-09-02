Imports Capa_Entidad
Imports Capa_Datos
Public Class InventarioPacas
    Public Overridable Sub Consultar(ByRef EntidadInventarioPacas As Capa_Entidad.InventarioPacas)
        Dim DatosInventarioPacas As New Capa_Datos.InventarioPacas
        DatosInventarioPacas.Consultar(EntidadInventarioPacas)
    End Sub
End Class
