Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
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
Public Class RepClasificacion
    Dim IdPaquete, IdPlanta As Integer
    Public Sub New(ByVal Idpaq As Integer, ByVal IdPla As Integer)
        InitializeComponent()
        IdPaquete = Idpaq
        IdPlanta = IdPla
    End Sub
    Private Sub RepClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla, TablaGeneral As New Data.DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTHviDetalle = New RPTHviDetalle
        Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Reportes\RPT\RPTHviDetalle.rpt"
        EntidadReportes.Reporte = Reporte.ReporteHviDetalle
        EntidadReportes.IdPaquete = IdPaquete
        EntidadReportes.IdPlanta = IdPlanta
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)

        'EntidadReportes.Reporte = Reporte.ReporteLiquidacionRomaneajeDet
        'EntidadReportes.IdOrdenTrabajo = IdOrdenTrabajo
        'EntidadReportes.CheckStatus = CheckStatus
        'NegocioReportes.Consultar(EntidadReportes)
        'TablaGeneral = EntidadReportes.TablaGeneral
        'ds.Tables.Add(TablaGeneral)

        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        'CrReport.Subreports("SubReporteRomaneaje").SetDataSource(ds.Tables("Table2"))
        CRVHviDetalle.ReportSource = CrReport
    End Sub
    Private Sub exportaHVIexcel(ByVal TablaExporta As Data.DataTable)

        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        'Iniciar un nuevo libro en Excel

        oExcel = CreateObject("Excel.Application")


        oBook = oExcel.Workbooks.Add

        'Agregar datos a las celdas de la primera hoja en el libro nuevo

        oSheet = oBook.Worksheets(1)
        With oSheet
            .Cells.NumberFormat = "@"
        End With

        ' Datos de Encabezado
        oSheet.Range("A1").Value = "ALGODONERA NUEVA HOLANDA S.P.R. DE R.L. DE C.V."
        oSheet.Range("A2").Value = "System Testing - Individual Tests"
        oSheet.Range("C4").Value = "Lot ID"
        oSheet.Range("C5").Value = "Operator"
        oSheet.Range("C6").Value = "Print Date"
        oSheet.Range("C7").Value = "Print Time"
        oSheet.Range("C8").Value = "Short/Weak Reference"

        oSheet.Range("I2").Value = "USTER ®"
        oSheet.Range("J2").Value = "HVI"
        oSheet.Range("I2:J2").Font.ColorIndex = 3
        oSheet.Range("I2:J2").Font.Size = 18
        oSheet.Range("I2:J2").Font.FontStyle = "Bold"
        oSheet.Range("J2").Font.FontStyle = "Italic"

        oSheet.Range("H4").Value = "Catalog"
        oSheet.Range("H5").Value = "HVI SW Version"
        oSheet.Range("H6").Value = "Serial Number"
        oSheet.Range("H7").Value = "Test Mode"
        oSheet.Range("H8").Value = "Long/Strong Reference"

        ' Formato Encabezado
        oSheet.Range("C4:C8").Font.FontStyle = "Bold"
        oSheet.Range("C4:C8").HorizontalAlignment = Constants.xlRight
        oSheet.Range("H4:H8").Font.FontStyle = "Bold"
        oSheet.Range("H4:H8").HorizontalAlignment = Constants.xlRight
        'oSheet.Range("A2").Font.FontStyle = "Bold"
        'oSheet.Range("C4").Font.FontStyle = "Bold"
        'oSheet.Range("C5").Font.FontStyle = "Bold"
        'oSheet.Range("C6").Font.FontStyle = "Bold"
        'oSheet.Range("C7").Font.FontStyle = "Bold"

        oSheet.Range("A2").Font.ColorIndex = 3
        ' Columnas

        oSheet.Range("B10").Value = "Bale ID"
        oSheet.Range("C10").Value = "SCI"
        oSheet.Range("D10").Value = "GRADE"
        oSheet.Range("E10").Value = "MST"
        oSheet.Range("F10").Value = "MIC"
        oSheet.Range("G10").Value = "MAT"
        oSheet.Range("H10").Value = "UHML"
        oSheet.Range("I10").Value = "UI"
        oSheet.Range("J10").Value = "SF"
        oSheet.Range("K10").Value = "STR"
        oSheet.Range("L10").Value = "ELG"
        oSheet.Range("M10").Value = "RD"
        oSheet.Range("N10").Value = "+B"
        oSheet.Range("O10").Value = "CGRD"
        oSheet.Range("P10").Value = "TRCNT"
        oSheet.Range("Q10").Value = "TRAR"
        oSheet.Range("R10").Value = "TRID"
        oSheet.Range("S10").Value = "AMT"
        ' Formato Columnas
        oSheet.Range("B10:S10").Font.FontStyle = "Bold"

        'Desde aqui empezaremos a exportar la lista

        If TablaExporta.Rows.Count > 0 Then

            ' primero verificamos cuantas filas tiene la lista
            'Dim TablaCalculos As Data.DataTable
            Dim col As Integer = 11 'empezaremos en el libro de excel a partir de la celda 11
            Dim ii As Integer ' for para empezar a recorrer la lista

            For ii = 0 To TablaExporta.Rows.Count

                If ii = TablaExporta.Rows.Count Then

                    Exit For

                End If

                ' estas son las columnas que usaremos y el contador nos ira cargando una a una cada fila
                Dim a As String = "A" + col.ToString + ""
                Dim b As String = "B" + col.ToString + ""
                Dim c As String = "C" + col.ToString + ""
                Dim d As String = "D" + col.ToString + ""
                Dim e As String = "E" + col.ToString + ""
                Dim f As String = "F" + col.ToString + ""
                Dim g As String = "G" + col.ToString + ""
                Dim h As String = "H" + col.ToString + ""
                Dim i As String = "I" + col.ToString + ""
                Dim j As String = "J" + col.ToString + ""
                Dim k As String = "K" + col.ToString + ""
                Dim l As String = "L" + col.ToString + ""
                Dim m As String = "M" + col.ToString + ""
                Dim n As String = "N" + col.ToString + ""
                Dim o As String = "O" + col.ToString + ""
                Dim p As String = "P" + col.ToString + ""
                Dim q As String = "Q" + col.ToString + ""
                Dim r As String = "R" + col.ToString + ""
                Dim s As String = "S" + col.ToString + ""

                oSheet.Range(a).Value = TablaExporta.Rows(ii).Item("LotID").ToString
                oSheet.Range(b).Value = TablaExporta.Rows(ii).Item("BaleID").ToString
                oSheet.Range(c).Value = TablaExporta.Rows(ii).Item("SCI").ToString
                oSheet.Range(d).Value = TablaExporta.Rows(ii).Item("Grade").ToString
                oSheet.Range(e).Value = TablaExporta.Rows(ii).Item("Moist").ToString
                oSheet.Range(f).Value = TablaExporta.Rows(ii).Item("Mic").ToString
                oSheet.Range(g).Value = TablaExporta.Rows(ii).Item("Maturity").ToString
                oSheet.Range(h).Value = TablaExporta.Rows(ii).Item("UHML").ToString
                oSheet.Range(i).Value = TablaExporta.Rows(ii).Item("UI").ToString
                oSheet.Range(j).Value = TablaExporta.Rows(ii).Item("SFI").ToString
                oSheet.Range(k).Value = TablaExporta.Rows(ii).Item("Strength").ToString
                oSheet.Range(l).Value = TablaExporta.Rows(ii).Item("Elongation").ToString
                oSheet.Range(m).Value = TablaExporta.Rows(ii).Item("RD").ToString
                oSheet.Range(n).Value = TablaExporta.Rows(ii).Item("PlusB").ToString
                oSheet.Range(o).Value = TablaExporta.Rows(ii).Item("ColorGrade").ToString
                oSheet.Range(p).Value = TablaExporta.Rows(ii).Item("TrashCount").ToString
                oSheet.Range(q).Value = TablaExporta.Rows(ii).Item("TrashArea").ToString
                oSheet.Range(r).Value = TablaExporta.Rows(ii).Item("TrashID").ToString
                oSheet.Range(s).Value = TablaExporta.Rows(ii).Item("Amount").ToString

                oSheet.Range(e).NumberFormat = "#0.00"
                oSheet.Range(f).NumberFormat = "#0.00"
                oSheet.Range(g).NumberFormat = "#0.00"
                oSheet.Range(h).NumberFormat = "#0.00"
                oSheet.Range(i).NumberFormat = "#0.00"
                oSheet.Range(j).NumberFormat = "#0.00"
                oSheet.Range(k).NumberFormat = "#0.00"
                oSheet.Range(l).NumberFormat = "#0.00"
                oSheet.Range(m).NumberFormat = "#0.00"
                oSheet.Range(n).NumberFormat = "#0.00"
                oSheet.Range(q).NumberFormat = "#0.00"

                col = col + 1
                ' removemos cada el elemento esto es solo si desean hacerlo
                'TablaExporta.Rows.Remove(TablaExporta.Rows.Item(ii))
                ' otra opcion es poner el contador positivo y no eliminar el elemento de la lista

                'ii = ii - 1

            Next


            col = col + 2

            Dim colformato As Integer = col
            oSheet.Range("A" + colformato.ToString + "").value = "Average"
            oSheet.Range("A" + colformato.ToString + "").Font.FontStyle = "Bold"
            colformato = colformato + 1
            oSheet.Range("A" + colformato.ToString + "").value = "Std.Dev."
            oSheet.Range("A" + colformato.ToString + "").Font.FontStyle = "Bold"
            colformato = colformato + 1
            oSheet.Range("A" + colformato.ToString + "").value = "CV%"
            oSheet.Range("A" + colformato.ToString + "").Font.FontStyle = "Bold"
            colformato = colformato + 1
            oSheet.Range("A" + colformato.ToString + "").value = "Q99% +/-"
            oSheet.Range("A" + colformato.ToString + "").Font.FontStyle = "Bold"
            colformato = colformato + 1
            oSheet.Range("A" + colformato.ToString + "").value = "Min"
            oSheet.Range("A" + colformato.ToString + "").Font.FontStyle = "Bold"
            colformato = colformato + 1
            oSheet.Range("A" + colformato.ToString + "").value = "Max"
            oSheet.Range("A" + colformato.ToString + "").Font.FontStyle = "Bold"

            oSheet.Range("B" + col.ToString + "").value = PromedioColumna(TablaExporta, 1)
            oSheet.Range("C" + col.ToString + "").value = PromedioColumna(TablaExporta, 2)
            oSheet.Range("E" + col.ToString + "").value = PromedioColumna(TablaExporta, 4)
            oSheet.Range("F" + col.ToString + "").value = PromedioColumna(TablaExporta, 5)
            oSheet.Range("G" + col.ToString + "").value = PromedioColumna(TablaExporta, 6)
            oSheet.Range("H" + col.ToString + "").value = PromedioColumna(TablaExporta, 7)
            oSheet.Range("I" + col.ToString + "").value = PromedioColumna(TablaExporta, 8)
            oSheet.Range("J" + col.ToString + "").value = PromedioColumna(TablaExporta, 9)
            oSheet.Range("K" + col.ToString + "").value = PromedioColumna(TablaExporta, 10)
            oSheet.Range("L" + col.ToString + "").value = PromedioColumna(TablaExporta, 11)
            oSheet.Range("M" + col.ToString + "").value = PromedioColumna(TablaExporta, 12)
            oSheet.Range("N" + col.ToString + "").value = PromedioColumna(TablaExporta, 13)
            oSheet.Range("P" + col.ToString + "").value = PromedioColumna(TablaExporta, 15)
            oSheet.Range("Q" + col.ToString + "").value = PromedioColumna(TablaExporta, 16)
            oSheet.Range("R" + col.ToString + "").value = PromedioColumna(TablaExporta, 17)
            oSheet.Range("S" + col.ToString + "").value = PromedioColumna(TablaExporta, 18)

            oSheet.Range("B" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("C" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("E" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("F" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("G" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("H" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("I" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("J" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("K" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("L" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("M" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("N" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("P" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("Q" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("R" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("S" + col.ToString + "").NumberFormat = "#0.00"

            col = col + 1

            oSheet.Range("B" + col.ToString + "").value = DesviacionColumna(TablaExporta, 1)
            oSheet.Range("C" + col.ToString + "").value = DesviacionColumna(TablaExporta, 2)
            oSheet.Range("E" + col.ToString + "").value = DesviacionColumna(TablaExporta, 4)
            oSheet.Range("F" + col.ToString + "").value = DesviacionColumna(TablaExporta, 5)
            oSheet.Range("G" + col.ToString + "").value = DesviacionColumna(TablaExporta, 6)
            oSheet.Range("H" + col.ToString + "").value = DesviacionColumna(TablaExporta, 7)
            oSheet.Range("I" + col.ToString + "").value = DesviacionColumna(TablaExporta, 8)
            oSheet.Range("J" + col.ToString + "").value = DesviacionColumna(TablaExporta, 9)
            oSheet.Range("K" + col.ToString + "").value = DesviacionColumna(TablaExporta, 10)
            oSheet.Range("L" + col.ToString + "").value = DesviacionColumna(TablaExporta, 11)
            oSheet.Range("M" + col.ToString + "").value = DesviacionColumna(TablaExporta, 12)
            oSheet.Range("N" + col.ToString + "").value = DesviacionColumna(TablaExporta, 13)
            oSheet.Range("P" + col.ToString + "").value = DesviacionColumna(TablaExporta, 15)
            oSheet.Range("Q" + col.ToString + "").value = DesviacionColumna(TablaExporta, 16)
            oSheet.Range("R" + col.ToString + "").value = DesviacionColumna(TablaExporta, 17)
            oSheet.Range("S" + col.ToString + "").value = DesviacionColumna(TablaExporta, 18)

            oSheet.Range("B" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("C" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("E" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("F" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("G" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("H" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("I" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("J" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("K" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("L" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("M" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("N" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("P" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("Q" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("R" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("S" + col.ToString + "").NumberFormat = "#0.00"

            col = col + 1

            oSheet.Range("B" + col.ToString + "").value = CvColumna(TablaExporta, 1)
            oSheet.Range("C" + col.ToString + "").value = CvColumna(TablaExporta, 2)
            oSheet.Range("E" + col.ToString + "").value = CvColumna(TablaExporta, 4)
            oSheet.Range("F" + col.ToString + "").value = CvColumna(TablaExporta, 5)
            oSheet.Range("G" + col.ToString + "").value = CvColumna(TablaExporta, 6)
            oSheet.Range("H" + col.ToString + "").value = CvColumna(TablaExporta, 7)
            oSheet.Range("I" + col.ToString + "").value = CvColumna(TablaExporta, 8)
            oSheet.Range("J" + col.ToString + "").value = CvColumna(TablaExporta, 9)
            oSheet.Range("K" + col.ToString + "").value = CvColumna(TablaExporta, 10)
            oSheet.Range("L" + col.ToString + "").value = CvColumna(TablaExporta, 11)
            oSheet.Range("M" + col.ToString + "").value = CvColumna(TablaExporta, 12)
            oSheet.Range("N" + col.ToString + "").value = CvColumna(TablaExporta, 13)
            oSheet.Range("P" + col.ToString + "").value = CvColumna(TablaExporta, 15)
            oSheet.Range("Q" + col.ToString + "").value = CvColumna(TablaExporta, 16)
            oSheet.Range("R" + col.ToString + "").value = CvColumna(TablaExporta, 17)
            oSheet.Range("S" + col.ToString + "").value = CvColumna(TablaExporta, 18)

            oSheet.Range("B" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("C" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("E" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("F" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("G" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("H" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("I" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("J" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("K" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("L" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("M" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("N" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("P" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("Q" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("R" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("S" + col.ToString + "").NumberFormat = "#0.00"

            col = col + 1

            oSheet.Range("B" + col.ToString + "").value = Q99columna(TablaExporta, 1)
            oSheet.Range("C" + col.ToString + "").value = Q99columna(TablaExporta, 2)
            oSheet.Range("E" + col.ToString + "").value = Q99columna(TablaExporta, 4)
            oSheet.Range("F" + col.ToString + "").value = Q99columna(TablaExporta, 5)
            oSheet.Range("G" + col.ToString + "").value = Q99columna(TablaExporta, 6)
            oSheet.Range("H" + col.ToString + "").value = Q99columna(TablaExporta, 7)
            oSheet.Range("I" + col.ToString + "").value = Q99columna(TablaExporta, 8)
            oSheet.Range("J" + col.ToString + "").value = Q99columna(TablaExporta, 9)
            oSheet.Range("K" + col.ToString + "").value = Q99columna(TablaExporta, 10)
            oSheet.Range("L" + col.ToString + "").value = Q99columna(TablaExporta, 11)
            oSheet.Range("M" + col.ToString + "").value = Q99columna(TablaExporta, 12)
            oSheet.Range("N" + col.ToString + "").value = Q99columna(TablaExporta, 13)
            oSheet.Range("P" + col.ToString + "").value = Q99columna(TablaExporta, 15)
            oSheet.Range("Q" + col.ToString + "").value = Q99columna(TablaExporta, 16)
            oSheet.Range("R" + col.ToString + "").value = Q99columna(TablaExporta, 17)
            oSheet.Range("S" + col.ToString + "").value = Q99columna(TablaExporta, 18)

            oSheet.Range("B" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("C" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("E" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("F" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("G" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("H" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("I" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("J" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("K" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("L" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("M" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("N" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("P" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("Q" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("R" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("S" + col.ToString + "").NumberFormat = "#0.00"

            col = col + 1

            oSheet.Range("B" + col.ToString + "").value = ValorMinimo(TablaExporta, 1)
            oSheet.Range("C" + col.ToString + "").value = ValorMinimo(TablaExporta, 2)
            oSheet.Range("E" + col.ToString + "").value = ValorMinimo(TablaExporta, 4)
            oSheet.Range("F" + col.ToString + "").value = ValorMinimo(TablaExporta, 5)
            oSheet.Range("G" + col.ToString + "").value = ValorMinimo(TablaExporta, 6)
            oSheet.Range("H" + col.ToString + "").value = ValorMinimo(TablaExporta, 7)
            oSheet.Range("I" + col.ToString + "").value = ValorMinimo(TablaExporta, 8)
            oSheet.Range("J" + col.ToString + "").value = ValorMinimo(TablaExporta, 9)
            oSheet.Range("K" + col.ToString + "").value = ValorMinimo(TablaExporta, 10)
            oSheet.Range("L" + col.ToString + "").value = ValorMinimo(TablaExporta, 11)
            oSheet.Range("M" + col.ToString + "").value = ValorMinimo(TablaExporta, 12)
            oSheet.Range("N" + col.ToString + "").value = ValorMinimo(TablaExporta, 13)
            oSheet.Range("P" + col.ToString + "").value = ValorMinimo(TablaExporta, 15)
            oSheet.Range("Q" + col.ToString + "").value = ValorMinimo(TablaExporta, 16)
            oSheet.Range("R" + col.ToString + "").value = ValorMinimo(TablaExporta, 17)
            oSheet.Range("S" + col.ToString + "").value = ValorMinimo(TablaExporta, 18)

            oSheet.Range("B" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("C" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("E" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("F" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("G" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("H" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("I" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("J" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("K" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("L" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("M" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("N" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("P" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("Q" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("R" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("S" + col.ToString + "").NumberFormat = "#0.00"

            col = col + 1

            oSheet.Range("B" + col.ToString + "").value = ValorMaximo(TablaExporta, 1)
            oSheet.Range("C" + col.ToString + "").value = ValorMaximo(TablaExporta, 2)
            oSheet.Range("E" + col.ToString + "").value = ValorMaximo(TablaExporta, 4)
            oSheet.Range("F" + col.ToString + "").value = ValorMaximo(TablaExporta, 5)
            oSheet.Range("G" + col.ToString + "").value = ValorMaximo(TablaExporta, 6)
            oSheet.Range("H" + col.ToString + "").value = ValorMaximo(TablaExporta, 7)
            oSheet.Range("I" + col.ToString + "").value = ValorMaximo(TablaExporta, 8)
            oSheet.Range("J" + col.ToString + "").value = ValorMaximo(TablaExporta, 9)
            oSheet.Range("K" + col.ToString + "").value = ValorMaximo(TablaExporta, 10)
            oSheet.Range("L" + col.ToString + "").value = ValorMaximo(TablaExporta, 11)
            oSheet.Range("M" + col.ToString + "").value = ValorMaximo(TablaExporta, 12)
            oSheet.Range("N" + col.ToString + "").value = ValorMaximo(TablaExporta, 13)
            oSheet.Range("P" + col.ToString + "").value = ValorMaximo(TablaExporta, 15)
            oSheet.Range("Q" + col.ToString + "").value = ValorMaximo(TablaExporta, 16)
            oSheet.Range("R" + col.ToString + "").value = ValorMaximo(TablaExporta, 17)
            oSheet.Range("S" + col.ToString + "").value = ValorMaximo(TablaExporta, 18)

            oSheet.Range("B" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("C" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("E" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("F" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("G" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("H" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("I" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("J" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("K" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("L" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("N" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("O" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("P" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("Q" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("R" + col.ToString + "").NumberFormat = "#0.00"
            oSheet.Range("S" + col.ToString + "").NumberFormat = "#0.00"
        End If

        ' hacemos visible el documento

        oExcel.Visible = True

        oExcel.UserControl = True

        'Guardaremos el documento en el escritorio con el nombre prueba

        'oBook.SaveAs(Environ("UserProfile") & "\desktop\Pruebatestexcel.xls")

    End Sub
    Private Function PromedioColumna(grid As Data.DataTable, columnIndex As Integer) As Double
        Return grid.Rows.Cast(Of DataRow).Select(Function(row) CDbl(row(columnIndex).ToString)).Average()
    End Function
    Private Function ValorMaximo(grid As Data.DataTable, columnIndex As Integer) As Double
        Return grid.Rows.Cast(Of DataRow).Select(Function(row) CDbl(row(columnIndex).ToString)).Max()
    End Function
    Private Function ValorMinimo(grid As Data.DataTable, columnIndex As Integer) As Double
        Return grid.Rows.Cast(Of DataRow).Select(Function(row) CDbl(row(columnIndex).ToString)).Min()
    End Function
    Private Function DesviacionColumna(grid As Data.DataTable, columnIndex As Integer) As Double
        Dim values As List(Of Double) = grid.Rows.Cast(Of DataRow).Select(Function(row) CDbl(row(columnIndex).ToString)).ToList()
        Dim ret As Double = 0
        If values.Count > 0 Then
            Dim avg As Double = values.Average()
            Dim sum As Double = values.Sum(Function(d) Math.Pow(d - avg, 2))
            ret = Math.Sqrt(sum / (values.Count - 1))
        End If
        Return ret
    End Function
    Private Function CvColumna(grid As Data.DataTable, columnIndex As Integer) As Double
        Dim values As List(Of Double) = grid.Rows.Cast(Of DataRow).Select(Function(row) CDbl(row(columnIndex).ToString)).ToList()
        Dim ret As Double = 0
        If values.Count > 0 Then
            Dim avg As Double = values.Average()
            Dim Ds As Double = DesviacionColumna(grid, columnIndex)
            ret = (Ds / avg) * 100
        End If
        Return ret
    End Function
    Private Function Q99columna(grid As Data.DataTable, columnIndex As Integer) As Double
        Dim values As List(Of Double) = grid.Rows.Cast(Of DataRow).Select(Function(row) CDbl(row(columnIndex).ToString)).ToList()
        Dim ret As Double = 0
        If values.Count > 0 Then
            Dim Cons As Double = 2.575
            Dim Ds As Double = DesviacionColumna(grid, columnIndex)
            ret = Cons * (Ds / Math.Sqrt(values.Count))
        End If
        Return ret
    End Function
    Private Sub ExportaExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportaExcelToolStripMenuItem.Click
        exportaHVIexcel(VarGlob2.TablaExporta)
    End Sub
    Private Sub Salir(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        VarGlob2.TablaExporta.Rows.Clear()
    End Sub
End Class