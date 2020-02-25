Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
Public Class LiquidacionesPorRomaneaje
    Public TablaCombos As New DataTable
    Public TablaComparacion As New DataTable
    Public Bandera As Boolean
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub LlenarCombos()
        Dim EntidadTierras As New Capa_Entidad.Tierras
        Dim NegocioTierras As New Capa_Negocio.Tierras
        EntidadTierras.LlenaCombo = LlenaCombo.LlenaComboCliente
        NegocioTierras.ConsultarCombo(EntidadTierras)
        TablaCombos = EntidadTierras.TablaConsulta
        CbNombreCliente.DataSource = TablaCombos
        CbNombreCliente.DisplayMember = "Nombre"
        CbNombreCliente.ValueMember = "IdCliente"
        CbNombreCliente.SelectedIndex = -1
        '---------------------------CONSULTA ASOCIACIONES   
        Dim tabla9 As New DataTable
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        'EntidadClientes.IdEstadoApoderado = CbEstadoApoderado.SelectedValue
        EntidadClientes.Consulta = Consulta.ConsultaAsociaciones
        NegocioClientes.Consultar(EntidadClientes)
        tabla9 = EntidadClientes.TablaConsulta
        CbPorCuenta.DataSource = tabla9
        CbPorCuenta.ValueMember = "IdAsociacion"
        CbPorCuenta.DisplayMember = "Descripcion"
        CbPorCuenta.SelectedIndex = -1
        '---------------------------CONSULTA PLANTA ORIGEN
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedIndex = -1
    End Sub
    Private Sub Limpiar()
        CbPlanta.SelectedIndex = -1
        TbIdOrden.Text = ""
        TbIdLiquidacion.Text = ""
        CbTipo.Text = ""
        DtFechaLiquidacion.Value = Now
        CbNombreCliente.SelectedIndex = -1
        CbPorCuenta.SelectedIndex = -1
        TbTotalHueso.Text = ""
        TbNumBorregos.Text = ""
        TbNumPacas.Text = ""
        TbTotalPluma.Text = ""
        TbBorregosPluma.Text = ""
        TbTotalMerma.Text = ""
        TbPorcentajeMerma.Text = ""
        TbPorcentajePluma.Text = ""
        TbPorcentajeSemilla.Text = ""
        TbTotalSemilla.Text = ""
        TbPorcentajeTotal.Text = ""
        TbComentarios.Text = ""
        DgvModulos.DataSource = ""
        TbTotalBoletas.Text = ""
        ChClaseMicros.Checked = False
        TbIdOrden.Enabled = True
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click, ToolStripMenuItem1.Click
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        Dim Tabla As New DataTable
        ConsultaOrdenTrabajo.ShowDialog()
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = ConsultaOrdenTrabajo.Id
        EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaOrden
        NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
        Tabla = EntidadLiquidacionesPorRomaneaje.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        TbIdOrden.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
        CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdPlantaOrigen")
        CbNombreCliente.SelectedValue = Tabla.Rows(0).Item("IdCliente")
        CbPorCuenta.SelectedValue = Tabla.Rows(0).Item("IdPorCuenta")
        CbTipo.Text = Tabla.Rows(0).Item("Tipo")
        TbTotalHueso.Text = Tabla.Rows(0).Item("TotalHueso")
        TbNumPacas.Text = Tabla.Rows(0).Item("Pacas")
        TbNumBorregos.Text = 0
        TbBorregosPluma.Text = Tabla.Rows(0).Item("PlumaBorregos")
        TbTotalPluma.Text = Tabla.Rows(0).Item("Pluma")
        TbTotalSemilla.Text = Tabla.Rows(0).Item("Semilla")
        TbTotalMerma.Text = Tabla.Rows(0).Item("Merma")
        TbPorcentajePluma.Text = Tabla.Rows(0).Item("PorcentajePluma")
        TbPorcentajeSemilla.Text = Tabla.Rows(0).Item("PorcentajeSemilla")
        TbPorcentajeMerma.Text = Tabla.Rows(0).Item("PorcentajeMerma")
        TbPorcentajeTotal.Text = Tabla.Rows(0).Item("PorcentajePluma") + Tabla.Rows(0).Item("PorcentajeSemilla") + Tabla.Rows(0).Item("PorcentajeMerma")
        ConsultarModulos()
    End Sub
    Private Sub ConsultarModulos()
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        Dim Tabla As New DataTable
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = TbIdOrden.Text
        EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaDetallada
        NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
        DgvModulos.DataSource = EntidadLiquidacionesPorRomaneaje.TablaConsulta
        PropiedadesDgvModulos()
    End Sub
    Private Sub PropiedadesDgvModulos()
        DgvModulos.Columns("IdOrdenTrabajo").Visible = False
        DgvModulos.Columns("IdPlanta").Visible = False
    End Sub
    Private Sub LiquidacionesPorRomaneaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaComparacion.Columns.Clear()
        TablaComparacion.Columns.Add(New DataColumn("IdBoleta", System.Type.GetType("System.Int32")))
        LlenarCombos()
        Limpiar()
        TbIdOrden.Focus()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If TbIdOrden.Text = "" Or DgvModulos.RowCount = 0 Then
            MsgBox("Por favor, abrir una orden de trabajo", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        Else
            For Each row As DataGridViewRow In DgvModulos.Rows
                Dim index = Convert.ToUInt64(row.Index)
                If DgvModulos.Rows(index).Cells("FlagRevisada").Value = False Then
                    MsgBox("Revisar las boletas y los pesos, registros incompletos", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If
            Next
            Guardar()
            GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, IdUsuario, Usuario)
            'VerificarBoletasTerminadas()
            'If Bandera = False Then
            '    MsgBox("Revisar las pacas y los pesos, registros incompletos, o no se encuentran registros para esta orden", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            '    Exit Sub
            'Else

            'End If
        End If
    End Sub

    Private Sub TbIdOrden_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbIdOrden.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbIdOrden.Text <> "" Then
                    Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
                    Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
                    Dim Tabla As New DataTable
                    EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaOrden
                    EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = CInt(TbIdOrden.Text)
                    NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
                    Tabla = EntidadLiquidacionesPorRomaneaje.TablaConsulta
                    If Tabla.Rows.Count = 0 Then
                        MsgBox("La orden de trabajo no existe...")
                        Limpiar()
                        Exit Sub
                    Else
                        TbIdOrden.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
                        CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdPlantaOrigen")
                        TbIdLiquidacion.Text = Tabla.Rows(0).Item("IdLiquidacion")
                        CbNombreCliente.SelectedValue = Tabla.Rows(0).Item("IdCliente")
                        CbPorCuenta.SelectedValue = Tabla.Rows(0).Item("IdPorCuenta")
                        CbTipo.Text = Tabla.Rows(0).Item("Tipo")
                        DtFechaLiquidacion.Value = Tabla.Rows(0).Item("Fecha")
                        TbComentarios.Text = Tabla.Rows(0).Item("Comentarios")
                        ConsultarModulos()
                        CalculosResumen()
                        TbTotalBoletas.Text = CInt(DgvModulos.RowCount)
                        TbIdOrden.Enabled = False
                    End If
                Else
                    MsgBox("Ingrese el ID de la orden de trabajo...")
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
        TbIdOrden.Focus()
    End Sub

    Private Sub CalculosResumen()
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        Dim Tabla As New DataTable
        EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaExterna
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = CInt(TbIdOrden.Text)
        NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
        Tabla = EntidadLiquidacionesPorRomaneaje.TablaConsulta
        Try
            TbTotalHueso.Text = Format(Tabla.Rows(0).Item("TotalHueso"), "##,##00.00")
            TbTotalPluma.Text = Format(Tabla.Rows(0).Item("TotalPluma"), "##,##00.00")
            TbPorcentajePluma.Text = Tabla.Rows(0).Item("PorcentajePluma")
            TbPorcentajeSemilla.Text = Tabla.Rows(0).Item("PorcentajeSemilla")
            TbTotalSemilla.Text = Format(Tabla.Rows(0).Item("TotalSemilla"), "##,##00.00")
            TbPorcentajeMerma.Text = Tabla.Rows(0).Item("PorcentajeMerma")
            TbTotalMerma.Text = Format(Tabla.Rows(0).Item("TotalMerma"), "##,##00.00")
            TbPorcentajeTotal.Text = CInt((CInt(TbPorcentajeMerma.Text) + CInt(TbPorcentajePluma.Text) + CInt(TbPorcentajeSemilla.Text)))
            TbNumPacas.Text = Tabla.Rows(0).Item("TotalPacas")
            TbNumBorregos.Text = Tabla.Rows(0).Item("TotalBorregos")
            TbBorregosPluma.Text = Format(Tabla.Rows(0).Item("TotalPlumaBorregos"), "##,##00.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        If TbIdOrden.Text <> "" And TbIdLiquidacion.Text <> "" Then
            Dim ReporteLiquidacionRomaneaje As New RepLiquidacionRomaneaje(TbIdOrden.Text, ChClaseMicros.CheckState)
            ReporteLiquidacionRomaneaje.ShowDialog()
        Else
            MessageBox.Show("No hay contrato seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Guardar()
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje.IdLiquidacion = IIf(TbIdLiquidacion.Text = "", 0, TbIdLiquidacion.Text)
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = TbIdOrden.Text
        EntidadLiquidacionesPorRomaneaje.IdCliente = CInt(CbNombreCliente.SelectedValue)
        EntidadLiquidacionesPorRomaneaje.Fecha = DtFechaLiquidacion.Value
        EntidadLiquidacionesPorRomaneaje.Comentarios = TbComentarios.Text
        '----------------------------------------------------------------
        EntidadLiquidacionesPorRomaneaje.TotalHueso = CDbl(TbTotalHueso.Text)
        EntidadLiquidacionesPorRomaneaje.TotalPluma = CDbl(TbTotalPluma.Text)
        EntidadLiquidacionesPorRomaneaje.TotalSemilla = CDbl(TbTotalSemilla.Text)
        EntidadLiquidacionesPorRomaneaje.TotalMerma = CDbl(TbTotalMerma.Text)
        EntidadLiquidacionesPorRomaneaje.TotalPacas = CInt(TbNumPacas.Text)
        EntidadLiquidacionesPorRomaneaje.TotalBoletas = CInt(TbTotalBoletas.Text)
        EntidadLiquidacionesPorRomaneaje.TotalBorregos = CInt(TbNumBorregos.Text)
        EntidadLiquidacionesPorRomaneaje.TotalPlumaBorregos = CDbl(TbBorregosPluma.Text)
        EntidadLiquidacionesPorRomaneaje.PorcentajePluma = CDbl(TbPorcentajePluma.Text)
        EntidadLiquidacionesPorRomaneaje.PorcentajeSemilla = CDbl(TbPorcentajeSemilla.Text)
        EntidadLiquidacionesPorRomaneaje.PorcentajeMerma = CDbl(TbPorcentajeMerma.Text)
        '---------------------------------------------
        EntidadLiquidacionesPorRomaneaje.IdEstatus = 1
        EntidadLiquidacionesPorRomaneaje.IdUsuarioCreacion = 1
        EntidadLiquidacionesPorRomaneaje.FechaCreacion = Now
        EntidadLiquidacionesPorRomaneaje.IdUsuarioActualizacion = 1
        EntidadLiquidacionesPorRomaneaje.FechaActualizacion = Now
        NegocioLiquidacionesPorRomaneaje.Upsert(EntidadLiquidacionesPorRomaneaje)
        TbIdLiquidacion.Text = EntidadLiquidacionesPorRomaneaje.IdLiquidacion
        MsgBox("Realizado Correctamente")
    End Sub

    Private Sub VerificarBoletasTerminadas()
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        'For Each row As DataGridViewRow In DgvModulos.Rows
        '    Dim RenglonAInsertar As DataRow
        '    RenglonAInsertar = TablaComparacion.NewRow()
        '    Dim index = Convert.ToUInt64(row.Index)
        '    RenglonAInsertar("IdBoleta") = DgvModulos.Rows(index).Cells("IdBoleta").Value
        '    TablaComparacion.Rows.Add(RenglonAInsertar)
        'Next
        EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaPorId
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = CInt(TbIdOrden.Text)
        NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
        Bandera = EntidadLiquidacionesPorRomaneaje.Bandera
    End Sub
End Class