Imports Capa_Operacion.Configuracion
Public Class ConsultaVentas
    Private formOpen As IForm1
    Public Property Opener() As IForm1
        Get
            Return formOpen
        End Get
        Set(ByVal value As IForm1)
            formOpen = value
        End Set
    End Property
    Private Sub ConsultaCompraProductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
    End Sub
    Private Sub ConsultaVenta()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        EntidadVentaPacasContrato.Consulta = Consulta.ConsultaVentaPorNombre
        EntidadVentaPacasContrato.IdVenta = IIf(TbIdVenta.Text = "", 0, TbIdVenta.Text)
        EntidadVentaPacasContrato.NombreComprador = TbNombre.Text
        NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
        Tabla = EntidadVentaPacasContrato.TablaConsulta
        DgvVentas.Columns.Clear()
        DgvVentas.DataSource = Tabla
        'Dim colSelCon As New DataGridViewCheckBoxColumn()
        'colSelCon.Name = "Seleccionar"
        'colSelCon.FalseValue = False
        'colSelCon.Visible = True
        'DgvCompras.Columns.Insert(21, colSelCon)
        PropiedadesDgvCompras()
        DgvVentas.CurrentCell = Nothing
    End Sub
    Private Sub PropiedadesDgvCompras()
        DgvVentas.Columns("IdVenta").HeaderText = "ID"
        DgvVentas.Columns("IdContratoAlgodon").HeaderText = "Contrato"
        DgvVentas.Columns("Fecha").HeaderText = "Fecha"
        DgvVentas.Columns("IdEstatusVenta").HeaderText = "Estatus"
        DgvVentas.Columns("IdComprador").Visible = False
        DgvVentas.Columns("IdModalidadVenta").Visible = False
        DgvVentas.Columns("Observaciones").Visible = False
        DgvVentas.Columns("CastigoMicros").Visible = False
        DgvVentas.Columns("CastigoLargoFibra").Visible = False
        DgvVentas.Columns("CastigoResistenciaFibra").Visible = False
        DgvVentas.Columns("TotalPesosMx").Visible = False
        DgvVentas.Columns("TotalDlls").Visible = False
        DgvVentas.Columns("InteresPesosMx").Visible = False
        DgvVentas.Columns("InteresDlls").Visible = False
        DgvVentas.Columns("PrecioQuintal").Visible = False
        DgvVentas.Columns("PrecioQuintalBorregos").Visible = False
        DgvVentas.Columns("CastigoDls").Visible = False
        DgvVentas.Columns("subtotal").Visible = False
    End Sub
    Private Sub LimpiarCampos()
        TbIdVenta.Text = ""
        TbNombre.Text = ""
        DgvVentas.DataSource = ""
        DgvVentas.Columns.Clear()
        TbIdVenta.Select()
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultaVenta()
    End Sub
    Private Sub DgvCompras_DoubleClick(sender As Object, e As EventArgs) Handles DgvVentas.DoubleClick
        Me.Close()
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DgvVentas.RowCount > 0 And DgvVentas.CurrentCell IsNot Nothing Then
            Dim _dataTable As DataTable = LoadDataTable()

            Dim estadoOperacion As Boolean = Me.Opener.LoadIdVenta(_dataTable)

            e.Cancel = Not estadoOperacion
        End If
    End Sub

    Private Function LoadDataTable() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("IDVenta")
        dt.Columns.Add("IDComprador")
        dt.Columns.Add("Nombre")
        Dim row As DataRow = dt.NewRow()
        Dim Index As Integer

        Index = DgvVentas.CurrentCell.RowIndex

        row("IDVenta") = DgvVentas.Rows(Index).Cells("IDVenta").Value
        row("IDComprador") = DgvVentas.Rows(Index).Cells("IDComprador").Value
        row("Nombre") = DgvVentas.Rows(Index).Cells("Nombre").Value

        dt.Rows.Add(row)

        Return dt
    End Function

    Private Sub TbIdVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdVenta.KeyDown, TbNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaVenta()
        End Select
    End Sub
End Class