Public Class PaquetesHVI
    Public Overridable Sub Guardar(ByRef EntidadPaquetesHVI As Capa_Entidad.PaquetesHVI)
        Dim EntidadPaquetesHVI1 As New Capa_Entidad.PaquetesHVI
        Dim DatosPaquetesHVI As New Capa_Datos.PaquetesHVI
        EntidadPaquetesHVI1 = EntidadPaquetesHVI
        DatosPaquetesHVI.Upsert(EntidadPaquetesHVI1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadPaquetesHVI As Capa_Entidad.PaquetesHVI)
        Dim DatosPaquetesHVI As New Capa_Datos.PaquetesHVI
        DatosPaquetesHVI.Consultar(EntidadPaquetesHVI)
    End Sub
End Class
