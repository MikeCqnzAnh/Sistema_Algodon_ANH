Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Management
Imports Microsoft.Office.Interop

Public Class Bitacora
    Private Sub BtConsulta_Click(sender As Object, e As EventArgs) Handles BtConsulta.Click
        ConsultarBitacora(DtFechaInicio.Value.Date, DtFechaFin.Value.Date)
    End Sub
    Private Sub ConsultarBitacora(ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime)
        Dim EntidadBitacora As New Capa_Entidad.Bitacora
        Dim NegocioBitacora As New Capa_Negocio.Bitacora
        Dim Tabla As New DataTable
        EntidadBitacora.FechaInicio = FechaInicio
        EntidadBitacora.FechaFin = FechaFin
        EntidadBitacora.Usuario = CbUsuario.Text
        EntidadBitacora.Modulo = CbModulo.Text
        EntidadBitacora.Operacion = CbOperacion.Text
        EntidadBitacora.Consulta = Consulta.ConsultaDetallada
        NegocioBitacora.Consultar(EntidadBitacora)
        Tabla = EntidadBitacora.TablaConsulta
        DgvBitacora.Columns.Clear()
        DgvBitacora.DataSource = EntidadBitacora.TablaConsulta
        'FormatoDGV()
    End Sub
    Private Sub FormatoDGV()
        DgvBitacora.Columns("Observaciones").Width = 600
    End Sub
    Private Sub Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCombos()
        ConsultarBitacora(Now, Now)
    End Sub
    Private Sub CargaCombos()
        Dim tabla As New DataTable
        Dim EntidadBitacora As New Capa_Entidad.Bitacora
        Dim NegocioBitacora As New Capa_Negocio.Bitacora
        EntidadBitacora.Consulta = Consulta.ConsultaUsuario
        NegocioBitacora.Consultar(EntidadBitacora)
        tabla = EntidadBitacora.TablaConsulta
        CbUsuario.DataSource = tabla
        CbUsuario.ValueMember = "Id"
        CbUsuario.DisplayMember = "Usuario"
        CbUsuario.SelectedValue = -1
        '----------------------------------
        Dim tabla1 As New DataTable
        EntidadBitacora.Consulta = Consulta.ConsultaBasica
        NegocioBitacora.Consultar(EntidadBitacora)
        tabla1 = EntidadBitacora.TablaConsulta
        CbModulo.DataSource = tabla1
        CbModulo.ValueMember = "Id"
        CbModulo.DisplayMember = "Modulo"
        CbModulo.SelectedValue = -1
        '----------------------------------
        Dim tabla2 As New DataTable
        EntidadBitacora.Consulta = Consulta.ConsultaExterna
        NegocioBitacora.Consultar(EntidadBitacora)
        tabla2 = EntidadBitacora.TablaConsulta
        CbOperacion.DataSource = tabla2
        CbOperacion.ValueMember = "Id"
        CbOperacion.DisplayMember = "Operacion"
        CbOperacion.SelectedValue = -1
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LimpiarCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarCamposToolStripMenuItem.Click
        LimpiarCampos()
    End Sub
    Private Sub LimpiarCampos()
        DtFechaFin.Value = Now
        DtFechaInicio.Value = Now
        CbUsuario.SelectedIndex = -1
        CbModulo.SelectedIndex = -1
        CbOperacion.SelectedIndex = -1
    End Sub

    Private Sub ExportarBitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarBitacoraToolStripMenuItem.Click
        ExportExcel(DgvBitacora)
    End Sub
End Class