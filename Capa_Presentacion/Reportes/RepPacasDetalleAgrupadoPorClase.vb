Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class RepPacasDetalleAgrupadoPorClase
    Private Sub RepPacasDetalleAgrupadoPorClase_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
        CargaCombos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub BtDetallado_Click(sender As Object, e As EventArgs) Handles BtDetallado.Click

    End Sub
    Private Sub Limpiar()

        CbPlantaDestino.SelectedIndex = -1
        CbPlantaOrigen.SelectedIndex = -1
        TbIdCliente.Text = ""
        TbNombreCliente.Text = ""
        CbOrdenProduccion.DataSource = Nothing
        CbOrdenProduccion.Items.Clear()
        CbClases.SelectedIndex = -1

    End Sub
    Private Sub BtConsultaCliente_Click(sender As Object, e As EventArgs) Handles BtConsultaCliente.Click
        ConsultarClienteBoton()
        CargaComboOrdenTrabajo()
    End Sub
    Private Sub BtAgrupadoPorClase_Click(sender As Object, e As EventArgs) Handles BtAgrupadoPorClase.Click
        Consultar()
    End Sub
    Private Sub TbIdCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdCliente.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultarClienteEnter()
                CargaComboOrdenTrabajo()
        End Select
    End Sub
    Private Sub CargaCombos()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlantaOrigen.DataSource = Tabla
        CbPlantaOrigen.ValueMember = "IdPlanta"
        CbPlantaOrigen.DisplayMember = "Descripcion"
        CbPlantaOrigen.SelectedValue = 0
        '-----------------------------------------------
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        CbClases.DataSource = Tabla2
        CbClases.ValueMember = "IdClasificacion"
        CbClases.DisplayMember = "ClaveCorta"
        CbClases.SelectedValue = 0
    End Sub
    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTAgrupadoPorClase = New RPTAgrupadoPorClase
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTAgrupadoPorClase.rpt"
        EntidadReportes.Reporte = Reporte.ReportePacasDetalleAgrupadoPorClase
        EntidadReportes.IdProductor = IIf(TbIdCliente.Text = "", 0, TbIdCliente.Text)
        EntidadReportes.IdPlanta = CbPlantaOrigen.SelectedValue
        EntidadReportes.IdClase = CbClases.SelectedValue
        EntidadReportes.IdOrdenProduccion = CbOrdenProduccion.SelectedValue
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        If Tabla.Rows.Count > 0 Then
            ds.Tables.Add(Tabla)
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds.Tables("table1"))
            CRVRepPacasDetallado.ReportSource = CrReport
            CRVRepPacasDetallado.Show()
        Else
            MsgBox("No hay registros con los parametros aplicados!!", MsgBoxStyle.Exclamation)
        End If

    End Sub
    Private Sub ConsultarClienteBoton()
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
            TbIdCliente.Text = Tabla.Rows(0).Item("IdCliente")
            TbNombreCliente.Text = Tabla.Rows(0).Item("Nombre")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarClienteEnter()
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        Dim Tabla As New DataTable
        'ConsultaClientes.ShowDialog()
        EntidadClientes.IdCliente = TbIdCliente.Text
        EntidadClientes.Consulta = Consulta.ConsultaDetallada
        NegocioClientes.Consultar(EntidadClientes)
        Tabla = EntidadClientes.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            TbIdCliente.Text = Tabla.Rows(0).Item("IdCliente")
            TbNombreCliente.Text = Tabla.Rows(0).Item("Nombre")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargaComboOrdenTrabajo()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        'ConsultaClientes.ShowDialog()
        If TbIdCliente.Text <> "" Then
            EntidadOrdenTrabajo.IdProductor = TbIdCliente.Text
            EntidadOrdenTrabajo.Consulta = Consulta.ConsultaOrdenesDeTrabajo
            NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
            Tabla = EntidadOrdenTrabajo.TablaConsulta
            CbOrdenProduccion.DataSource = Tabla
            CbOrdenProduccion.DataSource = Tabla
            CbOrdenProduccion.ValueMember = "IdOrdenTrabajo"
            CbOrdenProduccion.DisplayMember = "IdOrdenTrabajo"
            CbOrdenProduccion.SelectedValue = 0
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class