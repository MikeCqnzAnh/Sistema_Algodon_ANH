Imports Capa_Operacion.Configuracion
Public Class ConsultaProductorContratoCompras
    Private formOpener As IForm

    Public Property Opener() As IForm
        Get
            Return formOpener
        End Get
        Set(ByVal value As IForm)
            formOpener = value
        End Set
    End Property
    Private Sub ConsultaProductorContratoCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaProductores()
    End Sub
    Private Sub ConsultaProductores()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaProductores
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        DgvProductores.Columns.Clear()
        DgvProductores.DataSource = Tabla
    End Sub

    Private Sub DgvProductores_DoubleClick(sender As Object, e As EventArgs) Handles DgvProductores.DoubleClick
        Me.Close()
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DgvProductores.RowCount > 0 And DgvProductores.CurrentCell IsNot Nothing Then
            Dim _dataTable As DataTable = LoadDataTable()

            Dim estadoOperacion As Boolean = Me.Opener.LoadIdProductor(_dataTable)

            e.Cancel = Not estadoOperacion
        End If
    End Sub
    Private Function LoadDataTable() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("IDProductor")
        dt.Columns.Add("Nombre")
        Dim row As DataRow = dt.NewRow()
        Dim Index As Integer

        Index = DgvProductores.CurrentCell.RowIndex

        row("IDProductor") = DgvProductores.Rows(Index).Cells("IDProductor").Value
        row("Nombre") = DgvProductores.Rows(Index).Cells("Nombre").Value

        dt.Rows.Add(row)

        Return dt
    End Function
End Class
