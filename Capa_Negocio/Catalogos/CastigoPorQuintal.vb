Public Class CastigoPorQuintal
    Public Overridable Sub Guardar(ByRef EntidadCastigoPorQuintal As Capa_Entidad.CastigoPorQuintal)
        Dim EntidadCastigoPorQuintal1 As New Capa_Entidad.CastigoPorQuintal
        Dim DatosCastigoPorQuintal As New Capa_Datos.CastigoPorQuintal
        EntidadCastigoPorQuintal1 = EntidadCastigoPorQuintal
        DatosCastigoPorQuintal.Upsert(EntidadCastigoPorQuintal1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCastigoPorQuintal As Capa_Entidad.CastigoPorQuintal)
        Dim DatosCastigoPorQuintal As New Capa_Datos.CastigoPorQuintal
        DatosCastigoPorQuintal.Consultar(EntidadCastigoPorQuintal)
    End Sub
End Class
