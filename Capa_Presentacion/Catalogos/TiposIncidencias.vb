Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class TiposIncidencias
    Private Sub TiposIncidencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaTipoIncidencia()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadTIposIncidencias As New Capa_Entidad.TiposIncidencias
        Dim NegocioTiposIncidencias As New Capa_Negocio.TiposIncidencias
        EntidadTIposIncidencias.IdTipoIncidencia = IIf(TbIdTipoIncidencia.Text = "", 0, TbIdTipoIncidencia.Text)
        EntidadTIposIncidencias.Descripcion = TbDescripcion.Text
        EntidadTIposIncidencias.IdEstatus = CbEstatus.SelectedValue
        EntidadTIposIncidencias.IdUsuarioCreacion = 1
        EntidadTIposIncidencias.FechaCreacion = Now
        NegocioTiposIncidencias.Guardar(EntidadTIposIncidencias)
        TbIdTipoIncidencia.Text = EntidadTIposIncidencias.IdTipoIncidencia
        MsgBox("Realizado Correctamente")
        ConsultaTipoIncidencia()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Limpiar()
        TbIdTipoIncidencia.Text = ""
        TbDescripcion.Text = ""
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub ConsultaTipoIncidencia()
        Dim EntidadTiposIncidencias As New Capa_Entidad.TiposIncidencias
        Dim NegocioTiposIncidencias As New Capa_Negocio.TiposIncidencias
        Dim Tabla As New DataTable
        'EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadTiposIncidencias.Consulta = Consulta.ConsultaDetallada
        NegocioTiposIncidencias.Consultar(EntidadTiposIncidencias)
        DgvTipoIncidencia.DataSource = EntidadTiposIncidencias.TablaConsulta
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
End Class