Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
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
Public Class RepClasesVenta
    Dim IdPaquete As Integer
    Public Sub New(ByVal Idpaq As Integer)
        InitializeComponent()
        IdPaquete = Idpaq
    End Sub
    Private Sub RepClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRVClasesVenta.ReportSource = Nothing
        Consulta()
    End Sub
    Private Sub Consulta()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla, TablaGeneral As New Data.DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTClasesVenta = New RPTClasesVenta
        Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Reportes\RPT\RPTClasesVenta.rpt"
        EntidadReportes.Reporte = Reporte.ReporteClasesVenta
        EntidadReportes.IdPaquete = IdPaquete
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVClasesVenta.ReportSource = CrReport
    End Sub
End Class