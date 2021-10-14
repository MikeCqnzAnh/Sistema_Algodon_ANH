Imports System.Data.SqlClient
Imports Capa_Entidad
Imports Capa_Operacion.Configuracion
Public Class Roles
    Public Overridable Sub Consultar(ByRef EntidadRoles As Capa_Entidad.Roles)
        Dim EntidadRoles1 = New Capa_Entidad.Roles
        EntidadRoles1 = EntidadRoles
        EntidadRoles1.TablaConsulta = New DataTable
        EntidadRoles1.TablaGeneral = New DataTable
        EntidadRoles1.TablaOpciones = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPerfiles)
        Try
            cnn.Open()
            Select Case EntidadRoles1.Consulta
                Case Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaMenuRoles", cnn)
                    sqldat1.Fill(EntidadRoles1.TablaConsulta)
                Case Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Sp_ConsultaRolesPredefinidos", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdUsuario", EntidadRoles1.IdUsuario))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdTipoUsuario", EntidadRoles1.IdTipoUsuario))
                    sqldat1.Fill(EntidadRoles1.TablaConsulta)
                Case Consulta.ConsultaPerfilUsuario
                    sqlcom1 = New SqlCommand("Sp_ConsultaPerfilUsuario", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdUsuario", EntidadRoles1.IdUsuario))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdTipoUsuario", EntidadRoles1.IdTipoUsuario))
                    sqldat1.Fill(EntidadRoles1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadRoles = EntidadRoles1
        End Try
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadRoles As Capa_Entidad.Roles)
        Dim EntidadRoles1 As New Capa_Entidad.Roles
        EntidadRoles1 = EntidadRoles
        Dim cnn As New SqlConnection(conexionPerfiles)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadRoles1.Agrega
                Case Capa_Operacion.Configuracion.Agrega.AgregOpcion
                    cmdGuardar = New SqlCommand("Sp_InsertarOpcionRol", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdMenuRoles", EntidadRoles1.IdMenuRoles))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadRoles1.Descripcion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPadre", EntidadRoles1.IdPadre))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadRoles1.IdEstatus))
                    cmdGuardar.Parameters("@IdMenuRoles").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadRoles1.IdMenuRoles = 0 Then
                        EntidadRoles1.IdMenuRoles = cmdGuardar.Parameters("@IdMenuRoles").Value
                    End If
                Case Capa_Operacion.Configuracion.Agrega.AgregaRol
                    cmdGuardar = New SqlCommand("Sp_InsertaPerfilUsuario", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPerfilUsuario", EntidadRoles1.IdPerfilUsuario))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuario", EntidadRoles1.IdUsuario))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdNodo", EntidadRoles1.IdNodo))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPadre", EntidadRoles1.IdPadre))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoUsuario", EntidadRoles1.IdTipoUsuario))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadRoles1.IdEstatus))
                    'cmdGuardar.Parameters("@IdMenuRoles").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                Case Capa_Operacion.Configuracion.Agrega.AgregaRolPredefinido
                    cmdGuardar = New SqlCommand("Sp_InsertaPerfilUsuarioPredefinido", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPerfilUsuario", EntidadRoles1.IdPerfilUsuario))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuario", EntidadRoles1.IdUsuario))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdNodo", EntidadRoles1.IdNodo))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPadre", EntidadRoles1.IdPadre))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoUsuario", EntidadRoles1.IdTipoUsuario))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadRoles1.IdEstatus))
                    'cmdGuardar.Parameters("@IdMenuRoles").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
            End Select

        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadRoles = EntidadRoles1
        End Try
    End Sub
End Class
