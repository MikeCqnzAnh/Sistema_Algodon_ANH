﻿Imports System.Data.SqlClient
Public Class Usuarios
    Public Overridable Sub Upsert(ByRef EntidadUsuarios As Capa_Entidad.Usuarios)
        Dim EntidadUsuarios1 As New Capa_Entidad.Usuarios
        EntidadUsuarios1 = EntidadUsuarios
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarUsuario", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuario", EntidadUsuarios1.IdUsuario))
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre", EntidadUsuarios1.Nombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@Usuario", EntidadUsuarios1.Usuario))
            cmdGuardar.Parameters.Add(New SqlParameter("@Clave", EntidadUsuarios1.Password))
            cmdGuardar.Parameters.Add(New SqlParameter("@Tipo", EntidadUsuarios1.Tipo))
            cmdGuardar.Parameters("@IdUsuario").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadUsuarios1.IdUsuario = 0 Then
                EntidadUsuarios1.IdUsuario = cmdGuardar.Parameters("@IdUsuario").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadUsuarios = EntidadUsuarios1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadUsuarios As Capa_Entidad.Usuarios)
        Dim EntidadUsuarios1 = New Capa_Entidad.Usuarios
        EntidadUsuarios1 = EntidadUsuarios
        EntidadUsuarios1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadUsuarios1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaUsuario
                    sqldat1 = New SqlDataAdapter("Sp_LlenaComboTipoUsuario", cnn)
                    sqldat1.Fill(EntidadUsuarios1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaUsuarios", cnn)
                    sqldat1.Fill(EntidadUsuarios1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    '    sqlcom1 = New SqlCommand("sp_ConsultaUsuariosBusqueda", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@NombreLote", EntidadUsuarios1.Lote))
                    '    sqldat1.Fill(EntidadUsuarios1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    '    sqlcom1 = New SqlCommand("sp_ConsultaUsuarios", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdTierra", EntidadUsuarios1.IdTierra))
                    '    sqldat1.Fill(EntidadUsuarios1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadUsuarios = EntidadUsuarios1
        End Try
    End Sub
End Class