Imports Capa_Entidad
Imports Capa_Datos
Public Class LiquidacionesPorRomaneaje
    Public Overridable Sub Consultar(ByRef EntidadLiquidacionesPorRomaneaje As Capa_Entidad.LiquidacionesPorRomaneaje)
        Dim DatosLiquidacionesPorRomaneaje As New Capa_Datos.LiquidacionesPorRomaneaje
        DatosLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadLiquidacionesPorRomaneaje As Capa_Entidad.LiquidacionesPorRomaneaje)
        Dim DatosLiquidacionesPorRomaneaje As New Capa_Datos.LiquidacionesPorRomaneaje
        DatosLiquidacionesPorRomaneaje.Upsert(EntidadLiquidacionesPorRomaneaje)
    End Sub
End Class
