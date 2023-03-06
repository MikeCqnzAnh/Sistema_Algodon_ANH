Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaReporteModulos
    Private Sub ConsultaReporteModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta()
    End Sub
    Private Sub consulta()
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        Dim Tabla As New DataTable
        EntidadCapturaBoletasPorLotes.Consulta = Capa_Operacion.Configuracion.Consulta.ConsultaModulosReporte
        NegocioCapturaBoletasPorLotes.Consultar(EntidadCapturaBoletasPorLotes)
        DgvModulos.DataSource = EntidadCapturaBoletasPorLotes.TablaConsulta
    End Sub

    Private Sub ExportaAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportaAExcelToolStripMenuItem.Click
        If DgvModulos.Rows.Count > 0 Then
            exportdgvtoexcel(DgvModulos)
        End If
    End Sub
End Class