Imports Capa_Operacion.Configuracion
Public Class Empleados
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaEmpleados()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadEmpleados As New Capa_Entidad.Empleados
        Dim NegocioEmpleados As New Capa_Negocio.Empleados
        EntidadEmpleados.IdEmpleado = IIf(TbIdEmpleado.Text = "", 0, TbIdEmpleado.Text)
        EntidadEmpleados.Nombre = TbNombre.Text
        EntidadEmpleados.IdPuesto = CbPuesto.SelectedValue
        EntidadEmpleados.IdEstatus = CbEstatus.SelectedValue
        EntidadEmpleados.IdUsuarioCreacion = 1
        EntidadEmpleados.FechaCreacion = Now
        NegocioEmpleados.Guardar(EntidadEmpleados)
        TbIdEmpleado.Text = EntidadEmpleados.IdPuesto
        MsgBox("Realizado Correctamente")
        ConsultaEmpleados()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Limpiar()
        TbIdEmpleado.Text = ""
        TbNombre.Text = ""
        CbPuesto.SelectedValue = 1
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
        '---------------------------COMBO PUESTO
        Dim EntidadEmpleados As New Capa_Entidad.Empleados
        Dim NegocioEmpleados As New Capa_Negocio.Empleados
        Dim Tabla As New DataTable
        EntidadEmpleados.Consulta = Consulta.ConsultaExterna
        NegocioEmpleados.Consultar(EntidadEmpleados)
        CbPuesto.DataSource = EntidadEmpleados.TablaConsulta
        CbPuesto.ValueMember = "IdPuesto"
        CbPuesto.DisplayMember = "Descripcion"
        CbPuesto.SelectedValue = 1
    End Sub

    Private Sub ConsultaEmpleados()
        Dim EntidadEmpleados As New Capa_Entidad.Empleados
        Dim NegocioEmpleados As New Capa_Negocio.Empleados
        Dim Tabla As New DataTable
        'EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadEmpleados.Consulta = Consulta.ConsultaDetallada
        NegocioEmpleados.Consultar(EntidadEmpleados)
        DgvEmpleados.DataSource = EntidadEmpleados.TablaConsulta
    End Sub
End Class