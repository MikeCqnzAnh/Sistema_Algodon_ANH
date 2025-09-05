Imports System.Runtime.InteropServices
Imports System.ServiceModel.Dispatcher
Imports System.Web.UI.WebControls
Imports Capa_Operacion
Imports CrystalDecisions.CrystalReports
Public Class VentaPacasPorContrato
    Dim TablaUnidadPeso As New DataTable
    Private PrecioSM, PrecioMP, PrecioM, PrecioSLMP, PrecioSLM, PrecioLMP, PrecioLM, PrecioSGO, PrecioGO, PrecioO As Double
    Private cantidadcontrato, disponibles, vendidas As Integer
    Private dtmic As New DataTable()
    Private dtuhml As New DataTable()
    Private dtstr As New DataTable()
    Private dtui As New DataTable()
    Private dtsfi As New DataTable()
    Private origenView, destinoView As DataView
    Private dtorigen, dtdestino As DataTable
    Private Const RegistrosPorCarga = 50
    Private registrosCargadosOrigen As Integer = 0
    Private registrosCargadosDestino As Integer = 0
    Private ordenAscendenteorigen As Boolean = True
    Private ordenAscendentedestino As Boolean = True

    Private Sub VentaPacasPorContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        llenacombo()
        dtorigen = New DataTable()
        formatodatatable(dtorigen)
        origenView = New DataView(dtorigen)
        dtdestino = New DataTable()
        dtdestino = dtorigen.Clone()
        destinoView = New DataView(dtdestino)
        configdgvprecioclase(dgvprecioclase)
        configuradgvorigen(dataGridViewOrigen)
        configuradgvdestino(dataGridViewDestino)
    End Sub
    Private Sub llenacombo()
        Dim dt As New DataTable("Tabla")
        Dim dr As DataRow

        Try
            dt.Columns.Add("Id")
            dt.Columns.Add("Descripcion")

            dr = dt.NewRow()
            dr("Id") = "0"
            dr("Descripcion") = "Cancelado"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Id") = "1"
            dr("Descripcion") = "Activo"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Id") = "2"
            dr("Descripcion") = "Cerrado"
            dt.Rows.Add(dr)

            cbestatus.DataSource = dt
            cbestatus.ValueMember = "Id"
            cbestatus.DisplayMember = "Descripcion"
            cbestatus.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error " & ex.ToString())
        End Try
    End Sub
    Private Sub formatodatatable(dt As DataTable)
        dt.Columns.Add("idproducciondetalle", GetType(Integer))
        dt.Columns.Add("idproduccion", GetType(Integer))
        dt.Columns.Add("idplantaorigen", GetType(Integer))
        dt.Columns.Add("idVentaenc", GetType(Integer))
        dt.Columns.Add("baleid", GetType(Long))
        dt.Columns.Add("mic", GetType(Decimal))
        dt.Columns.Add("uhml", GetType(Decimal))
        dt.Columns.Add("ui", GetType(Decimal))
        dt.Columns.Add("strength", GetType(Decimal))
        dt.Columns.Add("sfi", GetType(Decimal))
        dt.Columns.Add("elongation", GetType(Decimal))
        dt.Columns.Add("grade", GetType(String))
        dt.Columns.Add("colorgrade", GetType(String))
        dt.Columns.Add("trashcount", GetType(Integer))
        dt.Columns.Add("trasharea", GetType(Decimal))
        dt.Columns.Add("trashid", GetType(Integer))
        dt.Columns.Add("sci", GetType(Integer))
        dt.Columns.Add("kilos", GetType(Decimal))
        dt.Columns.Add("libras", GetType(Decimal))
        dt.Columns.Add("quintales", GetType(Decimal))
        dt.Columns.Add("kilosVenta", GetType(Decimal))
        dt.Columns.Add("librasVenta", GetType(Decimal))
        dt.Columns.Add("quintalesVenta", GetType(Decimal))
        dt.Columns.Add("preciodlsVenta", GetType(Decimal))
        dt.Columns.Add("precioclaseVenta", GetType(Decimal))
        dt.Columns.Add("castigomicvta", GetType(Decimal))
        dt.Columns.Add("castigolargofibravta", GetType(Decimal))
        dt.Columns.Add("castigoresistenciafibravta", GetType(Decimal))
        dt.Columns.Add("castigouiVenta", GetType(Decimal))
        dt.Columns.Add("Seleccionar", GetType(Boolean))
    End Sub

    Private Sub nuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles nuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub consultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles consultarToolStripMenuItem.Click
        Dim _consultaVenta As New FConsultaVenta
        _consultaVenta.ShowDialog()
        If _consultaVenta._idVenta > 0 Then
            limpiar()
            TbIdVentaPaca.Text = _consultaVenta._idventa
            TbIdProductor.Text = _consultaVenta._idcomprador
            TbNombreProductor.Text = _consultaVenta._nombrecomprador
            TbIdContrato.Text = _consultaVenta._idcontrato
            nutotalpacas.Value = _consultaVenta._totalpacas
            nutara.Value = _consultaVenta._tara
            ckactivatara.Checked = _consultaVenta._checktara
            nusubtotal.Value = _consultaVenta._subtotal
            nucastigomic.Value = _consultaVenta._castigomicros
            nucastigostr.Value = _consultaVenta._castigostrength
            nucastigouhml.Value = _consultaVenta._castigouhml
            nucastigouni.Value = _consultaVenta._castigoui
            nutotaldeduccion.Value = _consultaVenta._deduccion
            nutotal.Value = _consultaVenta._totalprecio
            DtFechaVenta.Value = _consultaVenta._fechacreacion
            DtFechaActualizacion.Value = _consultaVenta._fechaactualizacion
            cbestatus.SelectedValue = _consultaVenta._idestatus
            consultadatosComprador()
            seleccionacontrato()
            cargadatagrid()
            cargadataVenta()
            gbcontratos.Enabled = False
        End If
    End Sub

    Private Sub CbModalidadVenta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbModalidadVenta.SelectionChangeCommitted
        If nuPrecioQuintal.Value > 0 And nuPuntos.Value > 0 Then
            Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
            Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
            Dim Tabla As New DataTable
            EntidadContratosAlgodon.IdExterno = CbModalidadVenta.SelectedValue
            EntidadContratosAlgodon.Consulta = Consulta.ConsultaDiferenciales
            NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
            Tabla = EntidadContratosAlgodon.TablaConsulta
            'TbSM.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(0).Item("Diferencial")))
            'TbMP.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(1).Item("Diferencial")))
            'TbM.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(2).Item("Diferencial")))
            'TbSLMP.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(3).Item("Diferencial")))
            'TbSLM.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(4).Item("Diferencial")))
            'TbLMP.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(5).Item("Diferencial")))
            'TbLM.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(6).Item("Diferencial")))
            'TbSGO.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(7).Item("Diferencial")))
            'TbGO.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(8).Item("Diferencial")))
            'TbO.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(9).Item("Diferencial")))
        Else
            MsgBox("Ingrese precio de quintal o los puntos")
        End If
    End Sub

    Private Sub dgvcontratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcontratos.CellContentClick
        Try
            ' Verificar si la columna es la de "Seleccionar" y que no sea el encabezado
            If e.RowIndex >= 0 AndAlso dgvcontratos.Columns(e.ColumnIndex).Name = "Seleccionar" Then
                ' Iterar por todas las filas para desmarcar las demás
                For Each row As DataGridViewRow In dgvcontratos.Rows
                    ' Exceptuar la fila actual
                    If row.Index <> e.RowIndex Then
                        row.Cells("Seleccionar").Value = False
                    End If
                Next
                ' Cambiar el valor de la celda actual
                Dim currentCell = dgvcontratos.Rows(e.RowIndex).Cells("Seleccionar")
                currentCell.Value = Not Convert.ToBoolean(currentCell.Value)
                'If currentCell.Value = True Then

                obtenercontrato()
                consultapreciosclase()
                ConsultaParametrosVenta()
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub seleccionacontrato()
        Try

            ' Iterar por todas las filas para desmarcar las demás
            For Each row As DataGridViewRow In dgvcontratos.Rows
                ' Exceptuar la fila actual
                If row.Cells("idcontratoalgodon").Value = Convert.ToInt32(TbIdContrato.Text) Then
                    row.Cells("Seleccionar").Value = True
                End If
            Next
            ' Cambiar el valor de la celda actual
            'Dim currentCell = dgvcontratos.Rows(e.RowIndex).Cells("Seleccionar")
            'currentCell.Value = Not Convert.ToBoolean(currentCell.Value)
            'If currentCell.Value = True Then

            obtenercontrato()
            consultapreciosclase()
            ConsultaParametrosVenta()
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub limpiar()
        TbIdVentaPaca.Clear()
        TbIdContrato.Clear()
        TbIdProductor.Clear()
        TbNombreProductor.Clear()
        DtFechaVenta.Value = Now
        DtFechaActualizacion.Value = Now
        CbModalidadVenta.SelectedIndex = -1
        cantidadcontrato = 0
        vendidas = 0
        disponibles = 0
        nuPrecioQuintal.Value = 0
        nuPuntos.Value = 0
        nuNoPacas.Value = 0
        ckMicros.Checked = False
        CkRes.Checked = False
        CkLargo.Checked = False
        CkUni.Checked = False
        cbperfilmicros.SelectedIndex = -1
        cbperfilstrength.SelectedIndex = -1
        cbperfiluhml.SelectedIndex = -1
        cbperfilui.SelectedIndex = -1
        nucastigomic.Value = 0
        nucastigostr.Value = 0
        nucastigouhml.Value = 0
        nucastigouni.Value = 0
        nusubtotal.Value = 0
        nutotaldeduccion.Value = 0
        nutotalpacas.Value = 0
        nutotal.Value = 0
        nutara.Value = 0
        ckactivatara.Checked = False
        cbunidadpeso.SelectedValue = 0
        cbestatus.SelectedIndex = -1
        TbValorConversion.Text = ""
        dgvcontratos.DataSource = ""
        dgvprecioclase.DataSource = ""
        dtorigen.Clear()
        dtdestino.Clear()
        registrosCargadosDestino = 0
        registrosCargadosOrigen = 0
        dataGridViewOrigen.RowCount = Math.Min(If(registrosCargadosOrigen = 0, RegistrosPorCarga, registrosCargadosOrigen), origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(If(registrosCargadosDestino = 0, RegistrosPorCarga, registrosCargadosDestino), destinoView.Count)
        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()
        tbpacaseleccionadadisp.Clear()
        tbcantidadsel1.Clear()
        tspacasseleccionadas.Clear()
        tbcantidadsel2.Clear()
    End Sub
    Private Sub consultapreciosclase()
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim Tabla As New DataTable

        EntidadContratosAlgodon.IdExterno = CbModalidadVenta.SelectedValue
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaDiferenciales
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla = EntidadContratosAlgodon.TablaConsulta

        If Tabla.Rows.Count > 0 Then
            ' Si está enlazado a DataSource, limpiar correctamente
            If dgvprecioclase.DataSource IsNot Nothing Then
                dgvprecioclase.DataSource = Nothing
            End If
            dgvprecioclase.Rows.Clear()

            For Each fila As DataRow In Tabla.Rows
                Dim grade As String = fila("Grade").ToString()
                Dim dif As Decimal = Convert.ToDecimal(fila("diferencial"))
                Dim precioclase As Decimal

                If grade <> "S/C" Then
                    precioclase = (nuPrecioQuintal.Value - dif) + nuPuntos.Value
                    dgvprecioclase.Rows.Add(fila("IdModoEncabezado"),
                                        fila("idclasificacion"),
                                        grade, dif, precioclase)
                Else
                    dgvprecioclase.Rows.Add(fila("IdModoEncabezado"),
                                        fila("idclasificacion"),
                                        grade, dif, 0)
                End If
            Next
        Else
            ' Opcional, limpiar grid si no hay datos
            dgvprecioclase.DataSource = Nothing
            dgvprecioclase.Rows.Clear()
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

    Private Sub btenviaseleccion_Click(sender As Object, e As EventArgs) Handles btenviaseleccion.Click
        dataGridViewOrigen.EndEdit()
        If dataGridViewOrigen.Rows.Count > 0 Then
            If cbestatus.SelectedIndex = 0 Then
                MessageBox.Show("El estatus de la venta con el ID " & TbIdVentaPaca.Text & " es cancelado, no se permite agregar pacas.", "Venta Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If (Convert.ToInt32(tbpacaseleccionadadisp.Text) + vendidas) <= cantidadcontrato Then
                    For Each rowView As DataRowView In origenView
                        Dim seleccionado As Boolean = CBool(rowView("seleccionar"))
                        If seleccionado Then
                            If ckactivatara.Checked = True Then
                                Dim factor As Decimal = CDec(Math.Pow(10, 4))
                                Dim tara As Decimal = nutara.Value
                                Dim taralb As Decimal = tara * 2.2046
                                Dim libras, kilos, quintales As Decimal

                                kilos = CDec(rowView("kilos")) - tara
                                libras = CDec(rowView("libras")) - taralb
                                quintales = (kilos / 46.02D)

                                rowView("kilosVenta") = Math.Truncate(kilos * factor) / factor
                                rowView("librasVenta") = Math.Truncate(libras * factor) / factor
                                rowView("quintalesVenta") = Math.Truncate(quintales * factor) / factor
                            Else
                                rowView("kilosVenta") = CDec(rowView("kilos"))
                                rowView("librasVenta") = CDec(rowView("libras"))
                                rowView("quintalesVenta") = CDec(rowView("quintales"))
                            End If

                            rowView("seleccionar") = False
                            Dim rowOrigen As DataRow = rowView.Row
                            dtdestino.ImportRow(rowOrigen)
                            rowView.Delete()
                        End If
                    Next
                    controlpacascontrato(Convert.ToInt32(tbpacaseleccionadadisp.Text), Convert.ToInt32(TbIdContrato.Text), True)
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
                    tbpacaseleccionadadisp.Text = ""

                    dataGridViewOrigen.Refresh()
                    dataGridViewDestino.Refresh()
                    'nutotalpacas.Value = dtdestino.Rows.Count
                    tabpacas.SelectedIndex = 1
                Else
                    Dim diferenciapacas As Integer = (Convert.ToInt32(tbpacaseleccionadadisp.Text) + vendidas) - cantidadcontrato
                    MessageBox.Show("La cantidad de pacas seleccionada supera a las establecidas en el contrato por " & diferenciapacas & ".", "Cantidad seleccionada supera al contrato.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

        End If
    End Sub
    Private Sub controlpacascontrato(ByVal pacasenvia As Integer, ByVal idcontrato As Integer, ByVal enviarecibe As Boolean)
        For Each row As DataGridViewRow In dgvcontratos.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If dgvcontratos.Rows(Index).Cells("IdcontratoAlgodon").Value = idcontrato Then
                If enviarecibe = True Then
                    'cantidadcontrato = dgvcontratos.Rows(Index).Cells("pacas").Value
                    'Vendidas = dgvcontratos.Rows(Index).Cells("pacasVendidas").Value
                    'disponibles = dgvcontratos.Rows(Index).Cells("pacasdisponibles").Value
                    dgvcontratos.Rows(Index).Cells("pacasVendidas").Value += pacasenvia
                    dgvcontratos.Rows(Index).Cells("pacasdisponibles").Value -= pacasenvia
                    vendidas += pacasenvia
                    disponibles -= pacasenvia
                Else
                    'cantidadcontrato = dgvcontratos.Rows(Index).Cells("pacas").Value
                    'Vendidas = dgvcontratos.Rows(Index).Cells("pacasVendidas").Value
                    'disponibles = dgvcontratos.Rows(Index).Cells("pacasdisponibles").Value
                    dgvcontratos.Rows(Index).Cells("pacasVendidas").Value -= pacasenvia
                    dgvcontratos.Rows(Index).Cells("pacasdisponibles").Value += pacasenvia
                    vendidas -= pacasenvia
                    disponibles += pacasenvia
                End If



            Else
                'dgvcontratos.Rows(Index).Cells("Seleccionar").Value = False
            End If
        Next
    End Sub
    Private Sub cbunidadpeso_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbunidadpeso.SelectionChangeCommitted
        If TablaUnidadPeso.Rows.Count > 0 Then
            For Each Fila As DataRow In TablaUnidadPeso.Rows
                If Fila.Item("IdUnidadPeso").ToString = cbunidadpeso.SelectedValue Then
                    TbValorConversion.Text = Fila.Item("ValorConversion").ToString
                End If
            Next
        End If
    End Sub

    Private Sub btmarcarpacas_Click(sender As Object, e As EventArgs) Handles btmarcarpacas.Click
        dataGridViewOrigen.ClearSelection()
        Dim cantidad As Integer = If(tbcantidadsel1.Text = "", 0, Integer.Parse(tbcantidadsel1.Text))
        SeleccionarTodasLasFilasdisp(True, dataGridViewOrigen, origenView, tbpacaseleccionadadisp, cantidad)
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
    Private Sub btregresarseleccion_Click(sender As Object, e As EventArgs) Handles btregresarseleccion.Click
        regresarpacas()
    End Sub
    Private Sub regresarpacas()
        dataGridViewDestino.EndEdit()
        If dataGridViewDestino.Rows.Count > 0 Then
            For Each rowView As DataRowView In destinoView
                Dim seleccionado As Boolean = CBool(rowView("seleccionar"))
                If seleccionado Then
                    rowView("seleccionar") = False
                    rowView("kilosVenta") = 0
                    rowView("librasVenta") = 0
                    rowView("quintalesVenta") = 0
                    rowView("preciodlsVenta") = 0
                    rowView("precioclaseVenta") = 0
                    rowView("castigomicvta") = 0
                    rowView("castigolargofibravta") = 0
                    rowView("castigoresistenciafibravta") = 0
                    rowView("castigouiVenta") = 0
                    'rowView("castigosfiVenta") = 0

                    Dim rowDestino As DataRow = rowView.Row
                    dtorigen.ImportRow(rowDestino)
                    rowView.Delete()
                End If
            Next
            controlpacascontrato(Convert.ToInt32(tspacasseleccionadas.Text), Convert.ToInt32(TbIdContrato.Text), False)
            destinoView.Table.AcceptChanges()
            origenView = New DataView(dtorigen)
            destinoView = New DataView(dtdestino)
            origenView.Sort = "Baleid ASC"
            destinoView.Sort = "Baleid ASC"
            registrosCargadosDestino = 0
            registrosCargadosOrigen = 0

            dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count - registrosCargadosOrigen)
            dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count - registrosCargadosDestino)

            tspacasseleccionadas.Text = ""
            tbcantidadsel2.Text = String.Empty

            dataGridViewOrigen.Refresh()
            dataGridViewDestino.Refresh()

            ' nutotalkilos.Value = dtdestino.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("kilos"))
            'nutotalpacas.Value = dtdestino.Rows.Count
            ' tabpacas.SelectedIndex = 1
        End If
    End Sub

    Private Sub btdesmarcarpacas_Click(sender As Object, e As EventArgs) Handles btdesmarcarpacas.Click
        dataGridViewOrigen.EndEdit()
        dataGridViewOrigen.ClearSelection()
        SeleccionarTodasLasFilasdisp(False, dataGridViewOrigen, origenView, tbpacaseleccionadadisp)
        dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)

        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()

    End Sub
    Private Sub btmarcasel_Click(sender As Object, e As EventArgs) Handles btmarcasel.Click
        dataGridViewDestino.ClearSelection()
        Dim cantidad As Integer = If(tbcantidadsel2.Text = "", 0, Integer.Parse(tbcantidadsel2.Text))
        SeleccionarTodasLasFilasdisp(True, dataGridViewDestino, destinoView, tspacasseleccionadas, cantidad)

        dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)

        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()

    End Sub



    Private Sub btdesmarcasel_Click(sender As Object, e As EventArgs) Handles btdesmarcasel.Click
        dataGridViewDestino.ClearSelection()
        SeleccionarTodasLasFilasdisp(False, dataGridViewDestino, destinoView, tspacasseleccionadas)

        dataGridViewOrigen.RowCount = Math.Min(RegistrosPorCarga, origenView.Count)
        dataGridViewDestino.RowCount = Math.Min(RegistrosPorCarga, destinoView.Count)

        dataGridViewOrigen.Refresh()
        dataGridViewDestino.Refresh()


    End Sub

    Private Sub btcalcula_Click(sender As Object, e As EventArgs) Handles btcalcula.Click
        calculopacas()
    End Sub
    Private Sub calculopacas()
        Try
            dtmic.Rows.Clear()
            dtuhml.Rows.Clear()
            dtstr.Rows.Clear()
            dtui.Rows.Clear()
            dtsfi.Rows.Clear()

            For Each item As DataRowView In cbunidadpeso.Items
                If CInt(cbunidadpeso.SelectedValue) = CInt(item(0)) Then
                    recorrepacas(CInt(item(0)), CDec(item(2)))
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString() & " Error en la siguiente paca .", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub recorrepacas(idunidad As Integer, valorunidad As Decimal)
        Dim decimalesDeseados As Integer = 4
        Dim factor As Decimal = CDec(Math.Pow(10, decimalesDeseados))
        Dim sumaprecio As Decimal = 0D, sumacastigomic As Decimal = 0D, sumacastigouhml As Decimal = 0D,
        sumacastigores As Decimal = 0D, sumacastigouni As Decimal = 0D, sumacastigosfi As Decimal = 0D

        If idunidad = 1 Then
            For Each fila As DataRow In dtdestino.Rows
                Dim precioclasegrade As Decimal = precioclase(fila("grade").ToString())
                Dim quintales As Decimal = CDec(fila("quintalesVenta"))
                Dim kilos As Decimal = Convert.ToDecimal(fila("kilosVenta"))
                Dim libras As Decimal = Convert.ToDecimal(fila("librasVenta"))

                fila("idVentaenc") = If(String.IsNullOrEmpty(TbIdVentaPaca.Text), 0, Convert.ToInt32(TbIdVentaPaca.Text.Trim()))
                fila("preciodlsVenta") = Math.Truncate((quintales * precioclasegrade) * factor) / factor
                fila("precioclaseVenta") = precioclasegrade
                fila("castigomicvta") = consultacastigomic(quintales, Math.Truncate(Convert.ToDecimal(fila("mic")) * 100) / 100)
                fila("castigolargofibravta") = consultacastigouhml(quintales, Math.Truncate(Convert.ToDecimal(fila("uhml")) * 100) / 100)
                fila("castigoresistenciafibravta") = consultacastigores(quintales, Math.Truncate(Convert.ToDecimal(fila("strength")) * 100) / 100)
                fila("castigouiVenta") = consultacastigouni(quintales, Math.Truncate(Convert.ToDecimal(fila("ui")) * 100) / 100)
                'fila("castigosfiventa") = consultacastigosfi(quintales, Math.Truncate(Convert.ToDecimal(fila("sfi")) * 100) / 100)

                sumaprecio += Math.Round(CDec(fila("preciodlsVenta")), 5)
                sumacastigomic += Math.Round(CDec(fila("castigomicvta")), 5)
                sumacastigouhml += Math.Round(CDec(fila("castigolargofibravta")), 5)
                sumacastigores += Math.Round(CDec(fila("castigoresistenciafibravta")), 5)
                sumacastigouni += Math.Round(CDec(fila("castigouiVenta")), 5)
                'sumacastigosfi += Math.Round(CDec(fila("castigosfiventa")), 5)
            Next
        ElseIf idunidad = 2 Then
            For Each fila As DataRow In dtdestino.Rows
                Dim precioclasegrade As Decimal = precioclase(fila("grade").ToString()) / 100
                Dim kilos As Decimal = Convert.ToDecimal(fila("kilosVenta"))
                Dim libras As Decimal = Convert.ToDecimal(fila("librasVenta"))

                fila("idVentaenc") = If(String.IsNullOrEmpty(TbIdVentaPaca.Text), 0, Convert.ToInt32(TbIdVentaPaca.Text.Trim()))
                fila("preciodlsVenta") = Math.Truncate((libras * precioclasegrade) * factor) / factor
                fila("precioclaseVenta") = precioclasegrade
                fila("castigomicvta") = (consultacastigomic(libras, Math.Truncate(Convert.ToDecimal(fila("mic")) * 100) / 100) / 100)
                fila("castigolargofibravta") = (consultacastigouhml(libras, Math.Truncate(Convert.ToDecimal(fila("uhml")) * 100) / 100) / 100)
                fila("castigoresistenciafibravta") = (consultacastigores(libras, Math.Truncate(Convert.ToDecimal(fila("strength")) * 100) / 100) / 100)
                fila("castigouiVenta") = (consultacastigouni(libras, Math.Truncate(Convert.ToDecimal(fila("ui")) * 100) / 100) / 100)
                'fila("castigosfiventa") = (consultacastigosfi(libras, Math.Truncate(Convert.ToDecimal(fila("sfi")) * 100) / 100) / 100)

                sumaprecio += Math.Round(CDec(fila("preciodlsVenta")), 5)
                sumacastigomic += Math.Round(CDec(fila("castigomicvta")), 5)
                sumacastigouhml += Math.Round(CDec(fila("castigolargofibravta")), 5)
                sumacastigores += Math.Round(CDec(fila("castigoresistenciafibravta")), 5)
                sumacastigouni += Math.Round(CDec(fila("castigouiVenta")), 5)
                'sumacastigosfi += Math.Round(CDec(fila("castigosfiventa")), 5)
            Next
        End If

        nusubtotal.Value = sumaprecio
        nucastigomic.Value = sumacastigomic
        'nucastigosfi.Value = sumacastigosfi
        nucastigostr.Value = sumacastigores
        nucastigouhml.Value = sumacastigouhml
        nucastigouni.Value = sumacastigouni

        dataGridViewDestino.Refresh()
        nutotaldeduccion.Value = sumacastigomic + sumacastigores + sumacastigouhml + sumacastigouni
        nutotal.Value = sumaprecio - (sumacastigomic + sumacastigores + sumacastigouhml + sumacastigouni)
    End Sub
    Private Function precioclase(grado As String) As Decimal
        Dim precioencontrado As Decimal = 0.0D

        For Each fila As DataGridViewRow In dgvprecioclase.Rows
            If fila.Cells("grade").Value.ToString() = grado Then
                ' Coincidencia encontrada, obtén el valor de la columna "precioclase"
                If fila.Cells("precioclase").Value IsNot Nothing AndAlso Decimal.TryParse(fila.Cells("precioclase").Value.ToString(), precioencontrado) Then
                    ' Valor válido encontrado, salir del bucle
                    Exit For
                End If
            End If
        Next

        Return precioencontrado
    End Function
    Private Function consultacastigomic(valorunidad As Decimal, parametro As Decimal) As Decimal
        Dim castigo As Decimal = 0D

        If ckMicros.Checked Then
            ' Obtener el valor de cbperfilmicros desde el hilo de UI de forma segura
            Dim idPerfilMic As Integer = 0

            If cbperfilmicros.InvokeRequired Then
                cbperfilmicros.Invoke(New MethodInvoker(Sub()
                                                            idPerfilMic = Convert.ToInt32(cbperfilmicros.SelectedValue)
                                                        End Sub))
            Else
                idPerfilMic = Convert.ToInt32(cbperfilmicros.SelectedValue)
            End If

            If dtmic.Rows.Count = 0 Then
                Dim ecatalogos As New Capa_Entidad.VentaPacasContrato
                Dim ncatalogos As New Capa_Negocio.VentaPacasContrato

                ecatalogos.Consulta = Consulta.consultaperfilmicros
                ecatalogos.IdModoEncabezadoMicros = idPerfilMic
                ncatalogos.Consultar(ecatalogos)

                dtmic = ecatalogos.TablaConsulta

                Dim resultado As Decimal = BuscarCastigo(dtmic, parametro)
                castigo = Math.Truncate((resultado * valorunidad) * 10000D) / 10000D
            Else
                Dim resultado As Decimal = BuscarCastigo(dtmic, parametro)
                castigo = Math.Truncate((resultado * valorunidad) * 10000D) / 10000D
            End If
        End If

        Return castigo
    End Function
    Private Function consultacastigouhml(valorunidad As Decimal, parametro As Decimal) As Decimal
        Dim castigo As Decimal = 0D

        If CkLargo.Checked Then
            ' Obtener el valor de cbperfiluhml de forma segura
            Dim idPerfilUhml As Integer = 0

            If cbperfiluhml.InvokeRequired Then
                cbperfiluhml.Invoke(New MethodInvoker(Sub()
                                                          idPerfilUhml = Convert.ToInt32(cbperfiluhml.SelectedValue)
                                                      End Sub))
            Else
                idPerfilUhml = Convert.ToInt32(cbperfiluhml.SelectedValue)
            End If

            If dtuhml.Rows.Count = 0 Then
                Dim ecatalogos As New Capa_Entidad.VentaPacasContrato
                Dim ncatalogos As New Capa_Negocio.VentaPacasContrato

                ecatalogos.Consulta = Consulta.consultaperfiluhml
                ecatalogos.IdModoEncabezadoLargoFibra = idPerfilUhml
                ncatalogos.Consultar(ecatalogos)

                dtuhml = ecatalogos.TablaConsulta

                Dim resultado As Decimal = BuscarCastigo(dtuhml, parametro)
                castigo = Math.Truncate((resultado * valorunidad) * 10000D) / 10000D
            Else
                Dim resultado As Decimal = BuscarCastigo(dtuhml, parametro)
                castigo = Math.Truncate((resultado * valorunidad) * 10000D) / 10000D
            End If
        End If

        Return castigo
    End Function
    Private Function consultacastigores(valorunidad As Decimal, parametro As Decimal) As Decimal
        Dim castigo As Decimal = 0D

        If CkRes.Checked Then
            ' Obtener el valor de cbperfilstrength de forma segura
            Dim idPerfilStr As Integer = 0

            If cbperfilstrength.InvokeRequired Then
                cbperfilstrength.Invoke(New MethodInvoker(Sub()
                                                              idPerfilStr = Convert.ToInt32(cbperfilstrength.SelectedValue)
                                                          End Sub))
            Else
                idPerfilStr = Convert.ToInt32(cbperfilstrength.SelectedValue)
            End If

            If dtstr.Rows.Count = 0 Then
                Dim ecatalogos As New Capa_Entidad.VentaPacasContrato
                Dim ncatalogos As New Capa_Negocio.VentaPacasContrato

                ecatalogos.Consulta = Consulta.consultaperfilres
                ecatalogos.IdModoEncabezadoResistencia = idPerfilStr
                ncatalogos.Consultar(ecatalogos)

                dtstr = ecatalogos.TablaConsulta

                Dim resultado As Decimal = BuscarCastigo(dtstr, parametro)
                castigo = Math.Truncate((resultado * valorunidad) * 10000D) / 10000D
            Else
                Dim resultado As Decimal = BuscarCastigo(dtstr, parametro)
                castigo = Math.Truncate((resultado * valorunidad) * 10000D) / 10000D
            End If
        End If

        Return castigo
    End Function
    Private Function consultacastigouni(valorunidad As Decimal, parametro As Decimal) As Decimal
        Dim castigo As Decimal = 0D

        If CkUni.Checked Then
            ' Obtener el valor de cbperfilui de forma segura
            Dim idPerfilUni As Integer = 0

            If cbperfilui.InvokeRequired Then
                cbperfilui.Invoke(New MethodInvoker(Sub()
                                                        idPerfilUni = Convert.ToInt32(cbperfilui.SelectedValue)
                                                    End Sub))
            Else
                idPerfilUni = Convert.ToInt32(cbperfilui.SelectedValue)
            End If

            If dtui.Rows.Count = 0 Then
                Dim ecatalogos As New Capa_Entidad.VentaPacasContrato
                Dim ncatalogos As New Capa_Negocio.VentaPacasContrato

                ecatalogos.Consulta = Consulta.consultaperfilui
                ecatalogos.IdModoEncabezadoUniformidad = idPerfilUni
                ncatalogos.Consultar(ecatalogos)

                dtui = ecatalogos.TablaConsulta
                Dim resultado As Decimal = BuscarCastigo(dtui, parametro)
                castigo = Math.Truncate((resultado * valorunidad) * 10000D) / 10000D
            Else
                Dim resultado As Decimal = BuscarCastigo(dtui, parametro)
                castigo = Math.Truncate((resultado * valorunidad) * 10000D) / 10000D
            End If
        End If

        Return castigo
    End Function
    Private Sub dataGridViewDestino_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewDestino.CellContentClick
        dataGridViewDestino.EndEdit()
        Dim cantidadSeleccionada As Integer = ContarCeldasSeleccionadas(destinoView)
        tspacasseleccionadas.Text = cantidadSeleccionada.ToString()
    End Sub

    Private Sub dataGridViewOrigen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewOrigen.CellContentClick
        dataGridViewOrigen.EndEdit()
        Dim cantidadSeleccionada As Integer = ContarCeldasSeleccionadas(origenView)
        tbpacaseleccionadadisp.Text = cantidadSeleccionada.ToString()
    End Sub

    Private Sub guardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles guardarToolStripMenuItem.Click
        If Not String.IsNullOrEmpty(TbIdProductor.Text) And Not String.IsNullOrEmpty(TbIdContrato.Text) Then
            Try
                calculopacas()
                guardarenc()
                guardadet(dtdestino, IIf(TbIdVentaPaca.Text = "", 0, TbIdVentaPaca.Text))
                guardadet(dtorigen, 0)
                actualizacontrato()
                MessageBox.Show("Guardado con exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No se puede continuar con datos sin capturar, revise si hay productor seleccionado y un contrato para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub guardarenc()
        Dim ecatalogos As New Capa_Entidad.VentaPacasContrato
        Dim ncatalogos As New Capa_Negocio.VentaPacasContrato
        If cbestatus.SelectedIndex = -1 Then cbestatus.SelectedValue = 1
        ecatalogos.Guarda = Guardar.GuardaVentaenc
        ecatalogos.IdVenta = IIf(TbIdVentaPaca.Text = "", 0, TbIdVentaPaca.Text)
        ecatalogos.IdPlanta = CbPlanta.SelectedValue
        ecatalogos.IdComprador = TbIdProductor.Text
        ecatalogos.IdContrato = TbIdContrato.Text
        ecatalogos.tara = nutara.Value
        ecatalogos.checktara = ckactivatara.Checked
        ecatalogos.TotalPacas = destinoView.Count
        ecatalogos.SubTotal = nusubtotal.Value
        ecatalogos.CastigoMicros = nucastigomic.Value
        ecatalogos.CastigoResistenciaFibra = nucastigostr.Value
        ecatalogos.CastigoLargoFibra = nucastigouhml.Value
        ecatalogos.CastigoUniformidad = nucastigouni.Value
        ecatalogos.deduccion = nutotaldeduccion.Value
        ecatalogos.TotalDlls = nutotal.Value
        ecatalogos.FechaCreacion = Now
        ecatalogos.FechaActualizacion = Now
        ecatalogos.IdEstatusVenta = cbestatus.SelectedValue
        ncatalogos.Guardar(ecatalogos)
        TbIdVentaPaca.Text = ecatalogos.IdVenta.ToString
    End Sub
    Private Sub guardadet(ByRef dt As DataTable, ByRef id As Integer)
        Dim ecatalogos As New Capa_Entidad.VentaPacasContrato
        Dim ncatalogos As New Capa_Negocio.VentaPacasContrato
        For Each row As DataRow In dt.Rows
            ecatalogos.Guarda = Guardar.GuardaVentadet
            ecatalogos.idproducciondetalle = row("idproducciondetalle")
            ecatalogos.IdVenta = id
            ecatalogos.Baleid = row("baleid")
            ecatalogos.Kilos = row("kilosVenta")
            ecatalogos.libras = row("librasVenta")
            ecatalogos.Quintales = row("quintalesVenta")
            ecatalogos.preciodlsVenta = row("PrecioDlsVenta")
            ecatalogos.precioclaseVenta = row("precioclaseVenta")
            ecatalogos.CastigoMicros = row("CastigoMicvta")
            ecatalogos.CastigoLargoFibra = row("CastigoLargoFibravta")
            ecatalogos.CastigoResistenciaFibra = row("CastigoResistenciaFibravta")
            ecatalogos.CastigoUniformidad = row("castigouiVenta")
            ncatalogos.Guardar(ecatalogos)
        Next
    End Sub
    Private Sub actualizacontrato()
        Dim econtrato As New Capa_Entidad.VentaPacasContrato
        Dim ncontrato As New Capa_Negocio.VentaPacasContrato
        For Each row As DataGridViewRow In dgvcontratos.Rows
            If row.Cells("idcontratoalgodon").Value = Convert.ToInt32(TbIdContrato.Text) Then
                econtrato.Actualiza = Actualiza.ActualizaContratoVenta
                econtrato.IdContrato = row.Cells("idcontratoalgodon").Value
                econtrato.PacasDisponibles = row.Cells("pacasdisponibles").Value
                econtrato.PacasVendidas = row.Cells("pacasVendidas").Value
                ncontrato.Actualizar(econtrato)
            End If
        Next
    End Sub
    Private Sub ckactivatara_CheckedChanged(sender As Object, e As EventArgs) Handles ckactivatara.CheckedChanged
        If ckactivatara.Checked = True Then
            nutara.Enabled = True
            nutara.Select()
        Else
            nutara.Enabled = False
            nutara.Value = 0
        End If

    End Sub
    Private Shared Function BuscarCastigo(dt As DataTable, parametro As Decimal) As Decimal
        Dim fila = dt.AsEnumerable().FirstOrDefault(Function(row) parametro >= row.Field(Of Decimal)("rango1") AndAlso parametro <= row.Field(Of Decimal)("rango2"))

        If fila IsNot Nothing Then
            Return fila.Field(Of Decimal)("castigo")
        Else
            Return 0D ' Retorna 0 si no encuentra coincidencias
        End If
    End Function

    Private Sub configdgvprecioclase(ByVal dgv As DataGridView)

        Dim newColIdmodo As New DataGridViewTextBoxColumn()
        Dim newColIdClasif As New DataGridViewTextBoxColumn()
        Dim newColgrade As New DataGridViewTextBoxColumn()
        Dim newColdif As New DataGridViewTextBoxColumn()
        Dim newColprecio As New DataGridViewTextBoxColumn()

        newColIdmodo.HeaderText = "idmodoencabezado"
        newColIdmodo.Name = "idmodoencabezado"
        newColIdmodo.Visible = False
        dgv.Columns.Add(newColIdmodo)

        newColIdClasif.HeaderText = "ID Clase"
        newColIdClasif.Name = "idclasificacion"
        dgv.Columns.Add(newColIdClasif)

        newColgrade.HeaderText = "Grade"
        newColgrade.Name = "Grade"
        dgv.Columns.Add(newColgrade)

        newColdif.HeaderText = "Dif"
        newColdif.Name = "diferencial"
        dgv.Columns.Add(newColdif)

        newColprecio.HeaderText = "Precio"
        newColprecio.Name = "precioclase"
        dgv.Columns.Add(newColprecio)
    End Sub
    Private Sub configuradgvorigen(ByVal dgv As DataGridView)

        dgv.VirtualMode = True

        Dim newColIdProduccionDet As New DataGridViewTextBoxColumn()
        Dim newColIdProduccion As New DataGridViewTextBoxColumn()
        Dim newColidgin = New DataGridViewTextBoxColumn()
        'Dim newColidlote = New DataGridViewTextBoxColumn()
        Dim newColidcalculo = New DataGridViewTextBoxColumn()
        Dim newColbaleid = New DataGridViewTextBoxColumn()
        Dim newColmic = New DataGridViewTextBoxColumn()
        Dim newColuhml = New DataGridViewTextBoxColumn()
        Dim newColui = New DataGridViewTextBoxColumn()
        Dim newColstrength = New DataGridViewTextBoxColumn()
        Dim newColsfi = New DataGridViewTextBoxColumn()
        Dim newColelongation = New DataGridViewTextBoxColumn()
        Dim newColgrade = New DataGridViewTextBoxColumn()
        Dim newColcolorgrade = New DataGridViewTextBoxColumn()
        Dim newColtrashcount = New DataGridViewTextBoxColumn()
        Dim newColtrasharea = New DataGridViewTextBoxColumn()
        Dim newColtrashid = New DataGridViewTextBoxColumn()
        Dim newColsci = New DataGridViewTextBoxColumn()
        Dim newColkilos = New DataGridViewTextBoxColumn()
        Dim newCollibras = New DataGridViewTextBoxColumn()
        Dim newColquintales = New DataGridViewTextBoxColumn()
        Dim newColkilosVenta = New DataGridViewTextBoxColumn()
        Dim newCollibrasVenta = New DataGridViewTextBoxColumn()
        Dim newColquintalesVenta = New DataGridViewTextBoxColumn()
        Dim newColprecioVenta = New DataGridViewTextBoxColumn()
        Dim newColprecioclase = New DataGridViewTextBoxColumn()
        Dim newColcastigomic = New DataGridViewTextBoxColumn()
        Dim newColcastigouhml = New DataGridViewTextBoxColumn()
        Dim newColcastigores = New DataGridViewTextBoxColumn()
        Dim newColcastigouni = New DataGridViewTextBoxColumn()
        'Dim newColcastigosfi = New DataGridViewTextBoxColumn()
        'Dim newColidtemporada = New DataGridViewTextBoxColumn()
        'Dim newColtemporada = New DataGridViewTextBoxColumn()
        Dim newColSeleccionar = New DataGridViewCheckBoxColumn()

        newColIdProduccionDet.HeaderText = "IdProduccionDet"
        newColIdProduccionDet.Name = "IdProduccionDet"
        newColIdProduccionDet.Visible = False
        dgv.Columns.Add(newColIdProduccionDet)

        newColIdProduccion.HeaderText = "IdProduccion"
        newColIdProduccion.Name = "IdProduccion"
        newColIdProduccion.Visible = False
        dgv.Columns.Add(newColIdProduccion)

        newColidgin.HeaderText = "idplantaorigen"
        newColidgin.Name = "idplantaorigen"
        newColidgin.Visible = False
        dgv.Columns.Add(newColidgin)

        'newColidlote.HeaderText = "idlote"
        'newColidlote.Name = "idlote"
        'newColidlote.Visible = False
        'dgv.Columns.Add(newColidlote)

        newColidcalculo.HeaderText = "ID Venta"
        newColidcalculo.Name = "IdVentaenc"
        newColidcalculo.Visible = False
        dgv.Columns.Add(newColidcalculo)

        newColbaleid.HeaderText = "BaleID"
        newColbaleid.Name = "baleid"
        newColbaleid.ReadOnly = True
        dgv.Columns.Add(newColbaleid)

        newColmic.HeaderText = "Mic"
        newColmic.Name = "mic"
        newColmic.ReadOnly = True
        dgv.Columns.Add(newColmic)

        newColuhml.HeaderText = "UHML"
        newColuhml.Name = "uhml"
        newColuhml.ReadOnly = True
        dgv.Columns.Add(newColuhml)

        newColui.HeaderText = "UI"
        newColui.Name = "ui"
        newColui.ReadOnly = True
        dgv.Columns.Add(newColui)

        newColstrength.HeaderText = "Strength"
        newColstrength.Name = "strength"
        newColstrength.ReadOnly = True
        dgv.Columns.Add(newColstrength)

        newColsfi.HeaderText = "SFI"
        newColsfi.Name = "sfi"
        newColsfi.ReadOnly = True
        dgv.Columns.Add(newColsfi)

        newColelongation.HeaderText = "Elongation"
        newColelongation.Name = "elongation"
        newColelongation.Visible = False
        dgv.Columns.Add(newColelongation)

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

        newColsci.HeaderText = "SCI"
        newColsci.Name = "sci"
        newColsci.Visible = False
        dgv.Columns.Add(newColsci)

        newColkilos.HeaderText = "Kilos"
        newColkilos.Name = "kilos"
        newColkilos.ReadOnly = True
        dgv.Columns.Add(newColkilos)

        newCollibras.HeaderText = "Libras"
        newCollibras.Name = "libras"
        newCollibras.ReadOnly = True
        dgv.Columns.Add(newCollibras)

        newColquintales.HeaderText = "Quintales"
        newColquintales.Name = "quintales"
        newColquintales.ReadOnly = True
        dgv.Columns.Add(newColquintales)

        newColkilosVenta.HeaderText = "Kilos Venta"
        newColkilosVenta.Name = "kilosVenta"
        newColkilosVenta.Visible = False
        dgv.Columns.Add(newColkilosVenta)

        newCollibrasVenta.HeaderText = "Libras Venta"
        newCollibrasVenta.Name = "librasVenta"
        newCollibrasVenta.Visible = False
        dgv.Columns.Add(newCollibrasVenta)

        newColquintalesVenta.HeaderText = "Quintales Venta"
        newColquintalesVenta.Name = "quintalesVenta"
        newColquintalesVenta.Visible = False
        dgv.Columns.Add(newColquintalesVenta)

        newColprecioVenta.HeaderText = "preciodlsVenta"
        newColprecioVenta.Name = "preciodlsVenta"
        newColprecioVenta.Visible = False
        dgv.Columns.Add(newColprecioVenta)

        newColprecioclase.HeaderText = "precioclaseVenta"
        newColprecioclase.Name = "precioclaseVenta"
        newColprecioclase.Visible = False
        dgv.Columns.Add(newColprecioclase)

        newColcastigomic.HeaderText = "castigomicvta"
        newColcastigomic.Name = "castigomicvta"
        newColcastigomic.Visible = False
        dgv.Columns.Add(newColcastigomic)

        newColcastigouhml.HeaderText = "castigolargofibravta"
        newColcastigouhml.Name = "castigolargofibravta"
        newColcastigouhml.Visible = False
        dgv.Columns.Add(newColcastigouhml)

        newColcastigores.HeaderText = "castigoresistenciafibravta"
        newColcastigores.Name = "castigoresistenciafibravta"
        newColcastigores.Visible = False
        dgv.Columns.Add(newColcastigores)

        newColcastigouni.HeaderText = "castigouiVenta"
        newColcastigouni.Name = "castigouiVenta"
        newColcastigouni.Visible = False
        dgv.Columns.Add(newColcastigouni)

        'newColcastigosfi.HeaderText = "castigosfi"
        'newColcastigosfi.Name = "castigosfi"
        'newColcastigosfi.Visible = False
        'dgv.Columns.Add(newColcastigosfi)

        'newColidtemporada.HeaderText = "idtemporada"
        'newColidtemporada.Name = "idtemporada"
        'newColidtemporada.Visible = False
        'dgv.Columns.Add(newColidtemporada)

        'newColtemporada.HeaderText = "Temporada"
        'newColtemporada.Name = "Temporada"
        'newColtemporada.ReadOnly = True
        'dgv.Columns.Add(newColtemporada)

        newColSeleccionar.HeaderText = "Seleccionar"
        newColSeleccionar.Name = "Seleccionar"
        newColSeleccionar.ReadOnly = False
        dgv.Columns.Add(newColSeleccionar)
    End Sub
    Private Sub configuradgvdestino(ByVal dgv As DataGridView)

        dgv.VirtualMode = True

        Dim newColIdProduccionDet As New DataGridViewTextBoxColumn()
        Dim newColIdProduccion As New DataGridViewTextBoxColumn()
        Dim newColidgin = New DataGridViewTextBoxColumn()
        'Dim newColidlote = New DataGridViewTextBoxColumn()
        Dim newColidcalculo = New DataGridViewTextBoxColumn()
        Dim newColbaleid = New DataGridViewTextBoxColumn()
        Dim newColmic = New DataGridViewTextBoxColumn()
        Dim newColuhml = New DataGridViewTextBoxColumn()
        Dim newColui = New DataGridViewTextBoxColumn()
        Dim newColstrength = New DataGridViewTextBoxColumn()
        Dim newColsfi = New DataGridViewTextBoxColumn()
        Dim newColelongation = New DataGridViewTextBoxColumn()
        Dim newColgrade = New DataGridViewTextBoxColumn()
        Dim newColcolorgrade = New DataGridViewTextBoxColumn()
        Dim newColtrashcount = New DataGridViewTextBoxColumn()
        Dim newColtrasharea = New DataGridViewTextBoxColumn()
        Dim newColtrashid = New DataGridViewTextBoxColumn()
        Dim newColsci = New DataGridViewTextBoxColumn()
        Dim newColkilos = New DataGridViewTextBoxColumn()
        Dim newCollibras = New DataGridViewTextBoxColumn()
        Dim newColquintales = New DataGridViewTextBoxColumn()
        Dim newColkilosVenta = New DataGridViewTextBoxColumn()
        Dim newCollibrasVenta = New DataGridViewTextBoxColumn()
        Dim newColquintalesVenta = New DataGridViewTextBoxColumn()
        Dim newColprecioVenta = New DataGridViewTextBoxColumn()
        Dim newColprecioclase = New DataGridViewTextBoxColumn()
        Dim newColcastigomic = New DataGridViewTextBoxColumn()
        Dim newColcastigouhml = New DataGridViewTextBoxColumn()
        Dim newColcastigores = New DataGridViewTextBoxColumn()
        Dim newColcastigouni = New DataGridViewTextBoxColumn()
        'Dim newColcastigosfi = New DataGridViewTextBoxColumn()
        'Dim newColidtemporada = New DataGridViewTextBoxColumn()
        'Dim newColtemporada = New DataGridViewTextBoxColumn()
        Dim newColSeleccionar = New DataGridViewCheckBoxColumn()

        newColIdProduccionDet.HeaderText = "IdProduccionDet"
        newColIdProduccionDet.Name = "IdProduccionDet"
        newColIdProduccionDet.Visible = False
        dgv.Columns.Add(newColIdProduccionDet)

        newColIdProduccion.HeaderText = "IdProduccion"
        newColIdProduccion.Name = "IdProduccion"
        newColIdProduccion.Visible = False
        dgv.Columns.Add(newColIdProduccion)

        newColidgin.HeaderText = "idplantaorigen"
        newColidgin.Name = "idplantaorigen"
        newColidgin.Visible = False
        dgv.Columns.Add(newColidgin)

        'newColidlote.HeaderText = "idlote"
        'newColidlote.Name = "idlote"
        'newColidlote.Visible = False
        'dgv.Columns.Add(newColidlote)

        newColidcalculo.HeaderText = "idventaenc"
        newColidcalculo.Name = "idventaenc"
        newColidcalculo.Visible = False
        dgv.Columns.Add(newColidcalculo)

        newColbaleid.HeaderText = "BaleID"
        newColbaleid.Name = "baleid"
        newColbaleid.ReadOnly = True
        dgv.Columns.Add(newColbaleid)

        newColmic.HeaderText = "Mic"
        newColmic.Name = "mic"
        newColmic.ReadOnly = True
        dgv.Columns.Add(newColmic)

        newColuhml.HeaderText = "UHML"
        newColuhml.Name = "uhml"
        newColuhml.ReadOnly = True
        dgv.Columns.Add(newColuhml)

        newColui.HeaderText = "UI"
        newColui.Name = "ui"
        newColui.ReadOnly = True
        dgv.Columns.Add(newColui)

        newColstrength.HeaderText = "Strength"
        newColstrength.Name = "strength"
        newColstrength.ReadOnly = True
        dgv.Columns.Add(newColstrength)

        newColsfi.HeaderText = "SFI"
        newColsfi.Name = "sfi"
        newColsfi.ReadOnly = True
        dgv.Columns.Add(newColsfi)

        newColelongation.HeaderText = "Elongation"
        newColelongation.Name = "elongation"
        newColelongation.Visible = False
        dgv.Columns.Add(newColelongation)

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

        newColsci.HeaderText = "SCI"
        newColsci.Name = "sci"
        newColsci.Visible = False
        dgv.Columns.Add(newColsci)

        newColkilos.HeaderText = "Kilos"
        newColkilos.Name = "kilos"
        newColkilos.Visible = False
        dgv.Columns.Add(newColkilos)

        newCollibras.HeaderText = "Libras"
        newCollibras.Name = "libras"
        newCollibras.Visible = False
        dgv.Columns.Add(newCollibras)

        newColquintales.HeaderText = "Quintales"
        newColquintales.Name = "quintales"
        newColquintales.Visible = False
        dgv.Columns.Add(newColquintales)

        newColkilosVenta.HeaderText = "Kilos Venta"
        newColkilosVenta.Name = "kilosVenta"
        newColkilosVenta.ReadOnly = True
        dgv.Columns.Add(newColkilosVenta)

        newCollibrasVenta.HeaderText = "Libras Venta"
        newCollibrasVenta.Name = "librasVenta"
        newCollibrasVenta.ReadOnly = True
        dgv.Columns.Add(newCollibrasVenta)

        newColquintalesVenta.HeaderText = "Quintales Venta"
        newColquintalesVenta.Name = "quintalesVenta"
        newColquintalesVenta.ReadOnly = True
        dgv.Columns.Add(newColquintalesVenta)

        newColprecioVenta.HeaderText = "preciodlsVenta"
        newColprecioVenta.Name = "preciodlsVenta"
        newColprecioVenta.Visible = False
        dgv.Columns.Add(newColprecioVenta)

        newColprecioclase.HeaderText = "precioclaseVenta"
        newColprecioclase.Name = "precioclaseVenta"
        newColprecioclase.Visible = False
        dgv.Columns.Add(newColprecioclase)

        newColcastigomic.HeaderText = "castigomicvta"
        newColcastigomic.Name = "castigomicvta"
        newColcastigomic.Visible = False
        dgv.Columns.Add(newColcastigomic)

        newColcastigouhml.HeaderText = "castigolargofibravta"
        newColcastigouhml.Name = "castigolargofibravta"
        newColcastigouhml.Visible = False
        dgv.Columns.Add(newColcastigouhml)

        newColcastigores.HeaderText = "castigoresistenciafibravta"
        newColcastigores.Name = "castigoresistenciafibravta"
        newColcastigores.Visible = False
        dgv.Columns.Add(newColcastigores)

        newColcastigouni.HeaderText = "castigouiVenta"
        newColcastigouni.Name = "castigouiVenta"
        newColcastigouni.Visible = False
        dgv.Columns.Add(newColcastigouni)

        'newColcastigosfi.HeaderText = "castigosfi"
        'newColcastigosfi.Name = "castigosfi"
        'newColcastigosfi.Visible = False
        'dgv.Columns.Add(newColcastigosfi)

        'newColidtemporada.HeaderText = "idtemporada"
        'newColidtemporada.Name = "idtemporada"
        'newColidtemporada.Visible = False
        'dgv.Columns.Add(newColidtemporada)

        'newColtemporada.HeaderText = "Temporada"
        'newColtemporada.Name = "Temporada"
        'newColtemporada.ReadOnly = True
        'dgv.Columns.Add(newColtemporada)

        newColSeleccionar.HeaderText = "Seleccionar"
        newColSeleccionar.Name = "Seleccionar"
        newColSeleccionar.ReadOnly = False
        dgv.Columns.Add(newColSeleccionar)
    End Sub
    Private Sub btconsultaclientes_Click(sender As Object, e As EventArgs) Handles btconsultaclientes.Click
        Dim _ConsultaProductorContratoVentas As New FConsultaProductorContratoVenta
        _ConsultaProductorContratoVentas.ShowDialog()
        'Nuevo()
        Try
            If _ConsultaProductorContratoVentas._id > 0 Then
                limpiar()
                TbIdProductor.Text = _ConsultaProductorContratoVentas._id
                TbNombreProductor.Text = _ConsultaProductorContratoVentas._nombre
                consultadatosComprador()
                cargadatagrid()
                gbcontratos.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'ConsultarDatosVenta()
        'gbcontratos.Enabled = True
    End Sub
    Private Sub consultadatosComprador()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        '---Consultar contratos del productor---
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPorId
        EntidadVentaPacasContrato.IdComprador = CInt(TbIdProductor.Text)
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        Tabla = EntidadVentaPacasContrato.TablaConsulta
        dgvcontratos.Columns.Clear()
        dgvcontratos.DataSource = Tabla
        'Dim colSelCon As New DataGridViewCheckBoxColumn()
        'colSelCon.Name = "Seleccionar"
        'colSelCon.FalseValue = False
        'colSelCon.Visible = True
        'dgvcontratos.Columns.Insert(22, colSelCon)
        PropiedadesDgvContratos()
    End Sub
    Private Sub cargadatagrid()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        EntidadVentaPacasContrato.Consulta = Consulta.consultapacasinVenta
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        dtorigen = EntidadVentaPacasContrato.TablaConsulta
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
    Private Sub cargadataVenta()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPacaVendida
        EntidadVentaPacasContrato.IdVenta = TbIdVentaPaca.Text
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        dtdestino = EntidadVentaPacasContrato.TablaConsulta
        If dtdestino.Rows.Count > 0 Then

            'origenView = New DataView(dtorigen)
            'dtdestino = New DataTable()
            'dtdestino = dtorigen.Clone()
            destinoView = New DataView(dtdestino)

            'AddHandler dataGridViewOrigen.CellValueNeeded, AddressOf dataGridViewOrigen_CellValueNeeded
            'AddHandler dataGridViewOrigen.CellValuePushed, AddressOf dataGridViewOrigen_CellValuePushed
            AddHandler dataGridViewDestino.CellValueNeeded, AddressOf dataGridViewDestino_CellValueNeeded
            AddHandler dataGridViewDestino.CellValuePushed, AddressOf dataGridViewDestino_CellValuePushed

            If registrosCargadosDestino <= destinoView.Count Then
                Dim nuevasFilas As Integer = Math.Min(RegistrosPorCarga, destinoView.Count - registrosCargadosDestino)
                registrosCargadosDestino += nuevasFilas
                dataGridViewDestino.RowCount += nuevasFilas
            End If

        End If
    End Sub
    Private Sub PropiedadesDgvContratos()
        dgvcontratos.Columns("IdComprador").Visible = False
        dgvcontratos.Columns("idunidadpeso").Visible = False
        dgvcontratos.Columns("ValorConversion").Visible = False
        dgvcontratos.Columns("FechaLiquidacion").Visible = False
        dgvcontratos.Columns("Puntos").Visible = False
        dgvcontratos.Columns("Temporada").Visible = False
        dgvcontratos.Columns("IdModalidadVenta").Visible = False
        dgvcontratos.Columns("PrecioSM").Visible = False
        dgvcontratos.Columns("PrecioMP").Visible = False
        dgvcontratos.Columns("preciom").Visible = False
        dgvcontratos.Columns("PrecioSLMP").Visible = False
        dgvcontratos.Columns("PrecioSLM").Visible = False
        dgvcontratos.Columns("PrecioLMP").Visible = False
        dgvcontratos.Columns("PrecioLM").Visible = False
        dgvcontratos.Columns("PrecioSGO").Visible = False
        dgvcontratos.Columns("PrecioGO").Visible = False
        dgvcontratos.Columns("PrecioO").Visible = False
        dgvcontratos.Columns("Fecha").Visible = False


        dgvcontratos.Columns("IdContratoAlgodon").HeaderText = "ID"
        dgvcontratos.Columns("Pacas").HeaderText = "Contratadas"
        dgvcontratos.Columns("PacasVendidas").HeaderText = "Vendidas"
        dgvcontratos.Columns("PacasDisponibles").HeaderText = "Disponibles"


        dgvcontratos.Columns("IdContratoAlgodon").ReadOnly = True
        dgvcontratos.Columns("Pacas").ReadOnly = True
        dgvcontratos.Columns("PacasVendidas").ReadOnly = True
        dgvcontratos.Columns("PrecioQuintal").ReadOnly = True
        dgvcontratos.Columns("PacasDisponibles").ReadOnly = True
        dgvcontratos.Columns("Seleccionar").ReadOnly = False



    End Sub
    Private Sub CargarCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = -1
        '--Clases---
        'Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        'Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        'Dim Tabla2 As New DataTable
        'EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        'NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        'Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        'CbClasesPacasAVentar.DataSource = Tabla2
        'CbClasesPacasAVentar.ValueMember = "IdClasificacion"
        'CbClasesPacasAVentar.DisplayMember = "ClaveCorta"
        'CbClasesPacasAVentar.SelectedValue = -1
        'LLenaComboInstancias(CbClasesVendidas)
        'LLenaComboInstancias(CbClasesPacasAVentar)
        '-------------------------COMBO UNIDAD PESO
        Dim Tabla1 As New DataTable
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaUnidadPeso
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla1 = EntidadContratosAlgodon.TablaConsulta
        cbunidadpeso.DataSource = Tabla1
        cbunidadpeso.ValueMember = "IdUnidadPeso"
        cbunidadpeso.DisplayMember = "Descripcion"
        cbunidadpeso.SelectedValue = -1
        TablaUnidadPeso = Tabla1
        '---Modalidad De Venta--
        'Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        'Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim Tabla3 As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaModoVenta
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla3 = EntidadProduccion.TablaConsulta
        CbModalidadVenta.DataSource = Tabla3
        CbModalidadVenta.ValueMember = "IdModoEncabezado"
        CbModalidadVenta.DisplayMember = "Descripcion"
        CbModalidadVenta.SelectedIndex = -1
        '------------------------COMBO MICROS VENTA
        Dim Tabla2 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaMicrosVentaCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla2 = EntidadContratosAlgodon.TablaConsulta
        cbperfilmicros.DataSource = Tabla2
        cbperfilmicros.ValueMember = "IdModoEncabezado"
        cbperfilmicros.DisplayMember = "Descripcion"
        cbperfilmicros.SelectedIndex = 0
        '------------------------COMBO LARGO FIBRA VENTA
        Dim Table3 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaLargoFibraVentaCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Table3 = EntidadContratosAlgodon.TablaConsulta
        cbperfiluhml.DataSource = Table3
        cbperfiluhml.ValueMember = "IdModoEncabezado"
        cbperfiluhml.DisplayMember = "Descripcion"
        cbperfiluhml.SelectedIndex = 0
        '------------------------COMBO RESISTENCIA VENTA
        Dim Tabla4 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaResistenciaVentaCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla4 = EntidadContratosAlgodon.TablaConsulta
        cbperfilstrength.DataSource = Tabla4
        cbperfilstrength.ValueMember = "IdModoEncabezado"
        cbperfilstrength.DisplayMember = "Descripcion"
        cbperfilstrength.SelectedIndex = 0
        '------------------------COMBO UNIFORMIDAD VENTA
        Dim Tabla5 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaUniformidadVentaCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla5 = EntidadContratosAlgodon.TablaConsulta
        cbperfilui.DataSource = Tabla5
        cbperfilui.ValueMember = "IdModoEncabezado"
        cbperfilui.DisplayMember = "Descripcion"
        cbperfilui.SelectedIndex = 0
        '-----------------------COMBO BARK
        'Dim dtBark As DataTable = New DataTable("Tabla")
        'dtBark.Columns.Add("Id")
        'dtBark.Columns.Add("Descripcion")
        'Dim drBark As DataRow
        'drBark = dtBark.NewRow()
        'drBark("Id") = "1"
        'drBark("Descripcion") = "Bark"
        'dtBark.Rows.Add(drBark)
        'CbModoBark.DataSource = dtBark
        'CbModoBark.ValueMember = "Id"
        'CbModoBark.DisplayMember = "Descripcion"
        'CbModoBark.SelectedIndex = 0
        ''-----------------------COMBO PREP
        'Dim dtPrep As DataTable = New DataTable("Tabla")
        'dtPrep.Columns.Add("Id")
        'dtPrep.Columns.Add("Descripcion")
        'Dim drPrep As DataRow
        'drPrep = dtPrep.NewRow()
        'drPrep("Id") = "2"
        'drPrep("Descripcion") = "Prep"
        'dtPrep.Rows.Add(drPrep)
        'CbModoPrep.DataSource = dtPrep
        'CbModoPrep.ValueMember = "Id"
        'CbModoPrep.DisplayMember = "Descripcion"
        'CbModoPrep.SelectedIndex = 0
        ''-----------------------COMBO OTHER
        'Dim dtOther As DataTable = New DataTable("Tabla")
        'dtOther.Columns.Add("Id")
        'dtOther.Columns.Add("Descripcion")
        'Dim drOther As DataRow
        'drOther = dtOther.NewRow()
        'drOther("Id") = "3"
        'drOther("Descripcion") = "Other"
        'dtOther.Rows.Add(drOther)
        'CbModoOther.DataSource = dtOther
        'CbModoOther.ValueMember = "Id"l
        'CbModoOther.DisplayMember = "Descripcion"
        'CbModoOther.SelectedIndex = 0
        ''-----------------------COMBO PLASTIC
        'Dim dtPlastic As DataTable = New DataTable("Tabla")
        'dtPlastic.Columns.Add("Id")
        'dtPlastic.Columns.Add("Descripcion")
        'Dim drPlastic As DataRow
        'drPlastic = dtPlastic.NewRow()
        'drPlastic("Id") = "4"
        'drPlastic("Descripcion") = "Plastic"
        'dtPlastic.Rows.Add(drPlastic)
        'CbModoPlastic.DataSource = dtPlastic
        'CbModoPlastic.ValueMember = "Id"
        'CbModoPlastic.DisplayMember = "Descripcion"
        'CbModoPlastic.SelectedIndex = 0
    End Sub

    Private Sub dgvcontratos_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub obtenercontrato()
        PrecioSM = 0
        PrecioMP = 0
        PrecioM = 0
        PrecioSLMP = 0
        PrecioSLM = 0
        PrecioLMP = 0
        PrecioLM = 0
        PrecioSGO = 0
        PrecioGO = 0
        PrecioO = 0
        'Dim filaSeleccionada As Integer = dgvcontratos.CurrentRow.Index
        Dim countcheck As Integer = 0
        For Each row As DataGridViewRow In dgvcontratos.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If dgvcontratos.Rows(Index).Cells("Seleccionar").Value = True Then
                'dgvcontratos.Rows(Index).Cells("Seleccionar").Value = True
                nuPrecioQuintal.Value = dgvcontratos.Rows(Index).Cells("PrecioQuintal").Value
                nuNoPacas.Value = dgvcontratos.Rows(Index).Cells("Pacas").Value
                TbIdContrato.Text = dgvcontratos.Rows(Index).Cells("IdCOntratoAlgodon").Value
                CbModalidadVenta.SelectedValue = dgvcontratos.Rows(Index).Cells("IdModalidadVenta").Value
                cbunidadpeso.SelectedValue = dgvcontratos.Rows(Index).Cells("idunidadpeso").Value
                cantidadcontrato = dgvcontratos.Rows(Index).Cells("pacas").Value
                vendidas = dgvcontratos.Rows(Index).Cells("pacasVendidas").Value
                disponibles = dgvcontratos.Rows(Index).Cells("pacasdisponibles").Value
                nuPuntos.Value = dgvcontratos.Rows(Index).Cells("Puntos").Value
                PrecioSM = dgvcontratos.Rows(Index).Cells("PrecioSM").Value
                PrecioMP = dgvcontratos.Rows(Index).Cells("PrecioMP").Value
                PrecioM = dgvcontratos.Rows(Index).Cells("PrecioM").Value
                PrecioSLMP = dgvcontratos.Rows(Index).Cells("PrecioSLMP").Value
                PrecioSLM = dgvcontratos.Rows(Index).Cells("PrecioSLM").Value
                PrecioLMP = dgvcontratos.Rows(Index).Cells("PrecioLMP").Value
                PrecioLM = dgvcontratos.Rows(Index).Cells("PrecioLM").Value
                PrecioSGO = dgvcontratos.Rows(Index).Cells("PrecioSGO").Value
                PrecioGO = dgvcontratos.Rows(Index).Cells("PrecioGO").Value
                PrecioO = dgvcontratos.Rows(Index).Cells("PrecioO").Value
                If TablaUnidadPeso.Rows.Count > 0 Then
                    For Each Fila As DataRow In TablaUnidadPeso.Rows
                        If Fila.Item("IdUnidadPeso").ToString = cbunidadpeso.SelectedValue Then
                            TbValorConversion.Text = Fila.Item("ValorConversion").ToString
                        End If
                    Next
                End If
                'ConsultaParametrosVenta()
            Else
                'dgvcontratos.Rows(Index).Cells("Seleccionar").Value = False
            End If
            If dgvcontratos.Rows(Index).Cells("seleccionar").Value = True Then countcheck = countcheck + 1
        Next
        If countcheck = 0 Then
            nuPrecioQuintal.Value = 0
            nuNoPacas.Value = 0
            nuPuntos.Value = 0
            TbIdContrato.Text = ""
            cantidadcontrato = 0
            vendidas = 0
            disponibles = 0
            PrecioSM = 0
            PrecioMP = 0
            PrecioM = 0
            PrecioSLMP = 0
            PrecioSLM = 0
            PrecioLMP = 0
            PrecioLM = 0
            PrecioSGO = 0
            PrecioGO = 0
            PrecioO = 0
            ckMicros.Checked = False
            CkRes.Checked = False
            CkLargo.Checked = False
            CkUni.Checked = False
            cbunidadpeso.SelectedIndex = -1
            TbValorConversion.Text = ""
            nutara.Value = 0
            ckactivatara.Checked = False
            cbperfilmicros.SelectedIndex = -1
            cbperfilstrength.SelectedIndex = -1
            cbperfiluhml.SelectedIndex = -1
            cbperfilui.SelectedIndex = -1
            CbModalidadVenta.SelectedIndex = -1
            dgvprecioclase.Rows.Clear()
        End If
    End Sub
    Private Sub ConsultaParametrosVenta()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.ContratosAlgodon
        Dim NegocioVentaPacasContrato As New Capa_Negocio.ContratosAlgodon
        Dim TablaDetalle As New DataTable
        Dim TablaParametros As New DataTable
        EntidadVentaPacasContrato.IdContratoAlgodon = Val(TbIdContrato.Text)
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaParametrosContratoVenta
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        TablaParametros = EntidadVentaPacasContrato.TablaConsulta
        If TablaParametros.Rows.Count > 0 Then
            ckactivatara.Checked = TablaParametros.Rows(0).Item("EstatusPesoNeto")
            nutara.Value = TablaParametros.Rows(0).Item("KilosNeto")
            ckMicros.Checked = TablaParametros.Rows(0).Item("CheckMicros")
            cbperfilmicros.SelectedValue = TablaParametros.Rows(0).Item("IdModoMicros")
            CkLargo.Checked = TablaParametros.Rows(0).Item("CheckLargo")
            cbperfiluhml.SelectedValue = TablaParametros.Rows(0).Item("IdModoLargoFibra")
            CkRes.Checked = TablaParametros.Rows(0).Item("CheckResistencia")
            cbperfilstrength.SelectedValue = TablaParametros.Rows(0).Item("IdModoResistencia")
            CkUni.Checked = TablaParametros.Rows(0).Item("CheckUniformidad")
            cbperfilui.SelectedValue = TablaParametros.Rows(0).Item("IdModoUniformidad")
            'ChBark.Checked = TablaParametros.Rows(0).Item("CheckBark")
            'CbModoBark.SelectedValue = TablaParametros.Rows(0).Item("IdModoBark")
            'ChBarkLevel1.Checked = TablaParametros.Rows(0).Item("CheckBarkLevel1")
            'ChBarkLevel2.Checked = TablaParametros.Rows(0).Item("CheckBarkLevel2")
            'ChPrep.Checked = TablaParametros.Rows(0).Item("CheckPrep")
            'CbModoPrep.SelectedValue = TablaParametros.Rows(0).Item("IdModoPrep")
            'ChPrepLevel1.Checked = TablaParametros.Rows(0).Item("CheckPrepLevel1")
            'ChPrepLevel2.Checked = TablaParametros.Rows(0).Item("CheckPrepLevel2")
            'ChOther.Checked = TablaParametros.Rows(0).Item("CheckOther")
            'CbModoOther.SelectedValue = TablaParametros.Rows(0).Item("IdModoOther")
            'ChOtherLevel1.Checked = TablaParametros.Rows(0).Item("CheckOtherLevel1")
            'ChOtherLevel2.Checked = TablaParametros.Rows(0).Item("CheckOtherLevel2")
            'ChPlastic.Checked = TablaParametros.Rows(0).Item("CheckPlastic")
            'CbModoPlastic.SelectedValue = TablaParametros.Rows(0).Item("IdModoPlastic")
            'ChPlasticLevel1.Checked = TablaParametros.Rows(0).Item("CheckPlasticLevel1")
            'ChPlasticLevel2.Checked = TablaParametros.Rows(0).Item("CheckPlasticLevel2")
        End If
    End Sub
End Class