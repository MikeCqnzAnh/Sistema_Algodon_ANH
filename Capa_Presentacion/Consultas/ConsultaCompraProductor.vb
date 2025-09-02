Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaCompraProductor
    Public Property idcompra_ As Integer
    Public Property idproductor_ As Integer
    Public Property nombreproductor_ As String
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
        If DgvCompras.Rows.Count > 0 Then
            Dim index As Integer
            index = DgvCompras.CurrentCell.RowIndex
            idcompra_ = DgvCompras.Rows(index).Cells("idcompra").Value
            idproductor_ = DgvCompras.Rows(index).Cells("idproductor").Value
            nombreproductor_ = DgvCompras.Rows(index).Cells("nombre").Value
            Close()
        End If
    End Sub
    Private Sub SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdCompra.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TbNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNombre.KeyDown, TbIdCompra.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaCompra()
        End Select
    End Sub
End Class