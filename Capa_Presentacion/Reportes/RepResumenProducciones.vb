Public Class RepResumenProducciones
    Private Sub RepResumenProducciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        'ActualizaProducciones()
        ConsultarLiquidacion()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub ConsultarLiquidacion()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        EntidadReportes.Reporte = Reporte.ReporteResumenProduccion
        EntidadReportes.IdOrdenTrabajo = Val(TbIdOrdenTrabajo.Text)
        EntidadReportes.IdProductor = Val(TbIdProductor.Text)
        EntidadReportes.IdPlanta = CbPlanta.SelectedValue
        EntidadReportes.FechaIni = DtFechaini.Value
        EntidadReportes.FechaFin = DtFechaFin.Value
        NegocioReportes.Consultar(EntidadReportes)
        DgvLiquidacion.DataSource = EntidadReportes.TablaConsulta
        'TbCantidadPacas.Text = DgvLiquidacion.RowCount
        PropiedadesDGV()
    End Sub
    Private Sub PropiedadesDGV()
        DgvLiquidacion.Columns("IdPlanta").Visible = False

        DgvLiquidacion.Columns("CantidadModulos").DefaultCellStyle.Format = "N2"
        DgvLiquidacion.Columns("TotalHueso").DefaultCellStyle.Format = "N2"
        DgvLiquidacion.Columns("TotalPluma").DefaultCellStyle.Format = "N2"
        DgvLiquidacion.Columns("PorcentajeSemilla").DefaultCellStyle.Format = "N2"
        DgvLiquidacion.Columns("TotalSemilla").DefaultCellStyle.Format = "N2"
        DgvLiquidacion.Columns("PorcentajeMerma").DefaultCellStyle.Format = "N2"
        DgvLiquidacion.Columns("TotalMerma").DefaultCellStyle.Format = "N2"
        DgvLiquidacion.Columns("TotalPacas").DefaultCellStyle.Format = "N2"

        DgvLiquidacion.Columns("CantidadModulos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvLiquidacion.Columns("TotalHueso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvLiquidacion.Columns("TotalPluma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvLiquidacion.Columns("PorcentajeSemilla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvLiquidacion.Columns("TotalSemilla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvLiquidacion.Columns("PorcentajeMerma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvLiquidacion.Columns("TotalMerma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvLiquidacion.Columns("TotalPacas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub ActualizaProducciones()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        NegocioReportes.Guardar(EntidadReportes)
    End Sub
    Private Sub CargaCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = 0
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        TbIdOrdenTrabajo.Text = ""
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        DtFechaini.Value = "01/01/1900"
        DtFechaFin.Value = "01/01/1900"
        DgvLiquidacion.DataSource = ""
    End Sub

    Private Sub BtBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtBuscarProductor.Click
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        Dim Tabla As New DataTable
        ConsultaClientes.ShowDialog()
        EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadClientes.Consulta = Consulta.ConsultaDetallada
        NegocioClientes.Consultar(EntidadClientes)
        Tabla = EntidadClientes.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            TbIdProductor.Text = Tabla.Rows(0).Item("IdCliente")
            TbNombreProductor.Text = Tabla.Rows(0).Item("Nombre")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VistaPreviaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VistaPreviaToolStripMenuItem.Click
        If DgvLiquidacion.Rows.Count > 0 Then
            Dim VistaPrevia As New RepProduccion(Val(TbIdOrdenTrabajo.Text), Val(TbIdProductor.Text), CbPlanta.SelectedValue, DtFechaini.Value, DtFechaFin.Value)
            VistaPrevia.ShowDialog()
        Else
            MsgBox("No hay registros para importar al reporte.", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub DgvLiquidacion_DoubleClick(sender As Object, e As EventArgs) Handles DgvLiquidacion.DoubleClick
        If DgvLiquidacion.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvLiquidacion.CurrentCell.RowIndex
            Dim vistapreviamodulos As New RepModulosConPeso(DgvLiquidacion.Rows(index).Cells("IdOrdenTrabajo").Value)
            vistapreviamodulos.ShowDialog()
        End If

    End Sub
End Class