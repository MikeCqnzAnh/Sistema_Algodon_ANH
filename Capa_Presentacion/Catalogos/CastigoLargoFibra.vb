Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class CastigoLargoFibra
    Private TablaDetalles As New DataTable()
    Private TablaEquivalente As New DataTable()
    Private Sub CastigoLargoFibra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        limpiarCampos()
        AgregaCamposTablaDetalles()
        AgregaCamposTablaEquivalente()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiarCampos()
        CargarCombos()
    End Sub
    Private Sub limpiarCampos()
        TbIdModoLargoFibraEncabezado.Text = ""
        TbDescripcion.Text = ""
        CbTipoContrato.SelectedIndex = -1
        CbEstatus.SelectedIndex = 0
        DgvEncabezado.DataSource = ""
        'DgvLargoDetalle.DataSource = ""
        'DgvEquivalente.DataSource = ""
        DgvEquivalente.Columns.Clear()
        DgvLargoDetalle.Columns.Clear()
        ConsultaModosLargoFibra()
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
    Private Sub ConsultaModosLargoFibra()
        Dim EntidadCastigoLargoFibra As New Capa_Entidad.CastigoLargoFibra
        Dim NegocioCastigoLargoFibra As New Capa_Negocio.CastigoLargoFibra
        Dim Tabla As New DataTable
        EntidadCastigoLargoFibra.Consulta = Consulta.ConsultaEncabezado
        NegocioCastigoLargoFibra.Consultar(EntidadCastigoLargoFibra)
        DgvEncabezado.DataSource = EntidadCastigoLargoFibra.TablaConsulta
        PropiedadesDgvEncabezado()
    End Sub
    Private Sub ConsultaModosDetalle()
        Dim EntidadCastigoLargoFibra As New Capa_Entidad.CastigoLargoFibra
        Dim NegocioCastigoLargoFibra As New Capa_Negocio.CastigoLargoFibra
        Dim Tabla As New DataTable
        EntidadCastigoLargoFibra.Consulta = Consulta.ConsultaDetallada
        EntidadCastigoLargoFibra.IdModoEncabezado = Val(TbIdModoLargoFibraEncabezado.Text)
        NegocioCastigoLargoFibra.Consultar(EntidadCastigoLargoFibra)
        DgvLargoDetalle.DataSource = EntidadCastigoLargoFibra.TablaConsulta
        PropiedadesDgvDetalles()
    End Sub
    Private Sub ConsultaModosEquivalenteDetalle()
        Dim EntidadCastigoLargoFibra As New Capa_Entidad.CastigoLargoFibra
        Dim NegocioCastigoLargoFibra As New Capa_Negocio.CastigoLargoFibra
        Dim Tabla As New DataTable
        EntidadCastigoLargoFibra.Consulta = Consulta.ConsultaEquivalente
        EntidadCastigoLargoFibra.IdModoEncabezado = Val(TbIdModoLargoFibraEncabezado.Text)
        NegocioCastigoLargoFibra.Consultar(EntidadCastigoLargoFibra)
        DgvEquivalente.DataSource = EntidadCastigoLargoFibra.TablaConsulta
        PropiedadesDgvEquivalente()
    End Sub
    Private Sub AgregaCamposTablaDetalles()
        TablaDetalles.Columns.Clear()
        TablaDetalles.Columns.Add(New DataColumn("IdModoDetalle", Type.GetType("System.Int32")))
        TablaDetalles.Columns.Add(New DataColumn("IdModoEncabezado", Type.GetType("System.Int32")))
        TablaDetalles.Columns.Add(New DataColumn("Rango1", Type.GetType("System.Decimal")))
        TablaDetalles.Columns.Add(New DataColumn("Rango2", Type.GetType("System.Decimal")))
        TablaDetalles.Columns.Add(New DataColumn("ColorGrade", Type.GetType("System.String")))
        TablaDetalles.Columns.Add(New DataColumn("Castigo", Type.GetType("System.Decimal")))
        TablaDetalles.Columns.Add(New DataColumn("IdEstatus", Type.GetType("System.Int32")))
        TablaDetalles.Columns.Add(New DataColumn("Seleccionar", Type.GetType("System.Boolean")))
    End Sub
    Private Sub AgregaCamposTablaEquivalente()
        TablaEquivalente.Columns.Clear()
        TablaEquivalente.Columns.Add(New DataColumn("IdModoDetalle", Type.GetType("System.Int32")))
        TablaEquivalente.Columns.Add(New DataColumn("IdModoEncabezado", Type.GetType("System.Int32")))
        TablaEquivalente.Columns.Add(New DataColumn("ModoComercializacion", Type.GetType("System.Int32")))
        TablaEquivalente.Columns.Add(New DataColumn("Rango1", Type.GetType("System.Decimal")))
        TablaEquivalente.Columns.Add(New DataColumn("Rango2", Type.GetType("System.Decimal")))
        TablaEquivalente.Columns.Add(New DataColumn("LenghtNDS", Type.GetType("System.Int32")))
        TablaEquivalente.Columns.Add(New DataColumn("Seleccionar", Type.GetType("System.Boolean")))
    End Sub
    Private Sub PropiedadesDgvEncabezado()
        DgvEncabezado.Columns("ModoComercializacion").Visible = False
    End Sub
    Private Sub PropiedadesDgvDetalles()
        If DgvLargoDetalle.Rows.Count > 0 Then
            If DgvLargoDetalle.Columns("Sel") Is Nothing Then
                Dim colSel As New DataGridViewCheckBoxColumn
                colSel.Name = "Sel"
                colSel.HeaderText = "Seleccionar"
                DgvLargoDetalle.Columns.Insert(7, colSel)
            End If
            DgvLargoDetalle.Columns("IdModoDetalle").Visible = False
            DgvLargoDetalle.Columns("IdModoEncabezado").Visible = False
            DgvLargoDetalle.Columns("ColorGrade").Visible = False
            DgvLargoDetalle.Columns("IdEstatus").Visible = False
        End If
    End Sub
    Private Sub PropiedadesDgvEquivalente()
        If DgvEquivalente.Rows.Count > 0 Then
            If DgvEquivalente.Columns("Sel") Is Nothing Then
                Dim colSel As New DataGridViewCheckBoxColumn
                colSel.Name = "Sel"
                colSel.HeaderText = "Seleccionar"
                DgvEquivalente.Columns.Insert(6, colSel)
            End If
            DgvEquivalente.Columns("IdLargoFibraDetalle").Visible = False
            DgvEquivalente.Columns("IdModoEncabezado").Visible = False
            DgvEquivalente.Columns("ModoComercializacion").Visible = False
        End If
    End Sub
    Private Sub AgregarATablaDetalle()
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaDetalles.Clear()
        DgvLargoDetalle.EndEdit()
        Try
            For Each row As DataGridViewRow In DgvLargoDetalle.Rows
                index = Convert.ToUInt64(row.Index)
                If DgvLargoDetalle.Rows(index).Cells("Rango1").Value IsNot Nothing Or DgvLargoDetalle.Rows(index).Cells("Rango2").Value IsNot Nothing Then
                    rengloninsertar = TablaDetalles.NewRow()
                    rengloninsertar("IdModoDetalle") = IIf(DgvLargoDetalle.Rows(index).Cells("IdModoDetalle").Value Is Nothing, 0, DgvLargoDetalle.Rows(index).Cells("IdModoDetalle").Value)
                    rengloninsertar("IdModoEncabezado") = Val(DgvLargoDetalle.Text)
                    rengloninsertar("Rango1") = DgvLargoDetalle.Rows(index).Cells("Rango1").Value
                    rengloninsertar("Rango2") = DgvLargoDetalle.Rows(index).Cells("Rango2").Value
                    rengloninsertar("ColorGrade") = 0
                    rengloninsertar("Castigo") = DgvLargoDetalle.Rows(index).Cells("Castigo").Value
                    rengloninsertar("IdEstatus") = 1
                    TablaDetalles.Rows.Add(rengloninsertar)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub AgregarATablaEquivalente()
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaEquivalente.Clear()
        DgvEquivalente.EndEdit()
        Try
            For Each row As DataGridViewRow In DgvEquivalente.Rows
                index = Convert.ToUInt64(row.Index)
                If DgvEquivalente.Rows(index).Cells("Rango1").Value IsNot Nothing Or DgvEquivalente.Rows(index).Cells("Rango2").Value IsNot Nothing Then
                    rengloninsertar = TablaEquivalente.NewRow()
                    rengloninsertar("IdModoDetalle") = IIf(DgvEquivalente.Rows(index).Cells("IdLargoFibraDetalle").Value Is Nothing, 0, DgvEquivalente.Rows(index).Cells("IdLargoFibraDetalle").Value)
                    rengloninsertar("IdModoEncabezado") = Val(DgvEquivalente.Text)
                    rengloninsertar("ModoComercializacion") = CbTipoContrato.SelectedValue
                    rengloninsertar("Rango1") = DgvEquivalente.Rows(index).Cells("Rango1").Value
                    rengloninsertar("Rango2") = DgvEquivalente.Rows(index).Cells("Rango2").Value
                    rengloninsertar("LenghtNDS") = DgvEquivalente.Rows(index).Cells("LenghtNDS").Value
                    TablaEquivalente.Rows.Add(rengloninsertar)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If TbDescripcion.Text = "" Or CbTipoContrato.SelectedValue = "" Then
            MsgBox("No se permite guardar con campos vacios.")
        Else
            Guardar()
        End If
    End Sub
    Private Sub Guardar()
        Dim EntidadCastigoLargoFibra As New Capa_Entidad.CastigoLargoFibra
        Dim NegocioCastigoLargoFibra As New Capa_Negocio.CastigoLargoFibra
        AgregarATablaDetalle()
        AgregarATablaEquivalente()
        EntidadCastigoLargoFibra.IdModoEncabezado = IIf(TbIdModoLargoFibraEncabezado.Text = "", 0, TbIdModoLargoFibraEncabezado.Text)
        EntidadCastigoLargoFibra.Descripcion = TbDescripcion.Text
        EntidadCastigoLargoFibra.IdModoComercializacion = CbTipoContrato.SelectedValue
        EntidadCastigoLargoFibra.IdEstatus = CbEstatus.SelectedValue
        EntidadCastigoLargoFibra.TablaModosDetalle = TablaDetalles
        EntidadCastigoLargoFibra.TablaModosEquivalente = TablaEquivalente
        NegocioCastigoLargoFibra.Guardar(EntidadCastigoLargoFibra)
        TbIdModoLargoFibraEncabezado.Text = EntidadCastigoLargoFibra.IdModoEncabezado
        MsgBox("Realizado Correctamente")
        DgvEquivalente.Columns.Clear()
        DgvLargoDetalle.Columns.Clear()
        ConsultaModosLargoFibra()
        ConsultaModosDetalleparametro(TbIdModoLargoFibraEncabezado.Text)
        ConsultaModosEquivalenteDetalleparametro(TbIdModoLargoFibraEncabezado.Text)
    End Sub
    Private Sub ConsultaModosDetalleparametro(ByVal Id As Integer)
        Dim EntidadCastigoLargoFibra As New Capa_Entidad.CastigoLargoFibra
        Dim NegocioCastigoLargoFibra As New Capa_Negocio.CastigoLargoFibra
        Dim Tabla As New DataTable
        EntidadCastigoLargoFibra.Consulta = Consulta.ConsultaDetallada
        EntidadCastigoLargoFibra.IdModoEncabezado = Id
        NegocioCastigoLargoFibra.Consultar(EntidadCastigoLargoFibra)
        DgvLargoDetalle.DataSource = EntidadCastigoLargoFibra.TablaConsulta
        PropiedadesDgvDetalles()
    End Sub
    Private Sub ConsultaModosEquivalenteDetalleparametro(ByVal Id As Integer)
        Dim EntidadCastigoLargoFibra As New Capa_Entidad.CastigoLargoFibra
        Dim NegocioCastigoLargoFibra As New Capa_Negocio.CastigoLargoFibra
        Dim Tabla As New DataTable
        EntidadCastigoLargoFibra.Consulta = Consulta.ConsultaEquivalente
        EntidadCastigoLargoFibra.IdModoEncabezado = Id
        NegocioCastigoLargoFibra.Consultar(EntidadCastigoLargoFibra)
        DgvEquivalente.DataSource = EntidadCastigoLargoFibra.TablaConsulta
        PropiedadesDgvEquivalente()
    End Sub
    'Private Sub ConsultaRendimientos()
    '    Dim EntidadCastigoLargoFibra As New Capa_Entidad.CastigoLargoFibra
    '    Dim NegocioCastigoLargoFibra As New Capa_Negocio.CastigoLargoFibra
    '    Dim Tabla As New DataTable
    '    EntidadCastigoLargoFibra.Consulta = Consulta.ConsultaDetallada
    '    NegocioCastigoLargoFibra.Consultar(EntidadCastigoLargoFibra)
    '    DgvLargoDetalle.DataSource = EntidadCastigoLargoFibra.TablaConsulta
    'End Sub
    Private Sub DgvEncabezado_DoubleClick(sender As Object, e As EventArgs) Handles DgvEncabezado.DoubleClick
        If DgvEncabezado.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvEncabezado.CurrentCell.RowIndex
            TbIdModoLargoFibraEncabezado.Text = DgvEncabezado.Rows(index).Cells("IdModoEncabezado").Value
            TbDescripcion.Text = DgvEncabezado.Rows(index).Cells("Descripcion").Value
            CbTipoContrato.SelectedValue = DgvEncabezado.Rows(index).Cells("ModoComercializacion").Value
            CbEstatus.SelectedValue = DgvEncabezado.Rows(index).Cells("IdEstatus").Value
            DgvLargoDetalle.Columns.Clear()
            DgvEquivalente.Columns.Clear()
            ConsultaModosDetalle()
            ConsultaModosEquivalenteDetalle()
        End If
    End Sub
    Private Sub CargarExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarExcelToolStripMenuItem.Click
        DgvLargoDetalle.Columns.Clear()
        importarexceltablacastigos(DgvLargoDetalle)
        PropiedadesDgvDetalles()
    End Sub
    Private Sub CargarExcelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarExcelToolStripMenuItem1.Click
        DgvEquivalente.Columns.Clear()
        importarexceltablacastequiv(DgvEquivalente)
        PropiedadesDgvEquivalente()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ExportarAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
        If DgvLargoDetalle.Rows.Count > 0 Then
            ExportExcel(DgvLargoDetalle)
        End If
    End Sub

    Private Sub ExportarAExcelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExportarAExcelToolStripMenuItem1.Click
        If DgvEquivalente.Rows.Count > 0 Then
            ExportExcel(DgvEquivalente)
        End If
    End Sub
End Class
