Public Class RepLiquidacionPacasResumen
    Dim IdCompra As Integer
    Dim IdProductor As Integer
    Dim NombreProductor As String
    Public Sub New(ByVal Id As Integer, ByVal IdProd As Integer, ByVal Nombre As String)
        InitializeComponent()
        IdCompra = Id
        NombreProductor = Nombre
        IdProductor = IdProd
    End Sub
    Private Sub RepCompraPacasResumen_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConsultaReporte()
    End Sub
    Private Sub ConsultaReporte()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTLiquidacionResumen = New RPTLiquidacionResumen
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTLiquidacionResumen.rpt"
        EntidadReportes.Reporte = Reporte.ReporteResumenLiquidacion
        EntidadReportes.IdCompra = IdCompra
        EntidadReportes.Nombre = NombreProductor
        EntidadReportes.IdProductor = IdProductor
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVLiquidacionRomanea.ReportSource = CrReport
        CRVLiquidacionRomanea.Show()
    End Sub
End Class