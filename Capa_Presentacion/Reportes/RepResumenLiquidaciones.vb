Imports Capa_Operacion.Configuracion
Public Class RepResumenLiquidaciones
    Private Sub RepResumenLiquidaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        CargaCombos()
        limpiar()
    End Sub
    Private Sub BtBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtBuscarProductor.Click
        consultarProductor()
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultarLiquidacion()
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
    Private Sub SoloNumerosEntero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbDesde.KeyPress, TbHasta.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub consultarProductor()
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
    Private Sub ConsultarLiquidacion()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        EntidadReportes.Reporte = Reporte.ReporteResumenLiqGeneral
        EntidadReportes.IdProductor = Val(TbIdProductor.Text)
        EntidadReportes.IdPlanta = CbPlanta.SelectedValue
        EntidadReportes.Desde = Val(TbDesde.Text)
        EntidadReportes.Hasta = Val(TbHasta.Text)
        NegocioReportes.Consultar(EntidadReportes)
        DgvLiquidacion.DataSource = EntidadReportes.TablaConsulta
        'TbCantidadPacas.Text = DgvLiquidacion.RowCount
    End Sub
    Private Sub limpiar()
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        CbPlanta.SelectedValue = 0
        TbDesde.Text = ""
        TbHasta.Text = ""
        DgvLiquidacion.DataSource = ""
        DgvLiquidacion.Columns.Clear()
    End Sub

    Private Sub VistaPreviaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VistaPreviaToolStripMenuItem.Click
        If DgvLiquidacion.Rows.Count > 0 Then
            Dim VistaPrevia As New RepResumenLiqVisPrev(Val(TbIdProductor.Text), CbPlanta.SelectedValue, Val(TbDesde.Text), Val(TbHasta.Text))
            VistaPrevia.ShowDialog()
        Else
            MsgBox("No hay registros para importar al reporte.", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class