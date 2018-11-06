Public Class RangosTemperatura
    Public Overridable Sub Guardar(ByRef EntidadRangosTemperatura As Capa_Entidad.RangosTemperatura)
        Dim EntidadRangosTemperatura1 As New Capa_Entidad.RangosTemperatura
        Dim DatosRangosTemperatura As New Capa_Datos.RangosTemperatura
        EntidadRangosTemperatura1 = EntidadRangosTemperatura
        DatosRangosTemperatura.Upsert(EntidadRangosTemperatura1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadRangosTemperatura As Capa_Entidad.RangosTemperatura)
        Dim DatosRangosTemperatura As New Capa_Datos.RangosTemperatura
        DatosRangosTemperatura.Consultar(EntidadRangosTemperatura)
    End Sub
End Class
