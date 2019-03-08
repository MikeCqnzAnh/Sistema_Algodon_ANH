Public Class ImportarCatalogos
    Public Overridable Sub Consultar(ByRef EntidadImportarCatalogos As Capa_Entidad.ImportarCatalogos)
        Dim EntidadImportarCatalogos1 As New Capa_Entidad.ImportarCatalogos()
        Dim DatosImportarCatalogos As New Capa_Datos.ImportarCatalogos()
        EntidadImportarCatalogos1 = EntidadImportarCatalogos
        DatosImportarCatalogos.Consultar(EntidadImportarCatalogos1)
    End Sub
    Public Overridable Sub ConsultarBaseExterna(ByRef EntidadImportarCatalogos As Capa_Entidad.ImportarCatalogos)
        Dim EntidadImportarCatalogos1 As New Capa_Entidad.ImportarCatalogos()
        Dim DatosImportarCatalogos As New Capa_Datos.ImportarCatalogos()
        EntidadImportarCatalogos1 = EntidadImportarCatalogos
        DatosImportarCatalogos.ConsultarBaseExterna(EntidadImportarCatalogos1)
    End Sub
    Public Overridable Sub Importar(ByRef EntidadImportarCatalogos As Capa_Entidad.ImportarCatalogos)
        Dim EntidadImportarCatalogos1 As New Capa_Entidad.ImportarCatalogos()
        Dim DatosImportarCatalogos As New Capa_Datos.ImportarCatalogos()
        EntidadImportarCatalogos1 = EntidadImportarCatalogos
        DatosImportarCatalogos.Importar(EntidadImportarCatalogos1)
    End Sub
End Class
