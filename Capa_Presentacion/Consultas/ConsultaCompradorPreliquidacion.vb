Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaCompradorPreliquidacion
    Private _idcomprador As Integer
    Public Property IdComprador() As Integer
        Get
            Return _idcomprador
        End Get
        Set(value As Integer)
            _idcomprador = value
        End Set
    End Property
    Private _nombrecomprador As String
    Public Property nombrecomprador() As String
        Get
            Return _nombrecomprador
        End Get
        Set(value As String)
            _nombrecomprador = value
        End Set
    End Property
    Private Sub ConsultaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbComprador.Select()
        ConsultaCompradores()
    End Sub
    Private Sub ConsultaCompradores()
        Dim tabla2 As New DataTable
        Dim EntidadCompradores As New Capa_Entidad.Compradores
        Dim NegocioCompradores As New Capa_Negocio.Compradores
        EntidadCompradores.Consulta = Consulta.ConsultaBasica
        EntidadCompradores.Nombre = TbComprador.Text
        NegocioCompradores.Consultar(EntidadCompradores)
        tabla2 = EntidadCompradores.TablaConsulta
        DgvProductores.DataSource = tabla2
    End Sub

    Private Sub BtBuscar_Click_1(sender As Object, e As EventArgs) Handles BtBuscar.Click
        ConsultaCompradores()
    End Sub
    Private Sub DgvConsultaClientes_DoubleClick(sender As Object, e As EventArgs) Handles DgvProductores.DoubleClick
        If DgvProductores.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvProductores.CurrentCell.RowIndex
            _idcomprador = DgvProductores.Rows(index).Cells("idcomprador").Value
            _nombrecomprador = DgvProductores.Rows(index).Cells("nombre").Value

            Close()
        End If
    End Sub

    Private Sub TbNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbComprador.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsultaCompradores()
        End If
    End Sub
End Class