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
Public Class RepCompraPacasResumen
    Dim IdCompra As Integer
    Public Sub New(ByVal Id As Integer)
        InitializeComponent()
        IdCompra = Id
    End Sub
    Private Sub RepCompraPacasResumen_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConsultaReporte()
    End Sub
    Private Sub ConsultaReporte()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTCompra = New RPTCompra
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTCompra.rpt"
        EntidadReportes.Reporte = Reporte.ReporteCompraPacasResumen
        EntidadReportes.IdCompra = IdCompra
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVReporteCompraResumen.ReportSource = CrReport
        CRVReporteCompraResumen.Show()
    End Sub
End Class