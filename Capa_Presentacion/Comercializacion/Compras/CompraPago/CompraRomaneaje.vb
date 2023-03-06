Imports System.Data.SqlClient
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
Public Class CompraRomaneaje
    Private IdCompra As Integer
    Public Sub New(ByVal ID As Integer)
        InitializeComponent()
        IdCompra = ID
    End Sub
    Private Sub CompraRomaneaje_Load(sender As Object, e As EventArgs) Handles Me.Load
        consultacompraromaneaje()
    End Sub
    Private Sub consultacompraromaneaje()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla, TablaGeneral As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTRomaneajeporCompr = New RPTRomaneajeporCompr
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTRomaneajeporCompr.rpt"
        EntidadReportes.Reporte = Reporte.ReporteRomaneajeCompraEnc
        EntidadReportes.IdCompra = IdCompra
        EntidadReportes.CheckStatus = ckdetalles.Checked
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)

        EntidadReportes.Reporte = Reporte.ReporteRomaneajeCompraDet
        EntidadReportes.IdCompra = IdCompra
        'EntidadReportes.IdOrdenTrabajo =
        EntidadReportes.CheckStatus = ckdetalles.Checked
        NegocioReportes.Consultar(EntidadReportes)
        TablaGeneral = EntidadReportes.TablaGeneral
        ds.Tables.Add(TablaGeneral)

        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CrReport.Subreports("SubReporteRomaneaje").SetDataSource(ds.Tables("Table2"))
        CRVReporteCompraRomaneaje.ReportSource = CrReport
    End Sub
    Private Sub btconsultar_Click(sender As Object, e As EventArgs) Handles btconsultar.Click
        consultacompraromaneaje()
    End Sub
End Class