Public Class FConsultaProductorContratoVenta
    Public _id As Integer
    Public _nombre As String
    Private Sub Consultacomprador()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        Dim dt As New DataTable
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaCompradores
        EntidadVentaPacasContrato.NombreComprador = tbnombre.Text
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        dt = EntidadVentaPacasContrato.TablaConsulta
        dgvconsulta.Columns.Clear()
        dgvconsulta.DataSource = dt
        formatodgv()
        dgvconsulta.ClearSelection()
    End Sub

    Private Sub tbnombre_TextChanged(sender As Object, e As EventArgs) Handles tbnombre.TextChanged
        Consultacomprador()
    End Sub
    Private Sub formatodgv()
        dgvconsulta.Columns(0).HeaderText = "ID"
    End Sub

    Private Sub dgvconsulta_DoubleClick(sender As Object, e As EventArgs) Handles dgvconsulta.DoubleClick
        If dgvconsulta.Rows.Count > 0 Then
            Dim index As Integer = dgvconsulta.CurrentCell.RowIndex
            _id = dgvconsulta.Rows(index).Cells(0).Value
            _nombre = dgvconsulta.Rows(index).Cells(1).Value
            Close()
        Else
            MessageBox.Show("No hay registros para seleccionar.", "Aviso")
        End If
    End Sub
End Class