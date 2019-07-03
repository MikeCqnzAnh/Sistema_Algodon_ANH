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
Public Class RepContratoProductor
    Private IdContratoAlgodon As Integer
    Public Sub New(ByVal ID As Integer)
        InitializeComponent()
        IdContratoAlgodon = ID
    End Sub
    Private Sub RepContratoProductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTContratoBuenaEsperanza = New RPTContratoBuenaEsperanza
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTContratoBuenaEsperanza.rpt"
        EntidadReportes.Reporte = Reporte.ReporteContratoCompra
        EntidadReportes.IdContratoAlgodon = IdContratoAlgodon
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVContratoProductor.ReportSource = CrReport
    End Sub
End Class