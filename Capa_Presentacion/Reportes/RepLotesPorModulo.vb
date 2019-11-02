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
Public Class RepLotesPorModulo
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        Consultar()
    End Sub
    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTModulosPorProductor = New RPTModulosPorProductor
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTModulosPorProductor.rpt"
        EntidadReportes.Reporte = Reporte.ReporteLotesPorModulo
        EntidadReportes.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CrLotesPorModulo.ReportSource = CrReport
        CrLotesPorModulo.Show()
    End Sub
    Private Sub TbIdOrdenTrabajo_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdOrdenTrabajo.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Consultar()
        End Select
    End Sub
End Class