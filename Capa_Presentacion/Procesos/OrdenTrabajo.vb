Imports Capa_Operacion.Configuracion
Public Class OrdenTrabajo
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
        ConsultarUltimoRango()
    End Sub

    Private Sub CapturaLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        Limpiar()
        ConsultarUltimoRango()
        ConsultarCapturas()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Try
            EntidadOrdenTrabajo.IdOrdenTrabajo = IIf(TbIdOrdenTrabajo.Text = "", 0, TbIdOrdenTrabajo.Text)
            EntidadOrdenTrabajo.IdPlanta = CbPlantas.SelectedValue
            EntidadOrdenTrabajo.IdProductor = TbIdProductor.Text
            EntidadOrdenTrabajo.RangoInicio = TbRangoInicio.Text
            EntidadOrdenTrabajo.RangoFin = TbRangoFin.Text
            EntidadOrdenTrabajo.IdVariedadAlgodon = CbVariedad.SelectedValue
            EntidadOrdenTrabajo.IdColonia = CbColonia.SelectedValue
            EntidadOrdenTrabajo.Predio = TbPredio.Text
            EntidadOrdenTrabajo.NoModulos = TbNoModulos.Text
            EntidadOrdenTrabajo.IdEstatus = CbEstatus.SelectedValue
            EntidadOrdenTrabajo.IdUsuarioCreacion = IdUsuario
            EntidadOrdenTrabajo.FechaCreacion = Now
            EntidadOrdenTrabajo.IdUsuarioActualizacion = IdUsuario
            EntidadOrdenTrabajo.FechaActualizacion = Now
            NegocioOrdenTrabajo.Guardar(EntidadOrdenTrabajo)
            TbIdOrdenTrabajo.Text = EntidadOrdenTrabajo.IdOrdenTrabajo
            MsgBox("Realizado Correctamente")
            ConsultarCapturas()
            GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, IdUsuario, Usuario)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ConsultarOrden()
    End Sub
    Private Sub Limpiar()
        TbIdOrdenTrabajo.Text = ""
        CbPlantas.SelectedValue = 1
        TbIdProductor.Text = ""
        TbNombre.Text = ""
        TbRangoInicio.Text = ""
        TbRangoFin.Text = ""
        TbNoModulos.Text = ""
        CbVariedad.SelectedValue = 1
        CbColonia.SelectedValue = 1
        TbPredio.Text = ""
    End Sub
    Private Sub LlenarCombos()
        '---Plantas--
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaExterna
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla = EntidadOrdenTrabajo.TablaConsulta
        CbPlantas.DataSource = Tabla
        CbPlantas.ValueMember = "IdPlanta"
        CbPlantas.DisplayMember = "Descripcion"
        CbPlantas.SelectedValue = 1
        '--Variedades algodon--
        Dim Tabla2 As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaVariedadesAlgodon
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla2 = EntidadOrdenTrabajo.TablaConsulta
        CbVariedad.DataSource = Tabla2
        CbVariedad.ValueMember = "IdVariedadAlgodon"
        CbVariedad.DisplayMember = "Descripcion"
        CbVariedad.SelectedValue = 1
        '--Colonias--
        Dim Tabla3 As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaColonias
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla3 = EntidadOrdenTrabajo.TablaConsulta
        CbColonia.DataSource = Tabla3
        CbColonia.ValueMember = "IdColonia"
        CbColonia.DisplayMember = "Descripcion"
        CbColonia.SelectedValue = 1
        '--Estatus--
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
    End Sub

    'Private Sub TbIdProductor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbIdProductor.KeyDown
    '    Select Case e.KeyData
    '        Case Keys.Enter
    '            ConsultaCliente()
    '    End Select
    'End Sub
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
    Private Sub ConsultarCapturas()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaBasica
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla = EntidadOrdenTrabajo.TablaConsulta
        DgvCapturaLotes.DataSource = Tabla
    End Sub
    Private Sub ConsultarOrden()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        Dim ConsultaOrden As New ConsultaOrdenTrabajo()
        ConsultaOrden.ShowDialog()
        Try
            EntidadOrdenTrabajo.Consulta = Consulta.ConsultaOrden
            EntidadOrdenTrabajo.IdOrdenTrabajo = ConsultaOrden.IdConsulta
            NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
            Tabla = EntidadOrdenTrabajo.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                Exit Sub
            Else
                TbIdOrdenTrabajo.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
                CbPlantas.SelectedValue = Tabla.Rows(0).Item("IdPlanta")
                TbIdProductor.Text = Tabla.Rows(0).Item("IdProductor")
                TbNombre.Text = Tabla.Rows(0).Item("Nombre")
                TbRangoInicio.Text = Tabla.Rows(0).Item("RangoInicio")
                TbRangoFin.Text = Tabla.Rows(0).Item("RangoFin")
                TbNoModulos.Text = Tabla.Rows(0).Item("NumeroModulos")
                CbVariedad.SelectedValue = Tabla.Rows(0).Item("IdVariedadAlgodon")
                CbColonia.SelectedValue = Tabla.Rows(0).Item("IdColonia")
                TbPredio.Text = Tabla.Rows(0).Item("Predio")
                CbEstatus.SelectedValue = Tabla.Rows(0).Item("IdEstatus")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultaCliente()
        If TbIdProductor.Text <> "" Then
            Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
            Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
            Dim Tabla As New DataTable
            EntidadOrdenTrabajo.Consulta = Consulta.ConsultaProductorId
            EntidadOrdenTrabajo.IdProductor = CInt(TbIdProductor.Text)
            NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
            Tabla = EntidadOrdenTrabajo.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                MsgBox("El productor no existe")
                Exit Sub
            Else
                TbIdProductor.Text = Tabla.Rows(0).Item("IdCliente")
                TbNombre.Text = Tabla.Rows(0).Item("Nombre")
            End If
        Else
            MsgBox("Ingrese el id del productor")
            Exit Sub
        End If
    End Sub
    Private Sub BtBuscarProductor_Click(sender As Object, e As EventArgs) Handles BtBuscarProductor.Click
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        Dim Tabla As New DataTable
        ConsultaClientes.ShowDialog()
        Try
            EntidadClientes.IdCliente = ConsultaClientes.IdCliente
            EntidadClientes.Consulta = Consulta.ConsultaDetallada
            NegocioClientes.Consultar(EntidadClientes)
            Tabla = EntidadClientes.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                Exit Sub
            Else
                TbIdProductor.Text = Tabla.Rows(0).Item("IdCliente")
                TbNombre.Text = Tabla.Rows(0).Item("Nombre")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'ConsultaCliente()
    End Sub

    Private Sub DgvCapturaLotes_DoubleClick(sender As Object, e As EventArgs) Handles DgvCapturaLotes.DoubleClick

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class