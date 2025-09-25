Public Class LotesPacas
    Private origenView, destinoView As DataView
    Private dtorigen, dtdestino As DataTable
    Private Const RegistrosPorCarga = 50
    Private registrosCargadosOrigen As Integer = 0
    Private registrosCargadosDestino As Integer = 0
    Private ordenAscendenteorigen As Boolean
    Private ordenAscendentedestino As Boolean
    Private Sub LotesPacas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenacombo()
        dtorigen = New DataTable()
        formatodt(dtorigen)
        origenView = New DataView(dtorigen)
        dtdestino = New DataTable()
        dtdestino = dtorigen.Clone()
        destinoView = New DataView(dtdestino)
        configuradgvorigen(dataGridViewOrigen)
        configuradgvorigen(dataGridViewDestino)
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        tbidlote.Clear()
        tbidcomprador.Clear()
        tbnombrelote.Clear()
        tbnombreproveedor.Clear()
        tbubicacion.Clear()
        tbobservaciones.Clear()
        dtfechacreacion.Value = Now
        dtfechaactualizacion.Value = Now
        nutotalpacas.Value = 0
        nutotalkilos.Value = 0
        cbestatus.SelectedIndex = -1
        dtorigen.Clear()
        dtdestino.Clear()
        registrosCargadosDestino = 0
        registrosCargadosOrigen = 0
        dataGridViewOrigen.RowCount = Math.Min(If(registrosCargadosOrigen = 0, RegistrosPorCarga, registrosCargadosOrigen), origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(If(registrosCargadosDestino = 0, RegistrosPorCarga, registrosCargadosDestino), destinoView.Count)
        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()
        tstotalpacasdisp.Clear()
        tbcantidadsel1.Clear()
        tstotalpacassel.Clear()
        tbcantidadsel2.Clear()
    End Sub
    Private Sub formatodt(dt As DataTable)
        dt.Columns.Add("idproducciondetalle", GetType(Integer))
        dt.Columns.Add("idpaqueteencabezado", GetType(Integer))
        dt.Columns.Add("idlote", GetType(Integer))
        dt.Columns.Add("idembarqueencabezado", GetType(Integer))
        dt.Columns.Add("baleid", GetType(Long))
        dt.Columns.Add("mic", GetType(Decimal))
        dt.Columns.Add("strength", GetType(Decimal))
        dt.Columns.Add("uhml", GetType(Decimal))
        dt.Columns.Add("ui", GetType(Decimal))
        dt.Columns.Add("grade", GetType(String))
        dt.Columns.Add("colorgrade", GetType(String))
        dt.Columns.Add("trashcount", GetType(Integer))
        dt.Columns.Add("trasharea", GetType(Decimal))
        dt.Columns.Add("trashid", GetType(Integer))
        dt.Columns.Add("kilos", GetType(Decimal))
        dt.Columns.Add("Seleccionar", GetType(Boolean))
    End Sub
    Private Sub configuradgvorigen(ByVal dgv As DataGridView)

        dgv.VirtualMode = True

        Dim newColIdProduccionDet As New DataGridViewTextBoxColumn()
        Dim newColIdPaquete As New DataGridViewTextBoxColumn()
        Dim newColidlote = New DataGridViewTextBoxColumn()
        Dim newColidembarque = New DataGridViewTextBoxColumn()
        Dim newColbaleid = New DataGridViewTextBoxColumn()
        Dim newColmic = New DataGridViewTextBoxColumn()
        Dim newColstrength = New DataGridViewTextBoxColumn()
        Dim newColuhml = New DataGridViewTextBoxColumn()
        Dim newColui = New DataGridViewTextBoxColumn()
        Dim newColgrade = New DataGridViewTextBoxColumn()
        Dim newColcolorgrade = New DataGridViewTextBoxColumn()
        Dim newColtrashcount = New DataGridViewTextBoxColumn()
        Dim newColtrasharea = New DataGridViewTextBoxColumn()
        Dim newColtrashid = New DataGridViewTextBoxColumn()
        Dim newColkilos = New DataGridViewTextBoxColumn()
        Dim newColSeleccionar = New DataGridViewCheckBoxColumn()

        newColIdProduccionDet.HeaderText = "IdProduccionDet"
        newColIdProduccionDet.Name = "IdProduccionDet"
        newColIdProduccionDet.Visible = False
        dgv.Columns.Add(newColIdProduccionDet)

        newColIdPaquete.HeaderText = "idpaquete"
        newColIdPaquete.Name = "idpaqueteencabezado"
        newColIdPaquete.Visible = False
        dgv.Columns.Add(newColIdPaquete)

        newColidlote.HeaderText = "idlote"
        newColidlote.Name = "idlote"
        newColidlote.Visible = False
        dgv.Columns.Add(newColidlote)

        newColidembarque.HeaderText = "idembarque"
        newColidembarque.Name = "idembarqueencabezado"
        newColidembarque.Visible = False
        dgv.Columns.Add(newColidembarque)

        newColbaleid.HeaderText = "BaleID"
        newColbaleid.Name = "baleid"
        newColbaleid.ReadOnly = True
        dgv.Columns.Add(newColbaleid)

        newColmic.HeaderText = "Mic"
        newColmic.Name = "mic"
        newColmic.ReadOnly = True
        dgv.Columns.Add(newColmic)

        newColstrength.HeaderText = "Strength"
        newColstrength.Name = "strength"
        newColstrength.ReadOnly = True
        dgv.Columns.Add(newColstrength)

        newColuhml.HeaderText = "UHML"
        newColuhml.Name = "uhml"
        newColuhml.ReadOnly = True
        dgv.Columns.Add(newColuhml)

        newColui.HeaderText = "UI"
        newColui.Name = "ui"
        newColui.ReadOnly = True
        dgv.Columns.Add(newColui)

        newColgrade.HeaderText = "Grade"
        newColgrade.Name = "grade"
        newColgrade.ReadOnly = True
        dgv.Columns.Add(newColgrade)

        newColcolorgrade.HeaderText = "Color Grade"
        newColcolorgrade.Name = "colorgrade"
        newColcolorgrade.ReadOnly = True
        dgv.Columns.Add(newColcolorgrade)

        newColtrashcount.HeaderText = "Trash Count"
        newColtrashcount.Name = "trashcount"
        newColtrashcount.Visible = False
        dgv.Columns.Add(newColtrashcount)

        newColtrasharea.HeaderText = "Trash Area"
        newColtrasharea.Name = "trasharea"
        newColtrasharea.Visible = False
        dgv.Columns.Add(newColtrasharea)

        newColtrashid.HeaderText = "Trash ID"
        newColtrashid.Name = "trashid"
        newColtrashid.Visible = False
        dgv.Columns.Add(newColtrashid)

        newColkilos.HeaderText = "Kilos"
        newColkilos.Name = "kilos"
        newColkilos.Visible = False
        dgv.Columns.Add(newColkilos)

        newColSeleccionar.HeaderText = "Seleccionar"
        newColSeleccionar.Name = "Seleccionar"
        newColSeleccionar.ReadOnly = False
        dgv.Columns.Add(newColSeleccionar)
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim consultalotes As New ConsultaLotesEnc()
        consultalotes.ShowDialog()
        If consultalotes._idlote > 0 Then
            limpiar()
            tbidlote.Text = consultalotes._idlote
            tbidcomprador.Text = consultalotes._idcomprador
            tbnombreproveedor.Text = consultalotes._nombre
            tbnombrelote.Text = consultalotes._nolote
            tbubicacion.Text = consultalotes._ubicacion
            tbobservaciones.Text = consultalotes._observaciones
            nutotalkilos.Value = consultalotes._totalkilos
            nutotalpacas.Value = consultalotes._totalpacas
            dtfechacreacion.Value = consultalotes._fechacreacion
            dtfechaactualizacion.Value = consultalotes._fechaactualizacion
            cbestatus.SelectedValue = consultalotes._idestatus
            consultapacasdisp()
            consultapacaslote()
        End If
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            If tbnombrelote.Text <> "" And tbidcomprador.Text <> "" And tbnombrelote.Text <> "" Then
                guardarenc()
                guardardet(dtdestino, IIf(tbidlote.Text = "", 0, tbidlote.Text))
                guardardet(dtorigen, 0)
                MessageBox.Show("Guardado con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    End Sub
    Private Sub guardardet(ByRef dt As DataTable, ByRef id As Integer)
        Dim elotespaca As New Capa_Entidad.LotesPacas
        Dim nlotespaca As New Capa_Negocio.LotesPacas
        For Each row As DataRow In dt.Rows
            elotespaca.Guarda = Guardar.GuardarDetalle
            elotespaca.idproducciondetalle = row("idproducciondetalle")
            elotespaca.idlote = id
            nlotespaca.Guardar(elotespaca)
        Next
    End Sub
    Private Sub btconsultaclientes_Click(sender As Object, e As EventArgs) Handles btconsultaproveedor.Click
        Dim compradores As New ConsultaCompradores()
        compradores.ShowDialog()
        If compradores.idcomprador_ > 0 Then
            limpiar()
            tbidcomprador.Text = compradores.idcomprador_
            tbnombreproveedor.Text = compradores.nombre_
            consultapacasdisp()
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

    Private Sub btenviaseleccion_Click(sender As Object, e As EventArgs) Handles btenviaseleccion.Click
        dataGridViewOrigen.EndEdit()
        If dataGridViewOrigen.Rows.Count > 0 Then
            If cbestatus.SelectedIndex = 0 Then
                MessageBox.Show("El estatus del Lote con el ID " & tbidlote.Text & " es cancelado, no se permite agregar pacas.", "Lote Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                For Each rowView As DataRowView In origenView
                    Dim seleccionado As Boolean = CBool(rowView("seleccionar"))
                    If seleccionado Then
                        rowView("seleccionar") = False
                        Dim rowOrigen As DataRow = rowView.Row
                        dtdestino.ImportRow(rowOrigen)
                        rowView.Delete()
                    End If
                Next
                origenView.Table.AcceptChanges()
                origenView = New DataView(dtorigen)
                destinoView = New DataView(dtdestino)
                origenView.Sort = "Baleid ASC"
                destinoView.Sort = "Baleid ASC"
                registrosCargadosDestino = 0
                registrosCargadosOrigen = 0
                tbcantidadsel1.Text = String.Empty

                dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
                dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)
                tsdisponibles.Text = ""
                tstotalpacasdisp.Text = ""

                dataGridViewOrigen.Refresh()
                dataGridViewDestino.Refresh()
                nutotalpacas.Value = dtdestino.Rows.Count
                tabpacas.SelectedIndex = 1
            End If

        End If
    End Sub
    Private Sub btregresarsel_Click(sender As Object, e As EventArgs) Handles btregresarsel.Click
        regresarpacas()
    End Sub
    Private Sub regresarpacas()
        dataGridViewDestino.EndEdit()
        If dataGridViewDestino.Rows.Count > 0 Then
            For Each rowView As DataRowView In destinoView
                Dim seleccionado As Boolean = CBool(rowView("seleccionar"))
                If seleccionado Then
                    rowView("seleccionar") = False
                    rowView("idlote") = 0
                    Dim rowDestino As DataRow = rowView.Row
                    dtorigen.ImportRow(rowDestino)
                    rowView.Delete()
                End If
            Next
            destinoView.Table.AcceptChanges()
            origenView = New DataView(dtorigen)
            destinoView = New DataView(dtdestino)
            origenView.Sort = "Baleid ASC"
            destinoView.Sort = "Baleid ASC"
            registrosCargadosDestino = 0
            registrosCargadosOrigen = 0

            dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count - registrosCargadosOrigen)
            dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count - registrosCargadosDestino)

            tstotalpacassel.Text = ""
            tbcantidadsel2.Text = String.Empty

            dataGridViewOrigen.Refresh()
            dataGridViewDestino.Refresh()
            nutotalpacas.Value = dtdestino.Rows.Count
        End If
    End Sub
    Private Sub btmarcarpacasdisp_Click(sender As Object, e As EventArgs) Handles btmarcarpacasdisp.Click
        dataGridViewOrigen.ClearSelection()
        Dim cantidad As Integer = If(tbcantidadsel1.Text = "", 0, Integer.Parse(tbcantidadsel1.Text))
        SeleccionarTodasLasFilasdisp(True, dataGridViewOrigen, origenView, tstotalpacasdisp, cantidad)
        dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)

        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()
    End Sub

    Private Sub btdesmarcarpacasdisp_Click(sender As Object, e As EventArgs) Handles btdesmarcarpacasdisp.Click
        dataGridViewOrigen.EndEdit()
        dataGridViewOrigen.ClearSelection()
        SeleccionarTodasLasFilasdisp(False, dataGridViewOrigen, origenView, tstotalpacasdisp)
        dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)

        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()
    End Sub
    Private Sub btmarcasel_Click(sender As Object, e As EventArgs) Handles btmarcasel.Click
        dataGridViewDestino.ClearSelection()
        Dim cantidad As Integer = If(tbcantidadsel2.Text = "", 0, Integer.Parse(tbcantidadsel2.Text))
        SeleccionarTodasLasFilasdisp(True, dataGridViewDestino, destinoView, tstotalpacassel, cantidad)

        dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)

        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()
    End Sub

    Private Sub btdesmarcasel_Click(sender As Object, e As EventArgs) Handles btdesmarcasel.Click
        dataGridViewDestino.ClearSelection()
        SeleccionarTodasLasFilasdisp(False, dataGridViewDestino, destinoView, tstotalpacassel)

        dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)

        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()
    End Sub
    Private Sub SeleccionarTodasLasFilasdisp(valor As Boolean, dgv As DataGridView, dv As DataView, tb As ToolStripTextBox, Optional cantidad As Integer = 0)
        If dgv.Rows.Count > 0 Then
            If cantidad = 0 Then
                For Each fila As DataRowView In dv
                    fila("Seleccionar") = valor
                Next
            Else
                For i As Integer = 0 To Math.Min(cantidad, dv.Count) - 1
                    ' Accedemos a cada registro utilizando el índice i
                    Dim fila As DataRowView = dv(i)
                    fila("Seleccionar") = valor
                Next
            End If

            ' Actualizar el recuento de selecciones
            Dim cantidadSeleccionada As Integer = ContarCeldasSeleccionadas(dv)
            tb.Text = cantidadSeleccionada.ToString()
        End If
    End Sub
    Private Function ContarCeldasSeleccionadas(dv As DataView) As Integer
        ' Consulta LINQ para contar las celdas en True en la columna "Seleccionar"
        Dim contador As Integer = dv.Cast(Of DataRowView)() _
        .Count(Function(fila) fila("Seleccionar") IsNot DBNull.Value AndAlso CBool(fila("Seleccionar")))
        Return contador
    End Function

    Private Sub dataGridViewDestino_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewDestino.CellContentClick
        dataGridViewDestino.EndEdit()
        Dim cantidadSeleccionada As Integer = ContarCeldasSeleccionadas(destinoView)
        tstotalpacassel.Text = cantidadSeleccionada.ToString()
    End Sub

    Private Sub dataGridViewOrigen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewOrigen.CellContentClick
        dataGridViewOrigen.EndEdit()
        Dim cantidadSeleccionada As Integer = ContarCeldasSeleccionadas(origenView)
        tstotalpacasdisp.Text = cantidadSeleccionada.ToString()
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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
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
    Private Sub consultapacaslote()
        Dim elotes As New Capa_Entidad.LotesPacas
        Dim nlotes As New Capa_Negocio.LotesPacas
        elotes.Consulta = Consulta.Consultapacasloteseldet
        elotes.idlote = tbidlote.Text
        nlotes.Consultar(elotes)
        dtdestino = elotes.TablaConsulta
        If dtdestino.Rows.Count > 0 Then

            destinoView = New DataView(dtdestino)

            AddHandler dataGridViewDestino.CellValueNeeded, AddressOf dataGridViewDestino_CellValueNeeded
            AddHandler dataGridViewDestino.CellValuePushed, AddressOf dataGridViewDestino_CellValuePushed

            If registrosCargadosDestino <= destinoView.Count Then
                Dim nuevasFilas As Integer = Math.Min(RegistrosPorCarga, destinoView.Count - registrosCargadosDestino)
                registrosCargadosDestino += nuevasFilas
                dataGridViewDestino.RowCount += nuevasFilas
            End If
        End If
    End Sub
End Class
