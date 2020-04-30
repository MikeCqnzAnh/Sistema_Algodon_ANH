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
Public Class RepSalidaPacas
    Private Sub RepSalidaPacas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbIdSalida.Text = ""
        TbComprador.Text = ""
        CRVReporteSalida.ReportSource = Nothing
        CRVReporteSalida.Refresh()
        CargaReporteIdSalida(0, 0)
    End Sub
    'Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
    '    'Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
    '    'Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
    '    'Dim Tabla As New DataTable
    '    ConsultaSalidas.ShowDialog()
    '    If ConsultaOrdenEmbarque.Id = 0 Then
    '        Exit Sub
    '    End If
    '    CargaReporte(ConsultaOrdenEmbarque.Id)
    'End Sub
    Private Sub CargaReporteIdSalida(ByVal IdSalida As Integer, ByVal IdComprador As Integer)
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla, TablaGeneral As New Data.DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTSalidaPacas = New RPTSalidaPacas
        Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Reportes\RPT\RPTSalidaPacas.rpt"
        EntidadReportes.Reporte = Reporte.ReportePesosSalidaPacas
        EntidadReportes.IdSalidaPacas = IdSalida
        EntidadReportes.IdComprador = IdComprador
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVReporteSalida.ReportSource = CrReport
    End Sub
    Private Sub NueviToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NueviToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub BtIdSalida_Click(sender As Object, e As EventArgs) Handles BtIdSalida.Click
        TbComprador.Text = ""
        ConsultaSalidas.ShowDialog()
        If ConsultaOrdenEmbarque.Id = 0 Then
            Exit Sub
        End If
        TbIdSalida.Text = ConsultaOrdenEmbarque.Id
        CargaReporteIdSalida(TbIdSalida.Text, 0)
    End Sub
    Private Sub BtComprador_Click(sender As Object, e As EventArgs) Handles BtComprador.Click
        TbIdSalida.Text = ""
        ConsultaCompradoresSalidas.ShowDialog()
        If ConsultaCompradoresSalidas.Id = 0 Then
            Exit Sub
        End If
        TbComprador.Text = ConsultaCompradoresSalidas.Nombre
        CargaReporteIdSalida(0, ConsultaCompradoresSalidas.Id)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class