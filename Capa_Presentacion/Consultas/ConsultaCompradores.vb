Imports Capa_Operacion.Configuracion
Public Class ConsultaCompradores
    Private formOpener As IForm1
    Public Property Opener() As IForm1
        Get
            Return formOpener
        End Get
        Set(value As IForm1)
            formOpener = value
        End Set
    End Property
    Private Sub ConsultaCompradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        ConsultaCompradores()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbNombre.Text = ""
        DgvConsultaCompradores.DataSource = Nothing
    End Sub
    Private Sub ConsultaCompradores()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim Tabla As New DataTable
        EntidadContratosAlgodonCompradores.DescripcionConsulta = TbNombre.Text
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaCompradores
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        DgvConsultaCompradores.DataSource = EntidadContratosAlgodonCompradores.TablaConsulta
        DgvConsultaCompradores.CurrentCell = Nothing
    End Sub
    Private Sub DgvConsultaCompradores_CellContentDoubleClick(sender As Object, e As EventArgs) Handles DgvConsultaCompradores.DoubleClick
        'Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        'Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        'Dim index As Integer
        'index = DgvConsultaCompradores.CurrentRow.Index
        '_Id = DgvConsultaCompradores.Rows(index).Cells("IdComprador").Value.ToString()
        '_Nombre = DgvConsultaCompradores.Rows(index).Cells("Nombre").Value.ToString()
        Me.Close()
    End Sub

    Private Sub TbNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaCompradores()
        End Select
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DgvConsultaCompradores.RowCount > 0 And DgvConsultaCompradores.CurrentCell IsNot Nothing Then
            Dim _dataTable As DataTable = LoadDataTable()

            Dim estadoOperacion As Boolean = Me.Opener.LoadIdComprador(_dataTable)

            e.Cancel = Not estadoOperacion
        End If
    End Sub
    Private Function LoadDataTable() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("IdComprador")
        dt.Columns.Add("Nombre")
        Dim row As DataRow = dt.NewRow()
        Dim Index As Integer

        Index = DgvConsultaCompradores.CurrentCell.RowIndex

        row("IdComprador") = DgvConsultaCompradores.Rows(Index).Cells("IdComprador").Value
        row("Nombre") = DgvConsultaCompradores.Rows(Index).Cells("Nombre").Value

        dt.Rows.Add(row)

        Return dt
    End Function
End Class