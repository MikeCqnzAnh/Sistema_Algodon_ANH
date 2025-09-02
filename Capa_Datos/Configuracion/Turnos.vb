Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class Turnos

    Public Overridable Sub Upsert(ByRef EntidadTurnos As Capa_Entidad.Turnos)
        Dim EntidadTurnos1 As New Capa_Entidad.Turnos
        EntidadTurnos1 = EntidadTurnos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("pa_insertaturnoenc", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@idturnoenc", EntidadTurnos1.idturnoenc))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadTurnos1.descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@idplanta", EntidadTurnos1.idplanta))
            cmdGuardar.Parameters.Add(New SqlParameter("@horaentrada", EntidadTurnos1.horaentrada))
            cmdGuardar.Parameters.Add(New SqlParameter("@horasalida", EntidadTurnos1.horasalida))
            cmdGuardar.Parameters("@idturnoenc").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadTurnos1.idturnoenc = 0 Then
                EntidadTurnos1.idturnoenc = cmdGuardar.Parameters("@idturnoenc").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadTurnos = EntidadTurnos1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadTurnos As Capa_Entidad.Turnos)
        Dim EntidadTurnos1 = New Capa_Entidad.Turnos
        EntidadTurnos1 = EntidadTurnos
        EntidadTurnos1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadTurnos1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEncabezado
                    sqldat1 = New SqlDataAdapter("pa_consultaturnosenc", cnn)
                    sqldat1.Fill(EntidadTurnos1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    '    sqlcom1 = New SqlCommand("Sp_ConsultaMicrosDetalle", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdMicrosEncabezado", EntidadTurnos1.IdMicrosEncabezado))
                    '    sqldat1.Fill(EntidadTurnos1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadTurnos = EntidadTurnos1
        End Try
    End Sub
End Class
