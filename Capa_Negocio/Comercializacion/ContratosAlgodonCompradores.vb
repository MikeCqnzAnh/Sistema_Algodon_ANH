Imports Capa_Entidad
Imports Capa_Datos
Public Class ContratosAlgodonCompradores
    Public Overridable Sub Guardar(ByRef EntidadContratosAlgodonCompradores As Capa_Entidad.ContratosAlgodonCompradores)
        Dim EntidadContratosAlgodonCompradores1 As New Capa_Entidad.ContratosAlgodonCompradores
        Dim DatosContratosAlgodonCompradores As New Capa_Datos.ContratosAlgodonCompradores
        EntidadContratosAlgodonCompradores1 = EntidadContratosAlgodonCompradores
        DatosContratosAlgodonCompradores.Upsert(EntidadContratosAlgodonCompradores1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadContratosAlgodonCompradores As Capa_Entidad.ContratosAlgodonCompradores)
        Dim DatosContratosAlgodonCompradores As New Capa_Datos.ContratosAlgodonCompradores
        DatosContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
    End Sub
End Class
