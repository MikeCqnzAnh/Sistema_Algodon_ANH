Imports Capa_Operacion.Configuracion
Public Class VentaPacasContrato
    Implements IForm1
    Public TablaModalidadVenta, TablacastigoMicros, TablaCastigoLargoFibra, TablaCastigoResistenciaFibra, TablaPacasAgrupadas As New DataTable
    Private PrecioSM, PrecioMP, PrecioM, PrecioSLMP, PrecioSLM, PrecioLMP, PrecioLM, PrecioSGO, PrecioGO, PrecioO As Double
    Private Sub VentaPacasContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearTablaPacasAgrupadas()
        CargarCombos()
        Nuevo()
    End Sub
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
    Private Sub CrearTablaPacasAgrupadas()
        TablaPacasAgrupadas.Columns.Clear()
        TablaPacasAgrupadas.Columns.Add(New DataColumn("BaleID", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Grade", System.Type.GetType("System.String")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Cantidad", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Kilos", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Quintales", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("TipoCambio", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioMxn", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoUniformidad", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoResistenciaFibra", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoMicros", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoLargoFibra", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioClase", System.Type.GetType("System.Single")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Total", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("TotalDlls", System.Type.GetType("System.Double")))
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        If TbIdComprador.Text = "" Or TbPrecioQuintal.Text = "" Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        Else
            VarGlob2.IdVenta = TbIdVentaPaca.Text
            VarGlob2.IdContrato = TbIdContrato.Text
            VarGlob2.IdComprador = TbIdComprador.Text
            VarGlob2.NombreComprador = TbNombreComprador.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text
            VarGlob2.IdModalidadVenta = CbModalidadVenta.SelectedValue
            VarGlob2.IdUnidadPeso = CbUnidadPeso.SelectedValue
            VarGlob2.ValorConversion = Val(TbValorConversion.Text)
            _Tabla = Table()
            VentaPago.ShowDialog()
        End If
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim _ConsultaVenta As New ConsultaVentas

        _ConsultaVenta.MdiParent = Me.MdiParent
        _ConsultaVenta.Opener = CType(Me, IForm1)

        _ConsultaVenta.ShowDialog()
        ConsultarDatosVenta()
    End Sub
    Public Function LoadIdVenta(ByVal DatatableParam As DataTable) As Boolean Implements IForm1.LoadIdVenta
        For Each row As DataRow In DatatableParam.Rows

            TbIdVentaPaca.Text = row("IdVenta")
            TbIdComprador.Text = row("IdComprador")
            TbNombreComprador.Text = row("Nombre")
        Next

        Return True
    End Function
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub Nuevo()
        TbIdVentaPaca.Text = ""
        TbIdComprador.Text = 0
        CbUnidadPeso.SelectedIndex = -1
        CbModalidadVenta.SelectedIndex = -1
        TbNombreComprador.Text = ""
        TbValorConversion.Text = 0
        CbPlanta.SelectedValue = 1
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
        CkKgAdd.Checked = False
        TbKdAd.Text = 0
        TbKdAd.Visible = False
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
        '-------------------------COMBO UNIDAD PESO
        LLenaComboInstancias(CbClasesVendidas)
        LLenaComboInstancias(CbClasesPacasAVender)
        Dim Tabla1 As New DataTable
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaUnidadPeso
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla1 = EntidadContratosAlgodon.TablaConsulta
        CbUnidadPeso.DataSource = Tabla1
        CbUnidadPeso.ValueMember = "IdUnidadPeso"
        CbUnidadPeso.DisplayMember = "Descripcion"
        CbUnidadPeso.SelectedValue = -1
        '------------------------
        Dim Tabla2 As New DataTable
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaExterna
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla2 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModalidadVenta.DataSource = Tabla2
        CbModalidadVenta.ValueMember = "IdModoEncabezado"
        CbModalidadVenta.DisplayMember = "Descripcion"
        CbModalidadVenta.SelectedValue = 1
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
        Dim _ConsultaCompradores As New ConsultaCompradores
        _ConsultaCompradores.MdiParent = Me.MdiParent
        _ConsultaCompradores.Opener = CType(Me, IForm1)
        _ConsultaCompradores.ShowDialog()
        ConsultaDatosCompra()
    End Sub
    Public Function LoadIdComprador(ByVal DatatableParam As DataTable) As Boolean Implements IForm1.LoadIdComprador
        For Each row As DataRow In DatatableParam.Rows
            TbIdComprador.Text = row("IdComprador")
            TbNombreComprador.Text = row("Nombre")
        Next
        Return True
    End Function
    Private Sub ConsultaDatosCompra()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        If TbIdComprador.Text = 0 Then
            'TbIdComprador.Text = ""
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
                DgvContratos.Columns.Insert(23, colSelCon)
            End If
            PropiedadesDgvContratos()
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
            PropiedadesDgvLiquidacionesVender()
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
            PropiedadesDgvPacasVender()
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
        Dim filaSeleccionada As Integer = DgvContratos.CurrentRow.Index
        Dim countcheck As Integer = 0
        For Each row As DataGridViewRow In DgvContratos.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If Index = filaSeleccionada And DgvContratos.Rows(Index).Cells("Seleccionar").Value = False Then
                DgvContratos.Rows(Index).Cells("Seleccionar").Value = True
                TbPrecioQuintal.Text = -1 * DgvContratos.Rows(Index).Cells("PrecioSM").Value
                TbNoPacas.Text = DgvContratos.Rows(Index).Cells("Pacas").Value
                TbIdContrato.Text = DgvContratos.Rows(Index).Cells("IdCOntratoAlgodon").Value
                CbModalidadVenta.SelectedValue = DgvContratos.Rows(Index).Cells("IdModalidadVenta").Value
                CbUnidadPeso.SelectedValue = DgvContratos.Rows(Index).Cells("IdUnidadPeso").Value
                TbValorConversion.Text = DgvContratos.Rows(Index).Cells("ValorConversion").Value
                PrecioSM = -1 * DgvContratos.Rows(Index).Cells("PrecioSM").Value
                PrecioMP = -1 * DgvContratos.Rows(Index).Cells("PrecioMP").Value
                PrecioM = -1 * DgvContratos.Rows(Index).Cells("PrecioM").Value
                PrecioSLMP = -1 * DgvContratos.Rows(Index).Cells("PrecioSLMP").Value
                PrecioSLM = -1 * DgvContratos.Rows(Index).Cells("PrecioSLM").Value
                PrecioLMP = -1 * DgvContratos.Rows(Index).Cells("PrecioLMP").Value
                PrecioLM = -1 * DgvContratos.Rows(Index).Cells("PrecioLM").Value
                PrecioSGO = -1 * DgvContratos.Rows(Index).Cells("PrecioSGO").Value
                PrecioGO = -1 * DgvContratos.Rows(Index).Cells("PrecioGO").Value
                PrecioO = -1 * DgvContratos.Rows(Index).Cells("PrecioO").Value
            Else
                DgvContratos.Rows(Index).Cells("Seleccionar").Value = False
            End If
            If DgvContratos.Rows(Index).Cells("seleccionar").Value = True Then countcheck = countcheck + 1
        Next
        If countcheck = 0 Then
            TbPrecioQuintal.Text = ""
            TbNoPacas.Text = ""
            TbIdContrato.Text = ""
            TbValorConversion.Text = ""
            CbUnidadPeso.SelectedValue = -1
            CbModalidadVenta.SelectedValue = -1
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
        End If
        'Dim filaSeleccionada As Integer = DgvContratos.CurrentRow.Index
        'Dim countcheck As Integer = 0
        'For Each row As DataGridViewRow In DgvContratos.Rows
        '    Dim Index As Integer = Convert.ToUInt64(row.Index)
        '    If Index = filaSeleccionada And DgvContratos.Rows(Index).Cells("Seleccionar").Value = False Then
        '        DgvContratos.Rows(Index).Cells("Seleccionar").Value = True
        '        TbPrecioQuintal.Text = DgvContratos.Rows(Index).Cells("PrecioQuintal").Value
        '        TbNoPacas.Text = DgvContratos.Rows(Index).Cells("Pacas").Value
        '        TbIdContrato.Text = DgvContratos.Rows(Index).Cells("IdCOntratoAlgodon").Value
        '    Else
        '        DgvContratos.Rows(Index).Cells("Seleccionar").Value = False
        '    End If
        '    If DgvContratos.Rows(Index).Cells("seleccionar").Value = True Then countcheck = countcheck + 1
        'Next
        'If countcheck = 0 Then
        '    TbPrecioQuintal.Text = ""
        '    TbNoPacas.Text = ""
        '    TbIdContrato.Text = ""
        'End If
    End Sub
    'Private Sub CheckFalse()
    '    Dim Contador As Integer
    '    For Contador = 0 To DgvPacasVender.RowCount - 1
    '        If DgvPacasVender.Rows(Contador).Cells("Seleccionar").Value = Nothing Or DgvPacasVender.Rows(Contador).Cells("Seleccionar").Value = True Then
    '            DgvPacasVender.Rows(Contador).Cells("Seleccionar").Value = False
    '        End If
    '    Next Contador
    'End Sub
    Private Function Table() As DataTable
        Dim TablaRenglonAInsertar As DataRow
        TablaPacasAgrupadas.Rows.Clear()

        For ii As Integer = 0 To DgvPacasIndVendidas.Rows.Count - 1
            'If ValidaChecksDgv() = True Then
            Dim Quintales As Double = Math.Round(CDbl(DgvPacasIndVendidas.Rows(ii).Cells("Kilos").Value) / 46.02, 2)
            Dim TotalDlls As Double = Quintales * CDbl(TbPrecioQuintal.Text)

            TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()

            TablaRenglonAInsertar("BaleID") = DgvPacasIndVendidas.Rows(ii).Cells("BaleID").Value
            TablaRenglonAInsertar("Grade") = DgvPacasIndVendidas.Rows(ii).Cells("Grade").Value
            TablaRenglonAInsertar("Cantidad") = 1
            TablaRenglonAInsertar("Kilos") = DgvPacasIndVendidas.Rows(ii).Cells("Kilos").Value
            TablaRenglonAInsertar("Quintales") = Math.Round(Quintales, 4)
            TablaRenglonAInsertar("TipoCambio") = 0 'Math.Round((DgvPacasIndCompradas.Rows(ii).Cells(7).Value * Quintales), 4)
            TablaRenglonAInsertar("PrecioMxn") = 0 'Math.Round((DgvPacasIndCompradas.Rows(ii).Cells(9).Value * Quintales), 4)
            TablaRenglonAInsertar("CastigoUniformidad") = Math.Round(DgvPacasIndVendidas.Rows(ii).Cells("CastigoUIVenta").Value, 2)
            TablaRenglonAInsertar("CastigoResistenciaFibra") = Math.Round(DgvPacasIndVendidas.Rows(ii).Cells("CastigoResistenciaFibraVenta").Value, 2)
            TablaRenglonAInsertar("CastigoMicros") = Math.Round(DgvPacasIndVendidas.Rows(ii).Cells("castigoMicVenta").Value, 2)
            TablaRenglonAInsertar("CastigoLargoFibra") = Math.Round(DgvPacasIndVendidas.Rows(ii).Cells("CastigoLargoFibraVenta").Value, 2)
            TablaRenglonAInsertar("PrecioClase") = DgvPacasIndVendidas.Rows(ii).Cells("PrecioClase").Value
            TablaRenglonAInsertar("Total") = 0 'DgvPacasIndCompradas.Rows(ii).Cells("Kilos").Value
            TablaRenglonAInsertar("TotalDlls") = Math.Truncate(DgvPacasIndVendidas.Rows(ii).Cells("PrecioDls").Value * 10000) / 10000
            TablaPacasAgrupadas.Rows.Add(TablaRenglonAInsertar)

        Next
        Tabla = TablaModalidadVenta

        Dim query = From q In TablaPacasAgrupadas.AsEnumerable() Select q Order By q.Item("Grade")
        Dim dtResultado As New DataTable()
        dtResultado.Columns.Add("BaleID")
        dtResultado.Columns.Add("Grade")
        dtResultado.Columns.Add("Cantidad")
        dtResultado.Columns.Add("Kilos")
        dtResultado.Columns.Add("Quintales")
        dtResultado.Columns.Add("TipoCambio")
        dtResultado.Columns.Add("PrecioMxn")
        dtResultado.Columns.Add("CastigoUniformidad")
        dtResultado.Columns.Add("CastigoResistenciaFibra")
        dtResultado.Columns.Add("CastigoMicros")
        dtResultado.Columns.Add("CastigoLargoFibra")
        dtResultado.Columns.Add("PrecioClase")
        dtResultado.Columns.Add("Total")
        dtResultado.Columns.Add("TotalDlls")
        ''
        Dim dtCopy = query.CopyToDataTable()
        dtCopy.Rows.Add()
        Dim dr As DataRow = dtCopy.NewRow()
        Dim i, value, TotalPacas As Integer
        Dim TotalQuintales, TotalDolares, TotalCastigoLF, TotalCastigoM, TotalCastigoRF, TotalCastigoUI As Double
        For j As Integer = 0 To dtCopy.Rows.Count - 2
            Dim item = dtCopy.Rows(j)
            Dim BaleID = Convert.ToInt32(item(0))
            Dim Clase = Convert.ToString(item(1))
            Dim Cantidad = Convert.ToInt32(item(2))
            Dim Kilos = Convert.ToDouble(item(3))
            Dim Quintales = Convert.ToString(item(4))
            Dim TipoCambio = Convert.ToDouble(item(5))
            Dim PrecioMxn = Convert.ToDouble(item(6))
            Dim CastigoUI = Convert.ToDouble(item(7))
            Dim CastigoRF = Convert.ToDouble(item(8))
            Dim CastigoM = Convert.ToDouble(item(9))
            Dim CastigoLF = Convert.ToDouble(item(10))
            Dim TbPrecioClase = Convert.ToDouble(item(11))
            Dim Total = Convert.ToDouble(item(12))
            Dim Dlls = Convert.ToDouble(item(13))
            Dim drr As DataRow = dtResultado.NewRow()
            drr.Item(0) = BaleID
            drr.Item(1) = Clase
            drr.Item(2) = Cantidad
            drr.Item(3) = Kilos
            drr.Item(4) = Quintales
            drr.Item(5) = TipoCambio
            drr.Item(6) = PrecioMxn
            drr.Item(7) = Math.Round(CastigoUI, 2)
            drr.Item(8) = Math.Round(CastigoRF, 2)
            drr.Item(9) = Math.Round(CastigoM, 2)
            drr.Item(10) = Math.Round(CastigoLF, 2)
            drr.Item(11) = TbPrecioClase
            drr.Item(12) = Math.Round(Total, 2)
            drr.Item(13) = Math.Round(Dlls, 2)
            dtResultado.ImportRow(item)
            Dim filaSig As String = Convert.ToString(dtCopy.Rows(i + 1).Item(1)) 'fila siguiente
            If (Clase = filaSig) Then 'clase actual es igual a la siguiente zona
                value += Kilos
                TotalQuintales += Quintales
                TotalCastigoUI += CastigoUI
                TotalCastigoLF += CastigoLF
                TotalCastigoM += CastigoM
                TotalCastigoRF += CastigoRF
                TotalPacas += Cantidad
                TotalDolares += Math.Round(Dlls, 4)
            Else 'cuando cambie la clase insertar nueva fila y poner "Total" & Clase
                drr.Item(0) = ""
                drr.Item(1) = "Total " & Clase
                drr.Item(2) = TotalPacas + Cantidad
                drr.Item(3) = value + Kilos
                drr.Item(4) = TotalQuintales + Quintales
                drr.Item(7) = Math.Round(TotalCastigoUI + CastigoUI, 2)
                drr.Item(8) = Math.Round(TotalCastigoRF + CastigoRF, 2)
                drr.Item(9) = Math.Round(TotalCastigoM + CastigoM, 2)
                drr.Item(10) = Math.Round(TotalCastigoLF + CastigoLF, 2)
                drr.Item(11) = ""
                drr.Item(12) = ""
                drr.Item(13) = TotalDolares + Math.Round(Dlls, 2)
                dtResultado.Rows.Add(drr)
                value = 0
                TotalCastigoUI = 0
                TotalQuintales = 0
                TotalCastigoLF = 0
                TotalCastigoM = 0
                TotalCastigoRF = 0
                TotalPacas = 0
                TotalDolares = 0
            End If
            i += 1 'indice
        Next
        Return dtResultado
    End Function
    Private Sub BtSeleccionar_Click_1(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        Dim PacasVendidas As Integer = 0
        Dim PacasDisponibles As Integer = 0
        Dim PacasSeleccionadas As Integer = 0
        If DgvContratos.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvContratos.Rows
                If Fila.Cells("IdContratoAlgodon").Value.ToString = TbIdContrato.Text Then
                    PacasVendidas = Fila.Cells("PacasVendidas").Value
                    PacasDisponibles = Fila.Cells("PacasDisponibles").Value
                    PacasSeleccionadas = ValidaChecksPacas()
                End If
            Next
        End If
        If TbIdComprador.Text = "" Or TbPrecioQuintal.Text = "" Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        ElseIf (PacasSeleccionadas + PacasVendidas) > Val(TbNoPacas.Text) Then
            MsgBox("Las Pacas Seleccionadas Superan la cantidad de pacas del contrato. Revise la seleccion o que el contrato sea el correcto.")
        ElseIf PacasSeleccionadas > 0 And PacasSeleccionadas > Val(TbNoPacas.Text) Then
            MsgBox("Las Pacas Seleccionadas Superan la cantidad de pacas del contrato. Revise la seleccion o que el contrato sea el correcto.")
        ElseIf PacasSeleccionadas > 0 And PacasSeleccionadas <= Val(TbNoPacas.Text) Then
            If TbIdVentaPaca.Text = "" Then GuardarVentaEnc()
            EntidadVentaPacasContrato.Guarda = Guardar.GuardarVentaPacasDet
            EntidadVentaPacasContrato.TablaGeneral = DataGridADatatable(2, 1, DgvPacasVender, TbIdVentaPaca.Text)
            NegocioVentaPacasContrato.Guardar(EntidadVentaPacasContrato)

            'filtraPacasClases()
            VarGlob2.IdComprador = TbIdComprador.Text
            VarGlob2.NombreComprador = TbNombreComprador.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text

            '_Tabla = Table()
            'CompraPago.ShowDialog()
            'ConsultaCompra()
            consultaDatosdgv()
            For Each Fila As DataGridViewRow In DgvContratos.Rows
                If Fila.Cells("IdContratoAlgodon").Value.ToString = TbIdContrato.Text Then
                    Fila.Cells("PacasVendidas").Value = Fila.Cells("PacasVendidas").Value + PacasSeleccionadas
                    Fila.Cells("PacasDisponibles").Value = Fila.Cells("PacasDisponibles").Value - PacasSeleccionadas
                    ActualizaPacasDisponiblesContrato(Fila.Cells("IdContratoAlgodon").Value, Fila.Cells("PacasVendidas").Value, Fila.Cells("PacasDisponibles").Value)
                End If
            Next
        Else
            MessageBox.Show("No hay pacas seleccionadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ActualizaPacasDisponiblesContrato(ByVal IdContrato As Integer, ByVal PacasVendidas As Integer, ByVal PacasDisponibles As Integer)
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        EntidadVentaPacasContrato.Actualiza = Actuliza.ActualizaPacasDisponibles
        EntidadVentaPacasContrato.IdContrato = IdContrato
        EntidadVentaPacasContrato.PacasVendidas = PacasVendidas
        EntidadVentaPacasContrato.PacasDisponibles = PacasDisponibles
        NegocioVentaPacasContrato.Actualizar(EntidadVentaPacasContrato)
    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar2.Click
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        Dim PacasVendidas As Integer = 0
        Dim PacasDisponibles As Integer = 0
        Dim PacasMarcadas As Integer = 0
        If DgvContratos.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvContratos.Rows
                If Fila.Cells("IdContratoAlgodon").Value.ToString = TbIdContrato.Text Then
                    PacasVendidas = Fila.Cells("PacasVendidas").Value
                    PacasDisponibles = Fila.Cells("PacasDisponibles").Value
                    PacasMarcadas = ValidaChecksPacasVendidas()
                End If
            Next
        End If
        If CheckFalse() = 0 Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        Else
            If PacasMarcadas <= PacasVendidas And PacasMarcadas > 0 Then
                If TbIdVentaPaca.Text = "" Then GuardarVentaEnc()
                EntidadVentaPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarVentaPacasDet
                EntidadVentaPacasContrato.TablaGeneral = DataGridADatatable(1, 2, DgvPacasIndVendidas, 0, 1)
                NegocioVentaPacasContrato.Guardar(EntidadVentaPacasContrato)
                consultaDatosdgv()
                For Each Fila As DataGridViewRow In DgvContratos.Rows
                    If Fila.Cells("IdContratoAlgodon").Value.ToString = TbIdContrato.Text Then
                        Fila.Cells("PacasVendidas").Value = Fila.Cells("PacasVendidas").Value - PacasMarcadas
                        Fila.Cells("PacasDisponibles").Value = Fila.Cells("PacasDisponibles").Value + PacasMarcadas
                        ActualizaPacasDisponiblesContrato(Fila.Cells("IdContratoAlgodon").Value, Fila.Cells("PacasVendidas").Value, Fila.Cells("PacasDisponibles").Value)
                    End If
                Next
            ElseIf PacasMarcadas > PacasVendidas Then
                MsgBox("La cantidad de pacas seleccionadas a devolucion, es mayor a la comprada, revise la seleccion de pacas o el contrato.", MsgBoxStyle.Information)
            ElseIf PacasMarcadas = 0 Then
                MessageBox.Show("No hay pacas seleccionadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Function ValidaChecksPacas()
        Dim PacasMarcadas As Integer = 0
        For i As Integer = 0 To DgvPacasVender.Rows.Count - 1
            If DgvPacasVender.Rows(i).Cells("Seleccionar").EditedFormattedValue = True Then
                PacasMarcadas = PacasMarcadas + 1
            End If
        Next
        Return PacasMarcadas
    End Function
    Private Function ValidaChecksPacasVendidas()
        DgvPacasIndVendidas.EndEdit()
        Dim PacasMarcadas As Integer = 0
        For i As Integer = 0 To DgvPacasIndVendidas.Rows.Count - 1
            If DgvPacasIndVendidas.Rows(i).Cells("Seleccionar").EditedFormattedValue = True Then
                PacasMarcadas = PacasMarcadas + 1
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
        EntidadVentaPacasContrato.IdModalidadVenta = CbModalidadVenta.SelectedValue
        EntidadVentaPacasContrato.FechaVenta = DtpFecha.Value
        EntidadVentaPacasContrato.TotalPacas = 0
        EntidadVentaPacasContrato.Observaciones = ""
        EntidadVentaPacasContrato.CastigoMicros = 0
        EntidadVentaPacasContrato.CastigoLargoFibra = 0
        EntidadVentaPacasContrato.CastigoResistenciaFibra = 0
        EntidadVentaPacasContrato.CastigoUI = 0
        EntidadVentaPacasContrato.CastigoBarkLevel1 = 0
        EntidadVentaPacasContrato.CastigoBarkLevel2 = 0
        EntidadVentaPacasContrato.CastigoPrepLevel1 = 0
        EntidadVentaPacasContrato.CastigoPrepLevel2 = 0
        EntidadVentaPacasContrato.CastigoOtherLevel1 = 0
        EntidadVentaPacasContrato.CastigoOtherLevel2 = 0
        EntidadVentaPacasContrato.CastigoPlasticLevel1 = 0
        EntidadVentaPacasContrato.CastigoPlasticLevel2 = 0
        EntidadVentaPacasContrato.IdUnidadPeso = CbModalidadVenta.SelectedValue
        EntidadVentaPacasContrato.ValorConversion = Val(TbValorConversion.Text)
        EntidadVentaPacasContrato.Unidad = Val(TbKdAd.Text)
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
        dt.Columns.Add("PrecioDls", Type.GetType("System.Single"))
        dt.Columns.Add("PrecioClase", Type.GetType("System.Single"))
        dt.Columns.Add("TipoCambio", Type.GetType("System.Single"))
        dt.Columns.Add("PrecioMxn", Type.GetType("System.Single"))
        dt.Columns.Add("Kilos", Type.GetType("System.Int32"))
        dt.Columns.Add("Quintales", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoResistenciaFibra", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoMicros", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoLargoFibra", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoUI", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoBarkLevel1", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoBarkLevel2", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoPrepLevel1", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoPrepLevel2", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoOtherLevel1", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoOtherLevel2", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoPlasticLevel1", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoPlasticLevel2", Type.GetType("System.Single"))
        dt.Columns.Add("EstatusVentaUpdate", Type.GetType("System.Int32"))
        dt.Columns.Add("EstatusVentaBusqueda", Type.GetType("System.Int32"))

        For i = 0 To DataGridEnvia.Rows.Count - 1
            r = dt.NewRow
            If DataGridEnvia.Item("Seleccionar", i).EditedFormattedValue = True Then
                Dim Kilos As Integer = DataGridEnvia.Item("Kilos", i).Value + Val(TbKdAd.Text)
                Dim Quintales As Double = Math.Round(CDbl(Kilos / 46.02), 4)
                r("IdComprador") = TbIdComprador.Text
                r("BaleID") = DataGridEnvia.Item("BaleID", i).Value
                r("IdLiquidacion") = DataGridEnvia.Item("IdLiquidacion", i).Value
                r("IdVentaEnc") = IdVentaEnc
                r("PrecioDls") = Math.Truncate((Quintales * PrecioContratoClase(DataGridEnvia.Item("Grade", i).Value.ToString)) * 10000) / 10000
                r("PrecioClase") = PrecioContratoClase(DataGridEnvia.Item("Grade", i).Value.ToString)
                r("TipoCambio") = 0
                r("PrecioMxn") = 0
                r("Kilos") = (DataGridEnvia.Item("Kilos", i).Value + Val(TbKdAd.Text))
                r("Quintales") = Quintales
                r("CastigoResistenciaFibra") = Math.Truncate(ConsultaCastigoResistenciaFibra(DataGridEnvia.Item(14, i).Value, Quintales, valcastigo) * 10000) / 10000
                r("CastigoMicros") = Math.Truncate(ConsultaCastigoMicros(DataGridEnvia.Item(13, i).Value, Quintales, valcastigo) * 10000) / 10000
                r("CastigoLargoFibra") = Math.Truncate(ConsultaCastigoLargoFibra(DataGridEnvia.Item(15, i).Value, Quintales, valcastigo) * 10000) / 10000
                r("CastigoUI") = Math.Truncate(ConsultaCastigoUniformidad(DataGridEnvia.Item(12, i).Value, Quintales, valcastigo) * 10000) / 10000
                r("CastigoBarkLevel1") = DataGridEnvia.Item("CastigoBarkLevel1Venta", i).Value
                r("CastigoBarkLevel2") = DataGridEnvia.Item("CastigoBarkLevel2Venta", i).Value
                r("CastigoPrepLevel1") = DataGridEnvia.Item("CastigoPrepLevel1Venta", i).Value
                r("CastigoPrepLevel2") = DataGridEnvia.Item("CastigoPrepLevel2Venta", i).Value
                r("CastigoOtherLevel1") = DataGridEnvia.Item("CastigoOtherLevel1Venta", i).Value
                r("CastigoOtherLevel2") = DataGridEnvia.Item("CastigoOtherLevel2Venta", i).Value
                r("CastigoPlasticLevel1") = DataGridEnvia.Item("CastigoPlasticLevel1Venta", i).Value
                r("CastigoPlasticLevel2") = DataGridEnvia.Item("CastigoPlasticLevel2Venta", i).Value
                r("EstatusVentaUpdate") = EstatusVentaUpdate
                r("EstatusVentaBusqueda") = EstatusVentaBusqueda
                dt.Rows.Add(r)
            End If
        Next
        Return dt
    End Function
    Private Function PrecioContratoClase(ByVal Clase As String) As Double
        Dim resultado As Double = 0
        Select Case Clase
            Case "SM"
                resultado = PrecioSM
            Case "MP"
                resultado = PrecioMP
            Case "M"
                resultado = PrecioM
            Case "SLMP"
                resultado = PrecioSLMP
            Case "SLM"
                resultado = PrecioSLM
            Case "LMP"
                resultado = PrecioLMP
            Case "LM"
                resultado = PrecioLM
            Case "SGO"
                resultado = PrecioSGO
            Case "GO"
                resultado = PrecioGO
            Case "O"
                resultado = PrecioO
        End Select
        Return resultado
    End Function
    Private Sub filtraPacasClases()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        '---Consultar las pacas ya clasificadas del productor
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPacaFiltro
        EntidadVentaPacasContrato.IdComprador = CInt(TbIdComprador.Text)
        EntidadVentaPacasContrato.InicioPaca = IIf(TbDesdePaca.Text = "", 0, TbDesdePaca.Text)
        EntidadVentaPacasContrato.FinPaca = IIf(TbHastaPaca.Text = "", 0, TbHastaPaca.Text)
        EntidadVentaPacasContrato.Clase = CbClasesPacasAVender.Text
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        Tabla = EntidadVentaPacasContrato.TablaConsulta
        DgvPacasVender.Columns.Clear()
        DgvPacasVender.DataSource = Tabla
        PropiedadesDgvPacasComprar()

        '---Consultar pacas compradas
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPacaVendida
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
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPacaVendida
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
    Private Sub ConsultarDatosVenta()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        If TbIdComprador.Text = 0 Then
            MsgBox("Seleccionar a un productor para ver sus contratos", MsgBoxStyle.Exclamation)
        Else
            '---Consultar contratos del productor---
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPorId
            EntidadVentaPacasContrato.IdComprador = CInt(TbIdComprador.Text)
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            DgvContratos.Columns.Clear()
            DgvContratos.DataSource = Tabla
            Dim colSelCon As New DataGridViewCheckBoxColumn()
            colSelCon.Name = "Seleccionar"
            colSelCon.FalseValue = False
            colSelCon.Visible = True
            DgvContratos.Columns.Insert(22, colSelCon)
            PropiedadesDgvContratos()
            '---Consultar liquidaciones del productor con compras
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaLiquidacionesVentas
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
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPacaVendida
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
            SeleccionaContratoConsultado()
        End If
    End Sub
    Private Sub SeleccionaContratoConsultado()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        If TbIdVentaPaca.Text <> "" Then
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaIdVentaPaca
            EntidadVentaPacasContrato.IdVenta = CInt(TbIdVentaPaca.Text)
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            If DgvContratos.Rows.Count > 0 Then
                For Each Fila As DataGridViewRow In DgvContratos.Rows
                    If Tabla.Rows(0).Item("IdContratoAlgodon").ToString = Fila.Cells("IdContratoAlgodon").Value.ToString Then
                        Fila.Cells("Seleccionar").Value = True
                        TbIdContrato.Text = Tabla.Rows(0).Item("IdContratoAlgodon").ToString
                        TbPrecioQuintal.Text = Fila.Cells("PrecioQuintal").Value
                        TbNoPacas.Text = Fila.Cells("Pacas").Value
                        CbModalidadVenta.SelectedValue = Fila.Cells("IdModalidadVenta").Value
                        CbUnidadPeso.SelectedValue = Fila.Cells("IdUnidadPeso").Value
                        TbValorConversion.Text = Fila.Cells("ValorConversion").Value
                        TbKdAd.Text = Tabla.Rows(0).Item("IdContratoAlgodon").ToString
                        PrecioSM = -1 * Fila.Cells("PrecioSM").Value
                        PrecioMP = -1 * Fila.Cells("PrecioMP").Value
                        PrecioM = -1 * Fila.Cells("PrecioM").Value
                        PrecioSLMP = -1 * Fila.Cells("PrecioSLMP").Value
                        PrecioSLM = -1 * Fila.Cells("PrecioSLM").Value
                        PrecioLMP = -1 * Fila.Cells("PrecioLMP").Value
                        PrecioLM = -1 * Fila.Cells("PrecioLM").Value
                        PrecioSGO = -1 * Fila.Cells("PrecioSGO").Value
                        PrecioGO = -1 * Fila.Cells("PrecioGO").Value
                        PrecioO = -1 * Fila.Cells("PrecioO").Value
                    End If
                Next
            End If
        End If
    End Sub
    Private Function ConsultaCastigoMicros(ByVal ValMicros As Double, ByVal Quintales As Double, Optional bandera As Integer = 0)
        Dim Castigo As Double
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If bandera = 0 Then
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoMicros
            EntidadCompraPacasContrato.CastigoMicros = Math.Truncate(ValMicros * 100) / 100
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 2)
            Return Castigo
        Else
            Castigo = 0
            Return Castigo
        End If

    End Function
    Private Function ConsultaCastigoResistenciaFibra(ByVal ValResistenciaFibra As Double, ByVal Quintales As Double, Optional bandera As Integer = 0)
        Dim Castigo As Double
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If bandera = 0 Then
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoResistenciaFibra
            EntidadCompraPacasContrato.CastigoResistenciaFibra = Math.Truncate(ValResistenciaFibra * 100) / 100
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 2)
            Return Castigo
        Else
            Castigo = 0
            Return Castigo
        End If

    End Function
    Private Function ConsultaCastigoLargoFibra(ByVal ValLargoFibra As Double, ByVal Quintales As Double, Optional bandera As Integer = 0)
        Dim Castigo As Double
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If bandera = 0 Then
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoLargoFibra
            EntidadCompraPacasContrato.CastigoLargoFibra = Math.Truncate(ValLargoFibra * 100) / 100
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 4)
            Return Castigo
        Else
            Castigo = 0
            Return Castigo
        End If

    End Function
    Private Function ConsultaCastigoUniformidad(ByVal ValUniformidad As Double, ByVal Quintales As Double, Optional bandera As Integer = 0)
        Dim Castigo As Double
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If bandera = 0 Then
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoUniformidad
            EntidadCompraPacasContrato.CastigoUniformidad = Math.Truncate(ValUniformidad * 10) / 10
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 4)
            Return Castigo
        Else
            Castigo = 0
            Return Castigo
        End If
    End Function

    Private Sub BtFiltro_Click(sender As Object, e As EventArgs) Handles BtFiltro.Click
        If TbIdComprador.Text = "" Then
            TbIdComprador.Text = ""
            MsgBox("Seleccionar a un comprador para ver sus contratos", MsgBoxStyle.Exclamation)
        ElseIf (TbDesdePaca.Text <> "" And TbHastaPaca.Text <> "" And Val(TbDesdePaca.Text) < Val(TbHastaPaca.Text)) Or (TbHastaPaca.Text = "" And TbDesdePaca.Text = "" And CbClasesPacasAVender.Text <> "") Or (TbHastaPaca.Text = "" And TbDesdePaca.Text = "" And CbClasesPacasAVender.Text = "") Then
            filtraPacasClases()
        ElseIf (TbDesdePaca.Text > TbHastaPaca.Text) Or TbHastaPaca.Text = "" Or TbDesdePaca.Text = "" Then
            MsgBox("El Campo De Inicio no puede ser mayor al campo final o contener campos vacios")
        End If
    End Sub

    Private Sub BtReiniciaFiltro_Click(sender As Object, e As EventArgs) Handles BtReiniciaFiltro.Click
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato

        If TbIdComprador.Text = "" Then
            TbIdComprador.Text = ""
            MsgBox("Seleccionar a un productor para ver sus contratos", MsgBoxStyle.Exclamation)
        Else
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaPaca
            EntidadVentaPacasContrato.IdComprador = CInt(TbIdComprador.Text)
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Tabla = EntidadVentaPacasContrato.TablaConsulta
            DgvPacasVender.Columns.Clear()
            DgvPacasVender.DataSource = Tabla

            PropiedadesDgvPacasComprar()
            TbDesdePaca.Text = ""
            TbHastaPaca.Text = ""
            CbClasesPacasAVender.SelectedValue = -1
            ConsultaCantidadPacas()
            TotalPacasContrato()
            MarcaSeleccionDisponibles()
        End If
    End Sub

    Private Sub PropiedadesDgvPacasComprar()
        DgvPacasVender.Columns("IdOrdenTrabajo").Visible = True
        DgvPacasVender.Columns("IdLiquidacion").Visible = False
        DgvPacasVender.Columns("FolioCIA").Visible = False
        DgvPacasVender.Columns("Kilos").Visible = False
        DgvPacasVender.Columns("Quintales").Visible = False
        DgvPacasVender.Columns("PrecioClase").Visible = False
        DgvPacasVender.Columns("PrecioDls").Visible = False
        DgvPacasVender.Columns("TipoCambio").Visible = False
        DgvPacasVender.Columns("PrecioMxn").Visible = False
        DgvPacasVender.Columns("CastigoBarkLevel1Venta").Visible = False
        DgvPacasVender.Columns("CastigoBarkLevel2Venta").Visible = False
        DgvPacasVender.Columns("CastigoPrepLevel1Venta").Visible = False
        DgvPacasVender.Columns("CastigoPrepLevel2Venta").Visible = False
        DgvPacasVender.Columns("CastigoOtherLevel1Venta").Visible = False
        DgvPacasVender.Columns("CastigoOtherLevel2Venta").Visible = False
        DgvPacasVender.Columns("CastigoPlasticLevel1Venta").Visible = False
        DgvPacasVender.Columns("CastigoPlasticLevel2Venta").Visible = False

        DgvPacasVender.Columns("IdOrdenTrabajo").HeaderText = "No Orden"
        DgvPacasVender.Columns("BaleId").HeaderText = "Etiqueta"
        DgvPacasVender.Columns("Grade").HeaderText = "Clase"
        DgvPacasVender.Columns("Descripcion").HeaderText = "Planta"

        DgvPacasVender.Columns("Descripcion").ReadOnly = True
        DgvPacasVender.Columns("BaleId").ReadOnly = True
        DgvPacasVender.Columns("Kilos").ReadOnly = True
        DgvPacasVender.Columns("Grade").ReadOnly = True
        DgvPacasVender.Columns("Uniformidad").ReadOnly = True
        DgvPacasVender.Columns("Micros").ReadOnly = True
        DgvPacasVender.Columns("Resistencia").ReadOnly = True
        DgvPacasVender.Columns("Largo").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvLiquidacionesCompradas()
        DgvLiqVendidas.Columns("IdOrdenTrabajo").HeaderText = "No Orden"

        DgvLiqVendidas.Columns("IdLiquidacion").Visible = False
        DgvLiqVendidas.Columns("TotalHueso").Visible = False
        DgvLiqVendidas.Columns("PacasCantidad").ReadOnly = True
        DgvLiqVendidas.Columns("PacasDisponibles").Visible = False
        DgvLiqVendidas.Columns("PacasVendidas").ReadOnly = True
        DgvLiqVendidas.Columns("PesoPluma").Visible = False
        DgvLiqVendidas.Columns("TotalSemilla").Visible = False
        DgvLiqVendidas.Columns("Seleccionar").ReadOnly = False
    End Sub
    Private Sub PropiedadesDgvLiquidacionesComprar()
        DgvDatosLiquidacion.Columns("IdLiquidacion").Visible = False

        DgvDatosLiquidacion.Columns("IdOrdenTrabajo").HeaderText = "No Orden"

        DgvDatosLiquidacion.Columns("IdOrdenTrabajo").ReadOnly = True
        DgvDatosLiquidacion.Columns("TotalHueso").ReadOnly = True
        DgvDatosLiquidacion.Columns("PacasCantidad").ReadOnly = True
        DgvDatosLiquidacion.Columns("PacasDisponibles").ReadOnly = True
        DgvDatosLiquidacion.Columns("PacasVendidas").ReadOnly = True
        DgvDatosLiquidacion.Columns("PesoPluma").ReadOnly = True
        DgvDatosLiquidacion.Columns("TotalSemilla").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvContratos()
        DgvContratos.Columns("IdContratoAlgodon").HeaderText = "Contrato"
        DgvContratos.Columns("Pacas").HeaderText = "Pacas por Contrato"

        DgvContratos.Columns("IdComprador").Visible = False
        DgvContratos.Columns("IdUnidadPeso").Visible = False
        DgvContratos.Columns("ValorConversion").Visible = False
        DgvContratos.Columns("Puntos").Visible = False
        DgvContratos.Columns("FechaLiquidacion").Visible = False
        DgvContratos.Columns("Temporada").Visible = False
        DgvContratos.Columns("IdModalidadVenta").Visible = False
        DgvContratos.Columns("PrecioSM").Visible = False
        DgvContratos.Columns("PrecioMP").Visible = False
        DgvContratos.Columns("precioM").Visible = False
        DgvContratos.Columns("PrecioSLMP").Visible = False
        DgvContratos.Columns("PrecioSLM").Visible = False
        DgvContratos.Columns("PrecioLMP").Visible = False
        DgvContratos.Columns("PrecioLM").Visible = False
        DgvContratos.Columns("PrecioSGO").Visible = False
        DgvContratos.Columns("PrecioGO").Visible = False
        DgvContratos.Columns("PrecioO").Visible = False
        DgvContratos.Columns("Fecha").Visible = False

        DgvContratos.Columns("IdContratoAlgodon").ReadOnly = True
        DgvContratos.Columns("Pacas").ReadOnly = True
        DgvContratos.Columns("PacasVendidas").ReadOnly = True
        DgvContratos.Columns("PacasDisponibles").ReadOnly = True
        DgvContratos.Columns("PrecioQuintal").ReadOnly = True
        DgvContratos.Columns("Fecha").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvPacasIndCompradas()
        DgvPacasIndVendidas.Columns("FolioCIA").Visible = False
        DgvPacasIndVendidas.Columns("IdOrdenTrabajo").Visible = True
        DgvPacasIndVendidas.Columns("IdLiquidacion").Visible = False
        DgvPacasIndVendidas.Columns("FolioCIA").Visible = False
        DgvPacasIndVendidas.Columns("Quintales").Visible = False
        DgvPacasIndVendidas.Columns("PrecioClase").Visible = False
        DgvPacasIndVendidas.Columns("PrecioDls").Visible = False
        DgvPacasIndVendidas.Columns("TipoCambio").Visible = False
        DgvPacasIndVendidas.Columns("PrecioMxn").Visible = False
        DgvPacasIndVendidas.Columns("CastigoBarkLevel1Venta").Visible = False
        DgvPacasIndVendidas.Columns("CastigoBarkLevel2Venta").Visible = False
        DgvPacasIndVendidas.Columns("CastigoPrepLevel1Venta").Visible = False
        DgvPacasIndVendidas.Columns("CastigoPrepLevel2Venta").Visible = False
        DgvPacasIndVendidas.Columns("CastigoOtherLevel1Venta").Visible = False
        DgvPacasIndVendidas.Columns("CastigoOtherLevel2Venta").Visible = False
        DgvPacasIndVendidas.Columns("CastigoPlasticLevel1Venta").Visible = False
        DgvPacasIndVendidas.Columns("CastigoPlasticLevel2Venta").Visible = False

        DgvPacasIndVendidas.Columns("IdOrdenTrabajo").HeaderText = "No Orden"
        DgvPacasIndVendidas.Columns("BaleId").HeaderText = "Etiqueta"
        DgvPacasIndVendidas.Columns("Grade").HeaderText = "Clase"
        DgvPacasIndVendidas.Columns("Descripcion").HeaderText = "Planta"
        DgvPacasIndVendidas.Columns("CastigoUIVenta").HeaderText = "Castigo UI"
        DgvPacasIndVendidas.Columns("CastigoMicVenta").HeaderText = "Castigo Mic"
        DgvPacasIndVendidas.Columns("CastigoResistenciaFibraVenta").HeaderText = "Castigo RF"
        DgvPacasIndVendidas.Columns("CastigoLargoFibraVenta").HeaderText = "Castigo LF"

        DgvPacasIndVendidas.Columns("Descripcion").ReadOnly = True
        DgvPacasIndVendidas.Columns("BaleId").ReadOnly = True
        DgvPacasIndVendidas.Columns("Kilos").ReadOnly = True
        DgvPacasIndVendidas.Columns("Grade").ReadOnly = True
        DgvPacasIndVendidas.Columns("CastigoUIVenta").ReadOnly = True
        DgvPacasIndVendidas.Columns("CastigoMicVenta").ReadOnly = True
        DgvPacasIndVendidas.Columns("CastigoResistenciaFibraVenta").ReadOnly = True
        DgvPacasIndVendidas.Columns("CastigoLargoFibraVenta").ReadOnly = True
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
        TbPacasComp.Text = Tabla.Rows(0).Item("Vendidas")
    End Sub
    Private Sub TotalPacasContrato()
        Dim Pacas As Integer = 0
        For i As Integer = 0 To DgvContratos.Rows.Count - 1
            Pacas += DgvContratos.Rows(i).Cells("Pacas").Value
        Next
        TbPacasContratadas.Text = Pacas
        TbPacasCompCont.Text = Val(TbPacasContratadas.Text) - Val(TbPacasComp.Text)
    End Sub
    Private Sub DgvLiqVendidas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLiqVendidas.CellContentClick
        Dim filaSeleccionada As Integer = DgvLiqVendidas.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvLiqVendidas.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdLiquidacion As Integer
        IdLiquidacion = DgvLiqVendidas.Rows(filaSeleccionada).Cells("IdLiquidacion").Value
        For Each row As DataGridViewRow In DgvPacasIndVendidas.Rows
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
    Private Function CheckFalse()
        Dim Contador As Integer
        Dim checkcount As Integer = 0
        For Contador = 0 To DgvContratos.RowCount - 1
            If DgvContratos.Rows(Contador).Cells("Seleccionar").Value = True Then
                checkcount = checkcount + 1
            End If
        Next Contador
        Return checkcount
    End Function

    Private Sub CkKgAdd_Click(sender As Object, e As EventArgs) Handles CkKgAdd.Click
        If CkKgAdd.Checked = False Then
            TbKdAd.Visible = False
        Else
            TbKdAd.Visible = True
        End If
    End Sub

    Private Sub DgvPacasVender_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacasVender.CellContentClick
        MarcaSeleccionDisponibles()
    End Sub
End Class