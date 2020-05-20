Imports Capa_Operacion.Configuracion
Public Class TipoAlmacen
    Private Sub TipoAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Consultar()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
        Consultar()
    End Sub
    Private Sub limpiar()
        TbIdTipoAlmacen.Text = ""
        TbDescripcion.Text = ""
    End Sub
    Private Sub SeleccionarTipoAlmacen()
        If DgvTipoAlmacen.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvTipoAlmacen.CurrentCell.RowIndex
            TbIdTipoAlmacen.Text = DgvTipoAlmacen.Rows(index).Cells("IdTIpoAlmacen").Value
            TbDescripcion.Text = DgvTipoAlmacen.Rows(index).Cells("Descripcion").Value
        End If
    End Sub
    Private Sub Guardar()
        Try
            If TbDescripcion.Text <> "" Then
                Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
                Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
                'EntidadAlmacenes.IdTipoAlmacen = IIf(TbIdTipoAlmacen.Text = "", 0, TbIdTipoAlmacen.Text)
                'EntidadAlmacenes.Descripcion = TbDescripcion.Text
                'EntidadAlmacenes.Actualiza = Actuliza.ActualizaTipoAlmacen
                'NegocioAlmacenes.Guardar(EntidadAlmacenes)
                'TbIdTipoAlmacen.Text = EntidadAlmacenes.IdTipoAlmacen
                'Consultar()
            Else
                MessageBox.Show("El campo descripcion no puede estar vacio.", "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Consultar()
        Try
            Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
            Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
            Dim Tabla As New DataTable
            EntidadAlmacenes.Consulta = Consulta.ConsultaBasica
            NegocioAlmacenes.Consultar(EntidadAlmacenes)
            DgvTipoAlmacen.DataSource = EntidadAlmacenes.TablaConsulta
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub

    Private Sub DgvTipoAlmacen_DoubleClick(sender As Object, e As EventArgs) Handles DgvTipoAlmacen.DoubleClick
        SeleccionarTipoAlmacen()
    End Sub
End Class