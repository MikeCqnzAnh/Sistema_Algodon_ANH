Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaOrdenEmbarqueComprador
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultaCompradores()
    End Sub
    Private Sub ConsultaCompradores()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim Tabla As New DataTable
        EntidadContratosAlgodonCompradores.DescripcionConsulta = TbComprador.Text
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaCompradores
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        DgvCompradores.DataSource = EntidadContratosAlgodonCompradores.TablaConsulta
        DgvCompradores.CurrentCell = Nothing
    End Sub

    Private Sub DgvCompradores_DoubleClick(sender As Object, e As EventArgs) Handles DgvCompradores.DoubleClick
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim index As Integer
        index = DgvCompradores.CurrentRow.Index
        _Id = DgvCompradores.Rows(index).Cells("IdComprador").Value.ToString()
        _NombreComprador = DgvCompradores.Rows(index).Cells("Nombre").Value.ToString()
        Me.Close()
    End Sub

    Private Sub TbComprador_KeyDown(sender As Object, e As KeyEventArgs) Handles TbComprador.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaCompradores()
        End Select
    End Sub
End Class