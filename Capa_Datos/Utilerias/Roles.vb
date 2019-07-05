Imports System.Data.SqlClient
Public Class Roles
    Public Overridable Sub Consultar(ByRef EntidadRoles As Capa_Entidad.Roles)
        Dim EntidadRoles1 = New Capa_Entidad.Roles
        EntidadRoles1 = EntidadRoles
        EntidadRoles1.TablaConsulta = New DataTable
        EntidadRoles1.TablaGeneral = New DataTable
        EntidadRoles1.TablaOpciones = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadRoles1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaMenuEncabezado", cnn)
                    sqldat1.Fill(EntidadRoles1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Sp_ConsultaMenuDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdMenuEncabezado", EntidadRoles1.IdMenuEncabezado))
                    sqldat1.Fill(EntidadRoles1.TablaGeneral)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOpciones
                    sqlcom1 = New SqlCommand("Sp_OpcionesSubMenu", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdMenuDetalle", EntidadRoles1.IdMenuDetalle))
                    sqldat1.Fill(EntidadRoles1.TablaOpciones)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadRoles = EntidadRoles1
        End Try
    End Sub
End Class
