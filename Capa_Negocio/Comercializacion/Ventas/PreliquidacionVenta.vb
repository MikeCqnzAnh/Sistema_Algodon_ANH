Imports Capa_Entidad
Imports Capa_Datos
Public Class PreliquidacionVenta
    Public Overridable Sub Consultar(ByRef EntidadPreliquidacionVenta As Capa_Entidad.PreliquidacionVenta)
        Dim DatosPreliquidacionVenta As New Capa_Datos.PreliquidacionVenta
        DatosPreliquidacionVenta.Consultar(EntidadPreliquidacionVenta)
    End Sub
End Class
