Imports Capa_Operacion.Configuracion
Public Class RevisionProduccion
    Private Sub RevisionProduccion_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ConsultarOrden()
        ConsultarFaltantes()
        ConsultaDetallesOrden()
        If TbIdOrdenTrabajo.Text <> "" Then
            DgvPacasLigeras.DataSource = CargaDgvPacasPesos(False, NuRegistrosLigero.Value, NuPesoLigero.Value)
            TbContarLigeras.Text = DgvPacasLigeras.RowCount
            DgvPacasPesadas.DataSource = CargaDgvPacasPesos(True, NuRegistroPesado.Value, NuPesoPesado.Value)
            TbContarPesadas.Text = DgvPacasPesadas.RowCount
        End If
    End Sub
    Private Sub BtEliminarPacas_Click(sender As Object, e As EventArgs) Handles BtEliminarPacas.Click
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
                Consultar()
                TbTotalPacas.Text = DgvPacas.Rows.Count
                TbTotalKilos.Text = SumaKilos()
                GuardarProduccion()
            End Try
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
        NuRegistroPesado.Value = 10
        NuPesoPesado.Value = 250
        NuRegistrosLigero.Value = 10
        NuPesoLigero.Value = 180
        DgvPacasFaltantes.DataSource = ""
        DgvPacasLigeras.DataSource = ""
        DgvPacasPesadas.DataSource = ""
    End Sub
    Private Sub TbEtiquetaActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbFolioCIA.KeyPress, TbKilos.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarFaltantes()
        If CbPlanta.Text <> "" And Val(TbPrimerPaca.Text) > 0 And Val(TbUltimaPaca.Text) > Val(TbPrimerPaca.Text) Then
            Dim diferenciapacas As Integer = Val(TbUltimaPaca.Text) - Val(TbPrimerPaca.Text)
            Dim pacaproducida As Integer = Val(TbPacasProducidas.Text) + 10
            If Val(TbPacasProducidas.Text) Then
                Dim EntidadReportes As New Capa_Entidad.Reportes
                Dim NegocioReportes As New Capa_Negocio.Reportes
                Dim Tabla As New DataTable
                Try
                    EntidadReportes.Reporte = Reporte.ReportePacasFaltantes
                    EntidadReportes.IdPlanta = CbPlanta.SelectedValue
                    EntidadReportes.PacaInicial = Val(TbPrimerPaca.Text)
                    EntidadReportes.PacaFinal = Val(TbUltimaPaca.Text)
                    NegocioReportes.Consultar(EntidadReportes)
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
        EntidadProduccion.IdOrdenTrabajo = CInt(TbIdOrdenTrabajo.Text)
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
            DgvPacas.DataSource = Nothing
            TbIdOrdenTrabajo.Enabled = False
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
    Private Sub PropiedadesDGV()
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
End Class