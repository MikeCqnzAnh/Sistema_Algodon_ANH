Public Class ContratoSemillas
    Public Overridable Sub Guardar(ByRef EntidadContratoSemillas As Capa_Entidad.ContratoSemillas)
        Dim EntidadContratoSemillas1 As New Capa_Entidad.ContratoSemillas
        Dim DatosContratoSemillas As New Capa_Datos.ContratoSemillas
        EntidadContratoSemillas1 = EntidadContratoSemillas
        DatosContratoSemillas.Upsert(EntidadContratoSemillas1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadContratoSemillas As Capa_Entidad.ContratoSemillas)
        Dim DatosContratoSemillas As New Capa_Datos.ContratoSemillas
        DatosContratoSemillas.Consultar(EntidadContratoSemillas)
    End Sub
End Class
