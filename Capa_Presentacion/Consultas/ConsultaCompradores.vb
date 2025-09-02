Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaCompradores
    Public Property idcomprador_ As Integer
    Public Property nombre_ As String
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
        If DgvConsultaCompradores.Rows.Count > 0 Then
            Dim index As Integer
            index = DgvConsultaCompradores.CurrentRow.Index
            idcomprador_ = DgvConsultaCompradores.Rows(index).Cells("IdComprador").Value.ToString()
            nombre_ = DgvConsultaCompradores.Rows(index).Cells("Nombre").Value.ToString()
            Me.Close()
        End If
    End Sub

    Private Sub TbNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaCompradores()
        End Select
    End Sub
End Class