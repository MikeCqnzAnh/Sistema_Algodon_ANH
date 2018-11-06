Imports Capa_Operacion.Configuracion
Public Class ProfesionalesFitosanitarios
    Private Sub ProfesionalesFitosanitarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaProfesionalesFitosanitarios()
    End Sub
    Private Sub ConsultaProfesionalesFitosanitarios()
        Dim EntidadProfesionalesFitosanitarios As New Capa_Entidad.ProfesionalesFitosanitarios
        Dim NegocioProfesionalesFitosanitarios As New Capa_Negocio.ProfesionalesFitosanitarios
        Dim Tabla As New DataTable
        EntidadProfesionalesFitosanitarios.Consulta = Consulta.ConsultaDetallada
        NegocioProfesionalesFitosanitarios.Consultar(EntidadProfesionalesFitosanitarios)
        DgvProfesionales.DataSource = EntidadProfesionalesFitosanitarios.TablaConsulta
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
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadProfesionalesFitosanitarios As New Capa_Entidad.ProfesionalesFitosanitarios
        Dim NegocioProfesionalesFitosanitarios As New Capa_Negocio.ProfesionalesFitosanitarios
        EntidadProfesionalesFitosanitarios.IdProfesionales = IIf(TbIdProfesionales.Text = "", 0, TbIdProfesionales.Text)
        EntidadProfesionalesFitosanitarios.Descripcion = TbDescripcion.Text
        EntidadProfesionalesFitosanitarios.IdEstatus = CbEstatus.SelectedValue
        EntidadProfesionalesFitosanitarios.IdUsuarioCreacion = 1
        EntidadProfesionalesFitosanitarios.FechaCreacion = Now
        NegocioProfesionalesFitosanitarios.Guardar(EntidadProfesionalesFitosanitarios)
        TbIdProfesionales.Text = EntidadProfesionalesFitosanitarios.IdProfesionales
        MsgBox("Realizado Correctamente")
        ConsultaProfesionalesFitosanitarios()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbIdProfesionales.Text = ""
        TbDescripcion.Text = ""
        CbEstatus.SelectedValue = 1
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
End Class