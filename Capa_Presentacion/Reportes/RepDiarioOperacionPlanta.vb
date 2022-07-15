Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Public Class RepDiarioOperacionPlanta
    Private Sub RepDiarioOperacionPlanta_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargareporte()
    End Sub
    Private Sub cargareporte()
        'Dim EntidadReportes As New Capa_Entidad.Reportes
        'Dim NegocioReportes As New Capa_Negocio.Reportes
        'Dim Tabla As New DataTable
        'Dim ds As New DataSet
        Dim CrReport As New RPTDiariooperacion
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTDiariooperacion.rpt"
        'EntidadReportes.Reporte = Reporte.ReporteContratoCompra
        'EntidadReportes.IdContratoAlgodon = IdContratoAlgodon
        'NegocioReportes.Consultar(EntidadReportes)
        'Tabla = EntidadReportes.TablaConsulta
        'ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        'CrReport.SetDataSource(ds.Tables(0))
        CRVOperacionPlanta.ReportSource = CrReport
    End Sub
End Class