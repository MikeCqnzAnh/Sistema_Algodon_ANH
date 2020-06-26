Imports Capa_Operacion.Configuracion
Public Class CargaPacasExternas
    Private Sub CargaPacasExternas_Load(sender As Object, e As EventArgs) Handles Me.Load
        nuevo()
    End Sub
    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        nuevo()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub nuevo()
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        llenaCombos()
    End Sub
    Private Sub llenaCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlantaOrigen.DataSource = Tabla
        CbPlantaOrigen.ValueMember = "IdPlanta"
        CbPlantaOrigen.DisplayMember = "Descripcion"
        CbPlantaOrigen.SelectedValue = 0
    End Sub
    Private Sub BtProductor_Click(sender As Object, e As EventArgs) Handles BtProductor.Click
        ConsultaProductores.ShowDialog()
        If VarGlob.Id > 0 Then
            TbIdProductor.Text = VarGlob.Id
            TbNombreProductor.Text = VarGlob.Nombre
            VarGlob.Id = 0
            VarGlob.Nombre = ""
        End If
    End Sub
    Private Sub DgvPacasClasificacion_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DgvPacas.RowPostPaint
        Try
            Dim NumeroFila As String = (e.RowIndex + 1).ToString 'Obtiene el número de filas
            While NumeroFila.Length < DgvPacas.RowCount.ToString.Length
                NumeroFila = "0" & NumeroFila 'Agrega un cero a los que tienen un dígito menos
            End While
            Dim size As SizeF = e.Graphics.MeasureString(NumeroFila, Me.Font)
            If DgvPacas.RowHeadersWidth < CInt(size.Width + 20) Then
                DgvPacas.RowHeadersWidth = CInt(size.Width + 20)
            End If
            Dim Obj As Brush = SystemBrushes.ControlText
            'Dibuja el número dentro del controltext
            e.Graphics.DrawString(NumeroFila, Me.Font, Obj, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
    Private Sub BtCargaExcel_Click(sender As Object, e As EventArgs) Handles BtCargaExcel.Click
        importarExcelExterno(DgvPacas)
    End Sub
End Class