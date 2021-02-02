Public Class RepConsultaVentas
    Private Sub RepConsultaCompras_Load(sender As Object, e As EventArgs) Handles Me.Load
        LlenaDgv()
    End Sub
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click

    End Sub
    Private Sub LlenaDgv()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        EntidadReportes.Reporte = Reporte.ReporteVentas
        'EntidadReportes.Valor = valor
        'EntidadReportes.IdPlanta = CbPlanta.SelectedValue
        'EntidadReportes.Clase = CbClase.Text
        NegocioReportes.Consultar(EntidadReportes)
        DgvVentas.DataSource = EntidadReportes.TablaConsulta
        'TbCantidadPacas.
    End Sub

    Private Sub DgvVentas_DoubleClick(sender As Object, e As EventArgs) Handles DgvVentas.DoubleClick
        If DgvVentas.DataSource IsNot Nothing Then
            Dim index As Integer
            index = DgvVentas.CurrentCell.RowIndex
            Dim ReporteVentaPacasResumen As New RepVentaPacasResumen(DgvVentas.Rows(index).Cells("IdVenta").Value, DgvVentas.Rows(index).Cells("EstatusPesoNeto").Value, DgvVentas.Rows(index).Cells("Tara").Value)
            ReporteVentaPacasResumen.ShowDialog()
        Else
            MessageBox.Show("El Id de venta no es valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class