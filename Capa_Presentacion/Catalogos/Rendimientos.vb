Imports Capa_Operacion.Configuracion
Public Class Rendimientos
    Private Sub Rendimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaRendimientos()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadRendimientos As New Capa_Entidad.Rendimientos
        Dim NegocioRendimientos As New Capa_Negocio.Rendimientos
        EntidadRendimientos.IdRendimiento = IIf(TbIdRendimiento.Text = "", 0, TbIdRendimiento.Text)
        EntidadRendimientos.Pluma = TbPluma.Text
        EntidadRendimientos.Semilla = TbSemilla.Text
        EntidadRendimientos.IdEstatus = CbEstatus.SelectedValue
        EntidadRendimientos.IdUsuarioCreacion = 1
        EntidadRendimientos.FechaCreacion = Now
        NegocioRendimientos.Guardar(EntidadRendimientos)
        TbIdRendimiento.Text = EntidadRendimientos.IdRendimiento
        MsgBox("Realizado Correctamente")
        ConsultaRendimientos()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub ConsultaRendimientos()
        Dim EntidadRendimientos As New Capa_Entidad.Rendimientos
        Dim NegocioRendimientos As New Capa_Negocio.Rendimientos
        Dim Tabla As New DataTable
        EntidadRendimientos.Consulta = Consulta.ConsultaDetallada
        NegocioRendimientos.Consultar(EntidadRendimientos)
        DgvRendimientos.DataSource = EntidadRendimientos.TablaConsulta
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
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        TbIdRendimiento.Text = ""
        TbPluma.Text = 0
        TbSemilla.Text = 0
        CbEstatus.SelectedValue = 1
        DgvRendimientos.DataSource = ""
        ConsultaRendimientos()
    End Sub

End Class