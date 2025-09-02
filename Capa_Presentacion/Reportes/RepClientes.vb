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
Public Class RepClientes
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\conf\"
    Dim archivo As String = "confemail.ini"
    Dim email, password, hostsmtp As String
    Dim puertosmtp As Integer
    Dim ConexionSSL As Boolean
    Dim rutadoc As String
    Private Sub RepClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRVReporteClientes.ReportSource = Nothing
        CRVReporteClientes.Refresh()
        CargarCombos()
        ObtenerArchivoConfiguracion()
    End Sub
    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        CRVReporteClientes.ReportSource = Nothing
        CRVReporteClientes.Refresh()
        CargarCombos()
        ObtenerArchivoConfiguracion()
    End Sub
    Private Sub CargarCombos()
        '--Hace referencia a clientes para no repetir codigo en la capas que traen la misma informacion
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        Dim tabla As New DataTable
        EntidadClientes.Consulta = Consulta.ConsultaAsociaciones
        NegocioClientes.Consultar(EntidadClientes)
        tabla = EntidadClientes.TablaConsulta
        CbAsociaciones.DataSource = tabla
        CbAsociaciones.ValueMember = "IdAsociacion"
        CbAsociaciones.DisplayMember = "Descripcion"
        CbAsociaciones.SelectedValue = 1
    End Sub

    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTReporteClientes = New RPTReporteClientes
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTReporteClientes.rpt"
        EntidadReportes.Reporte = Reporte.ReporteClientes
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVReporteClientes.ReportSource = CrReport
        CRVReporteClientes.Show()
    End Sub
    Private Sub ObtenerArchivoConfiguracion()
        Dim leer As New StreamReader(Ruta & archivo)
        email = ""
        password = ""
        hostsmtp = ""
        puertosmtp = 0
        ConexionSSL = False
        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadToEnd()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim arreglocadena() As String = Split(linea, vbCrLf)
                email = ObtenerValor(arreglocadena(0))
                password = ObtenerValor(arreglocadena(1))
                hostsmtp = ObtenerValor(arreglocadena(2))
                puertosmtp = ObtenerValor(arreglocadena(3))
                ConexionSSL = ObtenerValor(arreglocadena(4))
            End While
            leer.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function ObtenerValor(ByVal cadena As String)
        Dim Resultado As String
        Dim ArregloCadena() As String = Split(cadena, "=")
        Resultado = ArregloCadena(1)
        Return Resultado
    End Function
    Private Sub LeerArchivoconfiguracion()
        If File.Exists(Ruta & archivo) Then
            ObtenerArchivoConfiguracion()
            'Else
            '    CreaConexion()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Public Function ExportToPDF(ByVal rpt As ReportDocument, ByVal NombreArchivo As String) As String
        Dim vFileName As String = ""
        Dim diskOpts As New DiskFileDestinationOptions

        Try
            With rpt.ExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
            End With

            vFileName = My.Computer.FileSystem.CurrentDirectory & "\Reportes\" & NombreArchivo
            If File.Exists(vFileName) Then File.Delete(vFileName)
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
        End Try
        Return vFileName
    End Function
    Private Sub EnviarPorEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarPorEmailToolStripMenuItem.Click
        Dim Destinatario As String = ""
        Dim RutaDeDocumento As String = ""
        If CRVReporteClientes.ReportSource is Nothing Then
            MsgBox("No hay documento para enviar.")
        Else
            Dim EntidadReportes As New Capa_Entidad.Reportes
            Dim NegocioReportes As New Capa_Negocio.Reportes
            Dim Tabla As New DataTable
            Dim ds As New DataSet
            Dim CrReport As RPTReporteClientes = New RPTReporteClientes
            Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTReporteClientes.rpt"
            EntidadReportes.Reporte = Reporte.ReporteClientes
            NegocioReportes.Consultar(EntidadReportes)
            Tabla = EntidadReportes.TablaConsulta
            ds.Tables.Add(Tabla)
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds.Tables("table1"))

            RutaDeDocumento = ExportToPDF(CrReport, "ReporteClientes" & Now.Minute.ToString & Now.Second.ToString & ".pdf")
            Destinatario = InputBox("Para:", "Complete la direccion de correo del destinatario.")
            enviarCorreo(email, password, "Archivo enviado desde SIA.", "Reporte Clientes.", Destinatario, puertosmtp, hostsmtp, ConexionSSL, RutaDeDocumento)
        End If
    End Sub
End Class