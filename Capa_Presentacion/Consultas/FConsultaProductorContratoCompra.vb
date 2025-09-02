Imports System.Runtime.CompilerServices

Public Class FConsultaProductorContratoCompra
    Public id As Integer
    Public nombre As String
    Private Sub FConsultaProductorContratoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ConsultaProductores()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaProductores
        EntidadCompraPacasContrato.NombreProductor = tbnombre.Text
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        dgvconsulta.Columns.Clear()
        dgvconsulta.DataSource = Tabla
        formatodgv()
        dgvconsulta.ClearSelection()
    End Sub

    Private Sub tbnombre_TextChanged(sender As Object, e As EventArgs) Handles tbnombre.TextChanged
        ConsultaProductores()
    End Sub
    Private Sub formatodgv()
        dgvconsulta.Columns(0).HeaderText = "ID"
    End Sub

    Private Sub dgvconsulta_DoubleClick(sender As Object, e As EventArgs) Handles dgvconsulta.DoubleClick
        If dgvconsulta.Rows.Count > 0 Then
            Dim index As Integer = dgvconsulta.CurrentCell.RowIndex
            id = dgvconsulta.Rows(index).Cells(0).Value
            nombre = dgvconsulta.Rows(index).Cells(1).Value
            Close()
        Else
            MessageBox.Show("No hay registros para seleccionar.", "Aviso")
        End If
    End Sub
End Class