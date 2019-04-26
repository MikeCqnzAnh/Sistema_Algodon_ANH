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
            cmdGuardar.Parameters.Add(New SqlParameter("@InicialModulo", EntidadConfiguracionParametros1.InicialModulo))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoCaracterModulo", EntidadConfiguracionParametros1.NoCaracterModulo))
            cmdGuardar.Parameters.Add(New SqlParameter("@InicialTransporte", EntidadConfiguracionParametros1.InicialTransporte))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoCaracterTransporte", EntidadConfiguracionParametros1.NoCaracterTransporte))
            cmdGuardar.Parameters.Add(New SqlParameter("@InicialBoletasBruto", EntidadConfiguracionParametros1.InicialBoletasBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoCaracterBoletasBruto", EntidadConfiguracionParametros1.NoCaracterBoletasBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@InicialBoletasTara", EntidadConfiguracionParametros1.InicialBoletasTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoCaracterBoletasTara", EntidadConfiguracionParametros1.NoCaracterBoletasTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@InicialBoletasNeto", EntidadConfiguracionParametros1.InicialBoletasNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoCaracterBoletasNeto", EntidadConfiguracionParametros1.NoCaracterBoletasNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@InicialPacas", EntidadConfiguracionParametros1.InicialPacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoCaracteresPacas", EntidadConfiguracionParametros1.NoCaracteresPacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@TextoCadenaPesoModulos", EntidadConfiguracionParametros1.TextoCadenaPesoModulos))
            cmdGuardar.Parameters.Add(New SqlParameter("@TextoCadenaPesoPacas", EntidadConfiguracionParametros1.TextoCadenaPesoPacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdSerieBanxico", EntidadConfiguracionParametros1.IdSerieBanxico))
            cmdGuardar.Parameters.Add(New SqlParameter("@CampoValorBanxico", EntidadConfiguracionParametros1.CampoValorBanxico))
            cmdGuardar.Parameters.Add(New SqlParameter("@PosicionValorBanxico", EntidadConfiguracionParametros1.PosicionValorBanxico))
            cmdGuardar.Parameters.Add(New SqlParameter("@LongitudValorBanxico", EntidadConfiguracionParametros1.LongitudValorBanxico))
            cmdGuardar.Parameters.Add(New SqlParameter("@LongitudValorBanxico", EntidadConfiguracionParametros1.SitioBanxico))
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

    Public Overridable Sub Consultar(ByRef EntidadConfiguracionParametros As Capa_Entidad.ConfiguracionParametros)
        Dim EntidadConfiguracionParametros1 As New Capa_Entidad.ConfiguracionParametros()
        EntidadConfiguracionParametros1 = EntidadConfiguracionParametros
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadConfiguracionParametros1.TablaConsulta = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadConfiguracionParametros1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBaseDatos
                    sqldat1 = New SqlDataAdapter("SELECT database_id, name FROM sys.databases where name like '%Algodon%'", cnn)
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
