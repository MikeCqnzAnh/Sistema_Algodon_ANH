Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class ConfigMic
    Public Overridable Sub Upsert(ByRef EntidadConfigMic As Capa_Entidad.ConfigMic)
        Dim EntidadConfigMic1 As New Capa_Entidad.ConfigMic
        EntidadConfigMic1 = EntidadConfigMic
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertaMicrosEncabezado", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadConfigMic1.IdMicrosEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadConfigMic1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@ModoComercializacion", EntidadConfigMic1.IdModoComercializacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadConfigMic1.IdEstatus))
            cmdGuardar.Parameters("@IdModoEncabezado").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadConfigMic1.IdMicrosEncabezado = 0 Then
                EntidadConfigMic1.IdMicrosEncabezado = cmdGuardar.Parameters("@IdModoEncabezado").Value
            End If
            For Each MiTableRow As DataRow In EntidadConfigMic1.TablaModosDetalle.Rows
                cmdGuardar.CommandText = "sp_InsertaMicrosDetalle"
                cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Clear()
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoDetalle", MiTableRow("IdModoDetalle")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadConfigMic1.IdMicrosEncabezado))
                cmdGuardar.Parameters.Add(New SqlParameter("@Rango1", MiTableRow("Rango1")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Rango2", MiTableRow("Rango2")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Castigo", MiTableRow("Castigo")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", MiTableRow("IdEstatus")))
                cmdGuardar.ExecuteNonQuery()
            Next
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadConfigMic = EntidadConfigMic1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadConfigMic As Capa_Entidad.ConfigMic)
        Dim EntidadConfigMic1 = New Capa_Entidad.ConfigMic
        EntidadConfigMic1 = EntidadConfigMic
        EntidadConfigMic1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadConfigMic1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEncabezado
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaMicrosEncabezado", cnn)
                    sqldat1.Fill(EntidadConfigMic1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Sp_ConsultaMicrosDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdMicrosEncabezado", EntidadConfigMic1.IdMicrosEncabezado))
                    sqldat1.Fill(EntidadConfigMic1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadConfigMic = EntidadConfigMic1
        End Try
    End Sub
End Class
