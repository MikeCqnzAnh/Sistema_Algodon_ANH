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
        Dim CrReport As RPTContratoBE = New RPTContratoBE
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTContratoBE.rpt"
        EntidadReportes.Reporte = Reporte.ReporteContratoCompra
        EntidadReportes.IdContratoAlgodon = IdContratoAlgodon
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("Table1"))
        CRVContratoProductor.ReportSource = CrReport
    End Sub
End Class