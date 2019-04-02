Imports Capa_Operacion.Configuracion
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Management
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
        EntidadBitacora.Consulta = Consulta.ConsultaDetallada
        NegocioBitacora.Consultar(EntidadBitacora)
        DgvBitacora.DataSource = EntidadBitacora.TablaConsulta
        FormatoDGV()
        'InsertaBitacora(Now, My.Computer.Name, Dns.Resolve(My.Computer.Name).AddressList(0).ToString(), _Id, _Usuario, "", "", "", "")
    End Sub
    Private Sub FormatoDGV()
        DgvBitacora.Columns("Observaciones").Width = 600
    End Sub
    Private Sub Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarBitacora(Now, Now)
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
    End Sub
End Class