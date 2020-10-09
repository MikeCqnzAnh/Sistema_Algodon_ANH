Imports System.Data.SqlClient
Public Class CompraPacas
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
    Public Overridable Sub Consultar(ByRef EntidadCompraPacas As Capa_Entidad.VentaPacas)
        Dim EntidadCompraPacas1 As New Capa_Entidad.VentaPacas
        EntidadCompraPacas1 = EntidadCompraPacas
        EntidadCompraPacas1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCompraPacas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaPlantas", cnn)
                    sqldat1.Fill(EntidadCompraPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaProductores
                    sqldat1 = New SqlDataAdapter("sp_ConsultaProductoresTotal", cnn)
                    sqldat1.Fill(EntidadCompraPacas1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCompraPacas = EntidadCompraPacas1
        End Try
    End Sub
End Class
