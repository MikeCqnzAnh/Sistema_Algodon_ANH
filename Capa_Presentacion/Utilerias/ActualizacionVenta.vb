Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ActualizacionVenta
    Private Sub ActualizacionVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
        CargaCombosParametros()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim consultaventa As New ConsultaVentasAct
        consultaventa.ShowDialog()
        TbIdVentaPaca.Text = consultaventa._idventa
        TbIdContrato.Text = consultaventa._IdContrato
        TbIdComprador.Text = consultaventa._IdComprador
        TbNombreComprador.Text = consultaventa._Nombre
        If TbIdVentaPaca.Text > 0 Then
            ConsultaParametrosVenta()
            ConsultaDatosCompra()
            SeleccionaContratoConsultado()
            CargaListaRangos()
        End If
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
    Private Sub CargarCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable

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
    Private Sub ConsultaParametrosVenta()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim TablaDetalle As New DataTable
        Dim TablaParametros As New DataTable
        EntidadContratosAlgodonCompradores.IdContratoAlgodon = Val(TbIdContrato.Text)
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaParametrosContratoVenta
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        TablaParametros = EntidadContratosAlgodonCompradores.TablaConsulta
        If TablaParametros.Rows.Count > 0 Then
            ChMicros.Checked = TablaParametros.Rows(0).Item("CheckMicros")
            CbModoMicros.SelectedValue = TablaParametros.Rows(0).Item("IdModoMicros")
            ChLargoFibra.Checked = TablaParametros.Rows(0).Item("CheckLargo")
            CbModoLargoFibra.SelectedValue = TablaParametros.Rows(0).Item("IdModoLargoFibra")
            ChResistenciaFibra.Checked = TablaParametros.Rows(0).Item("CheckResistencia")
            CbModoResistenciaFibra.SelectedValue = TablaParametros.Rows(0).Item("IdModoResistencia")
            ChUniformidad.Checked = TablaParametros.Rows(0).Item("CheckUniformidad")
            CbModoUniformidad.SelectedValue = TablaParametros.Rows(0).Item("IdModoUniformidad")
            ChBark.Checked = TablaParametros.Rows(0).Item("CheckBark")
            CbModoBark.SelectedValue = TablaParametros.Rows(0).Item("IdModoBark")
            ChBarkLevel1.Checked = TablaParametros.Rows(0).Item("CheckBarkLevel1")
            ChBarkLevel2.Checked = TablaParametros.Rows(0).Item("CheckBarkLevel2")
            ChPrep.Checked = TablaParametros.Rows(0).Item("CheckPrep")
            CbModoPrep.SelectedValue = TablaParametros.Rows(0).Item("IdModoPrep")
            ChPrepLevel1.Checked = TablaParametros.Rows(0).Item("CheckPrepLevel1")
            ChPrepLevel2.Checked = TablaParametros.Rows(0).Item("CheckPrepLevel2")
            ChOther.Checked = TablaParametros.Rows(0).Item("CheckOther")
            CbModoOther.SelectedValue = TablaParametros.Rows(0).Item("IdModoOther")
            ChOtherLevel1.Checked = TablaParametros.Rows(0).Item("CheckOtherLevel1")
            ChOtherLevel2.Checked = TablaParametros.Rows(0).Item("CheckOtherLevel2")
            ChPlastic.Checked = TablaParametros.Rows(0).Item("CheckPlastic")
            CbModoPlastic.SelectedValue = TablaParametros.Rows(0).Item("IdModoPlastic")
            ChPlasticLevel1.Checked = TablaParametros.Rows(0).Item("CheckPlasticLevel1")
            ChPlasticLevel2.Checked = TablaParametros.Rows(0).Item("CheckPlasticLevel2")
            'NuPesoTara.Value = TablaParametros.Rows(0).Item("KilosNeto")
            TbPesoTara.Text = TablaParametros.Rows(0).Item("KilosNeto")
            CkTara.Checked = TablaParametros.Rows(0).Item("EstatusPesoNeto")

            TbPesoTara.Text = Format(Val(TbPesoTara.Text), "#,##0.00")
        End If
    End Sub
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
        End If
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

        DgvContratos.Columns("Pacas").DefaultCellStyle.Format = "N2"
        DgvContratos.Columns("PacasVendidas").DefaultCellStyle.Format = "N2"
        DgvContratos.Columns("PacasDisponibles").DefaultCellStyle.Format = "N2"
        DgvContratos.Columns("PrecioQuintal").DefaultCellStyle.Format = "N4"

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
                        TbIdContrato.Text = Tabla.Rows(0).Item("IdContratoAlgodon")
                        TbPrecioQuintal.Text = Fila.Cells("PrecioSM").Value
                        TbNoPacas.Text = Fila.Cells("Pacas").Value
                        CbModalidadVenta.SelectedValue = Fila.Cells("IdModalidadVenta").Value
                        CbUnidadPeso.SelectedValue = Fila.Cells("IdUnidadPeso").Value
                        TbValorConversion.Text = Fila.Cells("ValorConversion").Value
                        'LbUnidad.Text = CbUnidadPeso.Text
                        TbKdAd.Text = Tabla.Rows(0).Item("Unidad")
                        'PrecioSM = Fila.Cells("PrecioSM").Value
                        'PrecioMP = Fila.Cells("PrecioMP").Value
                        'PrecioM = Fila.Cells("PrecioM").Value
                        'PrecioSLMP = Fila.Cells("PrecioSLMP").Value
                        'PrecioSLM = Fila.Cells("PrecioSLM").Value
                        'PrecioLMP = Fila.Cells("PrecioLMP").Value
                        'PrecioLM = Fila.Cells("PrecioLM").Value
                        'PrecioSGO = Fila.Cells("PrecioSGO").Value
                        'PrecioGO = Fila.Cells("PrecioGO").Value
                        'PrecioO = Fila.Cells("PrecioO").Value

                        TbNoPacas.Text = Format(Val(TbNoPacas.Text), "#,##0.00")
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub CargaListaRangos()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        'Dim Tabla, TablaGeneral As New DataTable
        Dim ds As New DataSet

        'ds.Tables.Add(tablaidventa)
        If ChLargoFibra.CheckState = CheckState.Checked Then
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaLarRango
            EntidadVentaPacasContrato.IdVenta = TbIdVentaPaca.Text
            EntidadVentaPacasContrato.IdModoEncabezado = CbModoLargoFibra.SelectedValue
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Dgvlargofibra.DataSource = EntidadVentaPacasContrato.TablaConsulta
            propiedadesdgv(Dgvlargofibra)
            'ds.Tables.Add(TablaGeneral)
        Else
            Dgvlargofibra.DataSource = ""
        End If

        If ChMicros.CheckState = CheckState.Checked Then
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaMicRango
            EntidadVentaPacasContrato.IdVenta = TbIdVentaPaca.Text
            EntidadVentaPacasContrato.IdModoEncabezado = CbModoMicros.SelectedValue
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            DgvMicros.DataSource = EntidadVentaPacasContrato.TablaConsulta
            propiedadesdgv(DgvMicros)
            'ds.Tables.Add(TablaGeneral)
        Else
            DgvMicros.DataSource = ""
        End If

        If ChResistenciaFibra.CheckState = CheckState.Checked Then
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaResRango
            EntidadVentaPacasContrato.IdVenta = TbIdVentaPaca.Text
            EntidadVentaPacasContrato.IdModoEncabezado = CbModoResistenciaFibra.SelectedValue
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Dgvresistencia.DataSource = EntidadVentaPacasContrato.TablaConsulta
            propiedadesdgv(Dgvresistencia)
            'ds.Tables.Add(TablaGeneral)
        Else
            Dgvresistencia.DataSource = ""
        End If

        If ChUniformidad.CheckState = CheckState.Checked Then
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaUniRango
            EntidadVentaPacasContrato.IdVenta = TbIdVentaPaca.Text
            EntidadVentaPacasContrato.IdModoEncabezado = CbModoUniformidad.SelectedValue
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            Dgvuniformidad.DataSource = EntidadVentaPacasContrato.TablaConsulta
            'ds.Tables.Add(TablaGeneral)
            propiedadesdgv(Dgvuniformidad)
        Else
            Dgvuniformidad.DataSource = ""
        End If

    End Sub
    Private Sub propiedadesdgv(dgv As DataGridView)
        dgv.Columns("Rango1").ReadOnly = True
        dgv.Columns("Rango2").ReadOnly = True
        dgv.Columns("Castigo").ReadOnly = True
        dgv.Columns("NoPacas").ReadOnly = True

        Dim i As Integer
        For i = 0 To dgv.Columns.Count - 1
            dgv.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next i
    End Sub
    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Try
            If Dgvlargofibra.Rows.Count > 0 Then
                For i As Integer = 0 To Dgvlargofibra.Rows.Count - 1
                    If Dgvlargofibra.Rows.Item(i).Cells("sel").Value = True And Dgvlargofibra.Rows.Item(i).Cells("NoPacas").Value > 0 And Dgvlargofibra.Rows.Item(i).Cells("RanMod").Value > 0 Then
                        MsgBox("Esta seleccionado")
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "Largo fibra")
        End Try
        Try
            If DgvMicros.Rows.Count > 0 Then
                For i As Integer = 0 To DgvMicros.Rows.Count - 1
                    If DgvMicros.Rows.Item(i).Cells("sel").Value = True And DgvMicros.Rows.Item(i).Cells("NoPacas").Value > 0 And DgvMicros.Rows.Item(i).Cells("RanMod").Value > 0 Then
                        MsgBox("Esta seleccionado")
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "Micros")
        End Try
        Try
            If Dgvresistencia.Rows.Count > 0 Then
                For i As Integer = 0 To Dgvresistencia.Rows.Count - 1
                    If Dgvresistencia.Rows.Item(i).Cells("sel").Value = True And Dgvresistencia.Rows.Item(i).Cells("NoPacas").Value > 0 And Dgvresistencia.Rows.Item(i).Cells("RanMod").Value > 0 Then
                        MsgBox("Esta seleccionado")
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "Resistencias")
        End Try
        Try
            If Dgvuniformidad.Rows.Count > 0 Then
                For i As Integer = 0 To Dgvuniformidad.Rows.Count - 1
                    If Dgvuniformidad.Rows.Item(i).Cells("sel").Value = True And Dgvuniformidad.Rows.Item(i).Cells("NoPacas").Value > 0 And Dgvuniformidad.Rows.Item(i).Cells("RanMod").Value > 0 Then
                        MsgBox("Esta seleccionado")
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "Uniformidad")
        End Try
    End Sub
    Private Sub Dgvlargofibra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvlargofibra.CellContentClick
        Dgvlargofibra.EndEdit()
        Dim index As Integer
        Try
            If Dgvlargofibra.Rows.Count > 0 Then
                index = Dgvlargofibra.CurrentCell.RowIndex
                If index > 0 Then
                    If Dgvlargofibra.Rows(index).Cells("sel").Value = True And Dgvlargofibra.Rows(index).Cells("NoPacas").Value > 0 Then
                        Dgvlargofibra.Rows(index).Cells("RanMod").Value = generanuevovalor(Dgvlargofibra.Rows(index - 1).Cells("Rango1").Value, Dgvlargofibra.Rows(index - 1).Cells("Rango2").Value)
                    ElseIf Dgvlargofibra.Rows(index).Cells("sel").Value = False Then
                        Dgvlargofibra.Rows(index).Cells("RanMod").Value = "0.00"
                    End If
                Else
                    MsgBox("Este es el maximo valor de la tabla, no se puede cambiar")
                    Dgvlargofibra.Rows(index).Cells("sel").Value = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "Micros")
        End Try
    End Sub
    Private Sub Dgvresistencia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvresistencia.CellContentClick
        Dgvresistencia.EndEdit()
        Dim index As Integer
        Try
            If Dgvresistencia.Rows.Count > 0 Then
                index = Dgvresistencia.CurrentCell.RowIndex
                If index > 0 Then
                    If Dgvresistencia.Rows(index).Cells("sel").Value = True And Dgvresistencia.Rows(index).Cells("NoPacas").Value > 0 Then
                        Dgvresistencia.Rows(index).Cells("RanMod").Value = generanuevovalor(Dgvresistencia.Rows(index - 1).Cells("Rango1").Value, Dgvresistencia.Rows(index - 1).Cells("Rango2").Value)
                    ElseIf Dgvresistencia.Rows(index).Cells("sel").Value = False Then
                        Dgvresistencia.Rows(index).Cells("RanMod").Value = "0.00"
                    End If
                Else
                    MsgBox("Este es el maximo valor de la tabla, no se puede cambiar")
                    Dgvresistencia.Rows(index).Cells("sel").Value = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "Micros")
        End Try
    End Sub

    Private Sub Dgvuniformidad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvuniformidad.CellContentClick
        Dgvuniformidad.EndEdit()
        Dim index As Integer
        Try
            If Dgvuniformidad.Rows.Count > 0 Then
                index = Dgvuniformidad.CurrentCell.RowIndex
                If index > 0 Then
                    If Dgvuniformidad.Rows(index).Cells("sel").Value = True And Dgvuniformidad.Rows(index).Cells("NoPacas").Value > 0 Then
                        Dgvuniformidad.Rows(index).Cells("RanMod").Value = generanuevovalor(Dgvuniformidad.Rows(index - 1).Cells("Rango1").Value, Dgvuniformidad.Rows(index - 1).Cells("Rango2").Value)
                    ElseIf Dgvuniformidad.Rows(index).Cells("sel").Value = False Then
                        Dgvuniformidad.Rows(index).Cells("RanMod").Value = "0.00"
                    End If
                Else
                    MsgBox("Este es el maximo valor de la tabla, no se puede cambiar")
                    Dgvuniformidad.Rows(index).Cells("sel").Value = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "Micros")
        End Try
    End Sub
    Private Sub DgvMicros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMicros.CellContentClick
        DgvMicros.EndEdit()
        Dim index As Integer
        Try
            If DgvMicros.Rows.Count > 0 Then
                index = DgvMicros.CurrentCell.RowIndex
                If index > 0 Then
                    If DgvMicros.Rows(index).Cells("sel").Value = True And DgvMicros.Rows(index).Cells("NoPacas").Value > 0 Then
                        DgvMicros.Rows(index).Cells("RanMod").Value = generanuevovalor(DgvMicros.Rows(index - 1).Cells("Rango1").Value, DgvMicros.Rows(index - 1).Cells("Rango2").Value)
                    ElseIf DgvMicros.Rows(index).Cells("sel").Value = False Then
                        DgvMicros.Rows(index).Cells("RanMod").Value = "0.00"
                    End If
                Else
                    MsgBox("Este es el maximo valor de la tabla, no se puede cambiar")
                    DgvMicros.Rows(index).Cells("sel").Value = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "Micros")
        End Try
    End Sub
    Private Function generanuevovalor(ByVal rango1 As Decimal, ByVal rango2 As Decimal)
        Dim resultado As Decimal
        Dim rnd As New Random()
        Dim strArr1(), strArr2() As String
        Dim stringvalor1, stringvalor2 As String
        stringvalor1 = Convert.ToString(rango1)
        stringvalor2 = Convert.ToString(rango2)
        strArr1 = stringvalor1.Split(".")
        strArr2 = stringvalor2.Split(".")
        Dim nrnd2 As Decimal = rnd.Next(strArr1(1), IIf(strArr2(1) = 0, 99, strArr2(1)))
        Dim nrnd1 As Integer = rnd.Next(strArr1(0), strArr2(0))
        resultado = Convert.ToInt32(nrnd1) + (nrnd2 / 100)
        Return resultado
    End Function

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
        Dispose()
    End Sub
End Class