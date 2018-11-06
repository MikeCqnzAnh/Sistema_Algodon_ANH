Imports Capa_Operacion.Configuracion
Public Class IncidenciaOperaciones
    Private Sub IncidenciaOperaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        ConsultaIncidencias()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadIncidenciaOperaciones As New Capa_Entidad.IncidenciaOperaciones
        Dim NegocioIncidenciaOperaciones As New Capa_Negocio.IncidenciaOperaciones
        EntidadIncidenciaOperaciones.IdIncidencia = IIf(TbIdIncidencia.Text = "", 0, TbIdIncidencia.Text)
        EntidadIncidenciaOperaciones.IdTipo = CbTipo.SelectedValue
        EntidadIncidenciaOperaciones.Descripcion = TbDescripcion.Text
        EntidadIncidenciaOperaciones.IdEstatus = CbEstatus.SelectedValue
        EntidadIncidenciaOperaciones.IdUsuarioCreacion = 1
        EntidadIncidenciaOperaciones.FechaCreacion = Now
        NegocioIncidenciaOperaciones.Guardar(EntidadIncidenciaOperaciones)
        TbIdIncidencia.Text = EntidadIncidenciaOperaciones.IdIncidencia
        MsgBox("Realizado Correctamente")
        ConsultaIncidencias()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Limpiar()
        TbIdIncidencia.Text = ""
        CbTipo.SelectedValue = 1
        TbDescripcion.Text = ""
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub ConsultaIncidencias()
        Dim EntidadIncidenciaOperaciones As New Capa_Entidad.IncidenciaOperaciones
        Dim NegocioIncidenciaOperaciones As New Capa_Negocio.IncidenciaOperaciones
        Dim Tabla As New DataTable
        EntidadIncidenciaOperaciones.Consulta = Consulta.ConsultaDetallada
        NegocioIncidenciaOperaciones.Consultar(EntidadIncidenciaOperaciones)
        DgvIncidencia.DataSource = EntidadIncidenciaOperaciones.TablaConsulta
    End Sub

    Private Sub LlenarCombos()
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
        '---------------------------COMBO TIPO INCIDENCIA
        Dim EntidadIncidenciaOperaciones As New Capa_Entidad.IncidenciaOperaciones
        Dim NegocioIncidenciaOperaciones As New Capa_Negocio.IncidenciaOperaciones
        Dim Tabla As New DataTable
        EntidadIncidenciaOperaciones.Consulta = Consulta.ConsultaExterna
        NegocioIncidenciaOperaciones.Consultar(EntidadIncidenciaOperaciones)
        CbTipo.DataSource = EntidadIncidenciaOperaciones.TablaConsulta
        CbTipo.ValueMember = "IdTipoIncidencia"
        CbTipo.DisplayMember = "Descripcion"
        CbTipo.SelectedValue = 1
    End Sub
End Class