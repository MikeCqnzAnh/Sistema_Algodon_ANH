Imports System.Data.SqlClient
Public Class ContratoSemillas
    Public Overridable Sub Upsert(ByRef EntidadContratoSemillas As Capa_Entidad.ContratoSemillas)
        Dim EntidadContratoSemillas1 As New Capa_Entidad.ContratoSemillas
        EntidadContratoSemillas1 = EntidadContratoSemillas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarContratoSemilla", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoSemilla", EntidadContratoSemillas1.IdContratoSemilla))
            cmdGuardar.Parameters.Add(New SqlParameter("@Folio", EntidadContratoSemillas1.Folio))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadContratoSemillas1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdComprador", EntidadContratoSemillas1.IdComprador))
            cmdGuardar.Parameters.Add(New SqlParameter("@Cantidad", EntidadContratoSemillas1.Cantidad))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioTonelada", EntidadContratoSemillas1.PrecioTonelada))
            cmdGuardar.Parameters.Add(New SqlParameter("@Testigo1", EntidadContratoSemillas1.Testigo1))
            cmdGuardar.Parameters.Add(New SqlParameter("@Testigo2", EntidadContratoSemillas1.Testigo2))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadContratoSemillas1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadContratoSemillas1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadContratoSemillas1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadContratoSemillas1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadContratoSemillas1.FechaActualizacion))
            cmdGuardar.Parameters("@IdContratoSemilla").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadContratoSemillas1.IdContratoSemilla = 0 Then
                EntidadContratoSemillas1.IdContratoSemilla = cmdGuardar.Parameters("@IdContratoSemilla").Value
                'For Each MiTableRow As DataRow In EntidadContratoSemillas1.TablaConsulta.Rows
                '    cmdGuardar.CommandText = "sp_InsertarContratoCompraDet"
                '    cmdGuardar.CommandType = CommandType.StoredProcedure
                '    cmdGuardar.Parameters.Clear()
                '    cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodonDetalle", 0))
                '    cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadContratosAlgodon1.IdContratoAlgodon))
                '    cmdGuardar.Parameters.Add(New SqlParameter("@IdLote", MiTableRow("IdTierra")))
                '    cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieContratada", MiTableRow("SuperficieContratada")))
                '    cmdGuardar.ExecuteNonQuery()
                'Next
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadContratoSemillas = EntidadContratoSemillas1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadContratoSemillas As Capa_Entidad.ContratoSemillas)
        Dim EntidadContratoSemillas1 As New Capa_Entidad.ContratoSemillas
        EntidadContratoSemillas1 = EntidadContratoSemillas
        EntidadContratoSemillas1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadContratoSemillas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("sp_ConsultaContratosSemilla", cnn)
                    sqldat1.Fill(EntidadContratoSemillas1.TablaConsulta)
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                '    sqldat1 = New SqlDataAdapter("sp_ConsultaContratosDetalle", cnn)
                '    sqldat1.Fill(EntidadContratosAlgodon1.TablaConsulta)
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                '    sqldat1 = New SqlDataAdapter("sp_ConsultaCompradores", cnn)
                '    sqldat1.Fill(EntidadContratoSemillas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCompradores
                    sqlcom1 = New SqlCommand("sp_ConsultaCompradores", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", ""))
                    sqldat1.Fill(EntidadContratoSemillas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaContratosSemillaDet", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdContratoSemilla", EntidadContratoSemillas1.IdContratoSemilla))
                    sqldat1.Fill(EntidadContratoSemillas1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadContratoSemillas = EntidadContratoSemillas1
        End Try
    End Sub
End Class
