Imports System.Data.SqlClient
Public Class Empleados
    Public Overridable Sub Upsert(ByRef EntidadEmpleados As Capa_Entidad.Empleados)
        Dim EntidadEmpleados1 As New Capa_Entidad.Empleados
        EntidadEmpleados1 = EntidadEmpleados
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarEmpleado", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEmpleado", EntidadEmpleados1.IdEmpleado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre", EntidadEmpleados1.Nombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPuesto", EntidadEmpleados1.IdPuesto))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadEmpleados1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadEmpleados1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadEmpleados1.FechaCreacion))
            cmdGuardar.Parameters("@IdEmpleado").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadEmpleados1.IdEmpleado = 0 Then
                EntidadEmpleados1.IdEmpleado = cmdGuardar.Parameters("@IdEmpleado").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadEmpleados = EntidadEmpleados1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadEmpleados As Capa_Entidad.Empleados)
        Dim EntidadEmpleados1 = New Capa_Entidad.Empleados
        EntidadEmpleados1 = EntidadEmpleados
        EntidadEmpleados1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadEmpleados1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaDetalleEmpleado", cnn)
                    sqldat1.Fill(EntidadEmpleados1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaExtPuestos", cnn)
                    sqldat1.Fill(EntidadEmpleados1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaMunicipio
                    '    sqlcom1 = New SqlCommand("sp_ConsultaMunicipios", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdEstadoFisica", EntidadCompradores1.IdEstado))
                    '    sqldat1.Fill(EntidadCompradores1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadEmpleados = EntidadEmpleados1
        End Try
    End Sub
End Class
