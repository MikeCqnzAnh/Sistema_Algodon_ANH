Imports Capa_Operacion.Configuracion
Public Class CastigoUniformidad
    Private TablaClases As New DataTable()
    Private Sub CastigoUniformidad_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
        Nuevo()
        AgregaCamposTablaClases()
    End Sub
    Private Sub Nuevo()
        TbIdUniformidadEncabezado.Text = ""
        TbDescripcion.Text = ""
        CbTipoContrato.SelectedIndex = -1
        CbEstatus.SelectedIndex = 0
        DgvDetalle.DataSource = ""
        DgvEncabezado.DataSource = ""
        ConsultaModosUniformidad()
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
        '-------------------------COMBO TIPO CONTRATO
        Dim dt1 As DataTable = New DataTable("Tabla")
        dt1.Columns.Add("Id")
        dt1.Columns.Add("Descripcion")
        Dim dr1 As DataRow
        dr1 = dt1.NewRow()
        dr1("Id") = "1"
        dr1("Descripcion") = "Compra"
        dt1.Rows.Add(dr1)
        dr1 = dt1.NewRow()
        dr1("Id") = "2"
        dr1("Descripcion") = "Venta"
        dt1.Rows.Add(dr1)
        CbTipoContrato.DataSource = dt1
        CbTipoContrato.ValueMember = "Id"
        CbTipoContrato.DisplayMember = "Descripcion"
        CbTipoContrato.SelectedValue = 1
    End Sub
    Private Sub ConsultaModosUniformidad()
        Dim EntidadCastigoUniformidad As New Capa_Entidad.CastigoUniformidad
        Dim NegocioCastigoUniformidad As New Capa_Negocio.CastigoUniformidad
        Dim Tabla As New DataTable
        EntidadCastigoUniformidad.Consulta = Consulta.ConsultaEncabezado
        NegocioCastigoUniformidad.Consultar(EntidadCastigoUniformidad)
        DgvEncabezado.DataSource = EntidadCastigoUniformidad.TablaConsulta
        'PropiedadesDgModos()
    End Sub
    Private Sub ConsultaModosDetalle()
        Dim EntidadCastigoUniformidad As New Capa_Entidad.CastigoUniformidad
        Dim NegocioCastigoUniformidad As New Capa_Negocio.CastigoUniformidad
        Dim Tabla As New DataTable
        EntidadCastigoUniformidad.Consulta = Consulta.ConsultaDetallada
        EntidadCastigoUniformidad.IdUnidormidadEncabezado = Val(TbIdUniformidadEncabezado.Text)
        NegocioCastigoUniformidad.Consultar(EntidadCastigoUniformidad)
        DgvDetalle.DataSource = EntidadCastigoUniformidad.TablaConsulta
        PropiedadesDgvDetalle()
    End Sub
    Private Sub AgregaCamposTablaClases()
        TablaClases.Columns.Clear()
        TablaClases.Columns.Add(New DataColumn("IdModoDetalle", Type.GetType("System.Int32")))
        TablaClases.Columns.Add(New DataColumn("IdModoEncabezado", Type.GetType("System.Int32")))
        TablaClases.Columns.Add(New DataColumn("Rango1", Type.GetType("System.Decimal")))
        TablaClases.Columns.Add(New DataColumn("Rango2", Type.GetType("System.Decimal")))
        TablaClases.Columns.Add(New DataColumn("Castigo", Type.GetType("System.Decimal")))
        TablaClases.Columns.Add(New DataColumn("IdEstatus", Type.GetType("System.Int32")))
    End Sub
    Private Sub AgregarClasesATabla()
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaClases.Clear()
        DgvDetalle.EndEdit()

        For Each row As DataGridViewRow In DgvDetalle.Rows
            index = Convert.ToUInt64(row.Index)
            If DgvDetalle.Rows(index).Cells("Rango1").Value IsNot Nothing Or DgvDetalle.Rows(index).Cells("Rango2").Value IsNot Nothing Then
                rengloninsertar = TablaClases.NewRow()
                rengloninsertar("IdModoDetalle") = IIf(DgvDetalle.Rows(index).Cells("IdModoDetalle").Value Is Nothing, 0, DgvDetalle.Rows(index).Cells("IdModoDetalle").Value)
                rengloninsertar("IdModoEncabezado") = Val(TbIdUniformidadEncabezado.Text)
                rengloninsertar("Rango1") = DgvDetalle.Rows(index).Cells("Rango1").Value
                rengloninsertar("Rango2") = DgvDetalle.Rows(index).Cells("Rango2").Value
                rengloninsertar("Castigo") = DgvDetalle.Rows(index).Cells("Castigo").Value
                rengloninsertar("IdEstatus") = 1
                TablaClases.Rows.Add(rengloninsertar)
            End If
        Next
    End Sub
    Private Sub Guardar()
        Dim EntidadCastigoUniformidad As New Capa_Entidad.CastigoUniformidad
        Dim NegocioCastigoUniformidad As New Capa_Negocio.CastigoUniformidad
        AgregarClasesATabla()
        EntidadCastigoUniformidad.IdUnidormidadEncabezado = IIf(TbIdUniformidadEncabezado.Text = "", 0, TbIdUniformidadEncabezado.Text)
        EntidadCastigoUniformidad.Descripcion = TbDescripcion.Text
        EntidadCastigoUniformidad.IdModoComercializacion = CbTipoContrato.SelectedValue
        EntidadCastigoUniformidad.IdEstatus = CbEstatus.SelectedValue
        EntidadCastigoUniformidad.TablaModosDetalle = TablaClases
        NegocioCastigoUniformidad.Guardar(EntidadCastigoUniformidad)
        TbIdUniformidadEncabezado.Text = EntidadCastigoUniformidad.IdUnidormidadEncabezado
        MsgBox("Realizado Correctamente")
        ConsultaModosUniformidad()
        ConsultaClasesClasificacionDetalle(TbIdUniformidadEncabezado.Text)
    End Sub
    Private Sub ConsultaClasesClasificacionDetalle(ByVal Id As Integer)
        DgvDetalle.DataSource = Nothing
        Dim EntidadCastigoUniformidad As New Capa_Entidad.CastigoUniformidad
        Dim NegocioCastigoUniformidad As New Capa_Negocio.CastigoUniformidad
        Dim Tabla As New DataTable
        EntidadCastigoUniformidad.IdUnidormidadEncabezado = Id
        EntidadCastigoUniformidad.Consulta = Consulta.ConsultaDetallada
        NegocioCastigoUniformidad.Consultar(EntidadCastigoUniformidad)
        DgvDetalle.DataSource = EntidadCastigoUniformidad.TablaConsulta
        PropiedadesDgvDetalle()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If TbDescripcion.Text = "" Or CbTipoContrato.Text = "" Then
            MsgBox("No se permite guardar con campos vacios.")
        Else
            Guardar()
        End If
    End Sub
    Private Sub PropiedadesDgvDetalle()
        DgvDetalle.Columns("IdModoDetalle").Visible = False
        DgvDetalle.Columns("IdModoEncabezado").Visible = False
        DgvDetalle.Columns("IdEstatus").Visible = False
    End Sub
    Private Sub DgvEncabezado_DoubleClick(sender As Object, e As EventArgs) Handles DgvEncabezado.DoubleClick
        If DgvEncabezado.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvEncabezado.CurrentCell.RowIndex
            TbIdUniformidadEncabezado.Text = DgvEncabezado.Rows(index).Cells("IdModoEncabezado").Value
            TbDescripcion.Text = DgvEncabezado.Rows(index).Cells("Descripcion").Value
            CbTipoContrato.SelectedValue = DgvEncabezado.Rows(index).Cells("ModoComercializacion").Value
            CbEstatus.SelectedValue = DgvEncabezado.Rows(index).Cells("IdEstatus").Value
            ConsultaModosDetalle()
        End If
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class