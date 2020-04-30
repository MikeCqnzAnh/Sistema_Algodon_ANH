Public Class RepDisponibilidadPacasProductor

    Private Sub RepClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla, TablaGeneral As New Data.DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTDisponibilidadPacasProductor = New RPTDisponibilidadPacasProductor
        Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Reportes\RPT\RPTDisponibilidadPacasProductor.rpt"
        EntidadReportes.Reporte = Reporte.ReporteDisponibilidadPacasProductor
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVDisponibilidadPacas.ReportSource = CrReport
    End Sub
End Class