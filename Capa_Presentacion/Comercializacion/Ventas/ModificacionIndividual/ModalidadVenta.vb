Imports Capa_Operacion.Configuracion
Public Class ModalidadVenta
    Public TablaModalidadVenta As New DataTable
    Private Sub ModalidadVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaModalidadVenta.Columns.Clear()
        TablaModalidadVenta.Columns.Add(New DataColumn("IdModoDetalle", System.Type.GetType("System.Int32")))
        TablaModalidadVenta.Columns.Add(New DataColumn("IdClasificacion", System.Type.GetType("System.Int32")))
        TablaModalidadVenta.Columns.Add(New DataColumn("Diferencial", System.Type.GetType("System.Int32")))
        CargarCombos()
        ConsultarModalidadVenta()
    End Sub

    Private Sub ConsultarModalidadVenta()
        Dim EntidadConsultaCastigos As New Capa_Entidad.ConsultaCastigos
        Dim NegocioConsultaCastigos As New Capa_Negocio.ConsultaCastigos
        EntidadConsultaCastigos.Consulta = Consulta.ConsultaModalidadVenta
        EntidadConsultaCastigos.IdModalidadVenta = CInt(CbModalidadVenta.SelectedValue)
        NegocioConsultaCastigos.Consultar(EntidadConsultaCastigos)
        Tabla = EntidadConsultaCastigos.TablaConsulta
        DgvModalidadVenta.DataSource = Tabla
    End Sub

    Private Sub CargarCombos()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        '---Modalidad De Venta--
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaModoVenta
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbModalidadVenta.DataSource = Tabla
        CbModalidadVenta.ValueMember = "IdModoEncabezado"
        CbModalidadVenta.DisplayMember = "Descripcion"
        CbModalidadVenta.SelectedValue = 11
    End Sub

    Private Sub CbModalidadVenta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbModalidadVenta.SelectionChangeCommitted
        ConsultarModalidadVenta()
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        TablaModalidadVenta.Clear()
        Dim TablaRenglonAInsertar As DataRow
        For Each row As DataGridViewRow In DgvModalidadVenta.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            TablaRenglonAInsertar = TablaModalidadVenta.NewRow()
            TablaRenglonAInsertar("IdModoDetalle") = DgvModalidadVenta.Rows(Index).Cells("IdModoDetalle").Value
            TablaRenglonAInsertar("IdClasificacion") = DgvModalidadVenta.Rows(Index).Cells("IdClasificacion").Value
            TablaRenglonAInsertar("Diferencial") = DgvModalidadVenta.Rows(Index).Cells("Diferencial").Value
            TablaModalidadVenta.Rows.Add(TablaRenglonAInsertar)
        Next
        Tabla = TablaModalidadVenta
        Close()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
End Class