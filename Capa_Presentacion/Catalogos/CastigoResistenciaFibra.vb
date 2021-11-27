Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class CastigoResistenciaFibra
    Private TablaClases As New DataTable()
    Private Sub CastigoLargoFibra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        limpiarCampos()
        AgregaCamposTablaClases()
        ConsultaModosResistenciaFibra()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiarCampos()
        ConsultaModosResistenciaFibra()
    End Sub
    Private Sub limpiarCampos()
        TbIdResistenciaEncabezado.Text = ""
        TbDescripcion.Text = ""
        TbRango1.Text = ""
        TbRango2.Text = ""
        TbCastigo.Text = ""
        CbTipoContrato.SelectedIndex = -1
        CbEstatus.SelectedValue = 1
        DgvDetalle.DataSource = ""
        DgvEncabezado.DataSource = ""
        ConsultaModosResistenciaFibra()
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
        CbTipoContrato.SelectedIndex = -1
    End Sub
    Private Sub ConsultaModosResistenciaFibra()
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        Dim Tabla As New DataTable
        EntidadCastigoResistenciaFibra.Consulta = Consulta.ConsultaEncabezado
        NegocioCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
        DgvEncabezado.DataSource = EntidadCastigoResistenciaFibra.TablaConsulta
        PropiedadesDgModos()
    End Sub
    Private Sub ConsultaModosDetalle()
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        Dim Tabla As New DataTable
        EntidadCastigoResistenciaFibra.Consulta = Consulta.ConsultaDetallada
        EntidadCastigoResistenciaFibra.IdResistenciaEncabezado = Val(TbIdResistenciaEncabezado.Text)
        NegocioCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
        DgvDetalle.DataSource = EntidadCastigoResistenciaFibra.TablaConsulta
        DgvDetallePropiedades()
    End Sub
    Private Sub ConsultaModosDetalleParametro(ByVal Id As Integer)
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        Dim Tabla As New DataTable
        EntidadCastigoResistenciaFibra.Consulta = Consulta.ConsultaDetallada
        EntidadCastigoResistenciaFibra.IdResistenciaEncabezado = Val(TbIdResistenciaEncabezado.Text)
        NegocioCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
        DgvDetalle.DataSource = EntidadCastigoResistenciaFibra.TablaConsulta
        DgvDetallePropiedades()
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
                rengloninsertar("IdModoEncabezado") = Val(TbIdResistenciaEncabezado.Text)
                rengloninsertar("Rango1") = DgvDetalle.Rows(index).Cells("Rango1").Value
                rengloninsertar("Rango2") = DgvDetalle.Rows(index).Cells("Rango2").Value
                rengloninsertar("Castigo") = DgvDetalle.Rows(index).Cells("Castigo").Value
                rengloninsertar("IdEstatus") = 1
                TablaClases.Rows.Add(rengloninsertar)
            End If
        Next
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If TbDescripcion.Text = "" Or CbTipoContrato.Text = "" Then
            MsgBox("No se permite guardar con campos vacios.")
        Else
            Guardar()
        End If
    End Sub
    Private Sub Guardar()
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        AgregarClasesATabla()
        EntidadCastigoResistenciaFibra.IdResistenciaEncabezado = IIf(TbIdResistenciaEncabezado.Text = "", 0, TbIdResistenciaEncabezado.Text)
        EntidadCastigoResistenciaFibra.Descripcion = TbDescripcion.Text
        EntidadCastigoResistenciaFibra.IdModoComercializacion = CbTipoContrato.SelectedValue
        EntidadCastigoResistenciaFibra.IdEstatus = CbEstatus.SelectedValue
        EntidadCastigoResistenciaFibra.TablaModosDetalle = TablaClases
        NegocioCastigoResistenciaFibra.Guardar(EntidadCastigoResistenciaFibra)
        TbIdResistenciaEncabezado.Text = EntidadCastigoResistenciaFibra.IdResistenciaEncabezado
        MsgBox("Realizado Correctamente")
        ConsultaModosResistenciaFibra()
        ConsultaModosDetalleParametro(TbIdResistenciaEncabezado.Text)
    End Sub

    Private Sub ConsultaResistenciaFibra()
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        Dim Tabla As New DataTable
        EntidadCastigoResistenciaFibra.Consulta = Consulta.ConsultaDetallada
        NegocioCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
        'DgvCastigoResistenciaFibra.DataSource = EntidadCastigoResistenciaFibra.TablaConsulta
    End Sub
    Private Sub DgvEncabezado_DoubleClick(sender As Object, e As EventArgs) Handles DgvEncabezado.DoubleClick
        If DgvEncabezado.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvEncabezado.CurrentCell.RowIndex
            TbIdResistenciaEncabezado.Text = DgvEncabezado.Rows(index).Cells("IdModoEncabezado").Value
            TbDescripcion.Text = DgvEncabezado.Rows(index).Cells("Descripcion").Value
            CbTipoContrato.SelectedValue = DgvEncabezado.Rows(index).Cells("ModoComercializacion").Value
            CbEstatus.SelectedValue = DgvEncabezado.Rows(index).Cells("IdEstatus").Value
            ConsultaModosDetalle()
        End If
    End Sub
    Private Sub DgvDetallePropiedades()
        DgvDetalle.Columns("IdModoDetalle").Visible = False
        DgvDetalle.Columns("IdModoEncabezado").Visible = False
        DgvDetalle.Columns("IdEstatus").Visible = False
    End Sub
    Private Sub PropiedadesDgModos()
        DgvEncabezado.Columns("ModoComercializacion").Visible = False
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class