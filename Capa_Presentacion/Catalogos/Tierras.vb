Imports Capa_Operacion.Configuracion
Public Class Tierras
    Dim TablaCombos As New DataTable

    Private Sub Tierras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaCombos()
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbIdTierra.Text = ""
        TbLote.Text = ""
        CbColonia.SelectedIndex = 0
        CbCliente.SelectedIndex = 0
        TbRfc.Text = ""
        TbCurp.Text = ""
        TbRegistroAlterno.Text = ""
        NuSuperficieTotal.Value = 0
        NuSuperficieCultivable.Value = 0
        CbEstatus.SelectedIndex = 0
        TbLatitudGrados.Text = ""
        TbLatitudHoras.Text = ""
        TbLatitudMinutos.Text = ""
        TbLongitudGrados.Text = ""
        TbLongitudHoras.Text = ""
        TbLongitudMinutos.Text = ""
        TbNumeroRpp.Text = ""
        TbFolioRpp.Text = ""
        TbLibroRpp.Text = ""
        DtFechaRegistro.Value = Now
        TbTituloAgua.Text = ""
        CbRegimenHidrico.SelectedIndex = 0
        DtFechaTitulo.Value = Now
    End Sub
    Private Sub LlenaCombos()
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
        '--------------------------------------------------
        Dim EntidadTierras As New Capa_Entidad.Tierras
        Dim NegocioTierras As New Capa_Negocio.Tierras
        EntidadTierras.LlenaCombo = LlenaCombo.LlenaComboCliente
        NegocioTierras.ConsultarCombo(EntidadTierras)
        TablaCombos = EntidadTierras.TablaConsulta
        CbCliente.DataSource = TablaCombos
        CbCliente.DisplayMember = "Nombre"
        CbCliente.ValueMember = "IdCliente"
        '-----------------------------------------------------
        EntidadTierras.LlenaCombo = LlenaCombo.LlenaComboColonia
        NegocioTierras.ConsultarCombo(EntidadTierras)
        TablaCombos = EntidadTierras.TablaConsulta
        CbColonia.DataSource = TablaCombos
        CbColonia.DisplayMember = "Descripcion"
        CbColonia.ValueMember = "IdColonia"
        '-------------------------------------------------------
        EntidadTierras.LlenaCombo = LlenaCombo.LlenaComboRegimen
        NegocioTierras.ConsultarCombo(EntidadTierras)
        TablaCombos = EntidadTierras.TablaConsulta
        CbRegimenHidrico.DataSource = TablaCombos
        CbRegimenHidrico.DisplayMember = "Descripcion"
        CbRegimenHidrico.ValueMember = "IdRegimen"
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadTierras As New Capa_Entidad.Tierras
        Dim NegocioTierras As New Capa_Negocio.Tierras
        EntidadTierras.IdTierra = IIf(TbIdTierra.Text = "", 0, TbIdTierra.Text)
        EntidadTierras.Lote = TbLote.Text
        EntidadTierras.Colonia = CbColonia.SelectedValue
        EntidadTierras.Propietario = CbCliente.SelectedValue
        'EntidadTierras.TipoPersona = 
        EntidadTierras.RegistroAlterno = TbRegistroAlterno.Text
        EntidadTierras.SuperficieTotal = NuSuperficieTotal.Value
        EntidadTierras.SuperficieCultivable = NuSuperficieCultivable.Value
        EntidadTierras.LatitudGrados = TbLatitudGrados.Text
        EntidadTierras.LatitudHoras = TbLatitudHoras.Text
        EntidadTierras.LatitudMinutos = TbLatitudMinutos.Text
        EntidadTierras.LongitudGrados = TbLongitudGrados.Text
        EntidadTierras.LongitudHoras = TbLongitudHoras.Text
        EntidadTierras.LongitudMinutos = TbLongitudMinutos.Text
        EntidadTierras.NumeroRpp = TbNumeroRpp.Text
        EntidadTierras.FolioRpp = TbFolioRpp.Text
        EntidadTierras.LibroRpp = TbLibroRpp.Text
        EntidadTierras.Fecha = DtFechaRegistro.Value
        EntidadTierras.TituloAgua = TbTituloAgua.Text
        EntidadTierras.RegimenHidrico = CbRegimenHidrico.SelectedValue
        EntidadTierras.FechaTituloAgua = DtFechaTitulo.Value
        EntidadTierras.IdEstatus = CbEstatus.SelectedValue
        EntidadTierras.IdUsuarioCreacion = 1
        EntidadTierras.FechaCreacion = Now
        NegocioTierras.Guardar(EntidadTierras)
        TbIdTierra.Text = EntidadTierras.IdTierra
        MsgBox("Realizado Correctamente")
    End Sub
    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        Dim EntidadTierras As New Capa_Entidad.Tierras
        Dim NegocioTierras As New Capa_Negocio.Tierras
        Dim Tabla As New DataTable
        ConsultaTierras.ShowDialog()
        EntidadTierras.IdTierra = ConsultaTierras.IdTierra
        EntidadTierras.Consulta = Consulta.ConsultaDetallada
        NegocioTierras.Consultar(EntidadTierras)
        Tabla = EntidadTierras.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        TbIdTierra.Text = Tabla.Rows(0).Item("IdTierra")
        TbLote.Text = Tabla.Rows(0).Item("Lote")
        CbColonia.SelectedValue = Tabla.Rows(0).Item("Colonia")
        CbCliente.SelectedValue = Tabla.Rows(0).Item("Propietario")
        TbCurp.Text = Tabla.Rows(0).Item("CurpFisica")
        TbRfc.Text = Tabla.Rows(0).Item("RfcFisica")
        TbRegistroAlterno.Text = Tabla.Rows(0).Item("RegistroAlterno")
        NuSuperficieTotal.Value = Tabla.Rows(0).Item("SuperficieTotal")
        NuSuperficieCultivable.Value = Tabla.Rows(0).Item("SuperficieCultivable")
        TbLatitudGrados.Text = Tabla.Rows(0).Item("LatitudGrados")
        TbLatitudHoras.Text = Tabla.Rows(0).Item("LatitudHoras")
        TbLatitudMinutos.Text = Tabla.Rows(0).Item("LatitudMinutos")
        TbLongitudGrados.Text = Tabla.Rows(0).Item("LongitudGrados")
        TbLongitudHoras.Text = Tabla.Rows(0).Item("LongitudHoras")
        TbLongitudMinutos.Text = Tabla.Rows(0).Item("LongitudMinutos")
        TbNumeroRpp.Text = Tabla.Rows(0).Item("NumeroRpp")
        TbFolioRpp.Text = Tabla.Rows(0).Item("FolioRpp")
        TbLibroRpp.Text = Tabla.Rows(0).Item("LibroRpp")
        DtFechaRegistro.Value = Tabla.Rows(0).Item("Fecha")
        TbTituloAgua.Text = Tabla.Rows(0).Item("TituloAgua")
        CbRegimenHidrico.SelectedValue = Tabla.Rows(0).Item("RegimenHidrico")
        DtFechaTitulo.Value = Tabla.Rows(0).Item("FechaTituloAgua")
        CbEstatus.SelectedValue = Tabla.Rows(0).Item("IdEstatus")
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
End Class