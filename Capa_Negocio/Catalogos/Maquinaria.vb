Public Class Maquinaria
    Public Overridable Sub Guardar(ByRef EntidadMaquinaria As Capa_Entidad.Maquinaria)
        Dim EntidadMaquinaria1 As New Capa_Entidad.Maquinaria
        Dim DatosMaquinaria As New Capa_Datos.Maquinaria
        EntidadMaquinaria1 = EntidadMaquinaria
        DatosMaquinaria.Upsert(EntidadMaquinaria1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadMaquinaria As Capa_Entidad.Maquinaria)
        Dim DatosMaquinaria As New Capa_Datos.Maquinaria
        DatosMaquinaria.Consultar(EntidadMaquinaria)
    End Sub
End Class
