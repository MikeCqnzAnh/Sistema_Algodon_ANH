Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class RevisionProduccion
    Dim IdProduccionDetalle As Integer = 0
    Dim FolioCIAReturn As Long = 0
    Private Sub RevisionProduccion_Load(sender As Object, e As EventArgs) Handles Me.Load
        TbIdOrdenTrabajo.Select()
        CargarCombos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ConsultarOrden()
        ConsultarFaltantes()
        ConsultaDetallesOrden()
        ConsultarEstatusRevision()

        If TbIdOrdenTrabajo.Text <> "" Then
            DgvPacasLigeras.DataSource = CargaDgvPacasPesos(False, NuRegistrosLigero.Value, NuPesoLigero.Value)
            TbContarLigeras.Text = DgvPacasLigeras.RowCount
            DgvPacasPesadas.DataSource = CargaDgvPacasPesos(True, NuRegistroPesado.Value, NuPesoPesado.Value)
            TbContarPesadas.Text = DgvPacasPesadas.RowCount
        End If
        RbActualizar.Checked = False
        RbAgregar.Checked = False
        TbFolioCIA.Text = ""
        TbConsecutivoInicial.Text = ""
        TbKilos.Text = ""
    End Sub
    Private Sub AprovarRevisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AprovarRevisionToolStripMenuItem.Click
        If CkRevisado.Checked = False Then
            Dim opc As DialogResult = MsgBox("¿Marcar la revision como aprovada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aprovar revision de produccion")
            If opc = DialogResult.Yes Then
                Dim EntidadProduccion As New Capa_Entidad.Produccion
                Dim NegocioProduccion As New Capa_Negocio.Produccion
                Try
                    CkRevisado.Checked = True
                    EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                    EntidadProduccion.IdEstatus = True
                    NegocioProduccion.UpsertRevisadoProduccion(EntidadProduccion)

                    GeneraRegistroBitacora(Me.Text.Clone.ToString, AprovarRevisionToolStripMenuItem.Text, TbIdOrdenTrabajo.Text, TbNombreProductor.Text)
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            End If
        Else
            MsgBox("Esta Orden ya se ha revisado anteriormente", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Sub BtEliminarPacas_Click(sender As Object, e As EventArgs) Handles BtEliminarPacas.Click
        If DgvPacas.Rows.Count > 0 Then
            Dim opc As DialogResult = MsgBox("¿Eliminar pacas seleccionadas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar Pacas Seleccionadas")
            If opc = DialogResult.Yes Then
                Try
                    For i As Integer = 0 To DgvPacas.Rows.Count() - 1
                        Dim c As Boolean = DgvPacas.Rows(i).Cells(0).Value
                        If c = True Then
                            GeneraRegistroBitacora(Me.Text.Clone.ToString, BtEliminarPacas.Text, DgvPacas.Rows(i).Cells("FolioCIA").Value, DgvPacas.Rows(i).Cells("Kilos").Value & " KGs DEL PRODUCTOR " & TbNombreProductor.Text & " CON LA ORDEN No " & TbIdOrdenTrabajo.Text & " EN PLANTA " & CbPlanta.Text)
                            EliminaPaca(DgvPacas.Rows(i).Cells("FolioCIA").Value, TbIdOrdenTrabajo.Text)
                        End If
                    Next
                Catch ex As Exception
                    MsgBox(ex)
                Finally
                    ConsultaOrdenMod()
                    ConsultarFaltantes()
                    ConsultaDetallesOrden()
                    ConsultarEstatusRevision()

                    If TbIdOrdenTrabajo.Text <> "" Then
                        DgvPacasLigeras.DataSource = CargaDgvPacasPesos(False, NuRegistrosLigero.Value, NuPesoLigero.Value)
                        TbContarLigeras.Text = DgvPacasLigeras.RowCount
                        DgvPacasPesadas.DataSource = CargaDgvPacasPesos(True, NuRegistroPesado.Value, NuPesoPesado.Value)
                        TbContarPesadas.Text = DgvPacasPesadas.RowCount
                    End If
                    GuardarProduccion()
                End Try
            End If
        End If
    End Sub
    Private Sub BtConsultarL_Click(sender As Object, e As EventArgs) Handles BtConsultarL.Click
        DgvPacasLigeras.DataSource = CargaDgvPacasPesos(False, NuRegistrosLigero.Value, NuPesoLigero.Value)
        TbContarLigeras.Text = DgvPacasLigeras.RowCount
    End Sub

    Private Sub BtConsultarP_Click(sender As Object, e As EventArgs) Handles BtConsultarP.Click
        DgvPacasPesadas.DataSource = CargaDgvPacasPesos(True, NuRegistroPesado.Value, NuPesoPesado.Value)
        TbContarPesadas.Text = DgvPacasPesadas.RowCount
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbIdOrdenTrabajo.Text = ""
        TbIdProduccion.Text = ""
        CbPlanta.SelectedIndex = -1
        TbPrimerPaca.Text = ""
        TbUltimaPaca.Text = ""
        TbPacaLigera.Text = ""
        TbPacaPesada.Text = ""
        TbPesoLigero.Text = ""
        TbPesoPesado.Text = ""
        TbPesoPromedio.Text = ""
        TbPacasProducidas.Text = ""
        TbContarFaltantes.Text = ""
        TbContarLigeras.Text = ""
        TbContarPesadas.Text = ""
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        TbModulos.Text = ""
        TbTotalModulos.Text = ""
        TbFolioCIA.Text = ""
        TbKilos.Text = ""
        TbTotalPacas.Text = ""
        TbTotalKilos.Text = ""
        TbInicioFaltante.Text = ""
        TbFinFaltante.Text = ""
        CkRevisado.Checked = False
        TbConsecutivoInicial.Text = ""
        NuRegistroPesado.Value = 10
        NuPesoPesado.Value = 250
        NuRegistrosLigero.Value = 10
        NuPesoLigero.Value = 180
        GbFolioInicial.Enabled = False
        RbActualizar.Checked = False
        RbAgregar.Checked = False
        DgvPacasFaltantes.DataSource = ""
        DgvPacasLigeras.DataSource = ""
        DgvPacasPesadas.DataSource = ""
        DgvPacas.DataSource = ""
        TbIdOrdenTrabajo.ReadOnly = False
        TbIdOrdenTrabajo.Focus()
    End Sub
    Private Sub TbEtiquetaActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbFolioCIA.KeyPress, TbKilos.KeyPress, TbIdOrdenTrabajo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TbIdOrdenTrabajo_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdOrdenTrabajo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
            Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
            Try
                If TbIdOrdenTrabajo.Text <> "" Then
                    EntidadOrdenTrabajo.Consulta = Consulta.ConsultaOrdenRevision
                    EntidadOrdenTrabajo.IdOrdenTrabajo = Val(TbIdOrdenTrabajo.Text)
                    NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
                    Tabla = EntidadOrdenTrabajo.TablaConsulta
                    If Tabla.Rows.Count = 0 Then
                        MsgBox("No hay resultado para esa Orden", MsgBoxStyle.Information, "Aviso")
                        Limpiar()
                        Exit Sub
                    Else
                        TbIdOrdenTrabajo.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
                        TbIdProduccion.Text = Tabla.Rows(0).Item("IdProduccion")
                        CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdplantaOrigen")
                        TbPrimerPaca.Text = Tabla.Rows(0).Item("PrimerPaca")
                        TbUltimaPaca.Text = Tabla.Rows(0).Item("UltimaPaca")
                        TbPacasProducidas.Text = Tabla.Rows(0).Item("PacasProducidas")
                        TbPesoPromedio.Text = Tabla.Rows(0).Item("PesoPromedio")
                        TbPacaLigera.Text = Tabla.Rows(0).Item("EtiquetaPacaLigera")
                        TbPesoLigero.Text = Tabla.Rows(0).Item("PacaLigera")
                        TbPacaPesada.Text = Tabla.Rows(0).Item("EtiquetaPacaPesada")
                        TbPesoPesado.Text = Tabla.Rows(0).Item("PacaPesada")
                        GbFolioInicial.Enabled = True
                    End If

                    ConsultarFaltantes()
                    ConsultaDetallesOrden()
                    ConsultarEstatusRevision()

                    If TbIdOrdenTrabajo.Text <> "" Then
                        DgvPacasLigeras.DataSource = CargaDgvPacasPesos(False, NuRegistrosLigero.Value, NuPesoLigero.Value)
                        TbContarLigeras.Text = DgvPacasLigeras.RowCount
                        DgvPacasPesadas.DataSource = CargaDgvPacasPesos(True, NuRegistroPesado.Value, NuPesoPesado.Value)
                        TbContarPesadas.Text = DgvPacasPesadas.RowCount
                    End If
                    RbActualizar.Checked = False
                    RbAgregar.Checked = False
                    TbFolioCIA.Text = ""
                    TbConsecutivoInicial.Text = ""
                    TbKilos.Text = ""
                    TbIdOrdenTrabajo.ReadOnly = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
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
        '--Tipo--    
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "NORMAL"
        dt.Rows.Add(dr)
        CbTipo.DataSource = dt
        CbTipo.ValueMember = "Id"
        CbTipo.DisplayMember = "Descripcion"
        CbTipo.SelectedValue = 1
        '--Turno--    
        Dim dt2 As DataTable = New DataTable("Tabla")
        dt2.Columns.Add("Id")
        dt2.Columns.Add("Descripcion")
        Dim dr2 As DataRow
        dr2 = dt2.NewRow()
        dr2("Id") = "1"
        dr2("Descripcion") = "PRIMERO"
        dt2.Rows.Add(dr2)
        dr2 = dt2.NewRow()
        dr2("Id") = "2"
        dr2("Descripcion") = "SEGUNDO"
        dt2.Rows.Add(dr2)
        CbTurno.DataSource = dt2
        CbTurno.ValueMember = "Id"
        CbTurno.DisplayMember = "Descripcion"
        CbTurno.SelectedValue = 1
        '--Tipo Producto--    
        Dim dt3 As DataTable = New DataTable("Tabla")
        dt3.Columns.Add("Id")
        dt3.Columns.Add("Descripcion")
        Dim dr3 As DataRow
        dr3 = dt3.NewRow()
        dr3("Id") = "1"
        dr3("Descripcion") = "PACA"
        dt3.Rows.Add(dr3)
        dr3 = dt3.NewRow()
        dr3("Id") = "2"
        dr3("Descripcion") = "BORREGO"
        dt3.Rows.Add(dr3)
        CbTipoProducto.DataSource = dt3
        CbTipoProducto.ValueMember = "Id"
        CbTipoProducto.DisplayMember = "Descripcion"
        CbTipoProducto.SelectedValue = 1
    End Sub
    Private Function CargaDgvPacasPesos(ByVal PesoElegir As Boolean, ByVal NumeroRegistro As Integer, ByVal KilosElegir As Integer)
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaProduccionPesos
        EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
        EntidadProduccion.NumeroRegistro = NumeroRegistro
        EntidadProduccion.Kilos = KilosElegir
        EntidadProduccion.PesoElegir = PesoElegir
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        Return Tabla
    End Function
    Private Sub ConsultaOrdenMod()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        Try
            EntidadOrdenTrabajo.Consulta = Consulta.ConsultaOrdenRevision
            EntidadOrdenTrabajo.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
            NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
            Tabla = EntidadOrdenTrabajo.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                Exit Sub
            Else
                TbIdOrdenTrabajo.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
                TbIdProduccion.Text = Tabla.Rows(0).Item("IdProduccion")
                CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdplantaOrigen")
                TbPrimerPaca.Text = Tabla.Rows(0).Item("PrimerPaca")
                TbUltimaPaca.Text = Tabla.Rows(0).Item("UltimaPaca")
                TbPacasProducidas.Text = Tabla.Rows(0).Item("PacasProducidas")
                TbPesoPromedio.Text = Tabla.Rows(0).Item("PesoPromedio")
                TbPacaLigera.Text = Tabla.Rows(0).Item("EtiquetaPacaLigera")
                TbPesoLigero.Text = Tabla.Rows(0).Item("PacaLigera")
                TbPacaPesada.Text = Tabla.Rows(0).Item("EtiquetaPacaPesada")
                TbPesoPesado.Text = Tabla.Rows(0).Item("PacaPesada")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarOrden()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        Dim ConsultaProduccion As New ConsultaProduccionRevision()
        ConsultaProduccion.ShowDialog()
        Try
            EntidadOrdenTrabajo.Consulta = Consulta.ConsultaOrdenRevision
            EntidadOrdenTrabajo.IdOrdenTrabajo = ConsultaProduccion.IdOrdenTrabajo
            NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
            Tabla = EntidadOrdenTrabajo.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                Exit Sub
            Else
                TbIdOrdenTrabajo.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
                TbIdProduccion.Text = Tabla.Rows(0).Item("IdProduccion")
                CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdplantaOrigen")
                TbPrimerPaca.Text = Tabla.Rows(0).Item("PrimerPaca")
                TbUltimaPaca.Text = Tabla.Rows(0).Item("UltimaPaca")
                TbPacasProducidas.Text = Tabla.Rows(0).Item("PacasProducidas")
                TbPesoPromedio.Text = Tabla.Rows(0).Item("PesoPromedio")
                TbPacaLigera.Text = Tabla.Rows(0).Item("EtiquetaPacaLigera")
                TbPesoLigero.Text = Tabla.Rows(0).Item("PacaLigera")
                TbPacaPesada.Text = Tabla.Rows(0).Item("EtiquetaPacaPesada")
                TbPesoPesado.Text = Tabla.Rows(0).Item("PacaPesada")
                GbFolioInicial.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarFaltantes()
        If CbPlanta.Text <> "" And Val(TbPrimerPaca.Text) > 0 And Val(TbUltimaPaca.Text) > Val(TbPrimerPaca.Text) Then
            Dim diferenciapacas As Long = Val(TbUltimaPaca.Text) - Val(TbPrimerPaca.Text)
            Dim pacaproducida As Integer = Val(TbPacasProducidas.Text)
            If (diferenciapacas - pacaproducida) < pacaproducida Then
                Dim EntidadReportes As New Capa_Entidad.Reportes
                Dim NegocioReportes As New Capa_Negocio.Reportes
                Dim Tabla As New DataTable
                Try
                    EntidadReportes.Reporte = Reporte.ReportePacasFaltantes
                    EntidadReportes.IdPlanta = CbPlanta.SelectedValue
                    EntidadReportes.PacaInicial = Val(TbPrimerPaca.Text)
                    EntidadReportes.PacaFinal = Val(TbUltimaPaca.Text)
                    NegocioReportes.Consultar(EntidadReportes)
                    Tabla = EntidadReportes.TablaConsulta
                    If Tabla.Rows.Count = 0 Then
                        Exit Sub
                    Else
                        DgvPacasFaltantes.DataSource = EntidadReportes.TablaConsulta
                        TbContarFaltantes.Text = DgvPacasFaltantes.RowCount
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("El faltante de pacas son " & FormatNumber(diferenciapacas) & " revisar el error directamente en la produccion!", MsgBoxStyle.Critical, "Aviso")
            End If
        End If
    End Sub
    Private Sub ConsultarFaltantesBtn()
        If CbPlanta.Text <> "" And Val(TbInicioFaltante.Text) > 0 And Val(TbFinFaltante.Text) > Val(TbInicioFaltante.Text) Then
            Dim diferenciapacas As Long = Val(TbFinFaltante.Text) - Val(TbInicioFaltante.Text)
            Dim pacaproducida As Integer = Val(TbPacasProducidas.Text)
            If (diferenciapacas - pacaproducida) < 20 Then
                Dim EntidadReportes As New Capa_Entidad.Reportes
                Dim NegocioReportes As New Capa_Negocio.Reportes
                Dim Tabla As New DataTable
                Try
                    EntidadReportes.Reporte = Reporte.ReportePacasFaltantes
                    EntidadReportes.IdPlanta = CbPlanta.SelectedValue
                    EntidadReportes.PacaInicial = Val(TbInicioFaltante.Text)
                    EntidadReportes.PacaFinal = Val(TbFinFaltante.Text)
                    NegocioReportes.Consultar(EntidadReportes)
                    Tabla = EntidadReportes.TablaConsulta
                    If Tabla.Rows.Count = 0 Then
                        Exit Sub
                    Else
                        DgvPacasFaltantes.DataSource = EntidadReportes.TablaConsulta
                        TbContarFaltantes.Text = DgvPacasFaltantes.RowCount
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub ConsultaDetallesOrden()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaDetallada
        EntidadProduccion.IdOrdenTrabajo = Val(TbIdOrdenTrabajo.Text)
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        Else
            'CbPlantaOrigen.SelectedValue = Tabla.Rows(0).Item("IdPlantaOrigen")
            TbIdProductor.Text = Tabla.Rows(0).Item("IdCliente")
            TbNombreProductor.Text = Tabla.Rows(0).Item("Nombre")
            TbModulos.Text = Tabla.Rows(0).Item("Modulos")
            TbTotalModulos.Text = Tabla.Rows(0).Item("NumeroModulos")
            ckpepena.Checked = Tabla.Rows(0).Item("checkpepena")
            DgvPacas.DataSource = Nothing
            'TbIdOrdenTrabajo.Enabled = False
            If TbIdProduccion.Text <> "" Then
                Consultar()
            End If
            TbTotalPacas.Text = DgvPacas.RowCount
            TbTotalKilos.Text = SumaKilos()
        End If
    End Sub
    Private Sub Consultar()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaBasica
        EntidadProduccion.IdProduccion = CInt(TbIdProduccion.Text)
        EntidadProduccion.IdPlantaOrigen = CbPlanta.SelectedValue
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        DgvPacas.DataSource = Tabla
        PropiedadesDGV()
    End Sub
    Private Sub ConsultarEstatusRevision()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        Try
            EntidadProduccion.Consulta = Consulta.ConsultaEstatusRevision
            EntidadProduccion.IdProduccion = Val(TbIdProduccion.Text)
            EntidadProduccion.IdPlantaOrigen = CbPlanta.SelectedValue
            NegocioProduccion.Consultar(EntidadProduccion)
            Tabla = EntidadProduccion.TablaConsulta
            If DgvPacas.RowCount > 0 Then
                CkRevisado.Checked = Tabla.Rows(0).Item("EstatusRevisado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PropiedadesDGV()
        DgvPacas.Columns("Sel").ReadOnly = False
        DgvPacas.Columns("IdProduccionDetalle").Visible = False
        DgvPacas.Columns("IdPlantaOrigen").Visible = False
        DgvPacas.Columns("IdOrdenTrabajo").Visible = False
        DgvPacas.Columns("IdProduccion").Visible = False
        DgvPacas.Columns("FolioCIA").ReadOnly = True
        DgvPacas.Columns("Tipo").ReadOnly = True
        DgvPacas.Columns("Kilos").ReadOnly = True
        DgvPacas.Columns("Fecha").ReadOnly = True
    End Sub
    Private Function SumaKilos()
        Dim TotalKilos As Integer = 0
        If DgvPacas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPacas.Rows
                If Not Fila Is Nothing Then
                    TotalKilos = TotalKilos + Int(Fila.Cells("Kilos").Value)
                End If
            Next
        End If
        Return TotalKilos
    End Function
    Private Sub GuardarProduccion()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Try
            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
            EntidadProduccion.IdPlantaOrigen = CbPlanta.SelectedValue
            EntidadProduccion.IdPlantaDestino = 1
            EntidadProduccion.Fecha = Now
            EntidadProduccion.Tipo = CbTipo.Text
            EntidadProduccion.IdCliente = TbIdProductor.Text
            EntidadProduccion.TotalHueso = 0
            EntidadProduccion.Pacas = Val(TbTotalPacas.Text)
            EntidadProduccion.PlumaPacas = Val(TbTotalKilos.Text)
            EntidadProduccion.PlumaBorregos = 0
            EntidadProduccion.Pluma = 0
            EntidadProduccion.Semilla = 0
            EntidadProduccion.Merma = 0
            EntidadProduccion.Borra = 0
            EntidadProduccion.PorcentajePluma = 0
            EntidadProduccion.PorcentajeSemilla = 0
            EntidadProduccion.PorcentajeMerma = 0
            EntidadProduccion.IdUsuarioCreacion = 1
            EntidadProduccion.FechaCreacion = Now
            EntidadProduccion.IdUsuarioActualizacion = 1
            EntidadProduccion.FechaActualizacion = Now
            NegocioProduccion.Guardar(EntidadProduccion)
            TbIdProduccion.Text = EntidadProduccion.IdProduccion
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Private Sub EliminaPaca(ByVal FolioCIA As Long, ByVal IdOrdenTrabajo As Integer)
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Eliminar = Eliminar.EliminaPacaSeleccionada
        EntidadProduccion.FolioCIA = FolioCIA
        EntidadProduccion.IdOrdenTrabajo = IdOrdenTrabajo
        NegocioProduccion.EliminarPaca(EntidadProduccion)
    End Sub
    Private Sub TbKilos_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbKilos.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                CapturaPacasSinSaco()
                TbTotalPacas.Text = DgvPacas.RowCount
                TbTotalKilos.Text = SumaKilos()
                GuardarProduccion()
        End Select
    End Sub
    Private Sub CapturaPacasSinSaco()
        If TbIdOrdenTrabajo.Text <> "" Then
            If TbKilos.Text <> "" And TbFolioCIA.Text <> "" Then
                If RbActualizar.Checked = True Then
                    If ConsultarPacaExistente(TbFolioCIA.Text, CbPlanta.SelectedValue) = 1 Then
                        'MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                        'TbKilos.Text = ""
                        'ActualizarUltimaEtiqueta()
                        Dim EntidadProduccion As New Capa_Entidad.Produccion
                        Dim NegocioProduccion As New Capa_Negocio.Produccion
                        EntidadProduccion.IdProduccionDetalle = IdProduccionDetalle
                        EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                        EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                        EntidadProduccion.IdPlantaOrigen = CbPlanta.SelectedValue
                        EntidadProduccion.FolioCIA = FolioCIAReturn
                        EntidadProduccion.Tipo = CbTipoProducto.Text
                        EntidadProduccion.Kilos = Val(TbKilos.Text)
                        EntidadProduccion.BandExiste = True
                        EntidadProduccion.IdTurno = CbTurno.SelectedValue
                        EntidadProduccion.IdEstatus = 1
                        EntidadProduccion.Fecha = Now
                        EntidadProduccion.IdBaja = 0
                        EntidadProduccion.FechaBaja = Now
                        EntidadProduccion.ClaveClasificacion = 0
                        EntidadProduccion.Micros = 0
                        EntidadProduccion.Castigo = 0
                        EntidadProduccion.CastigoMicCpa = 0
                        EntidadProduccion.CastigoMicVta = 0
                        EntidadProduccion.CastigoLargoFibra = 0
                        EntidadProduccion.CastigoLargoFibraCpa = 0
                        EntidadProduccion.CastigoLargoFibraVta = 0
                        EntidadProduccion.CastigoResistenciaFibra = 0
                        EntidadProduccion.CastigoResistenciaFibraCpa = 0
                        EntidadProduccion.CastigoResistenciaFibraVta = 0
                        EntidadProduccion.ClaveClasificacionCpa = 0
                        EntidadProduccion.ClaveClasificacionVta = 0
                        EntidadProduccion.FechaClasificacion = Now
                        EntidadProduccion.Libras = 0
                        EntidadProduccion.ClaveCertificado = 0
                        EntidadProduccion.ClaveContratoAlgodon = 0
                        EntidadProduccion.ClaveContratoAlgodon2 = 0
                        EntidadProduccion.ClavePaqueteHVI = 0
                        EntidadProduccion.LargoFibra = 0
                        EntidadProduccion.ResistenciaFibra = 0
                        NegocioProduccion.GuardarDetalle(EntidadProduccion)
                        'ActualizarUltimaEtiqueta()
                        Consultar()
                        TbFolioCIA.Text = ""
                        TbKilos.Text = ""
                        'ConsultaUltimaSecuencia()
                        'TbFolioCIA.Text = EtiquetaEscaneada
                        TbKilos.Select()
                    Else
                        MsgBox("La paca con la etiqueta " & TbFolioCIA.Text & " no existe para actualizarla.")
                    End If
                ElseIf RbAgregar.Checked = True Then
                    If ConsultarPacaExistente(TbFolioCIA.Text, CbPlanta.SelectedValue) = 0 Then
                        Dim EntidadProduccion As New Capa_Entidad.Produccion
                        Dim NegocioProduccion As New Capa_Negocio.Produccion
                        EntidadProduccion.IdProduccionDetalle = 0
                        EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                        EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                        EntidadProduccion.IdPlantaOrigen = CbPlanta.SelectedValue
                        EntidadProduccion.FolioCIA = TbFolioCIA.Text
                        EntidadProduccion.Tipo = CbTipoProducto.Text
                        EntidadProduccion.Kilos = Val(TbKilos.Text)
                        EntidadProduccion.BandExiste = True
                        EntidadProduccion.IdTurno = CbTurno.SelectedValue
                        EntidadProduccion.IdEstatus = 1
                        EntidadProduccion.Fecha = Now
                        EntidadProduccion.IdBaja = 0
                        EntidadProduccion.FechaBaja = Now
                        EntidadProduccion.ClaveClasificacion = 0
                        EntidadProduccion.Micros = 0
                        EntidadProduccion.Castigo = 0
                        EntidadProduccion.CastigoMicCpa = 0
                        EntidadProduccion.CastigoMicVta = 0
                        EntidadProduccion.CastigoLargoFibra = 0
                        EntidadProduccion.CastigoLargoFibraCpa = 0
                        EntidadProduccion.CastigoLargoFibraVta = 0
                        EntidadProduccion.CastigoResistenciaFibra = 0
                        EntidadProduccion.CastigoResistenciaFibraCpa = 0
                        EntidadProduccion.CastigoResistenciaFibraVta = 0
                        EntidadProduccion.ClaveClasificacionCpa = 0
                        EntidadProduccion.ClaveClasificacionVta = 0
                        EntidadProduccion.FechaClasificacion = Now
                        EntidadProduccion.Libras = 0
                        EntidadProduccion.ClaveCertificado = 0
                        EntidadProduccion.ClaveContratoAlgodon = 0
                        EntidadProduccion.ClaveContratoAlgodon2 = 0
                        EntidadProduccion.ClavePaqueteHVI = 0
                        EntidadProduccion.LargoFibra = 0
                        EntidadProduccion.ResistenciaFibra = 0
                        NegocioProduccion.GuardarDetalle(EntidadProduccion)
                        'ActualizarUltimaEtiqueta()
                        Consultar()
                        TbFolioCIA.Text = ""
                        TbKilos.Text = ""
                        'ConsultaUltimaSecuencia()
                        'TbFolioInicial.Text = UltimaSecuencia
                        'TbFolioCIA.Text = UltimaSecuencia
                        TbKilos.Select()
                    Else
                        MsgBox("La paca con la etiqueta " & TbFolioCIA.Text & " ya existe, desea actualizarla?")
                    End If
                End If
            End If
        Else
            MsgBox("Por favor, abrir una produccion", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        'If TbIdOrdenTrabajo.Text <> "" Then
        '    'If TbKilos.Text <> "" Then
        '    '    TbConsecutivoInicial.Text = Val(TbConsecutivoInicial.Text) + 1
        '    '    TbFolioCIA.Text = TbConsecutivoInicial.Text
        '    '    TbKilos.Text = ""
        '    'End If
        '    If TbKilos.Text <> "" And TbFolioCIA.Text <> "" Then
        '        If ConsultarPacaExistente(TbFolioCIA.Text, CbPlanta.SelectedValue) = 1 Then
        '            'MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        '            'TbKilos.Text = ""
        '            'ActualizarUltimaEtiqueta()
        '            Dim EntidadProduccion As New Capa_Entidad.Produccion
        '            Dim NegocioProduccion As New Capa_Negocio.Produccion
        '            EntidadProduccion.IdProduccionDetalle = IdProduccionDetalle
        '            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
        '            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
        '            EntidadProduccion.IdPlantaOrigen = CbPlanta.SelectedValue
        '            EntidadProduccion.FolioCIA = FolioCIAReturn
        '            EntidadProduccion.Tipo = CbTipoProducto.Text
        '            EntidadProduccion.Kilos = Val(TbKilos.Text)
        '            EntidadProduccion.BandExiste = True
        '            EntidadProduccion.IdTurno = CbTurno.SelectedValue
        '            EntidadProduccion.IdEstatus = 1
        '            EntidadProduccion.Fecha = Now
        '            EntidadProduccion.IdBaja = 0
        '            EntidadProduccion.FechaBaja = Now
        '            EntidadProduccion.ClaveClasificacion = 0
        '            EntidadProduccion.Micros = 0
        '            EntidadProduccion.Castigo = 0
        '            EntidadProduccion.CastigoMicCpa = 0
        '            EntidadProduccion.CastigoMicVta = 0
        '            EntidadProduccion.CastigoLargoFibra = 0
        '            EntidadProduccion.CastigoLargoFibraCpa = 0
        '            EntidadProduccion.CastigoLargoFibraVta = 0
        '            EntidadProduccion.CastigoResistenciaFibra = 0
        '            EntidadProduccion.CastigoResistenciaFibraCpa = 0
        '            EntidadProduccion.CastigoResistenciaFibraVta = 0
        '            EntidadProduccion.ClaveClasificacionCpa = 0
        '            EntidadProduccion.ClaveClasificacionVta = 0
        '            EntidadProduccion.FechaClasificacion = Now
        '            EntidadProduccion.Libras = 0
        '            EntidadProduccion.ClaveCertificado = 0
        '            EntidadProduccion.ClaveContratoAlgodon = 0
        '            EntidadProduccion.ClaveContratoAlgodon2 = 0
        '            EntidadProduccion.ClavePaqueteHVI = 0
        '            EntidadProduccion.LargoFibra = 0
        '            EntidadProduccion.ResistenciaFibra = 0
        '            NegocioProduccion.GuardarDetalle(EntidadProduccion)
        '            'ActualizarUltimaEtiqueta()
        '            Consultar()
        '            TbFolioCIA.Text = ""
        '            TbKilos.Text = ""
        '            'ConsultaUltimaSecuencia()
        '            'TbFolioCIA.Text = EtiquetaEscaneada
        '            TbKilos.Select()
        '        Else
        '            Dim EntidadProduccion As New Capa_Entidad.Produccion
        '            Dim NegocioProduccion As New Capa_Negocio.Produccion
        '            EntidadProduccion.IdProduccionDetalle = 0
        '            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
        '            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
        '            EntidadProduccion.IdPlantaOrigen = CbPlanta.SelectedValue
        '            EntidadProduccion.FolioCIA = TbFolioCIA.Text
        '            EntidadProduccion.Tipo = CbTipoProducto.Text
        '            EntidadProduccion.Kilos = Val(TbKilos.Text)
        '            EntidadProduccion.BandExiste = True
        '            EntidadProduccion.IdTurno = CbTurno.SelectedValue
        '            EntidadProduccion.IdEstatus = 1
        '            EntidadProduccion.Fecha = Now
        '            EntidadProduccion.IdBaja = 0
        '            EntidadProduccion.FechaBaja = Now
        '            EntidadProduccion.ClaveClasificacion = 0
        '            EntidadProduccion.Micros = 0
        '            EntidadProduccion.Castigo = 0
        '            EntidadProduccion.CastigoMicCpa = 0
        '            EntidadProduccion.CastigoMicVta = 0
        '            EntidadProduccion.CastigoLargoFibra = 0
        '            EntidadProduccion.CastigoLargoFibraCpa = 0
        '            EntidadProduccion.CastigoLargoFibraVta = 0
        '            EntidadProduccion.CastigoResistenciaFibra = 0
        '            EntidadProduccion.CastigoResistenciaFibraCpa = 0
        '            EntidadProduccion.CastigoResistenciaFibraVta = 0
        '            EntidadProduccion.ClaveClasificacionCpa = 0
        '            EntidadProduccion.ClaveClasificacionVta = 0
        '            EntidadProduccion.FechaClasificacion = Now
        '            EntidadProduccion.Libras = 0
        '            EntidadProduccion.ClaveCertificado = 0
        '            EntidadProduccion.ClaveContratoAlgodon = 0
        '            EntidadProduccion.ClaveContratoAlgodon2 = 0
        '            EntidadProduccion.ClavePaqueteHVI = 0
        '            EntidadProduccion.LargoFibra = 0
        '            EntidadProduccion.ResistenciaFibra = 0
        '            NegocioProduccion.GuardarDetalle(EntidadProduccion)
        '            'ActualizarUltimaEtiqueta()
        '            Consultar()
        '            TbFolioCIA.Text = ""
        '            TbKilos.Text = ""
        '            'ConsultaUltimaSecuencia()
        '            'TbFolioInicial.Text = UltimaSecuencia
        '            'TbFolioCIA.Text = UltimaSecuencia
        '            TbKilos.Select()
        '        End If
        '    Else
        '        MsgBox("Verificar peso y folio", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        '    End If
        'Else
        '    MsgBox("Por favor, abrir una produccion", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        '    Exit Sub
        'End If
    End Sub
    Private Function ConsultarPacaExistente(ByVal FolioCIA As Long, ByVal IdPlantaElabora As Integer)
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaPacaExistente
        'EntidadProduccion.FolioCIA = IIf(SpCapturaAutomatica.IsOpen = True, Val(TbFolioInicial.Text), Val(TbFolioCIA.Text))
        EntidadProduccion.FolioCIA = FolioCIA
        EntidadProduccion.IdPlantaOrigen = CbPlanta.SelectedValue
        EntidadProduccion.IdProduccion = TbIdProduccion.Text
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        If Tabla.Rows(0).Item("Resultado") = 1 Then
            IdProduccionDetalle = Tabla.Rows(0).Item("IdProduccionDetalle")
            FolioCIAReturn = Tabla.Rows(0).Item("FolioCIA")
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Sub BtConsultarFaltante_Click(sender As Object, e As EventArgs) Handles BtConsultarFaltante.Click
        ConsultarFaltantesBtn()
    End Sub

    Private Sub RbAgregar_Click(sender As Object, e As EventArgs) Handles RbAgregar.Click
        If RbAgregar.Checked = True And Val(TbIdOrdenTrabajo.Text) > 0 Then
            TbConsecutivoInicial.Text = TbPrimerPaca.Text
        End If
    End Sub

    Private Sub RbActualizar_Click(sender As Object, e As EventArgs) Handles RbActualizar.Click
        If RbActualizar.Checked = True And Val(TbIdOrdenTrabajo.Text) > 0 Then
            TbFolioCIA.Text = ""
            TbConsecutivoInicial.Text = ""
        End If
    End Sub

    Private Sub BtEstablecefolio_Click(sender As Object, e As EventArgs) Handles BtEstablecefolio.Click
        If TbConsecutivoInicial.Text <> "" Then
            TbFolioCIA.Text = TbConsecutivoInicial.Text
            TbKilos.Select()
        End If
    End Sub

    Private Sub BtAgregarExcel_Click(sender As Object, e As EventArgs) Handles BtAgregarExcel.Click

    End Sub

    Private Sub TbIdOrdenTrabajo_GotFocus(sender As Object, e As EventArgs) Handles TbIdOrdenTrabajo.GotFocus
        TbIdOrdenTrabajo.SelectAll()
    End Sub

    Private Sub TbIdOrdenTrabajo_Click(sender As Object, e As EventArgs) Handles TbIdOrdenTrabajo.Click
        TbIdOrdenTrabajo.SelectAll()
    End Sub


End Class