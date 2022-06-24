Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class PreliquidacionVenta
    Dim TablaUnidadPeso As New DataTable
    Dim TablaPacasAgrupadas As New DataTable
    Private Sub PreliquidacionVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargacombos()
        CargaCombosParametros()
    End Sub
    Private Sub BtBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtBuscarProductor.Click
        consultacomprador()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub consultacomprador()
        Dim ConsultaPre As New ConsultaCompradorPreliquidacion
        ConsultaPre.ShowDialog()
        Try
            If ConsultaPre.IdComprador > 0 Then
                Tbidcomprador.Text = ConsultaPre.IdComprador
                TbNombrecomprador.Text = ConsultaPre.nombrecomprador
                TbPrecioQuintal.Select()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargacombos()
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
        '-------------------------COMBO UNIDAD PESO
        Dim Tabla1 As New DataTable
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaUnidadPeso
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla1 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbUnidadPeso.DataSource = Tabla1
        CbUnidadPeso.ValueMember = "IdUnidadPeso"
        CbUnidadPeso.DisplayMember = "Descripcion"
        CbUnidadPeso.SelectedValue = -1
        TablaUnidadPeso = Tabla1
        '------------------------
        Dim Tabla2 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaExterna
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla2 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModalidadVenta.DataSource = Tabla2
        CbModalidadVenta.ValueMember = "IdModoEncabezado"
        CbModalidadVenta.DisplayMember = "Descripcion"
        CbModalidadVenta.SelectedValue = 1
    End Sub
    Private Sub Limpiar()
        ChMicros.Checked = True
        ChLargoFibra.Checked = True
        ChResistenciaFibra.Checked = True
        ChUniformidad.Checked = True
        CbModoMicros.SelectedIndex = 0
        CbModoLargoFibra.SelectedIndex = 0
        CbModoResistenciaFibra.SelectedIndex = 0
        CbModoUniformidad.SelectedIndex = 0
        CkTara.Checked = False
        Tbidcomprador.Text = ""
        TbNombrecomprador.Text = ""
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
        CbModalidadVenta.SelectedIndex = -1
        CbClasesPacasAcomprar.SelectedIndex = -1
        CbUnidadPeso.SelectedIndex = -1
        NuPesoTara.Value = 0
        DgvDatosLiquidacion.DataSource = Nothing
        DgvDatosLiquidacion.Columns.Clear()
        DgvPacasComprar.DataSource = Nothing
        DgvPacasComprar.Columns.Clear()
        dgvpacasexcel.DataSource = Nothing
        dgvpacasexcel.Columns.Clear()
        Panel1.Visible = False
        PanelCenter.Visible = True
    End Sub
    Private Sub CargaCombosParametros()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        '------------------------COMBO MICROS VENTA
        Dim Tabla2 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaMicrosVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla2 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoMicros.DataSource = Tabla2
        CbModoMicros.ValueMember = "IdModoEncabezado"
        CbModoMicros.DisplayMember = "Descripcion"
        CbModoMicros.SelectedIndex = 0
        '------------------------COMBO LARGO FIBRA VENTA
        Dim Tabla3 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaLargoFibraVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla3 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoLargoFibra.DataSource = Tabla3
        CbModoLargoFibra.ValueMember = "IdModoEncabezado"
        CbModoLargoFibra.DisplayMember = "Descripcion"
        CbModoLargoFibra.SelectedIndex = 0
        '------------------------COMBO RESISTENCIA VENTA
        Dim Tabla4 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaResistenciaVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla4 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoResistenciaFibra.DataSource = Tabla4
        CbModoResistenciaFibra.ValueMember = "IdModoEncabezado"
        CbModoResistenciaFibra.DisplayMember = "Descripcion"
        CbModoResistenciaFibra.SelectedIndex = 0
        '------------------------COMBO UNIFORMIDAD VENTA
        Dim Tabla5 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaUniformidadVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla5 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoUniformidad.DataSource = Tabla5
        CbModoUniformidad.ValueMember = "IdModoEncabezado"
        CbModoUniformidad.DisplayMember = "Descripcion"
        CbModoUniformidad.SelectedIndex = 0
    End Sub
    Private Sub SoloNumerosDecimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbPrecioQuintal.KeyPress, TbPuntos.KeyPress, TbPuntos.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CkTara_Click(sender As Object, e As EventArgs) Handles CkTara.Click
        If CkTara.Checked = True Then
            NuPesoTara.Enabled = True
            NuPesoTara.Select()
        Else
            NuPesoTara.Enabled = False
        End If
    End Sub

    Private Sub CbUnidadPeso_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbUnidadPeso.SelectionChangeCommitted
        If TablaUnidadPeso.Rows.Count > 0 Then
            For Each Fila As DataRow In TablaUnidadPeso.Rows
                If Fila.Item("IdUnidadPeso").ToString = CbUnidadPeso.SelectedValue Then
                    TbValorConversion.Text = Fila.Item("ValorConversion").ToString
                End If
            Next
        End If
    End Sub

    Private Sub BtGenerar_Click(sender As Object, e As EventArgs) Handles BtGenerar.Click
        If TbPrecioQuintal.Text <> "" And TbPuntos.Text <> "" Then
            Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
            Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
            Dim Tabla As New DataTable
            Try
                EntidadContratosAlgodon.IdExterno = CbModalidadVenta.SelectedValue
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
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Ingrese precio de quintal o los puntos")
        End If
    End Sub

    Private Sub BtExcel_Click(sender As Object, e As EventArgs) Handles BtExcel.Click
        importarExcelExternoventa(dgvpacasexcel)
        If Panel1.Visible = False And dgvpacasexcel.Rows.Count > 0 Then
            Panel1.Dock = DockStyle.Fill
            Panel1.Visible = True
            PanelCenter.Visible = False
            TbNoPacas.Text = dgvpacasexcel.Rows.Count
            TbKilosSeleccionados.Text = sumakilos()
        Else
            Panel1.Visible = False
            PanelCenter.Visible = True
        End If
    End Sub
    Private Function sumakilos()
        Dim sumar As Decimal
        Try
            For Each row As DataGridViewRow In dgvpacasexcel.Rows
                sumar = sumar + row.Cells("Kilos").Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return sumar
    End Function

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub VistaPreviaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VistaPreviaToolStripMenuItem.Click
        If Val(TbNoPacas.Text) > 0 And Tbidcomprador.Text <> "" And TbPrecioQuintal.Text <> "" And TbPuntos.Text <> "" And TbSM.Text <> "" Then
            Try
                Dim RepLiquidacion As New RepPreLiquidacionVenta(Table())
                RepLiquidacion.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No hay pacas seleccionadas, o hay campos en blanco.", MsgBoxStyle.Information, "Revisa captura de informacion!")
        End If
    End Sub
    Private Function ConsultaCastigoMicros(ByVal ValMicros As Decimal, ByVal Quintales As Decimal, ByVal etiqueta As Long)
        Dim Castigo As Decimal
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        'If bandera = 0 Then
        Try
            If ChMicros.Checked = True Then
                EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoMicros
                EntidadCompraPacasContrato.IdModoEncabezadoMicros = CbModoMicros.SelectedValue
                EntidadCompraPacasContrato.CastigoMicros = Math.Truncate(ValMicros * 100) / 100
                NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
                Tabla = EntidadCompraPacasContrato.TablaConsulta
                Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 2)
            Else
                Castigo = 0
            End If
        Catch ex As Exception
            Castigo = 0
            MsgBox(ex.Message & "Paca No " & etiqueta & " con micros " & ValMicros)
            Exit Function
        End Try

        Return Castigo
    End Function
    Private Function ConsultaCastigoResistenciaFibra(ByVal ValResistenciaFibra As Decimal, ByVal Quintales As Decimal, ByVal etiqueta As Long)
        Dim Castigo As Decimal
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        'If bandera = 0 Then
        Try
            If ChResistenciaFibra.Checked = True Then
                EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoResistenciaFibra
                EntidadCompraPacasContrato.IdModoEncabezadoResistencia = CbModoResistenciaFibra.SelectedValue
                EntidadCompraPacasContrato.CastigoResistenciaFibra = Math.Truncate(ValResistenciaFibra * 100) / 100
                NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
                Tabla = EntidadCompraPacasContrato.TablaConsulta
                Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 2)
            Else
                Castigo = 0
            End If
        Catch ex As Exception
            Castigo = 0
            MsgBox(ex.Message & "Paca No " & etiqueta & " con resistencia de fibra " & ValResistenciaFibra)
            Exit Function
        End Try

        Return Castigo
    End Function
    Private Function ConsultaCastigoLargoFibra(ByVal ValLargoFibra As Decimal, ByVal Quintales As Decimal, ByVal etiqueta As Long)
        Dim Castigo As Decimal
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        'If bandera = 0 Then
        Try
            If ChLargoFibra.Checked = True Then
                EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoLargoFibra
                EntidadCompraPacasContrato.IdModoEncabezadoLargoFibra = CbModoLargoFibra.SelectedValue
                EntidadCompraPacasContrato.CastigoLargoFibra = Math.Truncate(ValLargoFibra * 100) / 100
                NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
                Tabla = EntidadCompraPacasContrato.TablaConsulta
                Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 4)
            Else
                Castigo = 0
            End If
        Catch ex As Exception
            Castigo = 0
            MsgBox(ex.Message & "Paca No " & etiqueta & " con largo de fibra " & ValLargoFibra)
            Exit Function
        End Try

        Return Castigo
    End Function
    Private Function ConsultaCastigoUniformidad(ByVal ValUniformidad As Decimal, ByVal Quintales As Decimal, ByVal etiqueta As Long)
        Dim Castigo As Decimal
        Dim Tabla As New DataTable
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        'If bandera = 0 Then
        Try
            If ChUniformidad.Checked = True Then
                EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoUniformidad
                EntidadCompraPacasContrato.IdModoEncabezadoUniformidad = CbModoUniformidad.SelectedValue
                EntidadCompraPacasContrato.CastigoUniformidad = Math.Truncate(ValUniformidad * 100) / 100
                NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
                Tabla = EntidadCompraPacasContrato.TablaConsulta
                Castigo = Math.Round(Tabla.Rows(0).Item("Castigo") * Quintales, 4)
            Else
                Castigo = 0
            End If
        Catch ex As Exception
            Castigo = 0
            MsgBox(ex.Message & "Paca No " & etiqueta & " con largo de Uniformidad " & ValUniformidad)
            Exit Function
        End Try

        Return Castigo
    End Function
    Private Sub CrearTablaPacasAgrupadas()
        TablaPacasAgrupadas.Columns.Clear()
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Nombre", System.Type.GetType("System.String")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("IdComprador", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioBase", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("BaleID", System.Type.GetType("System.Int64")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Grade", System.Type.GetType("System.String")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Cantidad", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Kilos", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Tara", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("UnidadPeso", System.Type.GetType("System.String")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("ValorUnidadPeso", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("ResUnidad", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("TipoCambio", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioMxn", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoUniformidad", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoResistenciaFibra", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoMicros", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("CastigoLargoFibra", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioClase", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Total", System.Type.GetType("System.Decimal")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("TotalDlls", System.Type.GetType("System.Decimal")))
    End Sub
    Private Function Table() As DataTable
        CrearTablaPacasAgrupadas()
        Dim TablaRenglonAInsertar As DataRow
        TablaPacasAgrupadas.Rows.Clear()
        If CbUnidadPeso.SelectedValue = 1 Then
            For Each Fila As DataGridViewRow In dgvpacasexcel.Rows
                TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()
                Dim kilos As Decimal = (Fila.Cells("kilos").Value) - IIf(NuPesoTara.Value <> 0, NuPesoTara.Value, 0)
                Dim Quintales As Decimal = Math.Round(CDbl(kilos / 46.02), 4)
                Dim PrecioClase As Decimal = Math.Truncate((PrecioContratoClase(Fila.Cells("Grade").Value) / 100) * 10000) / 10000

                TablaRenglonAInsertar("Nombre") = TbNombrecomprador.Text
                TablaRenglonAInsertar("IdComprador") = Tbidcomprador.Text
                TablaRenglonAInsertar("PrecioBase") = CDec(TbPrecioQuintal.Text)
                TablaRenglonAInsertar("BaleID") = Fila.Cells("BaleID").Value
                TablaRenglonAInsertar("Grade") = Fila.Cells("Grade").Value
                TablaRenglonAInsertar("Cantidad") = 1
                TablaRenglonAInsertar("Kilos") = kilos
                TablaRenglonAInsertar("Tara") = NuPesoTara.Value
                TablaRenglonAInsertar("UnidadPeso") = CbUnidadPeso.Text
                TablaRenglonAInsertar("ValorUnidadPeso") = CDec(TbValorConversion.Text)
                TablaRenglonAInsertar("ResUnidad") = Quintales
                TablaRenglonAInsertar("TipoCambio") = 0
                TablaRenglonAInsertar("PrecioMxn") = 0
                TablaRenglonAInsertar("CastigoUniformidad") = (Math.Truncate(ConsultaCastigoUniformidad(Fila.Cells("ui").Value, Quintales, Fila.Cells("BaleID").Value) * 10000) / 10000)
                TablaRenglonAInsertar("CastigoResistenciaFibra") = (Math.Truncate(ConsultaCastigoResistenciaFibra(Fila.Cells("Strength").Value, Quintales, Fila.Cells("BaleID").Value) * 10000) / 10000)
                TablaRenglonAInsertar("CastigoMicros") = (Math.Truncate(ConsultaCastigoMicros(Fila.Cells("Mic").Value, Quintales, Fila.Cells("BaleID").Value) * 10) / 10)
                TablaRenglonAInsertar("CastigoLargoFibra") = (Math.Truncate(ConsultaCastigoLargoFibra(Fila.Cells("uhml").Value, Quintales, Fila.Cells("BaleID").Value) * 10000) / 10000)
                TablaRenglonAInsertar("PrecioClase") = PrecioClase
                TablaRenglonAInsertar("Total") = 0
                TablaRenglonAInsertar("TotalDlls") = Math.Truncate((Quintales * PrecioContratoClase(Fila.Cells("Grade").Value.ToString)) * 10000) / 10000
                TablaPacasAgrupadas.Rows.Add(TablaRenglonAInsertar)
            Next
        ElseIf CbUnidadPeso.SelectedValue = 2 Then
            For Each Fila As DataGridViewRow In dgvpacasexcel.Rows
                TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()
                Dim Kilos As Decimal = Fila.Cells("Kilos").Value - CDec(NuPesoTara.Value)
                Dim Libras As Decimal = Math.Truncate(Kilos * CDec(TbValorConversion.Text) * 10000) / 10000
                Dim PrecioClase As Decimal = Math.Truncate((PrecioContratoClase(Fila.Cells("Grade").Value) / 100) * 10000) / 10000

                TablaRenglonAInsertar("Nombre") = TbNombrecomprador.Text
                TablaRenglonAInsertar("IdComprador") = Tbidcomprador.Text
                TablaRenglonAInsertar("PrecioBase") = CDec(TbPrecioQuintal.Text)
                TablaRenglonAInsertar("BaleID") = Fila.Cells("BaleID").Value
                TablaRenglonAInsertar("Grade") = Fila.Cells("Grade").Value
                TablaRenglonAInsertar("Cantidad") = 1
                TablaRenglonAInsertar("Kilos") = Kilos
                TablaRenglonAInsertar("Tara") = NuPesoTara.Value
                TablaRenglonAInsertar("UnidadPeso") = CbUnidadPeso.Text
                TablaRenglonAInsertar("ValorUnidadPeso") = CDec(TbValorConversion.Text)
                TablaRenglonAInsertar("ResUnidad") = Libras
                TablaRenglonAInsertar("TipoCambio") = 0
                TablaRenglonAInsertar("PrecioMxn") = 0
                TablaRenglonAInsertar("CastigoUniformidad") = (Math.Truncate(ConsultaCastigoUniformidad(Fila.Cells("ui").Value, Libras, Fila.Cells("BaleID").Value) * 10000) / 10000) / 100
                TablaRenglonAInsertar("CastigoResistenciaFibra") = Math.Truncate((ConsultaCastigoResistenciaFibra(Fila.Cells("strength").Value, Libras, Fila.Cells("BaleID").Value) / 100) * 10000) / 10000
                TablaRenglonAInsertar("CastigoMicros") = (Math.Truncate(ConsultaCastigoMicros(Fila.Cells("Mic").Value, Libras, Fila.Cells("BaleID").Value) * 10000) / 10000) / 100
                TablaRenglonAInsertar("CastigoLargoFibra") = (Math.Truncate(ConsultaCastigoLargoFibra(Fila.Cells("uhml").Value, Libras, Fila.Cells("BaleID").Value) * 10000) / 10000) / 100
                TablaRenglonAInsertar("PrecioClase") = PrecioContratoClase(Fila.Cells("Grade").Value.ToString)
                TablaRenglonAInsertar("Total") = 0
                TablaRenglonAInsertar("TotalDlls") = Libras * PrecioClase
                TablaPacasAgrupadas.Rows.Add(TablaRenglonAInsertar)
            Next
        End If
        Return TablaPacasAgrupadas
    End Function
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
End Class