Imports Capa_Operacion.Configuracion
Imports System.IO
Public Class ContratosAlgodonCompradores
    Implements IForm1
    Dim IdComprador As Integer
    Dim TablaUnidadPeso As New DataTable
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\conf\"
    Dim archivo As String = "confemail.ini"
    Dim email, password, hostsmtp As String
    Dim puertosmtp As Integer
    Dim ConexionSSL As Boolean
    Dim rutadoc As String
    Private Sub ContratosAlgodonCompradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        'CastigosMatExt()
        Limpiar()
        ConsultaContratos()
        ObtenerArchivoConfiguracion()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If TbComprador.Text <> "" And TbPacas.Text <> "" And CbUnidadPeso.Text <> "" And TbPrecioQuintal.Text <> "" And TbPuntos.Text <> "" And CbEstatus.Text <> "" And CbModalidad.Text <> "" And TbSM.Text <> "" Then
            Guardar()
        End If
    End Sub
    Private Sub ObtenerArchivoConfiguracion()
        email = ""
        password = ""
        hostsmtp = ""
        puertosmtp = 0
        ConexionSSL = False
        Try
            If File.Exists(Ruta & archivo) Then
                Dim leer As New StreamReader(Ruta & archivo)
                While leer.Peek <> -1
                    Dim linea As String = leer.ReadToEnd()
                    If String.IsNullOrEmpty(linea) Then
                        Continue While
                    End If
                    Dim arreglocadena() As String = Split(linea, vbCrLf)
                    email = ObtenerValor(arreglocadena(0))
                    password = ObtenerValor(arreglocadena(1))
                    hostsmtp = ObtenerValor(arreglocadena(2))
                    puertosmtp = ObtenerValor(arreglocadena(3))
                    ConexionSSL = ObtenerValor(arreglocadena(4))
                End While
                leer.Close()
            Else
                MsgBox("No se ha configurado un correo, entrar al apartado Utilerias en la opcion Parametros para envio de Correo y configurar los parametros requeridos.", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function ObtenerValor(ByVal cadena As String)
        Dim Resultado As String
        Dim ArregloCadena() As String = Split(cadena, "=")
        Resultado = ArregloCadena(1)
        Return Resultado
    End Function
    'Private Sub CastigosMatExt()
    '    Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
    '    Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
    '    Dim Tabla As New DataTable
    '    EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaCastigoMatExtVenta
    '    NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
    '    Tabla = EntidadContratosAlgodonCompradores.TablaConsulta

    '    CbModoBark.DataSource = Tabla.Rows(0).Item(0).ToString
    '    CbModoBark.ValueMember = "IdExmatVenta"
    '    CbModoBark.DisplayMember = "NombreMateria"
    '    CbModoBark.SelectedValue = 1

    'NuBarkLevel2.SelectedValue = Tabla.Rows(0).Item("Nivel2").ToString
    'NuPrepLevel2.SelectedValue = Tabla.Rows(1).Item("Nivel2").ToString
    'NuOtherLevel2.SelectedValue = Tabla.Rows(2).Item("Nivel2").ToString
    'NuPlasticLevel2.SelectedValue = Tabla.Rows(3).Item("Nivel2").ToString
    'End Sub
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
            EntidadContratosAlgodonCompradores.IdParametroContrato = 0
            EntidadContratosAlgodonCompradores.CheckMicros = ChMicros.Checked
            EntidadContratosAlgodonCompradores.IdModoMicros = CbModoMicros.SelectedValue
            EntidadContratosAlgodonCompradores.CheckLargo = ChLargoFibra.Checked
            EntidadContratosAlgodonCompradores.IdModoLargoFibra = CbModoLargoFibra.SelectedValue
            EntidadContratosAlgodonCompradores.CheckResistencia = ChResistenciaFibra.Checked
            EntidadContratosAlgodonCompradores.IdModoResistencia = CbModoResistenciaFibra.SelectedValue
            EntidadContratosAlgodonCompradores.CheckUniformidad = ChUniformidad.Checked
            EntidadContratosAlgodonCompradores.IdModoUniformidad = CbModoUniformidad.SelectedValue
            EntidadContratosAlgodonCompradores.CheckBark = ChBark.Checked
            EntidadContratosAlgodonCompradores.IdModoBark = CbModoBark.SelectedValue
            EntidadContratosAlgodonCompradores.CheckBarkLevel1 = ChBarkLevel1.Checked
            EntidadContratosAlgodonCompradores.CheckBarkLevel2 = ChBarkLevel2.Checked
            EntidadContratosAlgodonCompradores.CheckPrep = ChPrep.Checked
            EntidadContratosAlgodonCompradores.IdModoPrep = CbModoPrep.SelectedValue
            EntidadContratosAlgodonCompradores.CheckPrepLevel1 = ChPrepLevel1.Checked
            EntidadContratosAlgodonCompradores.CheckPrepLevel2 = ChPrepLevel2.Checked
            EntidadContratosAlgodonCompradores.CheckOther = ChOther.Checked
            EntidadContratosAlgodonCompradores.IdModoOther = CbModoOther.SelectedValue
            EntidadContratosAlgodonCompradores.CheckOtherLevel1 = ChOtherLevel1.Checked
            EntidadContratosAlgodonCompradores.CheckOtherLevel2 = ChOtherLevel2.Checked
            EntidadContratosAlgodonCompradores.CheckPlastic = ChPlastic.Checked
            EntidadContratosAlgodonCompradores.IdModoPlastic = CbModoPlastic.SelectedValue
            EntidadContratosAlgodonCompradores.CheckPlasticLevel1 = ChPlasticLevel1.Checked
            EntidadContratosAlgodonCompradores.CheckPlasticLevel2 = ChPlasticLevel2.Checked
            EntidadContratosAlgodonCompradores.EstatusPesoNeto = CkTara.Checked
            EntidadContratosAlgodonCompradores.KilosNeto = NuPesoTara.Value
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
            Try
                EntidadContratosAlgodonCompradores.IdExterno = CbModalidad.SelectedValue
                EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaDiferenciales
                NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
                Tabla = EntidadContratosAlgodonCompradores.TablaConsulta
                TbSM.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(0).Item("Diferencial")))
                TbMP.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(1).Item("Diferencial")))
                TbM.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(2).Item("Diferencial")))
                TbSLMP.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(3).Item("Diferencial")))
                TbSLM.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(4).Item("Diferencial")))
                TbLMP.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(5).Item("Diferencial")))
                TbLM.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(6).Item("Diferencial")))
                TbSGO.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(7).Item("Diferencial")))
                TbGO.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(8).Item("Diferencial")))
                TbO.Text = (TbPrecioQuintal.Text - CDbl(Val(TbPuntos.Text) + Tabla.Rows(9).Item("Diferencial")))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

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
        dtBARK.Columns.Add("Descripcion")
        Dim drBark As DataRow
        drBark = dtBARK.NewRow()
        drbARK("Id") = "1"
        drbARK("Descripcion") = "Bark"
        dtBARK.Rows.Add(drbARK)
        CbModoBark.DataSource = dtBARK
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
        CkTara.Checked = False
        NuPesoTara.Value = 0
        CbModoLargoFibra.SelectedIndex = 0
        CbModoMicros.SelectedIndex = 0
        CbModoResistenciaFibra.SelectedIndex = 0
        CbModoUniformidad.SelectedIndex = 0
        CbModoBark.SelectedIndex = 0
        CbModoPrep.SelectedIndex = 0
        CbModoOther.SelectedIndex = 0
        CbModoPlastic.SelectedIndex = 0
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
    Private Sub DgvContratoAlgodon_DoubleClick(sender As Object, e As EventArgs) Handles DgvContratoAlgodon.DoubleClick
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim TablaDetalle As New DataTable
        Dim TablaParametros As New DataTable
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

        EntidadContratosAlgodonCompradores.IdContratoAlgodon = DgvContratoAlgodon.Rows(index).Cells("IdContratoAlgodon").Value
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
            CkTara.Checked = TablaParametros.Rows(0).Item("EstatusPesoNeto")
            NuPesoTara.Value = TablaParametros.Rows(0).Item("KilosNeto")
        End If
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
    Private Sub EnviarEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarEmailToolStripMenuItem.Click
        Dim Destinatario As String = ""
        Dim asunto As String = ""
        Dim Mensaje As String = ""
        If TbIdContratoAlgodon.Text <> "" Then
            asunto = "Contrato de pacas con el ID " & TbIdContratoAlgodon.Text & " a nombre de " & "" & "."
            'Mensaje = "Se realizo compra por un total de " & TbPacas.Text & " Pacas con un precio de " & TbPrecioQuintal.Text & " Quintales." & vbCrLf & "Enviado desde SIA."
            Mensaje = "Se confirma la siguiente operacion ciclo PV" & TbTemporada.Text & "<br><br>Comprador.- " & TbComprador.Text & "<br>Ref. No.- " & TbIdContratoAlgodon.Text & "<br>Pacas.- " & TbPacas.Text & "<br>Precio Base.- " & IIf(Val(TbPrecioQuintal.Text) = 0, "On Call", Val(TbPrecioQuintal.Text)) & "<br>Descuento.- " & TbPuntos.Text & "<br>Precio base neto.- " & Val(TbPrecioQuintal.Text) - Val(TbPuntos.Text) & "<br><br><br><br>Enviado desde SIA."
            Destinatario = InputBox("Para:", "Complete la direccion de correo del destinatario.")
            enviarCorreo(email, password, Mensaje, asunto, Destinatario, puertosmtp, hostsmtp, ConexionSSL)
        Else
            MsgBox("Seleccione un contrato para enviar por email.", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CkTara_CheckedChanged(sender As Object, e As EventArgs) Handles CkTara.CheckedChanged
        If CkTara.Checked = True Then
            NuPesoTara.Enabled = True
        Else
            NuPesoTara.Enabled = False
            NuPesoTara.Value = 0
        End If

    End Sub
End Class