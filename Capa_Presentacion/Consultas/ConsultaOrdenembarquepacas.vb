Public Class ConsultaOrdenembarquepacas
    Public Property _idembarque As Integer
    Public Property _idcomprador As Integer
    Public Property _nombrecomprador As String
    Public Property _nombrechofer As String
    Public Property _nolicencia As String
    Public Property _telefono As String
    Public Property _folio As String
    Public Property _placatracto As String
    Public Property _placacaja As String
    Public Property _destino As String
    Public Property _observaciones As String
    Public Property _totalpacas As Integer
    Public Property _totalkilos As Decimal
    Public Property _idestatus As Integer
    Public Property _fechacreacion As DateTime
    Public Property _fechaactualizacion As DateTime
    Private Sub consulta()
        Dim eorden As New Capa_Entidad.OrdenEmbarquePacas()
        Dim norden As New Capa_Negocio.OrdenEmbarquePacas()
        Dim dt As New DataTable
        eorden.Consulta = Capa_Operacion.Configuracion.Consulta.ConsultaOrdenEmbarqueEncabezado
        eorden.busqueda = tbbusqueda.Text
        norden.Consultar(eorden)
        dt = eorden.TablaConsulta
        If dt.Rows.Count > 0 Then
            dgvconsulta.DataSource = dt
            formatodgv()
        End If
    End Sub
    Private Sub formatodgv()
        dgvconsulta.Columns("IdEmbarqueEncabezado").HeaderText = "ID"
        dgvconsulta.Columns("nombre").HeaderText = "Nombre"
        dgvconsulta.Columns("nombrechofer").HeaderText = "Transportiste"
        dgvconsulta.Columns("nolicencia").HeaderText = "Licencia"
        dgvconsulta.Columns("Telefono").HeaderText = "Telefono"
        dgvconsulta.Columns("folio").HeaderText = "Folio"
        dgvconsulta.Columns("placatractocamion").HeaderText = "Placa Tracto-Camion"
        dgvconsulta.Columns("placacaja").HeaderText = "Placa de Caja"
        dgvconsulta.Columns("destino").HeaderText = "Destino"
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
            _idembarque = dgvconsulta.Rows(index).Cells(0).Value
            _idcomprador = dgvconsulta.Rows(index).Cells(1).Value
            _nombrecomprador = dgvconsulta.Rows(index).Cells(2).Value
            _nombrechofer = dgvconsulta.Rows(index).Cells(3).Value
            _nolicencia = dgvconsulta.Rows(index).Cells(4).Value
            _telefono = dgvconsulta.Rows(index).Cells(5).Value
            _folio = dgvconsulta.Rows(index).Cells(6).Value
            _placatracto = dgvconsulta.Rows(index).Cells(7).Value
            _placacaja = dgvconsulta.Rows(index).Cells(8).Value
            _destino = dgvconsulta.Rows(index).Cells(9).Value
            _observaciones = dgvconsulta.Rows(index).Cells(10).Value
            _totalpacas = dgvconsulta.Rows(index).Cells(11).Value
            _totalkilos = dgvconsulta.Rows(index).Cells(12).Value
            _idestatus = dgvconsulta.Rows(index).Cells(13).Value
            _fechacreacion = dgvconsulta.Rows(index).Cells(15).Value
            _fechaactualizacion = dgvconsulta.Rows(index).Cells(16).Value
            Close()
        End If
    End Sub
End Class