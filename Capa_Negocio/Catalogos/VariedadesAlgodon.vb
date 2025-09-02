Imports Capa_Entidad
Imports Capa_Datos
Public Class VariedadesAlgodon
    Public Overridable Sub Guardar(ByRef EntidadVariedadesAlgodon As Capa_Entidad.VariedadesAlgodon)
        Dim EntidadVariedadesAlgodon1 As New Capa_Entidad.VariedadesAlgodon
        Dim DatosVariedadesAlgodon As New Capa_Datos.VariedadesAlgodon
        EntidadVariedadesAlgodon1 = EntidadVariedadesAlgodon
        DatosVariedadesAlgodon.Upsert(EntidadVariedadesAlgodon1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadVariedadesAlgodon As Capa_Entidad.VariedadesAlgodon)
        Dim DatosVariedadesAlgodon As New Capa_Datos.VariedadesAlgodon
        DatosVariedadesAlgodon.Consultar(EntidadVariedadesAlgodon)
    End Sub
End Class
