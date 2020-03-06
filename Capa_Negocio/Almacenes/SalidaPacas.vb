Public Class SalidaPacas
    Public Overridable Sub Consultar(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim DatosSalidaPacas As New Capa_Datos.SalidaPacas
        DatosSalidaPacas.Consultar(EntidadSalidaPacas)
    End Sub
End Class
