Imports Capa_Operacion.Configuracion
Public Class ConsultaCompradoresSalidas
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Private Sub ConsultaCompradoresSalidas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Id = 0
        Nombre = ""
        DgvConsultaCompradores.DataSource = ""
    End Sub
    Private Sub Limpiar()
        TbNombre.Text = ""
        DgvConsultaCompradores.DataSource = ""
        TbNombre.Select()
    End Sub
    Private Sub ConsultaSalida()
        Try
            Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
            Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
            Dim Tabla As New DataTable
            EntidadSalidaPacas.Consulta = Consulta.ConsultaCompradores
            EntidadSalidaPacas.NombreComprador = TbNombre.Text
            NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
            DgvConsultaCompradores.DataSource = EntidadSalidaPacas.TablaConsulta
            'PropiedadesDgv()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultaSalida()
    End Sub
    Private Sub EventoKeypress(sender As Object, e As KeyEventArgs) Handles TbNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaSalida()
        End Select
    End Sub
    Private Sub DgvConsultaEmbarque_DoubleClick(sender As Object, e As EventArgs) Handles DgvConsultaCompradores.DoubleClick
        If DgvConsultaCompradores.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvConsultaCompradores.CurrentCell.RowIndex
            _Id = DgvConsultaCompradores.Rows(index).Cells("IdComprador").Value
            _Nombre = DgvConsultaCompradores.Rows(index).Cells("Nombre").Value
            Close()
        End If
    End Sub
End Class