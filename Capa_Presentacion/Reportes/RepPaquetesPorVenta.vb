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
Imports Excel = Microsoft.Office.Interop.Excel
Public Class RepPaquetesPorVenta
    Dim IdVenta As Integer
    Public Sub New(ByVal IdVen As Integer)
        InitializeComponent()
        IdVenta = IdVen
    End Sub
    Private Sub RepClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla, TablaGeneral As New Data.DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTPaquetesPorVenta = New RPTPaquetesPorVenta
        Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Reportes\RPT\RPTPaquetesPorVenta.rpt"
        EntidadReportes.Reporte = Reporte.ReportePaquetePorVenta
        EntidadReportes.IdVenta = IdVenta
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVPaqVenta.ReportSource = CrReport
    End Sub
End Class