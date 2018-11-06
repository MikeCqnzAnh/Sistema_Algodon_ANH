Public Class Colonias
    Public Overridable Sub Guardar(ByRef EntidadColonias As Capa_Entidad.Colonias)
        Dim EntidadColonias1 As New Capa_Entidad.Colonias
        Dim DatosColonias As New Capa_Datos.Colonias
        EntidadColonias1 = EntidadColonias
        DatosColonias.Upsert(EntidadColonias1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadColonias As Capa_Entidad.Colonias)
        Dim DatosColonias As New Capa_Datos.Colonias
        DatosColonias.Consultar(EntidadColonias)
    End Sub
End Class
