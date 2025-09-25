Public Class ConsultaLotesEnc
    Public Property _idlote As Integer
    Public Property _nolote As String
    Public Property _idcomprador As Integer
    Public Property _nombre As String
    Public Property _observaciones As String
    Public Property _ubicacion As String
    Public Property _totalpacas As Integer
    Public Property _totalkilos As Decimal
    Public Property _fechacreacion As DateTime
    Public Property _fechaactualizacion As DateTime
    Public Property _idestatus As Integer
    Private Sub consulta()
        Dim elotespacas As New Capa_Entidad.LotesPacas()
        Dim nlotespacas As New Capa_Negocio.LotesPacas()
        Dim dt As New DataTable
        elotespacas.Consulta = Capa_Operacion.Configuracion.Consulta.ConsultaLotes
        elotespacas.busqueda = tbbusqueda.Text
        nlotespacas.Consultar(elotespacas)
        dt = elotespacas.TablaConsulta
        If dt.Rows.Count > 0 Then
            dgvconsulta.DataSource = dt
            formatodgv()
        End If
        dgvconsulta.ClearSelection()
    End Sub
    Private Sub formatodgv()
        dgvconsulta.Columns("idlote").HeaderText = "ID"
        dgvconsulta.Columns("nolote").HeaderText = "No Lote"
        dgvconsulta.Columns("nombre").HeaderText = "Nombre"
        dgvconsulta.Columns("ubicacion").HeaderText = "Ubicacion"
        dgvconsulta.Columns("observaciones").HeaderText = "Observaciones"
        dgvconsulta.Columns("totalpacas").HeaderText = "Cantidad"
        dgvconsulta.Columns("fechacreacion").HeaderText = "Fecha Creacion"
        dgvconsulta.Columns("estatus").HeaderText = "Estatus"

        dgvconsulta.Columns("idcomprador").Visible = False
        dgvconsulta.Columns("totalkilos").Visible = False
        dgvconsulta.Columns("fechaactualizacion").Visible = False
        dgvconsulta.Columns("idestatus").Visible = False
    End Sub

    Private Sub tbbusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbbusqueda.TextChanged
        consulta()
    End Sub

    Private Sub dgvconsulta_DoubleClick(sender As Object, e As EventArgs) Handles dgvconsulta.DoubleClick
        If dgvconsulta.Rows.Count > 0 Then
            Dim index As Integer = dgvconsulta.Rows(index).Cells(0).RowIndex
            _idlote = dgvconsulta.Rows(index).Cells(0).Value
            _nolote = dgvconsulta.Rows(index).Cells(1).Value
            _idcomprador = dgvconsulta.Rows(index).Cells(2).Value
            _nombre = dgvconsulta.Rows(index).Cells(3).Value
            _ubicacion = dgvconsulta.Rows(index).Cells(4).Value
            _observaciones = dgvconsulta.Rows(index).Cells(5).Value
            _totalpacas = dgvconsulta.Rows(index).Cells(6).Value
            _totalkilos = dgvconsulta.Rows(index).Cells(7).Value
            _fechacreacion = dgvconsulta.Rows(index).Cells(8).Value
            _fechaactualizacion = dgvconsulta.Rows(index).Cells(9).Value
            _idestatus = dgvconsulta.Rows(index).Cells(10).Value
            Close()
        Else
            MessageBox.Show("No hay registros para seleccionar.", "Aviso")
        End If
    End Sub
End Class
