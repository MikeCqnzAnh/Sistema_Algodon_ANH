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
Public Class RepProduccion
    Dim _IdOrdenTrabajo = New Integer
    Dim _IdProductor = New Integer
    Dim _IdPlanta = New Integer
    Dim _FechaIni = New DateTime
    Dim _FechaFin = New DateTime
    Public Sub New(ByVal IdOrdenTrabajo As Integer, ByVal IdProductor As Integer, ByVal IdPlanta As Integer, ByVal FechaIni As DateTime, ByVal FechaFin As DateTime)
        InitializeComponent()
        _IdOrdenTrabajo = IdOrdenTrabajo
        _IdProductor = IdProductor
        _IdPlanta = IdPlanta
        _FechaIni = FechaIni
        _FechaFin = FechaFin
    End Sub
    Private Sub RepResumenLiqVisPrev_Load(sender As Object, e As EventArgs) Handles Me.Load
        Consultar()
    End Sub
    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTResumenproduccion = New RPTResumenproduccion
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTResumenproduccion.rpt"
        EntidadReportes.Reporte = Reporte.ReporteResumenProduccion
        EntidadReportes.IdOrdenTrabajo = _IdOrdenTrabajo
        EntidadReportes.IdPlanta = _IdPlanta
        EntidadReportes.IdProductor = _IdProductor
        EntidadReportes.FechaIni = _FechaIni
        EntidadReportes.FechaFin = _FechaFin
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        If Tabla.Rows.Count > 0 Then
            ds.Tables.Add(Tabla)
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds.Tables("table1"))
            CRVReporteProduccion.ReportSource = CrReport
            CRVReporteProduccion.Show()
        Else
            MsgBox("No hay registros con los parametros aplicados!!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class