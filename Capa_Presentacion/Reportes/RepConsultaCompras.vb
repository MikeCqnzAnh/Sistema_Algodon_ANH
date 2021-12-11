Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class RepConsultaCompras
    Private Sub RepConsultaCompras_Load(sender As Object, e As EventArgs) Handles Me.Load
        LlenaDgv()
    End Sub
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        LlenaDgv()
    End Sub
    Private Sub LlenaDgv()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        EntidadReportes.Reporte = Reporte.ReporteCompras
        EntidadReportes.IdCompra = Val(TbIdCompra.Text)
        EntidadReportes.Nombre = TbNombre.Text
        'EntidadReportes.IdPlanta = CbPlanta.SelectedValue
        'EntidadReportes.Clase = CbClase.Text
        NegocioReportes.Consultar(EntidadReportes)
        DgvCompras.DataSource = EntidadReportes.TablaConsulta
        'TbCantidadPacas.Text = DgvCompras.RowCount
    End Sub

    Private Sub DgvCompras_DoubleClick(sender As Object, e As EventArgs) Handles DgvCompras.DoubleClick

        If DgvCompras.DataSource IsNot Nothing Then
            Dim index As Integer
            index = DgvCompras.CurrentCell.RowIndex
            Dim ReporteCompraPacasResumen As New RepCompraPacasResumen(DgvCompras.Rows(index).Cells("IdCompra").Value)
            ReporteCompraPacasResumen.ShowDialog()
        Else
            MessageBox.Show("El Id de compra no es valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class