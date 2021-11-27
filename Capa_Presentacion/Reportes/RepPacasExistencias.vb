Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class RepPacasExistencias
    Private Sub RepPacasExistencias_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConsultaExistenciaResumen()
        ConsultaReporte()
        cargacombos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub cargacombos()
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
    Private Sub Limpiar()
        TbIdCompra.Clear()
        TbIdEmbarque.Clear()
        TbIdPaqVenta.Clear()
        TbIdSalida.Clear()
        TbIdVenta.Clear()
        TbIdComprador.Clear()
        TbComprador.Clear()
        TbIdProductor.Clear()
        TbProductor.Clear()
        cargacombos()
        CkCompradas.Checked = False
        CkSinComprar.Checked = False
        CkVendidas.Checked = False
        CkSinVender.Checked = False
        CkSalidas.Checked = False
        CkExistencias.Checked = False
        CkEmbarques.Checked = False
        CkSinEmbarque.Checked = False
    End Sub
    Private Sub SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdCompra.KeyPress, TbIdEmbarque.KeyPress, TbIdPaqVenta.KeyPress, TbIdSalida.KeyPress, TbIdVenta.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub ConsultaExistenciaResumen()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla As New DataTable
        EntidadReportes.Reporte = Reporte.ReporteExistenciasResumen
        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        DgvPacas.DataSource = Tabla
    End Sub
    Private Sub ConsultaReporte()
        Dim EntidadReportes As New Capa_Entidad.Reportes
        Dim NegocioReportes As New Capa_Negocio.Reportes
        Dim Tabla, TablaGeneral As New Data.DataTable
        Dim ds As New DataSet
        Dim CrReport As RPTExistenciaPacasDetalle = New RPTExistenciaPacasDetalle
        Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Reportes\RPT\RPTExistenciaPacasDetalle.rpt"
        EntidadReportes.Reporte = Reporte.ReporteExistenciasDetalle
        EntidadReportes.IdCompra = Val(TbIdCompra.Text)
        EntidadReportes.IdVenta = Val(TbIdVenta.Text)
        EntidadReportes.IdPaquete = Val(TbIdPaqVenta.Text)
        EntidadReportes.IdEmbarqueEncabezado = Val(TbIdEmbarque.Text)
        EntidadReportes.IdPlanta = CbPlanta.SelectedValue
        EntidadReportes.IdSalidaPacas = Val(TbIdSalida.Text)
        EntidadReportes.IdComprador = Val(TbIdComprador.Text)
        EntidadReportes.IdProductor = Val(TbIdProductor.Text)
        EntidadReportes.SoloCompradas = CkCompradas.Checked
        EntidadReportes.SoloSinComprar = CkSinComprar.Checked
        EntidadReportes.SoloVendidas = CkVendidas.Checked
        EntidadReportes.SoloSinVender = CkSinVender.Checked
        EntidadReportes.SoloEmbarques = CkEmbarques.Checked
        EntidadReportes.SoloSinEmbarques = CkSinEmbarque.Checked
        EntidadReportes.SoloSalidas = CkSalidas.Checked
        EntidadReportes.SoloSinSalida = CkExistencias.Checked

        NegocioReportes.Consultar(EntidadReportes)
        Tabla = EntidadReportes.TablaConsulta
        ds.Tables.Add(Tabla)
        CrReport.Load(Ruta)
        CrReport.SetDataSource(ds.Tables("table1"))
        CRVReporteExistencias.ReportSource = CrReport
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ConsultaExistenciaResumen()
        ConsultaReporte()
    End Sub

    Private Sub BtComprador_Click(sender As Object, e As EventArgs) Handles BtComprador.Click
        Dim _ConsultaCompradorEmbarque As New ConsultaOrdenEmbarqueComprador
        _ConsultaCompradorEmbarque.ShowDialog()
        If _Id > 0 Then
            Limpiar()
            TbIdComprador.Text = _Id
            TbComprador.Text = _NombreComprador
        End If
    End Sub

    Private Sub BtProductor_Click(sender As Object, e As EventArgs) Handles BtProductor.Click
        Dim _ConsultaCliente As New ConsultaClientes
        _ConsultaCliente.ShowDialog()
        If _ConsultaCliente.IdCliente > 1 Then
            Limpiar()
            TbIdProductor.Text = _ConsultaCliente.IdCliente
            TbProductor.Text = _Nombre
        End If
    End Sub
    Private Sub CkCompradas_Click(sender As Object, e As EventArgs) Handles CkCompradas.Click
        If CkSinComprar.Checked = True Then
            CkSinComprar.Checked = False
            CkCompradas.Checked = True
        End If
    End Sub
    Private Sub CkSinComprar_Click(sender As Object, e As EventArgs) Handles CkSinComprar.Click
        If CkCompradas.Checked = True Then
            CkCompradas.Checked = False
            CkSinComprar.Checked = True
        End If
    End Sub
    Private Sub CkEmbarques_Click(sender As Object, e As EventArgs) Handles CkEmbarques.Click
        If CkSinEmbarque.Checked = True Then
            CkSinEmbarque.Checked = False
            CkEmbarques.Checked = True
        End If
    End Sub
    Private Sub CkSinEmbarque_Click(sender As Object, e As EventArgs) Handles CkSinEmbarque.Click
        If CkEmbarques.Checked = True Then
            CkSinEmbarque.Checked = True
            CkEmbarques.Checked = False
        End If
    End Sub
    Private Sub CkExistencias_Click(sender As Object, e As EventArgs) Handles CkExistencias.Click
        If CkSalidas.Checked = True Then
            CkSalidas.Checked = False
            CkExistencias.Checked = True
        End If
    End Sub
    Private Sub CkSalidas_Click(sender As Object, e As EventArgs) Handles CkSalidas.Click
        If CkExistencias.Checked = True Then
            CkSalidas.Checked = True
            CkExistencias.Checked = False
        End If
    End Sub
    Private Sub CkVendidas_Click(sender As Object, e As EventArgs) Handles CkVendidas.Click
        If CkSinVender.Checked = True Then
            CkSinVender.Checked = False
            CkVendidas.Checked = True
        End If
    End Sub
    Private Sub CkSinVender_Click(sender As Object, e As EventArgs) Handles CkSinVender.Click
        If CkVendidas.Checked = True Then
            CkVendidas.Checked = False
            CkSinVender.Checked = True
        End If
    End Sub

End Class