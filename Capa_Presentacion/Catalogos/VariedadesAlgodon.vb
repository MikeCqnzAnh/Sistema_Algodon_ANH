Imports Capa_Operacion.Configuracion
Public Class VariedadesAlgodon
    Private Sub VariedadesAlgodon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaVariedadesAlgodon()
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
    Private Sub limpiar()
        TbDescripcion.Text = ""
        TbIdVariedadAlgodon.Text = ""
        CbEstatus.SelectedIndex = 1
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub ConsultaVariedadesAlgodon()
        Dim EntidadVariedadesAlgodon As New Capa_Entidad.VariedadesAlgodon
        Dim NegocioVariedadesAlgodon As New Capa_Negocio.VariedadesAlgodon
        Dim Tabla As New DataTable
        EntidadVariedadesAlgodon.Consulta = Consulta.ConsultaDetallada
        NegocioVariedadesAlgodon.Consultar(EntidadVariedadesAlgodon)
        DgvVariedadesAlgodon.DataSource = EntidadVariedadesAlgodon.TablaConsulta
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadVariedadesAlgodon As New Capa_Entidad.VariedadesAlgodon
        Dim NegocioVariedadesAlgodon As New Capa_Negocio.VariedadesAlgodon
        EntidadVariedadesAlgodon.IdVariedadAlgodon = IIf(TbIdVariedadAlgodon.Text = "", 0, TbIdVariedadAlgodon.Text)
        EntidadVariedadesAlgodon.Descripcion = TbDescripcion.Text
        EntidadVariedadesAlgodon.IdEstatus = CbEstatus.SelectedValue
        EntidadVariedadesAlgodon.IdUsuarioCreacion = 1
        EntidadVariedadesAlgodon.FechaCreacion = Now
        NegocioVariedadesAlgodon.Guardar(EntidadVariedadesAlgodon)
        TbIdVariedadAlgodon.Text = EntidadVariedadesAlgodon.IdVariedadAlgodon
        MsgBox("Realizado Correctamente")
        ConsultaVariedadesAlgodon()
    End Sub

    Private Sub DgvProfesionales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVariedadesAlgodon.CellContentClick

    End Sub
End Class