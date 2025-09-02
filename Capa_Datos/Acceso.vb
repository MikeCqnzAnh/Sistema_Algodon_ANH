Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class Acceso
    Public Overridable Sub Consultar(ByRef EntidadAcceso As Capa_Entidad.Acceso)
        Dim EntidadAcceso1 As New Capa_Entidad.Acceso
        EntidadAcceso1 = EntidadAcceso
        EntidadAcceso1.TablaConsulta = New DataTable
        'DataBase = EntidadAcceso1.BaseDeDatos
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        'Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cnn As New SqlConnection(conexionPrincipal)

        Try
            cnn.Open()
            Select Case EntidadAcceso1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ListaBDD", cnn)
                    sqldat1.Fill(EntidadAcceso1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                    sqlcom1 = New SqlCommand("sp_ConsultaUltimaEtiquetaPorPlanta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadAcceso1.IdPlanta))
                    sqldat1.Fill(EntidadAcceso1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOrden
                    sqlcom1 = New SqlCommand("sp_ConsultaOrdenProduccion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdProduccion", EntidadAcceso1.IdProduccion))
                    sqldat1.Fill(EntidadAcceso1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadAcceso = EntidadAcceso1
        End Try
    End Sub
    Public Overridable Sub ConsultarPerfiles(ByRef EntidadAcceso As Capa_Entidad.Acceso)
        Dim EntidadAcceso1 As New Capa_Entidad.Acceso
        EntidadAcceso1 = EntidadAcceso
        EntidadAcceso1.TablaConsulta = New DataTable
        If EntidadAcceso1.BaseDeDatos <> Nothing Then DataBase = EntidadAcceso1.BaseDeDatos
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        'Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cnn As New SqlConnection(conexionPerfiles)

        Try
            cnn.Open()
            Select Case EntidadAcceso1.Consulta
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                '    sqldat1 = New SqlDataAdapter("sp_ListaBDD", cnn)
                '    sqldat1.Fill(EntidadAcceso1.TablaConsulta)
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                '    sqlcom1 = New SqlCommand("sp_ConsultaUltimaEtiquetaPorPlanta", cnn)
                '    sqldat1 = New SqlDataAdapter(sqlcom1)
                '    sqlcom1.CommandType = CommandType.StoredProcedure
                '    sqlcom1.Parameters.Clear()
                '    'sqlcom1.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadAcceso1.IdPlanta))
                '    sqldat1.Fill(EntidadAcceso1.TablaConsulta)
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaOrden
                '    sqlcom1 = New SqlCommand("sp_ConsultaOrdenProduccion", cnn)
                '    sqldat1 = New SqlDataAdapter(sqlcom1)
                '    sqlcom1.CommandType = CommandType.StoredProcedure
                '    sqlcom1.Parameters.Clear()
                '    'sqlcom1.Parameters.Add(New SqlParameter("@IdProduccion", EntidadAcceso1.IdProduccion))
                '    sqldat1.Fill(EntidadAcceso1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaUsuario
                    sqlcom1 = New SqlCommand("Sp_ConsultaUsuario", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Usuario", EntidadAcceso1.Usuario))
                    sqldat1.Fill(EntidadAcceso1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaClaveAutorizacion
                    sqlcom1 = New SqlCommand("Sp_ConsultaClaveAutorizacion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    'sqlcom1.Parameters.Add(New SqlParameter("@Usuario", EntidadAcceso1.Usuario))
                    sqldat1.Fill(EntidadAcceso1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadAcceso = EntidadAcceso1
        End Try
    End Sub
    Public Overridable Sub ActualizarPerfiles(ByRef EntidadAcceso As Capa_Entidad.Acceso)
        Dim EntidadAcceso1 As New Capa_Entidad.Acceso
        EntidadAcceso1 = EntidadAcceso
        EntidadAcceso1.TablaConsulta = New DataTable
        DataBase = EntidadAcceso1.BaseDeDatos
        Dim cmdGuardar As SqlCommand
        'Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cnn As New SqlConnection(conexionPerfiles)
        Try
            cnn.Open()
            Select Case EntidadAcceso1.Actualiza
                Case Capa_Operacion.Configuracion.Actualiza.ActualizaClaveAutorizacion
                    cmdGuardar = New SqlCommand("Sp_ActualizaClaveActualizacion", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.ExecuteNonQuery()
            End Select
        Catch ex As Exception
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadAcceso = EntidadAcceso1
        End Try
    End Sub
End Class
