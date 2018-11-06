Imports System.Data.SqlClient
Public Class Tierras
    Public Overridable Sub Upsert(ByRef EntidadTierras As Capa_Entidad.Tierras)
        Dim EntidadTierras1 As New Capa_Entidad.Tierras
        EntidadTierras1 = EntidadTierras
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarTierra", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTierra", EntidadTierras1.IdTierra))
            cmdGuardar.Parameters.Add(New SqlParameter("@Lote", EntidadTierras1.Lote))
            cmdGuardar.Parameters.Add(New SqlParameter("@Colonia", EntidadTierras1.Colonia))
            cmdGuardar.Parameters.Add(New SqlParameter("@Propietario", EntidadTierras1.Propietario))
            cmdGuardar.Parameters.Add(New SqlParameter("@RegistroAlterno", EntidadTierras1.RegistroAlterno))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieTotal", EntidadTierras1.SuperficieTotal))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieCultivable", EntidadTierras1.SuperficieCultivable))
            cmdGuardar.Parameters.Add(New SqlParameter("@LatitudGrados", EntidadTierras1.LatitudGrados))
            cmdGuardar.Parameters.Add(New SqlParameter("@LatitudHoras", EntidadTierras1.LatitudHoras))
            cmdGuardar.Parameters.Add(New SqlParameter("@LatitudMinutos", EntidadTierras1.LatitudMinutos))
            cmdGuardar.Parameters.Add(New SqlParameter("@LongitudGrados", EntidadTierras1.LongitudGrados))
            cmdGuardar.Parameters.Add(New SqlParameter("@LongitudHoras", EntidadTierras1.LongitudHoras))
            cmdGuardar.Parameters.Add(New SqlParameter("@LongitudMinutos", EntidadTierras1.LongitudMinutos))
            cmdGuardar.Parameters.Add(New SqlParameter("@NumeroRpp", EntidadTierras1.NumeroRpp))
            cmdGuardar.Parameters.Add(New SqlParameter("@FolioRpp", EntidadTierras1.FolioRpp))
            cmdGuardar.Parameters.Add(New SqlParameter("@LibroRpp", EntidadTierras1.LibroRpp))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadTierras1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@TituloAgua", EntidadTierras1.TituloAgua))
            cmdGuardar.Parameters.Add(New SqlParameter("@RegimenHidrico", EntidadTierras1.RegimenHidrico))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaTituloAgua", EntidadTierras1.FechaTituloAgua))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadTierras1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadTierras1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadTierras1.FechaCreacion))
            cmdGuardar.Parameters("@IdTierra").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadTierras1.IdTierra = 0 Then
                EntidadTierras1.IdTierra = cmdGuardar.Parameters("@IdTierra").Value
            End If
            InsertaTierraDetalle(cmdGuardar.Parameters("@IdTierra").Value, EntidadTierras1.SuperficieCultivable)
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadTierras = EntidadTierras1
        End Try
    End Sub
    Private Sub InsertaTierraDetalle(ByVal IdTierraEncabezado As Integer, ByVal SuperficieRestante As Double)
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            If cnn.State = ConnectionState.Closed Then cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarTierraDetalle", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTierraDetalle", 0))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTierraEncabezado", IdTierraEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieRestante", SuperficieRestante))
            cmdGuardar.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try

    End Sub
    Public Overridable Sub Consultar(ByRef EntidadTierras As Capa_Entidad.Tierras)
        Dim EntidadTierras1 = New Capa_Entidad.Tierras
        EntidadTierras1 = EntidadTierras
        EntidadTierras1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadTierras1.Consulta
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                '    sqldat1 = New SqlDataAdapter("sp_ConsultaTierrasBusqueda", cnn)
                '    sqldat1.Fill(EntidadTierras1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaEstado
                    '    sqldat1 = New SqlDataAdapter("sp_ConsultaEstados", cnn)
                    '    sqldat1.Fill(EntidadCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("sp_ConsultaTierrasBusqueda", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreLote", EntidadTierras1.Lote))
                    sqldat1.Fill(EntidadTierras1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaTierras", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdTierra", EntidadTierras1.IdTierra))
                    sqldat1.Fill(EntidadTierras1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadTierras = EntidadTierras1
        End Try
    End Sub
    Public Overridable Sub ConsultarCombo(ByRef EntidadTierras As Capa_Entidad.Tierras)
        Dim EntidadTierras1 As New Capa_Entidad.Tierras
        EntidadTierras1 = EntidadTierras
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadTierras1.LlenaCombo
                Case Capa_Operacion.Configuracion.LlenaCombo.LlenaComboCliente
                    Dim cmd As New SqlCommand("sp_LlenarComboClientes", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadTierras1.TablaConsulta = dt
                Case Capa_Operacion.Configuracion.LlenaCombo.LlenaComboColonia
                    Dim cmd As New SqlCommand("sp_llenarComboColonias", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadTierras1.TablaConsulta = dt
                Case Capa_Operacion.Configuracion.LlenaCombo.LlenaComboRegimen
                    Dim cmd As New SqlCommand("Sp_LlenaComboRegimenHidrico", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadTierras1.TablaConsulta = dt
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadTierras = EntidadTierras1
        End Try
    End Sub
End Class
