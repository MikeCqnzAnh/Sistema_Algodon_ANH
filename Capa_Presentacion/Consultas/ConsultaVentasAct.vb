Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaVentasAct
    Private IdVenta As Integer
    Private IdContrato As Integer
    Private IdComprador As Integer
    Private Nombre As String
    Public Property _idventa As Integer
        Get
            Return IdVenta
        End Get
        Set(value As Integer)
            IdVenta = value
        End Set
    End Property
    Public Property _IdContrato As Integer
        Get
            Return IdContrato
        End Get
        Set(value As Integer)
            IdContrato = value
        End Set
    End Property
    Public Property _IdComprador As Integer
        Get
            Return IdComprador
        End Get
        Set(value As Integer)
            IdComprador = value
        End Set
    End Property
    Public Property _Nombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
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

    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultaVenta()
    End Sub

    Private Sub DgvVentas_DoubleClick(sender As Object, e As EventArgs) Handles DgvVentas.DoubleClick
        Try
            If DgvVentas.Rows.Count > 0 Then
                Dim Index As Integer

                Index = DgvVentas.CurrentCell.RowIndex

                IdVenta = DgvVentas.Rows(Index).Cells("IDVenta").Value
                IdContrato = DgvVentas.Rows(Index).Cells("IdContratoAlgodon").Value
                IdComprador = DgvVentas.Rows(Index).Cells("IDComprador").Value
                Nombre = DgvVentas.Rows(Index).Cells("Nombre").Value

                Me.Close()
            Else
                MsgBox("No hay registros para seleccionar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " No hay registro seleccionado.")
        End Try

    End Sub

    Private Sub ConsultaVentasAct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub TbIdVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdVenta.KeyDown, TbNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaVenta()
        End Select
    End Sub
End Class