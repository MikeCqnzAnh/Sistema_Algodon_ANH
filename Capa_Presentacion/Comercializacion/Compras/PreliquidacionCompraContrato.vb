Imports System.IO

Public Class PreliquidacionCompraContrato
    Private _dtdestino As New DataTable()
    Private _dtencabezado As New DataTable()
    Private _idcliente As Integer
    'Private ruta As String = Path.Combine(Application.StartupPath & "\Reportes\RPTPreliqcliente.rpt")
    Private ruta As String = Path.Combine(Application.StartupPath & "\Reportes\RPT\RPTPreliquidacionCompraenc.rpt")

    Public Sub New(idcliente As Integer, dtencabezado As DataTable)
        InitializeComponent()
        _idcliente = idcliente
        '_dtdestino = dtdestino
        _dtencabezado = dtencabezado
    End Sub

    Private Sub FrmPreliquidacionventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultar()
    End Sub

    Private Sub consultar()
        'Dim crreport As New RPTPreliqcliente()
        Dim crreport As New RPTPreliquidacionCompraenc()

        Dim eDatosEmpresa As New Capa_Entidad.DatosEmpresa()
        Dim nDatosEmpresa As New Capa_Negocio.DatosEmpresa()
        Dim tabla1 As New DataTable()
        Dim tabla2 As New DataTable()
        Dim tabla3 As New DataTable()
        Dim tabla4 As New DataTable()
        'Dim tabla5 As New DataTable()
        Dim ds As New DataSet()

        Try
            eDatosEmpresa.Consulta = Consulta.ConsultaBasica
            'eDatosEmpresa.idempresa = 1
            nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla1 = eDatosEmpresa.TablaConsulta
            ds.Tables.Add(tabla1)

            eDatosEmpresa.Consulta = Consulta.consultaproductor
            eDatosEmpresa.nombreproductor = ""
            eDatosEmpresa.idproductor = _idcliente
            nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla2 = eDatosEmpresa.TablaConsulta
            ds.Tables.Add(tabla2)

            eDatosEmpresa.Consulta = Consulta.consultapreliqcompra
            nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla3 = eDatosEmpresa.TablaConsulta
            'tabla3 = _dtdestino.Copy()
            ds.Tables.Add(tabla3)

            'eDatosEmpresa.Consultar = O_Configuracion.Consultar.consultacalculocomprares
            'eDatosEmpresa.idcalculo = _idcalculocompra
            'nDatosEmpresa.Consultar(eDatosEmpresa)
            tabla4 = _dtencabezado.Copy()
            ds.Tables.Add(tabla4)

            crreport.Load(ruta)
            crreport.Database.Tables("DatosEmpresa").SetDataSource(ds.Tables(0))
            crreport.Database.Tables("DatosCliente").SetDataSource(ds.Tables(1))
            'crreport.Database.Tables("DatosPreliq").SetDataSource(ds.Tables(2))
            crreport.Database.Tables("Datospreliqvta").SetDataSource(ds.Tables(2))
            crreport.Database.Tables("DatosPreliqvtaenc").SetDataSource(ds.Tables(3))
            'crreport.Database.Tables("DatosPacas").SetDataSource(ds.Tables(3))

            CRVReportePreliquidacion.ReportSource = crreport
            CRVReportePreliquidacion.Show()

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
    End Sub
End Class