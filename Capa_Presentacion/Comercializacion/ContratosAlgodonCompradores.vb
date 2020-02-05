Imports Capa_Operacion.Configuracion
Public Class ContratosAlgodonCompradores
    Implements IForm1
    Dim IdComprador As Integer
    Dim TablaUnidadPeso As New DataTable
    Private Sub ContratosAlgodonCompradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        Limpiar()
        ConsultaContratos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If TbComprador.Text <> "" And TbPacas.Text <> "" And CbUnidadPeso.Text <> "" And TbPrecioQuintal.Text <> "" And TbPuntos.Text <> "" And CbEstatus.Text <> "" And CbModalidad.Text <> "" And TbSM.Text <> "" Then
            Guardar()
        End If
    End Sub
    Private Sub Guardar()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Try
            EntidadContratosAlgodonCompradores.IdContratoAlgodon = IIf(TbIdContratoAlgodon.Text = "", 0, TbIdContratoAlgodon.Text)
            EntidadContratosAlgodonCompradores.IdComprador = IdComprador
            EntidadContratosAlgodonCompradores.Pacas = Val(TbPacas.Text)
            EntidadContratosAlgodonCompradores.PacasDisponibles = Val(TbPacasDisponibles.Text)
            EntidadContratosAlgodonCompradores.PacasVendidas = Val(TbPacasVendidas.Text)
            EntidadContratosAlgodonCompradores.PrecioQuintal = Val(TbPrecioQuintal.Text)
            EntidadContratosAlgodonCompradores.IdUnidadPeso = CbUnidadPeso.SelectedValue
            EntidadContratosAlgodonCompradores.ValorConversion = Val(TbValorConversion.Text)
            EntidadContratosAlgodonCompradores.Puntos = Val(TbPuntos.Text)
            EntidadContratosAlgodonCompradores.FechaLiquidacion = DtpFechaLiquidacion.Value
            EntidadContratosAlgodonCompradores.Presidente = TbPresidente.Text
            EntidadContratosAlgodonCompradores.IdModalidadVenta = CbModalidad.SelectedValue
            EntidadContratosAlgodonCompradores.Temporada = Val(TbTemporada.Text)
            EntidadContratosAlgodonCompradores.PrecioSM = Val(TbSM.Text)
            EntidadContratosAlgodonCompradores.PrecioMP = Val(TbMP.Text)
            EntidadContratosAlgodonCompradores.PrecioM = Val(TbM.Text)
            EntidadContratosAlgodonCompradores.PrecioSLMP = Val(TbSLMP.Text)
            EntidadContratosAlgodonCompradores.PrecioSLM = Val(TbSLM.Text)
            EntidadContratosAlgodonCompradores.PrecioLMP = Val(TbLMP.Text)
            EntidadContratosAlgodonCompradores.PrecioLM = Val(TbLM.Text)
            EntidadContratosAlgodonCompradores.PrecioSGO = Val(TbSGO.Text)
            EntidadContratosAlgodonCompradores.PrecioGO = Val(TbGO.Text)
            EntidadContratosAlgodonCompradores.PrecioO = Val(TbO.Text)
            EntidadContratosAlgodonCompradores.IdEstatus = CbEstatus.SelectedValue
            EntidadContratosAlgodonCompradores.IdUsuarioCreacion = 1
            EntidadContratosAlgodonCompradores.FechaCreacion = Now
            EntidadContratosAlgodonCompradores.IdUsuarioActualizacion = 1
            EntidadContratosAlgodonCompradores.FechaActualizacion = Now
            EntidadContratosAlgodonCompradores.TablaConsulta = _Tabla
            NegocioContratosAlgodonCompradores.Guardar(EntidadContratosAlgodonCompradores)
            TbIdContratoAlgodon.Text = EntidadContratosAlgodonCompradores.IdContratoAlgodon
        Catch ex As Exception
            MsgBox(ex)
        Finally
            MsgBox("Realizado Correctamente")
            ConsultaContratos()
            GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdContratoAlgodon.Text, "SE CREO/ACTUALIZO EL CONTRATO " & TbIdContratoAlgodon.Text & " " & TbComprador.Text & " CON LA CANTIDAD DE " & TbPacas.Text & " PACAS DE CONTRATO, " & TbPacasDisponibles.Text & " DISPONIBLES, " & TbPacasVendidas.Text & " VENDIDAS, MODALIDAD DE VENTA" & CbModalidad.Text & ", PRECIO DE CONTRATO " & TbPrecioQuintal.Text & ".")
        End Try
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
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaExterna
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModalidad.DataSource = Tabla
        CbModalidad.ValueMember = "IdModoEncabezado"
        CbModalidad.DisplayMember = "Descripcion"
        CbModalidad.SelectedValue = 1
        '-------------------------COMBO UNIDAD PESO
        Dim Tabla1 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaUnidadPeso
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla1 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbUnidadPeso.DataSource = Tabla1
        CbUnidadPeso.ValueMember = "IdUnidadPeso"
        CbUnidadPeso.DisplayMember = "Descripcion"
        CbUnidadPeso.SelectedValue = -1
        TablaUnidadPeso = Tabla1
    End Sub
    Private Sub BtnBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProductor.Click
        'Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        'Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        'ConsultaCompradores.ShowDialog()
        'IdComprador = _Id
        'TbComprador.Text = _Nombre

        Dim _ConsultaCompradores As New ConsultaCompradores
        _ConsultaCompradores.MdiParent = Me.MdiParent
        _ConsultaCompradores.Opener = CType(Me, IForm1)
        _ConsultaCompradores.ShowDialog()
    End Sub
    Public Function LoadIdComprador(ByVal DatatableParam As DataTable) As Boolean Implements IForm1.LoadIdComprador
        For Each row As DataRow In DatatableParam.Rows
            IdComprador = row("IdComprador")
            TbComprador.Text = row("Nombre")
        Next
        Return True
    End Function
    Private Sub Limpiar()
        TbIdContratoAlgodon.Text = ""
        TbComprador.Text = ""
        TbPacas.Text = ""
        TbPacasDisponibles.Text = ""
        TbPacasVendidas.Text = ""
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
        CbUnidadPeso.SelectedValue = -1
        TbValorConversion.Text = ""
        ChBark.Checked = True
        ChPrep.Checked = True
        ChOther.Checked = True
        ChPlastic.Checked = True
        ChBarkLevel1.Checked = True
        ChBarkLevel2.Checked = True
        ChPrepLevel1.Checked = True
        ChPrepLevel2.Checked = True
        ChOtherLevel1.Checked = True
        ChOtherLevel2.Checked = True
        ChPlasticLevel1.Checked = True
        ChPlasticLevel2.Checked = True
        ChMicros.Checked = True
        ChResistenciaFibra.Checked = True
        ChLargoFibra.Checked = True
        ChUniformidad.Checked = True
    End Sub
    Private Sub ConsultaContratos()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim Tabla As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaBasica
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        DgvContratoAlgodon.DataSource = EntidadContratosAlgodonCompradores.TablaConsulta
    End Sub

    Private Sub HabilitarBotones()
        'BtConsultaLotes.Enabled = True
    End Sub
    Private Sub InhabilitarBotones()
        'BtConsultaLotes.Enabled = False
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
    Private Sub TbPuntos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPacas.KeyPress, TbPuntos.KeyPress, TbPrecioQuintal.KeyPress, TbTemporada.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DgvContratoAlgodon_DoubleClick(sender As Object, e As EventArgs) Handles DgvContratoAlgodon.DoubleClick
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim TablaDetalle As New DataTable
        Dim index As Integer
        index = DgvContratoAlgodon.CurrentRow.Index
        EntidadContratosAlgodonCompradores.IdContratoAlgodon = DgvContratoAlgodon.Rows(index).Cells("IdContratoAlgodon").Value
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaDetallada
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        TablaDetalle = EntidadContratosAlgodonCompradores.TablaConsulta
        TbIdContratoAlgodon.Text = TablaDetalle.Rows(0).Item("IdContratoAlgodon")
        IdComprador = TablaDetalle.Rows(0).Item("IdComprador")
        TbComprador.Text = TablaDetalle.Rows(0).Item("Nombre")
        TbPacas.Text = TablaDetalle.Rows(0).Item("Pacas")
        TbPacasDisponibles.Text = TablaDetalle.Rows(0).Item("PacasDisponibles")
        TbPacasVendidas.Text = TablaDetalle.Rows(0).Item("PacasVendidas")
        CbEstatus.SelectedValue = TablaDetalle.Rows(0).Item("IdEstatus")
        TbPrecioQuintal.Text = TablaDetalle.Rows(0).Item("PrecioQuintal")
        CbUnidadPeso.SelectedValue = TablaDetalle.Rows(0).Item("IdUnidadPeso")
        TbValorConversion.Text = TablaDetalle.Rows(0).Item("ValorConversion")
        TbPuntos.Text = TablaDetalle.Rows(0).Item("Puntos")
        DtpFechaLiquidacion.Value = TablaDetalle.Rows(0).Item("FechaLiquidacion")
        TbPresidente.Text = TablaDetalle.Rows(0).Item("Presidente")
        CbModalidad.SelectedValue = TablaDetalle.Rows(0).Item("IdModalidadVenta")
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

    Public Function LoadIdVenta(_DataTable As DataTable) As Boolean Implements IForm1.LoadIdVenta
        Throw New NotImplementedException()
    End Function
    Private Sub TbPacas_KeyDown(sender As Object, e As KeyEventArgs) Handles TbPacas.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If Val(TbPacas.Text) >= Val(TbPacasVendidas.Text) Then
                    TbPacasDisponibles.Text = Val(TbPacas.Text) - Val(TbPacasVendidas.Text)
                End If
        End Select
    End Sub
End Class