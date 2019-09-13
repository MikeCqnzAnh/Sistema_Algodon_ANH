Imports Capa_Operacion.Configuracion
Public Class VentaPacasContrato
    Public TablaModalidadVenta As New DataTable
    Public TablacastigoMicros As New DataTable
    Public TablaCastigoLargoFibra As New DataTable
    Public TablaCastigoResistenciaFibra As New DataTable
    Public TablaPacasAgrupadas As New DataTable
    Private Sub BtModalidadVenta_Click(sender As Object, e As EventArgs) Handles BtModalidadVenta.Click
        ModalidadVenta.ShowDialog()
        TablaModalidadVenta = Tabla
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
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        If TbIdComprador.Text = "" Or TbPrecioQuintal.Text = "" Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        Else
            VarGlob2.IdProductor = TbIdComprador.Text
            VarGlob2.NombreProductor = TbNombreComprador.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text
            _Tabla = Table()
            VentaPago.ShowDialog()
        End If
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
    Private Sub VentaPacasContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaPacasAgrupadas.Columns.Clear()
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Clase", System.Type.GetType("System.String")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Cantidad", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Kilos", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Quintales", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioQuintal", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Total", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("TotalDlls", System.Type.GetType("System.Double")))
        CargarCombos()
        Nuevo()
    End Sub
    Private Sub Nuevo()
        TbIdVentaPaca.Text = ""
        TbIdComprador.Text = ""
        TbNombreComprador.Text = ""
        CbPlanta.SelectedValue = 1
        TbDesdePaca.Text = ""
        TbHastaPaca.Text = ""
        TbIdContrato.Text = ""
        TbPrecioQuintal.Text = ""
        TbNoPacas.Text = ""
        DgvContratos.DataSource = Nothing
        DgvDatosLiquidacion.DataSource = Nothing
        DgvLiqVendidas.DataSource = Nothing
        DgvPacasVender.DataSource = Nothing
        DgvPacasIndVendidas.DataSource = Nothing
        DgvAgrupadasCliente.DataSource = Nothing
        DgvAgrupadasClases.DataSource = Nothing
        DgvContratos.Columns.Clear()
        DgvDatosLiquidacion.Columns.Clear()
        DgvLiqVendidas.Columns.Clear()
        DgvPacasVender.Columns.Clear()
        DgvPacasIndVendidas.Columns.Clear()
        DgvAgrupadasCliente.Columns.Clear()
        DgvAgrupadasClases.Columns.Clear()
        TbPacasContratadas.Text = ""
        TbPacasDisp.Text = ""
        TbPacasCompCont.Text = ""
        TbPacasMarc.Text = ""
        TbPacasComp.Text = ""
        TbKilosComp.Text = ""
        TablaModalidadVenta.Clear()
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
        '---Modalidad De Venta--
        'Dim Tabla2 As New DataTable
        'EntidadProduccion.Consulta = Consulta.ConsultaModoVenta
        'NegocioProduccion.Consultar(EntidadProduccion)
        'Tabla2 = EntidadProduccion.TablaConsulta
        'CbModalidadVenta.DataSource = Tabla2
        'CbModalidadVenta.ValueMember = "IdModoEncabezado"
        'CbModalidadVenta.DisplayMember = "Descripcion"
        'CbModalidadVenta.SelectedValue = 11
    End Sub
    Private Sub BtnBuscarProd_Click(sender As Object, e As EventArgs) Handles BtnBuscarProd.Click
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        ConsultaCompradores.ShowDialog()
        TbIdComprador.Text = _Id
        TbNombreComprador.Text = _Nombre
        'TbAsociacion.Text = _Dato
        If TbIdComprador.Text = 0 Then
            TbIdComprador.Text = ""
            MsgBox("Seleccionar a un productor para ver sus contratos", MsgBoxStyle.Exclamation)
        Else
            '---Consultar contratos del productor---
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPorId
            EntidadVentaPacasContrato.IdComprador = CInt(TbIdComprador.Text)
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            DgvContratos.Columns.Clear()
            DgvContratos.DataSource = Tabla
            If DgvContratos.RowCount > 0 Then
                Dim colSelCon As New DataGridViewCheckBoxColumn()
                colSelCon.Name = "Seleccionar"
                colSelCon.FalseValue = False
                colSelCon.Visible = True
                DgvContratos.Columns.Insert(4, colSelCon)
            End If
            '---Consultar liquidaciones del productor
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaLiquidaciones
            EntidadVentaPacasContrato.IdProductor = CInt(TbIdComprador.Text)
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            DgvDatosLiquidacion.Columns.Clear()
            DgvDatosLiquidacion.DataSource = Tabla
            'Dim colSelLiq As New DataGridViewCheckBoxColumn()
            'colSelLiq.Name = "Seleccionar"
            'colSelLiq.FalseValue = False
            'colSelLiq.Visible = True
            'DgvDatosLiquidacion.Columns.Insert(6, colSelLiq)
            'PropiedadesDgvLiquidacionesVender()
            '---Consultar las pacas ya clasificadas del productor
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPaca
            EntidadVentaPacasContrato.IdProductor = CInt(TbIdComprador.Text)
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            DgvPacasVender.Columns.Clear()
            DgvPacasVender.DataSource = Tabla
            'Dim colSelPac As New DataGridViewCheckBoxColumn()
            'colSelPac.Name = "Seleccionar"
            'colSelPac.FalseValue = False
            'colSelPac.Visible = True
            'DgvPacasVender.Columns.Insert(7, colSelPac)
            'PropiedadesDgvPacasVender()
        End If
    End Sub
    Private Sub PropiedadesDgvPacasVender()
        DgvPacasVender.Columns("IdOrdenTrabajo").ReadOnly = True
        DgvPacasVender.Columns("IdLiquidacion").ReadOnly = True
        DgvPacasVender.Columns("Descripcion").ReadOnly = True
        DgvPacasVender.Columns("BaleId").ReadOnly = True
        DgvPacasVender.Columns("FolioCIA").ReadOnly = True
        DgvPacasVender.Columns("Kilos").ReadOnly = True
        DgvPacasVender.Columns("Clase").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvLiquidacionesVender()
        DgvDatosLiquidacion.Columns("IdLiquidacion").ReadOnly = True
        DgvDatosLiquidacion.Columns("Cliente").ReadOnly = True
        DgvDatosLiquidacion.Columns("Fecha").ReadOnly = True
        DgvDatosLiquidacion.Columns("Comentarios").ReadOnly = True
        DgvDatosLiquidacion.Columns("TotalPacas").ReadOnly = True
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
    Private Sub CheckFalse()
        Dim Contador As Integer
        For Contador = 0 To DgvPacasVender.RowCount - 1
            If DgvPacasVender.Rows(Contador).Cells("Seleccionar").Value = Nothing Or DgvPacasVender.Rows(Contador).Cells("Seleccionar").Value = True Then
                DgvPacasVender.Rows(Contador).Cells("Seleccionar").Value = False
            End If
        Next Contador
    End Sub
    Private Function Table() As DataTable
        Dim TablaRenglonAInsertar As DataRow
        For Each row As DataGridViewRow In DgvPacasVender.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()
            TablaRenglonAInsertar("Clase") = DgvPacasVender.Rows(Index).Cells("Clase").Value
            TablaRenglonAInsertar("Cantidad") = 1
            TablaRenglonAInsertar("Kilos") = DgvPacasVender.Rows(Index).Cells("Kilos").Value
            TablaRenglonAInsertar("Quintales") = CDbl(DgvPacasVender.Rows(Index).Cells("Kilos").Value / 46.02)
            TablaRenglonAInsertar("PrecioQuintal") = CDbl(TbPrecioQuintal.Text)
            TablaRenglonAInsertar("Total") = DgvPacasVender.Rows(Index).Cells("Kilos").Value
            TablaRenglonAInsertar("TotalDlls") = Val(CDbl(DgvPacasVender.Rows(Index).Cells("Kilos").Value / 46.02) * CDbl(TbPrecioQuintal.Text))
            TablaPacasAgrupadas.Rows.Add(TablaRenglonAInsertar)
        Next
        'Tabla = TablaModalidadVenta
        ''
        Dim query = From q In TablaPacasAgrupadas.AsEnumerable() Select q Order By q.Item("Clase")
        Dim dtResultado As New DataTable()
        dtResultado.Columns.Add("Clase")
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
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        If TbIdComprador.Text = "" Or TbPrecioQuintal.Text = "" Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        ElseIf ValidaChecksPacas() > 0 Then
            If TbIdVentaPaca.Text = "" Then GuardarVentaEnc()
            EntidadVentaPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarVentaPacasDet
            EntidadVentaPacasContrato.TablaGeneral = DataGridADatatable(2, 1, DgvPacasVender, TbIdVentaPaca.Text)
            NegocioVentaPacasContrato.Guardar(EntidadVentaPacasContrato)

            filtraPacasClases()
            VarGlob2.IdProductor = TbIdComprador.Text
            VarGlob2.NombreProductor = TbNombreComprador.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text

            '_Tabla = Table()
            'CompraPago.ShowDialog()
            'ConsultaCompra()
            consultaDatosdgv()
        Else
            MessageBox.Show("No hay pacas seleccionadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function ValidaChecksPacas()
        'TablaPacasAgrupadas.Rows.Clear()
        'Dim TablaRenglonAInsertar As DataRow
        Dim PacasMarcadas As Integer = 0
        For i As Integer = 0 To DgvPacasVender.Rows.Count - 1
            If DgvPacasVender.Rows(i).Cells("Seleccionar").EditedFormattedValue = True Then
                PacasMarcadas = PacasMarcadas + 1
                'TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()
                'TablaRenglonAInsertar("Grade") = DgvPacasComprar.Rows(i).Cells("Grade").Value
                'TablaRenglonAInsertar("Cantidad") = 1
                'TablaRenglonAInsertar("Kilos") = DgvPacasComprar.Rows(i).Cells("Kilos").Value
                'TablaRenglonAInsertar("Quintales") = CDbl(DgvPacasComprar.Rows(i).Cells("Kilos").Value / 46.02)
                'TablaRenglonAInsertar("CastigoResistenciaFibra") = ConsultaCastigoResistenciaFibra(DgvPacasComprar.Rows(i).Cells(8).Value)
                'TablaRenglonAInsertar("CastigoMicros") = ConsultaCastigoMicros(DgvPacasComprar.Rows(i).Cells(7).Value)
                'TablaRenglonAInsertar("CastigoLargoFibra") = ConsultaCastigoLargoFibra(DgvPacasComprar.Rows(i).Cells(9).Value)
                'TablaRenglonAInsertar("PrecioQuintal") = CDbl(TbPrecioQuintal.Text)
                'TablaRenglonAInsertar("Total") = DgvPacasComprar.Rows(i).Cells("Kilos").Value
                'TablaRenglonAInsertar("TotalDlls") = Val(CDbl(DgvPacasComprar.Rows(i).Cells("Kilos").Value / 46.02) * CDbl(TbPrecioQuintal.Text))
                'TablaPacasAgrupadas.Rows.Add(TablaRenglonAInsertar)
            End If
        Next
        Return PacasMarcadas
    End Function
    Private Sub GuardarVentaEnc()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        EntidadVentaPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarVentaPacasEnc
        EntidadVentaPacasContrato.IdVenta = IIf(TbIdVentaPaca.Text = "", 0, TbIdVentaPaca.Text)
        EntidadVentaPacasContrato.IdContrato = TbIdContrato.Text
        EntidadVentaPacasContrato.IdComprador = TbIdComprador.Text
        EntidadVentaPacasContrato.IdPlanta = CbPlanta.SelectedValue
        'EntidadVentaPacasContrato.IdModalidadVenta = cbm.SelectedValue
        EntidadVentaPacasContrato.FechaVenta = DtpFecha.Value
        EntidadVentaPacasContrato.TotalPacas = 0
        EntidadVentaPacasContrato.Observaciones = ""
        EntidadVentaPacasContrato.CastigoMicros = 0
        EntidadVentaPacasContrato.CastigoLargoFibra = 0
        EntidadVentaPacasContrato.CastigoResistenciaFibra = 0
        EntidadVentaPacasContrato.InteresPesosMx = 0
        EntidadVentaPacasContrato.InteresDlls = 0
        EntidadVentaPacasContrato.PrecioQuintal = 0
        EntidadVentaPacasContrato.PrecioQuintalBorregos = 0
        EntidadVentaPacasContrato.PrecioDolar = 0
        EntidadVentaPacasContrato.SubTotal = 0
        EntidadVentaPacasContrato.CastigoDls = 0
        EntidadVentaPacasContrato.AnticipoDls = 0
        EntidadVentaPacasContrato.TotalDlls = 0
        EntidadVentaPacasContrato.TotalPesosMx = 0
        EntidadVentaPacasContrato.IdEstatusVenta = 0
        NegocioVentaPacasContrato.Guardar(EntidadVentaPacasContrato)
        TbIdVentaPaca.Text = EntidadVentaPacasContrato.IdVenta
    End Sub
    Private Function DataGridADatatable(ByVal EstatusVentaUpdate As Integer, ByVal EstatusVentaBusqueda As Integer, ByVal DataGridEnvia As DataGridView, ByVal IdVentaEnc As Integer, Optional valcastigo As Integer = 0) As DataTable
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Add("IdComprador", Type.GetType("System.Int32"))
        dt.Columns.Add("BaleID", Type.GetType("System.Int32"))
        dt.Columns.Add("IdLiquidacion", Type.GetType("System.Int32"))
        dt.Columns.Add("IdVentaEnc", Type.GetType("System.Int32"))
        dt.Columns.Add("CastigoResistenciaFibra", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoMicros", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoLargoFibra", Type.GetType("System.Single"))
        dt.Columns.Add("EstatusVentaUpdate", Type.GetType("System.Int32"))
        dt.Columns.Add("EstatusVentaBusqueda", Type.GetType("System.Int32"))

        For i = 0 To DataGridEnvia.Rows.Count - 1
            r = dt.NewRow
            If DataGridEnvia.Item("Seleccionar", i).EditedFormattedValue = True Then
                Dim Quintales As Double = Math.Round(CDbl(DataGridEnvia.Item("Kilos", i).Value) / 46.02, 2)
                r("IdComprador") = TbIdComprador.Text
                r("BaleID") = DataGridEnvia.Item("BaleID", i).Value.ToString
                r("IdLiquidacion") = DataGridEnvia.Item("IdLiquidacion", i).Value.ToString
                r("IdCompraEnc") = IdVentaEnc
                r("CastigoResistenciaFibra") = IIf(valcastigo = 0, ConsultaCastigoResistenciaFibra(DataGridEnvia.Item(8, i).Value.ToString, Quintales), 0)
                r("CastigoMicros") = IIf(valcastigo = 0, ConsultaCastigoMicros(DataGridEnvia.Item(7, i).Value.ToString, Quintales), 0)
                r("CastigoLargoFibra") = IIf(valcastigo = 0, ConsultaCastigoLargoFibra(DataGridEnvia.Item(9, i).Value.ToString, Quintales), 0)
                r("EstatusVentaUpdate") = EstatusVentaUpdate
                r("EstatusVentaBusqueda") = EstatusVentaBusqueda
                dt.Rows.Add(r)
            End If
        Next
        Return dt
    End Function
    Private Sub filtraPacasClases()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        '---Consultar las pacas ya clasificadas del productor
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPacaFiltro
        EntidadVentaPacasContrato.IdComprador = CInt(TbIdComprador.Text)
        EntidadVentaPacasContrato.InicioPaca = IIf(TbDesdePaca.Text = "", 0, TbDesdePaca.Text)
        EntidadVentaPacasContrato.FinPaca = IIf(TbHastaPaca.Text = "", 0, TbHastaPaca.Text)
        EntidadVentaPacasContrato.Clase = CbClasesPacasAcomprar.Text
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        Tabla = EntidadVentaPacasContrato.TablaConsulta
        DgvPacasVender.Columns.Clear()
        DgvPacasVender.DataSource = Tabla
        PropiedadesDgvPacasComprar()

        '---Consultar pacas compradas
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPacaComprada
        EntidadVentaPacasContrato.IdVenta = CInt(TbIdVentaPaca.Text)
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        Tabla = EntidadVentaPacasContrato.TablaConsulta
        DgvPacasIndVendidas.Columns.Clear()
        DgvPacasIndVendidas.DataSource = Tabla
        PropiedadesDgvPacasIndCompradas()
        ConsultaCantidadPacas()
        TotalPacasContrato()
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub consultaDatosdgv()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        If TbIdComprador.Text = 0 Then
            TbIdComprador.Text = ""
            MsgBox("Seleccionar a un productor para ver sus contratos", MsgBoxStyle.Exclamation)
        Else
            '---Consultar contratos del productor---
            'EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPorId
            'EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            'NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            'Tabla = EntidadCompraPacasContrato.TablaConsulta
            'DgvContratos.Columns.Clear()
            'DgvContratos.DataSource = Tabla
            'Dim colSelCon As New DataGridViewCheckBoxColumn()
            'colSelCon.Name = "Seleccionar"
            'colSelCon.FalseValue = False
            'colSelCon.Visible = True
            'DgvContratos.Columns.Insert(5, colSelCon)
            '---Consultar liquidaciones del productor con compras
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaLiquidacionesVentas
            EntidadVentaPacasContrato.IdComprador = CInt(TbIdComprador.Text)
            EntidadVentaPacasContrato.IdVenta = CInt(IIf(TbIdVentaPaca.Text = "", 0, TbIdVentaPaca.Text))
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            DgvLiqVendidas.Columns.Clear()
            DgvLiqVendidas.DataSource = Tabla
            PropiedadesDgvLiquidacionesCompradas()
            '---Consultar liquidaciones del productor
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaLiquidaciones
            EntidadVentaPacasContrato.IdProductor = CInt(TbIdComprador.Text)
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            DgvDatosLiquidacion.Columns.Clear()
            DgvDatosLiquidacion.DataSource = Tabla
            'Dim colSelLiq As New DataGridViewCheckBoxColumn()
            'colSelLiq.Name = "Seleccionar"
            'colSelLiq.FalseValue = False
            'colSelLiq.Visible = True
            'DgvDatosLiquidacion.Columns.Insert(6, colSelLiq)
            PropiedadesDgvLiquidacionesComprar()

            '---Consultar pacas compradas
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPacaComprada
            EntidadVentaPacasContrato.IdComprador = CInt(TbIdComprador.Text)
            EntidadVentaPacasContrato.IdVenta = CInt(IIf(TbIdVentaPaca.Text = "", 0, TbIdVentaPaca.Text))
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            DgvPacasIndVendidas.Columns.Clear()
            DgvPacasIndVendidas.DataSource = Tabla
            PropiedadesDgvPacasIndCompradas()
            '---Consultar las pacas ya clasificadas del productor
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPaca
            EntidadVentaPacasContrato.IdComprador = CInt(TbIdComprador.Text)
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            DgvPacasVender.Columns.Clear()
            DgvPacasVender.DataSource = Tabla

            'ConsultaCompra()

            PropiedadesDgvPacasComprar()
            ConsultaCantidadPacas()
            TotalPacasContrato()
            MarcaSeleccionDisponibles()
        End If
    End Sub
    Private Function ConsultaCastigoMicros(ByVal ValMicros As Double, ByVal Quintales As Double)
        Dim Castigo As Double
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoMicros
        EntidadCompraPacasContrato.CastigoMicros = Math.Round(ValMicros, 2)
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 2)
        Return Castigo
    End Function
    Private Function ConsultaCastigoResistenciaFibra(ByVal ValResistenciaFibra As Double, ByVal Quintales As Double)
        Dim Castigo As Double
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoResistenciaFibra
        EntidadCompraPacasContrato.CastigoResistenciaFibra = Math.Round(ValResistenciaFibra, 2)
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 2)
        Return Castigo
    End Function
    Private Function ConsultaCastigoLargoFibra(ByVal ValLargoFibra As Double, ByVal Quintales As Double)
        Dim Castigo As Double
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoLargoFibra
        EntidadCompraPacasContrato.CastigoLargoFibra = Math.Round(ValLargoFibra, 2)
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 2)
        Return Castigo
    End Function
    Private Sub PropiedadesDgvPacasComprar()
        'DgvPacasVender.Columns("IdOrdenTrabajo").Visible = False
        'DgvPacasVender.Columns("IdLiquidacion").Visible = True
        'DgvPacasVender.Columns("Descripcion").ReadOnly = True
        'DgvPacasVender.Columns("BaleId").ReadOnly = True
        'DgvPacasVender.Columns("FolioCIA").Visible = False
        'DgvPacasVender.Columns("Descripcion").Visible = False
        'DgvPacasVender.Columns("Kilos").ReadOnly = True
        'DgvPacasVender.Columns("Grade").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvLiquidacionesCompradas()
        'DgvLiqVendidas.Columns("IdLiquidacion").ReadOnly = True
        'DgvLiqVendidas.Columns("TotalHueso").Visible = False
        'DgvLiqVendidas.Columns("PacasCantidad").ReadOnly = True
        'DgvLiqVendidas.Columns("PacasDisponibles").Visible = False
        'DgvLiqVendidas.Columns("PacasCompradas").ReadOnly = True
        'DgvLiqVendidas.Columns("PesoPluma").Visible = False
        'DgvLiqVendidas.Columns("TotalSemilla").Visible = False
        'DgvLiqVendidas.Columns("Seleccionar").ReadOnly = False
    End Sub
    Private Sub PropiedadesDgvLiquidacionesComprar()
        'DgvDatosLiquidacion.Columns("IdLiquidacion").ReadOnly = True
        'DgvDatosLiquidacion.Columns("TotalHueso").ReadOnly = True
        'DgvDatosLiquidacion.Columns("PacasCantidad").ReadOnly = True
        'DgvDatosLiquidacion.Columns("PacasDisponibles").ReadOnly = True
        'DgvDatosLiquidacion.Columns("PacasCompradas").ReadOnly = True
        'DgvDatosLiquidacion.Columns("PesoPluma").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvContratos()
        'DgvContratos.Columns("IdContratoAlgodon").ReadOnly = True
        'DgvContratos.Columns("Pacas").ReadOnly = True
        'DgvContratos.Columns("SuperficieComprometida").ReadOnly = True
        'DgvContratos.Columns("PrecioQuintal").ReadOnly = True
        'DgvContratos.Columns("Fecha").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvPacasIndCompradas()
        'DgvPacasIndVendidas.Columns("BaleID").Visible = False
        'DgvPacasIndVendidas.Columns("CastigoResistenciaFibraCompra").Visible = False
        'DgvPacasIndVendidas.Columns("CastigoMicCompra").Visible = False
        'DgvPacasIndVendidas.Columns("CastigoLargoFibraCompra").Visible = False
    End Sub
    Private Sub ConsultaCantidadPacas()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        Dim Tabla As New DataTable
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPacasCantidadDisponible
        EntidadVentaPacasContrato.IdComprador = CInt(TbIdComprador.Text)
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        Tabla = EntidadVentaPacasContrato.TablaConsulta
        'TbPacasContratadas.Text = Tabla.Rows(0).Item("Disponibles")
        TbPacasDisp.Text = Tabla.Rows(0).Item("Disponibles")
        TbKilosComp.Text = Tabla.Rows(0).Item("Kilos Comprados")
        TbPacasComp.Text = Tabla.Rows(0).Item("Compradas")
    End Sub
    Private Sub TotalPacasContrato()
        Dim Pacas As Integer = 0
        For i As Integer = 0 To DgvContratos.Rows.Count - 1
            Pacas += DgvContratos.Rows(i).Cells("Pacas").Value
        Next
        TbPacasContratadas.Text = Pacas
        TbPacasCompCont.Text = Val(TbPacasContratadas.Text) - Val(TbPacasComp.Text)
    End Sub
    Private Sub MarcaSeleccionDisponibles()
        Dim Contador As Integer = 0
        Dim Kilos As Integer = 0
        For i As Integer = 0 To DgvPacasVender.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvPacasVender.Rows(i).Cells("Seleccionar").EditedFormattedValue, Boolean)
            If Seleccion = True Then
                Contador = Contador + 1
                Kilos = Kilos + DgvPacasVender.Rows(i).Cells("Kilos").Value
            End If
        Next
        TbPacasMarc.Text = Contador
        TbKilosSeleccionados.Text = Kilos
    End Sub
    Private Sub DgvLiqVendidas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLiqVendidas.CellContentClick
        Dim filaSeleccionada As Integer = DgvLiqVendidas.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvLiqVendidas.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdLiquidacion As Integer
        IdLiquidacion = DgvLiqVendidas.Rows(filaSeleccionada).Cells("IdLiquidacion").Value
        For Each row As DataGridViewRow In DgvLiqVendidas.Rows
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
        For Each row As DataGridViewRow In DgvPacasVender.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdLiquidacion").Value = IdLiquidacion And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdLiquidacion").Value = IdLiquidacion And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub
End Class