Imports Capa_Operacion.Configuracion
Public Class ModalidadesVenta
    Private TablaClases As New DataTable()
    Private Sub ModalidadesVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
        ConsultaModosVenta()
        ConsultaClasesClasificacion()
        AgregaCamposTablaClases()
    End Sub
    Private Sub Limpiar()
        TbIdModoVenta.Text = ""
        TbDescripcion.Text = ""
        CbEstatus.SelectedIndex = -1
        ConsultaModosVenta()
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
    Private Sub ConsultaModosVenta()
        Dim EntidadModalidadesVenta As New Capa_Entidad.ModalidadesVenta
        Dim NegocioModalidadesVenta As New Capa_Negocio.ModalidadesVenta
        Dim Tabla As New DataTable
        EntidadModalidadesVenta.Consulta = Consulta.ConsultaDetallada
        NegocioModalidadesVenta.Consultar(EntidadModalidadesVenta)
        DgvModosVenta.DataSource = EntidadModalidadesVenta.TablaConsulta
        PropiedadesDgModos()
    End Sub
    Private Sub ConsultaClasesClasificacion()
        Dim EntidadModalidadesVenta As New Capa_Entidad.ModalidadesVenta
        Dim NegocioModalidadesVenta As New Capa_Negocio.ModalidadesVenta
        Dim Tabla As New DataTable
        EntidadModalidadesVenta.Consulta = Consulta.ConsultaClases
        NegocioModalidadesVenta.Consultar(EntidadModalidadesVenta)
        DgvClasificacion.DataSource = EntidadModalidadesVenta.TablaConsulta
        PropiedadesDgClases()
    End Sub
    Private Sub ConsultaClasesClasificacionDetalle(ByVal Id As Integer)
        DgvClasificacion.DataSource = Nothing
        Dim EntidadModalidadesVenta As New Capa_Entidad.ModalidadesVenta
        Dim NegocioModalidadesVenta As New Capa_Negocio.ModalidadesVenta
        Dim Tabla As New DataTable
        EntidadModalidadesVenta.IdModoEncabezado = Id
        EntidadModalidadesVenta.Consulta = Consulta.ConsultaClasesDetalle
        NegocioModalidadesVenta.Consultar(EntidadModalidadesVenta)
        DgvClasificacion.DataSource = EntidadModalidadesVenta.TablaConsulta
        PropiedadesDgClases()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub PropiedadesDgModos()
        DgvModosVenta.Columns("IdModoEncabezado").Visible = False
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
        Dim EntidadModalidadesVenta As New Capa_Entidad.ModalidadesVenta
        Dim NegocioModalidadesVenta As New Capa_Negocio.ModalidadesVenta
        AgregarClasesATabla()
        EntidadModalidadesVenta.IdModoEncabezado = IIf(TbIdModoVenta.Text = "", 0, TbIdModoVenta.Text)
        EntidadModalidadesVenta.Descripcion = TbDescripcion.Text
        EntidadModalidadesVenta.IdEstatus = CbEstatus.SelectedValue
        EntidadModalidadesVenta.IdUsuarioCreacion = 1
        EntidadModalidadesVenta.FechaCreacion = Now
        EntidadModalidadesVenta.TablaClasesClasificacion = TablaClases
        NegocioModalidadesVenta.Guardar(EntidadModalidadesVenta)
        TbIdModoVenta.Text = EntidadModalidadesVenta.IdModoEncabezado
        MsgBox("Realizado Correctamente")
        ConsultaModosVenta()
        ConsultaClasesClasificacionDetalle(TbIdModoVenta.Text)
    End Sub
    Private Sub DgvModosVenta_CellContentClick() Handles DgvModosVenta.DoubleClick
        Dim NumFila As Integer = DgvModosVenta.CurrentCell.RowIndex
        Dim NumCol As Integer = DgvModosVenta.CurrentCell.ColumnIndex

        TbIdModoVenta.Text = DgvModosVenta("IdModoEncabezado", NumFila).Value
        TbDescripcion.Text = DgvModosVenta("Descripcion", NumFila).Value
        CbEstatus.SelectedValue = DgvModosVenta("IdEstatus", NumFila).Value
        ConsultaClasesClasificacionDetalle(TbIdModoVenta.Text)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class