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
        LlenarCombos()
        ConsultarClientes()
    End Sub

    Private Sub LlenarCombos()
        Dim tabla1 As New DataTable
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        EntidadClientes.Consulta = Consulta.ConsultaTipoPersona
        NegocioClientes.Consultar(EntidadClientes)
        tabla1 = EntidadClientes.TablaConsulta
        Dim dr As DataRow
        dr = tabla1.NewRow()
        dr("IdTipoPersona") = "3"
        dr("Descripcion") = "Todos"
        tabla1.Rows.Add(dr)
        CbTIpoPersona.DataSource = tabla1
        CbTIpoPersona.ValueMember = "IdTipoPersona"
        CbTIpoPersona.DisplayMember = "Descripcion"
        CbTIpoPersona.SelectedValue = 3
    End Sub

    Private Sub ConsultarClientes()
        Dim tabla2 As New DataTable
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        EntidadClientes.Consulta = Consulta.ConsultaBasica
        EntidadClientes.IdTipoPersona = CbTIpoPersona.SelectedValue
        NegocioClientes.Consultar(EntidadClientes)
        tabla2 = EntidadClientes.TablaConsulta
        DgvConsultaClientes.DataSource = tabla2
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        ConsultarClientes()
    End Sub

    Private Sub DgvConsultaClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvConsultaClientes.CellContentDoubleClick
        If DgvConsultaClientes.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvConsultaClientes.CurrentCell.RowIndex
            _IdCliente = DgvConsultaClientes.Rows(index).Cells("IdCliente").Value
            Close()
        End If
    End Sub
End Class