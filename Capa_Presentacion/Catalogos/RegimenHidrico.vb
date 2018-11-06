Imports Capa_Operacion.Configuracion
Public Class RegimenHidrico
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        TbIdRegimen.Text = ""
        TbDescripcion.Text = ""
        CbEstatus.SelectedValue = 1
        DgvRegimen.DataSource = ""
        ConsultaRegimen()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadRegimenHidrico As New Capa_Entidad.RegimenHidrico
        Dim NegocioRegimenHidrico As New Capa_Negocio.RegimenHidrico
        EntidadRegimenHidrico.IdRegimen = IIf(TbIdRegimen.Text = "", 0, TbIdRegimen.Text)
        EntidadRegimenHidrico.Descripcion = TbDescripcion.Text
        EntidadRegimenHidrico.IdEstatus = CbEstatus.SelectedValue
        EntidadRegimenHidrico.IdUsuarioCreacion = 1
        EntidadRegimenHidrico.FechaCreacion = Now
        NegocioRegimenHidrico.Guardar(EntidadRegimenHidrico)
        TbIdRegimen.Text = EntidadRegimenHidrico.IdRegimen
        MsgBox("Realizado Correctamente")
        ConsultaRegimen()
    End Sub
    Private Sub ConsultaRegimen()
        Dim EntidadRegimenHidrico As New Capa_Entidad.RegimenHidrico
        Dim NegocioRegimenHidrico As New Capa_Negocio.RegimenHidrico
        Dim Tabla As New DataTable
        EntidadRegimenHidrico.Consulta = Consulta.ConsultaDetallada
        NegocioRegimenHidrico.Consultar(EntidadRegimenHidrico)
        DgvRegimen.DataSource = EntidadRegimenHidrico.TablaConsulta
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

    Private Sub RegimenHidrico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaRegimen()
    End Sub
End Class