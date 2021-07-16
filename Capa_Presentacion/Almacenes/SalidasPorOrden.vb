Imports Capa_Operacion.Configuracion
Public Class SalidasPorOrden
    Private Sub SalidasPorOrden_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboEstatus()
    End Sub
    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub limpiar()
        TbIdSalida.Clear()
        TbIdEmbarque.Clear()
        TbIdComprador.Clear()
        TbNombreComprador.Clear()
        TbNombreChofer.Clear()
        TbTelefono.Clear()
        TbPlacaTractoCamion.Clear()
        TbFolioSalida.Clear()
        TbNoFactura.Clear()
        TbNoLicencia.Clear()
        TbDestino.Clear()
        TbNoLote.Clear()
        TbNoPacas.Clear()
        TbNoContenedor.Clear()
        TbPlacaCaja.Clear()
        TbObservaciones.Clear()
        TbTara.Clear()
        TbNeto.Clear()
        TbBruto.Clear()
        TbPacasDisponibles.Clear()
        TbPacasMarcadas.Clear()
        TbPacasLoteadas.Clear()
        TbPacasMarcadasLotes.Clear()
        CbLotesDisponible.Text = ""
        CbLotesSeleccionadas.Text = ""
        DtpFechaEntrada.Value = Now
        DtFechaSalida.Value = Now
        DgvOrdenes.DataSource = ""
        DgvOrdenesDetalle.DataSource = ""
        DgvSalidas.DataSource = ""
        DgvSalidaPacas.DataSource = ""
        ComboEstatus()
        CbAcuenta.SelectedValue = 0
        GbDatos.Enabled = False
        GroupBox1.Enabled = False
        Panel3.Enabled = False
    End Sub
    Private Sub ComboEstatus()
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("IdEstatus")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("IdEstatus") = "0"
        dr("Descripcion") = "SIN EMBARQUE"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("IdEstatus") = "1"
        dr("Descripcion") = "EMBARCADO"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "IdEstatus"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedIndex = -1
    End Sub
    Private Sub CargaComboAcuentaDE()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            Dim tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaComboCompradoresAcuenta
            EntidadOrdenEmbarquePacas.IdComprador = Val(TbIdComprador.Text)
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            tabla = EntidadOrdenEmbarquePacas.TablaConsulta
            CbAcuenta.DataSource = tabla
            CbAcuenta.ValueMember = "idcomprador"
            CbAcuenta.DisplayMember = "Nombre"
            CbAcuenta.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BtnBuscarEmbarque_Click(sender As Object, e As EventArgs) Handles BtnBuscarEmbarque.Click
        'Nuevo()
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Dim Tabla As New DataTable
        ConsultaOrdenEmbarqueSalidas.ShowDialog()
        If ConsultaOrdenEmbarqueSalidas.Id = 0 Then
            Exit Sub
        End If
        EntidadSalidaPacas.Consulta = Consulta.ConsultaEmbarqueParaSalidaSinSelecionar
        EntidadSalidaPacas.IdEmbarqueEncabezado = ConsultaOrdenEmbarqueSalidas.Id
        EntidadSalidaPacas.NombreComprador = ConsultaOrdenEmbarqueSalidas.NombreComprador
        EntidadSalidaPacas.NoLoteInd = ConsultaOrdenEmbarqueSalidas.NoLote
        'EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaEmbarqueEncabezado
        NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
        Tabla = EntidadSalidaPacas.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            TbIdEmbarque.Text = Tabla.Rows(0).Item("IdEmbarqueEncabezado")
            TbIdComprador.Text = Tabla.Rows(0).Item("IdComprador")
            TbNombreComprador.Text = Tabla.Rows(0).Item("Nombre")
            TbNombreChofer.Text = Tabla.Rows(0).Item("NombreChofer")
            TbPlacaTractoCamion.Text = Tabla.Rows(0).Item("PlacaTractoCamion")
            TbNoLicencia.Text = Tabla.Rows(0).Item("NoLicencia")
            TbTelefono.Text = Tabla.Rows(0).Item("Telefono")
            TbNoContenedor.Text = Tabla.Rows(0).Item("NoContenedor")
            TbPlacaCaja.Text = Tabla.Rows(0).Item("PlacaCaja")
            TbNoLote.Text = Tabla.Rows(0).Item("NoLote")
            'DtpFechaEntrada.Value = Tabla.Rows(0).Item("Fecha")
            'TbObservaciones.Text = Tabla.Rows(0).Item("Observaciones")
            'If Tabla.Rows(0).Item("CantidadCajas") = 1 Then
            '    CargaCombo(Tabla.Rows(0).Item("CantidadCajas"), Tabla.Rows(0).Item("NoLote1"))
            'ElseIf Tabla.Rows(0).Item("CantidadCajas") = 2 Then
            '    CargaCombo(Tabla.Rows(0).Item("CantidadCajas"), Tabla.Rows(0).Item("NoLote1"), Tabla.Rows(0).Item("NoLote2"))
            'End If
            'ConsultarPacas(TbIdEmbarque.Text, TbNoLote.Text)
            'TbNoPacas.Text = DgvPacas.RowCount

            CargaPaquetesDisponibles()
            CargaPacasDisponibles()
            ConsultaCombo()
            CargaComboAcuentaDE()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'GeneraRegistroBitacora(Me.Text.Clone.ToString, ConsultarToolStripMenuItem.Text, TbIdEmbarque.Text, TbNombreComprador.Text)
        End Try
    End Sub


    Private Sub ConsultarEmbarque()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Dim Tabla As New DataTable
        ConsultaOrdenEmbarqueEncabezado.ShowDialog()
        If ConsultaOrdenEmbarque.Id = 0 Then
            Exit Sub
        End If
        EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaEmbarqueEncabezado
        EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = ConsultaOrdenEmbarque.Id
        EntidadOrdenEmbarquePacas.NombreComprador = ""
        NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
        Tabla = EntidadOrdenEmbarquePacas.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            limpiar()
            TbIdEmbarque.Text = Tabla.Rows(0).Item("IdEmbarqueEncabezado")
            TbIdComprador.Text = Tabla.Rows(0).Item("IdComprador")
            TbNombreComprador.Text = Tabla.Rows(0).Item("Nombre")
            'TbNombreChofer.Text = Tabla.Rows(0).Item("NombreChofer")
            'TbPlacaTractoCamion.Text = Tabla.Rows(0).Item("PlacaTractoCamion")
            'TbNoLicencia.Text = Tabla.Rows(0).Item("NoLicencia")
            'TbNoLote1.Text = Tabla.Rows(0).Item("NoLote1")
            'TbNoLote2.Text = Tabla.Rows(0).Item("NoLote2")
            'TbTelefono.Text = Tabla.Rows(0).Item("Telefono")
            'RbCaja1.Checked = IIf(Tabla.Rows(0).Item("CantidadCajas") = 1, True, False)
            'RbCaja2.Checked = IIf(Tabla.Rows(0).Item("CantidadCajas") = 2, True, False)
            'TbNoContenedor1.Text = Tabla.Rows(0).Item("NoContenedorCaja1")
            'TbPlacaCaja1.Text = Tabla.Rows(0).Item("PlacaCaja1")
            'TbNoContenedor2.Text = Tabla.Rows(0).Item("NoContenedorCaja2")
            'TbPlacaCaja2.Text = Tabla.Rows(0).Item("PlacaCaja2")
            TbNoPacas.Text = Tabla.Rows(0).Item("CantidadPacas")
            DtpFechaEntrada.Value = Tabla.Rows(0).Item("Fecha")
            TbObservaciones.Text = Tabla.Rows(0).Item("Observaciones")
            CargaPaquetesDisponibles()
            CargaPacasDisponibles()
            'ConsultarPaqueteEmbarcado()
            'ConsultarPacasEmbarcadas()
            'GbProceso.Enabled = True
            TbPacasDisponibles.Text = DgvOrdenesDetalle.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'GeneraRegistroBitacora(Me.Text.Clone.ToString, ConsultarToolStripMenuItem.Text, TbIdEmbarque.Text, TbNombreComprador.Text)
        End Try
    End Sub
    Private Sub CargaPaquetesDisponibles()
        Try
            Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
            Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
            Dim Tabla As New DataTable
            EntidadSalidaPacas.Consulta = Consulta.ConsultaPaqueteDisponibleSalida
            EntidadSalidaPacas.IdEmbarqueEncabezado = Val(TbIdEmbarque.Text)
            NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
            DgvOrdenes.DataSource = EntidadSalidaPacas.TablaConsulta
            'propiedadesPaqueteDisponible(DgvOrdenes)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargaPacasDisponibles()
        Try
            Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
            Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
            Dim Tabla As New DataTable
            EntidadSalidaPacas.Consulta = Consulta.ConsultaPacasDisponibleSalida
            EntidadSalidaPacas.IdEmbarqueEncabezado = Val(TbIdEmbarque.Text)
            NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
            DgvOrdenesDetalle.DataSource = EntidadSalidaPacas.TablaConsulta
            'propiedadesPacasDisponible(DgvOrdenesDetalle)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        consultarSalidas()
    End Sub
    Private Sub consultarSalidas()
        Dim Consultar As New ConsultarSalidasPacas
        Consultar.ShowDialog()
        If Consultar.IdSalida > 0 Then
            TbIdSalida.Text = Consultar.IdSalida
            TbIdEmbarque.Text = Consultar.IdEmbarque
            TbIdComprador.Text = Consultar.IdComprador
            TbNombreComprador.Text = Consultar.NombreComprador
            TbNombreChofer.Text = Consultar.NombreChofer
            TbPlacaTractoCamion.Text = Consultar.PlacaTractoCamion
            TbNoLicencia.Text = Consultar.NoLicencia
            TbTelefono.Text = Consultar.Telefono
            TbBruto.Text = Consultar.PesoBruto
            TbTara.Text = Consultar.PesoTara
            TbNeto.Text = Consultar.PesoNeto
            TbDestino.Text = Consultar.Destino
            TbFolioSalida.Text = Consultar.FolioSalida
            TbNoFactura.Text = Consultar.NoFactura
            DtpFechaEntrada.Value = Consultar.FechaEntrada
            DtFechaSalida.Value = Consultar.FechaSalida
            TbObservaciones.Text = Consultar.Observaciones
            CargaComboAcuentaDE()
            CbAcuenta.SelectedValue = Consultar.IdCompradorAcuenta
            CbEstatus.SelectedValue = Consultar.EstatusSalida
            CargaPaquetesDisponibles()
            CargaPacasDisponibles()
            ConsultaCombo()
            ConsultarPacasSeleccionadas()
            ConsultarPaquetesSeleccionados()
            GbDatos.Enabled = True
            GroupBox1.Enabled = True
            Panel3.Enabled = True
        End If
    End Sub
    Private Sub ConsultarPacasSeleccionadas()
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Dim Tabla As New DataTable
        EntidadSalidaPacas.Consulta = Consulta.ConsultaPacaSalidaSeleccionado
        EntidadSalidaPacas.IdSalidaEncabezado = Val(TbIdSalida.Text)
        NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
        DgvSalidaPacas.DataSource = EntidadSalidaPacas.TablaConsulta
    End Sub
    Private Sub ConsultarPaquetesSeleccionados()
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Dim Tabla As New DataTable
        EntidadSalidaPacas.Consulta = Consulta.ConsultaPaqueteSalidaSeleccionado
        EntidadSalidaPacas.IdSalidaEncabezado = Val(TbIdSalida.Text)
        NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
        DgvSalidas.DataSource = EntidadSalidaPacas.TablaConsulta
    End Sub
    Private Sub DgvOrdenes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvOrdenes.CellContentClick
        Dim filaSeleccionada As Integer = DgvOrdenes.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvOrdenes.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvOrdenes.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvOrdenesDetalle.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub

    Private Sub DgvOrdenesDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvOrdenesDetalle.CellContentClick
        Dim filaSeleccionada As Integer = DgvOrdenesDetalle.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvOrdenesDetalle.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvOrdenesDetalle.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvOrdenes.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub

    Private Sub BtAgregarPacas_Click(sender As Object, e As EventArgs) Handles BtAgregarPacas.Click
        If DgvOrdenes.RowCount > 0 Then
            'If (Val(TbPacasMarcadas.Text) + cuentapacaslote(CbLotes.Text)) <= Val(TbCantidadPacasCombo.Text) Then
            'enviapaquetes()
            GuardarPacas()
            TbPacasLoteadas.Text = DgvSalidaPacas.RowCount
            TbPacasDisponibles.Text = DgvOrdenesDetalle.RowCount
            TbPacasMarcadas.Text = 0
            'Else
            '    MsgBox("Las pacas seleccionadas exceden la cantidad del lote " & CbLotes.Text & " " & TbCantidadPacasCombo.Text)
            'End If
        Else
            MsgBox("No hay pacas disponibles para seleccionar", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Function validaValor(Id As Long, dgv As DataGridView) As Boolean
        Dim valida As Boolean = False
        If dgv.Rows.Count > 0 Then
            For Each dgvvalida As DataGridViewRow In dgv.Rows
                If dgvvalida.Cells("IdPaqueteEncabezado").Value = Id Then
                    valida = True
                    Exit For
                End If
            Next
        End If
        Return valida
    End Function
    Private Function validapacas(id As Long, dgv As DataGridView) As Boolean
        Dim valida As Boolean = False
        If dgv.Rows.Count > 0 Then
            For Each dgvvalida As DataGridViewRow In dgv.Rows
                If dgvvalida.Cells("BaleID").Value = id Then
                    valida = True
                    Exit For
                End If
            Next
        End If
        Return valida
    End Function
    Private Function RevisaIDExiste(dtexiste As DataTable, ByVal ID As Integer) As Boolean
        Dim Existe As Boolean = False
        For Each filapaca In dtexiste.Rows
            If filapaca("IdPaqueteEncabezado") = ID Then
                Existe = True
                Exit For
            End If
        Next
        Return Existe
    End Function
    Private Sub BtQuitarPacas_Click(sender As Object, e As EventArgs) Handles BtQuitarPacas.Click
        'devolverpaquetes()
        'GuardarPacas()
        RegresarPacas()

        TbPacasLoteadas.Text = DgvSalidaPacas.RowCount
        TbPacasMarcadasLotes.Text = 0
        TbPacasDisponibles.Text = DgvOrdenesDetalle.RowCount
    End Sub
    Private Sub BtExcel_Click(sender As Object, e As EventArgs) Handles BtExcel.Click
        CargaExcel.ShowDialog()
        Try
            If TablaExcel.Rows.Count > 0 Then
                For Each rowTabla As DataRow In TablaExcel.Rows
                    For Each rowGrid As DataGridViewRow In DgvOrdenesDetalle.Rows
                        If rowTabla.Item(0) = rowGrid.Cells("BaleID").Value.ToString Then
                            rowGrid.Cells("Seleccionar").Value = True
                        End If
                    Next
                Next
            End If
            If TablaExcel.Rows.Count > 0 Then TablaExcel.Clear()
            MarcaSeleccionDisponibles()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub enviapaquetes()
        Dim dtpacasDisponibles As New DataTable
        Dim dtpaqueteDisponible As New DataTable
        Dim dtpacasRecibidas As New DataTable
        Dim dtpaqueteRecibido As New DataTable

        Dim dtPacasOrigen As New DataTable
        dtPacasOrigen.Columns.Add("IdPaqueteEncabezado")
        dtPacasOrigen.Columns.Add("IdVentaEnc")
        dtPacasOrigen.Columns.Add("IdPlantaOrigen")
        dtPacasOrigen.Columns.Add("BaleID")
        dtPacasOrigen.Columns.Add("NoLote")
        dtPacasOrigen.Columns.Add("Descripcion")
        dtPacasOrigen.Columns.Add("Kilos")
        dtPacasOrigen.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

        Dim dtPaqueteOrigen As New DataTable
        dtPaqueteOrigen.Columns.Add("IdPaqueteEncabezado")
        dtPaqueteOrigen.Columns.Add("Cantidad")
        dtPaqueteOrigen.Columns.Add("Kilos")
        dtPaqueteOrigen.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

        Dim dtPacasDestino As New DataTable
        dtPacasDestino.Columns.Add("IdPaqueteEncabezado")
        dtPacasDestino.Columns.Add("IdVentaEnc")
        dtPacasDestino.Columns.Add("IdPlantaOrigen")
        dtPacasDestino.Columns.Add("BaleID")
        dtPacasDestino.Columns.Add("NoLote")
        dtPacasDestino.Columns.Add("Descripcion")
        dtPacasDestino.Columns.Add("Kilos")
        dtPacasDestino.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

        Dim dtPaqueteDestino As New DataTable
        dtPaqueteDestino.Columns.Add("IdPaqueteEncabezado")
        dtPaqueteDestino.Columns.Add("Cantidad")
        dtPaqueteDestino.Columns.Add("Kilos")
        dtPaqueteDestino.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

        If DgvOrdenes.Columns.Count > 0 Then
            dtpacasDisponibles = TryCast(DgvOrdenesDetalle.DataSource, DataTable)
            dtpaqueteDisponible = TryCast(DgvOrdenes.DataSource, DataTable)
        Else
            dtpaqueteDisponible.Columns.Add("IdPaqueteEncabezado")
            dtpaqueteDisponible.Columns.Add("Cantidad")
            dtpaqueteDisponible.Columns.Add("Kilos")
            dtpaqueteDisponible.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

            dtpacasDisponibles.Columns.Add("IdPaqueteEncabezado")
            dtpacasDisponibles.Columns.Add("IdVentaEnc")
            dtpacasDisponibles.Columns.Add("IdPlantaOrigen")
            dtpacasDisponibles.Columns.Add("BaleID")
            dtpacasDisponibles.Columns.Add("NoLote")
            dtpacasDisponibles.Columns.Add("Descripcion")
            dtpacasDisponibles.Columns.Add("Kilos")
            dtpacasDisponibles.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))
        End If
        If DgvSalidas.Columns.Count > 0 Then
            dtpacasRecibidas = TryCast(DgvSalidaPacas.DataSource, DataTable)
            dtpaqueteRecibido = TryCast(DgvSalidas.DataSource, DataTable)
        Else
            dtpaqueteRecibido.Columns.Add("IdPaqueteEncabezado")
            dtpaqueteRecibido.Columns.Add("Cantidad")
            dtpaqueteRecibido.Columns.Add("Kilos")
            dtpaqueteRecibido.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

            dtpacasRecibidas.Columns.Add("IdPaqueteEncabezado")
            dtpacasRecibidas.Columns.Add("IdVentaEnc")
            dtpacasRecibidas.Columns.Add("IdPlantaOrigen")
            dtpacasRecibidas.Columns.Add("BaleID")
            dtpacasRecibidas.Columns.Add("NoLote")
            dtpacasRecibidas.Columns.Add("Descripcion")
            dtpacasRecibidas.Columns.Add("Kilos")
            dtpacasRecibidas.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))
        End If

        For Each filapacas In dtpacasDisponibles.Rows
            If filapacas("Seleccionar") = True And validapacas(filapacas("Baleid"), DgvSalidaPacas) = False Then
                Dim Renglon As DataRow = dtPacasDestino.NewRow()
                Renglon("IdPaqueteEncabezado") = filapacas("IdPaqueteEncabezado")
                Renglon("IdVentaEnc") = filapacas("IdVentaEnc")
                Renglon("IdPlantaOrigen") = filapacas("IdPlantaOrigen")
                Renglon("BaleID") = filapacas("BaleID")
                Renglon("NoLote") = filapacas("NoLote")
                Renglon("Descripcion") = filapacas("Descripcion")
                Renglon("Kilos") = filapacas("Kilos")
                Renglon("Seleccionar") = False
                dtPacasDestino.Rows.Add(Renglon)
            Else
                Dim Renglon As DataRow = dtPacasOrigen.NewRow()
                Renglon("IdPaqueteEncabezado") = filapacas("IdPaqueteEncabezado")
                Renglon("IdVentaEnc") = filapacas("IdVentaEnc")
                Renglon("IdPlantaOrigen") = filapacas("IdPlantaOrigen")
                Renglon("BaleID") = filapacas("BaleID")
                Renglon("NoLote") = filapacas("NoLote")
                Renglon("Descripcion") = filapacas("Descripcion")
                Renglon("Kilos") = filapacas("Kilos")
                Renglon("Seleccionar") = False
                dtPacasOrigen.Rows.Add(Renglon)
            End If
        Next

        For Each filapaquetes In dtpaqueteDisponible.Rows
            If filapaquetes("Seleccionar") = True And RevisaIDExiste(dtPacasOrigen, filapaquetes("IdPaqueteEncabezado")) = True Then
                Dim Renglon1 As DataRow = dtPaqueteDestino.NewRow()
                Renglon1("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon1("Cantidad") = filapaquetes("Cantidad")
                Renglon1("Kilos") = filapaquetes("Kilos")
                Renglon1("Seleccionar") = False
                dtPaqueteDestino.Rows.Add(Renglon1)

                Dim Renglon2 As DataRow = dtPaqueteOrigen.NewRow()
                Renglon2("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon2("Cantidad") = filapaquetes("Cantidad")
                Renglon2("Kilos") = filapaquetes("Kilos")
                Renglon2("Seleccionar") = False
                dtPaqueteOrigen.Rows.Add(Renglon2)

            ElseIf filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado"), DgvSalidas) = False Then
                Dim Renglon As DataRow = dtPaqueteDestino.NewRow()
                Renglon("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon("Cantidad") = filapaquetes("Cantidad")
                Renglon("Kilos") = filapaquetes("Kilos")
                Renglon("Seleccionar") = False
                dtPaqueteDestino.Rows.Add(Renglon)
            ElseIf filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado"), DgvOrdenes) = True Then
            Else
                Dim Renglon As DataRow = dtPaqueteOrigen.NewRow()
                Renglon("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon("Cantidad") = filapaquetes("Cantidad")
                Renglon("Kilos") = filapaquetes("Kilos")
                Renglon("Seleccionar") = False
                dtPaqueteOrigen.Rows.Add(Renglon)
            End If
        Next

        If dtpacasRecibidas.Rows.Count > 0 Then
            For Each filapacas In dtpacasRecibidas.Rows
                'If filapacas("Seleccionar") = True And validapacas(filapacas("Baleid")) = False Then
                Dim Renglon As DataRow = dtPacasDestino.NewRow()
                Renglon("IdPaqueteEncabezado") = filapacas("IdPaqueteEncabezado")
                Renglon("IdVentaEnc") = filapacas("IdVentaEnc")
                Renglon("IdPlantaOrigen") = filapacas("IdPlantaOrigen")
                Renglon("BaleID") = filapacas("BaleID")
                Renglon("NoLote") = filapacas("NoLote")
                Renglon("Descripcion") = filapacas("Descripcion")
                Renglon("Kilos") = filapacas("Kilos")
                Renglon("Seleccionar") = False
                dtPacasDestino.Rows.Add(Renglon)
                'End If
            Next
            DgvSalidaPacas.DataSource = dtPacasDestino
        Else
            DgvSalidaPacas.DataSource = dtPacasDestino
        End If

        If dtpaqueteRecibido.Rows.Count > 0 Then
            For Each filapaquetes In dtpaqueteRecibido.Rows
                'If filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado")) = False Then
                Dim Renglon As DataRow = dtPaqueteDestino.NewRow()
                Renglon("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon("Cantidad") = filapaquetes("Cantidad")
                Renglon("Kilos") = filapaquetes("Kilos")
                Renglon("Seleccionar") = False
                dtPaqueteDestino.Rows.Add(Renglon)
                'End If
                DgvSalidas.DataSource = dtPaqueteDestino
            Next
        Else
            DgvSalidas.DataSource = dtPaqueteDestino
        End If

        DgvOrdenes.DataSource = dtPaqueteOrigen
        DgvOrdenesDetalle.DataSource = dtPacasOrigen
        propiedadesPacasDisponible(DgvOrdenesDetalle)
        propiedadesPaqueteDisponible(DgvOrdenes)
    End Sub
    Private Sub devolverpaquetes()
        Dim dtpacasDisponibles As New DataTable
        Dim dtpaqueteDisponible As New DataTable
        Dim dtpacasRecibidas As New DataTable
        Dim dtpaqueteRecibido As New DataTable

        Dim dtPacasOrigen As New DataTable
        dtPacasOrigen.Columns.Add("IdPaqueteEncabezado")
        dtPacasOrigen.Columns.Add("IdVentaEnc")
        dtPacasOrigen.Columns.Add("IdPlantaOrigen")
        dtPacasOrigen.Columns.Add("BaleID")
        dtPacasOrigen.Columns.Add("NoLote")
        dtPacasOrigen.Columns.Add("Descripcion")
        dtPacasOrigen.Columns.Add("Kilos")
        dtPacasOrigen.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

        Dim dtPaqueteOrigen As New DataTable
        dtPaqueteOrigen.Columns.Add("IdPaqueteEncabezado")
        dtPaqueteOrigen.Columns.Add("Cantidad")
        dtPaqueteOrigen.Columns.Add("Kilos")
        dtPaqueteOrigen.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

        Dim dtPacasDestino As New DataTable
        dtPacasDestino.Columns.Add("IdPaqueteEncabezado")
        dtPacasDestino.Columns.Add("IdVentaEnc")
        dtPacasDestino.Columns.Add("IdPlantaOrigen")
        dtPacasDestino.Columns.Add("BaleID")
        dtPacasDestino.Columns.Add("NoLote")
        dtPacasDestino.Columns.Add("Descripcion")
        dtPacasDestino.Columns.Add("Kilos")
        dtPacasDestino.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

        Dim dtPaqueteDestino As New DataTable
        dtPaqueteDestino.Columns.Add("IdPaqueteEncabezado")
        dtPaqueteDestino.Columns.Add("Cantidad")
        dtPaqueteDestino.Columns.Add("Kilos")
        dtPaqueteDestino.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

        If DgvOrdenes.Columns.Count > 0 Then
            dtpacasDisponibles = TryCast(DgvOrdenesDetalle.DataSource, DataTable)
            dtpaqueteDisponible = TryCast(DgvOrdenes.DataSource, DataTable)
        Else
            dtpaqueteDisponible.Columns.Add("IdPaqueteEncabezado")
            dtpaqueteDisponible.Columns.Add("Cantidad")
            dtpaqueteDisponible.Columns.Add("Kilos")
            dtpaqueteDisponible.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

            dtpacasDisponibles.Columns.Add("IdPaqueteEncabezado")
            dtpacasDisponibles.Columns.Add("IdVentaEnc")
            dtpacasDisponibles.Columns.Add("IdPlantaOrigen")
            dtpacasDisponibles.Columns.Add("BaleID")
            dtpacasDisponibles.Columns.Add("NoLote")
            dtpacasDisponibles.Columns.Add("Descripcion")
            dtpacasDisponibles.Columns.Add("Kilos")
            dtpacasDisponibles.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))
        End If
        If DgvSalidas.Columns.Count > 0 Then
            dtpacasRecibidas = TryCast(DgvSalidaPacas.DataSource, DataTable)
            dtpaqueteRecibido = TryCast(DgvSalidas.DataSource, DataTable)
        Else
            dtpaqueteRecibido.Columns.Add("IdPaqueteEncabezado")
            dtpaqueteRecibido.Columns.Add("Cantidad")
            dtpaqueteRecibido.Columns.Add("Kilos")
            dtpaqueteRecibido.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

            dtpacasRecibidas.Columns.Add("IdPaqueteEncabezado")
            dtpacasRecibidas.Columns.Add("IdVentaEnc")
            dtpacasRecibidas.Columns.Add("IdPlantaOrigen")
            dtpacasRecibidas.Columns.Add("BaleID")
            dtpacasRecibidas.Columns.Add("NoLote")
            dtpacasRecibidas.Columns.Add("Descripcion")
            dtpacasRecibidas.Columns.Add("Kilos")
            dtpacasRecibidas.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))
        End If

        For Each filapacas In dtpacasRecibidas.Rows
            If filapacas("Seleccionar") = True And validapacas(filapacas("Baleid"), DgvOrdenesDetalle) = False Then
                Dim Renglon As DataRow = dtPacasOrigen.NewRow()
                Renglon("IdPaqueteEncabezado") = filapacas("IdPaqueteEncabezado")
                Renglon("IdVentaEnc") = filapacas("IdVentaEnc")
                Renglon("IdPlantaOrigen") = filapacas("IdPlantaOrigen")
                Renglon("BaleID") = filapacas("BaleID")
                Renglon("NoLote") = filapacas("NoLote")
                Renglon("Descripcion") = filapacas("Descripcion")
                Renglon("Kilos") = filapacas("Kilos")
                Renglon("Seleccionar") = False
                dtPacasOrigen.Rows.Add(Renglon)
            Else
                Dim Renglon As DataRow = dtPacasDestino.NewRow()
                Renglon("IdPaqueteEncabezado") = filapacas("IdPaqueteEncabezado")
                Renglon("IdVentaEnc") = filapacas("IdVentaEnc")
                Renglon("IdPlantaOrigen") = filapacas("IdPlantaOrigen")
                Renglon("BaleID") = filapacas("BaleID")
                Renglon("NoLote") = filapacas("NoLote")
                Renglon("Descripcion") = filapacas("Descripcion")
                Renglon("Kilos") = filapacas("Kilos")
                Renglon("Seleccionar") = False
                dtPacasDestino.Rows.Add(Renglon)
            End If
        Next
        For Each filapaquetes In dtpaqueteRecibido.Rows
            If filapaquetes("Seleccionar") = True And RevisaIDExiste(dtPacasDestino, filapaquetes("IdPaqueteEncabezado")) = True Then
                Dim Renglon1 As DataRow = dtPaqueteOrigen.NewRow()
                Renglon1("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon1("Cantidad") = filapaquetes("Cantidad")
                Renglon1("Kilos") = filapaquetes("Kilos")
                Renglon1("Seleccionar") = False
                dtPaqueteOrigen.Rows.Add(Renglon1)

                Dim Renglon2 As DataRow = dtPaqueteDestino.NewRow()
                Renglon2("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon2("Cantidad") = filapaquetes("Cantidad")
                Renglon2("Kilos") = filapaquetes("Kilos")
                Renglon2("Seleccionar") = False
                dtPaqueteDestino.Rows.Add(Renglon2)

            ElseIf filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado"), DgvOrdenes) = False Then
                Dim Renglon As DataRow = dtPaqueteOrigen.NewRow()
                Renglon("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon("Cantidad") = filapaquetes("Cantidad")
                Renglon("Kilos") = filapaquetes("Kilos")
                Renglon("Seleccionar") = False
                dtPaqueteOrigen.Rows.Add(Renglon)
            ElseIf filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado"), DgvOrdenes) = True Then

            Else
                Dim Renglon As DataRow = dtPaqueteDestino.NewRow()
                Renglon("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon("Cantidad") = filapaquetes("Cantidad")
                Renglon("Kilos") = filapaquetes("Kilos")
                Renglon("Seleccionar") = False
                dtPaqueteDestino.Rows.Add(Renglon)
            End If
        Next

        If dtpacasDisponibles.Rows.Count > 0 Then
            For Each filapacas In dtpacasDisponibles.Rows
                'If filapacas("Seleccionar") = True And validapacas(filapacas("Baleid")) = False Then
                Dim Renglon As DataRow = dtPacasOrigen.NewRow()
                Renglon("IdPaqueteEncabezado") = filapacas("IdPaqueteEncabezado")
                Renglon("IdVentaEnc") = filapacas("IdVentaEnc")
                Renglon("IdPlantaOrigen") = filapacas("IdPlantaOrigen")
                Renglon("BaleID") = filapacas("BaleID")
                Renglon("NoLote") = filapacas("NoLote")
                Renglon("Descripcion") = filapacas("Descripcion")
                Renglon("Kilos") = filapacas("Kilos")
                Renglon("Seleccionar") = False
                dtPacasOrigen.Rows.Add(Renglon)
                'End If
            Next
            DgvOrdenesDetalle.DataSource = dtPacasOrigen
        Else
            DgvOrdenesDetalle.DataSource = dtPacasOrigen
        End If

        If dtpaqueteDisponible.Rows.Count > 0 Then
            For Each filapaquetes In dtpaqueteDisponible.Rows
                'If filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado")) = False Then
                Dim Renglon As DataRow = dtPaqueteOrigen.NewRow()
                Renglon("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon("Cantidad") = filapaquetes("Cantidad")
                Renglon("Kilos") = filapaquetes("Kilos")
                Renglon("Seleccionar") = False
                dtPaqueteOrigen.Rows.Add(Renglon)
                'End If
                DgvOrdenes.DataSource = dtPaqueteOrigen
            Next
        Else
            DgvOrdenes.DataSource = dtPaqueteOrigen
        End If

        DgvSalidas.DataSource = dtPaqueteDestino
        DgvSalidaPacas.DataSource = dtPacasDestino
        propiedadesPacasDisponible(DgvSalidaPacas)
        propiedadesPaqueteDisponible(DgvSalidas)
    End Sub

    Private Sub DgvSalidas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSalidas.CellContentClick
        Dim filaSeleccionada As Integer = DgvSalidas.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvSalidas.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvSalidas.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvSalidaPacas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccion()
    End Sub
    Private Sub propiedadesPacasDisponible(ByVal dgv As DataGridView)
        dgv.Columns("IdPaqueteEncabezado").HeaderText = "ID Paquete"
        dgv.Columns("IdPaqueteEncabezado").ReadOnly = False
        dgv.Columns("IdVentaEnc").HeaderText = "ID Venta"
        dgv.Columns("IdVentaEnc").ReadOnly = True
        dgv.Columns("IdPlantaOrigen").Visible = False
        dgv.Columns("BaleID").ReadOnly = True
        dgv.Columns("Descripcion").HeaderText = "Planta"
        dgv.Columns("Descripcion").ReadOnly = True
        dgv.Columns("Kilos").ReadOnly = True
        dgv.Columns("Seleccionar").ReadOnly = False

        dgv.Columns("IdPaqueteEncabezado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("IdVentaEnc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("BaleID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("Kilos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub propiedadesPaqueteDisponible(ByVal dgv As DataGridView)
        dgv.Columns("IdPaqueteEncabezado").HeaderText = "ID Paquete"
        dgv.Columns("IdPaqueteEncabezado").ReadOnly = True
        dgv.Columns("Cantidad").ReadOnly = True
        dgv.Columns("Kilos").ReadOnly = True
        dgv.Columns("Seleccionar").ReadOnly = False

        dgv.Columns("IdPaqueteEncabezado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("Kilos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Private Sub GuardaSalida()
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Try
            EntidadSalidaPacas.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarEncabezado
            EntidadSalidaPacas.IdSalidaEncabezado = IIf(TbIdSalida.Text = "", 0, TbIdSalida.Text)
            EntidadSalidaPacas.IdEmbarqueEncabezado = TbIdEmbarque.Text
            EntidadSalidaPacas.IdCompradoAcuentade = IIf(CbAcuenta.SelectedValue Is Nothing, 0, CbAcuenta.SelectedValue)
            EntidadSalidaPacas.NombreChofer = TbNombreChofer.Text
            EntidadSalidaPacas.PlacaTractoCamion = TbPlacaTractoCamion.Text
            EntidadSalidaPacas.NoLicencia = TbNoLicencia.Text
            EntidadSalidaPacas.Telefono = TbTelefono.Text
            EntidadSalidaPacas.PesoBruto = Val(TbBruto.Text)
            EntidadSalidaPacas.PesoTara = Val(TbTara.Text)
            EntidadSalidaPacas.PesoNeto = Val(TbNeto.Text)
            EntidadSalidaPacas.Destino = TbDestino.Text
            EntidadSalidaPacas.FolioSalida = TbFolioSalida.Text
            EntidadSalidaPacas.NoFactura = TbNoFactura.Text
            'EntidadSalidaPacas.CantidadPacas = Val(TbNoPacas.Text)
            EntidadSalidaPacas.FechaEntrada = DtpFechaEntrada.Value
            EntidadSalidaPacas.FechaSalida = DtFechaSalida.Value
            EntidadSalidaPacas.Observaciones = TbObservaciones.Text
            EntidadSalidaPacas.EstatusSalida = CbEstatus.SelectedValue
            NegocioSalidaPacas.GuardarSalida(EntidadSalidaPacas)
            TbIdSalida.Text = EntidadSalidaPacas.IdSalidaEncabezado

            TbNoLote.Text = ""
            'TbCantidadPacas.Text = ""
            'MsgBox("Guardado con exito", MsgBoxStyle.Information, "Aviso")
            'GbProceso.Enabled = True
            'GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdEmbarque.Text, "SE REMOVIERON " & DgvPacas.Rows.Count & " PACAS PARA EL COMPRADOR " & TbNombre.Text & ".")
        Catch ex As Exception
            MsgBox(ex.Message)
            'GbProceso.Enabled = False
        End Try
    End Sub
    Private Sub GuardaPacas(ByVal Baleid As Long, ByVal NoLote As String, ByVal IdPlanta As Integer, ByVal IdSalida As Integer, ByVal IdEmbarque As Integer, ByVal IdComprador As Integer, ByVal EstatusEmbarque As Integer)
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Try
            EntidadSalidaPacas.Guarda = Guardar.GuardaPacas
            EntidadSalidaPacas.IdSalidaEncabezado = IdSalida
            EntidadSalidaPacas.IdEmbarqueEncabezado = IdEmbarque
            EntidadSalidaPacas.IdComprador = IdComprador
            EntidadSalidaPacas.IdPlanta = IdPlanta
            EntidadSalidaPacas.BaleID = Baleid
            EntidadSalidaPacas.NoLote = NoLote
            EntidadSalidaPacas.NoContenedor = TbNoContenedor.Text
            EntidadSalidaPacas.EstatusSalida = EstatusEmbarque
            NegocioSalidaPacas.GuardarSalida(EntidadSalidaPacas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MarcaSeleccionDisponibles()
        Dim Contador As Integer = 0
        Dim Kilos As Double = 0
        For i As Integer = 0 To DgvOrdenesDetalle.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvOrdenesDetalle.Rows(i).Cells("Seleccionar").EditedFormattedValue, Boolean)
            If Seleccion = True Then
                Contador = Contador + 1
                Kilos = Kilos + DgvOrdenesDetalle.Rows(i).Cells("Kilos").Value
            End If
        Next
        TbPacasMarcadas.Text = Contador
        TbPacasMarcadas.Text = Format(Val(TbPacasMarcadas.Text), "#,##0")
    End Sub
    Private Sub MarcaSeleccion()
        Dim Contador As Integer = 0
        Dim Kilos As Double = 0
        For i As Integer = 0 To DgvSalidaPacas.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvSalidaPacas.Rows(i).Cells("Seleccionar").EditedFormattedValue, Boolean)
            If Seleccion = True Then
                Contador = Contador + 1
                Kilos = Kilos + DgvSalidaPacas.Rows(i).Cells("Kilos").Value
            End If
        Next
        TbPacasMarcadasLotes.Text = Contador
        TbPacasMarcadasLotes.Text = Format(Val(TbPacasMarcadasLotes.Text), "#,##0")
    End Sub
    Private Sub GuardarPacas()
        Try
            If DgvOrdenesDetalle.Rows.Count > 0 Then
                For Each recorrepaca As DataGridViewRow In DgvOrdenesDetalle.Rows
                    If recorrepaca.Cells("Seleccionar").Value = True Then
                        GuardaPacas(recorrepaca.Cells("BaleID").Value, recorrepaca.Cells("Nolote").Value, recorrepaca.Cells("IdPlantaOrigen").Value, Val(TbIdSalida.Text), Val(TbIdEmbarque.Text), Val(TbIdComprador.Text), 1)
                    End If
                Next
                consultaPacasEmbarque()
                consultaPaqueteEmbarque()
                CargaPaquetesDisponibles()
                CargaPacasDisponibles()
            End If
            'MsgBox("Salida guardado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RegresarPacas()
        If DgvSalidaPacas.Rows.Count > 0 Then
            For Each recorrepaca As DataGridViewRow In DgvSalidaPacas.Rows
                If recorrepaca.Cells("Seleccionar").Value = True Then
                    GuardaPacas(recorrepaca.Cells("BaleID").Value, recorrepaca.Cells("Nolote").Value, recorrepaca.Cells("IdPlantaOrigen").Value, 0, Val(TbIdEmbarque.Text), 0, 0)
                End If
            Next
            consultaPacasEmbarque()
            consultaPaqueteEmbarque()
            CargaPaquetesDisponibles()
            CargaPacasDisponibles()
        End If
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If TbIdEmbarque.Text <> "" Then
            GuardaSalida()

            GbDatos.Enabled = True
            GroupBox1.Enabled = True
            Panel3.Enabled = True
        Else
            MsgBox("No hay embarque seleccionado!", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Sub consultaPacasEmbarque()
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Try
            Dim tabla As New DataTable
            EntidadSalidaPacas.Consulta = Consulta.ConsultaPacasCantidadDisponible
            EntidadSalidaPacas.IdEmbarqueEncabezado = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
            tabla = EntidadSalidaPacas.TablaConsulta
            DgvSalidaPacas.DataSource = tabla
            'propiedadesPacasDisponible(DgvSalidaPacas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub consultaPaqueteEmbarque()
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Try
            Dim tabla As New DataTable
            EntidadSalidaPacas.Consulta = Consulta.ConsultaPaquetesSalida
            EntidadSalidaPacas.IdEmbarqueEncabezado = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
            tabla = EntidadSalidaPacas.TablaConsulta
            DgvSalidas.DataSource = tabla
            'propiedadesPaqueteDisponible(DgvSalidas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TbBruto_TextChanged(sender As Object, e As EventArgs) Handles TbBruto.TextChanged, TbTara.TextChanged
        TbNeto.Text = FormatNumber(IIf((Val(TbBruto.Text) - Val(TbTara.Text)) < 0, 0, Val(TbBruto.Text) - Val(TbTara.Text)), 1)
    End Sub

    'Private Sub TbTara_LostFocus(sender As Object, e As EventArgs) Handles TbTara.LostFocus
    '    TbTara.Text = FormatNumber(Val(TbTara.Text), 1)
    'End Sub

    'Private Sub TbBruto_LostFocus(sender As Object, e As EventArgs) Handles TbBruto.LostFocus
    '    TbBruto.Text = FormatNumber(Val(TbBruto.Text), 1)
    'End Sub

    'Private Sub TbBruto_GotFocus(sender As Object, e As EventArgs) Handles TbBruto.GotFocus, TbBruto.Click
    '    TbBruto.SelectAll()
    'End Sub

    'Private Sub TbTara_GotFocus(sender As Object, e As EventArgs) Handles TbTara.GotFocus, TbTara.Click
    '    TbTara.SelectAll()
    'End Sub
    Private Sub ConsultaCombo()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            Dim tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaComboLotes
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            tabla = EntidadOrdenEmbarquePacas.TablaConsulta
            CbLotesDisponible.DataSource = tabla
            CbLotesDisponible.ValueMember = "IdEmbarqueDet"
            CbLotesDisponible.DisplayMember = "Nolote"
            CbLotesDisponible.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtFiltroDisponible_Click(sender As Object, e As EventArgs) Handles BtFiltroDisponible.Click
        CargaPaquetesDisponibles()
        CargaPacasDisponibles()
    End Sub

    Private Sub GenerarNuevaSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarNuevaSalidaToolStripMenuItem.Click
        If TbIdEmbarque.Text <> "" Then
            GuardaSalida()
        Else
            MsgBox("No hay Embarque seleccionado para continuar!", MsgBoxStyle.Critical, "Aviso")
        End If
    End Sub
End Class