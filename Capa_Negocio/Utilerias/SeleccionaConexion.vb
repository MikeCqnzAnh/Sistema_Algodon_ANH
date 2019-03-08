Public Class SeleccionaConexion
    Public Overridable Sub Conexion(ByRef EntidadSeleccionaConexion As Capa_Entidad.SeleccionaConexion)
        Dim EntidadSeleccionaConexion1 As New Capa_Entidad.SeleccionaConexion()
        Dim DatosSeleccionaConexion As New Capa_Datos.SeleccionaConexion()
        EntidadSeleccionaConexion1 = EntidadSeleccionaConexion
        DatosSeleccionaConexion.Conexion(EntidadSeleccionaConexion1)
    End Sub
End Class
