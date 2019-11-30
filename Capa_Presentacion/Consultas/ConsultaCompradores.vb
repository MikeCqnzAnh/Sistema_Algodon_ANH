Imports Capa_Operacion.Configuracion
Public Class ConsultaCompradores
    Private Sub ConsultaCompradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        ConsultaProductores()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbNombre.Text = ""
        DgvConsultaCompradores.DataSource = Nothing
    End Sub
    Private Sub ConsultaProductores()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim Tabla As New DataTable
        EntidadContratosAlgodonCompradores.DescripcionConsulta = TbNombre.Text
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaCompradores
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        DgvConsultaCompradores.DataSource = EntidadContratosAlgodonCompradores.TablaConsulta
    End Sub
    Private Sub DgvConsultaCompradores_CellContentDoubleClick(sender As Object, e As EventArgs) Handles DgvConsultaCompradores.DoubleClick
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        Dim index As Integer
        index = DgvConsultaCompradores.CurrentRow.Index
        _Id = DgvConsultaCompradores.Rows(index).Cells("IdComprador").Value.ToString()
        _Nombre = DgvConsultaCompradores.Rows(index).Cells("Nombre").Value.ToString()
        Close()
    End Sub

    Private Sub TbNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaProductores()
        End Select
    End Sub
End Class