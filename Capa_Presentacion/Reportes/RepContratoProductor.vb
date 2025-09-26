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

        Dim eDatosEmpresa As New Capa_Entidad.DatosEmpresa()
        Dim nDatosEmpresa As New Capa_Negocio.DatosEmpresa()

        Dim Tabla As New DataTable
        Dim tabla1 As New DataTable()
        Dim ds As New DataSet
        Dim CrReport As RPTContratoCompra = New RPTContratoCompra
        Dim Ruta As String = Path.Combine(Application.StartupPath & "\Reportes\RPT\RPTContratoCompra.rpt")

        eDatosEmpresa.Consulta = Consulta.ConsultaDatosEmpresa
        'eDatosEmpresa.idempresa = 1
        nDatosEmpresa.ConsultarEmpresa(eDatosEmpresa)
        tabla1 = eDatosEmpresa.TablaConsulta
        ds.Tables.Add(tabla1)

        EntidadReportes.Reporte = Reporte.ReporteContratoCompra
        EntidadReportes.IdContratoAlgodon = IdContratoAlgodon
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)


        CrReport.Load(Ruta)
        CrReport.Database.Tables("DatosEmpresa").SetDataSource(ds.Tables(0))
        CrReport.Database.Tables("ContratoCompraEmpresa").SetDataSource(ds.Tables(1))
        CRVContratoProductor.ReportSource = CrReport
    End Sub
End Class