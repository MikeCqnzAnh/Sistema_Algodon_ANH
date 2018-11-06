Public Class ConsultaCastigos
    Public Overridable Sub Consultar(ByRef EntidadConsultaCastigos As Capa_Entidad.ConsultaCastigos)
        Dim DatosConsultaCastigos As New Capa_Datos.ConsultaCastigos
        DatosConsultaCastigos.Consultar(EntidadConsultaCastigos)
    End Sub
End Class
