Public Class Clasificacion_para_Venta
    Private origenView As DataView
    Private dtorigen As DataTable
    Private Const RegistrosPorCarga = 50
    Private registrosCargadosOrigen As Integer = 0
    Private ordenAscendenteorigen As Boolean = True
    Private Sub Clasificacion_para_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargacombos()
        dtorigen = New DataTable()
        formatodatatable(dtorigen)
        origenView = New DataView(dtorigen)
        configuradgvorigen(dataGridViewOrigen)
    End Sub
    Private Sub cargacombos()
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
        CbPlanta.SelectedValue = 1
        '---Clasificacion--
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        CbClases.DataSource = Tabla2
        CbClases.ValueMember = "IdClasificacion"
        CbClases.DisplayMember = "ClaveCorta"
        CbClases.SelectedValue = 0
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("IdEstatus")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("IdEstatus") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("IdEstatus") = "2"
        dr("Descripcion") = "Inactivo"
        dt.Rows.Add(dr)
        cbestatus.DataSource = dt
        cbestatus.ValueMember = "IdEstatus"
        cbestatus.DisplayMember = "Descripcion"
        cbestatus.SelectedValue = 1
    End Sub
    Private Sub btconsultaclientes_Click(sender As Object, e As EventArgs) Handles btconsultaclientes.Click
        Dim _ConsultaProductorContratoVentas As New FConsultaProductorContratoVenta
        _ConsultaProductorContratoVentas.ShowDialog()
        'Nuevo()
        Try
            If _ConsultaProductorContratoVentas._id > 0 Then
                'limpiar()
                TbIdProductor.Text = _ConsultaProductorContratoVentas._id
                TbNombreProductor.Text = _ConsultaProductorContratoVentas._nombre
                'consultadatosComprador()
                'cargadatagrid()
                'gbcontratos.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'ConsultarDatosVenta()
        'gbcontratos.Enabled = True
    End Sub
    Private Sub formatodatatable(dt As DataTable)
        dt.Columns.Add("Seleccionar", GetType(Boolean))
        dt.Columns.Add("idproducciondetalle", GetType(Integer))
        dt.Columns.Add("idordentrabajo", GetType(Integer))
        dt.Columns.Add("idplantaorigen", GetType(Integer))
        dt.Columns.Add("idpaqueteencabezado", GetType(Integer))
        dt.Columns.Add("idVentaenc", GetType(Integer))
        dt.Columns.Add("lotid", GetType(Integer))
        dt.Columns.Add("baleid", GetType(Long))
        dt.Columns.Add("BaleGroup", GetType(String))
        dt.Columns.Add("Operator", GetType(String))
        dt.Columns.Add("date", GetType(DateTime))
        dt.Columns.Add("Temperature", GetType(Decimal))
        dt.Columns.Add("Humidity", GetType(Decimal))
        dt.Columns.Add("Amount", GetType(Integer))
        dt.Columns.Add("uhml", GetType(Decimal))
        dt.Columns.Add("ui", GetType(Decimal))
        dt.Columns.Add("strength", GetType(Decimal))
        dt.Columns.Add("elongation", GetType(Decimal))
        dt.Columns.Add("sfi", GetType(Decimal))
        dt.Columns.Add("Maturity", GetType(Decimal))
        dt.Columns.Add("grade", GetType(String))
        dt.Columns.Add("moist", GetType(Decimal))
        dt.Columns.Add("mic", GetType(Decimal))
        dt.Columns.Add("rd", GetType(Decimal))
        dt.Columns.Add("plusb", GetType(Decimal))
        dt.Columns.Add("colorgrade", GetType(String))
        dt.Columns.Add("trashcount", GetType(Integer))
        dt.Columns.Add("trasharea", GetType(Decimal))
        dt.Columns.Add("trashid", GetType(Integer))
        dt.Columns.Add("sci", GetType(Integer))
        dt.Columns.Add("Nep", GetType(Integer))
        dt.Columns.Add("UV", GetType(Integer))
        dt.Columns.Add("Flagterminadocompra", GetType(Boolean))
        dt.Columns.Add("Flagterminadoventa", GetType(Boolean))
        dt.Columns.Add("EstatusVenta", GetType(Integer))
    End Sub

    Private Sub configuradgvorigen(ByVal dgv As DataGridView)

        dgv.VirtualMode = True

        ' Definir columnas en un arreglo clásico (compatibilidad con todas las versiones)
        Dim columnas() As Object = {
        New With {.Name = "Seleccionar", .Header = "Sel", .Visible = True, .ReadOnly = False, .Tipo = "CheckBox"},
        New With {.Name = "idproducciondetalle", .Header = "Id Producción Detalle", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "idordentrabajo", .Header = "Id Orden Trabajo", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "idplantaorigen", .Header = "Id Planta Origen", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "idpaqueteencabezado", .Header = "Id Paquete Encabezado", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "idVentaenc", .Header = "Id Venta Encabezado", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "lotid", .Header = "LotID", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "baleid", .Header = "Bale ID", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "BaleGroup", .Header = "Group Bale", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "Operator", .Header = "Operador", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "date", .Header = "date", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "Temperature", .Header = "Temperatura", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "Humidity", .Header = "Humedad", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "Amount", .Header = "Cantidad", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "uhml", .Header = "UHML", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "ui", .Header = "UI", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "strength", .Header = "Strength", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "elongation", .Header = "Elongación", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "sfi", .Header = "SFI", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "Maturity", .Header = "Madurez", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "grade", .Header = "Grade", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "moist", .Header = "Humedad (%)", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "mic", .Header = "Mic", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "rd", .Header = "RD", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "plusb", .Header = "PlusB", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "colorgrade", .Header = "Color Grade", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "trashcount", .Header = "Trash Count", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "trasharea", .Header = "Trash Area", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "trashid", .Header = "Trash Id", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "sci", .Header = "SCI", .Visible = True, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "Nep", .Header = "Nep", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "UV", .Header = "UV", .Visible = False, .ReadOnly = True, .Tipo = "Text"},
        New With {.Name = "Flagterminadocompra", .Header = "Terminado Compra", .Visible = False, .ReadOnly = True, .Tipo = "CheckBox"},
        New With {.Name = "Flagterminadoventa", .Header = "Terminado Venta", .Visible = False, .ReadOnly = True, .Tipo = "CheckBox"},
        New With {.Name = "EstatusVenta", .Header = "Estatus Venta", .Visible = False, .ReadOnly = True, .Tipo = "Text"}
    }

        ' Crear y agregar columnas
        For Each col In columnas
            Dim nuevaCol As DataGridViewColumn

            If col.Tipo = "CheckBox" Then
                nuevaCol = New DataGridViewCheckBoxColumn()
            Else
                nuevaCol = New DataGridViewTextBoxColumn()
            End If

            nuevaCol.Name = col.Name
            nuevaCol.HeaderText = col.Header
            nuevaCol.Visible = col.Visible
            nuevaCol.ReadOnly = col.ReadOnly

            dgv.Columns.Add(nuevaCol)
        Next
    End Sub

    Private Sub consultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles consultarToolStripMenuItem.Click
        Dim _consulta As New ConsultaPaqueteVenta
        _consulta.ShowDialog()
        Dim id As New Integer
        id = _consulta.idpaquete_
        If id > 0 Then
            limpiar()
            TbIdPaquete.Text = id
            If TbIdPaquete.Text <> "" Then
                If dataGridViewOrigen.Rows.Count > 0 Then
                    Dim opc As DialogResult = MsgBox("¿Desea guardar el paquete actual?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar")
                    If opc = DialogResult.Yes Then
                        'Guardar()
                        TbIdPaquete.Enabled = False
                        cargapacaspaquete()
                        TbNoPaca.Text = ""
                        TbNoPaca.Focus()
                    ElseIf opc = DialogResult.No Then
                        TbIdPaquete.Enabled = False
                        cargapacaspaquete()
                        TbNoPaca.Text = ""
                        TbNoPaca.Focus()
                    End If
                Else
                    TbIdPaquete.Enabled = False
                    tbpaquete.Text = _consulta.lotid_
                    CbPlanta.SelectedValue = _consulta.idplanta_
                    TbIdProductor.Text = _consulta.idcomprador_
                    TbNombreProductor.Text = _consulta.nombre_
                    CbClases.SelectedValue = _consulta.idclase_
                    nuNoPacas.Value = _consulta.cantidapacas_
                    cbestatus.SelectedValue = _consulta.idestatus_
                    DtFechaVenta.Value = _consulta.fechacreacion_
                    DtFechaActualizacion.Value = _consulta.fechaactualizacion_
                    cargapacaspaquete()
                    TbNoPaca.Text = ""
                    TbNoPaca.Focus()
                End If
            Else
                MsgBox("Ingrese el ID del paquete...")
                Exit Sub
            End If
        End If
    End Sub
    Private Sub Consultar()
        dataGridViewOrigen.Rows.Clear()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        If TbIdPaquete.Text <> "" Then
            EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaDetallada
            EntidadClasificacionVentaPaquetes.IdPaquete = CInt(TbIdPaquete.Text)
            NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
            Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
            If Tabla.Rows.Count <> 0 Then
                TbIdPaquete.Text = Tabla.Rows(0).Item("IdPaquete")
                CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdPlanta")
                TbIdProductor.Text = Tabla.Rows(0).Item("IdComprador")
                TbNombreProductor.Text = Tabla.Rows(0).Item("Nombre")
                CbClases.SelectedValue = Tabla.Rows(0).Item("IdClase")
                nuNoPacas.Value = Tabla.Rows(0).Item("CantidadPacas")
                'TbDescripcion.Text = Tabla.Rows(0).Item("Descripcion")
                'TbEntrega.Text = Tabla.Rows(0).Item("Entrega")
                'chkfinalizado.Checked = Tabla.Rows(0).Item("chkrevisado")
                cbestatus.SelectedValue = Tabla.Rows(0).Item("IdEstatus")
                'EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPorId
                'EntidadClasificacionVentaPaquetes.IdPaquete = CInt(TbIdPaquete.Text)
                'NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
                'Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
                'For i As Integer = 0 To Tabla.Rows.Count - 1
                '    dataGridViewOrigen.Rows.Add(0, Tabla.Rows(i).Item("IdOrdenTrabajo"), Tabla.Rows(i).Item("IdPlantaOrigen"), Tabla.Rows(i).Item("Kilos"), Tabla.Rows(i).Item("Libras"), Tabla.Rows(i).Item("Quintales"), Tabla.Rows(i).Item("lotID"), Tabla.Rows(i).Item("BaleID"), Tabla.Rows(i).Item("BaleGroup"), Tabla.Rows(i).Item("Operator"), Tabla.Rows(i).Item("Date"), Tabla.Rows(i).Item("Temperature"), Tabla.Rows(i).Item("Humidity"), Tabla.Rows(i).Item("Amount"), Tabla.Rows(i).Item("UHML"), Tabla.Rows(i).Item("UI"), Tabla.Rows(i).Item("Strength"), Tabla.Rows(i).Item("Elongation"), Tabla.Rows(i).Item("SFI"), Tabla.Rows(i).Item("Maturity"), Tabla.Rows(i).Item("Grade"), Tabla.Rows(i).Item("Moist"), Tabla.Rows(i).Item("Mic"), Tabla.Rows(i).Item("Rd"), Tabla.Rows(i).Item("Plusb"), Tabla.Rows(i).Item("ColorGrade"), Tabla.Rows(i).Item("TrashCount"), Tabla.Rows(i).Item("TrashArea"), Tabla.Rows(i).Item("TrashID"), Tabla.Rows(i).Item("SCI"), Tabla.Rows(i).Item("Nep"), Tabla.Rows(i).Item("UV"), Tabla.Rows(i).Item("FlagTerminado"), Tabla.Rows(i).Item("EstatusVenta"), Tabla.Rows(i).Item("IdVentaEnc"))
                'Next
            Else
                MsgBox("No se encontraron registros con esos criterios.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                TbIdPaquete.Enabled = True
                TbIdPaquete.Text = ""
            End If
            'GeneraPromedioUI()
        Else
            MsgBox("Por favor, verificar que los datos esten correctos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        End If
        'dataGridViewOrigen.Sort(dataGridViewOrigen.Columns("BaleID"), System.ComponentModel.ListSortDirection.Descending)
        'ContarPacas()
        'IdentificaEstatusPacas()
    End Sub
    Private Sub cargapacaspaquete()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPorId
        EntidadClasificacionVentaPaquetes.IdPaquete = CInt(TbIdPaquete.Text)
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        dtorigen = EntidadClasificacionVentaPaquetes.TablaConsulta
        If dtorigen.Rows.Count > 0 Then
            origenView = New DataView(dtorigen)

            AddHandler dataGridViewOrigen.CellValueNeeded, AddressOf dataGridViewOrigen_CellValueNeeded
            AddHandler dataGridViewOrigen.CellValuePushed, AddressOf dataGridViewOrigen_CellValuePushed

            If registrosCargadosOrigen <= origenView.Count Then
                Dim nuevasFilas As Integer = Math.Min(RegistrosPorCarga, origenView.Count - registrosCargadosOrigen)
                registrosCargadosOrigen += nuevasFilas
                dataGridViewOrigen.RowCount += nuevasFilas
            End If
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

    Private Sub tbpaquete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbpaquete.KeyPress, TbNoPaca.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TbNoPaca_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNoPaca.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Try
                    InsertaPaca(TbNoPaca.Text)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
        End Select
    End Sub
    Private Sub InsertaPaca(ByVal NoPaca As Long)
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes

        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPaca
        EntidadClasificacionVentaPaquetes.NumeroPaca = NoPaca
        EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        EntidadClasificacionVentaPaquetes.IdPaquete = CInt(IIf(TbIdPaquete.Text = "", 0, TbIdPaquete.Text))
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)

        Dim dtresultado As DataTable = EntidadClasificacionVentaPaquetes.TablaConsulta

        If dtresultado.Rows.Count > 0 Then
            For Each fila As DataRow In dtresultado.Rows
                Dim baleid As Long = CLng(fila("baleid"))

                Dim existe() As DataRow = dtorigen.Select("baleid = " & baleid)
                If existe.Length = 0 Then
                    dtorigen.ImportRow(fila)
                End If
            Next
            origenView = New DataView(dtorigen)
            registrosCargadosOrigen = origenView.Count
            dataGridViewOrigen.RowCount = registrosCargadosOrigen
            dataGridViewOrigen.Refresh()
            nuNoPacas.Value = dtorigen.Rows.Count
        End If
        TbNoPaca.SelectAll()
    End Sub

    Private Sub guardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles guardarToolStripMenuItem.Click
        Try
            If TbIdProductor.Text <> "" Then
                guardarenc()
                guardardet()
                MessageBox.Show("Paquete guardado con exito.", "Paquete Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub guardarenc()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Guarda = Guardar.GuardarPqtclaenc
        EntidadClasificacionVentaPaquetes.IdPaquete = TbIdPaquete.Text
        EntidadClasificacionVentaPaquetes.LotID = 0
        EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        EntidadClasificacionVentaPaquetes.IdComprador = TbIdProductor.Text
        EntidadClasificacionVentaPaquetes.IdClase = CbClases.SelectedValue
        EntidadClasificacionVentaPaquetes.CantidadPacas = nuNoPacas.Value
        EntidadClasificacionVentaPaquetes.Descripcion = ""
        EntidadClasificacionVentaPaquetes.Entrega = ""
        EntidadClasificacionVentaPaquetes.chkrevisado = False
        EntidadClasificacionVentaPaquetes.IdEstatus = cbestatus.SelectedValue
        EntidadClasificacionVentaPaquetes.IdUsuarioCreacion = 1
        EntidadClasificacionVentaPaquetes.FechaCreacion = Now
        EntidadClasificacionVentaPaquetes.IdUsuarioActualizacion = 1
        EntidadClasificacionVentaPaquetes.FechaActualizacion = Now
        NegocioClasificacionVentaPaquetes.Guardar(EntidadClasificacionVentaPaquetes)
        TbIdPaquete.Text = EntidadClasificacionVentaPaquetes.IdPaquete
    End Sub
    Private Sub guardardet()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        For Each fila As DataRow In dtorigen.Rows
            EntidadClasificacionVentaPaquetes.Guarda = Guardar.GuardarPqtcladet
            EntidadClasificacionVentaPaquetes.idproducciondetalle = fila("idproducciondetalle")
            EntidadClasificacionVentaPaquetes.IdPaquete = TbIdPaquete.Text
            'EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
            NegocioClasificacionVentaPaquetes.Guardar(EntidadClasificacionVentaPaquetes)
            fila("idpaqueteencabezado") = TbIdPaquete.Text
        Next
    End Sub
    Private Sub limpiar()
        TbIdPaquete.Text = ""
        CbPlanta.SelectedValue = 0
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        CbClases.SelectedValue = 0
        nuNoPacas.Value = 0
        cbestatus.SelectedValue = 0
        TbNoPaca.Text = ""
        dtorigen.Clear()
        registrosCargadosOrigen = 0
        dataGridViewOrigen.RowCount = Math.Min(If(registrosCargadosOrigen = 0, RegistrosPorCarga, registrosCargadosOrigen), origenView.Count)
        dataGridViewOrigen.Refresh()
    End Sub
    Private Sub nuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles nuevoToolStripMenuItem.Click
        limpiar()
    End Sub
End Class
