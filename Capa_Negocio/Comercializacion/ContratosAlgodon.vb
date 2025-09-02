Imports Capa_Entidad
Imports Capa_Datos
Public Class ContratosAlgodon
    Public Overridable Sub Guardar(ByRef EntidadContratosAlgodon As Capa_Entidad.ContratosAlgodon)
        Dim EntidadContratosAlgodon1 As New Capa_Entidad.ContratosAlgodon
        Dim DatosContratosAlgodon As New Capa_Datos.ContratosAlgodon
        EntidadContratosAlgodon1 = EntidadContratosAlgodon
        DatosContratosAlgodon.Upsert(EntidadContratosAlgodon1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadContratosAlgodon As Capa_Entidad.ContratosAlgodon)
        Dim DatosContratosAlgodon As New Capa_Datos.ContratosAlgodon
        DatosContratosAlgodon.Consultar(EntidadContratosAlgodon)
    End Sub
End Class
