Imports Capa_Operacion.Configuracion
Public Class CompraPacasContrato
    Implements IForm
    Public TablaModalidadCompra, TablacastigoMicros, TablaCastigoLargoFibra, TablaCastigoResistenciaFibra, TablaPacasAgrupadas, TablaPacasCompras As New DataTable
    Private Sub CompraPacasContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearTablaPacasAgrupadas()
        CargarCombos()
        Nuevo()
    End Sub
    Private Sub CrearTablaPacasAgrupadas()
        TablaPacasAgrupadas.Columns.Clear()
        TablaPacasAgrupadas.Columns.Add(New DataColumn("BaleID", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Grade", System.Type.GetType("System.String")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Cantidad", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Kilos", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Quintales", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoResistenciaFibra", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoMicros", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoLargoFibra", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioQuintal", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Total", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("TotalDlls", System.Type.GetType("System.Double")))
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
        ElseIf DgvPacasIndCompradas.RowCount > 0 Then
            GuardarCompraEnc()
            filtraPacasClases()
            VarGlob2.IdProductor = TbIdProductor.Text
            VarGlob2.NombreProductor = TbNombreProductor.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text
            VarGlob2.IdCompra = TbIdCompraPaca.Text
            VarGlob2.IdContrato = TbIdContrato.Text
            VarGlob2.IdPlanta = CbPlanta.SelectedValue
            VarGlob2.IdModalidadCompra = CbModalidadCompra.SelectedValue

            _Tabla = Table()
            CompraPago.ShowDialog()
            'ConsultaCompra()
            consultaDatosdgv()
        Else
            MessageBox.Show("No hay pacas seleccionadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub GuardarCompraEnc()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarCompraPacasEnc
        EntidadCompraPacasContrato.IdCompra = IIf(TbIdCompraPaca.Text = "", 0, TbIdCompraPaca.Text)
        EntidadCompraPacasContrato.IdContrato = TbIdContrato.Text
        EntidadCompraPacasContrato.IdProductor = TbIdProductor.Text
        EntidadCompraPacasContrato.IdPlanta = CbPlanta.SelectedValue
        EntidadCompraPacasContrato.IdModalidadCompra = CbModalidadCompra.SelectedValue
        EntidadCompraPacasContrato.FechaCompra = DtFechaCompra.Value
        EntidadCompraPacasContrato.TotalPacas = 0
        EntidadCompraPacasContrato.Observaciones = ""
        EntidadCompraPacasContrato.CastigoMicros = 0
        EntidadCompraPacasContrato.CastigoLargoFibra = 0
        EntidadCompraPacasContrato.CastigoResistenciaFibra = 0
        EntidadCompraPacasContrato.InteresPesosMx = 0
        EntidadCompraPacasContrato.InteresDlls = 0
        EntidadCompraPacasContrato.PrecioQuintal = 0
        EntidadCompraPacasContrato.PrecioQuintalBorregos = 0
        EntidadCompraPacasContrato.PrecioDolar = 0
        EntidadCompraPacasContrato.subtotal = 0
        EntidadCompraPacasContrato.CastigoDls = 0
        EntidadCompraPacasContrato.AnticipoDls = 0
        EntidadCompraPacasContrato.TotalDlls = 0
        EntidadCompraPacasContrato.TotalPesosMx = 0
        EntidadCompraPacasContrato.IdEstatusCompra = 0
        NegocioCompraPacasContrato.Guardar(EntidadCompraPacasContrato)
        TbIdCompraPaca.Text = EntidadCompraPacasContrato.IdCompra
    End Sub
    Private Sub ConfirmarSeleccion()

    End Sub
    Private Function DataGridADatatable(ByVal EstatusCompraUpdate As Integer, ByVal EstatusCompraBusqueda As Integer, ByVal DataGridEnvia As DataGridView, ByVal IdCompraEnc As Integer, Optional valcastigo As Integer = 0) As DataTable
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Add("IdProductor", Type.GetType("System.Int32"))
        dt.Columns.Add("BaleID", Type.GetType("System.Int32"))
        dt.Columns.Add("IdLiquidacion", Type.GetType("System.Int32"))
        dt.Columns.Add("IdCompraEnc", Type.GetType("System.Int32"))
        dt.Columns.Add("CastigoResistenciaFibra", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoMicros", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoLargoFibra", Type.GetType("System.Single"))
        dt.Columns.Add("estatuscompraUpdate", Type.GetType("System.Int32"))
        dt.Columns.Add("estatuscompraBusqueda", Type.GetType("System.Int32"))

        For i = 0 To DataGridEnvia.Rows.Count - 1
            r = dt.NewRow
            If DataGridEnvia.Item("Seleccionar", i).EditedFormattedValue = True Then
                Dim Quintales As Double = Math.Round(CDbl(DataGridEnvia.Item("Kilos", i).Value) / 46.02, 2)
                r("IdProductor") = TbIdProductor.Text
                r("BaleID") = DataGridEnvia.Item("BaleID", i).Value.ToString
                r("IdLiquidacion") = DataGridEnvia.Item("IdLiquidacion", i).Value.ToString
                r("IdCompraEnc") = IdCompraEnc
                r("CastigoResistenciaFibra") = IIf(valcastigo = 0, ConsultaCastigoResistenciaFibra(DataGridEnvia.Item(8, i).Value.ToString, Quintales), 0)
                r("CastigoMicros") = IIf(valcastigo = 0, ConsultaCastigoMicros(DataGridEnvia.Item(7, i).Value.ToString, Quintales), 0)
                r("CastigoLargoFibra") = IIf(valcastigo = 0, ConsultaCastigoLargoFibra(DataGridEnvia.Item(9, i).Value.ToString, Quintales), 0)
                r("estatuscompraUpdate") = EstatusCompraUpdate
                r("EstatusCompraBusqueda") = EstatusCompraBusqueda
                dt.Rows.Add(r)
            End If
        Next
        Return dt
    End Function
    Private Sub CuentaPacasMarcadas() Handles DgvPacasComprar.CellContentClick
        MarcaSeleccionDisponibles()
    End Sub
    Private Function ValidaChecksPacas()
        'TablaPacasAgrupadas.Rows.Clear()
        'Dim TablaRenglonAInsertar As DataRow
        Dim PacasMarcadas As Integer = 0
        For i As Integer = 0 To DgvPacasComprar.Rows.Count - 1
            If DgvPacasComprar.Rows(i).Cells("Seleccionar").EditedFormattedValue = True Then
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
    Private Function ValidaChecksDgv()
        Dim valor As Boolean = False
        For i As Integer = 0 To DgvPacasComprar.Rows.Count - 1
            If DgvPacasComprar.Rows(i).Cells("Seleccionar").EditedFormattedValue = True Then
                valor = True
            End If
        Next
        Return valor
    End Function
    Private Function ValidaCheckContratos()
        Dim PacasMarcadas As Integer = 0
        For i As Integer = 0 To DgvContratos.Rows.Count - 1
            If DgvContratos.Rows(i).Cells("Seleccionar").EditedFormattedValue = True Then
                PacasMarcadas = PacasMarcadas + 1
            End If
        Next
        Return PacasMarcadas
    End Function
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
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim _ConsultaCompraProductor As New ConsultaCompraProductor

        _ConsultaCompraProductor.MdiParent = Me.MdiParent
        _ConsultaCompraProductor.Opener = CType(Me, IForm)

        _ConsultaCompraProductor.ShowDialog()
        ConsultarDatosCompra()
    End Sub
    Public Function LoadDataGridView(ByVal DatatableParam As DataTable) As Boolean Implements IForm.LoadIDValues
        For Each row As DataRow In DatatableParam.Rows

            TbIdCompraPaca.Text = row("IdCompra")
            TbIdProductor.Text = row("IdProductor")
            TbNombreProductor.Text = row("Nombre")
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
        TbIdCompraPaca.Text = ""
        TbIdProductor.Text = 0
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
    Private Sub ConsultarDatosCompra()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If TbIdProductor.Text = 0 Then
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
            EntidadCompraPacasContrato.IdCompra = CInt(IIf(TbIdCompraPaca.Text = "", 0, TbIdCompraPaca.Text))
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
            EntidadCompraPacasContrato.IdCompra = CInt(IIf(TbIdCompraPaca.Text = "", 0, TbIdCompraPaca.Text))
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvPacasIndCompradas.Columns.Clear()
            DgvPacasIndCompradas.DataSource = Tabla
            PropiedadesDgvPacasIndCompradas()
            '---Consultar las pacas ya clasificadas del productor
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPaca
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvPacasComprar.Columns.Clear()
            DgvPacasComprar.DataSource = Tabla

            'ConsultaCompra()

            PropiedadesDgvPacasComprar()
            ConsultaCantidadPacas()
            TotalPacasContrato()
            MarcaSeleccionDisponibles()
        End If
    End Sub
    Private Sub consultaDatosdgv()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If TbIdProductor.Text = 0 Then
            TbIdProductor.Text = ""
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
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaLiquidacionesCompras
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            EntidadCompraPacasContrato.IdCompra = CInt(IIf(TbIdCompraPaca.Text = "", 0, TbIdCompraPaca.Text))
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
            EntidadCompraPacasContrato.IdCompra = CInt(IIf(TbIdCompraPaca.Text = "", 0, TbIdCompraPaca.Text))
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvPacasIndCompradas.Columns.Clear()
            DgvPacasIndCompradas.DataSource = Tabla
            PropiedadesDgvPacasIndCompradas()
            '---Consultar las pacas ya clasificadas del productor
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPaca
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvPacasComprar.Columns.Clear()
            DgvPacasComprar.DataSource = Tabla

            'ConsultaCompra()

            PropiedadesDgvPacasComprar()
            ConsultaCantidadPacas()
            TotalPacasContrato()
            MarcaSeleccionDisponibles()
        End If
    End Sub
    Private Sub PropiedadesDgvPacasIndCompradas()
        DgvPacasIndCompradas.Columns("BaleID").Visible = False
        DgvPacasIndCompradas.Columns("CastigoResistenciaFibraCompra").Visible = False
        DgvPacasIndCompradas.Columns("CastigoMicCompra").Visible = False
        DgvPacasIndCompradas.Columns("CastigoLargoFibraCompra").Visible = False
    End Sub
    'Private Sub ConsultaCompra()
    '    Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
    '    Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
    '    EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCompra
    '    EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
    '    NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
    '    Tabla = EntidadCompraPacasContrato.TablaConsulta
    '    DgvCompras.Columns.Clear()
    '    DgvCompras.DataSource = Tabla
    '    Dim colSelCon As New DataGridViewCheckBoxColumn()
    '    colSelCon.Name = "Seleccionar"
    '    colSelCon.FalseValue = False
    '    colSelCon.Visible = True
    '    DgvCompras.Columns.Insert(21, colSelCon)
    '    PropiedadesDgvCompras()
    'End Sub
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
    'Private Sub PropiedadesDgvCompras()
    '    DgvCompras.Columns("IdCompra").HeaderText = "ID"
    '    DgvCompras.Columns("IdContratoAlgodon").HeaderText = "Contrato"
    '    DgvCompras.Columns("Fecha").HeaderText = "Fecha"
    '    DgvCompras.Columns("IdEstatusCompra").HeaderText = "Estatus"
    '    DgvCompras.Columns("IdProductor").Visible = False
    '    DgvCompras.Columns("IdModalidadCompra").Visible = False
    '    DgvCompras.Columns("Observaciones").Visible = False
    '    DgvCompras.Columns("CastigoMicros").Visible = False
    '    DgvCompras.Columns("CastigoLargoFibra").Visible = False
    '    DgvCompras.Columns("CastigoResistenciaFibra").Visible = False
    '    DgvCompras.Columns("TotalPesosMx").Visible = False
    '    DgvCompras.Columns("TotalDlls").Visible = False
    '    DgvCompras.Columns("InteresPesosMx").Visible = False
    '    DgvCompras.Columns("InteresDlls").Visible = False
    '    DgvCompras.Columns("PrecioQuintal").Visible = False
    '    DgvCompras.Columns("PrecioQuintalBorregos").Visible = False
    '    DgvCompras.Columns("Descuento").Visible = False
    '    DgvCompras.Columns("Total").Visible = False
    'End Sub
    Private Sub DgvContratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContratos.CellContentClick
        Dim filaSeleccionada As Integer = DgvContratos.CurrentRow.Index
        Dim countcheck As Integer = 0
        For Each row As DataGridViewRow In DgvContratos.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If Index = filaSeleccionada And DgvContratos.Rows(Index).Cells("Seleccionar").Value = False Then
                DgvContratos.Rows(Index).Cells("Seleccionar").Value = True
                TbPrecioQuintal.Text = DgvContratos.Rows(Index).Cells("PrecioQuintal").Value
                TbNoPacas.Text = DgvContratos.Rows(Index).Cells("Pacas").Value
                TbIdContrato.Text = DgvContratos.Rows(Index).Cells("IdCOntratoAlgodon").Value
            Else
                DgvContratos.Rows(Index).Cells("Seleccionar").Value = False
            End If
            If DgvContratos.Rows(Index).Cells("seleccionar").Value = True Then countcheck = countcheck + 1
        Next
        If countcheck = 0 Then
            TbPrecioQuintal.Text = ""
            TbNoPacas.Text = ""
            TbIdContrato.Text = ""
        End If
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
    Private Sub DgvLiqCompradas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLiqCompradas.CellContentClick
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
    Private Sub CuentaPacasMarcadas(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacasComprar.CellContentClick

    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar2.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If CheckFalse() = 0 Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        Else
            EntidadCompraPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarCompraPacasDet
            EntidadCompraPacasContrato.TablaGeneral = DataGridADatatable(1, 2, DgvPacasIndCompradas, 0, 1)
            NegocioCompraPacasContrato.Guardar(EntidadCompraPacasContrato)
            consultaDatosdgv()
        End If
    End Sub
    Private Sub BtBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtBuscarProductor.Click
        Dim _ConsultaProductorContratoCompras As New ConsultaProductorContratoCompras

        _ConsultaProductorContratoCompras.MdiParent = Me.MdiParent
        _ConsultaProductorContratoCompras.Opener = CType(Me, IForm)

        _ConsultaProductorContratoCompras.ShowDialog()
        ConsultarDatosCompra()
    End Sub
    Public Function LoadIdProductor(ByVal DatatableParam As DataTable) As Boolean Implements IForm.LoadIdProductor
        For Each row As DataRow In DatatableParam.Rows

            TbIdProductor.Text = row("IdProductor")
            TbNombreProductor.Text = row("Nombre")
        Next

        Return True
    End Function
    Private Sub BtSeleccionar_Click_1(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If TbIdProductor.Text = "" Or TbPrecioQuintal.Text = "" Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        ElseIf ValidaChecksPacas() > 0 Then
            If TbIdCompraPaca.Text = "" Then GuardarCompraEnc()
            EntidadCompraPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarCompraPacasDet
            EntidadCompraPacasContrato.TablaGeneral = DataGridADatatable(2, 1, DgvPacasComprar, TbIdCompraPaca.Text)
            NegocioCompraPacasContrato.Guardar(EntidadCompraPacasContrato)

            filtraPacasClases()
            VarGlob2.IdProductor = TbIdProductor.Text
            VarGlob2.NombreProductor = TbNombreProductor.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text

            '_Tabla = Table()
            'CompraPago.ShowDialog()
            'ConsultaCompra()
            consultaDatosdgv()
        Else
            MessageBox.Show("No hay pacas seleccionadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function Table() As DataTable
        Dim TablaRenglonAInsertar As DataRow
        TablaPacasAgrupadas.Rows.Clear()

        For ii As Integer = 0 To DgvPacasIndCompradas.Rows.Count - 1
            'If ValidaChecksDgv() = True Then
            Dim Quintales As Double = Math.Round(CDbl(DgvPacasIndCompradas.Rows(ii).Cells("Kilos").Value) / 46.02, 2)
            Dim TotalDlls As Double = Quintales * CDbl(TbPrecioQuintal.Text)

            TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()

            TablaRenglonAInsertar("BaleID") = DgvPacasIndCompradas.Rows(ii).Cells("BaleID").Value
            TablaRenglonAInsertar("Grade") = DgvPacasIndCompradas.Rows(ii).Cells("Grade").Value
            TablaRenglonAInsertar("Cantidad") = 1
            TablaRenglonAInsertar("Kilos") = DgvPacasIndCompradas.Rows(ii).Cells("Kilos").Value
            TablaRenglonAInsertar("Quintales") = Math.Round(Quintales, 2)
            'TablaRenglonAInsertar("CastigoResistenciaFibra") = Math.Round((DgvPacasIndCompradas.Rows(ii).Cells(8).Value * Quintales), 2)
            'TablaRenglonAInsertar("CastigoMicros") = Math.Round((DgvPacasIndCompradas.Rows(ii).Cells(7).Value * Quintales), 2)
            'TablaRenglonAInsertar("CastigoLargoFibra") = Math.Round((DgvPacasIndCompradas.Rows(ii).Cells(9).Value * Quintales), 2)
            TablaRenglonAInsertar("CastigoResistenciaFibra") = Math.Round(DgvPacasIndCompradas.Rows(ii).Cells(8).Value, 2)
            TablaRenglonAInsertar("CastigoMicros") = Math.Round(DgvPacasIndCompradas.Rows(ii).Cells(7).Value, 2)
            TablaRenglonAInsertar("CastigoLargoFibra") = Math.Round(DgvPacasIndCompradas.Rows(ii).Cells(9).Value, 2)
            TablaRenglonAInsertar("PrecioQuintal") = CDbl(TbPrecioQuintal.Text)
            TablaRenglonAInsertar("Total") = DgvPacasIndCompradas.Rows(ii).Cells("Kilos").Value
            TablaRenglonAInsertar("TotalDlls") = Math.Round(TotalDlls, 2)
            TablaPacasAgrupadas.Rows.Add(TablaRenglonAInsertar)

        Next
        Tabla = TablaModalidadCompra

        Dim query = From q In TablaPacasAgrupadas.AsEnumerable() Select q Order By q.Item("Grade")
        Dim dtResultado As New DataTable()
        dtResultado.Columns.Add("BaleID")
        dtResultado.Columns.Add("Grade")
        dtResultado.Columns.Add("Cantidad")
        dtResultado.Columns.Add("Kilos")
        dtResultado.Columns.Add("Quintales")
        dtResultado.Columns.Add("CastigoResistenciaFibra")
        dtResultado.Columns.Add("CastigoMicros")
        dtResultado.Columns.Add("CastigoLargoFibra")
        dtResultado.Columns.Add("PrecioQuintal")
        dtResultado.Columns.Add("Total")
        dtResultado.Columns.Add("TotalDlls")
        ''
        Dim dtCopy = query.CopyToDataTable()
        dtCopy.Rows.Add()
        Dim dr As DataRow = dtCopy.NewRow()
        Dim i, value, TotalPacas As Integer
        Dim TotalQuintales, TotalDolares, TotalCastigoLF, TotalCastigoM, TotalCastigoRF As Double
        For j As Integer = 0 To dtCopy.Rows.Count - 2
            Dim item = dtCopy.Rows(j)
            Dim BaleID = Convert.ToInt32(item(0))
            Dim Clase = Convert.ToString(item(1))
            Dim Cantidad = Convert.ToInt32(item(2))
            Dim Kilos = Convert.ToDouble(item(3))
            Dim Quintales = Convert.ToString(item(4))
            Dim CastigoRF = Convert.ToDouble(item(5))
            Dim CastigoM = Convert.ToDouble(item(6))
            Dim CastigoLF = Convert.ToDouble(item(7))
            Dim TbPrecioQuintalQuintal = Convert.ToInt32(item(8))
            Dim Total = Convert.ToDouble(item(9))
            Dim Dlls = Convert.ToDouble(item(10))
            Dim drr As DataRow = dtResultado.NewRow()
            drr.Item(0) = BaleID
            drr.Item(1) = Clase
            drr.Item(2) = Cantidad
            drr.Item(3) = Kilos
            drr.Item(4) = Quintales
            drr.Item(5) = Math.Round(CastigoRF, 2)
            drr.Item(6) = Math.Round(CastigoM, 2)
            drr.Item(7) = Math.Round(CastigoLF, 2)
            drr.Item(8) = TbPrecioQuintalQuintal
            drr.Item(9) = Math.Round(Total, 2)
            drr.Item(10) = Math.Round(Dlls, 2)
            dtResultado.ImportRow(item)
            Dim filaSig As String = Convert.ToString(dtCopy.Rows(i + 1).Item(1)) 'fila siguiente
            If (Clase = filaSig) Then 'clase actual es igual a la siguiente zona
                value += Kilos
                TotalQuintales += Quintales
                TotalCastigoLF += CastigoLF
                TotalCastigoM += CastigoM
                TotalCastigoRF += CastigoRF
                TotalPacas += Cantidad
                TotalDolares += Math.Round(Dlls, 2)
            Else 'cuando cambie la clase insertar nueva fila y poner "Total" & Clase
                drr.Item(0) = ""
                drr.Item(1) = "Total " & Clase
                drr.Item(2) = TotalPacas + Cantidad
                drr.Item(3) = value + Kilos
                drr.Item(4) = TotalQuintales + Quintales
                drr.Item(5) = Math.Round(TotalCastigoRF + CastigoRF, 2)
                drr.Item(6) = Math.Round(TotalCastigoM + CastigoM, 2)
                drr.Item(7) = Math.Round(TotalCastigoLF + CastigoLF, 2)
                drr.Item(8) = ""
                drr.Item(9) = ""
                drr.Item(10) = TotalDolares + Math.Round(Dlls, 2)
                dtResultado.Rows.Add(drr)
                value = 0
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
        EntidadCompraPacasContrato.IdCompra = CInt(TbIdCompraPaca.Text)
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        DgvPacasIndCompradas.Columns.Clear()
        DgvPacasIndCompradas.DataSource = Tabla
        PropiedadesDgvPacasIndCompradas()
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
