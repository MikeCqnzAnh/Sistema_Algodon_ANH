﻿Imports Capa_Operacion.Configuracion
Imports System.IO
Imports System.Data.OleDb
Public Class PaquetesHVI
    Public TablaPaquetesHVIGlobal As DataTable
    'Public Paquete As Integer
    Public NumeroPacas As Integer
    'Dim IdEncabezadoExiste As Integer
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
        'Call ShowDialog.
        OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Access Database (*.mdb)|*.mdb| & All Files|*.*"
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Dim path As String = OpenFileDialog1.FileName
                TbRuta.Text = path
                AbrirBaseDatosAccess()
                Inhabilitar()
            NuCantidadPacas.Value = DgvPaquetesHVI.RowCount
        End If
        End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If CbPlanta.Text <> "" Or TbPaquete.Text <> "" Then
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
                    BtSeleccionar.Enabled = False
                End If
            Else
                MsgBox("Por favor, cargar la base de datos de access.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("Campo Planta y Paquete es requerido para continuar.", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub
    Private Sub Limpiar()
        TbIdPaqueteHVI.Text = ""
        CbPlanta.SelectedIndex = -1
        NuCantidadPacas.Value = 0
        DtpFecha.Value = Now
        TbPaquete.Text = ""
        TbRuta.Text = ""
        Habilitar()
        DgvPaquetesHVI.DataSource = Nothing
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
    Private Sub AbrirBaseDatosAccess()
        Dim bbdd As OleDbConnection
        Dim dt As New DataTable
        Dim sConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & TbRuta.Text
        bbdd = New OleDb.OleDbConnection(sConnString)
        bbdd.Open()
        Dim ds As DataSet
        ds = New DataSet()
        Dim cm As OleDbCommand
        cm = New OleDbCommand("SELECT * FROM " & "SystemTestData", bbdd)
        Dim da As OleDbDataAdapter
        da = New OleDbDataAdapter(cm)
        da.Fill(ds)
        dt = ds.Tables(0)
        Dim miView As DataView = New DataView(dt)
        miView.Sort = "BaleID asc"
        DgvPaquetesHVI.DataSource = dt
        TablaPaquetesHVIGlobal = dt
        TbPaquete.Text = dt.Rows(0).Item("LotID")
        bbdd.Close()
        'DgvPaquetesHVI.Sort(DgvPaquetesHVI.Columns("BaleID"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
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
        Try
            Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
            Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
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
            EntidadPaquetesHVI.TablaGlobal = TablaPaquetesHVIGlobal
            NegocioPaquetesHVI.Guardar(EntidadPaquetesHVI)
            TbIdPaqueteHVI.Text = EntidadPaquetesHVI.IdPaqueteHVI
            ObtieneOrdentrabajoPaca()
        Catch ex As Exception
            MsgBox(ex)
        Finally
            NumeroPacas = 0
            MsgBox("Guardado con exito!")
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
                        'BtSeleccionar.Enabled = False
                        If DgvPaquetesHVI.RowCount > 0 Then TbIdPaqueteHVI.Text = DgvPaquetesHVI.Rows(0).Cells("IdHviEnc").Value
                        If DgvPaquetesHVI.RowCount > 0 Then CbPlanta.SelectedValue = DgvPaquetesHVI.Rows(0).Cells("IdPlantaOrigen").Value
                        ContarFilas()
                    End If

                Else
                    MsgBox("El campo Paquete no puede ir vacios.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub PropiedadesDGV()
        DgvPaquetesHVI.Columns("IdHVIenc").Visible = False
        DgvPaquetesHVI.Columns("IdPlantaOrigen").Visible = False
        DgvPaquetesHVI.Sort(DgvPaquetesHVI.Columns("BaleID"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class