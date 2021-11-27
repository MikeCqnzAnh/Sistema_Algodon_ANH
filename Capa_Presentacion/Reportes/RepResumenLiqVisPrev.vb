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
Public Class RepResumenLiqVisPrev
    Dim _IdProductor = New Integer
    Dim _IdPlanta = New Integer
    Dim _Desde = New Integer
    Dim _Hasta = New Integer
    Public Sub New(ByVal IdProductor As Integer, ByVal IdPlanta As Integer, ByVal Desde As Integer, ByVal Hasta As Integer)
        InitializeComponent()
        _IdProductor = IdProductor
        _IdPlanta = IdPlanta
        _Desde = Desde
        _Hasta = Hasta
    End Sub
    Private Sub RepResumenLiqVisPrev_Load(sender As Object, e As EventArgs) Handles Me.Load
        Consultar()
    End Sub
    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTResumenLiquidaciones = New RPTResumenLiquidaciones
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTResumenLiquidaciones.rpt"
        EntidadReportes.Reporte = Reporte.ReporteResumenLiqGeneral
        EntidadReportes.IdPlanta = _IdPlanta
        EntidadReportes.IdProductor = _IdProductor
        EntidadReportes.Desde = _Desde
        EntidadReportes.Hasta = _Hasta
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        If Tabla.Rows.Count > 0 Then
            ds.Tables.Add(Tabla)
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds.Tables("table1"))
            CRVResumenLiquidacion.ReportSource = CrReport
            CRVResumenLiquidacion.Show()
        Else
            MsgBox("No hay registros con los parametros aplicados!!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class