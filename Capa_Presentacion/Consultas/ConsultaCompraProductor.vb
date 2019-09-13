Imports Capa_Operacion.Configuracion
Public Class ConsultaCompraProductor
    Private formOpener As IForm

    Public Property Opener() As IForm
        Get
            Return formOpener
        End Get
        Set(ByVal value As IForm)
            formOpener = value
        End Set
    End Property
    Private Sub ConsultaCompraProductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
    End Sub
    Private Sub ConsultaCompra()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCompraPorNombre
        EntidadCompraPacasContrato.IdCompra = IIf(TbIdCompra.Text = "", 0, TbIdCompra.Text)
        EntidadCompraPacasContrato.NombreProductor = TbNombre.Text
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        DgvCompras.Columns.Clear()
        DgvCompras.DataSource = Tabla
        'Dim colSelCon As New DataGridViewCheckBoxColumn()
        'colSelCon.Name = "Seleccionar"
        'colSelCon.FalseValue = False
        'colSelCon.Visible = True
        'DgvCompras.Columns.Insert(21, colSelCon)
        PropiedadesDgvCompras()
        DgvCompras.CurrentCell = Nothing
    End Sub
    Private Sub PropiedadesDgvCompras()
        DgvCompras.Columns("IdCompra").HeaderText = "ID"
        DgvCompras.Columns("IdContratoAlgodon").HeaderText = "Contrato"
        DgvCompras.Columns("Fecha").HeaderText = "Fecha"
        DgvCompras.Columns("IdEstatusCompra").HeaderText = "Estatus"
        DgvCompras.Columns("IdProductor").Visible = False
        DgvCompras.Columns("IdModalidadCompra").Visible = False
        DgvCompras.Columns("Observaciones").Visible = False
        DgvCompras.Columns("CastigoMicros").Visible = False
        DgvCompras.Columns("CastigoLargoFibra").Visible = False
        DgvCompras.Columns("CastigoResistenciaFibra").Visible = False
        DgvCompras.Columns("TotalPesosMx").Visible = False
        DgvCompras.Columns("TotalDlls").Visible = False
        DgvCompras.Columns("InteresPesosMx").Visible = False
        DgvCompras.Columns("InteresDlls").Visible = False
        DgvCompras.Columns("PrecioQuintal").Visible = False
        DgvCompras.Columns("PrecioQuintalBorregos").Visible = False
        DgvCompras.Columns("CastigoDls").Visible = False
        DgvCompras.Columns("subtotal").Visible = False
    End Sub
    Private Sub LimpiarCampos()
        TbIdCompra.Text = ""
        TbIdCompra.Text = ""
        DgvCompras.DataSource = ""
        DgvCompras.Columns.Clear()
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultaCompra()
    End Sub
    Private Sub DgvCompras_DoubleClick(sender As Object, e As EventArgs) Handles DgvCompras.DoubleClick
        Me.Close()
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DgvCompras.RowCount > 0 And DgvCompras.CurrentCell IsNot Nothing Then
            Dim _dataTable As DataTable = LoadDataTable()

            Dim estadoOperacion As Boolean = Me.Opener.LoadIDValues(_dataTable)

            e.Cancel = Not estadoOperacion
        End If
    End Sub
    Private Function LoadDataTable() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("IDCompra")
        dt.Columns.Add("IDProductor")
        dt.Columns.Add("Nombre")
        Dim row As DataRow = dt.NewRow()
        Dim Index As Integer

        Index = DgvCompras.CurrentCell.RowIndex

        row("IdCompra") = DgvCompras.Rows(Index).Cells("IdCompra").Value
        row("IDProductor") = DgvCompras.Rows(Index).Cells("IDProductor").Value
        row("Nombre") = DgvCompras.Rows(Index).Cells("Nombre").Value

        dt.Rows.Add(row)

        Return dt
    End Function
End Class