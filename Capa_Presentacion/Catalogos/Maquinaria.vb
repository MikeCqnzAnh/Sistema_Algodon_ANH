Imports Capa_Operacion.Configuracion
Public Class Maquinaria
    Private Sub Maquinaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaMaquinaria()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadMaquinaria As New Capa_Entidad.Maquinaria
        Dim NegocioMaquinaria As New Capa_Negocio.Maquinaria
        EntidadMaquinaria.IdMaquinaria = IIf(TbIdMaquinaria.Text = "", 0, TbIdMaquinaria.Text)
        EntidadMaquinaria.Descripcion = TbDescripcion.Text
        EntidadMaquinaria.IdEstatus = CbEstatus.SelectedValue
        EntidadMaquinaria.IdUsuarioCreacion = 1
        EntidadMaquinaria.FechaCreacion = Now
        NegocioMaquinaria.Guardar(EntidadMaquinaria)
        TbIdMaquinaria.Text = EntidadMaquinaria.IdMaquinaria
        MsgBox("Realizado Correctamente")
        ConsultaMaquinaria()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ConsultaMaquinaria()
        Dim EntidadMaquinaria As New Capa_Entidad.Maquinaria
        Dim NegocioMaquinaria As New Capa_Negocio.Maquinaria
        Dim Tabla As New DataTable
        EntidadMaquinaria.Consulta = Consulta.ConsultaDetallada
        NegocioMaquinaria.Consultar(EntidadMaquinaria)
        DgvMaquinaria.DataSource = EntidadMaquinaria.TablaConsulta
    End Sub

    Private Sub Limpiar()
        TbIdMaquinaria.Text = ""
        TbDescripcion.Text = ""
        CbEstatus.SelectedValue = 1
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

    Private Sub TbDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbDescripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class