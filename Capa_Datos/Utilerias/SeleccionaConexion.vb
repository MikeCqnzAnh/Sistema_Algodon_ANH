Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class SeleccionaConexion
    Public Overridable Sub Conexion(ByRef EntidadSeleccionaConexion As Capa_Entidad.SeleccionaConexion)
        Dim EntidadSeleccionaConexion1 As New Capa_Entidad.SeleccionaConexion()
        EntidadSeleccionaConexion1 = EntidadSeleccionaConexion
        DataBase = EntidadSeleccionaConexion1.BaseDeDatos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadSeleccionaConexion1.Conexion
                Case Capa_Operacion.Configuracion.Conexion.ConexionDataBase
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
End Class
