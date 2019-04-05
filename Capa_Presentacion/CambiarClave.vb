Imports Capa_Operacion.Configuracion
Public Class CambiarClave
    Private Sub CambiarClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaBDD()
    End Sub
    Private Sub ConsultaBDD()
        Dim tabla As New DataTable
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        tabla = EntidadConfiguracionParametros.TablaConsulta
        For Each Fila As DataGridViewRow In tabla.Rows

        Next
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub
End Class