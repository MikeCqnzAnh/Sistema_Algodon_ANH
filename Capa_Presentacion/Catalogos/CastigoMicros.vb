Imports Capa_Operacion.Configuracion
Public Class CastigoMicros
    Private TablaClases As New DataTable()
    Private Sub CastigoMicros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        Nuevo()
        AgregaCamposTablaClases()
    End Sub
    Private Sub Nuevo()
        TbIdMicroEncabezado.Text = ""
        TbDescripcion.Text = ""
        CbTipoContrato.SelectedIndex = -1
        CbEstatus.SelectedIndex = 0
        DgvMicrosDetalle.DataSource = ""
        DgvMicrosEncabezado.DataSource = ""
        ConsultaModosMicros()
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
    Private Sub ConsultaModosMicros()
        Dim EntidadCastigoMicros As New Capa_Entidad.CastigoMicros
        Dim NegocioCastigoMicros As New Capa_Negocio.CastigoMicros
        Dim Tabla As New DataTable
        EntidadCastigoMicros.Consulta = Consulta.ConsultaEncabezado
        NegocioCastigoMicros.Consultar(EntidadCastigoMicros)
        DgvMicrosEncabezado.DataSource = EntidadCastigoMicros.TablaConsulta
        'PropiedadesDgModos()
    End Sub
    Private Sub ConsultaModosDetalle()
        Dim EntidadCastigoMicros As New Capa_Entidad.CastigoMicros
        Dim NegocioCastigoMicros As New Capa_Negocio.CastigoMicros
        Dim Tabla As New DataTable
        EntidadCastigoMicros.Consulta = Consulta.ConsultaDetallada
        EntidadCastigoMicros.IdMicrosEncabezado = Val(TbIdMicroEncabezado.Text)
        NegocioCastigoMicros.Consultar(EntidadCastigoMicros)
        DgvMicrosDetalle.DataSource = EntidadCastigoMicros.TablaConsulta
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
        DgvMicrosDetalle.EndEdit()

        For Each row As DataGridViewRow In DgvMicrosDetalle.Rows
            index = Convert.ToUInt64(row.Index)
            If DgvMicrosDetalle.Rows(index).Cells("Rango1").Value IsNot Nothing Or DgvMicrosDetalle.Rows(index).Cells("Rango2").Value IsNot Nothing Then
                rengloninsertar = TablaClases.NewRow()
                rengloninsertar("IdModoDetalle") = IIf(DgvMicrosDetalle.Rows(index).Cells("IdModoDetalle").Value Is Nothing, 0, DgvMicrosDetalle.Rows(index).Cells("IdModoDetalle").Value)
                rengloninsertar("IdModoEncabezado") = Val(TbIdMicroEncabezado.Text)
                rengloninsertar("Rango1") = DgvMicrosDetalle.Rows(index).Cells("Rango1").Value
                rengloninsertar("Rango2") = DgvMicrosDetalle.Rows(index).Cells("Rango2").Value
                rengloninsertar("Castigo") = DgvMicrosDetalle.Rows(index).Cells("Castigo").Value
                rengloninsertar("IdEstatus") = 1
                TablaClases.Rows.Add(rengloninsertar)
            End If
        Next
    End Sub
    Private Sub Guardar()
        Dim EntidadCastigoMicros As New Capa_Entidad.CastigoMicros
        Dim NegocioCastigoMicros As New Capa_Negocio.CastigoMicros
        AgregarClasesATabla()
        EntidadCastigoMicros.IdMicrosEncabezado = IIf(TbIdMicroEncabezado.Text = "", 0, TbIdMicroEncabezado.Text)
        EntidadCastigoMicros.Descripcion = TbDescripcion.Text
        EntidadCastigoMicros.IdModoComercializacion = CbTipoContrato.SelectedValue
        EntidadCastigoMicros.IdEstatus = CbEstatus.SelectedValue
        EntidadCastigoMicros.TablaModosDetalle = TablaClases
        NegocioCastigoMicros.Guardar(EntidadCastigoMicros)
        TbIdMicroEncabezado.Text = EntidadCastigoMicros.IdMicrosEncabezado
        MsgBox("Realizado Correctamente")
        ConsultaModosMicros()
        ConsultaClasesClasificacionDetalle(TbIdMicroEncabezado.Text)
    End Sub
    Private Sub ConsultaClasesClasificacionDetalle(ByVal Id As Integer)
        DgvMicrosDetalle.DataSource = Nothing
        Dim EntidadCastigoMicros As New Capa_Entidad.CastigoMicros
        Dim NegocioCastigoMicros As New Capa_Negocio.CastigoMicros
        Dim Tabla As New DataTable
        EntidadCastigoMicros.IdMicrosEncabezado = Id
        EntidadCastigoMicros.Consulta = Consulta.ConsultaDetallada
        NegocioCastigoMicros.Consultar(EntidadCastigoMicros)
        DgvMicrosDetalle.DataSource = EntidadCastigoMicros.TablaConsulta
        PropiedadesDgvDetalle()
    End Sub
    'Private Sub ConsultaMicrosEncabezado()
    '    Dim EntidadCastigoMicros As New Capa_Entidad.CastigoMicros
    '    Dim NegocioCastigoMicros As New Capa_Negocio.CastigoMicros
    '    Dim Tabla As New DataTable
    '    EntidadCastigoMicros.Consulta = Consulta.ConsultaDetallada
    '    NegocioCastigoMicros.Consultar(EntidadCastigoMicros)
    '    DgvMicrosEncabezado.DataSource = EntidadCastigoMicros.TablaConsulta
    '    'PropiedadesDgModos()
    'End Sub
    Private Sub PropiedadesDgvDetalle()
        DgvMicrosDetalle.Columns("IdModoDetalle").Visible = False
        DgvMicrosDetalle.Columns("IdModoEncabezado").Visible = False
        DgvMicrosDetalle.Columns("IdEstatus").Visible = False
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If TbDescripcion.Text = "" Or CbTipoContrato.Text = "" Then
            MsgBox("No se permite guardar con campos vacios.")
        Else
            Guardar()
        End If
    End Sub
    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        If TbIdMicroEncabezado.Text = "" Then
            MessageBox.Show("No se puede agregar parametro sin seleccinar un modo.", "Aviso")
        End If
    End Sub
    Private Sub DgvMicrosEncabezado_DoubleClick(sender As Object, e As EventArgs) Handles DgvMicrosEncabezado.DoubleClick
        If DgvMicrosEncabezado.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvMicrosEncabezado.CurrentCell.RowIndex
            TbIdMicroEncabezado.Text = DgvMicrosEncabezado.Rows(index).Cells("IdModoEncabezado").Value
            TbDescripcion.Text = DgvMicrosEncabezado.Rows(index).Cells("Descripcion").Value
            CbTipoContrato.SelectedValue = DgvMicrosEncabezado.Rows(index).Cells("ModoComercializacion").Value
            CbEstatus.SelectedValue = DgvMicrosEncabezado.Rows(index).Cells("IdEstatus").Value
            ConsultaModosDetalle()
        End If
    End Sub
End Class