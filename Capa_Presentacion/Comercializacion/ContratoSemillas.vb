Imports Capa_Operacion.Configuracion
Public Class ContratoSemillas
    Private Sub ContratoSemillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLenarCombos()
        Limpiar()
        ConsultaContratosSemilla()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadContratoSemillas As New Capa_Entidad.ContratoSemillas
        Dim NegocioContratoSemillas As New Capa_Negocio.ContratoSemillas
        EntidadContratoSemillas.IdContratoSemilla = IIf(TbIdContratoSemilla.Text = "", 0, TbIdContratoSemilla.Text)
        EntidadContratoSemillas.Folio = TbFolio.Text
        EntidadContratoSemillas.Fecha = DtpFecha.Value
        EntidadContratoSemillas.IdComprador = CbComprador.SelectedValue
        EntidadContratoSemillas.Cantidad = TbCantidad.Text
        EntidadContratoSemillas.IdEstatus = CbEstatus.SelectedValue
        EntidadContratoSemillas.PrecioTonelada = TbPrecioTonelada.Text
        EntidadContratoSemillas.Testigo1 = TbTestigo1.Text
        EntidadContratoSemillas.Testigo2 = TbTestigo2.Text
        EntidadContratoSemillas.IdUsuarioCreacion = 1
        EntidadContratoSemillas.FechaCreacion = Now
        EntidadContratoSemillas.IdUsuarioActualizacion = 1
        EntidadContratoSemillas.FechaActualizacion = Now
        NegocioContratoSemillas.Guardar(EntidadContratoSemillas)
        TbIdContratoSemilla.Text = EntidadContratoSemillas.IdContratoSemilla
        ConsultaContratosSemilla()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbIdContratoSemilla.Text = ""
        TbFolio.Text = ""
        DtpFecha.Value = Now
        CbComprador.SelectedValue = 1
        TbCantidad.Text = ""
        CbEstatus.SelectedValue = 1
        TbPrecioTonelada.Text = ""
        TbTestigo1.Text = ""
        TbTestigo2.Text = ""
    End Sub

    Private Sub LLenarCombos()
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
        '---------------------------COMBO COMPRADORES
        Dim EntidadContratoSemillas As New Capa_Entidad.ContratoSemillas
        Dim NegocioContratoSemillas As New Capa_Negocio.ContratoSemillas
        Dim Tabla As New DataTable
        EntidadContratoSemillas.Consulta = Consulta.ConsultaCompradores
        NegocioContratoSemillas.Consultar(EntidadContratoSemillas)
        CbComprador.DataSource = EntidadContratoSemillas.TablaConsulta
        CbComprador.ValueMember = "IdComprador"
        CbComprador.DisplayMember = "Nombre"
        CbComprador.SelectedValue = 1
    End Sub
    Private Sub ConsultaContratosSemilla()
        Dim EntidadContratoSemillas As New Capa_Entidad.ContratoSemillas
        Dim NegocioContratoSemillas As New Capa_Negocio.ContratoSemillas
        Dim Tabla As New DataTable
        EntidadContratoSemillas.Consulta = Consulta.ConsultaBasica
        NegocioContratoSemillas.Consultar(EntidadContratoSemillas)
        DgvContratoSemillas.DataSource = EntidadContratoSemillas.TablaConsulta
    End Sub

    Private Sub DgvContratoSemillas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContratoSemillas.CellContentDoubleClick
        Dim EntidadContratoSemillas As New Capa_Entidad.ContratoSemillas
        Dim NegocioContratoSemillas As New Capa_Negocio.ContratoSemillas
        Dim TablaDetalle As New DataTable
        Dim index As Integer
        index = DgvContratoSemillas.CurrentRow.Index
        EntidadContratoSemillas.IdContratoSemilla = DgvContratoSemillas.Rows(index).Cells("IdContratoSemilla").Value.ToString()
        EntidadContratoSemillas.Consulta = Consulta.ConsultaDetallada
        NegocioContratoSemillas.Consultar(EntidadContratoSemillas)
        TablaDetalle = EntidadContratoSemillas.TablaConsulta
        TbIdContratoSemilla.Text = TablaDetalle.Rows(0).Item("IdContratoSemilla")
        TbFolio.Text = TablaDetalle.Rows(0).Item("Folio")
        DtpFecha.Value = TablaDetalle.Rows(0).Item("Fecha")
        CbComprador.SelectedValue = TablaDetalle.Rows(0).Item("IdComprador")
        CbEstatus.SelectedValue = TablaDetalle.Rows(0).Item("IdEstatus")
        TbCantidad.Text = TablaDetalle.Rows(0).Item("Cantidad")
        TbPrecioTonelada.Text = TablaDetalle.Rows(0).Item("PrecioTonelada")
        TbTestigo1.Text = TablaDetalle.Rows(0).Item("Testigo1")
        TbTestigo2.Text = TablaDetalle.Rows(0).Item("Testigo2")
        'InhabilitarBotones()
    End Sub
End Class