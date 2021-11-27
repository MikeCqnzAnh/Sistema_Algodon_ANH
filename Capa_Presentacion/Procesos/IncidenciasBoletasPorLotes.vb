Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class IncidenciasBoletasPorLotes
    Private Sub IncidenciasBoletasPorLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaModulosEntradas()
        ConsultaModulosIncidencias()
    End Sub
    Private Sub ConsultaModulosEntradas()
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        Dim Tabla As New DataTable
        EntidadCapturaBoletasPorLotes.Consulta = Consulta.ConsultaModulosEntradas
        NegocioCapturaBoletasPorLotes.Consultar(EntidadCapturaBoletasPorLotes)
        DgvModulos.DataSource = EntidadCapturaBoletasPorLotes.TablaConsulta
    End Sub
    Private Sub ConsultaModulosIncidencias()
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        Dim Tabla As New DataTable
        EntidadCapturaBoletasPorLotes.Consulta = Consulta.ConsultaModulosIncidencias
        NegocioCapturaBoletasPorLotes.Consultar(EntidadCapturaBoletasPorLotes)
        DgvIncidencias.DataSource = EntidadCapturaBoletasPorLotes.TablaConsulta
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class