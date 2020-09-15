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
Public Class RepPacasFaltantes
    Private Sub CargaCombos()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = -1
    End Sub
    Private Sub RepPacasFaltantes_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TbFolioFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles TbFolioFinal.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Consultar()
        End Select
    End Sub
    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTPacasFaltantes = New RPTPacasFaltantes
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTPacasFaltantes.rpt"
        EntidadReportes.Reporte = Reporte.ReportePacasFaltantes
        EntidadReportes.IdPlanta = IIf(CbPlanta.SelectedValue = Nothing, 0, CbPlanta.SelectedValue)
        EntidadReportes.PacaInicial = IIf(TbFolioInicial.Text = "", 0, TbFolioInicial.Text)
        EntidadReportes.PacaFinal = IIf(TbFolioFinal.Text = "", 0, TbFolioFinal.Text)
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        If Tabla.Rows.Count > 0 Then
            ds.Tables.Add(Tabla)
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds.Tables("table1"))
            CRVPacasFaltantes.ReportSource = CrReport
            CRVPacasFaltantes.Show()
        Else
            MsgBox("No hay registros con los parametros aplicados!!", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub ValidaNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbFolioInicial.KeyPress, TbFolioFinal.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        Consultar()
    End Sub
End Class