Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class ModalidadesCompra
    Public Overridable Sub Upsert(ByRef EntidadModalidadesCompra As Capa_Entidad.ModalidadesCompra)
        Dim EntidadModalidadesCompra1 As New Capa_Entidad.ModalidadesCompra
        EntidadModalidadesCompra1 = EntidadModalidadesCompra
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertaModoCompraEncabezado", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadModalidadesCompra1.IdModoEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadModalidadesCompra1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadModalidadesCompra1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadModalidadesCompra1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadModalidadesCompra1.FechaCreacion))
            cmdGuardar.Parameters("@IdModoEncabezado").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadModalidadesCompra1.IdModoEncabezado = 0 Then
                EntidadModalidadesCompra1.IdModoEncabezado = cmdGuardar.Parameters("@IdModoEncabezado").Value
            End If
            For Each MiTableRow As DataRow In EntidadModalidadesCompra1.TablaClasesClasificacion.Rows
                cmdGuardar.CommandText = "sp_InsertaModoCompraDetalle"
                cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Clear()
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoDetalle", MiTableRow("IdModoDetalle")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadModalidadesCompra1.IdModoEncabezado))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdClasificacion", MiTableRow("IdClasificacion")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Diferencial", MiTableRow("Diferencial")))
                cmdGuardar.ExecuteNonQuery()
            Next
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadModalidadesCompra = EntidadModalidadesCompra1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadModalidadesCompra As Capa_Entidad.ModalidadesCompra)
        Dim EntidadModalidadesCompra1 = New Capa_Entidad.ModalidadesCompra
        EntidadModalidadesCompra1 = EntidadModalidadesCompra
        EntidadModalidadesCompra1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadModalidadesCompra1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModosCompraEncabezado", cnn)
                    sqldat1.Fill(EntidadModalidadesCompra1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaClases
                    sqldat1 = New SqlDataAdapter("sp_ConsultaClasesClasificacion", cnn)
                    sqldat1.Fill(EntidadModalidadesCompra1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaClasesDetalle
                    sqlcom1 = New SqlCommand("sp_ConsultaDetalleModoCompra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadModalidadesCompra1.IdModoEncabezado))
                    sqldat1.Fill(EntidadModalidadesCompra1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadModalidadesCompra = EntidadModalidadesCompra1
        End Try
    End Sub
End Class
