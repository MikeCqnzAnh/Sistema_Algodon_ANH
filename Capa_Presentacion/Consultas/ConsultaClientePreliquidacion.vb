Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaClientePreliquidacion
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
        TbProductor.Select()
        ConsultarClientes()
    End Sub
    Private Sub ConsultarClientes()
        Dim tabla2 As New DataTable
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        EntidadClientes.Consulta = Consulta.ConsultaBasica
        EntidadClientes.Nombre = TbProductor.Text
        NegocioClientes.Consultar(EntidadClientes)
        tabla2 = EntidadClientes.TablaConsulta
        DgvProductores.DataSource = tabla2
    End Sub

    Private Sub BtBuscar_Click_1(sender As Object, e As EventArgs) Handles BtBuscar.Click
        ConsultarClientes()
    End Sub
    Private Sub DgvConsultaClientes_DoubleClick(sender As Object, e As EventArgs) Handles DgvProductores.DoubleClick
        If DgvProductores.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvProductores.CurrentCell.RowIndex
            _IdCliente = DgvProductores.Rows(index).Cells("IdCliente").Value
            Close()
        End If
    End Sub

    Private Sub TbNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbProductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsultarClientes()
        End If
    End Sub
End Class