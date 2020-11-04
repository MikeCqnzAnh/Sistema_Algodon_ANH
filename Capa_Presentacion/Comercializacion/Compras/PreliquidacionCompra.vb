Imports Capa_Operacion.Configuracion
Public Class PreliquidacionCompra
    Public TablaPacasAgrupadas As New DataTable
    Private Sub PreliquidacionCompra_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
        Limpiar()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub BtBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtBuscarProductor.Click
        ConsultaProductor()
        ConsultarDatosCompra()
    End Sub
    Private Sub CrearTablaPacasAgrupadas()
        TablaPacasAgrupadas.Columns.Clear()
        TablaPacasAgrupadas.Columns.Add(New DataColumn("BaleID", System.Type.GetType("System.Int64")))
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
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Nombre", System.Type.GetType("System.String")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("IdProductor", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioBase", System.Type.GetType("System.Double")))
    End Sub
    Private Sub ConsultarDatosCompra()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If TbIdProductor.Text = 0 Then
            MsgBox("Seleccionar a un productor para ver sus contratos", MsgBoxStyle.Exclamation)
        Else
            '---Consultar liquidaciones del productor
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaLiquidaciones
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvDatosLiquidacion.Columns.Clear()
            DgvDatosLiquidacion.DataSource = Tabla
            PropiedadesDgvLiquidacionesComprar()
            '---Consultar las pacas ya clasificadas del productor
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPaca
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvPacasComprar.Columns.Clear()
            DgvPacasComprar.DataSource = Tabla
            PropiedadesDgvPacasComprar()
        End If
    End Sub
    Private Sub PropiedadesDgvLiquidacionesComprar()
        DgvDatosLiquidacion.Columns("IdLiquidacion").Visible = False
        DgvDatosLiquidacion.Columns("IdOrdenTrabajo").ReadOnly = True
        DgvDatosLiquidacion.Columns("IdOrdenTrabajo").HeaderText = "No Orden"
        DgvDatosLiquidacion.Columns("TotalHueso").ReadOnly = True
        DgvDatosLiquidacion.Columns("PacasCantidad").ReadOnly = True
        DgvDatosLiquidacion.Columns("PacasDisponibles").ReadOnly = True
        DgvDatosLiquidacion.Columns("PacasCompradas").ReadOnly = True
        DgvDatosLiquidacion.Columns("PesoPluma").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvPacasComprar()

        DgvPacasComprar.Columns("IdOrdenTrabajo").HeaderText = "No Orden"
        DgvPacasComprar.Columns("BaleId").HeaderText = "Etiqueta"
        DgvPacasComprar.Columns("Grade").HeaderText = "Clase"
        DgvPacasComprar.Columns("IdPlantaOrigen").HeaderText = "Planta"

        DgvPacasComprar.Columns("PrecioClase").Visible = False
        DgvPacasComprar.Columns("PrecioDls").Visible = False
        DgvPacasComprar.Columns("TipoCambio").Visible = False
        DgvPacasComprar.Columns("PrecioMxn").Visible = False
        DgvPacasComprar.Columns("FolioCIA").Visible = False
        DgvPacasComprar.Columns("Descripcion").Visible = False
        DgvPacasComprar.Columns("IdLiquidacion").Visible = False
        DgvPacasComprar.Columns("Quintales").Visible = False
        DgvPacasComprar.Columns("Uniformidad").Visible = False
        DgvPacasComprar.Columns("Micros").Visible = False
        DgvPacasComprar.Columns("Resistencia").Visible = False
        DgvPacasComprar.Columns("Largo").Visible = False

        DgvPacasComprar.Columns("IdOrdenTrabajo").ReadOnly = True
        DgvPacasComprar.Columns("IdPlantaOrigen").ReadOnly = True
        DgvPacasComprar.Columns("Descripcion").ReadOnly = True
        DgvPacasComprar.Columns("BaleId").ReadOnly = True
        DgvPacasComprar.Columns("Kilos").ReadOnly = True
        DgvPacasComprar.Columns("Grade").ReadOnly = True

    End Sub
    Private Function PrecioContratoClase(ByVal Clase As String) As Double
        Dim resultado As Double = 0
        Select Case Clase
            Case "SM"
                resultado = Val(TbSM.Text) * -1
            Case "MP"
                resultado = Val(TbMP.Text) * -1
            Case "M"
                resultado = Val(TbM.Text) * -1
            Case "SLMP"
                resultado = Val(TbSLMP.Text) * -1
            Case "SLM"
                resultado = Val(TbSLM.Text) * -1
            Case "LMP"
                resultado = Val(TbLMP.Text) * -1
            Case "LM"
                resultado = Val(TbLM.Text) * -1
            Case "SGO"
                resultado = Val(TbSGO.Text) * -1
            Case "GO"
                resultado = Val(TbGO.Text) * -1
            Case "O"
                resultado = Val(TbO.Text) * -1
        End Select
        Return resultado
    End Function
    Private Function ConsultaCastigoMicros(ByVal ValMicros As Double, ByVal Quintales As Double, Optional bandera As Integer = 0)
        Dim Castigo As Double
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If bandera = 0 Then
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoMicros
            EntidadCompraPacasContrato.IdModoEncabezadoMicros = CbModoMicros.SelectedValue
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
            EntidadCompraPacasContrato.IdModoEncabezadoResistencia = CbModoResistenciaFibra.SelectedValue
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
            EntidadCompraPacasContrato.IdModoEncabezadoLargoFibra = CbModoLargoFibra.SelectedValue
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
            EntidadCompraPacasContrato.IdModoEncabezadoUniformidad = CbModoUniformidad.SelectedValue
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
    Private Function Table() As DataTable
        CrearTablaPacasAgrupadas()
        Dim TablaRenglonAInsertar As DataRow
        TablaPacasAgrupadas.Rows.Clear()

        For ii As Integer = 0 To DgvPacasComprar.Rows.Count - 1
            If DgvPacasComprar.Rows(ii).Cells("Seleccionar").Value = True Then
                Dim Quintales As Double = Math.Round(CDbl(DgvPacasComprar.Rows(ii).Cells("Kilos").Value) / 46.02, 4)
                'Dim TotalDlls As Double = Quintales * CDbl(TbPrecioQuintal.Text)
                Dim TotalDlls As Double = Quintales * PrecioContratoClase(DgvPacasComprar.Rows(ii).Cells("Grade").Value)
                TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()

                TablaRenglonAInsertar("Nombre") = TbNombreProductor.Text
                TablaRenglonAInsertar("IdProductor") = TbIdProductor.Text
                TablaRenglonAInsertar("PrecioBase") = TbPrecioQuintal.Text
                TablaRenglonAInsertar("BaleID") = DgvPacasComprar.Rows(ii).Cells("BaleID").Value
                TablaRenglonAInsertar("Grade") = DgvPacasComprar.Rows(ii).Cells("Grade").Value
                TablaRenglonAInsertar("Cantidad") = 1
                TablaRenglonAInsertar("Kilos") = DgvPacasComprar.Rows(ii).Cells("Kilos").Value
                TablaRenglonAInsertar("Quintales") = Math.Round(Quintales, 4)
                TablaRenglonAInsertar("TipoCambio") = 0 'Math.Round((DgvPacasIndCompradas.Rows(ii).Cells(7).Value * Quintales), 4)
                TablaRenglonAInsertar("PrecioMxn") = 0 'Math.Round((DgvPacasIndCompradas.Rows(ii).Cells(9).Value * Quintales), 4)
                TablaRenglonAInsertar("CastigoUniformidad") = IIf(ChUniformidad.Checked = True, Math.Truncate(ConsultaCastigoUniformidad(DgvPacasComprar.Rows(ii).Cells("Uniformidad").Value.ToString, Quintales) * 10000) / 10000, 0)
                TablaRenglonAInsertar("CastigoResistenciaFibra") = IIf(ChResistenciaFibra.Checked = True, Math.Truncate(ConsultaCastigoResistenciaFibra(DgvPacasComprar.Rows(ii).Cells("Resistencia").Value.ToString, Quintales) * 10000) / 10000, 0)
                TablaRenglonAInsertar("CastigoMicros") = IIf(ChMicros.Checked = True, Math.Truncate(ConsultaCastigoMicros(DgvPacasComprar.Rows(ii).Cells("Micros").Value.ToString, Quintales) * 10000) / 10000, 0)
                TablaRenglonAInsertar("CastigoLargoFibra") = IIf(ChLargoFibra.Checked = True, Math.Truncate(ConsultaCastigoLargoFibra(DgvPacasComprar.Rows(ii).Cells("Largo").Value.ToString, Quintales) * 10000) / 10000, 0)
                TablaRenglonAInsertar("PrecioClase") = PrecioContratoClase(DgvPacasComprar.Rows(ii).Cells("Grade").Value.ToString)
                TablaRenglonAInsertar("Total") = 0 'DgvPacasIndCompradas.Rows(ii).Cells("Kilos").Value
                TablaRenglonAInsertar("TotalDlls") = Math.Truncate((Quintales * PrecioContratoClase(DgvPacasComprar.Rows(ii).Cells("Grade").Value.ToString)) * 10000) / 10000
                TablaPacasAgrupadas.Rows.Add(TablaRenglonAInsertar)
            End If
        Next
        Return TablaPacasAgrupadas
    End Function
    Private Sub ConsultaProductor()
        Dim EntidadPreliquidacionCompra As New Capa_Entidad.PreliquidacionCompra
        Dim NegocioPreliquidacionCompra As New Capa_Negocio.PreliquidacionCompra
        Dim Tabla As New DataTable
        Dim ConsultaPre As New ConsultaClientePreliquidacion
        ConsultaPre.ShowDialog()
        EntidadPreliquidacionCompra.IdCliente = ConsultaPre.IdCliente
        EntidadPreliquidacionCompra.Consulta = Consulta.ConsultaDetallada
        NegocioPreliquidacionCompra.Consultar(EntidadPreliquidacionCompra)
        Tabla = EntidadPreliquidacionCompra.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            TbIdProductor.Text = Tabla.Rows(0).Item("IdCliente")
            TbNombreProductor.Text = Tabla.Rows(0).Item("Nombre")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub VistaPreviaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VistaPreviaToolStripMenuItem.Click
        If Val(TbNoPacas.Text) > 0 And TbIdProductor.Text <> "" And TbPrecioQuintal.Text <> "" And TbPuntos.Text <> "" And TbSM.Text <> "" Then
            Dim RepLiquidacion As New RepPreliquidacionCompra(Table())
            RepLiquidacion.ShowDialog()
        Else
            MsgBox("No hay pacas seleccionadas, o hay campos en blanco.", MsgBoxStyle.Information, "Revisa captura de informacion!")
        End If
    End Sub

    Private Sub Limpiar()
        ChMicros.Checked = True
        ChLargoFibra.Checked = True
        ChResistenciaFibra.Checked = True
        ChUniformidad.Checked = True
        CbModoMicros.SelectedValue = 1
        CbModoLargoFibra.SelectedValue = 1
        CbModoResistenciaFibra.SelectedValue = 1
        CbModoUniformidad.SelectedValue = 1
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        CbPlanta.SelectedValue = 1
        TbPrecioQuintal.Text = ""
        DtFechaCompra.Value = Now
        TbPuntos.Text = ""
        TbNoPacas.Text = ""
        TbKilosSeleccionados.Text = ""
        TbSM.Text = ""
        TbMP.Text = ""
        TbM.Text = ""
        TbSLMP.Text = ""
        TbSLM.Text = ""
        TbLMP.Text = ""
        TbLM.Text = ""
        TbSGO.Text = ""
        TbGO.Text = ""
        TbO.Text = ""
        TbDesdePaca.Text = ""
        TbHastaPaca.Text = ""
        CbModalidadCompra.SelectedValue = 1
        CbClasesPacasAcomprar.SelectedValue = -1
        DgvDatosLiquidacion.DataSource = Nothing
        DgvDatosLiquidacion.Columns.Clear()
        DgvPacasComprar.DataSource = Nothing
        DgvPacasComprar.Columns.Clear()
    End Sub
    Private Sub SoloNumerosDecimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbPrecioQuintal.KeyPress, TbPuntos.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub SoloNumerosEntero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbDesdePaca.KeyPress, TbHastaPaca.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub CargaCombos()
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
        '--Modalidad de Compra
        LLenaComboInstancias(CbClasesPacasAcomprar)
        '---Modalidad De Compra--
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim Tabla3 As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaModoCompra
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla3 = EntidadProduccion.TablaConsulta
        CbModalidadCompra.DataSource = Tabla3
        CbModalidadCompra.ValueMember = "IdModoEncabezado"
        CbModalidadCompra.DisplayMember = "Descripcion"
        CbModalidadCompra.SelectedValue = 1
        '------------------------COMBO MICROS VENTA
        Dim Tabla2 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaMicrosCompraCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla2 = EntidadContratosAlgodon.TablaConsulta
        CbModoMicros.DataSource = Tabla2
        CbModoMicros.ValueMember = "IdModoEncabezado"
        CbModoMicros.DisplayMember = "Descripcion"
        CbModoMicros.SelectedIndex = 0
        '------------------------COMBO LARGO FIBRA VENTA
        Dim Table3 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaLargoFibraCompraCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Table3 = EntidadContratosAlgodon.TablaConsulta
        CbModoLargoFibra.DataSource = Table3
        CbModoLargoFibra.ValueMember = "IdModoEncabezado"
        CbModoLargoFibra.DisplayMember = "Descripcion"
        CbModoLargoFibra.SelectedIndex = 0
        '------------------------COMBO RESISTENCIA VENTA
        Dim Tabla4 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaResistenciaCompraCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla4 = EntidadContratosAlgodon.TablaConsulta
        CbModoResistenciaFibra.DataSource = Tabla4
        CbModoResistenciaFibra.ValueMember = "IdModoEncabezado"
        CbModoResistenciaFibra.DisplayMember = "Descripcion"
        CbModoResistenciaFibra.SelectedIndex = 0
        '------------------------COMBO UNIFORMIDAD VENTA
        Dim Tabla5 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaUniformidadCompraCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla5 = EntidadContratosAlgodon.TablaConsulta
        CbModoUniformidad.DataSource = Tabla5
        CbModoUniformidad.ValueMember = "IdModoEncabezado"
        CbModoUniformidad.DisplayMember = "Descripcion"
        CbModoUniformidad.SelectedIndex = 0
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
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        _Tabla.Clear()
        Me.Close()
    End Sub
    Private Sub BtGenerar_Click(sender As Object, e As EventArgs) Handles BtGenerar.Click
        If TbPrecioQuintal.Text <> "" And TbPuntos.Text <> "" Then
            Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
            Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
            Dim Tabla As New DataTable
            EntidadContratosAlgodon.IdExterno = CbModalidadCompra.SelectedValue
            EntidadContratosAlgodon.Consulta = Consulta.ConsultaDiferenciales
            NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
            Tabla = EntidadContratosAlgodon.TablaConsulta
            TbSM.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(0).Item("Diferencial")) - TbPrecioQuintal.Text)
            TbMP.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(1).Item("Diferencial")) - TbPrecioQuintal.Text)
            TbM.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(2).Item("Diferencial")) - TbPrecioQuintal.Text)
            TbSLMP.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(3).Item("Diferencial")) - TbPrecioQuintal.Text)
            TbSLM.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(4).Item("Diferencial")) - TbPrecioQuintal.Text)
            TbLMP.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(5).Item("Diferencial")) - TbPrecioQuintal.Text)
            TbLM.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(6).Item("Diferencial")) - TbPrecioQuintal.Text)
            TbSGO.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(7).Item("Diferencial")) - TbPrecioQuintal.Text)
            TbGO.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(8).Item("Diferencial")) - TbPrecioQuintal.Text)
            TbO.Text = (CDbl(Val(TbPuntos.Text) + Tabla.Rows(9).Item("Diferencial")) - TbPrecioQuintal.Text)
        Else
            MsgBox("Ingrese precio de quintal o los puntos")
        End If
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
        TbNoPacas.Text = Contador
        TbKilosSeleccionados.Text = Kilos
        TbKilosSeleccionados.Text = Format(Val(TbKilosSeleccionados.Text), "#,##0.00")
    End Sub

    Private Sub DgvPacasComprar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacasComprar.CellContentClick
        MarcaSeleccionDisponibles()
    End Sub

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
            MarcaSeleccionDisponibles()
        End If
    End Sub

    Private Sub BtExcel_Click(sender As Object, e As EventArgs) Handles BtExcel.Click
        If DgvPacasComprar.Rows.Count > 0 Then
            CargaExcel.ShowDialog()
            Try
                If TablaExcel.Rows.Count > 0 Then
                    For Each rowTabla As DataRow In TablaExcel.Rows
                        For Each rowGrid As DataGridViewRow In DgvPacasComprar.Rows
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
        Else
            MsgBox("No hay pacas para seleccionar.", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
End Class