Imports Capa_Operacion.Configuracion
Public Class OrdenEmbarquePacas
    Implements IForm1
    Private Sub OrdenEmbarquePacas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Nuevo()
    End Sub
    Private Sub Nuevo()
        TbIdEmbarque.Text = ""
        TbNoPacas.Text = ""
        TbIdComprador.Text = 0
        TbNombreChofer.Text = ""
        TbNombreComprador.Text = ""
        TbNoLicencia.Text = ""
        TbObservaciones.Text = ""
        TbPlacaTractoCamion.Text = ""
        TbNoContenedor1.Text = ""
        TbNoContenedor2.Text = ""
        TbTelefono.Text = ""
        TbNoLote1.Text = ""
        TbNoLote2.Text = ""
        RbCaja1.Checked = True
        TbPlacaCaja1.Text = ""
        TbPlacaCaja2.Text = ""
        DtpFecha.Value = Now
        DgvPacasEmbarcadas.DataSource = ""
        DgvPaqueteEmbarcado.DataSource = ""
        GbProceso.Enabled = False
    End Sub
    Private Sub ActivaCaja2(sender As Object, e As EventArgs) Handles RbCaja1.CheckedChanged
        If RbCaja1.Checked = True Then
            GbCaja2.Enabled = False
            RbSeleccionaCaja2.Enabled = False
            RbSeleccionaCaja1.Checked = True
        Else
            GbCaja2.Enabled = True
            RbSeleccionaCaja2.Enabled = True
        End If
    End Sub
    Private Sub CargaPaquetesDisponibles()
        Try
            Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
            Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
            Dim Tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaBasica
            EntidadOrdenEmbarquePacas.IdComprador = TbIdComprador.Text
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            DgvPaquetesDisponibles.DataSource = EntidadOrdenEmbarquePacas.TablaConsulta
            PropiedadesDgvPaquetesDisponibles()
            'FormatoDatagrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargaPacasDisponibles()
        Try
            Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
            Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
            Dim Tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaAlmacen
            EntidadOrdenEmbarquePacas.IdComprador = TbIdComprador.Text
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            DgvPacasDisponibles.DataSource = EntidadOrdenEmbarquePacas.TablaConsulta
            PropiedadesDgvPacasDisponibles()
            'FormatoDatagrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarPaqueteEmbarcado()
        Try
            Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
            Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
            Dim Tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaPaqueteEmbarcado
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = Val(TbIdEmbarque.Text)
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            DgvPaqueteEmbarcado.DataSource = EntidadOrdenEmbarquePacas.TablaConsulta
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarPacasEmbarcadas()
        Try
            Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
            Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
            Dim Tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaPacasEmbarcado
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = Val(TbIdEmbarque.Text)
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            DgvPacasEmbarcadas.DataSource = EntidadOrdenEmbarquePacas.TablaConsulta
            PropiedadesDgvPacasEmbarcadas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PropiedadesDgvPaquetesDisponibles()
        DgvPaquetesDisponibles.Columns("IdPaqueteEncabezado").HeaderText = "ID Paquete"
        DgvPaquetesDisponibles.Columns("IdPaqueteEncabezado").ReadOnly = True
        DgvPaquetesDisponibles.Columns("Cantidad").ReadOnly = True
        DgvPaquetesDisponibles.Columns("Kilos").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvPacasDisponibles()
        DgvPacasDisponibles.Columns("IdPaqueteEncabezado").HeaderText = "ID Paquete"
        DgvPacasDisponibles.Columns("BaleID").HeaderText = "Etiqueta"
        DgvPacasDisponibles.Columns("Descripcion").HeaderText = "Planta"

        DgvPacasDisponibles.Columns("IdPaqueteEncabezado").ReadOnly = True
        DgvPacasDisponibles.Columns("BaleID").ReadOnly = True
        DgvPacasDisponibles.Columns("Descripcion").ReadOnly = True
        DgvPacasDisponibles.Columns("Kilos").ReadOnly = True
        DgvPacasDisponibles.Columns("IdVentaEnc").ReadOnly = True
        DgvPacasDisponibles.Columns("IdPlantaOrigen").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvPacasEmbarcadas()
        DgvPacasEmbarcadas.Columns("IdEmbarqueDetalle").Visible = False
        DgvPacasEmbarcadas.Columns("IdEmbarqueEncabezado").Visible = False
        DgvPacasEmbarcadas.Columns("IdSalidaEncabezado").Visible = False
        DgvPacasEmbarcadas.Columns("IdComprador").Visible = False
        DgvPacasEmbarcadas.Columns("EstatusEmbarque").Visible = False
        DgvPacasEmbarcadas.Columns("EstatusSalida").Visible = False
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
        CargaPaquetesDisponibles()
        CargaPacasDisponibles()
    End Sub
    Private Sub DgvPaquetesDisponibles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPaquetesDisponibles.CellContentClick
        DgvPacasDisponibles.EndEdit()
        DgvPaquetesDisponibles.EndEdit()
        Dim filaSeleccionada As Integer = DgvPaquetesDisponibles.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvPaquetesDisponibles.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvPaquetesDisponibles.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvPacasDisponibles.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub DgvPaqueteEmbarcado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPaqueteEmbarcado.CellContentClick
        DgvPacasEmbarcadas.EndEdit()
        DgvPaqueteEmbarcado.EndEdit()
        Dim filaSeleccionada As Integer = DgvPaqueteEmbarcado.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvPaqueteEmbarcado.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvPaqueteEmbarcado.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvPacasEmbarcadas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        'MarcaSeleccionDisponibles()
    End Sub
    Private Sub MarcaSeleccionDisponibles()
        Dim Contador As Integer = 0
        Dim Kilos As Integer = 0
        For i As Integer = 0 To DgvPacasDisponibles.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvPacasDisponibles.Rows(i).Cells("Seleccionar").EditedFormattedValue, Boolean)
            If Seleccion = True Then
                Contador = Contador + 1
                Kilos = Kilos + DgvPacasDisponibles.Rows(i).Cells("Kilos").Value
            End If
        Next
        TbPacasMarc.Text = Contador
    End Sub
    Private Sub DgvPacasDisponibles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacasDisponibles.CellContentClick
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
        If RbCaja1.Checked = True And TbNoLote1.Text <> "" Then
            GuardaEmbarqueDetalle()
            TbNoPacas.Text = DgvPacasEmbarcadas.RowCount
            TbPacasMarc.Text = 0
            GuardarEncabezado()
        ElseIf RbCaja2.Checked = True And TbNoLote2.Text <> "" Then
            GuardaEmbarqueDetalle()
            TbNoPacas.Text = DgvPacasEmbarcadas.RowCount
            TbPacasMarc.Text = 0
            GuardarEncabezado()
        Else
            MsgBox("El Campo No Lote no puede estar vacio para continuar.")
        End If
    End Sub
    Private Sub BtSeleccionar2_Click(sender As Object, e As EventArgs) Handles BtSeleccionar2.Click
        DgvPacasEmbarcadas.EndEdit()
        DgvPaqueteEmbarcado.EndEdit()
        For Each row As DataGridViewRow In DgvPacasEmbarcadas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("Seleccionar").Value = True Then
                DeseleccionarPacas(row.Cells("IdEmbarqueDetalle").Value)
            End If
        Next
        CargaPaquetesDisponibles()
        CargaPacasDisponibles()
        ConsultarPaqueteEmbarcado()
        ConsultarPacasEmbarcadas()
        TbNoPacas.Text = DgvPacasEmbarcadas.RowCount
        GuardarEncabezado()
    End Sub
    Private Sub DeseleccionarPacas(ByVal IdEmbarqueDetalle As Integer)
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            Dim Tabla As New DataTable
            EntidadOrdenEmbarquePacas.Eliminar = Eliminar.EliminaPacaSeleccionada
            EntidadOrdenEmbarquePacas.IdEmbarqueDetalle = IdEmbarqueDetalle
            NegocioOrdenEmbarquePacas.Eliminar(EntidadOrdenEmbarquePacas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnBuscarProd_Click(sender As Object, e As EventArgs) Handles BtnBuscarProd.Click
        Dim _ConsultaCompradores As New ConsultaCompradores
        Nuevo()
        _ConsultaCompradores.MdiParent = Me.MdiParent
        _ConsultaCompradores.Opener = CType(Me, IForm1)
        _ConsultaCompradores.ShowDialog()
        CargaPaquetesDisponibles()
        CargaPacasDisponibles()
        ConsultarPaqueteEmbarcado()
        ConsultarPacasEmbarcadas()
    End Sub
    Public Function LoadIdComprador(ByVal DatatableParam As DataTable) As Boolean Implements IForm1.LoadIdComprador
        For Each row As DataRow In DatatableParam.Rows
            TbIdComprador.Text = row("IdComprador")
            TbNombreComprador.Text = row("Nombre")
        Next
        Return True
    End Function
    Public Function LoadIdVenta(_DataTable As DataTable) As Boolean Implements IForm1.LoadIdVenta
        Throw New NotImplementedException()
    End Function
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GuardarEncabezado()
    End Sub
    Private Sub GuardaEmbarqueDetalle()
        DgvPacasDisponibles.EndEdit()
        DgvPaquetesDisponibles.EndEdit()
        Dim filaSeleccionada As Integer = DgvPaquetesDisponibles.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvPaquetesDisponibles.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvPaquetesDisponibles.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvPacasDisponibles.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("Seleccionar").Value = True Then
                GuardaDetalle(row.Cells("IdVentaEnc").Value, row.Cells("IdPlantaOrigen").Value, row.Cells("BaleID").Value, row.Cells("Kilos").Value)
            End If
        Next
        CargaPaquetesDisponibles()
        CargaPacasDisponibles()
        ConsultarPaqueteEmbarcado()
        ConsultarPacasEmbarcadas()
    End Sub
    Private Sub GuardarEncabezado()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            EntidadOrdenEmbarquePacas.Guarda = Guardar.GuardarEmbarqueEncabezado
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            EntidadOrdenEmbarquePacas.IdComprador = TbIdComprador.Text
            EntidadOrdenEmbarquePacas.NombreChofer = TbNombreChofer.Text
            EntidadOrdenEmbarquePacas.PlacaTractoCamion = TbPlacaTractoCamion.Text
            EntidadOrdenEmbarquePacas.NoLicencia = TbNoLicencia.Text
            EntidadOrdenEmbarquePacas.NoLote1 = TbNoLote1.Text
            EntidadOrdenEmbarquePacas.NoLote2 = TbNoLote2.Text
            EntidadOrdenEmbarquePacas.Telefono = TbTelefono.Text
            EntidadOrdenEmbarquePacas.Observaciones = TbObservaciones.Text
            EntidadOrdenEmbarquePacas.CantidadCajas = IIf(RbCaja1.Checked = True, 1, 2)
            EntidadOrdenEmbarquePacas.NoContenedorCaja1 = TbNoContenedor1.Text
            EntidadOrdenEmbarquePacas.PlacaCaja1 = TbPlacaCaja1.Text
            EntidadOrdenEmbarquePacas.NoContenedorCaja2 = TbNoContenedor2.Text
            EntidadOrdenEmbarquePacas.PlacaCaja2 = TbPlacaCaja2.Text
            EntidadOrdenEmbarquePacas.NoPacas = Val(TbNoPacas.Text)
            EntidadOrdenEmbarquePacas.Fecha = DtpFecha.Value
            NegocioOrdenEmbarquePacas.Guardar(EntidadOrdenEmbarquePacas)
            TbIdEmbarque.Text = EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado
            GbProceso.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            GbProceso.Enabled = False
        End Try
    End Sub
    Private Sub GuardaDetalle(ByVal IdVenta As Integer, ByVal IdPlanta As Integer, ByVal BaleID As Integer, ByVal Kilos As Integer)
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Try
            EntidadOrdenEmbarquePacas.Guarda = Guardar.GuardarEmbarqueDetalle
            EntidadOrdenEmbarquePacas.IdEmbarqueDetalle = 0
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = TbIdEmbarque.Text
            EntidadOrdenEmbarquePacas.IdSalida = vbNull
            EntidadOrdenEmbarquePacas.IdComprador = TbIdComprador.Text
            EntidadOrdenEmbarquePacas.IdVentaEnc = IdVenta
            EntidadOrdenEmbarquePacas.IdPlanta = IdPlanta
            EntidadOrdenEmbarquePacas.BaleID = BaleID
            EntidadOrdenEmbarquePacas.Kilos = Kilos
            EntidadOrdenEmbarquePacas.NoContenedorInd = IIf(RbSeleccionaCaja1.Checked = True, TbNoContenedor1.Text, TbNoContenedor2.Text)
            EntidadOrdenEmbarquePacas.NoLoteInd = IIf(RbSeleccionaCaja1.Checked = True, TbNoLote1.Text, TbNoLote2.Text)
            EntidadOrdenEmbarquePacas.EstatusEmbarque = 0
            EntidadOrdenEmbarquePacas.EstatusSalida = 0
            NegocioOrdenEmbarquePacas.Guardar(EntidadOrdenEmbarquePacas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Dim Tabla As New DataTable
        ConsultaOrdenEmbarque.ShowDialog()
        EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = ConsultaOrdenEmbarque.Id
        EntidadOrdenEmbarquePacas.NombreComprador = ""
        EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaEmbarqueEncabezado
        NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
        Tabla = EntidadOrdenEmbarquePacas.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            TbIdEmbarque.Text = Tabla.Rows(0).Item("IdEmbarqueEncabezado")
            TbIdComprador.Text = Tabla.Rows(0).Item("IdComprador")
            TbNombreComprador.Text = Tabla.Rows(0).Item("Nombre")
            TbNombreChofer.Text = Tabla.Rows(0).Item("NombreChofer")
            TbPlacaTractoCamion.Text = Tabla.Rows(0).Item("PlacaTractoCamion")
            TbNoLicencia.Text = Tabla.Rows(0).Item("NoLicencia")
            TbNoLote1.Text = Tabla.Rows(0).Item("NoLote1")
            TbNoLote2.Text = Tabla.Rows(0).Item("NoLote2")
            TbTelefono.Text = Tabla.Rows(0).Item("Telefono")
            RbCaja1.Checked = IIf(Tabla.Rows(0).Item("CantidadCajas") = 1, True, False)
            RbCaja2.Checked = IIf(Tabla.Rows(0).Item("CantidadCajas") = 2, True, False)
            TbNoContenedor1.Text = Tabla.Rows(0).Item("NoContenedorCaja1")
            TbPlacaCaja1.Text = Tabla.Rows(0).Item("PlacaCaja1")
            TbNoContenedor2.Text = Tabla.Rows(0).Item("NoContenedorCaja2")
            TbPlacaCaja2.Text = Tabla.Rows(0).Item("PlacaCaja2")
            TbNoPacas.Text = Tabla.Rows(0).Item("CantidadPacas")
            DtpFecha.Value = Tabla.Rows(0).Item("Fecha")
            TbObservaciones.Text = Tabla.Rows(0).Item("Observaciones")
            CargaPaquetesDisponibles()
            CargaPacasDisponibles()
            ConsultarPaqueteEmbarcado()
            ConsultarPacasEmbarcadas()
            GbProceso.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GeneraRegistroBitacora(Me.Text.Clone.ToString, ConsultarToolStripMenuItem.Text, TbIdEmbarque.Text, TbNombreComprador.Text)
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
        Close()
    End Sub

    Private Sub EmbarqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarqueToolStripMenuItem.Click
        If TbIdEmbarque.Text <> "" Then
            Dim ReporteOrdenEmbarque As New RepOrdenEmbarque(TbIdEmbarque.Text)
            ReporteOrdenEmbarque.ShowDialog()
        Else
            MessageBox.Show("No hay Orden de Embarque seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class