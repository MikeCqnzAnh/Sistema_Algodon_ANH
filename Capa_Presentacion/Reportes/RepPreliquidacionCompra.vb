Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
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
Public Class RepPreliquidacionCompra
    Dim _tablePreCompra = New DataTable
    Public Sub New(ByVal Tableprec As DataTable)
        InitializeComponent()
        _tablePreCompra = Tableprec
    End Sub
    Private Sub RepPreliquidacionCompra_Load(sender As Object, e As EventArgs) Handles Me.Load
        Consultar()
    End Sub
    Private Sub Consultar()
        'Dim EntidadReportes As New Capa_Entidad.Reportes
        'Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds = New DataSet
        Dim CrReport As RPTPreliquidacionCompra = New RPTPreliquidacionCompra
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTPreliquidacionCompra.rpt"
        'EntidadReportes.Reporte = Reporte.ReporteClientes
        'NegocioReportes.Consultar(EntidadReportes)
        Tabla = _tablePreCompra.copy()
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVReportePreliquidacion.ReportSource = CrReport
        CRVReportePreliquidacion.Show()
    End Sub
End Class