Imports Capa_Operacion.Configuracion
Public Class ContratosAlgodonCompradores
    Dim IdComprador As Integer
    Private Sub ContratosAlgodonCompradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaContratos()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        EntidadContratosAlgodonCompradores.IdContratoAlgodon = IIf(TbIdContratoAlgodon.Text = "", 0, TbIdContratoAlgodon.Text)
        EntidadContratosAlgodonCompradores.IdComprador = IdComprador
        EntidadContratosAlgodonCompradores.Pacas = TbPacas.Text
        EntidadContratosAlgodonCompradores.PrecioQuintal = TbPrecioQuintal.Text
        EntidadContratosAlgodonCompradores.Puntos = TbPuntos.Text
        EntidadContratosAlgodonCompradores.FechaLiquidacion = DtpFechaLiquidacion.Value
        EntidadContratosAlgodonCompradores.Presidente = TbPresidente.Text
        EntidadContratosAlgodonCompradores.IdModalidadCompra = CbModalidad.SelectedValue
        EntidadContratosAlgodonCompradores.Temporada = TbTemporada.Text
        EntidadContratosAlgodonCompradores.PrecioSM = TbSM.Text
        EntidadContratosAlgodonCompradores.PrecioMP = TbMP.Text
        EntidadContratosAlgodonCompradores.PrecioM = TbM.Text
        EntidadContratosAlgodonCompradores.PrecioSLMP = TbSLMP.Text
        EntidadContratosAlgodonCompradores.PrecioSLM = TbSLM.Text
        EntidadContratosAlgodonCompradores.PrecioLMP = TbLMP.Text
        EntidadContratosAlgodonCompradores.PrecioLM = TbLM.Text
        EntidadContratosAlgodonCompradores.PrecioSGO = TbSGO.Text
        EntidadContratosAlgodonCompradores.PrecioGO = TbGO.Text
        EntidadContratosAlgodonCompradores.PrecioO = TbO.Text
        EntidadContratosAlgodonCompradores.IdEstatus = CbEstatus.SelectedValue
        EntidadContratosAlgodonCompradores.IdUsuarioCreacion = 1
        EntidadContratosAlgodonCompradores.FechaCreacion = Now
        EntidadContratosAlgodonCompradores.IdUsuarioActualizacion = 1
        EntidadContratosAlgodonCompradores.FechaActualizacion = Now
        EntidadContratosAlgodonCompradores.TablaConsulta = _Tabla
        NegocioContratosAlgodonCompradores.Guardar(EntidadContratosAlgodonCompradores)
        TbIdContratoAlgodon.Text = EntidadContratosAlgodonCompradores.IdContratoAlgodon
        MsgBox("Realizado Correctamente")
        ConsultaContratos()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub BtGenerar_Click(sender As Object, e As EventArgs) Handles BtGenerar.Click
        If TbPrecioQuintal.Text <> "" And TbPuntos.Text <> "" Then
            Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
            Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
            Dim Tabla As New DataTable
            EntidadContratosAlgodonCompradores.IdExterno = CbModalidad.SelectedValue
            EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaDiferenciales
            NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
            Tabla = EntidadContratosAlgodonCompradores.TablaConsulta
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
    Private Sub BtnBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProductor.Click
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        ConsultaCompradores.ShowDialog()
        IdComprador = _Id
        TbComprador.Text = _Nombre
    End Sub
    Private Sub Limpiar()
        TbIdContratoAlgodon.Text = ""
        TbComprador.Text = ""
        TbPacas.Text = ""
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
    Private Sub ConsultaContratos()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim Tabla As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaBasica
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        DgvContratoAlgodon.DataSource = EntidadContratosAlgodonCompradores.TablaConsulta
    End Sub

    Private Sub DgvContratoAlgodon_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContratoAlgodon.CellContentDoubleClick
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim TablaDetalle As New DataTable
        Dim index As Integer
        index = DgvContratoAlgodon.CurrentRow.Index
        EntidadContratosAlgodonCompradores.IdContratoAlgodon = DgvContratoAlgodon.Rows(index).Cells("IdContratoAlgodon").Value.ToString()
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaDetallada
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        TablaDetalle = EntidadContratosAlgodonCompradores.TablaConsulta
        TbIdContratoAlgodon.Text = TablaDetalle.Rows(0).Item("IdContratoAlgodon")
        IdComprador = TablaDetalle.Rows(0).Item("IdComprador")
        TbComprador.Text = TablaDetalle.Rows(0).Item("Nombre")
        TbPacas.Text = TablaDetalle.Rows(0).Item("Pacas")
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
        'BtConsultaLotes.Enabled = True
    End Sub
    Private Sub InhabilitarBotones()
        'BtConsultaLotes.Enabled = False
    End Sub
End Class