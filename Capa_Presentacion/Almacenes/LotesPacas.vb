Public Class LotesPacas
    Private origenView, destinoView As DataView
    Private dtorigen, dtdestino As DataTable
    Private Const RegistrosPorCarga = 50
    Private registrosCargadosOrigen As Integer = 0
    Private resigtrosCargadosDestino As Integer = 0
    Private ordenAscendenteorigen As Boolean
    Private ordenAscendentedestino As Boolean
    Private Sub LotesPacas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenacombo()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim consultalotes As New ConsultaLotesEnc()
        consultalotes.ShowDialog()
        If consultalotes._idlote > 0 Then
            tbidlote.Text = consultalotes._idlote
            tbidcomprador.Text = consultalotes._idcomprador
            tbnombreproveedor.Text = consultalotes._nombre
            tbnombrelote.Text = consultalotes._nolote
        End If
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            If tbnombrelote.Text <> "" And tbidcomprador.Text <> "" Then
                guardarenc()
            Else
                MessageBox.Show("Hay campos en blanco que son necesarios para continuar, favor de revisar.", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub guardarenc()
        Dim elotespaca As New Capa_Entidad.LotesPacas
        Dim nlotespaca As New Capa_Negocio.LotesPacas
        If cbestatus.SelectedIndex = -1 Then cbestatus.SelectedValue = 1
        elotespaca.Guarda = Guardar.GuardarEncabezado
        elotespaca.idlote = IIf(tbidlote.Text = "", 0, tbidlote.Text)
        elotespaca.idcomprador = tbidcomprador.Text
        elotespaca.nolote = tbnombrelote.Text
        elotespaca.ubicacion = tbubicacion.Text
        elotespaca.observaciones = tbobservaciones.Text
        elotespaca.totalpacas = nutotalpacas.Value
        elotespaca.totalkilos = nutotalkilos.Value
        elotespaca.FechaCreacion = Now()
        elotespaca.FechaActualizacion = Now()
        elotespaca.idestatus = cbestatus.SelectedValue
        nlotespaca.Guardar(elotespaca)
        tbidlote.Text = elotespaca.idlote
        MessageBox.Show("Guardado con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btconsultaclientes_Click(sender As Object, e As EventArgs) Handles btconsultaproveedor.Click
        Dim compradores As New ConsultaCompradores()
        compradores.ShowDialog()
        If compradores.idcomprador_ > 0 Then
            tbidcomprador.Text = compradores.idcomprador_
            tbnombreproveedor.Text = compradores.nombre_
        End If
    End Sub

    Private Sub dataGridViewOrigen_Scroll(sender As Object, e As ScrollEventArgs) Handles dataGridViewOrigen.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll AndAlso e.NewValue + dataGridViewOrigen.DisplayedRowCount(False) >= registrosCargadosOrigen - 10 AndAlso origenView IsNot Nothing Then
            ' Cargar más datos al hacer scroll y faltar 10 filas para llegar al final
            If registrosCargadosOrigen < origenView.Count Then
                Dim nuevasFilas As Integer = Math.Min(RegistrosPorCarga, origenView.Count - registrosCargadosOrigen)
                registrosCargadosOrigen += nuevasFilas
                dataGridViewOrigen.RowCount += nuevasFilas
            End If
        End If
    End Sub

    Private Sub dataGridViewOrigen_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dataGridViewOrigen.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.RowIndex < origenView.Count AndAlso e.ColumnIndex >= 0 Then
            e.Value = origenView(e.RowIndex)(e.ColumnIndex)
        End If
    End Sub

    Private Sub dataGridViewOrigen_CellValuePushed(sender As Object, e As DataGridViewCellValueEventArgs) Handles dataGridViewOrigen.CellValuePushed
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            origenView(e.RowIndex)(e.ColumnIndex) = e.Value
        End If
    End Sub

    Private Sub dataGridViewDestino_Scroll(sender As Object, e As ScrollEventArgs) Handles dataGridViewDestino.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll AndAlso e.NewValue + dataGridViewDestino.DisplayedRowCount(False) >= registrosCargadosDestino - 10 AndAlso destinoView IsNot Nothing Then
            ' Cargar más datos al hacer scroll y faltar 10 filas para llegar al final
            If registrosCargadosDestino < destinoView.Count Then
                Dim nuevasFilas As Integer = Math.Min(RegistrosPorCarga, destinoView.Count - registrosCargadosDestino)
                registrosCargadosDestino += nuevasFilas
                dataGridViewDestino.RowCount += nuevasFilas
            End If
        End If
    End Sub

    Private Sub dataGridViewDestino_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dataGridViewDestino.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.RowIndex < destinoView.Count AndAlso e.ColumnIndex >= 0 Then
            e.Value = destinoView(e.RowIndex)(e.ColumnIndex)
        End If
    End Sub

    Private Sub dataGridViewDestino_CellValuePushed(sender As Object, e As DataGridViewCellValueEventArgs) Handles dataGridViewDestino.CellValuePushed
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            destinoView(e.RowIndex)(e.ColumnIndex) = e.Value
        End If
    End Sub

    Private Sub llenacombo()
        Dim dt As New DataTable("Tabla")
        Dim dr As DataRow

        Try
            dt.Columns.Add("Id")
            dt.Columns.Add("Descripcion")

            dr = dt.NewRow()
            dr("Id") = "0"
            dr("Descripcion") = "Inactivo"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Id") = "1"
            dr("Descripcion") = "Activo"
            dt.Rows.Add(dr)

            cbestatus.DataSource = dt
            cbestatus.ValueMember = "Id"
            cbestatus.DisplayMember = "Descripcion"
            cbestatus.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error " & ex.ToString())
        End Try
    End Sub
    Private Sub consultapacasdisp()
        Dim elotes As New Capa_Entidad.LotesPacas
        Dim nlotes As New Capa_Negocio.LotesPacas
        elotes.Consulta = Consulta.Consultapacaslotedet
        elotes.idcomprador = tbidcomprador.Text
        nlotes.Consultar(elotes)
        dtorigen = elotes.TablaConsulta
        If dtorigen.Rows.Count > 0 Then
            origenView = New DataView(dtorigen)
            dtdestino = New DataTable()
            dtdestino = dtorigen.Clone()
            destinoView = New DataView(dtdestino)

            AddHandler dataGridViewOrigen.CellValueNeeded, AddressOf dataGridViewOrigen_CellValueNeeded
            AddHandler dataGridViewOrigen.CellValuePushed, AddressOf dataGridViewOrigen_CellValuePushed
            AddHandler dataGridViewDestino.CellValueNeeded, AddressOf dataGridViewDestino_CellValueNeeded
            AddHandler dataGridViewDestino.CellValuePushed, AddressOf dataGridViewDestino_CellValuePushed

            If registrosCargadosOrigen <= origenView.Count Then
                Dim nuevasFilas As Integer = Math.Min(RegistrosPorCarga, origenView.Count - registrosCargadosOrigen)
                registrosCargadosOrigen += nuevasFilas
                dataGridViewOrigen.RowCount += nuevasFilas
            End If
        End If
    End Sub
End Class