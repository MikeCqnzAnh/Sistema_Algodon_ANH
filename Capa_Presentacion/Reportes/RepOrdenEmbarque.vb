Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class RepOrdenEmbarque
    Dim IdEmbarque As Integer
    Public Sub New(ByVal IdEmb As Integer)
        InitializeComponent()
        IdEmbarque = IdEmb
    End Sub
    Private Sub Limpiar()
        TbIdEmbarque.Text = ""
        CbNoLote.SelectedValue = 0
        'CRVOrdenEmbarque.ReportSource = ""
    End Sub
    Private Sub RepOrdenEmbarque_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
        TbIdEmbarque.Text = IdEmbarque
        CargaComboEmbarque()
        'ObtenerDatosEncabezado()
    End Sub
    Private Sub ObtenerDatosEncabezado()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Dim Tabla As New DataTable
        EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = TbIdEmbarque.Text
        EntidadOrdenEmbarquePacas.NombreComprador = ""
        EntidadOrdenEmbarquePacas.Consulta = Capa_Operacion.Configuracion.Consulta.ConsultaEmbarqueEncabezado
        NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
        Tabla = EntidadOrdenEmbarquePacas.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        If Tabla.Rows(0).Item("CantidadCajas") = 1 Then
            CargaCombo(Tabla.Rows(0).Item("CantidadCajas"), Tabla.Rows(0).Item("NoLote1"))
        ElseIf Tabla.Rows(0).Item("CantidadCajas") = 2 Then
            CargaCombo(Tabla.Rows(0).Item("CantidadCajas"), Tabla.Rows(0).Item("NoLote1"), Tabla.Rows(0).Item("NoLote2"))
        End If
    End Sub
    Private Sub CargaComboEmbarque()
        Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
        Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
        Dim Tabla As New DataTable
        Try
            EntidadOrdenEmbarquePacas.Consulta = Capa_Operacion.Configuracion.Consulta.ConsultaComboEmbarqueLotes
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = TbIdEmbarque.Text
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            Tabla = EntidadOrdenEmbarquePacas.TablaConsulta
            CbNoLote.DataSource = Tabla
            CbNoLote.ValueMember = "IdEmbarqueDet"
            CbNoLote.DisplayMember = "Nolote"
            CbNoLote.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            CbNoLote.SelectedIndex = 0
        Else
            dr = dt.NewRow()
            dr("IdLote") = "1"
            dr("DescripcionLote") = NoLote1
            dt.Rows.Add(dr)
            CbNoLote.DataSource = dt
            CbNoLote.ValueMember = "IdLote"
            CbNoLote.DisplayMember = "DescripcionLote"
            CbNoLote.SelectedIndex = 0
        End If
    End Sub
    Private Sub Consulta()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New Data.DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTOrdenEmbarque = New RPTOrdenEmbarque
        Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Reportes\RPT\RPTOrdenEmbarque.rpt"
        EntidadReportes.Reporte = Reporte.ReporteOrdenEmbarque
        EntidadReportes.IdEmbarqueEncabezado = TbIdEmbarque.Text
        EntidadReportes.NoLote = CbNoLote.Text
        EntidadReportes.CheckStatus = ChKilos.Checked
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVOrdenEmbarque.ReportSource = CrReport
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Consulta()
    End Sub
End Class