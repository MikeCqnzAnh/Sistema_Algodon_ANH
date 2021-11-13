Imports Capa_Operacion.Configuracion
Imports System.IO
Imports System.Data.OleDb
Public Class PaquetesHVI
    Public TablaPaquetesHVIGlobal As DataTable
    'Public Paquete As Integer
    Public NumeroPacas As Long
    'Dim IdEncabezadoExiste As Integer
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
        'Call ShowDialog.
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Access Database (*.mdb)|*.mdb| & All Files|*.*"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            TbRuta.Text = path
            'AbrirBaseDatosAccess()
            PropiedadesDGVCarga()
            Inhabilitar()
            NuCantidadPacas.Value = DgvPaquetesHVI.RowCount
        End If
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If CbPlanta.Text <> "" And TbPaquete.Text <> "" And CbPlanta.SelectedValue > 0 Then
            Dim vReturn(1) As String
            If DgvPaquetesHVI.DataSource IsNot Nothing And TbPaquete.Text <> "" Then
                vReturn = ExistePaqueteHVI(TbPaquete.Text)
                If vReturn(0) = True And vReturn(1) = TbIdPaqueteHVI.Text Then
                    Dim opc As DialogResult = MsgBox("Este paquete ya existe en HVI,¿Desea reemplazar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
                    If opc = DialogResult.Yes Then
                        TbIdPaqueteHVI.Text = vReturn(1)
                        Guardar()
                        BtSeleccionar.Enabled = False
                    End If
                ElseIf vReturn(0) = True And vReturn(1) <> TbIdPaqueteHVI.Text Then
                    MsgBox("El paquete No " & TbPaquete.Text & " ya existe y no es posible actualizar.")
                Else
                    Guardar()
                    DgvPaquetesHVI.ReadOnly = True
                    BtSeleccionar.Enabled = False
                End If
            Else
                MsgBox("Por favor, cargar la base de datos de access.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("Campo Planta y Paquete es requerido para continuar.", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub
    Private Function VerificaPacaPlanta(ByVal IdPaca As Long) As String()
        Dim Tabla As New DataTable
        'Dim Resultado As Boolean
        Dim vReturn(2) As String
        'PlantaVerifica = ""
        Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
        Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
        EntidadPaquetesHVI.Consulta = Consulta.ConsultaPacaPlanta
        EntidadPaquetesHVI.BaleID = IdPaca
        NegocioPaquetesHVI.Consultar(EntidadPaquetesHVI)
        Tabla = EntidadPaquetesHVI.TablaConsulta
        'If Tabla.Rows(0).Item("ExistePacaPlanta") = False Then
        'Resultado = True
        vReturn(0) = Tabla.Rows(0).Item("ExistePacaPlanta")
        vReturn(1) = Tabla.Rows(0).Item("IdPlantaOrigen")
        vReturn(2) = Tabla.Rows(0).Item("Planta")
        'Else
        '    Resultado = False
        'End If
        Return vReturn
    End Function
    Private Sub BtCargaExcel_Click(sender As Object, e As EventArgs) Handles BtCargaExcel.Click
        importarExcelExterno(DgvPaquetesHVI)
        PropiedadesDGVCarga()
        Inhabilitar()
        NuCantidadPacas.Value = DgvPaquetesHVI.RowCount
    End Sub
    Private Sub BtCargaAccess_Click(sender As Object, e As EventArgs) Handles BtCargaAccess.Click
        importarAccessExterno(DgvPaquetesHVI)
        PropiedadesDGVCarga()
        Inhabilitar()
        NuCantidadPacas.Value = DgvPaquetesHVI.RowCount
    End Sub
    Private Sub Limpiar()
        TbIdPaqueteHVI.Text = ""
        TbNoPacaConsulta.Text = ""
        CbPlanta.SelectedIndex = -1
        NuCantidadPacas.Value = 0
        DtpFecha.Value = Now
        TbPaquete.Text = ""
        TbRuta.Text = ""
        Habilitar()
        DgvPaquetesHVI.DataSource = Nothing
        DgvConsultaLotID.DataSource = Nothing
    End Sub
    Private Sub CargarCombos()
        '---Planta Origen--
        Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
        Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
        Dim Tabla As New DataTable
        EntidadPaquetesHVI.Consulta = Consulta.ConsultaExterna
        NegocioPaquetesHVI.Consultar(EntidadPaquetesHVI)
        Tabla = EntidadPaquetesHVI.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = 1
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("IdEstatus")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("IdEstatus") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("IdEstatus") = "2"
        dr("Descripcion") = "Inactivo"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "IdEstatus"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedValue = 1
    End Sub
    Private Sub PaquetesHVI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        Limpiar()
    End Sub
    'Private Sub AbrirBaseDatosAccess()
    '    Dim bbdd As OleDbConnection
    '    Dim dt As New DataTable
    '    Dim sConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & TbRuta.Text
    '    bbdd = New OleDb.OleDbConnection(sConnString)
    '    bbdd.Open()
    '    Dim ds As DataSet
    '    ds = New DataSet()
    '    Dim cm As OleDbCommand
    '    cm = New OleDbCommand("SELECT * FROM " & "SystemTestData", bbdd)
    '    Dim da As OleDbDataAdapter
    '    da = New OleDbDataAdapter(cm)
    '    da.Fill(ds)
    '    dt = ds.Tables(0)
    '    Dim miView As DataView = New DataView(dt)
    '    miView.Sort = "BaleID asc"
    '    DgvPaquetesHVI.DataSource = dt
    '    TablaPaquetesHVIGlobal = dt
    '    TbPaquete.Text = dt.Rows(0).Item("LotID")
    '    bbdd.Close()
    '    'DgvPaquetesHVI.Sort(DgvPaquetesHVI.Columns("BaleID"), System.ComponentModel.ListSortDirection.Ascending)
    'End Sub
    Private Sub Inhabilitar()
        'TbPaquete.Enabled = False
    End Sub
    Private Function RecorreDT()
        Dim vReturn(1) As String
        Dim Bandera As Boolean = False
        For Each row As DataGridViewRow In DgvPaquetesHVI.Rows
            Dim valor As String = CStr(row.Cells("BaleID").Value)
            vReturn = ExistePacaHVI(valor)
            If vReturn(0) = True Then
                Bandera = True
                'IdEncabezadoExiste = vReturn(1)
            End If
        Next
        Return Bandera
    End Function
    Function ExistePacaHVI(ByVal IdPaca As String)
        Dim Tabla As New DataTable
        'Dim resultado As Boolean
        Dim vReturn(1) As String
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaExisteHVI
        EntidadClasificacionVentaPaquetes.NumeroPaca = IdPaca
        EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        vReturn(0) = Tabla.Rows(0).Item("ExistePaca")
        vReturn(1) = Tabla.Rows(0).Item("IdHviEnc")
        Return vReturn
    End Function
    Private Function ExistePaqueteHVI(ByVal LotID As String)
        Dim Tabla As New DataTable
        'Dim Resultado As Boolean
        Dim vReturn(1) As String
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPaqueteExisteHVI
        EntidadClasificacionVentaPaquetes.LotID = LotID
        EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        vReturn(0) = Tabla.Rows(0).Item("ExistePaquete")
        vReturn(1) = Tabla.Rows(0).Item("IdHviEnc")
        Return vReturn
    End Function
    Private Sub Habilitar()
        TbPaquete.Enabled = True
        BtSeleccionar.Enabled = True
    End Sub
    Private Sub Guardar()
        For Each row As DataGridViewRow In DgvPaquetesHVI.Rows
            Dim vReturn(2) As String
            vReturn = VerificaPacaPlanta(row.Cells("BaleID").Value)
            If vReturn(0) = True And vReturn(1) = CbPlanta.SelectedValue Then

            Else
                MsgBox("La Paca con la etiqueta " & row.Cells("BaleID").Value & " no existe en la planta " & CbPlanta.Text & ", la planta correcta es " & vReturn(2))
                Exit Sub
            End If
        Next
        Try
            Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
            Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
            EntidadPaquetesHVI.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarEncabezado
            EntidadPaquetesHVI.IdPaqueteHVI = IIf(TbIdPaqueteHVI.Text = "", 0, TbIdPaqueteHVI.Text)
            EntidadPaquetesHVI.LotId = TbPaquete.Text
            EntidadPaquetesHVI.NumeroPacas = IIf(NuCantidadPacas.Value > NumeroPacas, NuCantidadPacas.Value, NumeroPacas)
            EntidadPaquetesHVI.IdPlanta = CbPlanta.SelectedValue
            EntidadPaquetesHVI.Fecha = DtpFecha.Value
            EntidadPaquetesHVI.IdEstatus = CbEstatus.SelectedValue
            EntidadPaquetesHVI.IdUsuarioCreacion = 1
            EntidadPaquetesHVI.FechaCreacion = Now
            EntidadPaquetesHVI.IdUsuarioActualizacion = 1
            EntidadPaquetesHVI.FechaActualizacion = Now
            'EntidadPaquetesHVI.TablaGlobal = TablaPaquetesHVIGlobal
            NegocioPaquetesHVI.Guardar(EntidadPaquetesHVI)
            TbIdPaqueteHVI.Text = EntidadPaquetesHVI.IdPaqueteHVI
            GuardarDetalle()
            ObtieneOrdentrabajoPaca()
        Catch ex As Exception
            MsgBox(ex)
        Finally
            NumeroPacas = 0
            MsgBox("Guardado con exito!")
        End Try
    End Sub
    Private Sub GuardarDetalle()
        Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
        Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI

        Try
            For Each Fila As DataGridViewRow In DgvPaquetesHVI.Rows
                EntidadPaquetesHVI.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarDetalle
                EntidadPaquetesHVI.IdPaqueteHVI = Val(TbIdPaqueteHVI.Text)
                EntidadPaquetesHVI.IdPlanta = CbPlanta.SelectedValue
                EntidadPaquetesHVI.LotId = Val(TbPaquete.Text)
                EntidadPaquetesHVI.BaleID = Fila.Cells("BaleID").Value
                EntidadPaquetesHVI.BaleGroup = Fila.Cells("BaleGroup").Value
                EntidadPaquetesHVI.Operatr = Fila.Cells("Operator").Value
                EntidadPaquetesHVI.FechaAn = Fila.Cells("Date").Value
                EntidadPaquetesHVI.Temperature = Fila.Cells("Temperature").Value
                EntidadPaquetesHVI.Humidity = Fila.Cells("Humidity").Value
                EntidadPaquetesHVI.Amount = Fila.Cells("Amount").Value
                EntidadPaquetesHVI.UHML = Fila.Cells("UHML").Value
                EntidadPaquetesHVI.UI = Fila.Cells("UI").Value
                EntidadPaquetesHVI.Strength = Fila.Cells("Strength").Value
                EntidadPaquetesHVI.Elongation = Fila.Cells("Elongation").Value
                EntidadPaquetesHVI.SFI = Fila.Cells("SFI").Value
                EntidadPaquetesHVI.Maturity = Fila.Cells("Maturity").Value
                EntidadPaquetesHVI.Grade = CStr(Fila.Cells("Grade").Value.ToString)
                EntidadPaquetesHVI.Moist = Fila.Cells("Moist").Value
                EntidadPaquetesHVI.Mic = Fila.Cells("Mic").Value
                EntidadPaquetesHVI.Rd = Fila.Cells("Rd").Value
                EntidadPaquetesHVI.Plusb = Fila.Cells("Plusb").Value
                EntidadPaquetesHVI.Colorgrade = Fila.Cells("ColorGrade").Value
                EntidadPaquetesHVI.TrashCount = Fila.Cells("TrashCount").Value
                EntidadPaquetesHVI.TrashArea = Fila.Cells("TrashArea").Value
                EntidadPaquetesHVI.TrashID = Fila.Cells("TrashID").Value
                EntidadPaquetesHVI.SCI = Fila.Cells("SCI").Value
                EntidadPaquetesHVI.Nep = 0 ' Fila.Cells("Nep").Value
                EntidadPaquetesHVI.UV = 0 'Fila.Cells("UV").Value
                NegocioPaquetesHVI.Guardar(EntidadPaquetesHVI)
            Next
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Private Sub ObtieneOrdentrabajoPaca()
        If DgvPaquetesHVI.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPaquetesHVI.Rows
                If Not Fila Is Nothing Then
                    Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
                    Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
                    EntidadPaquetesHVI.IdPlanta = CbPlanta.SelectedValue
                    EntidadPaquetesHVI.BaleID = Fila.Cells("BaleID").Value
                    NegocioPaquetesHVI.GuardarIdOrden(EntidadPaquetesHVI)
                End If
            Next
        End If
    End Sub
    Private Sub ContarFilas()
        NuCantidadPacas.Value = DgvPaquetesHVI.RowCount
        NumeroPacas = DgvPaquetesHVI.RowCount
    End Sub
    Private Sub TbPaquete_KeyDown(sender As Object, e As KeyEventArgs) Handles TbPaquete.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Dim vReturn(1) As String
                If TbPaquete.Text <> "" Then
                    vReturn = ExistePaqueteHVI(TbPaquete.Text)
                    If vReturn(0) = False And vReturn(1) = False Then
                        MsgBox("El paquete consultado no se encuentra registrado!", MsgBoxStyle.Information, "Aviso")
                        TbPaquete.Text = ""
                    Else
                        Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
                        Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
                        EntidadPaquetesHVI.Consulta = Consulta.ConsultaDetallada
                        EntidadPaquetesHVI.IdPaquete = TbPaquete.Text
                        'EntidadPaquetesHVI.IdPlanta = CbPlanta.SelectedValue
                        NegocioPaquetesHVI.Consultar(EntidadPaquetesHVI)
                        TablaPaquetesHVIGlobal = EntidadPaquetesHVI.TablaConsulta
                        DgvPaquetesHVI.DataSource = TablaPaquetesHVIGlobal
                        PropiedadesDGV()
                        If DgvPaquetesHVI.Rows.Count > 0 Then IdentificaEstatusPacas()
                        'BtSeleccionar.Enabled = False
                        TbIdPaqueteHVI.Text = vReturn(1)
                        'If DgvPaquetesHVI.RowCount > 0 Then TbIdPaqueteHVI.Text = DgvPaquetesHVI.Rows(0).Cells("IdHviEnc").Value
                        If DgvPaquetesHVI.RowCount > 0 Then CbPlanta.SelectedValue = DgvPaquetesHVI.Rows(0).Cells("IdPlantaOrigen").Value
                        ContarFilas()
                    End If

                Else
                    MsgBox("El campo Paquete no puede ir vacios.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub DgvPaquetesHVI_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPaquetesHVI.CellEndEdit
        DgvPaquetesHVI.EndEdit()
        Dim ResultadoSCI As Integer = 0
        DgvPaquetesHVI.CurrentRow.Cells("SCI").Value = CalculaSCI(ResultadoSCI)
    End Sub
    Private Function CalculaSCI(ByVal ResultadoSCI As Integer)
        ResultadoSCI = -414.67 + 2.9 * DgvPaquetesHVI.CurrentRow.Cells("Strength").Value - 9.32 * DgvPaquetesHVI.CurrentRow.Cells("Mic").Value + 49.17 * DgvPaquetesHVI.CurrentRow.Cells("UHML").Value + 4.74 * DgvPaquetesHVI.CurrentRow.Cells("UI").Value + 0.65 * DgvPaquetesHVI.CurrentRow.Cells("RD").Value + 0.36 * DgvPaquetesHVI.CurrentRow.Cells("PLUSB").Value
        Return ResultadoSCI
    End Function
    Private Sub IdentificaEstatusPacas()
        For Each fila As DataGridViewRow In DgvPaquetesHVI.Rows
            If fila.Cells("EstatusCompra").Value > 1 Then
                fila.DefaultCellStyle.BackColor = Color.SkyBlue
            End If
            If fila.Cells("Mic").Value > 5.5 Then
                fila.Cells.Item(18).Style.BackColor = btaltaparametros.BackColor
            ElseIf fila.Cells("Mic").Value < 2.5 Then
                fila.Cells.Item(18).Style.BackColor = btbajaparametros.BackColor
            End If
            If fila.Cells("Strength").Value > 29.99 Then
                fila.Cells.Item(12).Style.BackColor = btaltaparametros.BackColor
            ElseIf fila.Cells("Strength").Value < 17.99 Then
                fila.Cells.Item(12).Style.BackColor = btbajaparametros.BackColor
            End If
            If fila.Cells("UHML").Value > 1.36 Then
                fila.Cells.Item(10).Style.BackColor = btaltaparametros.BackColor
            ElseIf fila.Cells("UHML").Value < 0.79 Then
                fila.Cells.Item(10).Style.BackColor = btbajaparametros.BackColor
            End If
            If fila.Cells("UI").Value > 85 Then
                fila.Cells.Item(11).Style.BackColor = btaltaparametros.BackColor
            ElseIf fila.Cells("UI").Value < 77.99 Then
                fila.Cells.Item(11).Style.BackColor = btbajaparametros.BackColor
            End If
        Next
    End Sub
    Private Sub PropiedadesDGV()
        DgvPaquetesHVI.Columns("IdHVIenc").Visible = False
        DgvPaquetesHVI.Columns("IdPlantaOrigen").Visible = False
        DgvPaquetesHVI.Columns("LotID").ReadOnly = True
        DgvPaquetesHVI.Columns("BaleID").ReadOnly = True
        DgvPaquetesHVI.Columns("BaleGroup").ReadOnly = True
        DgvPaquetesHVI.Columns("Operator").ReadOnly = True
        DgvPaquetesHVI.Columns("Date").ReadOnly = True
        DgvPaquetesHVI.Columns("Temperature").ReadOnly = True
        DgvPaquetesHVI.Columns("Humidity").ReadOnly = True
        DgvPaquetesHVI.Columns("Amount").ReadOnly = True
        DgvPaquetesHVI.Columns("UHML").ReadOnly = True
        DgvPaquetesHVI.Columns("UI").ReadOnly = True
        DgvPaquetesHVI.Columns("Strength").ReadOnly = True
        DgvPaquetesHVI.Columns("Elongation").ReadOnly = True
        DgvPaquetesHVI.Columns("SFI").ReadOnly = True
        DgvPaquetesHVI.Columns("Maturity").ReadOnly = True
        DgvPaquetesHVI.Columns("Grade").ReadOnly = True
        DgvPaquetesHVI.Columns("Moist").ReadOnly = True
        DgvPaquetesHVI.Columns("Mic").ReadOnly = True
        DgvPaquetesHVI.Columns("Rd").ReadOnly = True
        DgvPaquetesHVI.Columns("Plusb").ReadOnly = True
        DgvPaquetesHVI.Columns("ColorGrade").ReadOnly = True
        DgvPaquetesHVI.Columns("TrashCount").ReadOnly = True
        DgvPaquetesHVI.Columns("TrashArea").ReadOnly = True
        DgvPaquetesHVI.Columns("TrashID").ReadOnly = True
        DgvPaquetesHVI.Columns("SCI").ReadOnly = True
        DgvPaquetesHVI.Columns("Nep").Visible = False
        DgvPaquetesHVI.Columns("UV").Visible = False
        DgvPaquetesHVI.Columns("EstatusCompra").Visible = False
        'DgvPaquetesHVI.Columns("EstatusPaca").ReadOnly = True
    End Sub
    Private Sub PropiedadesDGVCarga()
        If DgvPaquetesHVI.Columns.Contains("LotID") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("BaleID") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("BaleGroup") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Operator") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Date") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Temperature") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Humidity") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Amount") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("UHML") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("UI") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Strength") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Elongation") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("SFI") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Maturity") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Grade") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Moist") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Mic") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Rd") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("Plusb") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("ColorGrade") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("TrashCount") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("TrashArea") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("TrashID") <> Nothing And
            DgvPaquetesHVI.Columns.Contains("SCI") <> Nothing Then

            DgvPaquetesHVI.Columns("LotID").ReadOnly = True
            DgvPaquetesHVI.Columns("BaleID").ReadOnly = True
            DgvPaquetesHVI.Columns("BaleGroup").ReadOnly = True
            DgvPaquetesHVI.Columns("Operator").ReadOnly = True
            DgvPaquetesHVI.Columns("Date").ReadOnly = True
            DgvPaquetesHVI.Columns("Temperature").ReadOnly = True
            DgvPaquetesHVI.Columns("Humidity").ReadOnly = True
            DgvPaquetesHVI.Columns("Amount").ReadOnly = True
            DgvPaquetesHVI.Columns("UHML").ReadOnly = False
            DgvPaquetesHVI.Columns("UI").ReadOnly = False
            DgvPaquetesHVI.Columns("Strength").ReadOnly = False
            DgvPaquetesHVI.Columns("Elongation").ReadOnly = True
            DgvPaquetesHVI.Columns("SFI").ReadOnly = True
            DgvPaquetesHVI.Columns("Maturity").ReadOnly = True
            DgvPaquetesHVI.Columns("Grade").ReadOnly = True
            DgvPaquetesHVI.Columns("Moist").ReadOnly = True
            DgvPaquetesHVI.Columns("Mic").ReadOnly = False
            DgvPaquetesHVI.Columns("Rd").ReadOnly = False
            DgvPaquetesHVI.Columns("Plusb").ReadOnly = False
            DgvPaquetesHVI.Columns("ColorGrade").ReadOnly = False
            DgvPaquetesHVI.Columns("TrashCount").ReadOnly = True
            DgvPaquetesHVI.Columns("TrashArea").ReadOnly = True
            DgvPaquetesHVI.Columns("TrashID").ReadOnly = False
            DgvPaquetesHVI.Columns("SCI").ReadOnly = True
            DgvPaquetesHVI.Columns("Nep").Visible = False
            DgvPaquetesHVI.Columns("UV").Visible = False
            DgvPaquetesHVI.Sort(DgvPaquetesHVI.Columns("BaleID"), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub
    Private Sub MatExtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatExtToolStripMenuItem.Click
        MatExtCompras.ShowDialog()
    End Sub
    Private Sub consultaLotIdPorPaca()
        Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
        Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
        Dim Tabla As New DataTable
        EntidadPaquetesHVI.Consulta = Consulta.ConsultaLotIDPorPaca
        EntidadPaquetesHVI.BaleID = Val(TbNoPacaConsulta.Text)
        NegocioPaquetesHVI.Consultar(EntidadPaquetesHVI)
        Tabla = EntidadPaquetesHVI.TablaConsulta
        DgvConsultaLotID.DataSource = Tabla
    End Sub
    Private Sub TbNoPacaConsulta_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNoPacaConsulta.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                consultaLotIdPorPaca()
        End Select
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class
