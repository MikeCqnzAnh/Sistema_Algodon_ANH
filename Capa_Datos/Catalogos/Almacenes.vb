Imports System.Data.SqlClient
Public Class Almacenes
    Public Overridable Sub Upsert(ByRef EntidadAlmacenes As Capa_Entidad.Almacenes)
        Dim EntidadAlmacenes1 As New Capa_Entidad.Almacenes
        EntidadAlmacenes1 = EntidadAlmacenes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadAlmacenes1.Actualiza
                Case Capa_Operacion.Configuracion.Actuliza.ActualizaTipoAlmacen
                    cmdGuardar = New SqlCommand("Sp_InsertarTipoAlmacen", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoAlmacen", EntidadAlmacenes1.IdTipoAlmacen))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadAlmacenes1.Descripcion))
                    cmdGuardar.Parameters("@IdTipoAlmacen").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadAlmacenes1.IdTipoAlmacen = 0 Then
                        EntidadAlmacenes1.IdTipoAlmacen = cmdGuardar.Parameters("@IdTipoAlmacen").Value
                    End If
                Case Capa_Operacion.Configuracion.Actuliza.ActualizaAlmacen
                    cmdGuardar = New SqlCommand("Sp_InsertaAlmacen", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdAlmacen", EntidadAlmacenes1.IdAlmacen))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadAlmacenes1.Descripcion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoAlmacen", EntidadAlmacenes1.IdTipoAlmacen))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Calle", EntidadAlmacenes1.Calle))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Numero", EntidadAlmacenes1.Numero))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CodigoPostal", EntidadAlmacenes1.CodigoPostal))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Colonia", EntidadAlmacenes1.Colonia))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Ciudad", EntidadAlmacenes1.Ciudad))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Estado", EntidadAlmacenes1.Estado))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Capacidad", EntidadAlmacenes1.Capacidad))
                    cmdGuardar.Parameters("@IdAlmacen").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadAlmacenes1.IdTipoAlmacen = 0 Then
                        EntidadAlmacenes1.IdTipoAlmacen = cmdGuardar.Parameters("@IdAlmacen").Value
                    End If
            End Select

        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAlmacenes = EntidadAlmacenes1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadAlmacenes As Capa_Entidad.Almacenes)
        Dim EntidadAlmacenes1 = New Capa_Entidad.Almacenes
        EntidadAlmacenes1 = EntidadAlmacenes
        EntidadAlmacenes1.TablaConsulta = New DataTable
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadAlmacenes1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    Dim sqldat1 As New SqlDataAdapter("Sp_ConsultaTipoAlmacen", cnn)
                    sqldat1.Fill(EntidadAlmacenes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaAlmacen
                    Dim sqldat1 As New SqlDataAdapter("Sp_ConsultaAlmacen", cnn)
                    sqldat1.Fill(EntidadAlmacenes1.TablaConsulta)
                    End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAlmacenes = EntidadAlmacenes1
        End Try
    End Sub
End Class
