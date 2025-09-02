Imports Capa_Entidad
Imports Capa_Datos
Public Class ModalidadesVenta
    Public Overridable Sub Guardar(ByRef EntidadModalidadesVenta As Capa_Entidad.ModalidadesVenta)
        Dim EntidadModalidadesVenta1 As New Capa_Entidad.ModalidadesVenta
        Dim DatosModalidadesVenta As New Capa_Datos.ModalidadesVenta
        EntidadModalidadesVenta1 = EntidadModalidadesVenta
        DatosModalidadesVenta.Upsert(EntidadModalidadesVenta1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadModalidadesVenta As Capa_Entidad.ModalidadesVenta)
        Dim DatosModalidadesVenta As New Capa_Datos.ModalidadesVenta
        DatosModalidadesVenta.Consultar(EntidadModalidadesVenta)
    End Sub
End Class
