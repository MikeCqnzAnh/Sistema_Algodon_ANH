Imports Capa_Operacion.Configuracion
Public Class CastigoResistenciaFibra
    Private Sub CastigoLargoFibra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        limpiarCampos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiarCampos()
        CargarCombos()
    End Sub
    Private Sub limpiarCampos()
        TbIdResistenciaFibra.Text = ""
        TbRango1.Text = ""
        TbRango2.Text = ""
        TbCastigo.Text = ""
        CbEstatus.SelectedValue = 1
        ConsultaRendimientos()
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
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        EntidadCastigoResistenciaFibra.IdCastigoResistenciaFibra = IIf(TbIdResistenciaFibra.Text = "", 0, TbIdResistenciaFibra.Text)
        EntidadCastigoResistenciaFibra.Rango1 = TbRango1.Text
        EntidadCastigoResistenciaFibra.Rango2 = TbRango2.Text
        EntidadCastigoResistenciaFibra.Castigo = TbCastigo.Text
        EntidadCastigoResistenciaFibra.IdEstatus = CbEstatus.SelectedValue
        EntidadCastigoResistenciaFibra.IdUsuarioCreacion = 1
        EntidadCastigoResistenciaFibra.FechaCreacion = Now
        NegocioCastigoResistenciaFibra.Guardar(EntidadCastigoResistenciaFibra)
        TbIdResistenciaFibra.Text = EntidadCastigoResistenciaFibra.IdCastigoResistenciaFibra
        MsgBox("Realizado Correctamente")
        ConsultaRendimientos()
    End Sub
    Private Sub ConsultaRendimientos()
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        Dim Tabla As New DataTable
        EntidadCastigoResistenciaFibra.Consulta = Consulta.ConsultaDetallada
        NegocioCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
        DgvCastigoResistenciaFibra.DataSource = EntidadCastigoResistenciaFibra.TablaConsulta
    End Sub
End Class