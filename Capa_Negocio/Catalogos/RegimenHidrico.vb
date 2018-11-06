Public Class RegimenHidrico
    Public Overridable Sub Guardar(ByRef EntidadRegimenHidrico As Capa_Entidad.RegimenHidrico)
        Dim EntidadRegimenHidrico1 As New Capa_Entidad.RegimenHidrico
        Dim DatosRegimenHidrico As New Capa_Datos.RegimenHidrico
        EntidadRegimenHidrico1 = EntidadRegimenHidrico
        DatosRegimenHidrico.Upsert(EntidadRegimenHidrico1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadRegimenHidrico As Capa_Entidad.RegimenHidrico)
        Dim DatosRegimenHidrico As New Capa_Datos.RegimenHidrico
        DatosRegimenHidrico.Consultar(EntidadRegimenHidrico)
    End Sub
End Class
