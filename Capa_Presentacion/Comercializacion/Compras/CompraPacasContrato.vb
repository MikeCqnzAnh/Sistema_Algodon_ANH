Imports Capa_Operacion.Configuracion
Public Class CompraPacasContrato
    Public TablaModalidadCompra, TablacastigoMicros, TablaCastigoLargoFibra, TablaCastigoResistenciaFibra, TablaPacasAgrupadas, TablaPacasCompras As New DataTable
    Private Sub CompraPacasContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaPacasAgrupadas.Columns.Clear()
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Grade", System.Type.GetType("System.String")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Cantidad", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Kilos", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Quintales", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioQuintal", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Total", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("TotalDlls", System.Type.GetType("System.Double")))
        CargarCombos()
        Nuevo()
    End Sub
    Private Sub BtModalidadCompra_Click(sender As Object, e As EventArgs) Handles BtClasesDif.Click
        ModalidadCompra.ShowDialog()
        TablaModalidadCompra = Tabla
    End Sub
    Private Sub BtCastigoResFibra_Click(sender As Object, e As EventArgs) Handles BtCastigoResFibra.Click
        CastigosResistenciaFibra.ShowDialog()
        TablaCastigoResistenciaFibra = Tabla
    End Sub

    Private Sub BtCastigoMicros_Click(sender As Object, e As EventArgs) Handles BtCastigoMicros.Click
        CastigosMicro.ShowDialog()
        TablacastigoMicros = Tabla
    End Sub

    Private Sub BtCastLarFib_Click(sender As Object, e As EventArgs) Handles BtCastLarFib.Click
        CastigosLargoFibra.ShowDialog()
        TablaCastigoLargoFibra = Tabla
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If TbIdProductor.Text = "" Or TbPrecioQuintal.Text = "" Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        ElseIf ValidaChecksPacas() > 0 Then
            EntidadCompraPacasContrato.TablaGeneral = DataGridADatatable()
            NegocioCompraPacasContrato.Guardar(EntidadCompraPacasContrato)
            filtraPacasClases()
            VarGlob2.IdProductor = TbIdProductor.Text
            VarGlob2.NombreProductor = TbNombreProductor.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text

            _Tabla = Table()
            CompraPago.ShowDialog()
        Else
            MessageBox.Show("No hay pacas seleccionadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ConfirmarSeleccion()

    End Sub
    Private Sub Guardar()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.IdCompra = IIf(TbIdCompraPaca.Text = "", 0, TbIdCompraPaca.Text)
        EntidadCompraPacasContrato.IdContrato = TbIdContrato.Text
        EntidadCompraPacasContrato.IdPlanta = CbPlanta.SelectedValue
        EntidadCompraPacasContrato.IdModalidadCompra = CbModalidadCompra.SelectedValue
        EntidadCompraPacasContrato.FechaCompra = DtFechaCompra.Value
        'EntidadCompraPacasContrato.TotalPacas =
        'EntidadCompraPacasContrato.idMunicipio = CbMunicipio.SelectedValue
        'EntidadCompraPacasContrato.Telefono = TbTelefono.Text
        'EntidadCompraPacasContrato.Correo = TbCorreo.Text
        'EntidadCompraPacasContrato.IdEstatus = CbEstatus.SelectedValue
        'EntidadCompraPacasContrato.IdUsuarioCreacion = 1
        'EntidadCompraPacasContrato.FechaCreacion = Now
        'NegocioCompraPacasContrato.Guardar(EntidadCompraPacasContrato)
        'TbIdComprador.Text = EntidadCompraPacasContrato.IdComprador
    End Sub
    Private Function DataGridADatatable() As DataTable
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Add("IdProductor", Type.GetType("System.String"))
        dt.Columns.Add("BaleID", Type.GetType("System.String"))
        dt.Columns.Add("IdLiquidacion", Type.GetType("System.String"))

        For i = 0 To DgvPacasComprar.Rows.Count - 1
            r = dt.NewRow
            If DgvPacasComprar.Item("Seleccionar", i).EditedFormattedValue = True Then
                r("IdProductor") = TbIdProductor.Text
                r("BaleID") = DgvPacasComprar.Item("BaleID", i).Value.ToString
                r("IdLiquidacion") = DgvPacasComprar.Item("IdLiquidacion", i).Value.ToString
                dt.Rows.Add(r)
            End If
        Next
        Return dt
    End Function
    Private Sub CuentaPacasMarcadas() Handles DgvPacasComprar.CellContentClick
        MarcaSeleccionDisponibles()
    End Sub
    Private Function ValidaChecksPacas()
        Dim PacasMarcadas As Integer = 0
        For i As Integer = 0 To DgvPacasComprar.Rows.Count - 1
            If DgvPacasComprar.Rows(i).Cells("Seleccionar").EditedFormattedValue = True Then
                PacasMarcadas = PacasMarcadas + 1
            End If
        Next
        Return PacasMarcadas
    End Function
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ConsultaCompraProductor.ShowDialog()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub Nuevo()
        TbIdCompraPaca.Text = ""
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        CbPlanta.SelectedValue = 1
        CbClasesPacasAcomprar.SelectedValue = -1
        TbDesdePaca.Text = ""
        TbHastaPaca.Text = ""
        TbIdContrato.Text = ""
        TbPrecioQuintal.Text = ""
        TbNoPacas.Text = ""
        DgvContratos.DataSource = Nothing
        DgvDatosLiquidacion.DataSource = Nothing
        DgvLiqCompradas.DataSource = Nothing
        DgvPacasComprar.DataSource = Nothing
        DgvPacasIndCompradas.DataSource = Nothing
        DgvAgrupadasCliente.DataSource = Nothing
        DgvAgrupadasClases.DataSource = Nothing
        DgvContratos.Columns.Clear()
        DgvDatosLiquidacion.Columns.Clear()
        DgvLiqCompradas.Columns.Clear()
        DgvPacasComprar.Columns.Clear()
        DgvPacasIndCompradas.Columns.Clear()
        DgvAgrupadasCliente.Columns.Clear()
        DgvAgrupadasClases.Columns.Clear()
        TbPacasContratadas.Text = ""
        TbPacasDisp.Text = ""
        TbPacasCompCont.Text = ""
        TbPacasMarc.Text = ""
        TbPacasComp.Text = ""
        TbKilosComp.Text = ""
        TbKilosSeleccionados.Text = ""
        TablaModalidadCompra.Clear()
        TablacastigoMicros.Clear()
        TablaCastigoLargoFibra.Clear()
        TablaCastigoResistenciaFibra.Clear()
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
        CbPlanta.SelectedValue = 1
        '--Clases---
        'Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        'Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        'Dim Tabla2 As New DataTable
        'EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        'NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        'Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        'CbClasesPacasAcomprar.DataSource = Tabla2
        'CbClasesPacasAcomprar.ValueMember = "IdClasificacion"
        'CbClasesPacasAcomprar.DisplayMember = "ClaveCorta"
        'CbClasesPacasAcomprar.SelectedValue = -1
        LLenaComboInstancias(CbClasesCompradas)
        LLenaComboInstancias(CbClasesPacasAcomprar)
        '---Modalidad De Compra--
        Dim Tabla3 As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaModoCompra
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla3 = EntidadProduccion.TablaConsulta
        CbModalidadCompra.DataSource = Tabla3
        CbModalidadCompra.ValueMember = "IdModoEncabezado"
        CbModalidadCompra.DisplayMember = "Descripcion"
        CbModalidadCompra.SelectedValue = 11
    End Sub
    Private Sub LLenaComboInstancias(ByVal cmb As ComboBox)
        'cmb.Items.Clear()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        cmb.DataSource = Tabla2
        cmb.ValueMember = "IdClasificacion"
        cmb.DisplayMember = "ClaveCorta"
        cmb.SelectedValue = -1
    End Sub
    Private Sub BtnBuscarProd_Click(sender As Object, e As EventArgs) Handles BtnBuscarProd.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        ConsultaProductores.ShowDialog()
        TbIdProductor.Text = _Id
        TbNombreProductor.Text = _Nombre
        'TbAsociacion.Text = _Dato
        If TbIdProductor.Text = 0 Then
            TbIdProductor.Text = ""
            MsgBox("Seleccionar a un productor para ver sus contratos", MsgBoxStyle.Exclamation)
        Else
            '---Consultar contratos del productor---
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPorId
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvContratos.Columns.Clear()
            DgvContratos.DataSource = Tabla
            Dim colSelCon As New DataGridViewCheckBoxColumn()
            colSelCon.Name = "Seleccionar"
            colSelCon.FalseValue = False
            colSelCon.Visible = True
            DgvContratos.Columns.Insert(5, colSelCon)
            '---Consultar liquidaciones del productor con compras
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaLiquidacionesCompras
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvLiqCompradas.Columns.Clear()
            DgvLiqCompradas.DataSource = Tabla
            PropiedadesDgvLiquidacionesCompradas()
            '---Consultar liquidaciones del productor
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaLiquidaciones
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvDatosLiquidacion.Columns.Clear()
            DgvDatosLiquidacion.DataSource = Tabla
            'Dim colSelLiq As New DataGridViewCheckBoxColumn()
            'colSelLiq.Name = "Seleccionar"
            'colSelLiq.FalseValue = False
            'colSelLiq.Visible = True
            'DgvDatosLiquidacion.Columns.Insert(6, colSelLiq)
            PropiedadesDgvLiquidacionesComprar()

            '---Consultar pacas compradas
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPacaComprada
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvPacasIndCompradas.Columns.Clear()
            DgvPacasIndCompradas.DataSource = Tabla

            '---Consultar las pacas ya clasificadas del productor
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPaca
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvPacasComprar.Columns.Clear()
            DgvPacasComprar.DataSource = Tabla

            PropiedadesDgvPacasComprar()
            ConsultaCantidadPacas()
            TotalPacasContrato()
            MarcaSeleccionDisponibles()
        End If
    End Sub
    Private Sub TotalPacasContrato()
        Dim Pacas As Integer = 0
        For i As Integer = 0 To DgvContratos.Rows.Count - 1
            Pacas += DgvContratos.Rows(i).Cells("Pacas").Value
        Next
        TbPacasContratadas.Text = Pacas
        TbPacasCompCont.Text = Val(TbPacasContratadas.Text) - Val(TbPacasComp.Text)
    End Sub

    Private Sub PropiedadesDgvPacasComprar()
        DgvPacasComprar.Columns("IdOrdenTrabajo").Visible = False
        DgvPacasComprar.Columns("IdLiquidacion").Visible = True
        DgvPacasComprar.Columns("Descripcion").ReadOnly = True
        DgvPacasComprar.Columns("BaleId").ReadOnly = True
        DgvPacasComprar.Columns("FolioCIA").Visible = False
        DgvPacasComprar.Columns("Descripcion").Visible = False
        DgvPacasComprar.Columns("Kilos").ReadOnly = True
        DgvPacasComprar.Columns("Grade").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvLiquidacionesCompradas()
        DgvLiqCompradas.Columns("IdLiquidacion").ReadOnly = True
        DgvLiqCompradas.Columns("TotalHueso").Visible = False
        DgvLiqCompradas.Columns("PacasCantidad").ReadOnly = True
        DgvLiqCompradas.Columns("PacasDisponibles").Visible = False
        DgvLiqCompradas.Columns("PacasCompradas").ReadOnly = True
        DgvLiqCompradas.Columns("PesoPluma").Visible = False
        DgvLiqCompradas.Columns("TotalSemilla").Visible = False
        DgvLiqCompradas.Columns("Seleccionar").ReadOnly = False
    End Sub
    Private Sub PropiedadesDgvLiquidacionesComprar()
        DgvDatosLiquidacion.Columns("IdLiquidacion").ReadOnly = True
        DgvDatosLiquidacion.Columns("TotalHueso").ReadOnly = True
        DgvDatosLiquidacion.Columns("PacasCantidad").ReadOnly = True
        DgvDatosLiquidacion.Columns("PacasDisponibles").ReadOnly = True
        DgvDatosLiquidacion.Columns("PacasCompradas").ReadOnly = True
        DgvDatosLiquidacion.Columns("PesoPluma").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvContratos()
        DgvContratos.Columns("IdContratoAlgodon").ReadOnly = True
        DgvContratos.Columns("Pacas").ReadOnly = True
        DgvContratos.Columns("SuperficieComprometida").ReadOnly = True
        DgvContratos.Columns("PrecioQuintal").ReadOnly = True
        DgvContratos.Columns("Fecha").ReadOnly = True
    End Sub
    Private Sub DgvContratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContratos.CellContentClick
        Dim filaSeleccionada As Integer = DgvContratos.CurrentRow.Index
        For Each row As DataGridViewRow In DgvContratos.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If Index = filaSeleccionada Then
                DgvContratos.Rows(Index).Cells("Seleccionar").Value = True
                TbPrecioQuintal.Text = DgvContratos.Rows(Index).Cells("PrecioQuintal").Value
                TbNoPacas.Text = DgvContratos.Rows(Index).Cells("Pacas").Value
                TbIdContrato.Text = DgvContratos.Rows(Index).Cells("IdCOntratoAlgodon").Value
            Else
                DgvContratos.Rows(Index).Cells("Seleccionar").Value = False
            End If
        Next
    End Sub
    Private Sub ConsultaCantidadPacas()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        Dim Tabla As New DataTable
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPacasCantidadDisponible
        EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        'TbPacasContratadas.Text = Tabla.Rows(0).Item("Disponibles")
        TbPacasDisp.Text = Tabla.Rows(0).Item("Disponibles")
        TbKilosComp.Text = Tabla.Rows(0).Item("Kilos Comprados")
        TbPacasComp.Text = Tabla.Rows(0).Item("Compradas")
    End Sub
    Private Sub DgvLiqCompradas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim filaSeleccionada As Integer = DgvLiqCompradas.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvLiqCompradas.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdLiquidacion As Integer
        IdLiquidacion = DgvLiqCompradas.Rows(filaSeleccionada).Cells("IdLiquidacion").Value
        For Each row As DataGridViewRow In DgvPacasIndCompradas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdLiquidacion").Value = IdLiquidacion And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdLiquidacion").Value = IdLiquidacion And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub DgvDatosLiquidacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatosLiquidacion.CellContentClick
        Dim filaSeleccionada As Integer = DgvDatosLiquidacion.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvDatosLiquidacion.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdLiquidacion As Integer
        IdLiquidacion = DgvDatosLiquidacion.Rows(filaSeleccionada).Cells("IdLiquidacion").Value
        For Each row As DataGridViewRow In DgvPacasComprar.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdLiquidacion").Value = IdLiquidacion And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdLiquidacion").Value = IdLiquidacion And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub MarcaSeleccionCompradas()
        Dim Contador As Integer = 0
        Dim Kilos As Integer = 0
        For i As Integer = 0 To DgvPacasIndCompradas.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvPacasIndCompradas.Rows(i).Cells("Seleccionar").EditedFormattedValue, Boolean)
            If Seleccion = True Then
                Contador = Contador + 1
                Kilos = Kilos + DgvPacasIndCompradas.Rows(i).Cells("Kilos").Value
            End If
        Next
        TbPacasMarc.Text = Contador
        TbKilosSeleccionados.Text = Kilos
    End Sub
    Private Sub MarcaSeleccionDisponibles()
        Dim Contador As Integer = 0
        Dim Kilos As Integer = 0
        For i As Integer = 0 To DgvPacasComprar.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvPacasComprar.Rows(i).Cells("Seleccionar").EditedFormattedValue, Boolean)
            If Seleccion = True Then
                Contador = Contador + 1
                Kilos = Kilos + DgvPacasComprar.Rows(i).Cells("Kilos").Value
            End If

        Next
        TbPacasMarc.Text = Contador
        TbKilosSeleccionados.Text = Kilos
    End Sub

    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click

    End Sub
    Private Sub CheckFalse()
        Dim Contador As Integer
        For Contador = 0 To DgvPacasComprar.RowCount - 1
            If DgvPacasComprar.Rows(Contador).Cells("Seleccionar").Value = Nothing Or DgvPacasComprar.Rows(Contador).Cells("Seleccionar").Value = True Then
                DgvPacasComprar.Rows(Contador).Cells("Seleccionar").Value = False
            End If
        Next Contador
    End Sub

    Private Sub CuentaPacasMarcadas(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Function Table() As DataTable
        Dim TablaRenglonAInsertar As DataRow
        For Each row As DataGridViewRow In DgvPacasComprar.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If DgvPacasComprar.Rows(Index).Cells("Seleccionar").EditedFormattedValue = True Then
                TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()
                TablaRenglonAInsertar("Grade") = DgvPacasComprar.Rows(Index).Cells("Grade").Value
                TablaRenglonAInsertar("Cantidad") = 1
                TablaRenglonAInsertar("Kilos") = DgvPacasComprar.Rows(Index).Cells("Kilos").Value
                TablaRenglonAInsertar("Quintales") = CDbl(DgvPacasComprar.Rows(Index).Cells("Kilos").Value / 46.02)
                TablaRenglonAInsertar("PrecioQuintal") = CDbl(TbPrecioQuintal.Text)
                TablaRenglonAInsertar("Total") = DgvPacasComprar.Rows(Index).Cells("Kilos").Value
                TablaRenglonAInsertar("TotalDlls") = Val(CDbl(DgvPacasComprar.Rows(Index).Cells("Kilos").Value / 46.02) * CDbl(TbPrecioQuintal.Text))
                TablaPacasAgrupadas.Rows.Add(TablaRenglonAInsertar)
            End If
        Next
        'Tabla = TablaModalidadCompra
        ''
        Dim query = From q In TablaPacasAgrupadas.AsEnumerable() Select q Order By q.Item("Grade")
        Dim dtResultado As New DataTable()
        dtResultado.Columns.Add("Grade")
        dtResultado.Columns.Add("Cantidad")
        dtResultado.Columns.Add("Kilos")
        dtResultado.Columns.Add("Quintales")
        dtResultado.Columns.Add("PrecioQuintal")
        dtResultado.Columns.Add("Total")
        dtResultado.Columns.Add("TotalDlls")
        ''
        Dim dtCopy = query.CopyToDataTable()
        dtCopy.Rows.Add()
        Dim dr As DataRow = dtCopy.NewRow()
        Dim i, value, TotalPacas As Integer
        Dim TotalQuintales, TotalDolares As Double
        For j As Integer = 0 To dtCopy.Rows.Count - 2
            Dim item = dtCopy.Rows(j)
            Dim Clase = Convert.ToString(item(0))
            Dim Cantidad = Convert.ToInt32(item(1))
            Dim Kilos = Convert.ToDouble(item(2))
            Dim Quintales = Convert.ToString(item(3))
            Dim TbPrecioQuintalQuintal = Convert.ToInt32(item(4))
            Dim Total = Convert.ToDouble(item(5))
            Dim TotalDlls = Convert.ToString(item(6))
            Dim drr As DataRow = dtResultado.NewRow()
            drr.Item(0) = Clase
            drr.Item(1) = Cantidad
            drr.Item(2) = Kilos
            drr.Item(3) = Quintales
            drr.Item(4) = TbPrecioQuintalQuintal
            drr.Item(5) = Total
            drr.Item(6) = TotalDlls
            dtResultado.ImportRow(item)
            Dim filaSig As String = Convert.ToString(dtCopy.Rows(i + 1).Item(0)) 'fila siguiente
            If (Clase = filaSig) Then 'clase actual es igual a la siguiente zona
                value += Kilos
                TotalPacas += Cantidad
            Else 'cuando cambie la clase insertar nueva fila y poner "Total" & Clase
                drr.Item(0) = "Total " & Clase
                drr.Item(1) = TotalPacas + Cantidad
                drr.Item(2) = value + Kilos
                drr.Item(3) = TotalQuintales + Quintales
                drr.Item(4) = ""
                drr.Item(5) = ""
                drr.Item(6) = TotalDlls + TotalDolares
                dtResultado.Rows.Add(drr)
                value = 0

                TotalPacas = 0
            End If
            i += 1 'indice
        Next
        Return dtResultado
    End Function
    Private Sub BtFiltro_Click(sender As Object, e As EventArgs) Handles BtFiltro.Click
        If TbIdProductor.Text = "" Then
            TbIdProductor.Text = ""
            MsgBox("Seleccionar a un productor para ver sus contratos", MsgBoxStyle.Exclamation)
        ElseIf (TbDesdePaca.Text <> "" And TbHastaPaca.Text <> "" And Val(TbDesdePaca.Text) < Val(TbHastaPaca.Text)) Or (TbHastaPaca.Text = "" And TbDesdePaca.Text = "" And CbClasesPacasAcomprar.Text <> "") Or (TbHastaPaca.Text = "" And TbDesdePaca.Text = "" And CbClasesPacasAcomprar.Text = "") Then
            filtraPacasClases()
        ElseIf (TbDesdePaca.Text > TbHastaPaca.Text) Or TbHastaPaca.Text = "" Or TbDesdePaca.Text = "" Then
            MsgBox("El Campo De Inicio no puede ser mayor al campo final o contener campos vacios")
        End If
    End Sub
    Private Sub BtFiltroCompra_Click(sender As Object, e As EventArgs) Handles BtFiltroCompra.Click

    End Sub
    Private Sub filtraPacasClases()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        '---Consultar las pacas ya clasificadas del productor
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPacaFiltro
        EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
        EntidadCompraPacasContrato.InicioPaca = IIf(TbDesdePaca.Text = "", 0, TbDesdePaca.Text)
        EntidadCompraPacasContrato.FinPaca = IIf(TbHastaPaca.Text = "", 0, TbHastaPaca.Text)
        EntidadCompraPacasContrato.Clase = CbClasesPacasAcomprar.Text
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        DgvPacasComprar.Columns.Clear()
        DgvPacasComprar.DataSource = Tabla
        PropiedadesDgvPacasComprar()

        '---Consultar pacas compradas
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPacaComprada
        EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        DgvPacasIndCompradas.Columns.Clear()
        DgvPacasIndCompradas.DataSource = Tabla

        ConsultaCantidadPacas()
        TotalPacasContrato()
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub BtReiniciaFiltro_Click(sender As Object, e As EventArgs) Handles BtReiniciaFiltro.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato

        If TbIdProductor.Text = "" Then
            TbIdProductor.Text = ""
            MsgBox("Seleccionar a un productor para ver sus contratos", MsgBoxStyle.Exclamation)
        Else
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPaca
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvPacasComprar.Columns.Clear()
            DgvPacasComprar.DataSource = Tabla

            PropiedadesDgvPacasComprar()
            TbDesdePaca.Text = ""
            TbHastaPaca.Text = ""
            CbClasesPacasAcomprar.SelectedValue = -1
            ConsultaCantidadPacas()
            TotalPacasContrato()
            MarcaSeleccionDisponibles()
        End If
    End Sub
End Class