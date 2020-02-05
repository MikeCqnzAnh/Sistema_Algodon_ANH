Imports Capa_Operacion.Configuracion
Public Class CastigoResistenciaFibra
    Private TablaClases As New DataTable()
    Private Sub CastigoLargoFibra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        limpiarCampos()
        AgregaCamposTablaClases()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiarCampos()
        CargarCombos()
    End Sub
    Private Sub limpiarCampos()
        TbIdResistenciaEncabezado.Text = ""
        TbRango1.Text = ""
        TbRango2.Text = ""
        TbCastigo.Text = ""
        CbEstatus.SelectedValue = 1
        ConsultaResistenciaFibra()
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
    Private Sub ConsultaModosResistenciaFibra()
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        Dim Tabla As New DataTable
        EntidadCastigoResistenciaFibra.Consulta = Consulta.ConsultaEncabezado
        NegocioCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
        DgvEncabezado.DataSource = EntidadCastigoResistenciaFibra.TablaConsulta
        'PropiedadesDgModos()
    End Sub
    Private Sub ConsultaModosDetalle()
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        Dim Tabla As New DataTable
        EntidadCastigoResistenciaFibra.Consulta = Consulta.ConsultaDetallada
        EntidadCastigoResistenciaFibra.IdResistenciaEncabezado = Val(TbIdResistenciaEncabezado.Text)
        NegocioCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
        DgvDetalle.DataSource = EntidadCastigoResistenciaFibra.TablaConsulta
        'PropiedadesDgvDetalle()
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
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        EntidadCastigoResistenciaFibra.IdCastigoResistenciaFibra = IIf(TbIdResistenciaEncabezado.Text = "", 0, TbIdResistenciaEncabezado.Text)
        EntidadCastigoResistenciaFibra.Rango1 = TbRango1.Text
        EntidadCastigoResistenciaFibra.Rango2 = TbRango2.Text
        EntidadCastigoResistenciaFibra.Castigo = TbCastigo.Text
        EntidadCastigoResistenciaFibra.IdEstatus = CbEstatus.SelectedValue
        EntidadCastigoResistenciaFibra.IdUsuarioCreacion = 1
        EntidadCastigoResistenciaFibra.FechaCreacion = Now
        NegocioCastigoResistenciaFibra.Guardar(EntidadCastigoResistenciaFibra)
        TbIdResistenciaEncabezado.Text = EntidadCastigoResistenciaFibra.IdCastigoResistenciaFibra
        MsgBox("Realizado Correctamente")
        ConsultaResistenciaFibra()
    End Sub
    Private Sub ConsultaResistenciaFibra()
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        Dim Tabla As New DataTable
        EntidadCastigoResistenciaFibra.Consulta = Consulta.ConsultaDetallada
        NegocioCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
        'DgvCastigoResistenciaFibra.DataSource = EntidadCastigoResistenciaFibra.TablaConsulta
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class