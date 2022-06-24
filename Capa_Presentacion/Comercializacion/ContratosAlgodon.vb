Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.IO
Public Class ContratosAlgodon
    Public IdCliente As Integer
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\conf\"
    Dim archivo As String = "confemail.ini"
    Dim email, password, hostsmtp As String
    Dim puertosmtp As Integer
    Dim ConexionSSL As Boolean
    Dim rutadoc As String
    Private Sub ContratosAlgodon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        Limpiar()
        ConsultaContratos()
        ObtenerArchivoConfiguracion()
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
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
        HabilitarBotones()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Try
            EntidadContratosAlgodon.Guarda = Guardar.GuardarEncabezado
            EntidadContratosAlgodon.IdContratoAlgodon = IIf(TbIdContratoAlgodon.Text = "", 0, TbIdContratoAlgodon.Text)
            EntidadContratosAlgodon.IdProductor = IdCliente
            EntidadContratosAlgodon.Pacas = Val(TbPacas.Text)
            EntidadContratosAlgodon.PacasCompradas = Val(TbPacasCompradas.Text)
            EntidadContratosAlgodon.PacasDisponibles = Val(TbPacasDisponibles.Text)
            EntidadContratosAlgodon.SuperficieComprometida = Val(TbSuperficie.Text)
            EntidadContratosAlgodon.Lotes = TbLotes.Text
            EntidadContratosAlgodon.IdContratoVta = Val(tbidcontratovta.Text)
            EntidadContratosAlgodon.DescripcionVta = tbdescripcionvta.Text
            EntidadContratosAlgodon.PrecioQuintal = Val(TbPrecioQuintal.Text)
            EntidadContratosAlgodon.Puntos = Val(TbPuntos.Text)
            EntidadContratosAlgodon.FechaLiquidacion = DtpFechaLiquidacion.Value
            EntidadContratosAlgodon.Presidente = TbPresidente.Text
            EntidadContratosAlgodon.IdModalidadCompra = CbModalidad.SelectedValue
            EntidadContratosAlgodon.Temporada = Val(TbTemporada.Text)
            EntidadContratosAlgodon.PrecioSM = Val(TbSM.Text)
            EntidadContratosAlgodon.PrecioMP = Val(TbMP.Text)
            EntidadContratosAlgodon.PrecioM = Val(TbM.Text)
            EntidadContratosAlgodon.PrecioSLMP = Val(TbSLMP.Text)
            EntidadContratosAlgodon.PrecioSLM = Val(TbSLM.Text)
            EntidadContratosAlgodon.PrecioLMP = Val(TbLMP.Text)
            EntidadContratosAlgodon.PrecioLM = Val(TbLM.Text)
            EntidadContratosAlgodon.PrecioSGO = Val(TbSGO.Text)
            EntidadContratosAlgodon.PrecioGO = Val(TbGO.Text)
            EntidadContratosAlgodon.PrecioO = Val(TbO.Text)
            EntidadContratosAlgodon.IdEstatus = CbEstatus.SelectedValue
            EntidadContratosAlgodon.IdUsuarioCreacion = 1
            EntidadContratosAlgodon.FechaCreacion = Now
            EntidadContratosAlgodon.IdUsuarioActualizacion = 1
            EntidadContratosAlgodon.FechaActualizacion = Now
            EntidadContratosAlgodon.TablaConsulta = _Tabla
            NegocioContratosAlgodon.Guardar(EntidadContratosAlgodon)
            TbIdContratoAlgodon.Text = EntidadContratosAlgodon.IdContratoAlgodon
            GuardarDetalles()
            MsgBox("Realizado Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ConsultaContratos()
            HabilitarBotones()
            GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdContratoAlgodon.Text, "SE CREO/ACTUALIZO EL CONTRATO " & TbIdContratoAlgodon.Text & " " & TbProductor.Text & " CON LA CANTIDAD DE " & TbPacas.Text & " PACAS DE CONTRATO, " & TbPacasDisponibles.Text & " DISPONIBLES, " & TbPacasCompradas.Text & "COMPRADAS, MODALIDAD DE COMPRA" & CbModalidad.Text & ", PRECIO DE CONTRATO " & TbPrecioQuintal.Text & ".")
        End Try
    End Sub
    Private Sub GuardarDetalles()
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Try
            EntidadContratosAlgodon.Guarda = Guardar.GuardarDetalle
            EntidadContratosAlgodon.IdParametroContrato = 0
            EntidadContratosAlgodon.IdContratoAlgodon = IIf(TbIdContratoAlgodon.Text = "", 0, TbIdContratoAlgodon.Text)
            EntidadContratosAlgodon.CheckMicros = ChMicros.Checked
            EntidadContratosAlgodon.IdModoMicros = CbModoMicros.SelectedValue
            EntidadContratosAlgodon.CheckLargo = ChLargoFibra.Checked
            EntidadContratosAlgodon.IdModoLargoFibra = CbModoLargoFibra.SelectedValue
            EntidadContratosAlgodon.CheckResistencia = ChResistenciaFibra.Checked
            EntidadContratosAlgodon.IdModoResistencia = CbModoResistenciaFibra.SelectedValue
            EntidadContratosAlgodon.CheckUniformidad = ChUniformidad.Checked
            EntidadContratosAlgodon.IdModoUniformidad = CbModoUniformidad.SelectedValue
            EntidadContratosAlgodon.CheckBark = ChBark.Checked
            EntidadContratosAlgodon.IdModoBark = CbModoBark.SelectedValue
            EntidadContratosAlgodon.CheckBarkLevel1 = ChBarkLevel1.Checked
            EntidadContratosAlgodon.CheckBarkLevel2 = ChBarkLevel2.Checked
            EntidadContratosAlgodon.CheckPrep = ChPrep.Checked
            EntidadContratosAlgodon.IdModoPrep = CbModoPrep.SelectedValue
            EntidadContratosAlgodon.CheckPrepLevel1 = ChPrepLevel1.Checked
            EntidadContratosAlgodon.CheckPrepLevel2 = ChPrepLevel2.Checked
            EntidadContratosAlgodon.CheckOther = ChOther.Checked
            EntidadContratosAlgodon.IdModoOther = CbModoOther.SelectedValue
            EntidadContratosAlgodon.CheckOtherLevel1 = ChOtherLevel1.Checked
            EntidadContratosAlgodon.CheckOtherLevel2 = ChOtherLevel2.Checked
            EntidadContratosAlgodon.CheckPlastic = ChPlastic.Checked
            EntidadContratosAlgodon.IdModoPlastic = CbModoPlastic.SelectedValue
            EntidadContratosAlgodon.CheckPlasticLevel1 = ChPlasticLevel1.Checked
            EntidadContratosAlgodon.CheckPlasticLevel2 = ChPlasticLevel2.Checked
            NegocioContratosAlgodon.Guardar(EntidadContratosAlgodon)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

        '------------------------COMBO MICROS VENTA
        Dim Tabla2 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaMicrosCompraCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla2 = EntidadContratosAlgodon.TablaConsulta
        CbModoMicros.DataSource = Tabla2
        CbModoMicros.ValueMember = "IdModoEncabezado"
        CbModoMicros.DisplayMember = "Descripcion"
        CbModoMicros.SelectedIndex = 0
        '------------------------COMBO LARGO FIBRA VENTA
        Dim Tabla3 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaLargoFibraCompraCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla3 = EntidadContratosAlgodon.TablaConsulta
        CbModoLargoFibra.DataSource = Tabla3
        CbModoLargoFibra.ValueMember = "IdModoEncabezado"
        CbModoLargoFibra.DisplayMember = "Descripcion"
        CbModoLargoFibra.SelectedIndex = 0
        '------------------------COMBO RESISTENCIA VENTA
        Dim Tabla4 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaResistenciaCompraCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla4 = EntidadContratosAlgodon.TablaConsulta
        CbModoResistenciaFibra.DataSource = Tabla4
        CbModoResistenciaFibra.ValueMember = "IdModoEncabezado"
        CbModoResistenciaFibra.DisplayMember = "Descripcion"
        CbModoResistenciaFibra.SelectedIndex = 0
        '------------------------COMBO UNIFORMIDAD VENTA
        Dim Tabla5 As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaUniformidadCompraCmb
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla5 = EntidadContratosAlgodon.TablaConsulta
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
    Private Sub ConsultaContratos()
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim Tabla As New DataTable
        Try
            EntidadContratosAlgodon.Consulta = Consulta.ConsultaBasica
            NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
            DgvContratoAlgodon.DataSource = EntidadContratosAlgodon.TablaConsulta
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()
        TbIdContratoAlgodon.Text = ""
        TbPacasCompradas.Text = ""
        TbPacasDisponibles.Text = ""
        TbProductor.Text = ""
        TbAsociacion.Text = ""
        TbPacas.Text = ""
        TbSuperficie.Text = ""
        TbLotes.Text = ""
        TbPrecioQuintal.Text = ""
        TbPrecioQuintal.Enabled = True
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
        tbidcontratovta.Clear()
        tbdescripcionvta.Clear()
        ChBark.Checked = False
        ChPrep.Checked = False
        ChOther.Checked = False
        ChPlastic.Checked = False
        ChBarkLevel1.Checked = False
        ChBarkLevel2.Checked = False
        ChPrepLevel1.Checked = False
        ChPrepLevel2.Checked = False
        ChOtherLevel1.Checked = False
        ChOtherLevel2.Checked = False
        ChPlasticLevel1.Checked = False
        ChPlasticLevel2.Checked = False
        ChMicros.Checked = True
        ChResistenciaFibra.Checked = True
        ChLargoFibra.Checked = True
        ChUniformidad.Checked = True
        CbModoLargoFibra.SelectedIndex = 0
        CbModoMicros.SelectedIndex = 0
        CbModoResistenciaFibra.SelectedIndex = 0
        CbModoUniformidad.SelectedIndex = 0
        CbModoBark.SelectedIndex = 0
        CbModoPrep.SelectedIndex = 0
        CbModoOther.SelectedIndex = 0
        CbModoPlastic.SelectedIndex = 0
    End Sub
    Private Sub BtnBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProductor.Click
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        ConsultaProductores.ShowDialog()
        IdCliente = _Id
        TbProductor.Text = _Nombre
        TbPacas.Select()
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
        Else
            MsgBox("Ingrese precio de quintal o los puntos")
        End If
    End Sub
    Private Sub DgvContratoAlgodon_DoubleClick(sender As Object, e As EventArgs) Handles DgvContratoAlgodon.DoubleClick
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim TablaDetalle As New DataTable
        Dim TablaParametros As New DataTable
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
        TbPacasCompradas.Text = TablaDetalle.Rows(0).Item("PacasCompradas")
        TbPacasDisponibles.Text = TablaDetalle.Rows(0).Item("PacasDisponibles")
        TbSuperficie.Text = TablaDetalle.Rows(0).Item("SuperficieComprometida")
        TbLotes.Text = TablaDetalle.Rows(0).Item("Lotes")
        tbidcontratovta.Text = TablaDetalle.Rows(0).Item("IdContratoVta")
        tbdescripcionvta.Text = TablaDetalle.Rows(0).Item("DescripcionVta")
        CbEstatus.SelectedValue = TablaDetalle.Rows(0).Item("IdEstatus")
        TbPrecioQuintal.Text = TablaDetalle.Rows(0).Item("PrecioQuintal")
        If Val(TbPrecioQuintal.Text) = 0 Then
            TbPrecioQuintal.Enabled = True
        Else
            TbPrecioQuintal.Enabled = False
        End If
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

        EntidadContratosAlgodon.IdContratoAlgodon = DgvContratoAlgodon.Rows(index).Cells("IdContratoAlgodon").Value
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaParametrosContratoCompra
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        TablaParametros = EntidadContratosAlgodon.TablaConsulta
        If TablaParametros.Rows.Count > 0 Then
            ChMicros.Checked = TablaParametros.Rows(0).Item("CheckMicros")
            CbModoMicros.SelectedValue = TablaParametros.Rows(0).Item("IdModoMicros")
            ChLargoFibra.Checked = TablaParametros.Rows(0).Item("CheckLargo")
            CbModoLargoFibra.SelectedValue = TablaParametros.Rows(0).Item("IdModoLargoFibra")
            ChResistenciaFibra.Checked = TablaParametros.Rows(0).Item("CheckResistencia")
            CbModoResistenciaFibra.SelectedValue = TablaParametros.Rows(0).Item("IdModoResistencia")
            ChUniformidad.Checked = TablaParametros.Rows(0).Item("CheckUniformidad")
            CbModoUniformidad.SelectedValue = TablaParametros.Rows(0).Item("IdModoUniformidad")
            'ChBark.Checked = TablaParametros.Rows(0).Item("CheckBark")
            'CbModoBark.SelectedValue = TablaParametros.Rows(0).Item("IdModoBark")
            'ChBarkLevel1.Checked = TablaParametros.Rows(0).Item("CheckBarkLevel1")
            'ChBarkLevel2.Checked = TablaParametros.Rows(0).Item("CheckBarkLevel2")
            'ChPrep.Checked = TablaParametros.Rows(0).Item("CheckPrep")
            'CbModoPrep.SelectedValue = TablaParametros.Rows(0).Item("IdModoPrep")
            'ChPrepLevel1.Checked = TablaParametros.Rows(0).Item("CheckPrepLevel1")
            'ChPrepLevel2.Checked = TablaParametros.Rows(0).Item("CheckPrepLevel2")
            'ChOther.Checked = TablaParametros.Rows(0).Item("CheckOther")
            'CbModoOther.SelectedValue = TablaParametros.Rows(0).Item("IdModoOther")
            'ChOtherLevel1.Checked = TablaParametros.Rows(0).Item("CheckOtherLevel1")
            'ChOtherLevel2.Checked = TablaParametros.Rows(0).Item("CheckOtherLevel2")
            'ChPlastic.Checked = TablaParametros.Rows(0).Item("CheckPlastic")
            'CbModoPlastic.SelectedValue = TablaParametros.Rows(0).Item("IdModoPlastic")
            'ChPlasticLevel1.Checked = TablaParametros.Rows(0).Item("CheckPlasticLevel1")
            'ChPlasticLevel2.Checked = TablaParametros.Rows(0).Item("CheckPlasticLevel2")
        End If

        InhabilitarBotones()
    End Sub
    Private Sub HabilitarBotones()
        'BtConsultaLotes.Enabled = True
        'btconsultacontratoventa.Enabled = True
        If Val(TbPrecioQuintal.Text) > 0 Then
            TbPrecioQuintal.Enabled = False
        Else
            TbPrecioQuintal.Enabled = True
        End If
    End Sub
    Private Sub InhabilitarBotones()
        'BtConsultaLotes.Enabled = False
        'btconsultacontratoventa.Enabled = False
    End Sub
    Private Sub SoloNumerosDecimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbPacas.KeyPress, TbPuntos.KeyPress, TbSuperficie.KeyPress, TbPrecioQuintal.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        If TbIdContratoAlgodon.Text <> "" Then
            Dim ReporteContrato As New RepContratoProductor(TbIdContratoAlgodon.Text)
            ReporteContrato.ShowDialog()
        Else
            MessageBox.Show("No hay contrato seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btconsultacontratoventa_Click(sender As Object, e As EventArgs) Handles btconsultacontratoventa.Click
        If TbProductor.Text <> "" And TbPacas.Text <> "" Then
            Dim consulta As New ConsultaContratoVenta
            consulta.ShowDialog()
            If consulta.IdContratoVenta > 0 Then
                If (consulta.PacasDispContcomp + CInt(TbPacas.Text)) < consulta.PacasContVenta Then
                    tbidcontratovta.Text = consulta.IdContratoVenta
                    tbdescripcionvta.Text = consulta.nombre
                Else
                    MsgBox("La cantidad de pacas del contrato de compra exceden la cantidad de pacas del contrato de venta")
                End If
            End If
        End If
    End Sub

    Private Sub EnviarEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarEmailToolStripMenuItem.Click
        Dim Destinatario As String = ""
        Dim asunto As String = ""
        Dim Mensaje As String = ""
        If TbIdContratoAlgodon.Text <> "" Then
            asunto = "Contrato de pacas con el ID " & TbIdContratoAlgodon.Text & " Nombre de " & TbProductor.Text & "."
            Mensaje = "Se confirma la siguiente operacion ciclo PV" & TbTemporada.Text & "<br><br>Cliente.- " & TbProductor.Text & "<br>Ref. No.- " & TbIdContratoAlgodon.Text & "<br>Pacas.- " & TbPacas.Text & "<br>Precio Base.- " & IIf(Val(TbPrecioQuintal.Text) = 0, "On Call", Val(TbPrecioQuintal.Text)) & "<br>Descuento.- " & TbPuntos.Text & "<br>Precio base neto.- " & Val(TbPrecioQuintal.Text) - Val(TbPuntos.Text) & "<br><br><br><br>Enviado desde SIA."
            Destinatario = InputBox("Para:", "Complete la direccion de correo del destinatario.")
            enviarCorreo(email, password, Mensaje, asunto, Destinatario, puertosmtp, hostsmtp, ConexionSSL)
        Else
            MsgBox("Seleccione un contrato para enviar por email.", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub TbPacas_TextChanged(sender As Object, e As EventArgs) Handles TbPacas.TextChanged
        'Select Case e.KeyData
        '    Case Keys.Enter
        If Val(TbPacas.Text) >= Val(TbPacasCompradas.Text) Then
            TbPacasDisponibles.Text = Val(TbPacas.Text) - Val(TbPacasCompradas.Text)
            TbPacasCompradas.Text = IIf(TbPacasCompradas.Text = "", 0, Val(TbPacasCompradas.Text))
        End If
        '    End Select
    End Sub
End Class