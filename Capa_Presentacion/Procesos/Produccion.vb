Imports Capa_Operacion.Configuracion
Imports System.IO.Ports
Imports System.Net
Public Class Produccion
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Conf\"
    Dim archivo As String = "config.ini"
    Dim PesoMinimoPaca, PosicionPesoBruto, PosicionTara, PosicionNeto, CaracterPesoBruto, CaracterTara, CaracterNeto, BaudRate, DataBits, StopBits, Parity, HandShake, DtrEnable, ReadBufferSize, WriteBufferSize, ReceivedBytesThreshold As Integer
    Dim IndicadorPesoBruto, IndicadorTara, IndicadorNeto, NombrePuerto As String
    Dim TextoIzq As Boolean
    Dim UltimaSecuencia, EtiquetaEscaneada As Long
    Dim IdProduccionDetalle As Integer = 0
    Dim FolioCIAReturn As Long = 0
    Dim Puerto As String
    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        CargarCombos()
        GetSerialPortNames()
        LeerArchivoConfiguracion()
        ConsultaParametros()
        TbIdOrdenTrabajo.Select()
        CheckForIllegalCrossThreadCalls = False
        LbStatus.Text = "CAPTURA AUTOMATICA DESACTIVADA"
        ActualizaEstatusLeerEtiqueta()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        If SpCapturaAutomatica.IsOpen = False Then
            Limpiar()
            CargarCombos()
            LeerArchivoConfiguracion()
            ConsultaParametros()
            TbIdOrdenTrabajo.Select()
            ActualizaEstatusLeerEtiqueta()
        Else
            MessageBox.Show("La captura automatica esta activada, desactive para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub TbEtiquetaActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdOrdenTrabajo.KeyPress, TbFolioInicial.KeyPress, TbFolioCIA.KeyPress, TbKilos.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ActualizaEstadoLeerSaco()
        Close()
    End Sub
    Private Sub ActualizaEstadoLeerSaco()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        EntidadProduccion.LeerEtiqueta = False
        NegocioProduccion.UpsertLeerEtiqueta(EntidadProduccion)
    End Sub
    Private Sub Salir(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If SpCapturaAutomatica.IsOpen = True Then
            MessageBox.Show("No se puede cerrar la ventana con la funcion de captura automatica activada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub GetSerialPortNames()
        ' muestra COM ports disponibles.
        Dim l As Integer

        Dim ncom As String

        Try

            CbPuertosSeriales.Items.Clear()

            For Each sp As String In My.Computer.Ports.SerialPortNames

                l = sp.Length

                If ((sp(l - 1) >= "0") And (sp(l - 1) <= "9")) Then
                    CbPuertosSeriales.Items.Add(sp)
                Else
                    'hay una letra al final del COM
                    ncom = sp.Substring(0, l - 1)
                    CbPuertosSeriales.Items.Add(ncom)
                End If
            Next
            If CbPuertosSeriales.Items.Count >= 1 Then

                CbPuertosSeriales.Text = CbPuertosSeriales.Items(0)
                Puerto = CbPuertosSeriales.Items(0)
            Else

                CbPuertosSeriales.Text = ""

            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Limpiar()
        TbIdProduccion.Text = ""
        TbIdOrdenTrabajo.Text = ""
        TbIdOrdenTrabajo.Enabled = True
        TbTotalPacas.Text = ""
        CBPlantaDestino.SelectedValue = 1
        CbTipo.SelectedValue = 1
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        CbTurno.SelectedValue = 1
        CbOperador.SelectedValue = 1
        TbFolioInicial.Text = ""
        TbFolioCIA.Text = ""
        TbKilos.Text = ""
        TbModulos.Text = ""
        DtpFechaProduccion.Value = Now
        TbTotalModulos.Text = ""
        DgvPacas.DataSource = Nothing
        DeshabilitarControles()
        GbCapturaAutomatica.Enabled = False
        GbTipoCaptura.Enabled = False
    End Sub
    Private Sub Setup_Puerto_Serie()
        Try
            With SpCapturaAutomatica
                If .IsOpen Then

                    .Close()

                End If
                .PortName = CbPuertosSeriales.Text

                .BaudRate = BaudRate '// 9600 baud rate

                .DataBits = DataBits '// 8 data bits

                .StopBits = StopBits '// 1 Stop bit

                .Parity = Parity '

                .DtrEnable = DtrEnable

                .Handshake = HandShake

                .ReadBufferSize = ReadBufferSize

                .WriteBufferSize = WriteBufferSize

                .ReceivedBytesThreshold = ReceivedBytesThreshold

                .WriteTimeout = 500

                .Encoding = System.Text.Encoding.Default

                .Open() ' ABRE EL PUERTO SERIE
            End With
        Catch ex As Exception
            MsgBox("Error al abrir el puerto serial: " & ex.Message, MsgBoxStyle.Critical)
        End Try
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
        CbPlantaOrigen.SelectedValue = 0
        '---Planta Elabora--        
        Dim Tabla2 As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla2 = EntidadProduccion.TablaConsulta
        CBPlantaDestino.DataSource = Tabla2
        CBPlantaDestino.ValueMember = "IdPlanta"
        CBPlantaDestino.DisplayMember = "Descripcion"
        CBPlantaDestino.SelectedValue = 1
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
                        'CbPlantaOrigen.SelectedValue = Tabla.Rows(0).Item("IdPlantaOrigen")
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
                        TbIdOrdenTrabajo.Enabled = False
                        If TbIdProduccion.Text <> "" Then
                            Consultar()
                        End If
                        ConsultaUltimaSecuencia()
                        TbFolioInicial.Text = UltimaSecuencia
                    End If
                Else
                    MsgBox("Ingrese el ID de la orden de trabajo...")
                    Exit Sub
                End If
                TbTotalPacas.Text = DgvPacas.RowCount
                TbTotalKilos.Text = SumaKilos()
        End Select
    End Sub
    Private Sub TbKilos_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbKilos.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If CkLeersaco.Checked = True Then
                    CapturaPacaConSaco()
                Else
                    CapturaPacasSinSaco()
                End If
        End Select
        TbTotalPacas.Text = DgvPacas.RowCount
        TbTotalKilos.Text = SumaKilos()
        GuardarProduccion()
    End Sub
    Private Sub CapturaPacaConSaco()
        If TbIdOrdenTrabajo.Text <> "" Then
            If TbKilos.Text <> "" And TbFolioCIA.Text <> "" Then
                ConsultaUltimaSecuencia()
                If TbFolioCIA.Text <> EtiquetaEscaneada Then
                    Dim opc = MessageBox.Show("El folio no coincide, ¿Desea reemplazarlo por el consecutivo" + " " + CStr(EtiquetaEscaneada) + " " + "siguiente?", "Aviso", MessageBoxButtons.YesNo)
                    If opc = DialogResult.Yes Then
                        If ConsultarPacaExistente(EtiquetaEscaneada, CbPlantaOrigen.SelectedValue) = 1 Then
                            'MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                            'TbKilos.Text = ""
                            'ActualizarUltimaEtiqueta()
                            Dim EntidadProduccion As New Capa_Entidad.Produccion
                            Dim NegocioProduccion As New Capa_Negocio.Produccion
                            EntidadProduccion.IdProduccionDetalle = IIf(IdProduccionDetalle = 0, 0, IdProduccionDetalle)
                            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
                            EntidadProduccion.FolioCIA = EtiquetaEscaneada
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
                            ConsultaUltimaSecuencia()
                            TbFolioCIA.Text = UltimaSecuencia
                            TbFolioInicial.Text = UltimaSecuencia
                            TbKilos.Select()
                        Else

                            'TbFolioCIA.Text = EtiquetaEscaneada
                            Dim EntidadProduccion As New Capa_Entidad.Produccion
                            Dim NegocioProduccion As New Capa_Negocio.Produccion
                            EntidadProduccion.IdProduccionDetalle = 0
                            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
                            EntidadProduccion.FolioCIA = EtiquetaEscaneada
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
                            ConsultaUltimaSecuencia()
                            TbFolioInicial.Text = UltimaSecuencia
                            TbFolioCIA.Text = UltimaSecuencia
                            TbKilos.Select()
                        End If
                    ElseIf ConsultarPacaExistente(TbFolioCIA.Text, CbPlantaOrigen.SelectedValue) = 1 Then
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
                        ConsultaUltimaSecuencia()
                        TbFolioCIA.Text = UltimaSecuencia
                        TbFolioInicial.Text = UltimaSecuencia
                        TbKilos.Select()
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
                        'TbFolioInicial.Text = Val(TbFolioCIA.Text) + 1
                        'UpsertFolioInicial(TbFolioCIA.Text)
                        'ActualizarUltimaEtiqueta()
                        Consultar()
                        TbFolioCIA.Text = ""
                        TbKilos.Text = ""
                        ConsultaUltimaSecuencia()
                        'TbFolioCIA.Text = EtiquetaEscaneada
                        TbFolioInicial.Text = UltimaSecuencia
                        TbFolioCIA.Text = UltimaSecuencia
                        TbKilos.Select()

                    End If
                ElseIf ConsultarPacaExistente(TbFolioCIA.Text, CbPlantaOrigen.SelectedValue) = 1 Then
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
                    ConsultaUltimaSecuencia()
                    TbFolioCIA.Text = EtiquetaEscaneada
                    TbKilos.Select()

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
                    'TbFolioInicial.Text = Val(TbFolioCIA.Text) + 1
                    'UpsertFolioInicial(TbFolioCIA.Text)
                    'ActualizarUltimaEtiqueta()
                    Consultar()
                    TbFolioCIA.Text = ""
                    TbKilos.Text = ""
                    ConsultaUltimaSecuencia()
                    'TbFolioCIA.Text = EtiquetaEscaneada
                    TbFolioInicial.Text = UltimaSecuencia
                    TbFolioCIA.Text = UltimaSecuencia
                    TbKilos.Select()
                End If
                'If 

                '    Exit Sub
                'Else

                'End If
            Else
                MsgBox("Verificar peso y folio", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("Por favor, abrir una produccion", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If
    End Sub
    Private Sub CapturaPacasSinSaco()
        If TbIdOrdenTrabajo.Text <> "" Then
            If TbKilos.Text <> "" And TbFolioCIA.Text <> "" Then
                If ConsultarPacaExistente(TbFolioCIA.Text, CbPlantaOrigen.SelectedValue) = 1 Then
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
                    ConsultaUltimaSecuencia()
                    TbFolioCIA.Text = EtiquetaEscaneada
                    TbKilos.Select()

                    Exit Sub
                Else
                    ConsultaUltimaSecuencia()
                    If TbFolioCIA.Text <> UltimaSecuencia Then
                        Dim opc = MessageBox.Show("El folio no coincide, ¿Desea reemplazarlo por el consecutivo" + " " + CStr(UltimaSecuencia) + " " + "siguiente?", "Aviso", MessageBoxButtons.YesNo)
                        If opc = DialogResult.Yes Then
                            'TbFolioCIA.Text = EtiquetaEscaneada
                            Dim EntidadProduccion As New Capa_Entidad.Produccion
                            Dim NegocioProduccion As New Capa_Negocio.Produccion
                            EntidadProduccion.IdProduccionDetalle = 0
                            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
                            EntidadProduccion.FolioCIA = UltimaSecuencia
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
                            ConsultaUltimaSecuencia()
                            TbFolioInicial.Text = UltimaSecuencia
                            TbFolioCIA.Text = UltimaSecuencia
                            TbKilos.Select()

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
                            ConsultaUltimaSecuencia()
                            TbFolioCIA.Text = UltimaSecuencia
                            TbKilos.Select()
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
                        'TbFolioInicial.Text = Val(TbFolioCIA.Text) + 1
                        'UpsertFolioInicial(TbFolioCIA.Text)
                        ActualizarUltimaEtiqueta()
                        Consultar()
                        TbFolioCIA.Text = ""
                        TbKilos.Text = ""
                        ConsultaUltimaSecuencia()
                        'TbFolioCIA.Text = EtiquetaEscaneada
                        TbFolioInicial.Text = UltimaSecuencia
                        TbFolioCIA.Text = UltimaSecuencia
                        TbKilos.Select()

                    End If
                End If
            Else
                MsgBox("Verificar peso y folio", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("Por favor, abrir una produccion", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If
    End Sub

    Private Sub BtAbrirProduccion_Click(sender As Object, e As EventArgs) Handles BtAbrirProduccion.Click
        TbFolioInicial.Enabled = True
        GbCapturaAutomatica.Enabled = True
        If TbFolioInicial.Text = "" Then
            MsgBox("Ingrese un folio inicial", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        Else
            UpsertFolioInicial(TbFolioInicial.Text)
        End If
        If TbIdProduccion.Text = "" And TbIdOrdenTrabajo.Text <> "" Then
            Dim opc = MessageBox.Show("¿Desea abrir la produccion con esta orden de trabajo?", "", MessageBoxButtons.YesNo)
            If opc = DialogResult.Yes Then
                GuardarProduccion()
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
            TbFolioCIA.Text = TbFolioInicial.Text
            TbKilos.Select()
        ElseIf TbIdProduccion.Text = "" And TbIdOrdenTrabajo.Text = "" Then
            MsgBox("No se puede abrir produccion sin una orden de trabajo activa", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Sub GuardarProduccion()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Try
            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
            EntidadProduccion.IdPlantaDestino = CBPlantaDestino.SelectedValue
            EntidadProduccion.Fecha = DtpFechaProduccion.Value
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
        Try
            EntidadProduccion.Consulta = Consulta.ConsultaBasica
            EntidadProduccion.IdProduccion = CInt(TbIdProduccion.Text)
            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
            NegocioProduccion.Consultar(EntidadProduccion)
            Tabla = EntidadProduccion.TablaConsulta
            DgvPacas.DataSource = Tabla
            PropiedadesDGV()

            If DgvPacas.Rows.Count > 0 Then
                TbTotalPacas.Text = DgvPacas.Rows.Count
                TbTotalKilos.Text = SumaKilos()
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
            'CbPlantaOrigen.SelectedValue = Tabla.Rows(0).Item("IdPlantaOrigen")
            CBPlantaDestino.SelectedValue = Tabla.Rows(0).Item("IdPlantaDestino")
            DtpFechaProduccion.Value = Tabla.Rows(0).Item("Fecha")
            CbTipo.Text = Tabla.Rows(0).Item("Tipo")
            TbIdProductor.Text = Tabla.Rows(0).Item("IdCliente")
            TbNombreProductor.Text = Tabla.Rows(0).Item("Nombre")
        End If
    End Sub
    Private Sub BtCerrarProduccion_Click(sender As Object, e As EventArgs) Handles BtCerrarProduccion.Click
        Limpiar()
        DeshabilitarControles()
        BtAbrirProduccion.Enabled = True
        BtCerrarProduccion.Enabled = False
    End Sub
    Private Function ConsultarPacaExistente(ByVal FolioCIA As Long, ByVal IdPlantaElabora As Integer)
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaPacaExistente
        'EntidadProduccion.FolioCIA = IIf(SpCapturaAutomatica.IsOpen = True, Val(TbFolioInicial.Text), Val(TbFolioCIA.Text))
        EntidadProduccion.FolioCIA = FolioCIA
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        EntidadProduccion.IdProduccion = TbIdProduccion.Text
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        If Tabla.Rows(0).Item("Resultado") = 1 Then
            IdProduccionDetalle = Tabla.Rows(0).Item("idproducciondetalle")
            FolioCIAReturn = Tabla.Rows(0).Item("FolioCIA")
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub ActualizarUltimaEtiqueta()
        If CkLeersaco.CheckState = False Then
            Dim EntidadProduccion As New Capa_Entidad.Produccion
            Dim NegocioProduccion As New Capa_Negocio.Produccion
            Dim Tabla As New DataTable
            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
            EntidadProduccion.FolioCIA = TbFolioCIA.Text
            NegocioProduccion.GuardarEtiqueta(EntidadProduccion)
        End If
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
            EtiquetaEscaneada = Tabla.Rows(0).Item("Etiqueta")
            'TbFolioInicial.Text = Tabla.Rows(0).Item("Secuencia")
            'TbFolioCIA.Text = Tabla.Rows(0).Item("Secuencia")
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

    Private Sub BtActivarPrensa_Click(sender As Object, e As EventArgs) Handles BtActivarPrensa.Click
        If IO.File.Exists(Ruta & archivo) Then
            If LbStatus.Text = "CAPTURA AUTOMATICA DESACTIVADA" Then
                DgvPacas.ReadOnly = True
                ConsultaUltimaSecuencia()
                TbFolioCIA.Text = UltimaSecuencia
                TbFolioInicial.Text = UltimaSecuencia
                TbFolioCIA.Enabled = False
                ' TbKilos.Enabled = False
                TbFolioInicial.Enabled = False
                TiActualizaDgvPacas.Enabled = True
                CbPuertosSeriales.Enabled = False
                GbDatosProduccion.Enabled = False
                CkLeersaco.Checked = True
                LbStatus.Text = "CAPTURA AUTOMATICA ACTIVADA"
                BtActivarPrensa.Text = "Desactivar Lectura de Prensa"
                Setup_Puerto_Serie()
            Else
                DgvPacas.ReadOnly = False
                GbDatosProduccion.Enabled = True
                TbFolioCIA.Enabled = True
                ' TbKilos.Enabled = True
                TbFolioInicial.Enabled = True
                CbPuertosSeriales.Enabled = True
                TiActualizaDgvPacas.Enabled = False
                CkLeersaco.Checked = False
                LbStatus.Text = "CAPTURA AUTOMATICA DESACTIVADA"
                BtActivarPrensa.Text = "Activar Lectura de Prensa"
                SpCapturaAutomatica.Close()
            End If
        Else
            MessageBox.Show("No se ha configurado el puerto serial para captura automatica, Contactar al Administrador del sistema para resolverlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub TiActualizaDgvPacas__Tick(sender As Object, e As EventArgs) Handles TiActualizaDgvPacas.Tick
        Consultar()
    End Sub
    Sub ReceiveSerialData_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SpCapturaAutomatica.DataReceived
        'While bandera = True
        Dim Resultado As String = ""
        Dim Bruto
        Dim TipoFlete As String = ""
        Dim returnStr As String = ""
        Dim FechaActualizacion As DateTime
        Dim numeroRecorrido As Integer = 0
        Dim az As String     'utilizada para almacenar los datos que se reciben por el puerto
        Dim sib As Integer    ' sera utilizada como contador
        Dim msn(1000) As String
        Try
            az = SpCapturaAutomatica.ReadLine.Trim

            msn(sib) = az

            'returnStr += msn(sib) + " "
            returnStr += msn(sib) + vbCrLf + vbCrLf

            sib = sib + 1
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
        End Try
        Try
            If IndicadorPesoBruto <> "" Then
                If returnStr.Contains(IndicadorPesoBruto) And TextoIzq = False Then
                    Resultado = returnStr.Substring(returnStr.IndexOf(Trim(IndicadorPesoBruto)), returnStr.Length - returnStr.IndexOf(Trim(IndicadorPesoBruto)))
                    Bruto = LTrim(Resultado.Substring(PosicionPesoBruto, CaracterPesoBruto))
                    TbKilos.Text = Bruto
                    FechaActualizacion = Now
                    ActualizaPesoModuloAutomatico(Bruto, FechaActualizacion)
                ElseIf returnStr.Contains(IndicadorPesoBruto) And TextoIzq = True Then
                    Dim largo As Integer = returnStr.Length - returnStr.IndexOf(Trim(IndicadorPesoBruto))
                    Dim inicio As Integer = returnStr.IndexOf(Trim(IndicadorPesoBruto)) - CaracterPesoBruto
                    Resultado = returnStr.Substring(inicio, largo)
                    Bruto = Trim(Resultado.Substring(inicio, largo))
                    TbKilos.Text = Bruto
                    ActualizaPesoModuloAutomatico(Bruto, FechaActualizacion)
                End If
            Else
                MessageBox.Show("Campo indicador de peso vacio, continuar con captura manual." & vbCrLf & " Si el problema continuna contactar al Administrador del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        returnStr = ""
    End Sub
    Private Sub ActualizaPesoModuloAutomatico(ByVal Bruto As Double, ByVal FechaActualizacion As DateTime)
        If TbIdOrdenTrabajo.Text <> "" Then
            If TbKilos.Text <> "" And TbFolioCIA.Text <> "" Then
                ConsultaUltimaSecuencia()
                If TbFolioCIA.Text <> EtiquetaEscaneada Then
                    Dim opc = MessageBox.Show("El folio no coincide, ¿Desea reemplazarlo por el consecutivo" + " " + CStr(EtiquetaEscaneada) + " " + "siguiente?", "Aviso", MessageBoxButtons.YesNo)
                    If opc = DialogResult.Yes Then
                        If ConsultarPacaExistente(EtiquetaEscaneada, CbPlantaOrigen.SelectedValue) = 1 Then
                            'MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                            'TbKilos.Text = ""
                            'ActualizarUltimaEtiqueta()
                            Dim EntidadProduccion As New Capa_Entidad.Produccion
                            Dim NegocioProduccion As New Capa_Negocio.Produccion
                            EntidadProduccion.IdProduccionDetalle = IIf(IdProduccionDetalle = 0, 0, IdProduccionDetalle)
                            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
                            EntidadProduccion.FolioCIA = EtiquetaEscaneada
                            EntidadProduccion.Tipo = CbTipoProducto.Text
                            EntidadProduccion.Kilos = Bruto
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
                            'Consultar()
                            TbFolioCIA.Text = ""
                            TbKilos.Text = ""
                            ConsultaUltimaSecuencia()
                            TbFolioCIA.Text = UltimaSecuencia
                            TbFolioInicial.Text = UltimaSecuencia
                            TbKilos.Select()
                        Else
                            'TbFolioCIA.Text = EtiquetaEscaneada
                            Dim EntidadProduccion As New Capa_Entidad.Produccion
                            Dim NegocioProduccion As New Capa_Negocio.Produccion
                            EntidadProduccion.IdProduccionDetalle = 0
                            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
                            EntidadProduccion.FolioCIA = EtiquetaEscaneada
                            EntidadProduccion.Tipo = CbTipoProducto.Text
                            EntidadProduccion.Kilos = Bruto
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
                            'Consultar()
                            TbFolioCIA.Text = ""
                            TbKilos.Text = ""
                            ConsultaUltimaSecuencia()
                            TbFolioInicial.Text = UltimaSecuencia
                            TbFolioCIA.Text = UltimaSecuencia
                            TbKilos.Select()
                        End If
                    ElseIf ConsultarPacaExistente(TbFolioCIA.Text, CbPlantaOrigen.SelectedValue) = 1 Then
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
                        EntidadProduccion.Kilos = Bruto
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
                        'Consultar()
                        TbFolioCIA.Text = ""
                        TbKilos.Text = ""
                        ConsultaUltimaSecuencia()
                        TbFolioCIA.Text = UltimaSecuencia
                        TbFolioInicial.Text = UltimaSecuencia
                        TbKilos.Select()
                    Else
                        Dim EntidadProduccion As New Capa_Entidad.Produccion
                        Dim NegocioProduccion As New Capa_Negocio.Produccion
                        EntidadProduccion.IdProduccionDetalle = 0
                        EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                        EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
                        EntidadProduccion.FolioCIA = TbFolioCIA.Text
                        EntidadProduccion.Tipo = CbTipoProducto.Text
                        EntidadProduccion.Kilos = Bruto
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
                        'TbFolioInicial.Text = Val(TbFolioCIA.Text) + 1
                        'UpsertFolioInicial(TbFolioCIA.Text)
                        'ActualizarUltimaEtiqueta()
                        'Consultar()
                        TbFolioCIA.Text = ""
                        TbKilos.Text = ""
                        ConsultaUltimaSecuencia()
                        'TbFolioCIA.Text = EtiquetaEscaneada
                        TbFolioInicial.Text = UltimaSecuencia
                        TbFolioCIA.Text = UltimaSecuencia
                        TbKilos.Select()

                    End If
                ElseIf ConsultarPacaExistente(TbFolioCIA.Text, CbPlantaOrigen.SelectedValue) = 1 Then
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
                    EntidadProduccion.Kilos = Bruto
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
                    'Consultar()
                    TbFolioCIA.Text = ""
                    TbKilos.Text = ""
                    ConsultaUltimaSecuencia()
                    TbFolioCIA.Text = EtiquetaEscaneada
                    TbKilos.Select()

                Else

                    Dim EntidadProduccion As New Capa_Entidad.Produccion
                    Dim NegocioProduccion As New Capa_Negocio.Produccion
                    EntidadProduccion.IdProduccionDetalle = 0
                    EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
                    EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
                    EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
                    EntidadProduccion.FolioCIA = TbFolioCIA.Text
                    EntidadProduccion.Tipo = CbTipoProducto.Text
                    EntidadProduccion.Kilos = Bruto
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
                    'TbFolioInicial.Text = Val(TbFolioCIA.Text) + 1
                    'UpsertFolioInicial(TbFolioCIA.Text)
                    'ActualizarUltimaEtiqueta()
                    'Consultar()
                    TbFolioCIA.Text = ""
                    TbKilos.Text = ""
                    ConsultaUltimaSecuencia()
                    'TbFolioCIA.Text = EtiquetaEscaneada
                    TbFolioInicial.Text = UltimaSecuencia
                    TbFolioCIA.Text = UltimaSecuencia
                    TbKilos.Select()
                End If
                'If 

                '    Exit Sub
                'Else

                'End If
            Else
                MsgBox("Verificar peso y folio", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("Por favor, abrir una produccion", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If
        TbTotalPacas.Text = DgvPacas.Rows.Count
        TbTotalKilos.Text = SumaKilos()
        GuardarProduccion()
    End Sub
    Private Sub TbIdOrdenTrabajo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdOrdenTrabajo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TbFolioInicial.Focus()
        End If
    End Sub
    Private Sub RbAutomatico_CheckedChanged(sender As Object, e As EventArgs)
        TbFolioCIA.Enabled = False
        TbKilos.Enabled = False
        TbFolioInicial.Enabled = True
    End Sub
    Private Sub RbManual_CheckedChanged(sender As Object, e As EventArgs)
        TbFolioCIA.Enabled = True
        TbKilos.Enabled = True
        TbFolioInicial.Enabled = False
    End Sub

    Private Sub CkLeersaco_CheckedChanged(sender As Object, e As EventArgs) Handles CkLeersaco.CheckedChanged
        ActualizaEstatusLeerEtiqueta()
    End Sub
    Private Sub ActualizaEstatusLeerEtiqueta()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        EntidadProduccion.LeerEtiqueta = CkLeersaco.CheckState
        NegocioProduccion.UpsertLeerEtiqueta(EntidadProduccion)
    End Sub

    'Private Sub DgvPacas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacas.CellContentClick
    '    For i As Integer = 0 To DgvPacas.Rows.Count() - 1
    '        Dim c As Boolean
    '        c = DgvPacas.Rows(i).Cells(0).Value
    '        ' if the checkbox cell is checked
    '        If c = True Then
    '            c = False
    '            ' if not
    '        Else
    '            c = True
    '        End If
    '    Next
    'End Sub

    Private Sub BtEliminarPacas_Click(sender As Object, e As EventArgs) Handles BtEliminarPacas.Click
        Dim opc As DialogResult = MsgBox("¿Eliminar pacas seleccionadas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar Pacas Seleccionadas")
        If opc = DialogResult.Yes Then
            Try
                For i As Integer = 0 To DgvPacas.Rows.Count() - 1
                    Dim c As Boolean = DgvPacas.Rows(i).Cells(0).Value

                    If c = True Then
                        GeneraRegistroBitacora(Me.Text.Clone.ToString, BtEliminarPacas.Text, DgvPacas.Rows(i).Cells("FolioCIA").Value, DgvPacas.Rows(i).Cells("Kilos").Value & " KGs DEL PRODUCTOR " & TbNombreProductor.Text & " CON LA ORDEN No " & TbIdOrdenTrabajo.Text & " EN PLANTA " & CbPlantaOrigen.Text)
                        EliminaPaca(DgvPacas.Rows(i).Cells("FolioCIA").Value, TbIdOrdenTrabajo.Text)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex)
            Finally
                Consultar()
                TbTotalPacas.Text = DgvPacas.Rows.Count
                TbTotalKilos.Text = SumaKilos()
                GuardarProduccion()
            End Try
        End If
    End Sub

    Private Sub TbFolioInicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbFolioInicial.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtAbrirProduccion.Focus()
        End If
    End Sub
    Private Sub UpsertFolioInicial(ByVal Folio As String)
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        EntidadProduccion.FolioInicial = Val(Folio)
        NegocioProduccion.UpsertFolioInicial(EntidadProduccion)
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
        If ConsultarPacaExistente(TbFolioCIA.Text, CBPlantaDestino.SelectedValue) = 1 Then
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
    Private Sub LeerArchivoConfiguracion()
        If IO.File.Exists(Ruta & archivo) Then
            ObtenerArchivoConfiguracion()
        Else
            MessageBox.Show("No se ha configurado el puerto serial para captura automatica, Contactar al Administrador del sistema para resolverlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ObtenerArchivoConfiguracion()
        Dim leer As New IO.StreamReader(Ruta & archivo)
        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadToEnd()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim ArregloCadena() As String = Split(linea, vbCrLf)
                PesoMinimoPaca = ObtenerValor(ArregloCadena(21))
                IndicadorPesoBruto = ObtenerValor(ArregloCadena(22))
                PosicionPesoBruto = ObtenerValor(ArregloCadena(23))
                CaracterPesoBruto = ObtenerValor(ArregloCadena(24))
                IndicadorTara = ObtenerValor(ArregloCadena(25))
                PosicionTara = ObtenerValor(ArregloCadena(26))
                CaracterTara = ObtenerValor(ArregloCadena(27))
                IndicadorNeto = ObtenerValor(ArregloCadena(28))
                PosicionNeto = ObtenerValor(ArregloCadena(29))
                CaracterNeto = ObtenerValor(ArregloCadena(30))
                TextoIzq = ObtenerValor(ArregloCadena(31))
                CbPuertosSeriales.Text = ObtenerValor(ArregloCadena(32))
                BaudRate = ObtenerValor(ArregloCadena(33))
                DataBits = ObtenerValor(ArregloCadena(34))
                StopBits = ObtenerValor(ArregloCadena(35))
                Parity = ObtenerValor(ArregloCadena(36))
                HandShake = ObtenerValor(ArregloCadena(37))
                DtrEnable = ObtenerValor(ArregloCadena(38))
                ReadBufferSize = ObtenerValor(ArregloCadena(39))
                WriteBufferSize = ObtenerValor(ArregloCadena(40))
                ReceivedBytesThreshold = ObtenerValor(ArregloCadena(41))
                CbPlantaOrigen.SelectedValue = ObtenerValor(ArregloCadena(42))
            End While
            leer.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Function ObtenerValor(ByVal cadena As String)
        Dim Resultado As String
        Dim ArregloCadena() As String = Split(cadena, "=")
        Resultado = ArregloCadena(1)
        Return Resultado
    End Function
    Private Sub ConsultaParametros()
        'Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        'Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        'Dim Tabla As New DataTable
        'EntidadConfiguracionParametros.IdConfiguracion = 0
        'EntidadConfiguracionParametros.DireccionIP = GetNameHost()
        'EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBasica
        'NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        'Tabla = EntidadConfiguracionParametros.TablaConsulta
        'If Tabla.Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'CbPuertosSeriales.Text = Tabla.Rows(0).Item("NombrePuerto")
        'PesoMinimoPaca = Tabla.Rows(0).Item("PesoMinimoPaca")
        'IndicadorPesoBruto = Tabla.Rows(0).Item("IndicadorPacasBruto")
        'IndicadorTara = Tabla.Rows(0).Item("IndicadorPacasTara")
        'IndicadorNeto = Tabla.Rows(0).Item("IndicadorPacasNeto")
        'PosicionPesoBruto = Tabla.Rows(0).Item("PacasPosicionBruto")
        'PosicionTara = Tabla.Rows(0).Item("PacasPosicionTara")
        'PosicionNeto = Tabla.Rows(0).Item("PacasPosicionNeto")
        'CaracterPesoBruto = Tabla.Rows(0).Item("PacasCaracterBruto")
        'CaracterTara = Tabla.Rows(0).Item("PacasCaracterTara")
        'CaracterNeto = Tabla.Rows(0).Item("PacasCaracterNeto")
    End Sub
    Private Function GetNameHost()
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = Dns.GetHostName()
        strIPAddress = Dns.Resolve(strHostName).AddressList(0).ToString()
        Return strIPAddress
    End Function
    Private Sub BtActualizarFolio_Click(sender As Object, e As EventArgs) Handles BtActualizarFolio.Click
        UpsertFolioInicial(TbFolioInicial.Text)
        TbFolioCIA.Text = TbFolioInicial.Text
    End Sub
End Class