Public Class Puestos
    Public Overridable Sub Guardar(ByRef EntidadPuestos As Capa_Entidad.Puestos)
        Dim EntidadPuestos1 As New Capa_Entidad.Puestos
        Dim DatosPuestos As New Capa_Datos.Puestos
        EntidadPuestos1 = EntidadPuestos
        DatosPuestos.Upsert(EntidadPuestos1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadPuestos As Capa_Entidad.Puestos)
        Dim DatosPuestos As New Capa_Datos.Puestos
        DatosPuestos.Consultar(EntidadPuestos)
    End Sub
End Class
