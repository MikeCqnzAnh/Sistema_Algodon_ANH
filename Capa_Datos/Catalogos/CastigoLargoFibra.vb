Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class CastigoLargoFibra
    Public Overridable Sub Upsert(ByRef EntidadCastigoLargoFibra As Capa_Entidad.CastigoLargoFibra)
        Dim EntidadCastigoLargoFibra1 As New Capa_Entidad.CastigoLargoFibra
        EntidadCastigoLargoFibra1 = EntidadCastigoLargoFibra
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadCastigoLargoFibra1.Guarda
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                '    sqldat1 = New SqlDataAdapter("Sp_ConsultaLargosFibraDetalle", cnn)
                '    sqldat1.Fill(EntidadCastigoLargoFibra1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Guardar.GuardarEncabezado
                    cmdGuardar = New SqlCommand("sp_InsertaLargoFibraEncabezado", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoLargoFibra1.IdModoEncabezado))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadCastigoLargoFibra1.Descripcion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@ModoComercializacion", EntidadCastigoLargoFibra1.IdModoComercializacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadCastigoLargoFibra1.IdEstatus))
                    cmdGuardar.Parameters("@IdModoEncabezado").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadCastigoLargoFibra1.IdModoEncabezado = 0 Then
                        EntidadCastigoLargoFibra1.IdModoEncabezado = cmdGuardar.Parameters("@IdModoEncabezado").Value
                    End If
                Case Capa_Operacion.Configuracion.Guardar.GuardarDetalle
                    cmdGuardar = New SqlCommand("pa_insertaperfiluhmldetalle", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdmodoDetalle", EntidadCastigoLargoFibra1.IdModoDetalle))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoLargoFibra1.IdModoEncabezado))
                    cmdGuardar.Parameters.Add(New SqlParameter("@rango1", EntidadCastigoLargoFibra1.Rango1))
                    cmdGuardar.Parameters.Add(New SqlParameter("@rango2", EntidadCastigoLargoFibra1.Rango2))
                    cmdGuardar.Parameters.Add(New SqlParameter("@LenghtNDS", EntidadCastigoLargoFibra1.LenghtNDS))
                    cmdGuardar.Parameters.Add(New SqlParameter("@castigo", EntidadCastigoLargoFibra1.Castigo))
                    cmdGuardar.Parameters("@IdmodoDetalle").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadCastigoLargoFibra1.IdModoDetalle = 0 Then
                        EntidadCastigoLargoFibra1.IdModoDetalle = cmdGuardar.Parameters("@IdmodoDetalle").Value
                    End If
            End Select
            'For Each MiTableRow As DataRow In EntidadCastigoLargoFibra1.TablaModosDetalle.Rows
            '    cmdGuardar.CommandText = "sp_InsertaLargoFibraDetalle"
            '    cmdGuardar.CommandType = CommandType.StoredProcedure
            '    cmdGuardar.Parameters.Clear()
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdModoDetalle", MiTableRow("IdModoDetalle")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoLargoFibra1.IdModoEncabezado))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@Rango1", MiTableRow("Rango1")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@Rango2", MiTableRow("Rango2")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@ColorGrade", MiTableRow("ColorGrade")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@Castigo", MiTableRow("Castigo")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", MiTableRow("IdEstatus")))
            '    cmdGuardar.ExecuteNonQuery()
            'Next
            'For Each MiTableEquivalenteRow As DataRow In EntidadCastigoLargoFibra1.TablaModosEquivalente.Rows
            '    cmdGuardar.CommandText = "sp_InsertaLargoFibraEquivalente"
            '    cmdGuardar.CommandType = CommandType.StoredProcedure
            '    cmdGuardar.Parameters.Clear()
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdLargoFibraDetalle", MiTableEquivalenteRow("IdModoDetalle")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoLargoFibra1.IdModoEncabezado))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@ModoComercializacion", MiTableEquivalenteRow("ModoComercializacion")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@Rango1", MiTableEquivalenteRow("Rango1")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@Rango2", MiTableEquivalenteRow("Rango2")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@LenghtNDS", MiTableEquivalenteRow("LenghtNDS")))
            '    cmdGuardar.ExecuteNonQuery()
            'Next
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoLargoFibra = EntidadCastigoLargoFibra1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCastigoLargoFibra As Capa_Entidad.CastigoLargoFibra)
        Dim EntidadCastigoLargoFibra1 = New Capa_Entidad.CastigoLargoFibra
        EntidadCastigoLargoFibra1 = EntidadCastigoLargoFibra
        EntidadCastigoLargoFibra1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCastigoLargoFibra1.Consulta
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                '    sqldat1 = New SqlDataAdapter("Sp_ConsultaLargosFibraDetalle", cnn)
                '    sqldat1.Fill(EntidadCastigoLargoFibra1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEncabezado
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaLargosFibraEncabezado", cnn)
                    sqldat1.Fill(EntidadCastigoLargoFibra1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("pa_consultaperfiluhmldetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@idmodoencabezado", EntidadCastigoLargoFibra1.IdModoEncabezado))
                    sqldat1.Fill(EntidadCastigoLargoFibra1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEquivalente
                    sqlcom1 = New SqlCommand("Sp_ConsultaLargoFibraEquivalente", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdLargoFibraEncabezado", EntidadCastigoLargoFibra1.IdModoEncabezado))
                    sqldat1.Fill(EntidadCastigoLargoFibra1.TablaConsulta)

            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoLargoFibra = EntidadCastigoLargoFibra1
        End Try
    End Sub
End Class
