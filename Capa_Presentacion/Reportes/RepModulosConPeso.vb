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
Public Class RepModulosConPeso
    Dim _IdOrdenTrabajo = New Integer
    Public Sub New(ByVal IdOrdenTrabajo As Integer)
        InitializeComponent()
        _IdOrdenTrabajo = IdOrdenTrabajo
    End Sub
    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTModulosConPeso = New RPTModulosConPeso
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTModulosConPeso.rpt"
        EntidadReportes.Reporte = Reporte.ReporteModulosDetallePeso
        EntidadReportes.IdOrdenTrabajo = _IdOrdenTrabajo
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        If Tabla.Rows.Count > 0 Then
            ds.Tables.Add(Tabla)
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds.Tables("table1"))
            CRVReporteModulos.ReportSource = CrReport
            CRVReporteModulos.Show()
        Else
            MsgBox("No hay registros con los parametros aplicados!!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub CRVReporteModulos_Load(sender As Object, e As EventArgs) Handles CRVReporteModulos.Load
        Consultar()
    End Sub
End Class