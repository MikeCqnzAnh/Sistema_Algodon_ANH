Imports Capa_Operacion.Configuracion
Public Class CastigoLargoFibra
    Private Sub CastigoLargoFibra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        limpiarCampos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiarCampos()
        CargarCombos()
    End Sub
    Private Sub limpiarCampos()
        TbIdCastigoLargoFibra.Text = ""
        TbRango1.Text = ""
        TbRango2.Text = ""
        TbColorGrade.Text = ""
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
        Dim EntidadCastigoLargoFibra As New Capa_Entidad.CastigoLargoFibra
        Dim NegocioCastigoLargoFibra As New Capa_Negocio.CastigoLargoFibra
        EntidadCastigoLargoFibra.IdCastigoLargoFibra = IIf(TbIdCastigoLargoFibra.Text = "", 0, TbIdCastigoLargoFibra.Text)
        EntidadCastigoLargoFibra.Rango1 = TbRango1.Text
        EntidadCastigoLargoFibra.Rango2 = TbRango2.Text
        EntidadCastigoLargoFibra.ColorGrade = TbColorGrade.Text
        EntidadCastigoLargoFibra.Castigo = TbCastigo.Text
        EntidadCastigoLargoFibra.IdEstatus = CbEstatus.SelectedValue
        EntidadCastigoLargoFibra.IdUsuarioCreacion = 1
        EntidadCastigoLargoFibra.FechaCreacion = Now
        NegocioCastigoLargoFibra.Guardar(EntidadCastigoLargoFibra)
        TbIdCastigoLargoFibra.Text = EntidadCastigoLargoFibra.IdCastigoLargoFibra
        MsgBox("Realizado Correctamente")
        ConsultaRendimientos()
    End Sub
    Private Sub ConsultaRendimientos()
        Dim EntidadCastigoLargoFibra As New Capa_Entidad.CastigoLargoFibra
        Dim NegocioCastigoLargoFibra As New Capa_Negocio.CastigoLargoFibra
        Dim Tabla As New DataTable
        EntidadCastigoLargoFibra.Consulta = Consulta.ConsultaDetallada
        NegocioCastigoLargoFibra.Consultar(EntidadCastigoLargoFibra)
        DgvCastigoLargoFibra.DataSource = EntidadCastigoLargoFibra.TablaConsulta
    End Sub
End Class
