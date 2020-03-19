Imports Capa_Operacion.Configuracion
Public Class SalidaPacas
    Implements IForm1
    Private NoPacas1, NoPacas2 As Integer
    Private NoContenedor1, NoContenedor2, PlacaCaja1, PlacaCaja2, NoLote1, NoLote2 As String
    Private Sub SalidaPacas_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboEstatus()
    End Sub
    Private Sub Nuevo()
        TbIdSalida.Text = ""
        TbIdEmbarque.Text = ""
        TbIdComprador.Text = ""
        TbNombreComprador.Text = ""
        TbNombreChofer.Text = ""
        TbTelefono.Text = ""
        TbPlacaTractoCamion.Text = ""
        TbNoLicencia.Text = ""
        TbDestino.Text = ""
        CbNoLote.SelectedValue = 0
        TbNoPacas.Text = ""
        TbNoContenedor.Text = ""
        TbPlacaCaja.Text = ""
        TbObservaciones.Text = ""
        TbNoFactura.Text = ""
        TbTara.Text = 0
        TbBruto.Text = 0
        TbNeto.Text = 0
        NoPacas1 = 0
        NoPacas2 = 0
        NoContenedor1 = ""
        NoContenedor2 = ""
        PlacaCaja1 = ""
        PlacaCaja2 = ""
        NoLote1 = ""
        NoLote2 = ""
        CbEstatus.SelectedIndex = -1
        DtpFechaEntrada.Value = Now
        DtFechaSalida.Value = Now
        DgvPacas.DataSource = ""
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
        Close()
    End Sub
    Private Sub BtnBuscarProd_Click(sender As Object, e As EventArgs) Handles BtnBuscarEmbarque.Click
        Nuevo()
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
            TbTelefono.Text = Tabla.Rows(0).Item("Telefono")
            NoContenedor1 = Tabla.Rows(0).Item("NoContenedorCaja1")
            NoContenedor2 = Tabla.Rows(0).Item("NoContenedorCaja2")
            PlacaCaja1 = Tabla.Rows(0).Item("PlacaCaja1")
            PlacaCaja2 = Tabla.Rows(0).Item("PlacaCaja2")
            NoLote1 = Tabla.Rows(0).Item("NoLote1")
            NoLote2 = Tabla.Rows(0).Item("NoLote2")
            'DtpFechaEntrada.Value = Tabla.Rows(0).Item("Fecha")
            'TbObservaciones.Text = Tabla.Rows(0).Item("Observaciones")
            If Tabla.Rows(0).Item("CantidadCajas") = 1 Then
                CargaCombo(Tabla.Rows(0).Item("CantidadCajas"), Tabla.Rows(0).Item("NoLote1"))
            ElseIf Tabla.Rows(0).Item("CantidadCajas") = 2 Then
                CargaCombo(Tabla.Rows(0).Item("CantidadCajas"), Tabla.Rows(0).Item("NoLote1"), Tabla.Rows(0).Item("NoLote2"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GeneraRegistroBitacora(Me.Text.Clone.ToString, ConsultarToolStripMenuItem.Text, TbIdEmbarque.Text, TbNombreComprador.Text)
        End Try
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        CbEstatus.SelectedValue = IIf(CbEstatus.SelectedValue = Nothing, 0, IIf(CbEstatus.SelectedValue = 0, 1, 0))
        GuardarSalida()
    End Sub
    Private Sub GuardarSalida()
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Try
            EntidadSalidaPacas.Guarda = Guardar.GuardarSalidaPacas
            EntidadSalidaPacas.IdSalidaEncabezado = IIf(TbIdSalida.Text = "", 0, TbIdSalida.Text)
            EntidadSalidaPacas.IdEmbarqueEncabezado = TbIdEmbarque.Text
            EntidadSalidaPacas.NoLote = CbNoLote.Text
            EntidadSalidaPacas.PesoBruto = Val(TbBruto.Text)
            EntidadSalidaPacas.PesoTara = Val(TbTara.Text)
            EntidadSalidaPacas.PesoNeto = Val(TbNeto.Text)
            EntidadSalidaPacas.Destino = TbDestino.Text
            EntidadSalidaPacas.NoFactura = TbNoFactura.Text
            EntidadSalidaPacas.FechaEntrada = DtpFechaEntrada.Value
            EntidadSalidaPacas.FechaSalida = DtFechaSalida.Value
            EntidadSalidaPacas.Observaciones = TbObservaciones.Text
            EntidadSalidaPacas.EstatusSalida = CbEstatus.SelectedValue
            NegocioSalidaPacas.Guardar(EntidadSalidaPacas)
            TbIdSalida.Text = EntidadSalidaPacas.IdSalidaEncabezado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub EnterToTab()
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '        e.Handled = True
    '        SendKeys.Send("{TAB}")
    '    End If
    'End Sub
    Private Sub formulario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode() = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub CalculaNeto()
        If Val(TbBruto.Text) > Val(TbNeto.Text) Then
            TbNeto.Text = Val(TbBruto.Text) - Val(TbTara.Text)
        Else
            TbNeto.Text = 0
        End If

    End Sub
    Private Sub ComboEstatus()
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("IdEstatus")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("IdEstatus") = "0"
        dr("Descripcion") = "SIN EMBARQUE"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("IdEstatus") = "1"
        dr("Descripcion") = "EMBARCADO"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "IdEstatus"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedIndex = -1
    End Sub
    Private Sub CargaCombo(ByVal CantidadLotes As Integer, ByVal NoLote1 As String, Optional ByVal NoLote2 As String = "")
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("IdLote")
        dt.Columns.Add("DescripcionLote")
        Dim dr As DataRow
        If CantidadLotes = 2 Then
            dr = dt.NewRow()
            dr("IdLote") = "1"
            dr("DescripcionLote") = NoLote1
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("IdLote") = "2"
            dr("DescripcionLote") = NoLote2
            dt.Rows.Add(dr)
            CbNoLote.DataSource = dt
            CbNoLote.ValueMember = "IdLote"
            CbNoLote.DisplayMember = "DescripcionLote"
            CbNoLote.SelectedValue = 0
        Else
            dr = dt.NewRow()
            dr("IdLote") = "1"
            dr("DescripcionLote") = NoLote1
            dt.Rows.Add(dr)
            CbNoLote.DataSource = dt
            CbNoLote.ValueMember = "IdLote"
            CbNoLote.DisplayMember = "DescripcionLote"
            CbNoLote.SelectedValue = 0
        End If
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Nuevo()
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Dim Tabla As New DataTable
        ConsultaSalidas.ShowDialog()
        EntidadSalidaPacas.IdEmbarqueEncabezado = ConsultaOrdenEmbarque.Id
        EntidadSalidaPacas.NombreComprador = ""
        EntidadSalidaPacas.Consulta = Consulta.ConsultaSalidaPacas
        NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
        Tabla = EntidadSalidaPacas.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            TbIdSalida.Text = Tabla.Rows(0).Item("IdSalidaEncabezado")
            TbIdEmbarque.Text = Tabla.Rows(0).Item("IdEmbarqueEncabezado")
            TbIdComprador.Text = Tabla.Rows(0).Item("IdComprador")
            TbNombreComprador.Text = Tabla.Rows(0).Item("Nombre")
            TbNombreChofer.Text = Tabla.Rows(0).Item("NombreChofer")
            TbPlacaTractoCamion.Text = Tabla.Rows(0).Item("PlacaTractoCamion")
            TbNoLicencia.Text = Tabla.Rows(0).Item("NoLicencia")
            TbTelefono.Text = Tabla.Rows(0).Item("Telefono")
            TbDestino.Text = Tabla.Rows(0).Item("Destino")
            TbNoFactura.Text = Tabla.Rows(0).Item("NoFactura")
            DtFechaSalida.Value = IIf(Tabla.Rows(0).Item("FechaSalida").ToString = "", Now, Tabla.Rows(0).Item("FechaSalida").ToString)
            DtpFechaEntrada.Value = Tabla.Rows(0).Item("FechaEntrada")
            TbObservaciones.Text = Tabla.Rows(0).Item("Observaciones")
            NoContenedor1 = Tabla.Rows(0).Item("NoContenedorCaja1")
            NoContenedor2 = Tabla.Rows(0).Item("NoContenedorCaja2")
            PlacaCaja1 = Tabla.Rows(0).Item("PlacaCaja1")
            PlacaCaja2 = Tabla.Rows(0).Item("PlacaCaja2")
            NoLote1 = Tabla.Rows(0).Item("NoLote1")
            NoLote2 = Tabla.Rows(0).Item("NoLote2")
            'DtpFechaEntrada.Value = Tabla.Rows(0).Item("Fecha")
            'TbObservaciones.Text = Tabla.Rows(0).Item("Observaciones")
            If Tabla.Rows(0).Item("CantidadCajas") = 1 Then
                CargaCombo(Tabla.Rows(0).Item("CantidadCajas"), Tabla.Rows(0).Item("NoLote1"))
            ElseIf Tabla.Rows(0).Item("CantidadCajas") = 2 Then
                CargaCombo(Tabla.Rows(0).Item("CantidadCajas"), Tabla.Rows(0).Item("NoLote1"), Tabla.Rows(0).Item("NoLote2"))
            End If
            CbEstatus.SelectedValue = Tabla.Rows(0).Item("EstatusSalida")
            CbNoLote.Text = Tabla.Rows(0).Item("NoLote")
            PropiedadesDgv()
            SeleccionaLoteCombo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PropiedadesDgv()
        DgvPacas.Columns("IdSalidaEncabezado").HeaderText = "ID Salida"
        DgvPacas.Columns("IdEmbarqueEncabezado").HeaderText = "ID Embarque"
        DgvPacas.Columns("IdComprador").Visible = False
        DgvPacas.Columns("Nombre").HeaderText = "Comprador"
        DgvPacas.Columns("NombreChofer").HeaderText = "Chofer"
        DgvPacas.Columns("PlacaTractoCamion").HeaderText = "Placas Camion"
        DgvPacas.Columns("NoLicencia").Visible = False
        DgvPacas.Columns("Telefono").Visible = False
        DgvPacas.Columns("Destino").Visible = False
        DgvPacas.Columns("NoFactura").Visible = False
        DgvPacas.Columns("FechaSalida").HeaderText = ""
        DgvPacas.Columns("FechaEntrada").HeaderText = ""
        DgvPacas.Columns("Observaciones").HeaderText = ""
        DgvPacas.Columns("NoContenedorCaja1").HeaderText = ""
        DgvPacas.Columns("NoContenedorCaja2").HeaderText = ""
        DgvPacas.Columns("PlacaCaja1").HeaderText = ""
        DgvPacas.Columns("PlacaCaja2").HeaderText = ""
        DgvPacas.Columns("NoLote1").HeaderText = ""
        DgvPacas.Columns("NoLote2").HeaderText = ""
    End Sub
    Private Sub ConsultarPacas(ByVal IdEmbarqueEncabezado As Integer, ByVal NoLote As String)
        Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
        Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
        Dim Tabla As New DataTable
        EntidadSalidaPacas.IdEmbarqueEncabezado = IdEmbarqueEncabezado
        EntidadSalidaPacas.NoLote = NoLote
        EntidadSalidaPacas.Consulta = Consulta.ConsultaPacasEmbarcado
        NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
        DgvPacas.DataSource = EntidadSalidaPacas.TablaConsulta
    End Sub
    Public Function LoadIdComprador(ByVal DatatableParam As DataTable) As Boolean Implements IForm1.LoadIdComprador
        For Each row As DataRow In DatatableParam.Rows
            TbIdComprador.Text = row("IdComprador")
            TbNombreComprador.Text = row("Nombre")
        Next
        Return True
    End Function
    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbBruto.KeyPress, TbNeto.KeyPress, TbTara.KeyPress
        Dim Cadena = ".0123456789"
        If InStr(Cadena, e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function LoadIdVenta(_DataTable As DataTable) As Boolean Implements IForm1.LoadIdVenta
        Throw New NotImplementedException()
    End Function
    Private Sub CbNoLote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNoLote.SelectionChangeCommitted
        SeleccionaLoteCombo()
    End Sub
    Private Sub SeleccionaLoteCombo()
        If CbNoLote.Text = NoLote1 Then
            TbNoContenedor.Text = NoContenedor1
            TbPlacaCaja.Text = PlacaCaja1
            ConsultarPacas(TbIdEmbarque.Text, NoLote1)
        ElseIf CbNoLote.Text = NoLote2 Then
            TbNoContenedor.Text = NoContenedor2
            TbPlacaCaja.Text = PlacaCaja2
            ConsultarPacas(TbIdEmbarque.Text, NoLote2)
        End If
        TbNoPacas.Text = DgvPacas.Rows.Count
    End Sub
    Private Sub TbBruto_Leave(sender As Object, e As EventArgs) Handles TbBruto.Leave
        CalculaNeto()
    End Sub
End Class