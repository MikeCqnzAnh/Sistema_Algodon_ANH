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
Public Class RepClientes
    Private Sub RepClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
    End Sub
    Private Sub CargarCombos()
        '--Hace referencia a clientes para no repetir codigo en la capas que traen la misma informacion
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        Dim tabla As New DataTable
        EntidadClientes.Consulta = Consulta.ConsultaAsociaciones
        NegocioClientes.Consultar(EntidadClientes)
        tabla = EntidadClientes.TablaConsulta
        CbAsociaciones.DataSource = tabla
        CbAsociaciones.ValueMember = "IdAsociacion"
        CbAsociaciones.DisplayMember = "Descripcion"
        CbAsociaciones.SelectedValue = 1
    End Sub

    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTReporteClientes = New RPTReporteClientes
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTReporteClientes.rpt"
        EntidadReportes.Reporte = Reporte.ReporteClientes
        EntidadReportes.IdAsociacion = CbAsociaciones.SelectedValue
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVReporteClientes.ReportSource = CrReport
        CRVReporteClientes.Show()
    End Sub
End Class