﻿Imports Capa_Operacion.Configuracion
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Management
Imports Microsoft.Office.Interop
Public Class RepPacasSinComprar
    Private Sub RepPacasSinComprar_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
        Limpiar()
    End Sub
    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        LlenaDgv("")
    End Sub
    Private Sub Limpiar()
        DgvPacasSinComprar.DataSource = ""
        CbClase.SelectedIndex = -1
        CbPlanta.SelectedIndex = -1
        TbCantidadPacas.Text = ""
        TbRangoInicio.Text = ""
        TbRangoFin.Text = ""
    End Sub
    Private Sub CargaCombos()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = 0
        '-----------------------------------------------
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        CbClase.DataSource = Tabla2
        CbClase.ValueMember = "IdClasificacion"
        CbClase.DisplayMember = "ClaveCorta"
        CbClase.SelectedValue = 0
    End Sub
    Private Sub BtConsultarExcel_Click(sender As Object, e As EventArgs) Handles BtConsultarExcel.Click
        CargaExcel.ShowDialog()
        Dim valor As String = String.Empty
        Try
            If TablaExcel.Rows.Count > 0 Then
                For Each rowTabla As DataRow In TablaExcel.Rows
                    valor &= rowTabla(0) & ","
                Next
                valor = valor.TrimEnd(",")
                LlenaDgv(valor)
            End If
            If TablaExcel.Rows.Count > 0 Then TablaExcel.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LlenaDgv(ByVal valor As String)
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        EntidadReportes.Reporte = Reporte.ReportePacasSinComprar
        EntidadReportes.Valor = valor
        EntidadReportes.IdPlanta = CbPlanta.SelectedValue
        EntidadReportes.Clase = CbClase.Text
        NegocioReportes.Consultar(EntidadReportes)
        DgvPacasSinComprar.DataSource = EntidadReportes.TablaConsulta
        TbCantidadPacas.Text = DgvPacasSinComprar.RowCount
    End Sub
    Private Sub ExportaAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportaAExcelToolStripMenuItem.Click
        If DgvPacasSinComprar.RowCount > 0 Then
            ExportExcel(DgvPacasSinComprar)
        Else
            MsgBox("No hay registros para exportar.", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

End Class