Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class ClasificacionPacasExcel
    Public Overridable Sub Upsert(ByRef EntidadClasificacionPacasExcel As Capa_Entidad.ClasificacionPacasExcel)
        Dim EntidadClasificacionPacasExcel1 As New Capa_Entidad.ClasificacionPacasExcel
        EntidadClasificacionPacasExcel1 = EntidadClasificacionPacasExcel
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As New SqlCommand
        Try
            cnn.Open()
            For Each MiTableRow As DataRow In EntidadClasificacionPacasExcel1.TablaGeneral.Rows
                cmdGuardar = New SqlCommand("sp_InsertarClasificacionPacas", cnn)
                cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Clear()
                cmdGuardar.Parameters.Add(New SqlParameter("@IdCalculoClasificacion", 0))
                cmdGuardar.Parameters.Add(New SqlParameter("@BaleId", MiTableRow("BaleId")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Mic", MiTableRow("Mic")))
                cmdGuardar.Parameters.Add(New SqlParameter("@ColorGrade", MiTableRow("ColorGrade")))
                cmdGuardar.Parameters.Add(New SqlParameter("@TrashId", MiTableRow("TrashId")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Clase", MiTableRow("Clase")))
                cmdGuardar.Parameters.Add(New SqlParameter("@UHML", MiTableRow("UHML")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Strength", MiTableRow("Strength")))
                cmdGuardar.Parameters.Add(New SqlParameter("@SCI", MiTableRow("SCI")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdHviDetalle", MiTableRow("IdHviDetalle")))
                cmdGuardar.ExecuteNonQuery()
            Next
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadClasificacionPacasExcel = EntidadClasificacionPacasExcel1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadClasificacionPacasExcel As Capa_Entidad.ClasificacionPacasExcel)
        Dim EntidadClasificacionPacasExcel1 As New Capa_Entidad.ClasificacionPacasExcel
        EntidadClasificacionPacasExcel1 = EntidadClasificacionPacasExcel
        EntidadClasificacionPacasExcel1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadClasificacionPacasExcel1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                    For Each MiTableRow As DataRow In EntidadClasificacionPacasExcel1.TablaBaleID.Rows
                        sqlcom1 = New SqlCommand("Sp_CargaPacasExcel", cnn)
                        sqldat1 = New SqlDataAdapter(sqlcom1)
                        sqlcom1.CommandType = CommandType.StoredProcedure
                        sqlcom1.Parameters.Clear()
                        sqlcom1.Parameters.Add(New SqlParameter("@baleid", MiTableRow("BaleID")))
                        sqldat1.Fill(EntidadClasificacionPacasExcel1.TablaConsulta)
                    Next
                Case Capa_Operacion.Configuracion.Consulta.ConsultaClases
                    sqldat1 = New SqlDataAdapter("sp_LlenarComboClases", cnn)
                    sqldat1.Fill(EntidadClasificacionPacasExcel1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadClasificacionPacasExcel = EntidadClasificacionPacasExcel1
        End Try
    End Sub
End Class
