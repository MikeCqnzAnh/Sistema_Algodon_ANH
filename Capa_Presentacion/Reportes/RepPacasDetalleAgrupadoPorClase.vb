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
Public Class RepPacasDetalleAgrupadoPorClase
    Private Sub BtDetallado_Click(sender As Object, e As EventArgs) Handles BtDetallado.Click
        Consultar()
    End Sub
    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTAgrupadoPorClase = New RPTAgrupadoPorClase
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTAgrupadoPorClase.rpt"
        EntidadReportes.Reporte = Reporte.ReportePacasDetalleAgrupadoPorClase
        EntidadReportes.IdProductor = IIf(TbIdCliente.Text = "", 0, TbIdCliente.Text)
        EntidadReportes.IdPlanta = CbPlantaOrigen.SelectedValue
        EntidadReportes.IdClase = CbClases.SelectedValue
        EntidadReportes.IdOrdenProduccion = CbOrdenProduccion.SelectedValue
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVRepPacasDetallado.ReportSource = CrReport
        CRVRepPacasDetallado.Show()
    End Sub
End Class