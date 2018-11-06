Imports Capa_Operacion.Configuracion
Public Class ModalidadesCompra
    Private TablaClases As New DataTable()
    Private Sub ModalidadesCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaModosCompra()
        ConsultaClasesClasificacion()
        AgregaCamposTablaClases()
    End Sub
    Private Sub Limpiar()
        TbIdModoCompra.Text = ""
        TbDescripcion.Text = ""
        CbEstatus.SelectedIndex = 0
        ConsultaModosCompra()
        ConsultaClasesClasificacion()
    End Sub
    Private Sub CargarCombos()
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "2"
        dr("Descripcion") = "Inactivo"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Id"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedValue = 1
    End Sub
    Private Sub ConsultaModosCompra()
        Dim EntidadModalidadesCompra As New Capa_Entidad.ModalidadesCompra
        Dim NegocioModalidadesCompra As New Capa_Negocio.ModalidadesCompra
        Dim Tabla As New DataTable
        EntidadModalidadesCompra.Consulta = Consulta.ConsultaDetallada
        NegocioModalidadesCompra.Consultar(EntidadModalidadesCompra)
        DgvModosCompra.DataSource = EntidadModalidadesCompra.TablaConsulta
        PropiedadesDgModos()
    End Sub
    Private Sub ConsultaClasesClasificacion()
        Dim EntidadModalidadesCompra As New Capa_Entidad.ModalidadesCompra
        Dim NegocioModalidadesCompra As New Capa_Negocio.ModalidadesCompra
        Dim Tabla As New DataTable
        EntidadModalidadesCompra.Consulta = Consulta.ConsultaClases
        NegocioModalidadesCompra.Consultar(EntidadModalidadesCompra)
        DgvClasificacion.DataSource = EntidadModalidadesCompra.TablaConsulta
        PropiedadesDgClases()
    End Sub
    Private Sub ConsultaClasesClasificacionDetalle(ByVal Id As Integer)
        DgvClasificacion.DataSource = Nothing
        Dim EntidadModalidadesCompra As New Capa_Entidad.ModalidadesCompra
        Dim NegocioModalidadesCompra As New Capa_Negocio.ModalidadesCompra
        Dim Tabla As New DataTable
        EntidadModalidadesCompra.IdModoEncabezado = Id
        EntidadModalidadesCompra.Consulta = Consulta.ConsultaClasesDetalle
        NegocioModalidadesCompra.Consultar(EntidadModalidadesCompra)
        DgvClasificacion.DataSource = EntidadModalidadesCompra.TablaConsulta
        PropiedadesDgClases()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub PropiedadesDgModos()
        DgvModosCompra.Columns("IdModoEncabezado").Visible = False
    End Sub
    Private Sub AgregaCamposTablaClases()
        TablaClases.Columns.Clear()
        TablaClases.Columns.Add(New DataColumn("IdModoDetalle", Type.GetType("System.Int32")))
        TablaClases.Columns.Add(New DataColumn("IdModoEncabezado", Type.GetType("System.Int32")))
        TablaClases.Columns.Add(New DataColumn("IdClasificacion", Type.GetType("System.Int32")))
        TablaClases.Columns.Add(New DataColumn("Diferencial", Type.GetType("System.Int32")))
    End Sub
    Private Sub AgregarClasesATabla()
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaClases.Clear()
        For Each row As DataGridViewRow In DgvClasificacion.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaClases.NewRow()
            rengloninsertar("IdModoDetalle") = IIf(DgvClasificacion.Rows(index).Cells("IdModoDetalle").Value Is Nothing, 0, DgvClasificacion.Rows(index).Cells("IdModoDetalle").Value)
            rengloninsertar("IdModoEncabezado") = DgvClasificacion.Rows(index).Cells("IdModoEncabezado").Value
            rengloninsertar("IdClasificacion") = DgvClasificacion.Rows(index).Cells("IdClasificacion").Value
            rengloninsertar("Diferencial") = DgvClasificacion.Rows(index).Cells("Diferencial").Value
            TablaClases.Rows.Add(rengloninsertar)
        Next
    End Sub
    Private Sub PropiedadesDgClases()
        DgvClasificacion.Columns("IdModoDetalle").Visible = False
        DgvClasificacion.Columns("IdModoEncabezado").Visible = False
        DgvClasificacion.Columns("IdClasificacion").Visible = False
        DgvClasificacion.Columns("ClaveCorta").ReadOnly = True
        DgvClasificacion.Columns("ClaveCorta").HeaderText = "Clave Corta"
        DgvClasificacion.Columns("Descripcion").ReadOnly = True
        DgvClasificacion.Columns("Descripcion").HeaderText = "Descripcion"
        DgvClasificacion.Columns("Diferencial").ReadOnly = False
        DgvClasificacion.Columns("Diferencial").HeaderText = "Diferencial"
        DgvClasificacion.Columns("Diferencial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadModalidadesCompra As New Capa_Entidad.ModalidadesCompra
        Dim NegocioModalidadesCompra As New Capa_Negocio.ModalidadesCompra
        AgregarClasesATabla()
        EntidadModalidadesCompra.IdModoEncabezado = IIf(TbIdModoCompra.Text = "", 0, TbIdModoCompra.Text)
        EntidadModalidadesCompra.Descripcion = TbDescripcion.Text
        EntidadModalidadesCompra.IdEstatus = CbEstatus.SelectedValue
        EntidadModalidadesCompra.IdUsuarioCreacion = 1
        EntidadModalidadesCompra.FechaCreacion = Now
        EntidadModalidadesCompra.TablaClasesClasificacion = TablaClases
        NegocioModalidadesCompra.Guardar(EntidadModalidadesCompra)
        TbIdModoCompra.Text = EntidadModalidadesCompra.IdModoEncabezado
        MsgBox("Realizado Correctamente")
        ConsultaModosCompra()
        ConsultaClasesClasificacionDetalle(TbIdModoCompra.Text)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DgvModosCompra_CellContentClick() Handles DgvModosCompra.DoubleClick
        Dim NumFila As Integer = DgvModosCompra.CurrentCell.RowIndex
        Dim NumCol As Integer = DgvModosCompra.CurrentCell.ColumnIndex

        TbIdModoCompra.Text = DgvModosCompra("IdModoEncabezado", NumFila).Value
        TbDescripcion.Text = DgvModosCompra("Descripcion", NumFila).Value
        CbEstatus.SelectedValue = DgvModosCompra("IdEstatus", NumFila).Value
        ConsultaClasesClasificacionDetalle(TbIdModoCompra.Text)
    End Sub
End Class