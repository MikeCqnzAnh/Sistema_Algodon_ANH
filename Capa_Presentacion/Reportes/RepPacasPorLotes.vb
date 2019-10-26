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
Public Class RepPacasPorLotes
    Private Sub BtConsultar_Click_1(sender As Object, e As EventArgs) Handles BtConsultar.Click
        Consultar()
    End Sub

    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTPacasPorLotes = New RPTPacasPorLotes
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTPacasPorLotes.rpt"
        EntidadReportes.Reporte = Reporte.ReportePacasPorLote
        EntidadReportes.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVPacasPorLotes.ReportSource = CrReport
        CRVPacasPorLotes.Show()
    End Sub

    Private Sub TbIdOrdenTrabajo_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdOrdenTrabajo.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Consultar()
        End Select
    End Sub

    Private Sub TbIdOrdenTrabajo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdOrdenTrabajo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
End Class