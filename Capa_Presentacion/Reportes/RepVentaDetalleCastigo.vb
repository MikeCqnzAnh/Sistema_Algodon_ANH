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
Imports Excel = Microsoft.Office.Interop.Excel
Public Class RepVentaDetalleCastigo
    Dim IdVenta As Integer
    Public Sub New(ByVal Id As Integer)
        InitializeComponent()
        IdVenta = Id
    End Sub
    Private Sub RepCompraPacasResumen_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConsultaReporte()
    End Sub
    Private Sub ConsultaReporte()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTVentaDetalleCastigos = New RPTVentaDetalleCastigos
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTVentaDetalleCastigos.rpt"
        EntidadReportes.Reporte = Reporte.ReporteVentaDetalleCastigo
        EntidadReportes.IdVenta = IdVenta
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVVentaDetalleCastigo.ReportSource = CrReport
        CRVVentaDetalleCastigo.Show()
    End Sub
    Private Sub ExportarAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes

        'Needed for the Excel Workbook/WorkSheet(s)
        Dim app As New Excel.Application
        Dim wb As Excel.Workbook = app.Workbooks.Add()
        Dim ws As Excel.Worksheet

        Dim strFN As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\datos\Detalle castigo venta " & IdVenta & ".xlsx"   'must have ".xlsx" extension

        'Standard code for filling a DataTable from SQL Server
        Dim strSym As String = "Detalle Castigo"
        Dim MyTable As New DataTable

        EntidadReportes.Reporte = Reporte.ReporteVentaDetalleCastigo
        EntidadReportes.IdVenta = IdVenta
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
        ws.Range(ws.Cells(2, 1), ws.Cells(dt.Rows.Count, dt.Columns.Count)).Value = arr
    End Sub
End Class