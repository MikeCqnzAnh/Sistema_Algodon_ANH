Imports Capa_Operacion.Configuracion
Public Class CargaPacasExternas
    Public TablaPaquetesHVIGlobal As DataTable
    Private Sub CargaPacasExternas_Load(sender As Object, e As EventArgs) Handles Me.Load
        nuevo()
    End Sub
    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        nuevo()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub nuevo()
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        TbLotID.Text = ""
        TbPredio.Text = ""
        TbTotalPacas.Text = ""
        TbTotalKilos.Text = ""
        TbIdOrdenTrabajo.Text = ""
        TbIdProduccion.Text = ""
        TbIdLiquidacion.Text = ""
        TbIdPaqueteHVI.Text = ""
        TbRangoFin.Text = ""
        TbRangoInicio.Text = ""
        TbNoModulos.Text = ""
        DgvPacas.DataSource = Nothing
        DgvPacas.Columns.Clear()
        llenaCombos()
        ConsultarUltimoRango()
    End Sub
    Private Sub ConsultarUltimoRango()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaRango
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla = EntidadOrdenTrabajo.TablaConsulta
        TbRangoInicio.Text = (Tabla.Rows(0).Item("RangoFin") + 1)
    End Sub
    Private Sub TbRangoFin_Leave(sender As Object, e As EventArgs) Handles TbRangoFin.Leave
        If TbRangoFin.Text = "" Then
            MsgBox("Ingrese un valor para el rango final")
            Exit Sub
        Else
            TbNoModulos.Text = CInt((TbRangoFin.Text - TbRangoInicio.Text) + 1)
        End If
    End Sub
    Private Sub ConsultaOrdProd()
        If TbIdOrdenTrabajo.Text <> "" Then
            Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
            Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
            Dim Tabla As New DataTable
            EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaOrden
            EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = CInt(TbIdOrdenTrabajo.Text)
            NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
            Tabla = EntidadLiquidacionesPorRomaneaje.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                MsgBox("La orden de trabajo no existe...")
                'Limpiar()
                Exit Sub
            Else
                TbIdOrdenTrabajo.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
                'CbPlantaOrigen.SelectedValue = Tabla.Rows(0).Item("IdPlantaOrigen")
                TbIdLiquidacion.Text = Tabla.Rows(0).Item("IdLiquidacion")
                'CbNombreCliente.SelectedValue = Tabla.Rows(0).Item("IdCliente")
                'CbPorCuenta.SelectedValue = Tabla.Rows(0).Item("IdPorCuenta")
                'CbTipo.Text = Tabla.Rows(0).Item("Tipo")
                'DtFechaLiquidacion.Value = Tabla.Rows(0).Item("Fecha")
                'TbComentarios.Text = Tabla.Rows(0).Item("Comentarios")
                'ConsultarModulos()
                'CalculosResumen()
                'TbTotalBoletas.Text = CInt(DgvModulos.RowCount)
                'TbIdOrden.Enabled = False
            End If
        Else
            MsgBox("Ingrese el ID de la orden de trabajo...")
            Exit Sub
        End If
    End Sub
    Private Function ConsultaModulos()
        Dim TablaModulos As DataTable
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        Dim Tabla As New DataTable
        EntidadCapturaBoletasPorLotes.Consulta = Consulta.ConsultaExterna
        EntidadCapturaBoletasPorLotes.IdOrdenTrabajo = CInt(TbIdOrdenTrabajo.Text)
        NegocioCapturaBoletasPorLotes.Consultar(EntidadCapturaBoletasPorLotes)
        TablaModulos = EntidadCapturaBoletasPorLotes.TablaConsulta
        Return TablaModulos
    End Function
    Private Sub llenaCombos()
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
        CBPlantaDestino.SelectedValue = 0
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
        CbTipoPaca.DataSource = dt3
        CbTipoPaca.ValueMember = "Id"
        CbTipoPaca.DisplayMember = "Descripcion"
        CbTipoPaca.SelectedValue = 1
        '--Variedades algodon--
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla3 As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaVariedadesAlgodon
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla3 = EntidadOrdenTrabajo.TablaConsulta
        CbVariedad.DataSource = Tabla3
        CbVariedad.ValueMember = "IdVariedadAlgodon"
        CbVariedad.DisplayMember = "Descripcion"
        CbVariedad.SelectedValue = 1
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
    End Sub
    Private Sub BtProductor_Click(sender As Object, e As EventArgs) Handles BtProductor.Click
        ConsultaProductores.ShowDialog()
        If VarGlob.Id > 0 Then
            TbIdProductor.Text = VarGlob.Id
            TbNombreProductor.Text = VarGlob.Nombre
            VarGlob.Id = 0
            VarGlob.Nombre = ""
        End If
    End Sub
    Private Sub DgvPacasClasificacion_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DgvPacas.RowPostPaint
        Try
            Dim NumeroFila As String = (e.RowIndex + 1).ToString 'Obtiene el número de filas
            While NumeroFila.Length < DgvPacas.RowCount.ToString.Length
                NumeroFila = "0" & NumeroFila 'Agrega un cero a los que tienen un dígito menos
            End While
            Dim size As SizeF = e.Graphics.MeasureString(NumeroFila, Me.Font)
            If DgvPacas.RowHeadersWidth < CInt(size.Width + 20) Then
                DgvPacas.RowHeadersWidth = CInt(size.Width + 20)
            End If
            Dim Obj As Brush = SystemBrushes.ControlText
            'Dibuja el número dentro del controltext
            e.Graphics.DrawString(NumeroFila, Me.Font, Obj, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
    Private Sub BtCargaExcel_Click(sender As Object, e As EventArgs) Handles BtCargaExcel.Click
        Dim SumaKilos As Integer = 0
        importarExcelExterno(DgvPacas)
        TbTotalPacas.Text = DgvPacas.Rows.Count()
        If DgvPacas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPacas.Rows
                If Not Fila Is Nothing Then
                    SumaKilos = SumaKilos + Fila.Cells(25).Value
                End If
            Next
        End If
        TbTotalKilos.Text = SumaKilos
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GuardarOrdenTrabajoEnc()

        Dim TablaModulos As DataTable
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes

        EntidadCapturaBoletasPorLotes.Consulta = Consulta.ConsultaExterna
        EntidadCapturaBoletasPorLotes.IdOrdenTrabajo = CInt(TbIdOrdenTrabajo.Text)
        NegocioCapturaBoletasPorLotes.Consultar(EntidadCapturaBoletasPorLotes)
        TablaModulos = EntidadCapturaBoletasPorLotes.TablaConsulta

        For Each row As DataRow In TablaModulos.Rows
            ActualizaPesoModuloManual(CStr(row("IdBoleta")), 2, 1, 1, 1, 0)
        Next
        GuardaLiquidacion()
        GuardaProduccionPacaEnc()
        For Each Fila As DataGridViewRow In DgvPacas.Rows
            GuardaProduccionPacaDet(Fila.Cells("BALEID").Value, Fila.Cells("KILOS").Value)
        Next
        'GuardarHvi()
    End Sub
    Private Sub GuardarOrdenTrabajoEnc()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Try
            EntidadOrdenTrabajo.IdOrdenTrabajo = IIf(TbIdOrdenTrabajo.Text = "", 0, TbIdOrdenTrabajo.Text)
            EntidadOrdenTrabajo.IdPlanta = CbPlantaOrigen.SelectedValue
            EntidadOrdenTrabajo.IdProductor = TbIdProductor.Text
            EntidadOrdenTrabajo.RangoInicio = TbRangoInicio.Text
            EntidadOrdenTrabajo.RangoFin = TbRangoFin.Text
            EntidadOrdenTrabajo.IdVariedadAlgodon = CbVariedad.SelectedValue
            EntidadOrdenTrabajo.IdColonia = 1
            EntidadOrdenTrabajo.Predio = TbPredio.Text
            EntidadOrdenTrabajo.NoModulos = TbNoModulos.Text
            EntidadOrdenTrabajo.IdEstatus = 1
            EntidadOrdenTrabajo.IdUsuarioCreacion = 1
            EntidadOrdenTrabajo.FechaCreacion = Now
            EntidadOrdenTrabajo.IdUsuarioActualizacion = 1
            EntidadOrdenTrabajo.FechaActualizacion = Now
            NegocioOrdenTrabajo.Guardar(EntidadOrdenTrabajo)
            TbIdOrdenTrabajo.Text = EntidadOrdenTrabajo.IdOrdenTrabajo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardaLiquidacion()
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        Try
            EntidadLiquidacionesPorRomaneaje.IdLiquidacion = IIf(TbIdLiquidacion.Text = "", 0, TbIdLiquidacion.Text)
            EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
            EntidadLiquidacionesPorRomaneaje.IdCliente = TbIdProductor.Text
            EntidadLiquidacionesPorRomaneaje.Fecha = Now
            EntidadLiquidacionesPorRomaneaje.Comentarios = ""
            ''----------------------------------------------------------------
            EntidadLiquidacionesPorRomaneaje.TotalHueso = 0
            EntidadLiquidacionesPorRomaneaje.TotalPluma = 0
            EntidadLiquidacionesPorRomaneaje.TotalSemilla = 0
            EntidadLiquidacionesPorRomaneaje.TotalMerma = 0
            EntidadLiquidacionesPorRomaneaje.TotalPacas = 0
            EntidadLiquidacionesPorRomaneaje.TotalBoletas = 0
            EntidadLiquidacionesPorRomaneaje.TotalBorregos = 0
            EntidadLiquidacionesPorRomaneaje.TotalPlumaBorregos = 0
            EntidadLiquidacionesPorRomaneaje.PorcentajePluma = 0
            EntidadLiquidacionesPorRomaneaje.PorcentajeSemilla = 0
            EntidadLiquidacionesPorRomaneaje.PorcentajeMerma = 0
            ''---------------------------------------------
            EntidadLiquidacionesPorRomaneaje.IdEstatus = 1
            EntidadLiquidacionesPorRomaneaje.IdUsuarioCreacion = 1
            EntidadLiquidacionesPorRomaneaje.FechaCreacion = Now
            EntidadLiquidacionesPorRomaneaje.IdUsuarioActualizacion = 1
            EntidadLiquidacionesPorRomaneaje.FechaActualizacion = Now
            NegocioLiquidacionesPorRomaneaje.Upsert(EntidadLiquidacionesPorRomaneaje)
            TbIdLiquidacion.Text = EntidadLiquidacionesPorRomaneaje.IdLiquidacion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardaProduccionPacaEnc()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Try
            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
            EntidadProduccion.IdPlantaDestino = CBPlantaDestino.SelectedValue
            EntidadProduccion.Fecha = Now
            EntidadProduccion.Tipo = CbTipoPaca.Text
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
    Private Sub RecorrerDgv()
        GuardaProduccionPacaEnc()
        If DgvPacas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPacas.Rows
                GuardaProduccionPacaDet(Fila.Cells("BaleID").Value, Fila.Cells("Kilos").Value)
            Next
        End If
    End Sub
    Private Sub GuardaProduccionPacaDet(ByVal NoPaca As Integer, ByVal Kilos As Integer)
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Try
            EntidadProduccion.IdProduccionDetalle = 0
            EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
            EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
            EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
            EntidadProduccion.FolioCIA = NoPaca
            EntidadProduccion.Tipo = CbTipoPaca.Text
            EntidadProduccion.Kilos = Kilos
            EntidadProduccion.BandExiste = True
            EntidadProduccion.IdTurno = 1
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarHvi()
        Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
        Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
        Try
            EntidadPaquetesHVI.IdPaqueteHVI = IIf(TbIdPaqueteHVI.Text = "", 0, TbIdPaqueteHVI.Text)
            EntidadPaquetesHVI.LotId = TbLotID.Text
            EntidadPaquetesHVI.NumeroPacas = DgvPacas.Rows.Count
            EntidadPaquetesHVI.IdPlanta = CbPlantaOrigen.SelectedValue
            EntidadPaquetesHVI.Fecha = Now
            EntidadPaquetesHVI.IdEstatus = 1
            EntidadPaquetesHVI.IdUsuarioCreacion = 1
            EntidadPaquetesHVI.FechaCreacion = Now
            EntidadPaquetesHVI.IdUsuarioActualizacion = 1
            EntidadPaquetesHVI.FechaActualizacion = Now
            EntidadPaquetesHVI.TablaGlobal = TablaPaquetesHVIGlobal
            NegocioPaquetesHVI.Guardar(EntidadPaquetesHVI)
            TbIdPaqueteHVI.Text = EntidadPaquetesHVI.IdPaqueteHVI
            ObtieneOrdentrabajoPaca()
        Catch ex As Exception
            MsgBox(ex)
        Finally
            'NumeroPacas = 0
            MsgBox("Guardado con exito!")
        End Try
    End Sub
    Private Sub ObtieneOrdentrabajoPaca()
        If DgvPacas.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPacas.Rows
                If Not Fila Is Nothing Then
                    Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
                    Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
                    EntidadPaquetesHVI.IdPlanta = CbPlantaOrigen.SelectedValue
                    EntidadPaquetesHVI.BaleID = Fila.Cells("BaleID").Value
                    NegocioPaquetesHVI.GuardarIdOrden(EntidadPaquetesHVI)
                End If
            Next
        End If
    End Sub
    Private Sub ConsultaPaqueteHVI()
        Dim vReturn(1) As String
        If TbLotID.Text <> "" Then
            'vReturn = ExistePaqueteHVI(TbPaquete.Text)
            If vReturn(0) = False And vReturn(1) = False Then
                MsgBox("El paquete consultado no se encuentra registrado!", MsgBoxStyle.Information, "Aviso")
            Else
                Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
                Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
                EntidadPaquetesHVI.Consulta = Consulta.ConsultaDetallada
                EntidadPaquetesHVI.IdPaquete = TbLotID.Text
                NegocioPaquetesHVI.Consultar(EntidadPaquetesHVI)
                TablaPaquetesHVIGlobal = EntidadPaquetesHVI.TablaConsulta
                'DgvPacas.DataSource = TablaPaquetesHVIGlobal
                'PropiedadesDGV()
                'If DgvPaquetesHVI.Rows.Count > 0 Then IdentificaEstatusPacas()
                ''BtSeleccionar.Enabled = False
                'If DgvPacas.RowCount > 0 Then TbIdPaqueteHVI.Text = DgvPacas.Rows(0).Cells("IdHviEnc").Value
                'If DgvPacas.RowCount > 0 Then CbPlanta.SelectedValue = DgvPacas.Rows(0).Cells("IdPlantaOrigen").Value
                'ContarFilas()
            End If
        Else
            MsgBox("El campo Paquete no puede ir vacios.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If
    End Sub
    Private Sub ActualizaPesoModuloManual(ByVal IdBoleta As Integer, ByVal Bruto As Double, ByVal Tara As Double, ByVal Total As Double, ByVal Revisada As Boolean, ByVal Cancelada As Boolean)
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        Try
            EntidadCapturaBoletasPorLotes.Idboleta = IdBoleta
            EntidadCapturaBoletasPorLotes.Bruto = Bruto
            EntidadCapturaBoletasPorLotes.Tara = Tara
            EntidadCapturaBoletasPorLotes.Neto = Total
            EntidadCapturaBoletasPorLotes.FlagRevisada = Revisada
            EntidadCapturaBoletasPorLotes.FlagCancelada = Cancelada
            NegocioCapturaBoletasPorLotes.upsert(EntidadCapturaBoletasPorLotes)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class