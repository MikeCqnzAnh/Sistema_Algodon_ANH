Imports System.Data.SqlClient
Public Class CastigoResistenciaFibra
    Public Overridable Sub Upsert(ByRef EntidadCastigoResistenciaFibra As Capa_Entidad.CastigoResistenciaFibra)
        Dim EntidadCastigoResistenciaFibra1 As New Capa_Entidad.CastigoResistenciaFibra
        EntidadCastigoResistenciaFibra1 = EntidadCastigoResistenciaFibra
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertaResistenciaEncabezado", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoResistenciaFibra1.IdResistenciaEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadCastigoResistenciaFibra1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@ModoComercializacion", EntidadCastigoResistenciaFibra1.IdModoComercializacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadCastigoResistenciaFibra1.IdEstatus))
            cmdGuardar.Parameters("@IdModoEncabezado").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadCastigoResistenciaFibra1.IdResistenciaEncabezado = 0 Then
                EntidadCastigoResistenciaFibra1.IdResistenciaEncabezado = cmdGuardar.Parameters("@IdModoEncabezado").Value
            End If
            For Each MiTableRow As DataRow In EntidadCastigoResistenciaFibra1.TablaModosDetalle.Rows
                cmdGuardar.CommandText = "sp_InsertaResistenciaDetalle"
                cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Clear()
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoDetalle", MiTableRow("IdModoDetalle")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoResistenciaFibra1.IdResistenciaEncabezado))
                cmdGuardar.Parameters.Add(New SqlParameter("@Rango1", MiTableRow("Rango1")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Rango2", MiTableRow("Rango2")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Castigo", MiTableRow("Castigo")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", MiTableRow("IdEstatus")))
                cmdGuardar.ExecuteNonQuery()
            Next
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoResistenciaFibra = EntidadCastigoResistenciaFibra1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCastigoResistenciaFibra As Capa_Entidad.CastigoResistenciaFibra)
        Dim EntidadCastigoResistenciaFibra1 = New Capa_Entidad.CastigoResistenciaFibra
        EntidadCastigoResistenciaFibra1 = EntidadCastigoResistenciaFibra
        EntidadCastigoResistenciaFibra1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCastigoResistenciaFibra1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Sp_ConsultaResistenciaDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdResistenciaEncabezado", EntidadCastigoResistenciaFibra1.IdResistenciaEncabezado))
                    sqldat1.Fill(EntidadCastigoResistenciaFibra1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEncabezado
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaResistenciaEncabezado", cnn)
                    sqldat1.Fill(EntidadCastigoResistenciaFibra1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaMunicipio
                    '    sqlcom1 = New SqlCommand("sp_ConsultaMunicipios", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdEstadoFisica", EntidadCompradores1.IdEstado))
                    '    sqldat1.Fill(EntidadCompradores1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadCastigoResistenciaFibra = EntidadCastigoResistenciaFibra1
        End Try
    End Sub
End Class
