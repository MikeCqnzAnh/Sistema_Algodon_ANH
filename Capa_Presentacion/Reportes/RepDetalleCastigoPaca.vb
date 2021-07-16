Imports Capa_Operacion.Configuracion
Imports Excel = Microsoft.Office.Interop.Excel
Public Class RepDetalleCastigoPaca
    Dim IdVenta As Integer
    Dim IdMicCastigo As Integer
    Dim IdLarCastigo As Integer
    Dim IdResCastigo As Integer
    Dim IDUICastigo As Integer
    Dim IdUni As Integer
    Dim ValUnidad As Decimal
    Dim CheckMicro As Boolean
    Dim CheckLargo As Boolean
    Dim CheckResistencia As Boolean
    Dim CheckUniformidad As Boolean
    Public Sub New(ByVal IdVen As Integer, ByVal IdMicroCastigo As Integer, ByVal IdLargoCastigo As Integer, ByVal IdResistenciaCastigo As Integer, ByVal IdUniformidadCastigo As Integer, ByVal IdUnidad As Integer, ByVal ValorUnidad As Decimal, ByVal ChkMicro As Boolean, ByVal ChkLargo As Boolean, ByVal ChkRes As Boolean, ChkUi As Boolean)
        InitializeComponent()
        IdVenta = IdVen
        IdMicCastigo = IdMicroCastigo
        IdLarCastigo = IdLargoCastigo
        IdResCastigo = IdResistenciaCastigo
        IDUICastigo = IdUniformidadCastigo
        IdUni = IdUnidad
        ValUnidad = ValorUnidad
        CheckMicro = ChkMicro
        CheckLargo = ChkLargo
        CheckResistencia = ChkRes
        CheckUniformidad = ChkUi
    End Sub
    Private Sub RepDetalleCastigoPaca_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombosParametros()
        CargaCombos()
        TbIdVenta.Text = IdVenta
        CbModoMicros.SelectedValue = IdMicCastigo
        CbModoLargoFibra.SelectedValue = IdLarCastigo
        CbModoResistenciaFibra.SelectedValue = IdResCastigo
        CbModoUniformidad.SelectedValue = IDUICastigo
        CbUnidadPeso.SelectedValue = IdUni
        TbValorConversion.Text = ValUnidad
        ChMicros.Checked = CheckMicro
        ChLargoFibra.Checked = CheckLargo
        ChResistenciaFibra.Checked = CheckResistencia
        ChUniformidad.Checked = CheckUniformidad
        consultar()
    End Sub

    Private Sub CargaCombosParametros()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        '------------------------COMBO MICROS VENTA
        Dim Tabla2 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaMicrosVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla2 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoMicros.DataSource = Tabla2
        CbModoMicros.ValueMember = "IdModoEncabezado"
        CbModoMicros.DisplayMember = "Descripcion"
        CbModoMicros.SelectedIndex = 0
        '------------------------COMBO LARGO FIBRA VENTA
        Dim Tabla3 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaLargoFibraVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla3 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoLargoFibra.DataSource = Tabla3
        CbModoLargoFibra.ValueMember = "IdModoEncabezado"
        CbModoLargoFibra.DisplayMember = "Descripcion"
        CbModoLargoFibra.SelectedIndex = 0
        '------------------------COMBO RESISTENCIA VENTA
        Dim Tabla4 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaResistenciaVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla4 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoResistenciaFibra.DataSource = Tabla4
        CbModoResistenciaFibra.ValueMember = "IdModoEncabezado"
        CbModoResistenciaFibra.DisplayMember = "Descripcion"
        CbModoResistenciaFibra.SelectedIndex = 0
        '------------------------COMBO UNIFORMIDAD VENTA
        Dim Tabla5 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaUniformidadVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla5 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoUniformidad.DataSource = Tabla5
        CbModoUniformidad.ValueMember = "IdModoEncabezado"
        CbModoUniformidad.DisplayMember = "Descripcion"
        CbModoUniformidad.SelectedIndex = 0
    End Sub
    Private Sub CargaCombos()
        '-------------------------COMBO UNIDAD PESO
        Dim Tabla1 As New DataTable
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaUnidadPeso
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla1 = EntidadContratosAlgodon.TablaConsulta
        CbUnidadPeso.DataSource = Tabla1
        CbUnidadPeso.ValueMember = "IdUnidadPeso"
        CbUnidadPeso.DisplayMember = "Descripcion"
        CbUnidadPeso.SelectedValue = -1
    End Sub

    Private Sub consultar()
        Dim Tabla1 As New DataTable
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaDetallesCastigoPacas
        EntidadVentaPacasContrato.IdVenta = Val(TbIdVenta.Text)
        EntidadVentaPacasContrato.IdModoMic = CbModoMicros.SelectedValue
        EntidadVentaPacasContrato.IdModoRes = CbModoResistenciaFibra.SelectedValue
        EntidadVentaPacasContrato.IdModoUI = CbModoUniformidad.SelectedValue
        EntidadVentaPacasContrato.IdModoLargo = CbModoLargoFibra.SelectedValue
        EntidadVentaPacasContrato.IdUnidadPeso = CbUnidadPeso.SelectedValue
        EntidadVentaPacasContrato.CkMic = ChMicros.Checked
        EntidadVentaPacasContrato.CkRes = ChResistenciaFibra.Checked
        EntidadVentaPacasContrato.CkUI = ChUniformidad.Checked
        EntidadVentaPacasContrato.CkLargo = ChLargoFibra.Checked
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        Tabla1 = EntidadVentaPacasContrato.TablaConsulta

        'For Each row As DataRow In Tabla1.Rows
        '    Dim suma1 As Decimal
        '    suma1 = row("")
        'Next

        DgvPacas.DataSource = Tabla1

        PropiedadesDGV()
    End Sub
    Private Sub PropiedadesDGV()

        DgvPacas.Columns("Kilos").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Mic").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Micro Castigo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Mic Resultado Castigo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Mic Rango 1").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Mic Rango 2").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DgvPacas.Columns("Resistencia").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Resistencia Castigo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Res Resultado Castigo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Res Rango 1").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Res Rango 2").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DgvPacas.Columns("Uniformidad").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("UI Castigo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("UI Resultado Castigo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("UI Rango 1").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("UI Rango 2").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DgvPacas.Columns("Largo de Fibra").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Largo Castigo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Largo Resultado Castigo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Largo Rango 1").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvPacas.Columns("Largo Rango 2").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DgvPacas.Columns("Kilos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Mic").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Micro Castigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Mic Resultado Castigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Mic Rango 1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Mic Rango 2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgvPacas.Columns("Resistencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Resistencia Castigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Res Resultado Castigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Res Rango 1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Res Rango 2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgvPacas.Columns("Uniformidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("UI Castigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("UI Resultado Castigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("UI Rango 1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("UI Rango 2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgvPacas.Columns("Largo de Fibra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Largo Castigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Largo Resultado Castigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Largo Rango 1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvPacas.Columns("Largo Rango 2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        If DgvPacas.Columns.Contains("Quintales") Then
            DgvPacas.Columns("Quintales").DefaultCellStyle.Format = "###,##0.00"
            DgvPacas.Columns("Quintales").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvPacas.Columns("Quintales").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ElseIf DgvPacas.Columns.Contains("libras") Then
            DgvPacas.Columns("libras").DefaultCellStyle.Format = "###,##0.0000"
            DgvPacas.Columns("libras").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvPacas.Columns("libras").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        DgvPacas.Columns("Kilos").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Mic").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Micro Castigo").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Mic Resultado Castigo").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Mic Rango 1").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Mic Rango 2").DefaultCellStyle.Format = "###,##0.00"

        DgvPacas.Columns("Resistencia").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Resistencia Castigo").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Res Resultado Castigo").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Res Rango 1").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Res Rango 2").DefaultCellStyle.Format = "###,##0.00"

        DgvPacas.Columns("Uniformidad").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("UI Castigo").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("UI Resultado Castigo").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("UI Rango 1").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("UI Rango 2").DefaultCellStyle.Format = "###,##0.00"

        DgvPacas.Columns("Largo de Fibra").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Largo Castigo").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Largo Resultado Castigo").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Largo Rango 1").DefaultCellStyle.Format = "###,##0.00"
        DgvPacas.Columns("Largo Rango 2").DefaultCellStyle.Format = "###,##0.00"

    End Sub
    Private Sub ExportarAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato

        'Needed for the Excel Workbook/WorkSheet(s)
        Dim app As New Excel.Application
        Dim wb As Excel.Workbook = app.Workbooks.Add()
        Dim ws As Excel.Worksheet

        Dim strFN As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\datos\Detalle castigo por paca venta " & IdVenta & ".xlsx"   'must have ".xlsx" extension

        'Standard code for filling a DataTable from SQL Server
        Dim strSym As String = "Detalle castigo por paca"
        Dim MyTable As New DataTable

        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaDetallesCastigoPacas
        EntidadVentaPacasContrato.IdVenta = Val(TbIdVenta.Text)
        EntidadVentaPacasContrato.IdModoMic = CbModoMicros.SelectedValue
        EntidadVentaPacasContrato.IdModoRes = CbModoResistenciaFibra.SelectedValue
        EntidadVentaPacasContrato.IdModoUI = CbModoUniformidad.SelectedValue
        EntidadVentaPacasContrato.IdModoLargo = CbModoLargoFibra.SelectedValue
        EntidadVentaPacasContrato.IdUnidadPeso = CbUnidadPeso.SelectedValue
        EntidadVentaPacasContrato.CkMic = ChMicros.Checked
        EntidadVentaPacasContrato.CkRes = ChResistenciaFibra.Checked
        EntidadVentaPacasContrato.CkUI = ChUniformidad.Checked
        EntidadVentaPacasContrato.CkLargo = ChLargoFibra.Checked
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        MyTable = EntidadVentaPacasContrato.TablaConsulta
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
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class
