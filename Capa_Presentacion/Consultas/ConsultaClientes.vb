Imports Capa_Operacion.Configuracion
Public Class ConsultaClientes
    Private _IdCliente As Integer
    Public Property IdCliente() As Integer
        Get
            Return _IdCliente
        End Get
        Set(value As Integer)
            _IdCliente = value
        End Set
    End Property
    Private Sub ConsultaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbIdCliente.Select()
        ConsultarClientes()
    End Sub
    Private Sub ConsultarClientes()
        Dim tabla2 As New DataTable
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        EntidadClientes.Consulta = Consulta.ConsultaBasica
        EntidadClientes.Nombre = TbNombre.Text
        EntidadClientes.IdCliente = IIf(TbIdCliente.Text = "", 0, TbIdCliente.Text)
        NegocioClientes.Consultar(EntidadClientes)
        tabla2 = EntidadClientes.TablaConsulta
        DgvConsultaClientes.DataSource = tabla2
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        ConsultarClientes()
    End Sub
    Private Sub DgvConsultaClientes_DoubleClick(sender As Object, e As EventArgs) Handles DgvConsultaClientes.DoubleClick
        If DgvConsultaClientes.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvConsultaClientes.CurrentCell.RowIndex
            _IdCliente = DgvConsultaClientes.Rows(index).Cells("IdCliente").Value
            _Nombre = DgvConsultaClientes.Rows(index).Cells("Nombre").Value
            Close()
        End If
    End Sub

    Private Sub TbNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNombre.KeyDown, TbIdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsultarClientes()
        End If
    End Sub
End Class