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
Public Class RepInventarioPacas
    Dim Dgv As DataGridView
    Dim vPlanta As String
    Public Sub New(ByVal DgvPacas As DataGridView, ByVal Planta As String)
        InitializeComponent()
        Dgv = DgvPacas
        vPlanta = Planta
    End Sub
    Private Sub RepInventarioPacas_Load(sender As Object, e As EventArgs) Handles Me.Load
        todatatable()
    End Sub
    Private Sub todatatable()
        Dim ds As New DataSet
        Dim CrReport As RPTInventarioPacas = New RPTInventarioPacas
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTInventarioPacas.rpt"
        Dim dt As New DataTable
        With dt
            .Columns.Add("BaleID")
            .Columns.Add("Planta")
        End With
        For Each dr As DataGridViewRow In Dgv.Rows
            dt.Rows.Add(dr.Cells("BaleID").Value, vPlanta)
        Next
        ds.Tables.Add(dt)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables(0))
        CRVInventariopacas.ReportSource = CrReport
        CRVInventariopacas.Show()
    End Sub
End Class