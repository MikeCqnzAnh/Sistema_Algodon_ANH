Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaVentas
    Public Property _idventa As Integer
    Public Property _idcomprador As Integer
    Public Property _nombre As String
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
        If DgvVentas.Rows.Count > 0 Then
            Dim index As Integer
            index = DgvVentas.CurrentRow.Index
            _idventa = DgvVentas.Rows(index).Cells("Idventa").Value
            _idcomprador = DgvVentas.Rows(index).Cells("IdComprador").Value
            _nombre = DgvVentas.Rows(index).Cells("Nombre").Value.ToString()
            Me.Close()
        End If
    End Sub

    Private Sub TbIdVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdVenta.KeyDown, TbNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaVenta()
        End Select
    End Sub
End Class