Imports System.Data.SqlClient
Public Class MenuPrincipal
    Public Overridable Sub Consultar(ByRef EntidadMenuPrincipal As Capa_Entidad.MenuPrincipal)
        Dim EntidadMenuPrincipal1 As New Capa_Entidad.MenuPrincipal
        EntidadMenuPrincipal1 = EntidadMenuPrincipal
        EntidadMenuPrincipal1.TablaConsulta = New DataTable
        'DataBase = EntidadMenuPrincipal1.BaseDeDatos
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadMenuPrincipal1.Consulta
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                '    sqldat1 = New SqlDataAdapter("sp_ListaBDD", cnn)
                '    sqldat1.Fill(EntidadMenuPrincipal1.TablaConsulta)
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                '    sqlcom1 = New SqlCommand("sp_ConsultaUltimaEtiquetaPorPlanta", cnn)
                '    sqldat1 = New SqlDataAdapter(sqlcom1)
                '    sqlcom1.CommandType = CommandType.StoredProcedure
                '    sqlcom1.Parameters.Clear()
                '    'sqlcom1.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadMenuPrincipal1.IdPlanta))
                '    sqldat1.Fill(EntidadMenuPrincipal1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaTipoDeCambio
                    sqlcom1 = New SqlCommand("Sp_ConsultaTipoDeCambio", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdMoneda", EntidadMenuPrincipal1.IdMoneda))
                    sqldat1.Fill(EntidadMenuPrincipal1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaFechaTipoCambio
                    sqlcom1 = New SqlCommand("Sp_ConsultaFechaTipoCambio", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Abreviacion", EntidadMenuPrincipal1.Abreviacion))
                    sqlcom1.Parameters.Add(New SqlParameter("@FechaHoy", EntidadMenuPrincipal1.FechaHoy))
                    sqldat1.Fill(EntidadMenuPrincipal1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadMenuPrincipal = EntidadMenuPrincipal1
        End Try
    End Sub
    Public Overridable Sub Actualizar(ByRef EntidadMenuPrincipal As Capa_Entidad.MenuPrincipal)
        Dim EntidadMenuPrincipal1 As New Capa_Entidad.MenuPrincipal()
        EntidadMenuPrincipal1 = EntidadMenuPrincipal
        'DataBase = EntidadMenuPrincipal1.BaseDeDatos
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadMenuPrincipal1.TablaConsulta = New DataTable()
        EntidadMenuPrincipal1.TablaGeneral = New DataTable()
        Dim cmdActualizar As SqlCommand
        'Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            cmdActualizar = New SqlCommand("Sp_ActualizaTipoCambioDiario", cnn)
            cmdActualizar.CommandType = CommandType.StoredProcedure
            cmdActualizar.Parameters.Clear()
            cmdActualizar.Parameters.Add(New SqlParameter("@TipoDeCambio", EntidadMenuPrincipal1.TipoDeCambio))
            cmdActualizar.Parameters.Add(New SqlParameter("@Abreviacion", EntidadMenuPrincipal1.Abreviacion))
            cmdActualizar.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        Finally
            cnn.Close()
            EntidadMenuPrincipal = EntidadMenuPrincipal1
        End Try
    End Sub
End Class
