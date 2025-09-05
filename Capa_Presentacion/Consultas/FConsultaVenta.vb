Public Class FConsultaVenta
    Public Property _idventa As Integer
    Public Property _idplanta As Integer
    Public Property _idcomprador As Integer
    Public Property _nombrecomprador As String
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
        Dim ecatalogos As New Capa_Entidad.VentaPacasContrato
        Dim ncatalogos As New Capa_Negocio.VentaPacasContrato
        Dim dt As New DataTable
        ecatalogos.Consulta = Capa_Operacion.Configuracion.Consulta.ConsultaVenta
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
        dgvconsulta.Columns("idplanta").Visible = False
        dgvconsulta.Columns("tara").Visible = False
        dgvconsulta.Columns("checktara").Visible = False
        dgvconsulta.Columns("castigomic").Visible = False
        dgvconsulta.Columns("castigoresistencia").Visible = False
        dgvconsulta.Columns("castigouhml").Visible = False
        dgvconsulta.Columns("castigoui").Visible = False
        dgvconsulta.Columns("fechaactualizacion").Visible = False
        dgvconsulta.Columns("idestatus").Visible = False
        dgvconsulta.Columns("idventa").HeaderText = "ID Venta"
        dgvconsulta.Columns("idcomprador").HeaderText = "ID Comprador"
        dgvconsulta.Columns("idcontrato").HeaderText = "ID Contrato"
        dgvconsulta.Columns("totalpacas").HeaderText = "Pacas"
        dgvconsulta.Columns("Subtotal").HeaderText = "SubTotal"
        dgvconsulta.Columns("deduccion").HeaderText = "Deduccion"
        dgvconsulta.Columns("Totalprecio").HeaderText = "Total"
        dgvconsulta.Columns("fechacreacion").HeaderText = "Creacion"
        dgvconsulta.Columns("estatus").HeaderText = "Estatus"
    End Sub

    Private Sub tbbusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbbusqueda.TextChanged
        consulta()
    End Sub

    Private Sub dgvconsulta_DoubleClick(sender As Object, e As EventArgs) Handles dgvconsulta.DoubleClick
        If dgvconsulta.Rows.Count > 0 Then
            Dim index As Integer = dgvconsulta.CurrentCell.RowIndex
            _idventa = dgvconsulta.Rows(index).Cells(0).Value
            _idcomprador = dgvconsulta.Rows(index).Cells(2).Value
            _nombrecomprador = dgvconsulta.Rows(index).Cells(3).Value
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