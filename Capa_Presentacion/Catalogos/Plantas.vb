Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class Plantas
    Private Sub Plantas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaPlantas()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadPlantas As New Capa_Entidad.Plantas
        Dim NegocioPlantas As New Capa_Negocio.Plantas
        EntidadPlantas.IdPlanta = IIf(TbIdPlanta.Text = "", 0, TbIdPlanta.Text)
        EntidadPlantas.Descripcion = TbDescripcion.Text
        EntidadPlantas.Registro = TbRegistro.Text
        EntidadPlantas.IdEstatus = CbEstatus.SelectedValue
        EntidadPlantas.IdUsuarioCreacion = 1
        EntidadPlantas.FechaCreacion = Now
        NegocioPlantas.Guardar(EntidadPlantas)
        TbIdPlanta.Text = EntidadPlantas.IdPlanta
        MsgBox("Realizado Correctamente")
        ConsultaPlantas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
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
        TbIdPlanta.Text = ""
        TbDescripcion.Text = ""
        TbRegistro.Text = ""
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub ConsultaPlantas()
        Dim EntidadPlantas As New Capa_Entidad.Plantas
        Dim NegocioPlantas As New Capa_Negocio.Plantas
        Dim Tabla As New DataTable
        'EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadPlantas.Consulta = Consulta.ConsultaDetallada
        NegocioPlantas.Consultar(EntidadPlantas)
        DgvPlantas.DataSource = EntidadPlantas.TablaConsulta
    End Sub
End Class