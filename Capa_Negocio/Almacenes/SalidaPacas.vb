﻿Public Class SalidaPacas
    Public Overridable Sub Consultar(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim DatosSalidaPacas As New Capa_Datos.SalidaPacas
        DatosSalidaPacas.Consultar(EntidadSalidaPacas)
    End Sub
    Public Overridable Sub Guardar(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim EntidadSalidaPacas1 As New Capa_Entidad.SalidaPacas
        Dim DatosSalidaPacas As New Capa_Datos.SalidaPacas
        EntidadSalidaPacas1 = EntidadSalidaPacas
        DatosSalidaPacas.Upsert(EntidadSalidaPacas)
    End Sub
End Class