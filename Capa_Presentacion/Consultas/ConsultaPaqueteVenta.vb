
Public Class ConsultaPaqueteVenta
    Public Property idpaquete_ As Integer
    Public Property lotid_ As Integer
    Public Property idcomprador_ As Integer
    Public Property nombre_ As String
    Public Property idplanta_ As Integer
    Public Property idclase_ As Integer
    Public Property cantidapacas_ As Integer
    Public Property idestatus_ As Integer
    Public Property fechacreacion_ As DateTime
    Public Property fechaactualizacion_ As DateTime
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
            lotid_ = DgvPaquetes.Rows(index).Cells("lotid").Value
            idcomprador_ = DgvPaquetes.Rows(index).Cells("idcomprador").Value
            nombre_ = DgvPaquetes.Rows(index).Cells("nombre").Value
            idplanta_ = DgvPaquetes.Rows(index).Cells("idplanta").Value
            idclase_ = DgvPaquetes.Rows(index).Cells("idclase").Value
            cantidapacas_ = DgvPaquetes.Rows(index).Cells("cantidadpacas").Value
            idestatus_ = DgvPaquetes.Rows(index).Cells("idestatus").Value
            fechacreacion_ = DgvPaquetes.Rows(index).Cells("fechacreacion").Value
            fechaactualizacion_ = DgvPaquetes.Rows(index).Cells("fechaactualizacion").Value
            Close()
        End If
    End Sub
End Class