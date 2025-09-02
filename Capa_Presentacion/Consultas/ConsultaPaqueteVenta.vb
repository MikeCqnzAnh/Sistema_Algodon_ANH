
Public Class ConsultaPaqueteVenta
    Public Property idpaquete_ As Integer
    Private Sub ConsultaPaqueteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultar()
    End Sub
    Private Sub consultar()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPaqueteVtaEnc
        EntidadClasificacionVentaPaquetes.busqueda = tbidpaquete.Text
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        DgvPaquetes.DataSource = Tabla
        propiedadesdgv()
    End Sub
    Private Sub propiedadesdgv()
        DgvPaquetes.Columns("idpaquete").HeaderText = "Paquete"
        DgvPaquetes.Columns("LotID").Visible = False
        DgvPaquetes.Columns("IdPlanta").Visible = False
        DgvPaquetes.Columns("idcomprador").Visible = False
        DgvPaquetes.Columns("idclase").Visible = False
        DgvPaquetes.Columns("Entrega").Visible = False
        DgvPaquetes.Columns("chkrevisado").Visible = False
        DgvPaquetes.Columns("idestatus").Visible = False
    End Sub
    Private Sub tbidpaquete_TextChanged(sender As Object, e As EventArgs) Handles tbidpaquete.TextChanged
        consultar()
    End Sub

    Private Sub DgvPaquetes_DoubleClick(sender As Object, e As EventArgs) Handles DgvPaquetes.DoubleClick
        If DgvPaquetes.Rows.Count > 0 Then
            Dim index As Integer
            index = DgvPaquetes.CurrentCell.RowIndex
            idpaquete_ = DgvPaquetes.Rows(index).Cells("idpaquete").Value
            Close()
        End If
    End Sub
End Class