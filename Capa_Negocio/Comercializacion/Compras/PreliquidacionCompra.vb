Imports Capa_Entidad
Imports Capa_Datos
Public Class PreliquidacionCompra
    Public Overridable Sub Consultar(ByRef EntidadPreliquidacionCompra As Capa_Entidad.PreliquidacionCompra)
        Dim DatosPreliquidacionCompra As New Capa_Datos.PreliquidacionCompra
        DatosPreliquidacionCompra.Consultar(EntidadPreliquidacionCompra)
    End Sub
End Class
