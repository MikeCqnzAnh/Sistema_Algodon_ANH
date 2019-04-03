Public Class RutaDocumentos
    Public Overridable Sub Consultar(ByRef EntidadRutaDocumentos As Capa_Entidad.RutaDocumentos)
        Dim EntidadRutaDocumentos1 As New Capa_Entidad.RutaDocumentos()
        Dim DatosRutaDocumentos As New Capa_Datos.RutaDocumentos()
        EntidadRutaDocumentos1 = EntidadRutaDocumentos
        DatosRutaDocumentos.Consultar(EntidadRutaDocumentos1)
    End Sub
    Public Overridable Sub InsertaRutaDocumentos(ByRef EntidadRutaDocumentos As Capa_Entidad.RutaDocumentos)
        Dim EntidadRutaDocumentos1 As New Capa_Entidad.RutaDocumentos()
        Dim DatosRutaDocumentos As New Capa_Datos.RutaDocumentos()
        EntidadRutaDocumentos1 = EntidadRutaDocumentos
        DatosRutaDocumentos.InsertaRutaDocumentos(EntidadRutaDocumentos1)
    End Sub
End Class
