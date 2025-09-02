Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class InventarioPacas
    Public Overridable Sub Consultar(ByRef EntidadInventarioPacas As Capa_Entidad.InventarioPacas)
        Dim EntidadInventarioPacas1 = New Capa_Entidad.InventarioPacas
        EntidadInventarioPacas1 = EntidadInventarioPacas
        EntidadInventarioPacas1.TablaConsulta = New DataTable
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadInventarioPacas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEncabezado
                    sqlcom1 = New SqlCommand("Pa_ConsultaLotesPacas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadInventarioPacas1.IdComprador))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadInventarioPacas1.NoLote))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadInventarioPacas1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@SinComprador", EntidadInventarioPacas1.SinComprador))
                    sqlcom1.Parameters.Add(New SqlParameter("@SinLote", EntidadInventarioPacas1.SinLote))
                    sqldat1.Fill(EntidadInventarioPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Pa_ConsultaPacasporlote", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadInventarioPacas1.IdComprador))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadInventarioPacas1.NoLote))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadInventarioPacas1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@SinComprador", EntidadInventarioPacas1.SinComprador))
                    sqlcom1.Parameters.Add(New SqlParameter("@SinLote", EntidadInventarioPacas1.SinLote))
                    sqldat1.Fill(EntidadInventarioPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaComboLotes
                    sqlcom1 = New SqlCommand("Pa_ConsultaLotesInventario", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadInventarioPacas1.IdComprador))
                    sqldat1.Fill(EntidadInventarioPacas1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadInventarioPacas = EntidadInventarioPacas1
        End Try
    End Sub
End Class
