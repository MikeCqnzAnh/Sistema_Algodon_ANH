Imports Capa_Entidad
Imports Capa_Datos
Public Class CastigoLargoFibra
    Public Overridable Sub Guardar(ByRef EntidadCastigoLargoFibra As Capa_Entidad.CastigoLargoFibra)
        Dim EntidadCastigoLargoFibra1 As New Capa_Entidad.CastigoLargoFibra
        Dim DatosCastigoLargoFibra As New Capa_Datos.CastigoLargoFibra
        EntidadCastigoLargoFibra1 = EntidadCastigoLargoFibra
        DatosCastigoLargoFibra.Upsert(EntidadCastigoLargoFibra1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadCastigoLargoFibra As Capa_Entidad.CastigoLargoFibra)
        Dim DatosCastigoLargoFibra As New Capa_Datos.CastigoLargoFibra
        DatosCastigoLargoFibra.Consultar(EntidadCastigoLargoFibra)
    End Sub
End Class
