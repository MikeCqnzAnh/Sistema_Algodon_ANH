Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaProductorContratoCompras
    Public Property idproductor_ As Integer
    Public Property nombre_ As String
    Private Sub ConsultaProductorContratoCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbProductor.Text = ""
        TbProductor.Select()
        DgvProductores.DataSource = Nothing
    End Sub
    Private Sub TbProductor_KeyDown(sender As Object, e As KeyEventArgs) Handles TbProductor.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ConsultaProductores()
        End Select
    End Sub
    Private Sub ConsultaProductores()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaProductores
        EntidadCompraPacasContrato.NombreProductor = TbProductor.Text
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        DgvProductores.Columns.Clear()
        DgvProductores.DataSource = Tabla
        DgvProductores.ClearSelection()
    End Sub
    Private Sub DgvProductores_DoubleClick(sender As Object, e As EventArgs) Handles DgvProductores.DoubleClick
        If DgvProductores.Rows.Count > 0 Then
            Dim index As Integer
            index = DgvProductores.CurrentCell.RowIndex
            idproductor_ = DgvProductores.Rows(index).Cells("idproductor").Value
            nombre_ = DgvProductores.Rows(index).Cells("Nombre").Value
            Me.Close()
        End If
    End Sub
End Class
