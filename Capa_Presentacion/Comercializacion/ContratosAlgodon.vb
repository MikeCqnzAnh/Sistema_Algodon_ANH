Imports Capa_Operacion.Configuracion
Public Class ContratosAlgodon
    Public IdCliente As Integer

    Private Sub ContratosAlgodon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        Limpiar()
        ConsultaContratos()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
        HabilitarBotones()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        EntidadContratosAlgodon.IdContratoAlgodon = IIf(TbIdContratoAlgodon.Text = "", 0, TbIdContratoAlgodon.Text)
        EntidadContratosAlgodon.IdProductor = IdCliente
        EntidadContratosAlgodon.Pacas = TbPacas.Text
        EntidadContratosAlgodon.SuperficieComprometida = TbSuperficie.Text
        EntidadContratosAlgodon.PrecioQuintal = TbPrecioQuintal.Text
        EntidadContratosAlgodon.Puntos = TbPuntos.Text
        EntidadContratosAlgodon.FechaLiquidacion = DtpFechaLiquidacion.Value
        EntidadContratosAlgodon.Presidente = TbPresidente.Text
        EntidadContratosAlgodon.IdModalidadCompra = CbModalidad.SelectedValue
        EntidadContratosAlgodon.Temporada = TbTemporada.Text
        EntidadContratosAlgodon.PrecioSM = TbSM.Text
        EntidadContratosAlgodon.PrecioMP = TbMP.Text
        EntidadContratosAlgodon.PrecioM = TbM.Text
        EntidadContratosAlgodon.PrecioSLMP = TbSLMP.Text
        EntidadContratosAlgodon.PrecioSLM = TbSLM.Text
        EntidadContratosAlgodon.PrecioLMP = TbLMP.Text
        EntidadContratosAlgodon.PrecioLM = TbLM.Text
        EntidadContratosAlgodon.PrecioSGO = TbSGO.Text
        EntidadContratosAlgodon.PrecioGO = TbGO.Text
        EntidadContratosAlgodon.PrecioO = TbO.Text
        EntidadContratosAlgodon.IdEstatus = CbEstatus.SelectedValue
        EntidadContratosAlgodon.IdUsuarioCreacion = 1
        EntidadContratosAlgodon.FechaCreacion = Now
        EntidadContratosAlgodon.IdUsuarioActualizacion = 1
        EntidadContratosAlgodon.FechaActualizacion = Now
        EntidadContratosAlgodon.TablaConsulta = _Tabla
        NegocioContratosAlgodon.Guardar(EntidadContratosAlgodon)
        TbIdContratoAlgodon.Text = EntidadContratosAlgodon.IdContratoAlgodon
        MsgBox("Realizado Correctamente")
        ConsultaContratos()
        HabilitarBotones()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CargarCombos()
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "2"
        dr("Descripcion") = "Inactivo"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Id"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedValue = 1
        '-------------------------COMBO MODOS DE COMPRA
        Dim Tabla As New DataTable
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaExterna
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla = EntidadContratosAlgodon.TablaConsulta
        CbModalidad.DataSource = Tabla
        CbModalidad.ValueMember = "IdModoEncabezado"
        CbModalidad.DisplayMember = "Descripcion"
        CbModalidad.SelectedValue = 1
    End Sub

    Private Sub ConsultaContratos()
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim Tabla As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaBasica
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        DgvContratoAlgodon.DataSource = EntidadContratosAlgodon.TablaConsulta
    End Sub

    Private Sub Limpiar()
        TbIdContratoAlgodon.Text = ""
        TbProductor.Text = ""
        TbAsociacion.Text = ""
        TbPacas.Text = ""
        TbSuperficie.Text = ""
        TbLotes.Text = ""
        TbPrecioQuintal.Text = ""
        TbPuntos.Text = ""
        DtpFechaLiquidacion.Value = Now
        TbPresidente.Text = ""
        CbModalidad.SelectedValue = 1
        TbTemporada.Text = ""
        CbEstatus.SelectedValue = 1
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
    End Sub

    Private Sub BtnBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProductor.Click
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        ConsultaProductores.ShowDialog()
        IdCliente = _Id
        TbProductor.Text = _Nombre
        TbAsociacion.Text = _Dato
    End Sub

    Private Sub BtConsultaLotes_Click(sender As Object, e As EventArgs) Handles BtConsultaLotes.Click
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim Tabla As New DataTable
        ConsultaTierrasChecks.ShowDialog()
        Tabla.Clear()
        TbLotes.Text = ""
        Tabla = _Tabla
        If Tabla Is Nothing Then
            Exit Sub
        End If
        For Each row As DataRow In Tabla.Rows
            TbLotes.Text = TbLotes.Text + " - " + row.Item("Lote")
        Next
    End Sub

    Private Sub BtGenerar_Click(sender As Object, e As EventArgs) Handles BtGenerar.Click
        If TbPrecioQuintal.Text <> "" And TbPuntos.Text <> "" Then
            Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
            Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
            Dim Tabla As New DataTable
            EntidadContratosAlgodon.IdExterno = CbModalidad.SelectedValue
            EntidadContratosAlgodon.Consulta = Consulta.ConsultaDiferenciales
            NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
            Tabla = EntidadContratosAlgodon.TablaConsulta
            TbSM.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(0).Item("Diferencial"))
            TbMP.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(1).Item("Diferencial") - Tabla.Rows(0).Item("Diferencial"))
            TbM.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(2).Item("Diferencial") - Tabla.Rows(1).Item("Diferencial") - Tabla.Rows(0).Item("Diferencial"))
            TbSLMP.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(3).Item("Diferencial") - Tabla.Rows(2).Item("Diferencial") - Tabla.Rows(1).Item("Diferencial") - Tabla.Rows(0).Item("Diferencial"))
            TbSLM.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(4).Item("Diferencial") - Tabla.Rows(3).Item("Diferencial") - Tabla.Rows(2).Item("Diferencial") - Tabla.Rows(1).Item("Diferencial") - Tabla.Rows(0).Item("Diferencial"))
            TbLMP.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(5).Item("Diferencial") - Tabla.Rows(4).Item("Diferencial") - Tabla.Rows(3).Item("Diferencial") - Tabla.Rows(2).Item("Diferencial") - Tabla.Rows(1).Item("Diferencial") - Tabla.Rows(0).Item("Diferencial"))
            TbLM.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(6).Item("Diferencial") - Tabla.Rows(5).Item("Diferencial") - Tabla.Rows(4).Item("Diferencial") - Tabla.Rows(3).Item("Diferencial") - Tabla.Rows(2).Item("Diferencial") - Tabla.Rows(1).Item("Diferencial") - Tabla.Rows(0).Item("Diferencial"))
            TbSGO.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(7).Item("Diferencial") - Tabla.Rows(6).Item("Diferencial") - Tabla.Rows(5).Item("Diferencial") - Tabla.Rows(4).Item("Diferencial") - Tabla.Rows(3).Item("Diferencial") - Tabla.Rows(2).Item("Diferencial") - Tabla.Rows(1).Item("Diferencial") - Tabla.Rows(0).Item("Diferencial"))
            TbGO.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(8).Item("Diferencial") - Tabla.Rows(7).Item("Diferencial") - Tabla.Rows(6).Item("Diferencial") - Tabla.Rows(5).Item("Diferencial") - Tabla.Rows(4).Item("Diferencial") - Tabla.Rows(3).Item("Diferencial") - Tabla.Rows(2).Item("Diferencial") - Tabla.Rows(1).Item("Diferencial") - Tabla.Rows(0).Item("Diferencial"))
            TbO.Text = CDbl(TbPrecioQuintal.Text - (TbPuntos.Text) - Tabla.Rows(9).Item("Diferencial") - Tabla.Rows(8).Item("Diferencial") - Tabla.Rows(7).Item("Diferencial") - Tabla.Rows(6).Item("Diferencial") - Tabla.Rows(5).Item("Diferencial") - Tabla.Rows(4).Item("Diferencial") - Tabla.Rows(3).Item("Diferencial") - Tabla.Rows(2).Item("Diferencial") - Tabla.Rows(1).Item("Diferencial") - Tabla.Rows(0).Item("Diferencial"))
        Else
            MsgBox("Ingrese precio de quintal o los puntos")
        End If
    End Sub
    Private Sub DgvContratoAlgodon_DoubleClick(sender As Object, e As EventArgs) Handles DgvContratoAlgodon.DoubleClick
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim TablaDetalle As New DataTable
        Dim index As Integer
        index = DgvContratoAlgodon.CurrentRow.Index
        EntidadContratosAlgodon.IdContratoAlgodon = DgvContratoAlgodon.Rows(index).Cells("IdContratoAlgodon").Value.ToString()
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaDetallada
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        TablaDetalle = EntidadContratosAlgodon.TablaConsulta
        TbIdContratoAlgodon.Text = TablaDetalle.Rows(0).Item("IdContratoAlgodon")
        IdCliente = TablaDetalle.Rows(0).Item("IdCliente")
        TbProductor.Text = TablaDetalle.Rows(0).Item("Nombre")
        TbAsociacion.Text = TablaDetalle.Rows(0).Item("Descripcion")
        TbPacas.Text = TablaDetalle.Rows(0).Item("Pacas")
        TbSuperficie.Text = TablaDetalle.Rows(0).Item("SuperficieComprometida")
        TbLotes.Text = TablaDetalle.Rows(0).Item("Lotes")
        CbEstatus.SelectedValue = TablaDetalle.Rows(0).Item("IdEstatus")
        TbPrecioQuintal.Text = TablaDetalle.Rows(0).Item("PrecioQuintal")
        TbPuntos.Text = TablaDetalle.Rows(0).Item("Puntos")
        DtpFechaLiquidacion.Value = TablaDetalle.Rows(0).Item("FechaLiquidacion")
        TbPresidente.Text = TablaDetalle.Rows(0).Item("Presidente")
        CbModalidad.SelectedValue = TablaDetalle.Rows(0).Item("IdModalidadCompra")
        TbTemporada.Text = TablaDetalle.Rows(0).Item("Temporada")
        TbSM.Text = TablaDetalle.Rows(0).Item("PrecioSM")
        TbMP.Text = TablaDetalle.Rows(0).Item("PrecioMP")
        TbM.Text = TablaDetalle.Rows(0).Item("PrecioM")
        TbSLMP.Text = TablaDetalle.Rows(0).Item("PrecioSLMP")
        TbSLM.Text = TablaDetalle.Rows(0).Item("PrecioSLM")
        TbLMP.Text = TablaDetalle.Rows(0).Item("PrecioLMP")
        TbLM.Text = TablaDetalle.Rows(0).Item("PrecioLM")
        TbSGO.Text = TablaDetalle.Rows(0).Item("PrecioSGO")
        TbGO.Text = TablaDetalle.Rows(0).Item("PrecioGO")
        TbO.Text = TablaDetalle.Rows(0).Item("PrecioO")
        InhabilitarBotones()
    End Sub
    Private Sub HabilitarBotones()
        BtConsultaLotes.Enabled = True
    End Sub
    Private Sub InhabilitarBotones()
        BtConsultaLotes.Enabled = False
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Dim ReporteContrato As New RepContratoProductor(TbIdContratoAlgodon.Text)
        ReporteContrato.ShowDialog()
    End Sub
End Class