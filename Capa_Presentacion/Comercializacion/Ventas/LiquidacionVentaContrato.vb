Imports System.IO

Public Class LiquidacionVentaContrato
    Private _idcomprador As Integer
    Private _idventa As Integer
    Private _nombrecomprador As String
    'Private ruta As String = Path.Combine(Application.StartupPath & "\Reportes\RPTPreliqcliente.rpt")
    Private ruta As String = Path.Combine(Application.StartupPath & "\Reportes\RPT\RPTLiquidacionVentaEnc.rpt")

    Public Sub New(idventa As Integer, idcomprador As Integer, nombrecomprador As String)
        InitializeComponent()
        _idventa = idventa
        _idcomprador = idcomprador
        _nombrecomprador = nombrecomprador
    End Sub

    Private Sub FrmPreliquidacionventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultar()
    End Sub

    Private Sub consultar()
        'Dim crreport As New RPTPreliqcliente()
        Dim crreport As New RPTLiquidacionVentaEnc()

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

            eDatosEmpresa.Consulta = Consulta.ConsultaComprador
            eDatosEmpresa.nombrecomprador = ""
            eDatosEmpresa.idcomprador = _idcomprador
            nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla2 = eDatosEmpresa.TablaConsulta
            ds.Tables.Add(tabla2)

            eDatosEmpresa.Consulta = Consulta.Consultaventaenc
            eDatosEmpresa.idventa = _idventa
            nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla3 = eDatosEmpresa.TablaConsulta
            ds.Tables.Add(tabla3)

            eDatosEmpresa.Consulta = Consulta.Consultaventadet
            eDatosEmpresa.idventa = _idventa
            nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla4 = eDatosEmpresa.TablaConsulta
            ds.Tables.Add(tabla4)

            crreport.Load(ruta)
            crreport.Database.Tables("DatosEmpresa").SetDataSource(ds.Tables(0))
            crreport.Database.Tables("DatosComprador").SetDataSource(ds.Tables(1))
            crreport.Database.Tables("DatosVentaenc").SetDataSource(ds.Tables(2))
            crreport.Database.Tables("DatosVentadet").SetDataSource(ds.Tables(3))
            'crreport.Database.Tables("DatosPreliqvtaenc").SetDataSource(ds.Tables(3))
            'crreport.Database.Tables("DatosPacas").SetDataSource(ds.Tables(3))

            CRVReportePreliquidacion.ReportSource = crreport
            CRVReportePreliquidacion.Show()

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
    End Sub
End Class