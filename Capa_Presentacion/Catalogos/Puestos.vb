Imports Capa_Operacion.Configuracion
Public Class Puestos
    Private Sub Puestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaPuesto()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadPuestos As New Capa_Entidad.Puestos
        Dim NegocioPuestos As New Capa_Negocio.Puestos
        EntidadPuestos.IdPuesto = IIf(TbIdPuesto.Text = "", 0, TbIdPuesto.Text)
        EntidadPuestos.Descripcion = TbDescripcion.Text
        EntidadPuestos.IdEstatus = CbEstatus.SelectedValue
        EntidadPuestos.IdUsuarioCreacion = 1
        EntidadPuestos.FechaCreacion = Now
        NegocioPuestos.Guardar(EntidadPuestos)
        TbIdPuesto.Text = EntidadPuestos.IdPuesto
        MsgBox("Realizado Correctamente")
        ConsultaPuesto()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Limpiar()
        TbIdPuesto.Text = ""
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

    Private Sub ConsultaPuesto()
        Dim EntidadPuestos As New Capa_Entidad.Puestos
        Dim NegocioPuestos As New Capa_Negocio.Puestos
        Dim Tabla As New DataTable
        'EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadPuestos.Consulta = Consulta.ConsultaDetallada
        NegocioPuestos.Consultar(EntidadPuestos)
        DgvPuestos.DataSource = EntidadPuestos.TablaConsulta
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