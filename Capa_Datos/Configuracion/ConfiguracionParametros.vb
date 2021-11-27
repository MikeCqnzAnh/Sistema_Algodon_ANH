Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class ConfiguracionParametros
    Public Overridable Sub Upsert(ByRef EntidadConfiguracionParametros As Capa_Entidad.ConfiguracionParametros)
        Dim EntidadConfiguracionParametros1 As New Capa_Entidad.ConfiguracionParametros
        EntidadConfiguracionParametros1 = EntidadConfiguracionParametros
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_InsertaConfiguracionParametros", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdConfiguracion", EntidadConfiguracionParametros1.IdConfiguracion))
            cmdGuardar.Parameters.Add(New SqlParameter("@NombrePC", EntidadConfiguracionParametros1.NombrePC))
            cmdGuardar.Parameters.Add(New SqlParameter("@DireccionIP", EntidadConfiguracionParametros1.DireccionIP))
            cmdGuardar.Parameters.Add(New SqlParameter("@NombrePuerto", EntidadConfiguracionParametros1.NombrePuerto))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorID", EntidadConfiguracionParametros1.IndicadorID))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorModulo", EntidadConfiguracionParametros1.IndicadorModulo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorEntrada", EntidadConfiguracionParametros1.IndicadorEntrada))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorSalida", EntidadConfiguracionParametros1.IndicadorSalida))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorBruto", EntidadConfiguracionParametros1.IndicadorPesoBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorTara", EntidadConfiguracionParametros1.IndicadorTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorNeto", EntidadConfiguracionParametros1.IndicadorNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorPacasBruto", EntidadConfiguracionParametros1.IndicadorPacasBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorPacasTara", EntidadConfiguracionParametros1.IndicadorPacasTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@IndicadorPacasNeto", EntidadConfiguracionParametros1.IndicadorPacasNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@PosicionID", EntidadConfiguracionParametros1.PosicionID))
            cmdGuardar.Parameters.Add(New SqlParameter("@PosicionModulo", EntidadConfiguracionParametros1.PosicionModulo))
            cmdGuardar.Parameters.Add(New SqlParameter("@PosicionEntrada", EntidadConfiguracionParametros1.PosicionEntradas))
            cmdGuardar.Parameters.Add(New SqlParameter("@PosicionSalida", EntidadConfiguracionParametros1.PosicionSalida))
            cmdGuardar.Parameters.Add(New SqlParameter("@PosicionBruto", EntidadConfiguracionParametros1.PosicionBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@PosicionTara", EntidadConfiguracionParametros1.PosicionTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@PosicionNeto", EntidadConfiguracionParametros1.PosicionNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasPosicionBruto", EntidadConfiguracionParametros1.PosicionPacasBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasPosicionTara", EntidadConfiguracionParametros1.PosicionPacasTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasPosicionNeto", EntidadConfiguracionParametros1.PosicionPacasNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@CaracterID", EntidadConfiguracionParametros1.NoCaracterID))
            cmdGuardar.Parameters.Add(New SqlParameter("@CaracterModulo", EntidadConfiguracionParametros1.NoCaracterModulo))
            cmdGuardar.Parameters.Add(New SqlParameter("@CaracterEntrada", EntidadConfiguracionParametros1.NoCaracterEntrada))
            cmdGuardar.Parameters.Add(New SqlParameter("@CaracterSalida", EntidadConfiguracionParametros1.NoCaracterSalida))
            cmdGuardar.Parameters.Add(New SqlParameter("@CaracterBruto", EntidadConfiguracionParametros1.NoCaracterBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@CaracterTara", EntidadConfiguracionParametros1.NoCaracterTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@CaracterNeto", EntidadConfiguracionParametros1.NoCaracterNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasCaracterBruto", EntidadConfiguracionParametros1.NoCaracterPacasBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasCaracterTara", EntidadConfiguracionParametros1.NoCaracterPacasTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasCaracterNeto", EntidadConfiguracionParametros1.NoCaracterPacasNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@PesoMinimoPaca", EntidadConfiguracionParametros1.PesoMinimoPaca))

            'cmdGuardar.Parameters.Add(New SqlParameter("@IdSerieBanxico", EntidadConfiguracionParametros1.IdSerieBanxico))
            'cmdGuardar.Parameters.Add(New SqlParameter("@CampoValorBanxico", EntidadConfiguracionParametros1.CampoValorBanxico))
            'cmdGuardar.Parameters.Add(New SqlParameter("@PosicionValorBanxico", EntidadConfiguracionParametros1.PosicionValorBanxico))
            'cmdGuardar.Parameters.Add(New SqlParameter("@LongitudValorBanxico", EntidadConfiguracionParametros1.LongitudValorBanxico))
            'cmdGuardar.Parameters.Add(New SqlParameter("@LongitudValorBanxico", EntidadConfiguracionParametros1.SitioBanxico))
            cmdGuardar.Parameters("@IdConfiguracion").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadConfiguracionParametros1.IdConfiguracion = 0 Then
                EntidadConfiguracionParametros1.IdConfiguracion = cmdGuardar.Parameters("@IdConfiguracion").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadConfiguracionParametros = EntidadConfiguracionParametros1
        End Try
    End Sub
    Public Overridable Sub UpsertBanxico(ByRef EntidadConfiguracionParametros As Capa_Entidad.ConfiguracionParametros)
        Dim EntidadConfiguracionParametros1 As New Capa_Entidad.ConfiguracionParametros
        EntidadConfiguracionParametros1 = EntidadConfiguracionParametros
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_InsertarConfiguracionBanxico", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@Idconfiguracionbanxico", EntidadConfiguracionParametros1.IdConfiguracion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Sitio", EntidadConfiguracionParametros1.SitioBanxico))
            cmdGuardar.Parameters.Add(New SqlParameter("@Serie", EntidadConfiguracionParametros1.IdSerieBanxico))
            cmdGuardar.Parameters.Add(New SqlParameter("@Token", EntidadConfiguracionParametros1.TokenBanxico))

            cmdGuardar.Parameters("@IdConfiguracionBanxico").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadConfiguracionParametros1.IdConfiguracion = 0 Then
                EntidadConfiguracionParametros1.IdConfiguracion = cmdGuardar.Parameters("@IdConfiguracionBanxico").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadConfiguracionParametros = EntidadConfiguracionParametros1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadConfiguracionParametros As Capa_Entidad.ConfiguracionParametros)
        Dim EntidadConfiguracionParametros1 As New Capa_Entidad.ConfiguracionParametros()
        EntidadConfiguracionParametros1 = EntidadConfiguracionParametros
        EntidadConfiguracionParametros1.BaseDeDatos = DataBase
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadConfiguracionParametros1.TablaConsulta = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadConfiguracionParametros1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBaseDatos
                    sqldat1 = New SqlDataAdapter("SELECT database_id, name,* FROM sys.databases where name like 'Algodon%' order by   create_date desc", cnn)
                    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Sp_ConsultaConfiguracionParametros", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdConfiguracion", EntidadConfiguracionParametros1.IdConfiguracion))
                    sqlcom1.Parameters.Add(New SqlParameter("@DireccionIP", EntidadConfiguracionParametros1.DireccionIP))
                    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaInstancia
                    sqldat1 = New SqlDataAdapter("Sp_obtieneNombreInstancia", cnn)
                    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaConfiguracionBanxico", cnn)
                    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaMunicipioMovilizacion
                    '    sqlcom1 = New SqlCommand("sp_ConsultaMunicipiosMov", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdEstadoMovilizacion", EntidadConfiguracionParametros1.IdEstadoMovilizacion))
                    '    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaEstadoMoral
                    '    sqldat1 = New SqlDataAdapter("sp_ConsultaEstados", cnn)
                    '    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaEstadoApoderado
                    '    sqldat1 = New SqlDataAdapter("sp_ConsultaEstados", cnn)
                    '    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaMunicipioApoderado
                    '    sqlcom1 = New SqlCommand("sp_ConsultaMunicipiosApod", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdEstadoApoderado", EntidadConfiguracionParametros1.IdEstadoApoderado))
                    '    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaAsociaciones
                    '    sqldat1 = New SqlDataAdapter("sp_ConsultaAsociaciones", cnn)
                    '    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    '    sqlcom1 = New SqlCommand("sp_ConsultaBasicaConfiguracionParametros", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdTipoPersona", EntidadConfiguracionParametros1.IdTipoPersona))
                    '    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    '    'sqldat1 = New SqlDataAdapter("sp_ConsultaDetalladaConfiguracionParametros", cnn)
                    '    'sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
                    '    sqlcom1 = New SqlCommand("sp_ConsultaDetalladaConfiguracionParametros", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdCliente", EntidadConfiguracionParametros1.IdCliente))
                    '    sqldat1.Fill(EntidadConfiguracionParametros1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadConfiguracionParametros = EntidadConfiguracionParametros1
        End Try
    End Sub
End Class
