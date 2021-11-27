Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class UnidadesComercializacion
    Private Sub UnidadesComercializacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbIdUnidad.Text = ""
        TbDescripcion.Text = ""
        NuValorConversion.Value = 0
        DgvUnidades.DataSource = Nothing
        ConsultaUnidades()
    End Sub
    Private Sub ConsultaUnidades()
        Dim EntidadUnidadesComercializacion As New Capa_Entidad.UnidadesComercializacion
        Dim NegocioUnidadesComercializacion As New Capa_Negocio.UnidadesComercializacion
        Dim Tabla As New DataTable
        EntidadUnidadesComercializacion.Consulta = Consulta.ConsultaBasica
        NegocioUnidadesComercializacion.Consultar(EntidadUnidadesComercializacion)
        DgvUnidades.DataSource = EntidadUnidadesComercializacion.TablaConsulta
        'PropiedadesDgModos()
    End Sub
    Private Sub Guardar()
        Dim EntidadUnidadesComercializacion As New Capa_Entidad.UnidadesComercializacion
        Dim NegocioUnidadesComercializacion As New Capa_Negocio.UnidadesComercializacion
        Try
            EntidadUnidadesComercializacion.IdUnidadPeso = IIf(TbIdUnidad.Text = "", 0, TbIdUnidad.Text)
            EntidadUnidadesComercializacion.Descripcion = TbDescripcion.Text
            EntidadUnidadesComercializacion.ValorConversion = NuValorConversion.Value
            NegocioUnidadesComercializacion.Guardar(EntidadUnidadesComercializacion)
            TbIdUnidad.Text = EntidadUnidadesComercializacion.IdUnidadPeso
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("Realizado Correctamente")
            ConsultaUnidades()
        End Try
    End Sub
    Private Sub DgvUnidades_DoubleClick(sender As Object, e As EventArgs) Handles DgvUnidades.DoubleClick
        Dim NumFila As Integer = DgvUnidades.CurrentCell.RowIndex
        Dim NumCol As Integer = DgvUnidades.CurrentCell.ColumnIndex

        TbIdUnidad.Text = DgvUnidades("IdUnidadPeso", NumFila).Value
        TbDescripcion.Text = DgvUnidades("Descripcion", NumFila).Value
        NuValorConversion.Value = DgvUnidades("ValorConversion", NumFila).Value
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class