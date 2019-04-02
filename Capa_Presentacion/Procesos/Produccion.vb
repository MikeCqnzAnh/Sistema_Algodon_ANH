Imports Capa_Operacion.Configuracion
Public Class Produccion
    Dim UltimaSecuencia As Integer
    Dim IdProduccionDetalle As Integer = 0
    Dim FolioCIAReturn As Integer = 0
    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        Limpiar()
        TbIdOrdenTrabajo.Select()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Limpiar()
        TbIdProduccion.Text = ""
        TbIdOrdenTrabajo.Text = ""
        CbPlantaOrigen.SelectedValue = 1
        CBPlantaElabora.SelectedValue = 1
        CbTipo.SelectedValue = 1
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        CbTurno.SelectedValue = 1
        CbOperador.SelectedValue = 1
        TbFolioInicial.Text = ""
        TbFolioCIA.Text = ""
        TbKilos.Text = ""
        TbModulos.Text = ""
        TbTotalModulos.Text = ""
        DgvPacas.DataSource = Nothing
        DeshabilitarControles()
        GbTipoCaptura.Enabled = False
        RbManual.Checked = True
    End Sub
    Private Sub CargarCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlantaOrigen.DataSource = Tabla
        CbPlantaOrigen.ValueMember = "IdPlanta"
        CbPlantaOrigen.DisplayMember = "Descripcion"
        CbPlantaOrigen.SelectedValue = 1
        '---Planta Elabora--        
        Dim Tabla2 As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla2 = EntidadProduccion.TablaConsulta
        CBPlantaElabora.DataSource = Tabla2
        CBPlantaElabora.ValueMember = "IdPlanta"
        CBPlantaElabora.DisplayMember = "Descripcion"
        CBPlantaElabora.SelectedValue = 1
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
        '---Operador
        Dim Tabla3 As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaOperadores
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla2 = EntidadProduccion.TablaConsulta
        CbOperador.DataSource = Tabla2
        CbOperador.ValueMember = "IdEmpleado"
        CbOperador.DisplayMember = "Nombre"
        CbOperador.SelectedValue = 1
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

    Private Sub TbIdOrdenTrabajo_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbIdOrdenTrabajo.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbIdOrdenTrabajo.Text <> "" Then
                    Dim EntidadProduccion As New Capa_Entidad.Produccion
                    Dim NegocioProduccion As New Capa_Negocio.Produccion
                    Dim Tabla As New DataTable
                    EntidadProduccion.Consulta = Consulta.ConsultaDetallada
                    EntidadProduccion.IdOrdenTrabajo = CInt(TbIdOrdenTrabajo.Text)
                    NegocioProduccion.Consultar(EntidadProduccion)
                    Tabla = EntidadProduccion.TablaConsulta
                    If Tabla.Rows.Count = 0 Then
                        MsgBox("La orden de trabajo no existe...")
                        Exit Sub
                    Else
                        CBPlantaElabora.SelectedValue = Tabla.Rows(0).Item("IdPlantaElabora")
                        TbIdProductor.Text = Tabla.Rows(0).Item("IdCliente")
                        TbNombreProductor.Text = Tabla.Rows(0).Item("Nombre")
                        TbModulos.Text = Tabla.Rows(0).Item("Modulos")
                        TbTotalModulos.Text = Tabla.Rows(0).Item("NumeroModulos")
                        ConsultarProduccionPorOrden()
                        DgvPacas.DataSource = Nothing
                        DeshabilitarControles()
                        BtAbrirProduccion.Enabled = True
                        BtCerrarProduccion.Enabled = False
                        TbFolioInicial.Enabled = True
                        If TbIdProduccion.Text <> "" Then
                            Consultar()
                        End If
                    End If
                Else
                    MsgBox("Ingrese el ID de la orden de trabajo...")
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub TbKilos_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbKilos.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbIdOrdenTrabajo.Text <> "" Then
                    If TbKilos.Text <> "" Or TbFolioCIA.Text <> "" Then
                        If ConsultarPacaExistente(TbFolioCIA.Text, CBPlantaElabora.SelectedValue) = 1 Then
                            'MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                            'TbKilos.Text = ""
                            'ActualizarUltimaEtiqueta()
                            Dim EntidadProduccion As New Capa_Entidad.Produccion
                            Dim NegocioProduccion As New Capa_Negocio.Produccion
                            EntidadProduccion.IdProduccionDetalle = IIf(IdProduccionDetalle = 0, 0, IdProduccionDetalle)
                            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
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
                            ActualizarUltimaEtiqueta()
                            Consultar()
                            TbFolioCIA.Text = ""
                            TbKilos.Text = ""
                            Exit Sub
                        Else
                            ConsultaUltimaSecuencia()
                            If TbFolioCIA.Text <> UltimaSecuencia Then
                                Dim opc = MessageBox.Show("El folio no coincide, ¿Desea reemplazarlo por el consecutivo" + " " + CStr(UltimaSecuencia) + " " + "siguiente?", "Aviso", MessageBoxButtons.YesNo)
                                If opc = DialogResult.Yes Then
                                    TbFolioCIA.Text = UltimaSecuencia
                                    Dim EntidadProduccion As New Capa_Entidad.Produccion
                                    Dim NegocioProduccion As New Capa_Negocio.Produccion
                                    EntidadProduccion.IdProduccionDetalle = 0
                                    EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                                    EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                                    EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
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
                                    ActualizarUltimaEtiqueta()
                                    Consultar()
                                    TbFolioCIA.Text = ""
                                    TbKilos.Text = ""
                                Else
                                    Dim EntidadProduccion As New Capa_Entidad.Produccion
                                    Dim NegocioProduccion As New Capa_Negocio.Produccion
                                    EntidadProduccion.IdProduccionDetalle = 0
                                    EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                                    EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                                    EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
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
                                    Consultar()
                                    TbFolioCIA.Text = ""
                                    TbKilos.Text = ""
                                End If
                            Else
                                Dim EntidadProduccion As New Capa_Entidad.Produccion
                                Dim NegocioProduccion As New Capa_Negocio.Produccion
                                EntidadProduccion.IdProduccionDetalle = 0
                                EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                                EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                                EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
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
                                ActualizarUltimaEtiqueta()
                                Consultar()
                                TbFolioCIA.Text = ""
                                TbKilos.Text = ""
                            End If
                        End If
                    Else
                        MsgBox("Verificar peso y folio", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                    End If
                Else
                    MsgBox("Por favor, abrir una produccion", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub BtAbrirProduccion_Click(sender As Object, e As EventArgs) Handles BtAbrirProduccion.Click
        TbFolioInicial.Enabled = True
        If TbFolioInicial.Text = "" Then
            MsgBox("Ingrese un folio inicial", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        Else
            UpsertFolioInicial()
        End If
        If TbIdProduccion.Text = "" And TbIdOrdenTrabajo.Text <> "" Then
            Dim opc = MessageBox.Show("¿Desea abrir la produccion con esta orden de trabajo?", "", MessageBoxButtons.YesNo)
            If opc = DialogResult.Yes Then
                Dim EntidadProduccion As New Capa_Entidad.Produccion
                Dim NegocioProduccion As New Capa_Negocio.Produccion
                EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
                EntidadProduccion.IdPlantaDestino = CBPlantaElabora.SelectedValue
                EntidadProduccion.Fecha = DtpFechaProduccion.Value
                EntidadProduccion.Tipo = CbTipo.Text
                EntidadProduccion.IdCliente = TbIdProductor.Text
                EntidadProduccion.TotalHueso = 0
                EntidadProduccion.Pacas = 0
                EntidadProduccion.PlumaPacas = 0
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
                GeneraRegistroBitacora(Me.Text.Clone.ToString, BtAbrirProduccion.Text, TbIdOrdenTrabajo.Text, TbNombreProductor.Text)
                MsgBox("Realizado correctamente", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
                HabilitarControles()
                BtAbrirProduccion.Enabled = False
                BtCerrarProduccion.Enabled = True
                Consultar()
            Else
                Exit Sub
            End If
        ElseIf TbIdProduccion.Text <> "" And TbIdOrdenTrabajo.Text <> "" Then
            GeneraRegistroBitacora(Me.Text.Clone.ToString, BtAbrirProduccion.Text, TbIdOrdenTrabajo.Text, TbNombreProductor.Text)
            MsgBox("Ya tiene una producccion con esta orden", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
            HabilitarControles()
            Consultar()
            BtAbrirProduccion.Enabled = False
            BtCerrarProduccion.Enabled = True
        ElseIf TbIdProduccion.Text = "" And TbIdOrdenTrabajo.Text = "" Then
            MsgBox("No se puede abrir produccion sin una orden de trabajo activa", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Sub HabilitarControles()
        TbFolioCIA.Enabled = True
        TbKilos.Enabled = True
        GbTipoCaptura.Enabled = True
    End Sub
    Private Sub DeshabilitarControles()
        TbFolioCIA.Enabled = False
        TbKilos.Enabled = False
        BtCerrarProduccion.Enabled = False
    End Sub
    Private Sub Consultar()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaBasica
        EntidadProduccion.IdProduccion = CInt(TbIdProduccion.Text)
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        DgvPacas.DataSource = Tabla
        PropiedadesDGV()
    End Sub

    Private Sub PropiedadesDGV()
        DgvPacas.Columns("IdProduccionDetalle").Visible = False
    End Sub
    Private Sub ConsultarProduccionPorOrden()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaPorId
        EntidadProduccion.IdOrdenTrabajo = CInt(TbIdOrdenTrabajo.Text)
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            TbIdProduccion.Text = ""
        Else
            TbIdProduccion.Text = Tabla.Rows(0).Item("IdProduccion")
            CbPlantaOrigen.SelectedValue = Tabla.Rows(0).Item("IdPlantaOrigen")
            CBPlantaElabora.SelectedValue = Tabla.Rows(0).Item("IdPlantaDestino")
            DtpFechaProduccion.Value = Tabla.Rows(0).Item("Fecha")
            CbTipo.Text = Tabla.Rows(0).Item("Tipo")
            TbIdProductor.Text = Tabla.Rows(0).Item("IdCliente")
            TbNombreProductor.Text = Tabla.Rows(0).Item("Nombre")
            TbFolioInicial.Text = Tabla.Rows(0).Item("FolioInicial")
        End If
    End Sub

    Private Sub BtCerrarProduccion_Click(sender As Object, e As EventArgs) Handles BtCerrarProduccion.Click
        Limpiar()
        DeshabilitarControles()
        BtAbrirProduccion.Enabled = True
        BtCerrarProduccion.Enabled = False
    End Sub

    Private Function ConsultarPacaExistente(ByVal FolioCIA As Integer, ByVal IdPlantaElabora As Integer)
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaPacaExistente
        EntidadProduccion.FolioCIA = IIf(RbAutomatico.Checked = True, Val(TbFolioInicial.Text), Val(TbFolioCIA.Text))
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
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

    Private Sub ActualizarUltimaEtiqueta()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        EntidadProduccion.FolioCIA = TbFolioCIA.Text
        NegocioProduccion.GuardarEtiqueta(EntidadProduccion)
    End Sub

    Private Sub ConsultaUltimaSecuencia()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaSecuencia
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            UltimaSecuencia = 1
        Else
            UltimaSecuencia = Tabla.Rows(0).Item("Secuencia")
        End If
    End Sub

    Private Sub TbFolioCIA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbFolioCIA.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TbKilos.Focus()
        End If
    End Sub

    Private Sub TbKilos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbKilos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TbFolioCIA.Focus()
        End If
    End Sub

    Private Sub TbIdOrdenTrabajo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdOrdenTrabajo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TbFolioInicial.Focus()
        End If
    End Sub

    Private Sub RbAutomatico_CheckedChanged(sender As Object, e As EventArgs) Handles RbAutomatico.CheckedChanged
        TbFolioCIA.Enabled = False
        TbKilos.Enabled = False
        TbFolioInicial.Enabled = True
    End Sub

    Private Sub RbManual_CheckedChanged(sender As Object, e As EventArgs) Handles RbManual.CheckedChanged
        TbFolioCIA.Enabled = True
        TbKilos.Enabled = True
        TbFolioInicial.Enabled = False
    End Sub

    Private Sub TbFolioInicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbFolioInicial.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtAbrirProduccion.Focus()
        End If
    End Sub

    Private Sub UpsertFolioInicial()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        EntidadProduccion.FolioInicial = Val(TbFolioInicial.Text)
        NegocioProduccion.UpsertFolioInicial(EntidadProduccion)
    End Sub
    '--------------------------------------------------------------
    '--------------------------------------------------------------
    Private Sub NOSEUSAAUN()
        'Se asigna el peso de la paca con el boton automaticamente         
        TbKilos.Text = 200
        '---------------------------------------------------------
        ConsultaUltimaSecuencia()
        If UltimaSecuencia = 1 Then
            UltimaSecuencia = Val(TbFolioInicial.Text)
        End If
        TbFolioCIA.Text = UltimaSecuencia
        If ConsultarPacaExistente(TbFolioCIA.Text, CBPlantaElabora.SelectedValue) = 1 Then
            MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            Dim EntidadProduccion As New Capa_Entidad.Produccion
            Dim NegocioProduccion As New Capa_Negocio.Produccion
            EntidadProduccion.IdProduccionDetalle = IIf(IdProduccionDetalle = 0, 0, IdProduccionDetalle)
            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
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
            ActualizarUltimaEtiqueta()
            Consultar()
            TbFolioCIA.Text = ""
            TbKilos.Text = ""
            TbKilos.Text = ""
            'Exit Sub
        ElseIf TbFolioCIA.Text <> UltimaSecuencia Then
            Dim opc = MessageBox.Show("El folio no coincide, ¿Desea reemplazarlo por el consecutivo" + " " + CStr(UltimaSecuencia) + " " + "siguiente?", "Aviso", MessageBoxButtons.YesNo)
            If opc = DialogResult.Yes Then
                TbFolioCIA.Text = UltimaSecuencia
                Dim EntidadProduccion As New Capa_Entidad.Produccion
                Dim NegocioProduccion As New Capa_Negocio.Produccion
                EntidadProduccion.IdProduccionDetalle = 0
                EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
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
                ActualizarUltimaEtiqueta()
                Consultar()
                TbFolioCIA.Text = ""
                TbKilos.Text = ""
            End If
        ElseIf TbFolioCIA.Text = UltimaSecuencia Then
            Dim EntidadProduccion As New Capa_Entidad.Produccion
            Dim NegocioProduccion As New Capa_Negocio.Produccion
            EntidadProduccion.IdProduccionDetalle = 0
            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
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
            ActualizarUltimaEtiqueta()
            Consultar()
            TbFolioCIA.Text = ""
            TbKilos.Text = ""
        End If
    End Sub
    Private Sub BtActualizarFolio_Click(sender As Object, e As EventArgs) Handles BtActualizarFolio.Click
        UpsertFolioInicial()
    End Sub
End Class