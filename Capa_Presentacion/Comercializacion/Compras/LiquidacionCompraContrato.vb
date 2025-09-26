Imports System.Drawing.Printing
Imports System.IO
Imports CrystalDecisions.Shared

Public Class LiquidacionCompraContrato
    Private _idcliente As Integer
    Private _nombrecliente As String
    Private _idcompra As Integer
    'Private ruta As String = Path.Combine(Application.StartupPath & "\Reportes\RPTPreliqcliente.rpt")
    Private ruta As String = Path.Combine(Application.StartupPath & "\Reportes\RPT\RPTLiquidacionCompraEnc.rpt")
    Dim crreport As New RPTLiquidacionCompraEnc()

    Public Sub New(idcompra As Integer, idcliente As Integer, nombrecliente As String)
        InitializeComponent()
        _idcompra = idcompra
        _idcliente = idcliente
        _nombrecliente = nombrecliente
    End Sub

    Private Sub FrmPreliquidacionventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultar()
    End Sub

    Private Sub consultar()
        'Dim crreport As New RPTPreliqcliente()
        'Dim crreport As New RPTLiquidacionCompraEnc()

        Dim eDatosEmpresa As New Capa_Entidad.DatosEmpresa()
        Dim nDatosEmpresa As New Capa_Negocio.DatosEmpresa()
        Dim tabla1 As New DataTable()
        Dim tabla2 As New DataTable()
        Dim tabla3 As New DataTable()
        Dim tabla4 As New DataTable()
        'Dim tabla5 As New DataTable()
        Dim ds As New DataSet()

        Try
            eDatosEmpresa.Consulta = Consulta.ConsultaDatosEmpresa
            'eDatosEmpresa.idempresa = 1
            nDatosEmpresa.ConsultarEmpresa(eDatosEmpresa)
            tabla1 = eDatosEmpresa.TablaConsulta
            ds.Tables.Add(tabla1)

            eDatosEmpresa.Consulta = Consulta.consultaproductor
            eDatosEmpresa.nombreproductor = ""
            eDatosEmpresa.idproductor = _idcliente
            nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla2 = eDatosEmpresa.TablaConsulta
            ds.Tables.Add(tabla2)

            eDatosEmpresa.Consulta = Consulta.ConsultaCompraenc
            eDatosEmpresa.idcompra = _idcompra
            nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla3 = eDatosEmpresa.TablaConsulta
            ds.Tables.Add(tabla3)

            eDatosEmpresa.Consulta = Consulta.ConsultaCompradet
            eDatosEmpresa.idcompra = _idcompra
            nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla4 = eDatosEmpresa.TablaConsulta
            ds.Tables.Add(tabla4)

            crreport.Load(ruta)
            crreport.Database.Tables("DatosEmpresa").SetDataSource(ds.Tables(0))
            crreport.Database.Tables("DatosProductor").SetDataSource(ds.Tables(1))
            crreport.Database.Tables("DatosCompraenc").SetDataSource(ds.Tables(2))
            crreport.Database.Tables("DatosCompradet").SetDataSource(ds.Tables(3))
            'crreport.Database.Tables("DatosPreliqvtaenc").SetDataSource(ds.Tables(3))
            'crreport.Database.Tables("DatosPacas").SetDataSource(ds.Tables(3))

            CRVReportePreliquidacion.ReportSource = crreport
            CRVReportePreliquidacion.Show()

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
    End Sub

    Private Sub EnviarPorEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarPorEmailToolStripMenuItem.Click
        Try
            Dim mensaje As String = "Se adjunta el documento de Liquidacion con el Folio " & _idcompra & " a nombre del cliente " & _nombrecliente
            Dim asunto As String = "Liquidacion de Compra Folio " & _idcompra & " para " & _nombrecliente
            Dim destinatario As String = "miguelcarrilloqnz@gmail.com"
            Dim pdfPath As String = IO.Path.Combine(Application.StartupPath, "Liquidacion_" & _idcompra & ".pdf")
            If IO.File.Exists(pdfPath) Then IO.File.Delete(pdfPath)
            Dim printerName As String = "Microsoft Print to PDF"
            Dim prnSettings As New System.Drawing.Printing.PrinterSettings()
            prnSettings.PrinterName = printerName
            prnSettings.PrintToFile = True
            prnSettings.PrintFileName = pdfPath

            Dim pgSettings As New PageSettings(prnSettings)
            pgSettings.Landscape = False

            ' Imprimir a PDF
            crreport.PrintToPrinter(prnSettings, pgSettings, False)

            ' Esperar a que el archivo ya no esté bloqueado
            Dim fileReady As Boolean = False
            Do
                Try
                    Using fs As IO.FileStream = IO.File.Open(pdfPath, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
                        fileReady = True
                    End Using
                Catch ex As IO.IOException
                    Threading.Thread.Sleep(500) ' esperar medio segundo
                End Try
            Loop Until fileReady
            ' Ahora enviarlo
            enviarCorreo(mensaje, asunto, destinatario, pdfPath)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class