Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
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
Imports Excel = Microsoft.Office.Interop.Excel
Public Class RepConsultaPacasDetalleVenta
    Private Sub RepConsultaPacasDetalleVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        Consultar()
    End Sub
    Private Sub Consultar()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTPacasDetalleVenta = New RPTPacasDetalleVenta
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTPacasDetalleVenta.rpt"
        EntidadReportes.Reporte = Reporte.ReportePacaDetalleVenta
        EntidadReportes.FolioCia = Val(TbPaca.Text)
        EntidadReportes.IdOrdenTrabajo = Val(TbIdOrdenTrabajo.Text)
        EntidadReportes.IdLiquidacionRomaneaje = Val(TbIdLiquidacion.Text)
        EntidadReportes.IdVenta = Val(TbIdVenta.Text)
        EntidadReportes.IdPlanta = CbPlanta.SelectedValue
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVReportePacasDetalleVenta.ReportSource = CrReport
        CRVReportePacasDetalleVenta.Show()
    End Sub
    Private Sub CargaCombos()
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
    End Sub
    Private Sub SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbPaca.KeyPress, TbIdVenta.KeyPress, TbIdOrdenTrabajo.KeyPress, TbIdLiquidacion.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub ExportaAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportaAExcelToolStripMenuItem.Click
        ExportarExcel()
    End Sub
    Private Sub ExportarExcel()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes

        'Needed for the Excel Workbook/WorkSheet(s)
        Dim app As New Excel.Application
        Dim wb As Excel.Workbook = app.Workbooks.Add()
        Dim ws As Excel.Worksheet
        If Not Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\SIA Export PacaDetalle excel" & "\" & BaseDeDatos) Then
            Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\SIA Export PacaDetalle excel" & "\" & BaseDeDatos)
        End If
        Dim strFN As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\SIA Export PacaDetalle excel" & "\" & BaseDeDatos & "\Detalle_Paca_Venta" & Now.DayOfYear & Now.Month & ".xlsx"   'must have ".xlsx" extension

        'Standard code for filling a DataTable from SQL Server
        Dim strSym As String = "Detalle Pacas"
        Dim MyTable As New DataTable

        EntidadReportes.Reporte = Reporte.ReportePacaDetalleVenta
        EntidadReportes.FolioCia = Val(TbPaca.Text)
        EntidadReportes.IdOrdenTrabajo = Val(TbIdOrdenTrabajo.Text)
        EntidadReportes.IdLiquidacionRomaneaje = Val(TbIdLiquidacion.Text)
        EntidadReportes.IdVenta = Val(TbIdVenta.Text)
        EntidadReportes.IdPlanta = CbPlanta.SelectedValue
        NegocioReportes.Consultar(EntidadReportes)
        MyTable = EntidadReportes.TablaConsulta
        'Add a sheet to the workbook and fill it with data from MyTable
        'You could create multiple tables and add additional sheets in a loop
        ws = wb.Sheets.Add(After:=wb.Sheets(wb.Sheets.Count))
        DataTableToExcel(MyTable, ws, strSym)
        If System.IO.File.Exists(strFN) Then
            System.IO.File.Delete(strFN)
        End If

        wb.SaveAs(strFN)    'save and close the WorkBook
        wb.Close()
        MsgBox("Exportacion completada.")
        System.Diagnostics.Process.Start(strFN)
    End Sub
    Private Sub DataTableToExcel(dt As DataTable, ws As Excel.Worksheet, TabName As String)
        Dim arr(dt.Rows.Count, dt.Columns.Count) As Object
        Dim r As Int32, c As Int32
        'copy the datatable to an array
        For r = 0 To dt.Rows.Count - 1
            For c = 0 To dt.Columns.Count - 1
                arr(r, c) = dt.Rows(r).Item(c)
            Next
        Next

        ws.Cells.NumberFormat = "@"
        ws.Name = TabName   'name the worksheet
        'add the column headers starting in A1
        c = 0
        For Each column As DataColumn In dt.Columns
            ws.Cells(1, c + 1) = column.ColumnName
            c += 1
        Next
        'add the data starting in cell A2
        ws.Range(ws.Cells(2, 1), ws.Cells(dt.Rows.Count + 1, dt.Columns.Count)).Value = arr
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class