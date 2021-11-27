Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
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
    Private Sub DgvProductores_DoubleClick(sender As Object, e As EventArgs) Handles DgvProductores.DoubleClick
        Me.Close()
    End Sub
End Class
