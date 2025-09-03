Public Class FConsultaCompra
    Public Property _idcompra As Integer
    Public Property _idplanta As Integer
    Public Property _idproductor As Integer
    Public Property _nombreproductor As String
    Public Property _idcontrato As Integer
    Public Property _tara As Decimal
    Public Property _checktara As Boolean
    Public Property _totalpacas As Integer
    Public Property _subtotal As Decimal
    Public Property _castigomicros As Decimal
    Public Property _castigostrength As Decimal
    Public Property _castigouhml As Decimal
    Public Property _castigoui As Decimal
    Public Property _deduccion As Decimal
    Public Property _totalprecio As Decimal
    Public Property _fechacreacion As DateTime
    Public Property _fechaactualizacion As DateTime
    Public Property _idestatus As Integer

    Private Sub FConsultaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub consulta()
        Dim ecatalogos As New Capa_Entidad.CompraPacasContrato
        Dim ncatalogos As New Capa_Negocio.CompraPacasContrato
        Dim dt As New DataTable
        ecatalogos.Consulta = Capa_Operacion.Configuracion.Consulta.ConsultaCompra
        ecatalogos.busqueda = tbbusqueda.Text
        ncatalogos.Consultar(ecatalogos)

        dt = ecatalogos.TablaConsulta
        dgvconsulta.DataSource = dt
        'dgvconsulta.Rows.Clear()
        'dgvconsulta.Columns.Clear()
        formatodgv()
        dgvconsulta.ClearSelection()

    End Sub
    Private Sub formatodgv()

    End Sub

    Private Sub tbbusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbbusqueda.TextChanged
        consulta()
    End Sub

    Private Sub dgvconsulta_DoubleClick(sender As Object, e As EventArgs) Handles dgvconsulta.DoubleClick
        If dgvconsulta.Rows.Count > 0 Then
            Dim index As Integer = dgvconsulta.CurrentCell.RowIndex
            _idcompra = dgvconsulta.Rows(index).Cells(0).Value
            _idproductor = dgvconsulta.Rows(index).Cells(2).Value
            _nombreproductor = dgvconsulta.Rows(index).Cells(3).Value
            _idcontrato = dgvconsulta.Rows(index).Cells(4).Value
            _tara = dgvconsulta.Rows(index).Cells(5).Value
            _checktara = dgvconsulta.Rows(index).Cells(6).Value
            _totalpacas = dgvconsulta.Rows(index).Cells(7).Value
            _subtotal = dgvconsulta.Rows(index).Cells(8).Value
            _castigomicros = dgvconsulta.Rows(index).Cells(9).Value
            _castigostrength = dgvconsulta.Rows(index).Cells(10).Value
            _castigouhml = dgvconsulta.Rows(index).Cells(11).Value
            _castigoui = dgvconsulta.Rows(index).Cells(12).Value
            _deduccion = dgvconsulta.Rows(index).Cells(13).Value
            _totalprecio = dgvconsulta.Rows(index).Cells(14).Value
            _fechacreacion = dgvconsulta.Rows(index).Cells(15).Value
            _fechaactualizacion = dgvconsulta.Rows(index).Cells(16).Value
            _idestatus = dgvconsulta.Rows(index).Cells(17).Value
            Close()
        Else
            MessageBox.Show("No hay registros para seleccionar.", "Aviso")
        End If
    End Sub
End Class