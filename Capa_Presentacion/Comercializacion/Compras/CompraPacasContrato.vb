Imports Capa_Operacion.Configuracion
Public Class CompraPacasContrato
    Implements IForm
    Public TablaModalidadCompra, TablacastigoMicros, TablaCastigoLargoFibra, TablaCastigoResistenciaFibra, TablaPacasAgrupadas, TablaPacasCompras As New DataTable
    Private PrecioSM, PrecioMP, PrecioM, PrecioSLMP, PrecioSLM, PrecioLMP, PrecioLM, PrecioSGO, PrecioGO, PrecioO As Double
    Private Sub CompraPacasContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearTablaPacasAgrupadas()
        CargarCombos()
        Nuevo()
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
            GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdCompraPaca.Text, "SE CREO/MODIFICO LA COMPRA CON EL ID " & TbIdCompraPaca.Text & " DEL PRODUCTOR " & TbNombreProductor.Text & " CON LA CANTIDAD DE " & TbPacasCompradasContrato.Text & " PACAS COMPRADAS DEL CONTRATO No " & TbIdContrato.Text & " CON " & TbNoPacas.Text & " PACAS.")
            filtraPacasClases()
            VarGlob2.IdProductor = TbIdProductor.Text
            VarGlob2.NombreProductor = TbNombreProductor.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text
            VarGlob2.IdCompra = TbIdCompraPaca.Text
            VarGlob2.IdContrato = TbIdContrato.Text
            VarGlob2.IdPlanta = CbPlanta.SelectedValue
            VarGlob2.IdModalidadCompra = CbModalidadCompra.SelectedValue

            _Tabla = Table()
            Dim ventanacompra As New CompraPago
            ventanacompra.ShowDialog()
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
        EntidadCompraPacasContrato.TotalPacas = DgvPacasIndCompradas.Rows.Count
        EntidadCompraPacasContrato.Observaciones = ""
        EntidadCompraPacasContrato.CastigoMicros = SumaCastigoMicros()
        EntidadCompraPacasContrato.CastigoLargoFibra = SumaCastigoLargo()
        EntidadCompraPacasContrato.CastigoResistenciaFibra = SumaCastigoResistencia()
        EntidadCompraPacasContrato.CastigoUniformidad = SumaCastigoUniformidad()
        EntidadCompraPacasContrato.CastigoBarkLevel1 = 0
        EntidadCompraPacasContrato.CastigoBarkLevel2 = 0
        EntidadCompraPacasContrato.CastigoPrepLevel1 = 0
        EntidadCompraPacasContrato.CastigoPrepLevel2 = 0
        EntidadCompraPacasContrato.CastigoOtherLevel1 = 0
        EntidadCompraPacasContrato.CastigoOtherLevel2 = 0
        EntidadCompraPacasContrato.CastigoPlasticLevel1 = 0
        EntidadCompraPacasContrato.CastigoPlasticLevel2 = 0
        EntidadCompraPacasContrato.IdUnidadPeso = 0
        EntidadCompraPacasContrato.ValorConversacion = 0
        EntidadCompraPacasContrato.Unidad = 0
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
    Private Function SumaCastigoMicros()
        Dim Resultado As Double = 0
        If DgvPacasIndCompradas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPacasIndCompradas.Rows
                If Not Fila Is Nothing Then
                    Resultado = Resultado + Fila.Cells("castigoMicCompra").Value
                End If
            Next
        End If
        Return Resultado
    End Function
    Private Function SumaCastigoResistencia()
        Dim Resultado As Double = 0
        If DgvPacasIndCompradas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPacasIndCompradas.Rows
                If Not Fila Is Nothing Then
                    Resultado = Resultado + Fila.Cells("CastigoResistenciaFibraCompra").Value
                End If
            Next
        End If
        Return Resultado
    End Function
    Private Function SumaCastigoLargo()
        Dim Resultado As Double = 0
        If DgvPacasIndCompradas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPacasIndCompradas.Rows
                If Not Fila Is Nothing Then
                    Resultado = Resultado + Fila.Cells("CastigoLargoFibraCompra").Value
                End If
            Next
        End If
        Return Resultado
    End Function
    Private Function SumaCastigoUniformidad()
        Dim Resultado As Double = 0
        If DgvPacasIndCompradas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPacasIndCompradas.Rows
                If Not Fila Is Nothing Then
                    Resultado = Resultado + Fila.Cells("CastigoUniformidadCompra").Value
                End If
            Next
        End If
        Return Resultado
    End Function
    Private Function DataGridADatatable(ByVal EstatusCompraUpdate As Integer, ByVal EstatusCompraBusqueda As Integer, ByVal DataGridEnvia As DataGridView, ByVal IdCompraEnc As Integer, Optional valcastigo As Integer = 0) As DataTable
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Add("IdProductor", Type.GetType("System.Int32"))
        dt.Columns.Add("BaleID", Type.GetType("System.Int64"))
        dt.Columns.Add("Quintales", Type.GetType("System.Single"))
        dt.Columns.Add("PrecioClase", Type.GetType("System.Single"))
        dt.Columns.Add("IdPlantaOrigen", Type.GetType("System.Int32"))
        dt.Columns.Add("IdLiquidacion", Type.GetType("System.Int32"))
        dt.Columns.Add("IdCompraEnc", Type.GetType("System.Int32"))
        dt.Columns.Add("PrecioDls", Type.GetType("System.Single"))
        dt.Columns.Add("TipoCambio", Type.GetType("System.Single"))
        dt.Columns.Add("PrecioMxn", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoUniformidad", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoResistenciaFibra", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoMicros", Type.GetType("System.Single"))
        dt.Columns.Add("CastigoLargoFibra", Type.GetType("System.Single"))
        dt.Columns.Add("estatuscompraUpdate", Type.GetType("System.Int32"))
        dt.Columns.Add("estatuscompraBusqueda", Type.GetType("System.Int32"))

        For i = 0 To DataGridEnvia.Rows.Count - 1
            r = dt.NewRow
            If DataGridEnvia.Item("Seleccionar", i).EditedFormattedValue = True Then
                Dim Quintales As Double = Math.Round(DataGridEnvia.Item("Quintales", i).Value, 4)
                r("IdProductor") = TbIdProductor.Text
                r("IdPlantaOrigen") = DataGridEnvia.Item("IdPlantaOrigen", i).Value.ToString
                r("BaleID") = DataGridEnvia.Item("BaleID", i).Value.ToString
                r("Quintales") = Math.Truncate(Quintales * 10000) / 10000
                r("PrecioClase") = PrecioContratoClase(DataGridEnvia.Item("Grade", i).Value.ToString)
                r("IdLiquidacion") = DataGridEnvia.Item("IdLiquidacion", i).Value.ToString
                r("IdCompraEnc") = IdCompraEnc
                r("PrecioDls") = Math.Truncate((Quintales * PrecioContratoClase(DataGridEnvia.Item("Grade", i).Value.ToString)) * 10000) / 10000
                r("TipoCambio") = 0
                r("PrecioMxn") = 0
                r("CastigoUniformidad") = IIf(ChUniformidad.Checked = True, Math.Truncate(ConsultaCastigoUniformidad(DataGridEnvia.Item(13, i).Value.ToString, Quintales, valcastigo) * 10000) / 10000, 0)
                r("CastigoResistenciaFibra") = IIf(ChResistenciaFibra.Checked = True, Math.Truncate(ConsultaCastigoResistenciaFibra(DataGridEnvia.Item(15, i).Value.ToString, Quintales, valcastigo) * 10000) / 10000, 0)
                r("CastigoMicros") = IIf(ChMicros.Checked = True, Math.Truncate(ConsultaCastigoMicros(DataGridEnvia.Item(14, i).Value.ToString, Quintales, valcastigo) * 10000) / 10000, 0)
                r("CastigoLargoFibra") = IIf(ChLargoFibra.Checked = True, Math.Truncate(ConsultaCastigoLargoFibra(DataGridEnvia.Item(16, i).Value.ToString, Quintales, valcastigo) * 10000) / 10000, 0)
                r("estatuscompraUpdate") = EstatusCompraUpdate
                r("EstatusCompraBusqueda") = EstatusCompraBusqueda
                dt.Rows.Add(r)
            End If
        Next
        Return dt
    End Function
    Private Sub CuentaPacasMarcadas() Handles DgvPacasComprar.CellContentClick

    End Sub
    Private Function ValidaChecksPacas()
        DgvPacasComprar.EndEdit()
        Dim PacasMarcadas As Integer = 0
        For i As Integer = 0 To DgvPacasComprar.Rows.Count - 1
            If DgvPacasComprar.Rows(i).Cells("Seleccionar").EditedFormattedValue = True Then
                PacasMarcadas = PacasMarcadas + 1
            End If
        Next
        Return PacasMarcadas
    End Function
    Private Function ValidaChecksPacasCompradas()
        DgvPacasIndCompradas.EndEdit()
        Dim PacasMarcadas As Integer = 0
        For i As Integer = 0 To DgvPacasIndCompradas.Rows.Count - 1
            If DgvPacasIndCompradas.Rows(i).Cells("Seleccionar").EditedFormattedValue = True Then
                PacasMarcadas = PacasMarcadas + 1
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
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim _ConsultaCompraProductor As New ConsultaCompraProductor

        _ConsultaCompraProductor.MdiParent = Me.MdiParent
        _ConsultaCompraProductor.Opener = CType(Me, IForm)

        _ConsultaCompraProductor.ShowDialog()
        ConsultarDatosCompra()
        ConsultaParametrosCompra()
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
        TbPacasCompradasContrato.Text = ""
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
        ChBark.Checked = False
        ChPrep.Checked = False
        ChOther.Checked = False
        ChPlastic.Checked = False
        ChBarkLevel1.Checked = False
        ChBarkLevel2.Checked = False
        ChPrepLevel1.Checked = False
        ChPrepLevel2.Checked = False
        ChOtherLevel1.Checked = False
        ChOtherLevel2.Checked = False
        ChPlasticLevel1.Checked = False
        ChPlasticLevel2.Checked = False
        ChMicros.Checked = False
        ChResistenciaFibra.Checked = False
        ChLargoFibra.Checked = False
        ChUniformidad.Checked = False
        CbModoLargoFibra.SelectedIndex = -1
        CbModoMicros.SelectedIndex = -1
        CbModoResistenciaFibra.SelectedIndex = -1
        CbModoUniformidad.SelectedIndex = -1
        CbModoBark.SelectedIndex = -1
        CbModoPrep.SelectedIndex = -1
        CbModoOther.SelectedIndex = -1
        CbModoPlastic.SelectedIndex = -1
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
        CbPlanta.SelectedValue = -1
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
        '-----------------------COMBO BARK
        Dim dtBark As DataTable = New DataTable("Tabla")
        dtBark.Columns.Add("Id")
        dtBark.Columns.Add("Descripcion")
        Dim drBark As DataRow
        drBark = dtBark.NewRow()
        drBark("Id") = "1"
        drBark("Descripcion") = "Bark"
        dtBark.Rows.Add(drBark)
        CbModoBark.DataSource = dtBark
        CbModoBark.ValueMember = "Id"
        CbModoBark.DisplayMember = "Descripcion"
        CbModoBark.SelectedIndex = 0
        '-----------------------COMBO PREP
        Dim dtPrep As DataTable = New DataTable("Tabla")
        dtPrep.Columns.Add("Id")
        dtPrep.Columns.Add("Descripcion")
        Dim drPrep As DataRow
        drPrep = dtPrep.NewRow()
        drPrep("Id") = "2"
        drPrep("Descripcion") = "Prep"
        dtPrep.Rows.Add(drPrep)
        CbModoPrep.DataSource = dtPrep
        CbModoPrep.ValueMember = "Id"
        CbModoPrep.DisplayMember = "Descripcion"
        CbModoPrep.SelectedIndex = 0
        '-----------------------COMBO OTHER
        Dim dtOther As DataTable = New DataTable("Tabla")
        dtOther.Columns.Add("Id")
        dtOther.Columns.Add("Descripcion")
        Dim drOther As DataRow
        drOther = dtOther.NewRow()
        drOther("Id") = "3"
        drOther("Descripcion") = "Other"
        dtOther.Rows.Add(drOther)
        CbModoOther.DataSource = dtOther
        CbModoOther.ValueMember = "Id"
        CbModoOther.DisplayMember = "Descripcion"
        CbModoOther.SelectedIndex = 0
        '-----------------------COMBO PLASTIC
        Dim dtPlastic As DataTable = New DataTable("Tabla")
        dtPlastic.Columns.Add("Id")
        dtPlastic.Columns.Add("Descripcion")
        Dim drPlastic As DataRow
        drPlastic = dtPlastic.NewRow()
        drPlastic("Id") = "4"
        drPlastic("Descripcion") = "Plastic"
        dtPlastic.Rows.Add(drPlastic)
        CbModoPlastic.DataSource = dtPlastic
        CbModoPlastic.ValueMember = "Id"
        CbModoPlastic.DisplayMember = "Descripcion"
        CbModoPlastic.SelectedIndex = 0
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
    Private Sub ConsultaParametrosCompra()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.ContratosAlgodon
        Dim NegocioCompraPacasContrato As New Capa_Negocio.ContratosAlgodon
        Dim TablaDetalle As New DataTable
        Dim TablaParametros As New DataTable
        EntidadCompraPacasContrato.IdContratoAlgodon = Val(TbIdContrato.Text)
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaParametrosContratoCompra
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        TablaParametros = EntidadCompraPacasContrato.TablaConsulta
        If TablaParametros.Rows.Count > 0 Then
            ChMicros.Checked = TablaParametros.Rows(0).Item("CheckMicros")
            CbModoMicros.SelectedValue = TablaParametros.Rows(0).Item("IdModoMicros")
            ChLargoFibra.Checked = TablaParametros.Rows(0).Item("CheckLargo")
            CbModoLargoFibra.SelectedValue = TablaParametros.Rows(0).Item("IdModoLargoFibra")
            ChResistenciaFibra.Checked = TablaParametros.Rows(0).Item("CheckResistencia")
            CbModoResistenciaFibra.SelectedValue = TablaParametros.Rows(0).Item("IdModoResistencia")
            ChUniformidad.Checked = TablaParametros.Rows(0).Item("CheckUniformidad")
            CbModoUniformidad.SelectedValue = TablaParametros.Rows(0).Item("IdModoUniformidad")
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
            DgvContratos.Columns.Insert(22, colSelCon)
            PropiedadesDgvContratos()
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
            SeleccionaContratoConsultado()
            TbPacasCompradasContrato.Text = DgvPacasIndCompradas.Rows.Count
        End If
    End Sub
    Private Sub SeleccionaContratoConsultado()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If TbIdCompraPaca.Text <> "" Then
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaIdCompraPaca
            EntidadCompraPacasContrato.IdCompra = CInt(TbIdCompraPaca.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            If DgvContratos.Rows.Count > 0 Then
                For Each Fila As DataGridViewRow In DgvContratos.Rows
                    If Tabla.Rows(0).Item("IdContratoAlgodon").ToString = Fila.Cells("IdContratoAlgodon").Value.ToString Then
                        Fila.Cells("Seleccionar").Value = True
                        TbIdContrato.Text = Fila.Cells("IdContratoAlgodon").Value
                        TbPrecioQuintal.Text = Fila.Cells("PrecioSM").Value
                        TbNoPacas.Text = Fila.Cells("Pacas").Value
                        CbModalidadCompra.SelectedValue = Fila.Cells("IdModalidadCompra").Value
                        PrecioSM = Fila.Cells("PrecioSM").Value
                        PrecioMP = Fila.Cells("PrecioMP").Value
                        PrecioM = Fila.Cells("PrecioM").Value
                        PrecioSLMP = Fila.Cells("PrecioSLMP").Value
                        PrecioSLM = Fila.Cells("PrecioSLM").Value
                        PrecioLMP = Fila.Cells("PrecioLMP").Value
                        PrecioLM = Fila.Cells("PrecioLM").Value
                        PrecioSGO = Fila.Cells("PrecioSGO").Value
                        PrecioGO = Fila.Cells("PrecioGO").Value
                        PrecioO = Fila.Cells("PrecioO").Value
                    End If
                Next
            End If
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
    Private Sub PropiedadesDgvLiquidacionesCompradas()
        DgvLiqCompradas.Columns("IdOrdenTrabajo").HeaderText = "No Orden"

        DgvLiqCompradas.Columns("Seleccionar").ReadOnly = False
        DgvLiqCompradas.Columns("PacasCantidad").ReadOnly = True
        DgvLiqCompradas.Columns("PacasCompradas").ReadOnly = True
        DgvLiqCompradas.Columns("IdOrdenTrabajo").ReadOnly = True

        DgvLiqCompradas.Columns("IdLiquidacion").Visible = False
        DgvLiqCompradas.Columns("TotalHueso").Visible = False
        DgvLiqCompradas.Columns("PacasDisponibles").Visible = False
        DgvLiqCompradas.Columns("PesoPluma").Visible = False
        DgvLiqCompradas.Columns("TotalSemilla").Visible = False
        DgvLiqCompradas.Columns("IdCliente").Visible = False
        DgvLiqCompradas.Columns("IdCompraEnc").Visible = False
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
    Private Sub PropiedadesDgvContratos()
        DgvContratos.Columns("IdContratoAlgodon").HeaderText = "Contrato"

        DgvContratos.Columns("IdContratoAlgodon").ReadOnly = True
        DgvContratos.Columns("Pacas").ReadOnly = True
        DgvContratos.Columns("PacasCompradas").ReadOnly = True
        DgvContratos.Columns("PrecioQuintal").ReadOnly = True
        DgvContratos.Columns("PacasCompradas").ReadOnly = True
        DgvContratos.Columns("PacasDisponibles").ReadOnly = True

        DgvContratos.Columns("SuperficieComprometida").Visible = False
        DgvContratos.Columns("FechaLiquidacion").Visible = False
        DgvContratos.Columns("Puntos").Visible = False
        DgvContratos.Columns("IdProductor").Visible = False
        DgvContratos.Columns("Temporada").Visible = False
        DgvContratos.Columns("IdModalidadCompra").Visible = False
        DgvContratos.Columns("PrecioSM").Visible = False
        DgvContratos.Columns("PrecioMP").Visible = False
        DgvContratos.Columns("preciom").Visible = False
        DgvContratos.Columns("PrecioSLMP").Visible = False
        DgvContratos.Columns("PrecioSLM").Visible = False
        DgvContratos.Columns("PrecioLMP").Visible = False
        DgvContratos.Columns("PrecioLM").Visible = False
        DgvContratos.Columns("PrecioSGO").Visible = False
        DgvContratos.Columns("PrecioGO").Visible = False
        DgvContratos.Columns("PrecioO").Visible = False
        DgvContratos.Columns("Fecha").Visible = False
    End Sub
    Private Sub PropiedadesDgvPacasIndCompradas()
        DgvPacasIndCompradas.Columns("FolioCIA").Visible = False
        'DgvPacasIndCompradas.Columns("CastigoResistenciaFibraCompra").Visible = False
        'DgvPacasIndCompradas.Columns("CastigoMicCompra").Visible = False
        'DgvPacasIndCompradas.Columns("CastigoLargoFibraCompra").Visible = False
        'DgvPacasIndCompradas.Columns("CastigoUniformidadCompra").Visible = False
        DgvPacasIndCompradas.Columns("TipoCambio").Visible = False
        DgvPacasIndCompradas.Columns("PrecioMxn").Visible = False
        DgvPacasIndCompradas.Columns("Descripcion").Visible = False
        DgvPacasIndCompradas.Columns("IdLiquidacion").Visible = False
        DgvPacasIndCompradas.Columns("Quintales").Visible = False
        DgvPacasIndCompradas.Columns("PrecioClase").Visible = False
        DgvPacasIndCompradas.Columns("PrecioDls").Visible = False

        DgvPacasIndCompradas.Columns("BaleID").ReadOnly = True
        DgvPacasIndCompradas.Columns("IdOrdenTrabajo").ReadOnly = True
        DgvPacasIndCompradas.Columns("IdPlantaOrigen").ReadOnly = True
        DgvPacasIndCompradas.Columns("Kilos").ReadOnly = True
        DgvPacasIndCompradas.Columns("Grade").ReadOnly = True
        DgvPacasIndCompradas.Columns("CastigoResistenciaFibraCompra").ReadOnly = True
        DgvPacasIndCompradas.Columns("CastigoMicCompra").ReadOnly = True
        DgvPacasIndCompradas.Columns("CastigoLargoFibraCompra").ReadOnly = True
        DgvPacasIndCompradas.Columns("CastigoUniformidadCompra").ReadOnly = True

        DgvPacasIndCompradas.Columns("BaleID").HeaderText = "Etiqueta"
        DgvPacasIndCompradas.Columns("IdOrdenTrabajo").HeaderText = "No Orden"
        DgvPacasIndCompradas.Columns("IdPlantaOrigen").HeaderText = "Planta"
        DgvPacasIndCompradas.Columns("Grade").HeaderText = "Clase"
        DgvPacasIndCompradas.Columns("CastigoResistenciaFibraCompra").HeaderText = "Castigo RF"
        DgvPacasIndCompradas.Columns("CastigoMicCompra").HeaderText = "Castigo Mic"
        DgvPacasIndCompradas.Columns("CastigoLargoFibraCompra").HeaderText = "Castigo LF"
        DgvPacasIndCompradas.Columns("CastigoUniformidadCompra").HeaderText = "Castigo UI"
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
                TbPrecioQuintal.Text = DgvContratos.Rows(Index).Cells("PrecioSM").Value
                TbNoPacas.Text = DgvContratos.Rows(Index).Cells("Pacas").Value
                TbIdContrato.Text = DgvContratos.Rows(Index).Cells("IdCOntratoAlgodon").Value
                CbModalidadCompra.SelectedValue = DgvContratos.Rows(Index).Cells("IdModalidadCompra").Value
                PrecioSM = DgvContratos.Rows(Index).Cells("PrecioSM").Value
                PrecioMP = DgvContratos.Rows(Index).Cells("PrecioMP").Value
                PrecioM = DgvContratos.Rows(Index).Cells("PrecioM").Value
                PrecioSLMP = DgvContratos.Rows(Index).Cells("PrecioSLMP").Value
                PrecioSLM = DgvContratos.Rows(Index).Cells("PrecioSLM").Value
                PrecioLMP = DgvContratos.Rows(Index).Cells("PrecioLMP").Value
                PrecioLM = DgvContratos.Rows(Index).Cells("PrecioLM").Value
                PrecioSGO = DgvContratos.Rows(Index).Cells("PrecioSGO").Value
                PrecioGO = DgvContratos.Rows(Index).Cells("PrecioGO").Value
                PrecioO = DgvContratos.Rows(Index).Cells("PrecioO").Value
                ConsultaParametrosCompra()
            Else
                DgvContratos.Rows(Index).Cells("Seleccionar").Value = False
            End If
            If DgvContratos.Rows(Index).Cells("seleccionar").Value = True Then countcheck = countcheck + 1
        Next
        If countcheck = 0 Then
            TbPrecioQuintal.Text = ""
            TbNoPacas.Text = ""
            TbIdContrato.Text = ""
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
            ChBark.Checked = False
            ChPrep.Checked = False
            ChOther.Checked = False
            ChPlastic.Checked = False
            ChBarkLevel1.Checked = False
            ChBarkLevel2.Checked = False
            ChPrepLevel1.Checked = False
            ChPrepLevel2.Checked = False
            ChOtherLevel1.Checked = False
            ChOtherLevel2.Checked = False
            ChPlasticLevel1.Checked = False
            ChPlasticLevel2.Checked = False
            ChMicros.Checked = False
            ChResistenciaFibra.Checked = False
            ChLargoFibra.Checked = False
            ChUniformidad.Checked = False
            CbModoLargoFibra.SelectedIndex = -1
            CbModoMicros.SelectedIndex = -1
            CbModoResistenciaFibra.SelectedIndex = -1
            CbModoUniformidad.SelectedIndex = -1
            CbModoBark.SelectedIndex = -1
            CbModoPrep.SelectedIndex = -1
            CbModoOther.SelectedIndex = -1
            CbModoPlastic.SelectedIndex = -1
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
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar2.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        Dim PacasCompradas As Integer = 0
        Dim PacasDisponibles As Integer = 0
        Dim PacasMarcadas As Integer = 0
        If DgvContratos.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvContratos.Rows
                If Fila.Cells("IdContratoAlgodon").Value.ToString = TbIdContrato.Text Then
                    PacasCompradas = Fila.Cells("PacasCompradas").Value
                    PacasDisponibles = Fila.Cells("PacasDisponibles").Value
                    PacasMarcadas = ValidaChecksPacasCompradas()
                End If
            Next
        End If
        If CheckFalse() = 0 Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        Else
            If PacasMarcadas <= PacasCompradas And PacasMarcadas > 0 Then
                If TbIdCompraPaca.Text = "" Then GuardarCompraEnc()
                EntidadCompraPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarCompraPacasDet
                EntidadCompraPacasContrato.TablaGeneral = DataGridADatatable(1, 2, DgvPacasIndCompradas, 0, 1)
                NegocioCompraPacasContrato.Guardar(EntidadCompraPacasContrato)
                consultaDatosdgv()
                For Each Fila As DataGridViewRow In DgvContratos.Rows
                    If Fila.Cells("IdContratoAlgodon").Value.ToString = TbIdContrato.Text Then
                        Fila.Cells("PacasCompradas").Value = Fila.Cells("PacasCompradas").Value - PacasMarcadas
                        Fila.Cells("PacasDisponibles").Value = Fila.Cells("PacasDisponibles").Value + PacasMarcadas
                        ActualizaPacasDisponiblesContrato(Fila.Cells("IdContratoAlgodon").Value, Fila.Cells("PacasCompradas").Value, Fila.Cells("PacasDisponibles").Value)
                    End If
                Next
                TbPacasCompradasContrato.Text = DgvPacasIndCompradas.Rows.Count
            ElseIf PacasMarcadas > PacasCompradas Then
                MsgBox("La cantidad de pacas seleccionadas a devolucion, es mayor a la comprada, revise la seleccion de pacas o el contrato.", MsgBoxStyle.Information)
            ElseIf PacasMarcadas = 0 Then
                MessageBox.Show("No hay pacas seleccionadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub
    Private Sub BtBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtBuscarProductor.Click
        Dim _ConsultaProductorContratoCompras As New ConsultaProductorContratoCompras
        Nuevo()
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
        Dim PacasCompradas As Integer = 0
        Dim PacasDisponibles As Integer = 0
        Dim PacasSeleccionadas As Integer = 0
        If DgvContratos.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvContratos.Rows
                If Fila.Cells("IdContratoAlgodon").Value.ToString = TbIdContrato.Text Then
                    PacasCompradas = Fila.Cells("PacasCompradas").Value
                    PacasDisponibles = Fila.Cells("PacasDisponibles").Value
                    PacasSeleccionadas = ValidaChecksPacas()
                End If
            Next
        End If
        If TbIdProductor.Text = "" Or TbPrecioQuintal.Text = "" Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        ElseIf (PacasSeleccionadas + PacasCompradas) > Val(TbNoPacas.Text) Then
            MsgBox("Las Pacas Seleccionadas Superan la cantidad de pacas del contrato. Revise la seleccion o que el contrato sea el correcto.")
        ElseIf PacasSeleccionadas > 0 And PacasSeleccionadas > Val(TbNoPacas.Text) Then
            MsgBox("Las Pacas Seleccionadas Superan la cantidad de pacas del contrato. Revise la seleccion o que el contrato sea el correcto.")
        ElseIf PacasSeleccionadas > 0 And PacasSeleccionadas <= Val(TbNoPacas.Text) Then
            If TbIdCompraPaca.Text = "" Then GuardarCompraEnc()
            EntidadCompraPacasContrato.Guarda = Guardar.GuardarCompraPacasDet
            EntidadCompraPacasContrato.TablaGeneral = DataGridADatatable(2, 1, DgvPacasComprar, TbIdCompraPaca.Text)
            NegocioCompraPacasContrato.Guardar(EntidadCompraPacasContrato)

            'filtraPacasClases()
            VarGlob2.IdProductor = TbIdProductor.Text
            VarGlob2.NombreProductor = TbNombreProductor.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text

            '_Tabla = Table()
            'CompraPago.ShowDialog()
            'ConsultaCompra()
            consultaDatosdgv()
            For Each Fila As DataGridViewRow In DgvContratos.Rows
                If Fila.Cells("IdContratoAlgodon").Value.ToString = TbIdContrato.Text Then
                    Fila.Cells("PacasCompradas").Value = Fila.Cells("PacasCompradas").Value + PacasSeleccionadas
                    Fila.Cells("PacasDisponibles").Value = Fila.Cells("PacasDisponibles").Value - PacasSeleccionadas
                    ActualizaPacasDisponiblesContrato(Fila.Cells("IdContratoAlgodon").Value, Fila.Cells("PacasCompradas").Value, Fila.Cells("PacasDisponibles").Value)
                End If
            Next
            TbPacasCompradasContrato.Text = DgvPacasIndCompradas.Rows.Count
        Else
            MessageBox.Show("No hay pacas seleccionadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ActualizaPacasDisponiblesContrato(ByVal IdContrato As Integer, ByVal PacasCompradas As Integer, ByVal PacasDisponibles As Integer)
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Actualiza = Actualiza.ActualizaPacasDisponibles
        EntidadCompraPacasContrato.IdContrato = IdContrato
        EntidadCompraPacasContrato.PacasCompradas = PacasCompradas
        EntidadCompraPacasContrato.PacasDisponibles = PacasDisponibles
        NegocioCompraPacasContrato.Actualizar(EntidadCompraPacasContrato)
    End Sub
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
    Private Function Table() As DataTable
        Dim TablaRenglonAInsertar As DataRow
        TablaPacasAgrupadas.Rows.Clear()

        For ii As Integer = 0 To DgvPacasIndCompradas.Rows.Count - 1
            'If ValidaChecksDgv() = True Then
            Dim Quintales As Double = Math.Round(CDbl(DgvPacasIndCompradas.Rows(ii).Cells("Kilos").Value) / 46.02, 4)
            'Dim TotalDlls As Double = Quintales * CDbl(TbPrecioQuintal.Text)
            Dim TotalDlls As Double = Quintales * PrecioContratoClase(DgvPacasIndCompradas.Rows(ii).Cells("Grade").Value)
            TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()

            TablaRenglonAInsertar("BaleID") = DgvPacasIndCompradas.Rows(ii).Cells("BaleID").Value
            TablaRenglonAInsertar("Grade") = DgvPacasIndCompradas.Rows(ii).Cells("Grade").Value
            TablaRenglonAInsertar("Cantidad") = 1
            TablaRenglonAInsertar("Kilos") = DgvPacasIndCompradas.Rows(ii).Cells("Kilos").Value
            TablaRenglonAInsertar("Quintales") = Math.Round(Quintales, 4)
            TablaRenglonAInsertar("TipoCambio") = 0 'Math.Round((DgvPacasIndCompradas.Rows(ii).Cells(7).Value * Quintales), 4)
            TablaRenglonAInsertar("PrecioMxn") = 0 'Math.Round((DgvPacasIndCompradas.Rows(ii).Cells(9).Value * Quintales), 4)
            TablaRenglonAInsertar("CastigoUniformidad") = IIf(ChUniformidad.Checked = True, Math.Round(DgvPacasIndCompradas.Rows(ii).Cells("CastigoUniformidadCompra").Value, 2), 0)
            TablaRenglonAInsertar("CastigoResistenciaFibra") = IIf(ChResistenciaFibra.Checked = True, Math.Round(DgvPacasIndCompradas.Rows(ii).Cells("CastigoResistenciaFibraCompra").Value, 2), 0)
            TablaRenglonAInsertar("CastigoMicros") = IIf(ChMicros.Checked = True, Math.Round(DgvPacasIndCompradas.Rows(ii).Cells("castigoMicCompra").Value, 2), 0)
            TablaRenglonAInsertar("CastigoLargoFibra") = IIf(ChLargoFibra.Checked = True, Math.Round(DgvPacasIndCompradas.Rows(ii).Cells("CastigoLargoFibraCompra").Value, 2), 0)
            TablaRenglonAInsertar("PrecioClase") = DgvPacasIndCompradas.Rows(ii).Cells("PrecioClase").Value
            TablaRenglonAInsertar("Total") = 0 'DgvPacasIndCompradas.Rows(ii).Cells("Kilos").Value
            TablaRenglonAInsertar("TotalDlls") = Math.Truncate(DgvPacasIndCompradas.Rows(ii).Cells("PrecioDls").Value * 10000) / 10000
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
            Dim BaleID = Convert.ToInt64(item(0))
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

        '---Consultar pacas compradas
        'EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPacaComprada
        'EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
        'EntidadCompraPacasContrato.IdCompra = Val(TbIdCompraPaca.Text)
        'NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        'Tabla = EntidadCompraPacasContrato.TablaConsulta
        'DgvPacasIndCompradas.Columns.Clear()
        'DgvPacasIndCompradas.DataSource = Tabla
        'PropiedadesDgvPacasIndCompradas()
        'ConsultaCantidadPacas()
        'TotalPacasContrato()
        'MarcaSeleccionDisponibles()
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