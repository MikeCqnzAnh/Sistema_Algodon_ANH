﻿Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class RepCastigoPorRangos
    Private IdModMicros As Integer
    Private IdModResistencia As Integer
    Private IdModLargo As Integer
    Private IdModUniformidad As Integer
    Private IDVenta As Integer
    Public Sub New(ByVal ID As Integer, IdModoMic As Integer, ByVal IdModoRes As Integer, ByVal IdModoLar As Integer, ByVal IdModoUni As Integer)
        InitializeComponent()
        IDVenta = ID
        IdModMicros = IdModoMic
        IdModResistencia = IdModoRes
        IdModLargo = IdModoLar
        IdModUniformidad = IdModoUni
    End Sub
    Private Function tablaidventa()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim i As Integer = 0
        dt.Columns.Add(New DataColumn("IdVenta", GetType(Int64)))

        dr = dt.NewRow()
        dr("IdVenta") = IDVenta
        dt.Rows.Add(dr)

        Return dt
    End Function
    Private Sub RepCastigoRangos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla, TablaGeneral As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTCastigoPorRangos = New RPTCastigoPorRangos
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTCastigoPorRangos.rpt"

        ds.Tables.Add(tablaidventa)

        EntidadReportes.Reporte = Reporte.ReporteRangoCastigolar
        EntidadReportes.IdVenta = IDVenta
        EntidadReportes.IdModoEncabezado = IdModLargo
        NegocioReportes.Consultar(EntidadReportes)
        TablaGeneral = EntidadReportes.TablaConsulta
        ds.Tables.Add(TablaGeneral)

        EntidadReportes.Reporte = Reporte.ReporteRangoCastigomic
        EntidadReportes.IdVenta = IDVenta
        EntidadReportes.IdModoEncabezado = IdModMicros
        NegocioReportes.Consultar(EntidadReportes)
        TablaGeneral = EntidadReportes.TablaConsulta
        ds.Tables.Add(TablaGeneral)

        EntidadReportes.Reporte = Reporte.ReporteRangoCastigores
        EntidadReportes.IdVenta = IDVenta
        EntidadReportes.IdModoEncabezado = IdModResistencia
        NegocioReportes.Consultar(EntidadReportes)
        TablaGeneral = EntidadReportes.TablaConsulta
        ds.Tables.Add(TablaGeneral)

        EntidadReportes.Reporte = Reporte.ReporteRangoCastigouni
        EntidadReportes.IdVenta = IDVenta
        EntidadReportes.IdModoEncabezado = IdModUniformidad
        NegocioReportes.Consultar(EntidadReportes)
        TablaGeneral = EntidadReportes.TablaConsulta
        ds.Tables.Add(TablaGeneral)

        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CrReport.Subreports("SubReporteLar").SetDataSource(ds.Tables("Table2"))
        CrReport.Subreports("SubReporteMic").SetDataSource(ds.Tables("Table3"))
        CrReport.Subreports("SubReporteRes").SetDataSource(ds.Tables("Table4"))
        CrReport.Subreports("SubReporteUni").SetDataSource(ds.Tables("Table5"))
        CRVCastigoporrangos.ReportSource = CrReport
    End Sub
End Class