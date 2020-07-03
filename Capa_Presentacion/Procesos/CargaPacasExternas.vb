Imports Capa_Operacion.Configuracion
Public Class CargaPacasExternas
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
        DgvPacas.Columns.Clear()
        llenaCombos()
    End Sub
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
        CBPlantaDestino.SelectedValue = 1
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
        importarExcelExterno(DgvPacas)
        TbTotalPacas.Text = DgvPacas.Rows.Count()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

    End Sub
    Private Sub GuardarOrdenTrabajoEnc()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        EntidadOrdenTrabajo.IdOrdenTrabajo = IIf(TbIdOrdenTrabajo.Text = "", 0, TbIdOrdenTrabajo.Text)
        EntidadOrdenTrabajo.IdPlanta = CbPlantaOrigen.SelectedValue
        EntidadOrdenTrabajo.IdProductor = TbIdProductor.Text
        'EntidadOrdenTrabajo.RangoInicio = TbRangoInicio.Text
        'EntidadOrdenTrabajo.RangoFin = TbRangoFin.Text
        EntidadOrdenTrabajo.IdVariedadAlgodon = CbVariedad.SelectedValue
        'EntidadOrdenTrabajo.IdColonia = CbColonia.SelectedValue
        EntidadOrdenTrabajo.Predio = TbPredio.Text
        'EntidadOrdenTrabajo.NoModulos = TbNoModulos.Text
        EntidadOrdenTrabajo.IdEstatus = 1
        EntidadOrdenTrabajo.IdUsuarioCreacion = 1
        EntidadOrdenTrabajo.FechaCreacion = Now
        EntidadOrdenTrabajo.IdUsuarioActualizacion = 1
        EntidadOrdenTrabajo.FechaActualizacion = Now
        NegocioOrdenTrabajo.Guardar(EntidadOrdenTrabajo)
        TbIdOrdenTrabajo.Text = EntidadOrdenTrabajo.IdOrdenTrabajo
        MsgBox("Realizado Correctamente")
    End Sub
    Private Sub GuardaLiquidacion()
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje.IdLiquidacion = IIf(TbIdLiquidacion.Text = "", 0, TbIdLiquidacion.Text)
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
        EntidadLiquidacionesPorRomaneaje.IdCliente = TbNombreProductor.Text
        EntidadLiquidacionesPorRomaneaje.Fecha = Now
        'EntidadLiquidacionesPorRomaneaje.Comentarios = TbComentarios.Text
        ''----------------------------------------------------------------
        'EntidadLiquidacionesPorRomaneaje.TotalHueso = CDbl(TbTotalHueso.Text)
        'EntidadLiquidacionesPorRomaneaje.TotalPluma = CDbl(TbTotalPluma.Text)
        'EntidadLiquidacionesPorRomaneaje.TotalSemilla = CDbl(TbTotalSemilla.Text)
        'EntidadLiquidacionesPorRomaneaje.TotalMerma = CDbl(TbTotalMerma.Text)
        'EntidadLiquidacionesPorRomaneaje.TotalPacas = CInt(TbNumPacas.Text)
        'EntidadLiquidacionesPorRomaneaje.TotalBoletas = CInt(TbTotalBoletas.Text)
        'EntidadLiquidacionesPorRomaneaje.TotalBorregos = CInt(TbNumBorregos.Text)
        'EntidadLiquidacionesPorRomaneaje.TotalPlumaBorregos = CDbl(TbBorregosPluma.Text)
        'EntidadLiquidacionesPorRomaneaje.PorcentajePluma = CDbl(TbPorcentajePluma.Text)
        'EntidadLiquidacionesPorRomaneaje.PorcentajeSemilla = CDbl(TbPorcentajeSemilla.Text)
        'EntidadLiquidacionesPorRomaneaje.PorcentajeMerma = CDbl(TbPorcentajeMerma.Text)
        ''---------------------------------------------
        EntidadLiquidacionesPorRomaneaje.IdEstatus = 1
        EntidadLiquidacionesPorRomaneaje.IdUsuarioCreacion = 1
        EntidadLiquidacionesPorRomaneaje.FechaCreacion = Now
        EntidadLiquidacionesPorRomaneaje.IdUsuarioActualizacion = 1
        EntidadLiquidacionesPorRomaneaje.FechaActualizacion = Now
        NegocioLiquidacionesPorRomaneaje.Upsert(EntidadLiquidacionesPorRomaneaje)
        'TbIdLiquidacion.Text = EntidadLiquidacionesPorRomaneaje.IdLiquidacion
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
    Private Sub GuardaProduccionPacaDet()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        EntidadProduccion.IdProduccionDetalle = 0
        EntidadProduccion.IdProduccion = IIf(TbIdProduccion.Text = "", 0, TbIdProduccion.Text)
        EntidadProduccion.IdOrdenTrabajo = TbIdOrdenTrabajo.Text
        EntidadProduccion.IdPlantaOrigen = CbPlantaOrigen.SelectedValue
        'EntidadProduccion.FolioCIA = TbFolioCIA.Text
        EntidadProduccion.Tipo = CbTipoPaca.Text
        'EntidadProduccion.Kilos = Val(TbKilos.Text)
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
    End Sub
End Class