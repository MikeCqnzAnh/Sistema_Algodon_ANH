Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaHVI
    Public Property idpaquete_ As Integer

    Private Sub ConsultaHVI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultar()
    End Sub
    Private Sub consultar()
        Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
        Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
        Dim Tabla As New DataTable
        EntidadPaquetesHVI.Consulta = Consulta.ConsultaPaqueteHviEnc
        EntidadPaquetesHVI.IdPaquete = Val(tbidpaquete.Text)
        NegocioPaquetesHVI.Consultar(EntidadPaquetesHVI)
        Tabla = EntidadPaquetesHVI.TablaConsulta
        DgvPaquetes.DataSource = Tabla
        propiedadesdgv()
    End Sub

    Private Sub tbidpaquete_TextChanged(sender As Object, e As EventArgs) Handles tbidpaquete.TextChanged
        consultar()
    End Sub
    Private Sub propiedadesdgv()
        DgvPaquetes.Columns("idhvienc").Visible = False
        DgvPaquetes.Columns("idplanta").Visible = False
    End Sub

    Private Sub DgvPaquetes_DoubleClick(sender As Object, e As EventArgs) Handles DgvPaquetes.DoubleClick
        If DgvPaquetes.Rows.Count > 0 Then
            Dim index As Integer
            index = DgvPaquetes.CurrentCell.RowIndex
            idpaquete_ = DgvPaquetes.Rows(index).Cells("Paquete").Value
            Close()
        End If
    End Sub
End Class