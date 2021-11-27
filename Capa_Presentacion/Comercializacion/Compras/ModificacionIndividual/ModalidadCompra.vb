Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ModalidadCompra
    Public TablaModalidadCompra As New DataTable
    Private Sub ModalidadCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaModalidadCompra.Columns.Clear()
        TablaModalidadCompra.Columns.Add(New DataColumn("IdModoDetalle", System.Type.GetType("System.Int32")))
        TablaModalidadCompra.Columns.Add(New DataColumn("IdClasificacion", System.Type.GetType("System.Int32")))
        TablaModalidadCompra.Columns.Add(New DataColumn("Diferencial", System.Type.GetType("System.Int32")))
        CargarCombos()
        ConsultarModalidadCompra()
    End Sub

    Private Sub ConsultarModalidadCompra()
        Dim EntidadConsultaCastigos As New Capa_Entidad.ConsultaCastigos
        Dim NegocioConsultaCastigos As New Capa_Negocio.ConsultaCastigos
        EntidadConsultaCastigos.Consulta = Consulta.ConsultaModalidadCompra
        EntidadConsultaCastigos.IdModalidadCompra = CInt(CbModalidadCompra.SelectedValue)
        NegocioConsultaCastigos.Consultar(EntidadConsultaCastigos)
        Tabla = EntidadConsultaCastigos.TablaConsulta
        DgvModalidadCompra.DataSource = Tabla
    End Sub

    Private Sub CargarCombos()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        '---Modalidad De Compra--
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaModoCompra
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbModalidadCompra.DataSource = Tabla
        CbModalidadCompra.ValueMember = "IdModoEncabezado"
        CbModalidadCompra.DisplayMember = "Descripcion"
        CbModalidadCompra.SelectedValue = 11
    End Sub

    Private Sub CbModalidadCompra_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbModalidadCompra.SelectionChangeCommitted
        ConsultarModalidadCompra()
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.VentaPacasContrato
        TablaModalidadCompra.Clear()
        Dim TablaRenglonAInsertar As DataRow
        For Each row As DataGridViewRow In DgvModalidadCompra.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            TablaRenglonAInsertar = TablaModalidadCompra.NewRow()
            TablaRenglonAInsertar("IdModoDetalle") = DgvModalidadCompra.Rows(Index).Cells("IdModoDetalle").Value
            TablaRenglonAInsertar("IdClasificacion") = DgvModalidadCompra.Rows(Index).Cells("IdClasificacion").Value
            TablaRenglonAInsertar("Diferencial") = DgvModalidadCompra.Rows(Index).Cells("Diferencial").Value
            TablaModalidadCompra.Rows.Add(TablaRenglonAInsertar)
        Next
        Tabla = TablaModalidadCompra
        Close()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
End Class