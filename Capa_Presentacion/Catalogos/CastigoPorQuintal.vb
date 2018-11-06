Imports Capa_Operacion.Configuracion
Public Class CastigoPorQuintal
    Private Sub CastigoPorQuintal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        CargarCombos()
        ConsultaCastigoPorQuintal()
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
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadCastigoPorQuintal As New Capa_Entidad.CastigoPorQuintal
        Dim NegocioCastigoPorQuintal As New Capa_Negocio.CastigoPorQuintal
        EntidadCastigoPorQuintal.IdMicro = IIf(TbIdCastigoQuintal.Text = "", 0, TbIdCastigoQuintal.Text)
        EntidadCastigoPorQuintal.Rango1 = TbRango1.Text
        EntidadCastigoPorQuintal.Rango2 = TbRango2.Text
        EntidadCastigoPorQuintal.Castigo = TbCastigo.Text
        EntidadCastigoPorQuintal.IdEstatus = CbEstatus.SelectedValue
        EntidadCastigoPorQuintal.IdUsuarioCreacion = 1
        EntidadCastigoPorQuintal.FechaCreacion = Now
        NegocioCastigoPorQuintal.Guardar(EntidadCastigoPorQuintal)
        TbIdCastigoQuintal.Text = EntidadCastigoPorQuintal.IdMicro
        MsgBox("Realizado Correctamente")
        ConsultaCastigoPorQuintal()
    End Sub
    Private Sub ConsultaCastigoPorQuintal()
        Dim EntidadCastigoPorQuintal As New Capa_Entidad.CastigoPorQuintal
        Dim NegocioCastigoPorQuintal As New Capa_Negocio.CastigoPorQuintal
        Dim Tabla As New DataTable
        EntidadCastigoPorQuintal.Consulta = Consulta.ConsultaDetallada
        NegocioCastigoPorQuintal.Consultar(EntidadCastigoPorQuintal)
        DgvCastigo.DataSource = EntidadCastigoPorQuintal.TablaConsulta
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        TbIdCastigoQuintal.Text = ""
        TbRango1.Text = ""
        TbRango2.Text = ""
        TbCastigo.Text = ""
        CbEstatus.SelectedValue = 1
        DgvCastigo.DataSource = ""
    End Sub
End Class