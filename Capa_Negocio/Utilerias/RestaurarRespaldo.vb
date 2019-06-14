Public Class RestaurarRespaldo
    Public Overridable Sub Restaurar(ByRef EntidadRestaurarRespaldo As Capa_Entidad.RestaurarRespaldo)
        Dim EntidadRestaurarRespaldo1 As New Capa_Entidad.RestaurarRespaldo
        Dim DatosRestaurarRespaldo As New Capa_Datos.RestaurarRespaldo
        EntidadRestaurarRespaldo1 = EntidadRestaurarRespaldo
        DatosRestaurarRespaldo.Restaurar(EntidadRestaurarRespaldo1)
    End Sub
End Class
