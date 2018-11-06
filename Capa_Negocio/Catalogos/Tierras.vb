Public Class Tierras
    Public Overridable Sub Guardar(ByRef EntidadTierras As Capa_Entidad.Tierras)
        Dim EntidadTierras1 As New Capa_Entidad.Tierras
        Dim DatosTierras As New Capa_Datos.Tierras
        EntidadTierras1 = EntidadTierras
        DatosTierras.Upsert(EntidadTierras1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadTierras As Capa_Entidad.Tierras)
        Dim DatosTierras As New Capa_Datos.Tierras
        DatosTierras.Consultar(EntidadTierras)
    End Sub
    Public Overridable Sub ConsultarCombo(ByRef EntidadTierras As Capa_Entidad.Tierras)
        Dim EntidadTierras1 As New Capa_Entidad.Tierras
        Dim DatosTierras As New Capa_Datos.Tierras
        EntidadTierras1 = EntidadTierras
        DatosTierras.ConsultarCombo(EntidadTierras)
    End Sub
End Class
