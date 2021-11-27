﻿Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class PaquetesHVI
    Public Overridable Sub Upsert(ByRef EntidadPaquetesHVI As Capa_Entidad.PaquetesHVI)
        Dim EntidadPaquetesHVI1 As New Capa_Entidad.PaquetesHVI
        EntidadPaquetesHVI1 = EntidadPaquetesHVI
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadPaquetesHVI1.Guarda
                Case Capa_Operacion.Configuracion.Guardar.GuardarEncabezado
                    cmdGuardar = New SqlCommand("sp_InsertarPaquetesHVIEnc", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdHviEnc", EntidadPaquetesHVI1.IdPaqueteHVI))
                    cmdGuardar.Parameters.Add(New SqlParameter("@LotID", EntidadPaquetesHVI1.LotId))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CantidadPacas", EntidadPaquetesHVI1.NumeroPacas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadPaquetesHVI1.IdPlanta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadPaquetesHVI1.Fecha))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadPaquetesHVI1.IdEstatus))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadPaquetesHVI1.IdUsuarioCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadPaquetesHVI1.FechaCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadPaquetesHVI1.IdUsuarioActualizacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadPaquetesHVI1.FechaActualizacion))
                    cmdGuardar.Parameters("@IdHviEnc").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadPaquetesHVI1.IdPaqueteHVI = 0 Then
                        EntidadPaquetesHVI1.IdPaqueteHVI = cmdGuardar.Parameters("@IdHviEnc").Value
                    End If
                Case Capa_Operacion.Configuracion.Guardar.GuardarDetalle
                    cmdGuardar = New SqlCommand("sp_InsertarPaquetesHVIDet", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Clear()
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdHviDet", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdHviEnc", EntidadPaquetesHVI1.IdPaqueteHVI))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadPaquetesHVI1.IdPlanta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@LotID", EntidadPaquetesHVI1.LotId))
                    cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", EntidadPaquetesHVI1.BaleID))
                    cmdGuardar.Parameters.Add(New SqlParameter("@BaleGroup", EntidadPaquetesHVI1.BaleGroup))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Operator", EntidadPaquetesHVI1.Operatr))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Date", EntidadPaquetesHVI1.FechaAn))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Temperature", EntidadPaquetesHVI1.Temperature))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Humidity", EntidadPaquetesHVI1.Humidity))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Amount", EntidadPaquetesHVI1.Amount))
                    cmdGuardar.Parameters.Add(New SqlParameter("@UHML", EntidadPaquetesHVI1.UHML))
                    cmdGuardar.Parameters.Add(New SqlParameter("@UI", EntidadPaquetesHVI1.UI))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Strength", EntidadPaquetesHVI1.Strength))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Elongation", EntidadPaquetesHVI1.Elongation))
                    cmdGuardar.Parameters.Add(New SqlParameter("@SFI", EntidadPaquetesHVI1.SFI))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Maturity", EntidadPaquetesHVI1.Maturity))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Grade", EntidadPaquetesHVI1.Grade))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Moist", EntidadPaquetesHVI1.Moist))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Mic", EntidadPaquetesHVI1.Mic))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Rd", EntidadPaquetesHVI1.Rd))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Plusb", EntidadPaquetesHVI1.Plusb))
                    cmdGuardar.Parameters.Add(New SqlParameter("@ColorGrade", EntidadPaquetesHVI1.Colorgrade))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TrashCount", EntidadPaquetesHVI1.TrashCount))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TrashArea", EntidadPaquetesHVI1.TrashArea))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TrashID", EntidadPaquetesHVI1.TrashID))
                    cmdGuardar.Parameters.Add(New SqlParameter("@SCI", EntidadPaquetesHVI1.SCI))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Nep", EntidadPaquetesHVI1.Nep))
                    cmdGuardar.Parameters.Add(New SqlParameter("@UV", EntidadPaquetesHVI1.UV))
                    cmdGuardar.ExecuteNonQuery()
            End Select

            'If EntidadPaquetesHVI1.IdPaqueteHVI = 0 Then
            '    EntidadPaquetesHVI1.IdPaqueteHVI = cmdGuardar.Parameters("@IdHviEnc").Value
            '    For Each MiTableRow As DataRow In EntidadPaquetesHVI1.TablaGlobal.Rows
            '        cmdGuardar.CommandText = "sp_InsertarPaquetesHVIDet"
            '        cmdGuardar.CommandType = CommandType.StoredProcedure
            '        cmdGuardar.Parameters.Clear()
            '        cmdGuardar.Parameters.Add(New SqlParameter("@IdHviDet", 0))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@IdHviEnc", EntidadPaquetesHVI1.IdPaqueteHVI))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadPaquetesHVI1.IdPlanta))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@LotID", MiTableRow("LotID")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", MiTableRow("BaleID")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@BaleGroup", MiTableRow("BaleGroup")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Operator", MiTableRow("Operator")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Date", MiTableRow("Date")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Temperature", MiTableRow("Temperature")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Humidity", MiTableRow("Humidity")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Amount", MiTableRow("Amount")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@UHML", MiTableRow("UHML")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@UI", MiTableRow("UI")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Strength", MiTableRow("Strength")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Elongation", MiTableRow("Elongation")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@SFI", MiTableRow("SFI")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Maturity", MiTableRow("Maturity")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Grade", MiTableRow("Grade")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Moist", MiTableRow("Moist")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Mic", MiTableRow("Mic")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Rd", MiTableRow("Rd")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Plusb", MiTableRow("Plusb")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@ColorGrade", MiTableRow("ColorGrade")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@TrashCount", MiTableRow("TrashCount")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@TrashArea", MiTableRow("TrashArea")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@TrashID", MiTableRow("TrashID")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@SCI", MiTableRow("SCI")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Nep", MiTableRow("Nep")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@UV", MiTableRow("UV")))
            '        cmdGuardar.ExecuteNonQuery()
            '    Next
            'Else
            '    For Each MiTableRow As DataRow In EntidadPaquetesHVI1.TablaGlobal.Rows
            '        cmdGuardar.CommandText = "sp_InsertarPaquetesHVIDet"
            '        cmdGuardar.CommandType = CommandType.StoredProcedure
            '        cmdGuardar.Parameters.Clear()
            '        cmdGuardar.Parameters.Add(New SqlParameter("@IdHviDet", 0))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@IdHviEnc", EntidadPaquetesHVI1.IdPaqueteHVI))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadPaquetesHVI1.IdPlanta))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@LotID", MiTableRow("LotID")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", MiTableRow("BaleID")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@BaleGroup", MiTableRow("BaleGroup")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Operator", MiTableRow("Operator")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Date", MiTableRow("Date")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Temperature", MiTableRow("Temperature")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Humidity", MiTableRow("Humidity")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Amount", MiTableRow("Amount")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@UHML", MiTableRow("UHML")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@UI", MiTableRow("UI")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Strength", MiTableRow("Strength")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Elongation", MiTableRow("Elongation")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@SFI", MiTableRow("SFI")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Maturity", MiTableRow("Maturity")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Grade", MiTableRow("Grade")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Moist", MiTableRow("Moist")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Mic", MiTableRow("Mic")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Rd", MiTableRow("Rd")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Plusb", MiTableRow("Plusb")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@ColorGrade", MiTableRow("ColorGrade")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@TrashCount", MiTableRow("TrashCount")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@TrashArea", MiTableRow("TrashArea")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@TrashID", MiTableRow("TrashID")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@SCI", MiTableRow("SCI")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@Nep", MiTableRow("Nep")))
            '        cmdGuardar.Parameters.Add(New SqlParameter("@UV", MiTableRow("UV")))
            '        cmdGuardar.ExecuteNonQuery()
            '    Next
            'End If
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadPaquetesHVI = EntidadPaquetesHVI1
        End Try
    End Sub
    Public Overridable Sub UpsertIdOrden(ByRef EntidadPaquetesHVI As Capa_Entidad.PaquetesHVI)
        Dim EntidadPaquetesHVI1 As New Capa_Entidad.PaquetesHVI
        EntidadPaquetesHVI1 = EntidadPaquetesHVI
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_ActualizaIdOrdenTrabajoPaqueteHVI", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadPaquetesHVI1.IdPlanta))
            cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", EntidadPaquetesHVI1.BaleID))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex)
            cnn.Close()
        Finally
            cnn.Close()
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadPaquetesHVI As Capa_Entidad.PaquetesHVI)
        Dim EntidadPaquetesHVI1 As New Capa_Entidad.PaquetesHVI
        EntidadPaquetesHVI1 = EntidadPaquetesHVI
        EntidadPaquetesHVI1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadPaquetesHVI1.Consulta
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                '    sqldat1 = New SqlDataAdapter("sp_ConsultaContratosSemilla", cnn)
                '    sqldat1.Fill(EntidadContratoSemillas1.TablaConsulta)              
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaPlantas", cnn)
                    sqldat1.Fill(EntidadPaquetesHVI1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaPaquetesHVIDet", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPaquete", EntidadPaquetesHVI1.IdPaquete))
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadPaquetesHVI1.IdPlanta))
                    sqldat1.Fill(EntidadPaquetesHVI1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEncabezadoMatExt
                    sqlcom1 = New SqlCommand("Sp_ConsultaPaqueteHviEncabezado", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@LotId", EntidadPaquetesHVI1.LotId))
                    sqldat1.Fill(EntidadPaquetesHVI1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaLotIDPorPaca
                    sqlcom1 = New SqlCommand("Sp_ConsultaLotIDporPaca", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@BaleID", EntidadPaquetesHVI1.BaleID))
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadPaquetesHVI1.IdPlanta))
                    sqldat1.Fill(EntidadPaquetesHVI1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacaPlanta
                    sqlcom1 = New SqlCommand("sp_VerificaPacaPlantaProduccion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@FolioCIA", EntidadPaquetesHVI1.BaleID))
                    sqldat1.Fill(EntidadPaquetesHVI1.TablaConsulta)
            End Select
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadPaquetesHVI = EntidadPaquetesHVI1
        End Try
    End Sub
End Class
