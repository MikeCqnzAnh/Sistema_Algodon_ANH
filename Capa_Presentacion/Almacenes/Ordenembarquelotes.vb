Public Class Ordenembarquelotes
    Private origenView, destinoView As DataView
    Private dtorigen, dtdestino As DataTable
    Private Const RegistrosPorCarga = 50
    Private registrosCargadosOrigen As Integer = 0
    Private registrosCargadosDestino As Integer = 0
    Private ordenAscendenteorigen As Boolean
    Private ordenAscendentedestino As Boolean
    Private Sub Ordenembarquelotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaCombo()
        dtorigen = New DataTable()
        formatodt(dtorigen)
        origenView = New DataView(dtorigen)
        dtdestino = New DataTable()
        dtdestino = dtorigen.Clone()
        destinoView = New DataView(dtdestino)
        configuradgvorigen(dataGridViewOrigen)
        configuradgvorigen(dataGridViewDestino)
    End Sub
    Private Sub nuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles nuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub guardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles guardarToolStripMenuItem.Click
        Try
            If tbnombrecomprador.Text <> "" And tbidcomprador.Text <> "" Then
                guardarenc()
                guardardet(dtdestino, IIf(tbidembarque.Text = "", 0, tbidembarque.Text))
                guardardet(dtorigen, 0)
                MessageBox.Show("Guardado con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hay campos en blanco que son necesarios para continuar, favor de revisar.", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cancelarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cancelarToolStripMenuItem.Click

    End Sub
    Private Sub consultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles consultarToolStripMenuItem.Click
        Dim consultaembarques As New ConsultaOrdenembarquepacas
        consultaembarques.ShowDialog()
        If consultaembarques._idembarque > 0 Then
            tbidembarque.Text = consultaembarques._idembarque
            tbidcomprador.Text = consultaembarques._idcomprador
            tbnombrecomprador.Text = consultaembarques._nombrecomprador
            tbnombretransportista.Text = consultaembarques._nombrechofer
            tblicencia.Text = consultaembarques._nolicencia
            tbtelefono.Text = consultaembarques._telefono
            tbfoliosalida.Text = consultaembarques._folio
            tbplacatractocamion.Text = consultaembarques._placatracto
            tbplacacaja.Text = consultaembarques._placacaja
            tbdestino.Text = consultaembarques._destino
            tbobservaciones.Text = consultaembarques._observaciones
            nutotalkilos.Value = consultaembarques._totalkilos
            nutotalpacas.Value = consultaembarques._totalpacas
            cbestatus.SelectedValue = consultaembarques._idestatus
            dtfechacreacion.Value = consultaembarques._fechacreacion
            dtfechaactualizacion.Value = consultaembarques._fechaactualizacion
            consultapacasdisp()
            consultapacasembarque()
        End If
    End Sub
    Private Sub imprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles imprimirToolStripMenuItem.Click

    End Sub
    Private Sub dataGridViewDestino_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewDestino.CellContentClick
        dataGridViewDestino.EndEdit()
        Dim cantidadSeleccionada As Integer = ContarCeldasSeleccionadas(destinoView)
        tstotalpacassel.Text = cantidadSeleccionada.ToString()
    End Sub

    Private Sub btenviaseleccion_Click(sender As Object, e As EventArgs) Handles btenviaseleccion.Click
        dataGridViewOrigen.EndEdit()
        If dataGridViewOrigen.Rows.Count > 0 Then
            If cbestatus.SelectedIndex = 0 Then
                MessageBox.Show("El estatus del embarque con el ID " & tbidembarque.Text & " es cancelado, no se permite agregar pacas.", "Embarque Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                tbcantidadsel1.Text = ""
                tstotalpacasdisp.Text = ""

                dataGridViewOrigen.Refresh()
                dataGridViewDestino.Refresh()
                nutotalpacas.Value = dtdestino.Rows.Count
                tabpacas.SelectedIndex = 1
            End If

        End If
    End Sub

    Private Sub btfiltros_Click(sender As Object, e As EventArgs) Handles btfiltros.Click

    End Sub

    Private Sub btfiltroreiniciar_Click(sender As Object, e As EventArgs) Handles btfiltroreiniciar.Click

    End Sub

    Private Sub btmarcarpacas_Click(sender As Object, e As EventArgs) Handles btmarcarpacas.Click
        dataGridViewOrigen.ClearSelection()
        Dim cantidad As Integer = If(tbcantidadsel1.Text = "", 0, Integer.Parse(tbcantidadsel1.Text))
        SeleccionarTodasLasFilasdisp(True, dataGridViewOrigen, origenView, tstotalpacasdisp, cantidad)
        dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)

        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()
    End Sub

    Private Sub btdesmarcarpacas_Click(sender As Object, e As EventArgs) Handles btdesmarcarpacas.Click
        dataGridViewOrigen.EndEdit()
        dataGridViewOrigen.ClearSelection()
        SeleccionarTodasLasFilasdisp(False, dataGridViewOrigen, origenView, tstotalpacasdisp)
        dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)

        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()
    End Sub

    Private Sub btimportaexcel_Click(sender As Object, e As EventArgs) Handles btimportaexcel.Click

    End Sub

    Private Sub btregresarseleccion_Click(sender As Object, e As EventArgs) Handles btregresarseleccion.Click
        regresarpacas()
    End Sub

    Private Sub btfiltrosel_Click(sender As Object, e As EventArgs) Handles btfiltrosel.Click

    End Sub

    Private Sub btreiniciafiltrosel_Click(sender As Object, e As EventArgs) Handles btreiniciafiltrosel.Click

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

    Private Sub btimportaseleccionexcel_Click(sender As Object, e As EventArgs) Handles btimportaseleccionexcel.Click

    End Sub
    Private Sub limpiar()
        tbidembarque.Clear()
        tbidcomprador.Clear()
        tbnombrecomprador.Clear()
        tbnombretransportista.Clear()
        tblicencia.Clear()
        tbtelefono.Clear()
        tbfoliosalida.Clear()
        tbplacatractocamion.Clear()
        tbplacacaja.Clear()
        tbdestino.Clear()
        nutotalkilos.Value = 0
        nutotalpacas.Value = 0
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
    Private Sub formatodt(dt As DataTable)
        dt.Columns.Add("idproducciondetalle", GetType(Integer))
        dt.Columns.Add("idlote", GetType(Integer))
        dt.Columns.Add("nolote", GetType(String))
        dt.Columns.Add("idembarqueencabezado", GetType(Integer))
        dt.Columns.Add("idsalidaencabezado", GetType(Integer))
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
        Dim newColidlote = New DataGridViewTextBoxColumn()
        Dim newColnolote = New DataGridViewTextBoxColumn()
        Dim newColidembarque = New DataGridViewTextBoxColumn()
        Dim newColidsalida = New DataGridViewTextBoxColumn()
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

        newColidlote.HeaderText = "idlote"
        newColidlote.Name = "idlote"
        newColidlote.Visible = False
        dgv.Columns.Add(newColidlote)

        newColnolote.HeaderText = "No Lote"
        newColnolote.Name = "nolote"
        newColnolote.ReadOnly = True
        dgv.Columns.Add(newColnolote)

        newColidembarque.HeaderText = "idembarque"
        newColidembarque.Name = "idembarqueencabezado"
        newColidembarque.Visible = False
        dgv.Columns.Add(newColidembarque)

        newColidsalida.HeaderText = "idsalida"
        newColidsalida.Name = "idsalidaencabezado"
        newColidsalida.Visible = False
        dgv.Columns.Add(newColidsalida)

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
    Private Sub guardarenc()
        Dim eorden As New Capa_Entidad.OrdenEmbarquePacas
        Dim norden As New Capa_Negocio.OrdenEmbarquePacas
        If cbestatus.SelectedIndex = -1 Then cbestatus.SelectedValue = 1
        eorden.Guarda = Guardar.GuardarEncabezado
        eorden.IdEmbarqueEncabezado = IIf(tbidembarque.Text = "", 0, tbidembarque.Text)
        eorden.IdComprador = tbidcomprador.Text
        eorden.NombreChofer = tbnombretransportista.Text
        eorden.NoLicencia = tblicencia.Text
        eorden.Telefono = tbtelefono.Text
        eorden.folio = tbfoliosalida.Text
        eorden.PlacaTractoCamion = tbplacatractocamion.Text
        eorden.PlacaCaja = tbplacacaja.Text
        eorden.destino = tbdestino.Text
        eorden.Observaciones = tbobservaciones.Text
        eorden.totalpacas = nutotalpacas.Value
        eorden.totalkilos = nutotalkilos.Value
        eorden.FechaCreacion = Now()
        eorden.FechaActualizacion = Now()
        eorden.idestatus = cbestatus.SelectedValue
        norden.Guardar(eorden)
        tbidembarque.Text = eorden.IdEmbarqueEncabezado
    End Sub
    Private Sub guardardet(ByRef dt As DataTable, ByRef id As Integer)
        Dim eorden As New Capa_Entidad.OrdenEmbarquePacas
        Dim norden As New Capa_Negocio.OrdenEmbarquePacas
        For Each row As DataRow In dt.Rows
            eorden.Guarda = Guardar.GuardarDetalle
            eorden.idproducciondetalle = row("idproducciondetalle")
            eorden.IdEmbarqueEncabezado = id
            norden.Guardar(eorden)
        Next
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

    Private Sub dataGridViewOrigen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewOrigen.CellContentClick
        dataGridViewOrigen.EndEdit()
        Dim cantidadSeleccionada As Integer = ContarCeldasSeleccionadas(origenView)
        tstotalpacasdisp.Text = cantidadSeleccionada.ToString()
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
    Private Sub consultapacasdisp()
        Dim eorden As New Capa_Entidad.OrdenEmbarquePacas
        Dim norden As New Capa_Negocio.OrdenEmbarquePacas
        eorden.Consulta = Consulta.Consultapacasembdet
        eorden.IdComprador = tbidcomprador.Text
        norden.Consultar(eorden)
        dtorigen = eorden.TablaConsulta
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
    Private Sub consultapacasembarque()
        Dim eorden As New Capa_Entidad.OrdenEmbarquePacas
        Dim norden As New Capa_Negocio.OrdenEmbarquePacas
        eorden.Consulta = Consulta.consultapacasembseldet
        eorden.IdEmbarqueEncabezado = tbidembarque.Text
        norden.Consultar(eorden)
        dtdestino = eorden.TablaConsulta
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

    Private Sub btconsultaclientes_Click(sender As Object, e As EventArgs) Handles btconsultacompradores.Click
        Dim compradores As New ConsultaCompradores()
        compradores.ShowDialog()
        If compradores.idcomprador_ > 0 Then
            limpiar()
            tbidcomprador.Text = compradores.idcomprador_
            tbnombrecomprador.Text = compradores.nombre_
            consultapacasdisp()
        End If
    End Sub

    Private Function ContarCeldasSeleccionadas(dv As DataView) As Integer
        ' Consulta LINQ para contar las celdas en True en la columna "Seleccionar"
        Dim contador As Integer = dv.Cast(Of DataRowView)() _
        .Count(Function(fila) fila("Seleccionar") IsNot DBNull.Value AndAlso CBool(fila("Seleccionar")))
        Return contador
    End Function
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
End Class