Imports Capa_Entidad
Imports Capa_Datos
Public Class ModalidadesCompra
    Public Overridable Sub Guardar(ByRef EntidadModalidadesCompra As Capa_Entidad.ModalidadesCompra)
        Dim EntidadModalidadesCompra1 As New Capa_Entidad.ModalidadesCompra
        Dim DatosModalidadesCompra As New Capa_Datos.ModalidadesCompra
        EntidadModalidadesCompra1 = EntidadModalidadesCompra
        DatosModalidadesCompra.Upsert(EntidadModalidadesCompra1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadModalidadesCompra As Capa_Entidad.ModalidadesCompra)
        Dim DatosModalidadesCompra As New Capa_Datos.ModalidadesCompra
        DatosModalidadesCompra.Consultar(EntidadModalidadesCompra)
    End Sub
End Class
