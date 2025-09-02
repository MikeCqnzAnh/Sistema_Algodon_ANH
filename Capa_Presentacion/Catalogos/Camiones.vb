Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class Camiones
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadCamiones As New Capa_Entidad.Camiones
        Dim NegocioCamiones As New Capa_Negocio.Camiones
        EntidadCamiones.IdCamion = IIf(TbIdCamion.Text = "", 0, TbIdCamion.Text)
        EntidadCamiones.Descripcion = TbDescripcion.Text
        EntidadCamiones.Placas = TbPlacas.Text
        EntidadCamiones.IdEstatus = CbEstatus.SelectedValue
        EntidadCamiones.IdUsuarioCreacion = 1
        EntidadCamiones.FechaCreacion = Now
        NegocioCamiones.Guardar(EntidadCamiones)
        TbIdCamion.Text = EntidadCamiones.IdCamion
        MsgBox("Realizado Correctamente")
        ConsultaCamiones()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Camiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaCamiones()
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

    Private Sub Limpiar()
        TbIdCamion.Text = ""
        TbDescripcion.Text = ""
        TbPlacas.Text = ""
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub ConsultaCamiones()
        Dim EntidadCamiones As New Capa_Entidad.Camiones
        Dim NegocioCamiones As New Capa_Negocio.Camiones
        Dim Tabla As New DataTable
        EntidadCamiones.Consulta = Consulta.ConsultaDetallada
        NegocioCamiones.Consultar(EntidadCamiones)
        DgvPlantas.DataSource = EntidadCamiones.TablaConsulta
    End Sub
End Class