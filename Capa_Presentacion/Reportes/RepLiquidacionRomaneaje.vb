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
Public Class RepLiquidacionRomaneaje
    Private IdOrdenTrabajo As Integer
    Private CheckStatus As Boolean
    Public Sub New(ByVal ID As Integer, ByVal Check As Boolean)
        InitializeComponent()
        IdOrdenTrabajo = ID
        CheckStatus = Check
    End Sub
    Private Sub RepLiquidacionRomaneaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla, TablaGeneral As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTLiquidacionRomaneaje = New RPTLiquidacionRomaneaje
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTLiquidacionRomaneaje.rpt"
        EntidadReportes.Reporte = Reporte.ReporteLiquidacionRomaneaje
        EntidadReportes.IdOrdenTrabajo = IdOrdenTrabajo
        EntidadReportes.CheckStatus = CheckStatus
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)

        EntidadReportes.Reporte = Reporte.ReporteLiquidacionRomaneajeDet
        EntidadReportes.IdOrdenTrabajo = IdOrdenTrabajo
        EntidadReportes.CheckStatus = CheckStatus
        NegocioReportes.Consultar(EntidadReportes)
        TablaGeneral = EntidadReportes.TablaGeneral
        ds.Tables.Add(TablaGeneral)

        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CrReport.Subreports("SubReporteRomaneaje").SetDataSource(ds.Tables("Table2"))
        CRVLiquidacionRomanea.ReportSource = CrReport
    End Sub
End Class