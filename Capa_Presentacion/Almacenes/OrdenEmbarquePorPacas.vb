Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class OrdenEmbarquePorPacas
    Private Sub OrdenEmbarquePorPacas_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ConsultarEmbarque()
        ConsultaLotes()
        ConsultaCombo()
        consultaPacasEmbarque()
        consultaPaqueteEmbarque()
        TbNoPacas.Text = DgvPacas.Rows.Count
    End Sub
    Private Sub EmbarqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarqueToolStripMenuItem.Click
        If TbIdEmbarque.Text <> "" Then
            Dim ReporteOrdenEmbarque As New RepOrdenEmbarque(TbIdEmbarque.Text)
            ReporteOrdenEmbarque.ShowDialog()
        Else
            MessageBox.Show("No hay Orden de Embarque seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        If TbNoLote.Text <> "" And Val(TbCantidadPacas.Text) > 0 Then
            If ExisteLote() = False Then
                GuardaEncabezado()
                GuardaLote()

                ConsultaLotes()
                ConsultaCombo()
            Else
                MsgBox("Ya existe ese lote en el embarque " & TbIdEmbarque.Text)
            End If
        Else
            MsgBox("Campos vacios")
        End If
    End Sub
    Private Function ExisteLote()
        Dim valida As Boolean = False
        Try

            Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
            Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
            Dim Tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaExisteNoLote
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = Val(TbIdEmbarque.Text)
            EntidadOrdenEmbarquePacas.NoLoteInd = TbNoLote.Text
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            Tabla = EntidadOrdenEmbarquePacas.TablaConsulta
            Dim row As DataRow = Tabla.Rows(Tabla.Rows.Count - 1)
            If row("Valida") <> 0 Then valida = True
            'propiedadesPaqueteDisponible(DgvPaqueteDisponible)

        Catch ex As Exception
            MsgBox(ex.Message)
            valida = False
        End Try
        Return valida
    End Function
    Private Sub BtnBuscarProd_Click(sender As Object, e As EventArgs) Handles BtnBuscarProd.Click
        Dim _ConsultaCompradorEmbarque As New ConsultaOrdenEmbarqueComprador
        _ConsultaCompradorEmbarque.ShowDialog()
        If _Id > 0 Then
            limpiar()
            TbIdComprador.Text = _Id
            TbNombre.Text = _NombreComprador
            _Id = 0
            _NombreComprador = ""
            CargaPaquetesDisponibles()
            CargaPacasDisponibles()

            TbPacasDisponibles.Text = DgvPacasDisponibles.RowCount
        End If
        'ConsultarPaqueteEmbarcado()
        'ConsultarPacasEmbarcadas()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub CargaPaquetesDisponibles()
        Try
            Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
            Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
            Dim Tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaBasica
            EntidadOrdenEmbarquePacas.IdComprador = TbIdComprador.Text
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            DgvPaqueteDisponible.DataSource = EntidadOrdenEmbarquePacas.TablaConsulta
            propiedadesPaqueteDisponible(DgvPaqueteDisponible)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargaPacasDisponibles()
        Try
            Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
            Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
            Dim Tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaAlmacen
            EntidadOrdenEmbarquePacas.IdComprador = TbIdComprador.Text
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            DgvPacasDisponibles.DataSource = EntidadOrdenEmbarquePacas.TablaConsulta
            propiedadesPacasDisponible(DgvPacasDisponibles)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub propiedadesPacasDisponible(ByVal dgv As DataGridView)
        'dgv.Columns("IdPaqueteEncabezado").HeaderText = "ID Paquete"
        'dgv.Columns("IdPaqueteEncabezado").ReadOnly = False
        'dgv.Columns("IdVentaEnc").HeaderText = "ID Venta"
        'dgv.Columns("IdVentaEnc").ReadOnly = True
        'dgv.Columns("IdPlantaOrigen").Visible = False
        'dgv.Columns("BaleID").ReadOnly = True
        'dgv.Columns("Descripcion").HeaderText = "Planta"
        'dgv.Columns("Descripcion").ReadOnly = True
        'dgv.Columns("Kilos").ReadOnly = True
        'dgv.Columns("Seleccionar").ReadOnly = False
        'dgv.Columns("Kilos").DefaultCellStyle.Format = "###,##0.00"
        'dgv.Columns("IdPaqueteEncabezado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv.Columns("IdVentaEnc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv.Columns("BaleID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv.Columns("Kilos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub propiedadesPaqueteDisponible(ByVal dgv As DataGridView)
        'dgv.Columns("IdPaqueteEncabezado").HeaderText = "ID Paquete"
        'dgv.Columns("IdPaqueteEncabezado").ReadOnly = True
        'dgv.Columns("Cantidad").ReadOnly = True
        'dgv.Columns("Kilos").ReadOnly = True
        'dgv.Columns("Kilos").DefaultCellStyle.Format = "###,##0.00"
        'dgv.Columns("Seleccionar").ReadOnly = False

        'dgv.Columns("IdPaqueteEncabezado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv.Columns("Kilos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Private Sub propiedadesLotes()
        DgvLotes.Columns("IdEmbarqueEnc").Visible = False
        DgvLotes.Columns("NoContenedor").Visible = False
        DgvLotes.Columns("PlacaCaja").Visible = False
        DgvLotes.Columns("Fecha").Visible = False
        DgvLotes.Columns("FechaActualizacion").Visible = False

        DgvLotes.Columns("IdEmbarqueDet").HeaderText = "ID Emb Det"
        DgvLotes.Columns("CantidadPacas").HeaderText = "No Pacas"
        DgvLotes.Columns("NoLote").HeaderText = "No Lote"
    End Sub
    Private Sub DgvPaqueteDisponible_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPaqueteDisponible.CellContentClick
        Dim filaSeleccionada As Integer = DgvPaqueteDisponible.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvPaqueteDisponible.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvPaqueteDisponible.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvPacasDisponibles.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub DgvPacasDisponibles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacasDisponibles.CellContentClick
        Dim filaSeleccionada As Integer = DgvPacasDisponibles.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvPacasDisponibles.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvPacasDisponibles.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvPaqueteDisponible.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub DgvPacas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacas.CellContentClick
        Dim filaSeleccionada As Integer = DgvPacas.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvPacas.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvPacas.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvPaquete.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub
    'Private Sub DgvDatosLiquidacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatosLiquidacion.CellContentClick
    '    Dim filaSeleccionada As Integer = DgvDatosLiquidacion.CurrentRow.Index
    '    Dim chkSel As Boolean = CType(Me.DgvDatosLiquidacion.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
    '    Dim IdPaquete As Integer
    '    IdPaquete = DgvDatosLiquidacion.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
    '    For Each row As DataGridViewRow In DgvPacasVender.Rows
    '        Dim Index As Integer = Convert.ToUInt64(row.Index)
    '        If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
    '            row.Cells("Seleccionar").Value = True
    '        ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
    '            row.Cells("Seleccionar").Value = False
    '        End If
    '    Next
    '    MarcaSeleccionDisponibles()
    'End Sub
    Private Sub MarcaSeleccionDisponibles()
        Dim Contador As Integer = 0
        Dim Kilos As Double = 0
        For i As Integer = 0 To DgvPacasDisponibles.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvPacasDisponibles.Rows(i).Cells("Seleccionar").EditedFormattedValue, Boolean)
            If Seleccion = True Then
                Contador = Contador + 1
                Kilos = Kilos + DgvPacasDisponibles.Rows(i).Cells("Kilos").Value
            End If
        Next
        TbPacasMarcadas.Text = Contador
        TbPacasMarcadas.Text = Format(Val(TbPacasMarcadas.Text), "#,##0")
    End Sub

    Private Sub DgvPaquete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPaquete.CellContentClick
        Dim filaSeleccionada As Integer = DgvPaquete.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvPaquete.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvPaquete.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvPacas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccion()
    End Sub
    Private Sub MarcaSeleccion()
        Dim Contador As Integer = 0
        Dim Kilos As Double = 0
        For i As Integer = 0 To DgvPacas.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvPacas.Rows(i).Cells("Seleccionar").EditedFormattedValue, Boolean)
            If Seleccion = True Then
                Contador = Contador + 1
                Kilos = Kilos + DgvPacas.Rows(i).Cells("Kilos").Value
            End If
        Next
        TbPacasMarcadasLotes.Text = Contador
        TbPacasMarcadasLotes.Text = Format(Val(TbPacasMarcadasLotes.Text), "#,##0")
    End Sub
    Private Sub limpiar()
        TbIdEmbarque.Clear()
        TbIdComprador.Clear()
        TbIdLoteDet.Clear()
        TbNombre.Clear()
        TbObservaciones.Clear()
        TbNoPacas.Clear()
        TbNoLote.Clear()
        TbCantidadPacas.Clear()
        TbPacasDisponibles.Clear()
        TbPacasMarcadas.Clear()
        TbPacasLoteadas.Clear()
        TbPacasMarcadasLotes.Clear()
        TbCantidadPacasCombo.Clear()
        CbLotes.DataSource = Nothing
        TbNoPacas.Clear()
        DtpFecha.Value = Now
        DgvLotes.DataSource = Nothing
        DgvPaqueteDisponible.DataSource = Nothing
        DgvPacasDisponibles.DataSource = Nothing
        DgvPaquete.DataSource = Nothing
        DgvPacas.DataSource = Nothing
    End Sub

    Private Sub GuardaEncabezado()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            EntidadOrdenEmbarquePacas.Guarda = Guardar.GuardarEmbarqueEncabezado
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            EntidadOrdenEmbarquePacas.IdComprador = TbIdComprador.Text
            EntidadOrdenEmbarquePacas.NombreChofer = ""
            EntidadOrdenEmbarquePacas.PlacaTractoCamion = ""
            EntidadOrdenEmbarquePacas.NoLicencia = ""
            EntidadOrdenEmbarquePacas.NoLote1 = ""
            EntidadOrdenEmbarquePacas.NoLote2 = ""
            EntidadOrdenEmbarquePacas.Telefono = ""
            EntidadOrdenEmbarquePacas.Observaciones = TbObservaciones.Text
            EntidadOrdenEmbarquePacas.CantidadCajas = 0
            EntidadOrdenEmbarquePacas.NoContenedorCaja1 = ""
            EntidadOrdenEmbarquePacas.PlacaCaja1 = ""
            EntidadOrdenEmbarquePacas.NoContenedorCaja2 = ""
            EntidadOrdenEmbarquePacas.PlacaCaja2 = ""
            EntidadOrdenEmbarquePacas.NoPacas = Val(TbNoPacas.Text)
            EntidadOrdenEmbarquePacas.Fecha = DtpFecha.Value
            NegocioOrdenEmbarquePacas.Guardar(EntidadOrdenEmbarquePacas)
            TbIdEmbarque.Text = EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado
            'MsgBox("Guardado con exito", MsgBoxStyle.Information, "Aviso")
            'GbProceso.Enabled = True
            'GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdEmbarque.Text, "SE REMOVIERON " & DgvPacas.Rows.Count & " PACAS PARA EL COMPRADOR " & TbNombre.Text & ".")
        Catch ex As Exception
            MsgBox(ex.Message)
            'GbProceso.Enabled = False
        End Try
    End Sub
    Private Sub GuardaLote()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            EntidadOrdenEmbarquePacas.Guarda = Guardar.GuardarEmbarqueDetalleLotes
            EntidadOrdenEmbarquePacas.IdEmbarqueDetalle = IIf(TbIdLoteDet.Text = "", 0, Val(TbIdLoteDet.Text))
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = TbIdEmbarque.Text
            EntidadOrdenEmbarquePacas.NoPacas = Val(TbCantidadPacas.Text)
            EntidadOrdenEmbarquePacas.NoContenedorInd = ""
            EntidadOrdenEmbarquePacas.NoLoteInd = TbNoLote.Text
            EntidadOrdenEmbarquePacas.PlacaCaja = ""
            EntidadOrdenEmbarquePacas.ObservacionLote = TbObservacionNoLote.Text
            EntidadOrdenEmbarquePacas.Fecha = DtpFecha.Value
            EntidadOrdenEmbarquePacas.FechaActualizacion = Now
            NegocioOrdenEmbarquePacas.Guardar(EntidadOrdenEmbarquePacas)
            TbIdEmbarque.Text = EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado

            TbNoLote.Text = ""
            TbCantidadPacas.Text = ""
            TbObservacionNoLote.Text = ""
            TbIdLoteDet.Text = ""
            'MsgBox("Guardado con exito", MsgBoxStyle.Information, "Aviso")
            'GbProceso.Enabled = True
            'GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdEmbarque.Text, "SE REMOVIERON " & DgvPacas.Rows.Count & " PACAS PARA EL COMPRADOR " & TbNombre.Text & ".")
        Catch ex As Exception
            MsgBox(ex.Message)
            'GbProceso.Enabled = False
        End Try
    End Sub
    Private Sub GuardaPacas(ByVal Baleid As Long, ByVal NoLote As String, ByVal IdPlanta As Integer, ByVal IdEmbarque As Integer, ByVal IdComprador As Integer, ByVal EstatusEmbarque As Integer)
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            EntidadOrdenEmbarquePacas.Guarda = Guardar.GuardaPacas
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = IdEmbarque
            EntidadOrdenEmbarquePacas.IdComprador = IdComprador
            EntidadOrdenEmbarquePacas.IdPlanta = IdPlanta
            EntidadOrdenEmbarquePacas.BaleID = Baleid
            EntidadOrdenEmbarquePacas.NoLoteInd = NoLote
            EntidadOrdenEmbarquePacas.EstatusEmbarque = EstatusEmbarque
            NegocioOrdenEmbarquePacas.Guardar(EntidadOrdenEmbarquePacas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultaCombo()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            Dim tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaComboLotes
            EntidadOrdenEmbarquePacas.EstatusSalida = 0
            EntidadOrdenEmbarquePacas.IdSalida = 0
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            tabla = EntidadOrdenEmbarquePacas.TablaConsulta
            CbLotes.DataSource = tabla
            CbLotes.ValueMember = "IdEmbarqueDet"
            CbLotes.DisplayMember = "Nolote"
            CbLotes.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultaLotes()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            Dim tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaLotes
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            tabla = EntidadOrdenEmbarquePacas.TablaConsulta
            DgvLotes.DataSource = tabla
            propiedadesLotes()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub consultaPacasEmbarque()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            Dim tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaPacasEmbarques
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            tabla = EntidadOrdenEmbarquePacas.TablaConsulta
            DgvPacas.DataSource = tabla
            propiedadesPacasDisponible(DgvPacas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub consultaPaqueteEmbarque()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            Dim tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaPaquetesembarques
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            tabla = EntidadOrdenEmbarquePacas.TablaConsulta
            DgvPaquete.DataSource = tabla
            propiedadesPaqueteDisponible(DgvPaquete)
        Catch ex As Exception
            MsgBox(ex.Message)
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
            TbNombre.Text = Tabla.Rows(0).Item("Nombre")
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
            DtpFecha.Value = Tabla.Rows(0).Item("Fecha")
            TbObservaciones.Text = Tabla.Rows(0).Item("Observaciones")
            CargaPaquetesDisponibles()
            CargaPacasDisponibles()
            'ConsultarPaqueteEmbarcado()
            'ConsultarPacasEmbarcadas()
            'GbProceso.Enabled = True
            TbPacasDisponibles.Text = DgvPacasDisponibles.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'GeneraRegistroBitacora(Me.Text.Clone.ToString, ConsultarToolStripMenuItem.Text, TbIdEmbarque.Text, TbNombreComprador.Text)
        End Try
    End Sub
    Private Sub CargaComboLotesCantidad()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Dim Tabla As New DataTable
        Try
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaComboLotesPacas
            EntidadOrdenEmbarquePacas.IdEmbarqueDetalle = CbLotes.SelectedValue
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            Tabla = EntidadOrdenEmbarquePacas.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                Exit Sub
            End If
            TbCantidadPacasCombo.Text = Tabla.Rows(0).Item("CantidadPacas")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CbLotes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbLotes.SelectionChangeCommitted
        CargaComboLotesCantidad()
    End Sub
    Private Sub BtEnviaPacas_Click(sender As Object, e As EventArgs) Handles BtEnviaPacas.Click
        Try
            If CbLotes.Text <> "" And Val(TbCantidadPacasCombo.Text) > 0 Then
                If DgvPaqueteDisponible.RowCount > 0 Then
                    If (Val(TbPacasMarcadas.Text) + cuentapacaslote(CbLotes.Text)) <= Val(TbCantidadPacasCombo.Text) Then
                        For Each recorrepaca As DataGridViewRow In DgvPacasDisponibles.Rows
                            If recorrepaca.Cells("Seleccionar").Value = True Then
                                GuardaPacas(recorrepaca.Cells("BaleID").Value, CbLotes.Text, recorrepaca.Cells("IdPlantaOrigen").Value, Val(TbIdEmbarque.Text), Val(TbIdComprador.Text), 1)
                            End If
                        Next
                    Else
                        MsgBox("Las pacas seleccionadas exceden la cantidad del lote " & CbLotes.Text & " " & TbCantidadPacasCombo.Text)
                    End If
                Else
                    MsgBox("No hay pacas disponibles para seleccionar", MsgBoxStyle.Information, "Aviso")
                End If
            Else
                MsgBox("Seleccione un lote para continuar.", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        consultaPacasEmbarque()
        consultaPaqueteEmbarque()
        CargaPaquetesDisponibles()
        CargaPacasDisponibles()
        TbNoPacas.Text = DgvPacas.Rows.Count
        TbPacasLoteadas.Text = DgvPacas.RowCount
        TbPacasDisponibles.Text = DgvPacasDisponibles.RowCount
        TbPacasMarcadas.Text = 0
    End Sub
    Private Sub BtDevuelvePacas_Click(sender As Object, e As EventArgs) Handles BtDevuelvePacas.Click
        For Each recorrepaca As DataGridViewRow In DgvPacas.Rows
            If recorrepaca.Cells("Seleccionar").Value = True Then
                GuardaPacas(recorrepaca.Cells("BaleID").Value, "", recorrepaca.Cells("IdPlantaOrigen").Value, 0, 0, 0)
            End If
        Next
        consultaPacasEmbarque()
        consultaPaqueteEmbarque()
        CargaPaquetesDisponibles()
        CargaPacasDisponibles()
        TbPacasLoteadas.Text = DgvPacas.RowCount
        TbPacasMarcadasLotes.Text = 0
        TbPacasDisponibles.Text = DgvPacasDisponibles.RowCount
        TbNoPacas.Text = DgvPacas.Rows.Count
    End Sub
    Private Function cuentapacaslote(ByVal NoLote As String) As Integer
        Dim contador As New Integer
        For Each rows As DataGridViewRow In DgvPacas.Rows
            If rows.Cells("Nolote").Value = NoLote Then
                contador = contador + 1
            End If
        Next
        Return contador
    End Function
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

        If DgvPaqueteDisponible.Columns.Count > 0 Then
            dtpacasDisponibles = TryCast(DgvPacasDisponibles.DataSource, DataTable)
            dtpaqueteDisponible = TryCast(DgvPaqueteDisponible.DataSource, DataTable)
        Else
            dtpaqueteDisponible.Columns.Add("IdPaqueteEncabezado")
            dtpaqueteDisponible.Columns.Add("Cantidad")
            dtpaqueteDisponible.Columns.Add("Kilos")
            dtpaqueteDisponible.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

            dtpacasDisponibles.Columns.Add("IdPaqueteEncabezado")
            dtpacasDisponibles.Columns.Add("IdVentaEnc")
            dtpacasDisponibles.Columns.Add("IdPlantaOrigen")
            dtpacasDisponibles.Columns.Add("BaleID")
            dtpacasDisponibles.Columns.Add("Descripcion")
            dtpacasDisponibles.Columns.Add("Kilos")
            dtpacasDisponibles.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))
        End If
        If DgvPaquete.Columns.Count > 0 Then
            dtpacasRecibidas = TryCast(DgvPacas.DataSource, DataTable)
            dtpaqueteRecibido = TryCast(DgvPaquete.DataSource, DataTable)
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
            If filapacas("Seleccionar") = True And validapacas(filapacas("Baleid"), DgvPacasDisponibles) = False Then
                Dim Renglon As DataRow = dtPacasOrigen.NewRow()
                Renglon("IdPaqueteEncabezado") = filapacas("IdPaqueteEncabezado")
                Renglon("IdVentaEnc") = filapacas("IdVentaEnc")
                Renglon("IdPlantaOrigen") = filapacas("IdPlantaOrigen")
                Renglon("BaleID") = filapacas("BaleID")
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
                Renglon("NoLote") = CbLotes.Text
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

            ElseIf filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado"), DgvPaqueteDisponible) = False Then
                Dim Renglon As DataRow = dtPaqueteOrigen.NewRow()
                Renglon("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon("Cantidad") = filapaquetes("Cantidad")
                Renglon("Kilos") = filapaquetes("Kilos")
                Renglon("Seleccionar") = False
                dtPaqueteOrigen.Rows.Add(Renglon)
            ElseIf filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado"), DgvPaqueteDisponible) = True Then

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
                Renglon("Descripcion") = filapacas("Descripcion")
                Renglon("Kilos") = filapacas("Kilos")
                Renglon("Seleccionar") = False
                dtPacasOrigen.Rows.Add(Renglon)
                'End If
            Next
            DgvPacasDisponibles.DataSource = dtPacasOrigen
        Else
            DgvPacasDisponibles.DataSource = dtPacasOrigen
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
                DgvPaqueteDisponible.DataSource = dtPaqueteOrigen
            Next
        Else
            DgvPaqueteDisponible.DataSource = dtPaqueteOrigen
        End If

        DgvPaquete.DataSource = dtPaqueteDestino
        DgvPacas.DataSource = dtPacasDestino
        propiedadesPacasDisponible(DgvPacas)
        propiedadesPaqueteDisponible(DgvPaquete)
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

        If DgvPaqueteDisponible.Columns.Count > 0 Then
            dtpacasDisponibles = TryCast(DgvPacasDisponibles.DataSource, DataTable)
            dtpaqueteDisponible = TryCast(DgvPaqueteDisponible.DataSource, DataTable)
        Else
            dtpaqueteDisponible.Columns.Add("IdPaqueteEncabezado")
            dtpaqueteDisponible.Columns.Add("Cantidad")
            dtpaqueteDisponible.Columns.Add("Kilos")
            dtpaqueteDisponible.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))

            dtpacasDisponibles.Columns.Add("IdPaqueteEncabezado")
            dtpacasDisponibles.Columns.Add("IdVentaEnc")
            dtpacasDisponibles.Columns.Add("IdPlantaOrigen")
            dtpacasDisponibles.Columns.Add("BaleID")
            dtpacasDisponibles.Columns.Add("Descripcion")
            dtpacasDisponibles.Columns.Add("Kilos")
            dtpacasDisponibles.Columns.Add("Seleccionar", System.Type.GetType("System.Boolean"))
        End If
        If DgvPaquete.Columns.Count > 0 Then
            dtpacasRecibidas = TryCast(DgvPacas.DataSource, DataTable)
            dtpaqueteRecibido = TryCast(DgvPaquete.DataSource, DataTable)
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
            If filapacas("Seleccionar") = True And validapacas(filapacas("Baleid"), DgvPacas) = False Then
                Dim Renglon As DataRow = dtPacasDestino.NewRow()
                Renglon("IdPaqueteEncabezado") = filapacas("IdPaqueteEncabezado")
                Renglon("IdVentaEnc") = filapacas("IdVentaEnc")
                Renglon("IdPlantaOrigen") = filapacas("IdPlantaOrigen")
                Renglon("BaleID") = filapacas("BaleID")
                Renglon("NoLote") = CbLotes.Text
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

            ElseIf filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado"), DgvPaquete) = False Then
                Dim Renglon As DataRow = dtPaqueteDestino.NewRow()
                Renglon("IdPaqueteEncabezado") = filapaquetes("IdPaqueteEncabezado")
                Renglon("Cantidad") = filapaquetes("Cantidad")
                Renglon("Kilos") = filapaquetes("Kilos")
                Renglon("Seleccionar") = False
                dtPaqueteDestino.Rows.Add(Renglon)
            ElseIf filapaquetes("Seleccionar") = True And validaValor(filapaquetes("IdPaqueteEncabezado"), DgvPaqueteDisponible) = True Then
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
                Renglon("NoLote") = IIf(filapacas("NoLote") = "", CbLotes.Text, filapacas("NoLote"))
                Renglon("Descripcion") = filapacas("Descripcion")
                Renglon("Kilos") = filapacas("Kilos")
                Renglon("Seleccionar") = False
                dtPacasDestino.Rows.Add(Renglon)
                'End If
            Next
            DgvPacas.DataSource = dtPacasDestino
        Else
            DgvPacas.DataSource = dtPacasDestino
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
                DgvPaquete.DataSource = dtPaqueteDestino
            Next
        Else
            DgvPaquete.DataSource = dtPaqueteDestino
        End If

        DgvPaqueteDisponible.DataSource = dtPaqueteOrigen
        DgvPacasDisponibles.DataSource = dtPacasOrigen
        propiedadesPacasDisponible(DgvPacasDisponibles)
        propiedadesPaqueteDisponible(DgvPaqueteDisponible)
    End Sub
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

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            If DgvPacas.Rows.Count > 0 Then
                'For Each recorrepaca As DataGridViewRow In DgvPacas.Rows
                '    GuardaPacas(recorrepaca.Cells("BaleID").Value, recorrepaca.Cells("Nolote").Value, recorrepaca.Cells("IdPlantaOrigen").Value, Val(TbIdEmbarque.Text), Val(TbIdComprador.Text), 1)
                'Next
                consultaPacasEmbarque()
                consultaPaqueteEmbarque()
            End If
            If DgvPacasDisponibles.Rows.Count > 0 Then
                'For Each recorrepaca As DataGridViewRow In DgvPacasDisponibles.Rows
                '    GuardaPacas(recorrepaca.Cells("BaleID").Value, "", recorrepaca.Cells("IdPlantaOrigen").Value, 0, 0, 0)
                'Next
                CargaPaquetesDisponibles()
                CargaPacasDisponibles()
            End If
            MsgBox("Embarque guardado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtExcel_Click(sender As Object, e As EventArgs) Handles BtExcel.Click
        CargaExcel.ShowDialog()
        Try
            If TablaExcel.Rows.Count > 0 Then
                For Each rowTabla As DataRow In TablaExcel.Rows
                    For Each rowGrid As DataGridViewRow In DgvPacasDisponibles.Rows
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

    Private Sub DgvLotes_DoubleClick(sender As Object, e As EventArgs) Handles DgvLotes.DoubleClick
        If DgvLotes.RowCount = 0 Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvLotes.CurrentCell.RowIndex
            TbIdLoteDet.Text = DgvLotes.Rows(index).Cells("IdEmbarqueDet").Value
            TbNoLote.Text = DgvLotes.Rows(index).Cells("NoLote").Value
            TbObservacionNoLote.Text = DgvLotes.Rows(index).Cells("ObservacionLote").Value
            TbCantidadPacas.Text = DgvLotes.Rows(index).Cells("CantidadPacas").Value
        End If
    End Sub
End Class
