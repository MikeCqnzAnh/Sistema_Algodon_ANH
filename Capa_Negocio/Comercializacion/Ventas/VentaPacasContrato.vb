Public Class VentaPacasContrato
    Public Overridable Sub Guardar(ByRef EntidadVentaPacasContrato As Capa_Entidad.VentaPacasContrato)
        Dim EntidadVentaPacasContrato1 As New Capa_Entidad.VentaPacasContrato
        Dim DatosVentaPacasContrato As New Capa_Datos.VentaPacasContrato
        EntidadVentaPacasContrato1 = EntidadVentaPacasContrato
        DatosVentaPacasContrato.Upsert(EntidadVentaPacasContrato)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCompraPacasContrato As Capa_Entidad.VentaPacasContrato)
        Dim DatosCompraPacasContrato As New Capa_Datos.VentaPacasContrato
        DatosCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
    End Sub
End Class
