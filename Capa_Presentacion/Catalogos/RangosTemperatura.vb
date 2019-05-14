Imports Capa_Operacion.Configuracion
Public Class RangosTemperatura
    Private Sub RangosTemperatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultarRangos()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadRangosTemperatura As New Capa_Entidad.RangosTemperatura
        Dim NegocioRangosTemperatura As New Capa_Negocio.RangosTemperatura
        EntidadRangosTemperatura.IdRango = IIf(TbIdRango.Text = "", 0, TbIdRango.Text)
        EntidadRangosTemperatura.RangoInicial = TbRangoInicial.Text
        EntidadRangosTemperatura.RangoInicial = TbRangoFinal.Text
        EntidadRangosTemperatura.DentroLimite = ChkDentroLim.Checked
        EntidadRangosTemperatura.IdEstatus = CbEstatus.SelectedValue
        EntidadRangosTemperatura.IdUsuarioCreacion = 1
        EntidadRangosTemperatura.FechaCreacion = Now
        NegocioRangosTemperatura.Guardar(EntidadRangosTemperatura)
        TbIdRango.Text = EntidadRangosTemperatura.IdRango
        MsgBox("Realizado Correctamente")
        ConsultarRangos()
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
        TbIdRango.Text = ""
        TbRangoInicial.Text = ""
        TbRangoFinal.Text = ""
        ChkDentroLim.Checked = False
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub ConsultarRangos()
        Dim EntidadRangosTemperatura As New Capa_Entidad.RangosTemperatura
        Dim NegocioRangosTemperatura As New Capa_Negocio.RangosTemperatura
        Dim Tabla As New DataTable
        EntidadRangosTemperatura.Consulta = Consulta.ConsultaDetallada
        NegocioRangosTemperatura.Consultar(EntidadRangosTemperatura)
        DgvRangos.DataSource = EntidadRangosTemperatura.TablaConsulta
    End Sub

    Private Sub TbRangoInicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbRangoInicial.KeyPress, TbRangoFinal.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class