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
Public Class RepPaquetesVenta
    Private Sub RepPaquetesVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
        Limpiar()
    End Sub
    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub TbIdPaquete_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdPaquete.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Consultar()
        End Select
    End Sub
    Private Sub Limpiar()
        TbIdPaquete.Text = ""
        TbCantidadPacas.Text = ""
        CbClase.SelectedValue = -1
        CbPlanta.SelectedValue = -1
        CkMayor.Checked = False
        CkMenor.Checked = False
        CRVPaquetesVenta.ReportSource = Nothing
    End Sub
    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTPaquetesVenta = New RPTPaquetesVenta
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTPaquetesVenta.rpt"
        EntidadReportes.Reporte = Reporte.ReportePaquetesVenta
        EntidadReportes.IdPaquete = Val(TbIdPaquete.Text)
        EntidadReportes.IdPlanta = CbPlanta.SelectedValue
        EntidadReportes.CantidadPacas = Val(TbCantidadPacas.Text)
        EntidadReportes.IdComprador = 0
        EntidadReportes.IdClase = CbClase.SelectedValue
        EntidadReportes.Mayor = CkMayor.Checked
        EntidadReportes.Menor = CkMenor.Checked
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        If Tabla.Rows.Count > 0 Then
            ds.Tables.Add(Tabla)
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds.Tables("table1"))
            CRVPaquetesVenta.ReportSource = CrReport
            CRVPaquetesVenta.Show()
        Else
            MsgBox("No hay registros con los parametros aplicados!!", MsgBoxStyle.Exclamation)
        End If
    End Sub
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
        '-----------------------------------------------
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        CbClase.DataSource = Tabla2
        CbClase.ValueMember = "IdClasificacion"
        CbClase.DisplayMember = "ClaveCorta"
    End Sub
    Private Sub TbCantidadPacas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbCantidadPacas.KeyPress, TbIdPaquete.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        Consultar()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class