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
Public Class RepVentaPacasResumen
    Dim IdVenta As Integer
    Public Sub New(ByVal Id As Integer)
        InitializeComponent()
        IdVenta = Id
    End Sub
    Private Sub RepCompraPacasResumen_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConsultaReporte()
    End Sub
    Private Sub ConsultaReporte()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTVenta = New RPTVenta
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTVenta.rpt"
        EntidadReportes.Reporte = Reporte.ReporteVentaPacasResumen
        EntidadReportes.IdVenta = IdVenta
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVReporteVentaResumen.ReportSource = CrReport
        CRVReporteVentaResumen.Show()
        'Sp_ReporteVentaResumen
    End Sub
End Class