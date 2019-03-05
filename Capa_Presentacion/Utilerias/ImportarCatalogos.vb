Imports Capa_Operacion.Configuracion
Public Class ImportarCatalogos
    Private Sub ImportarCatalogos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaCombos()
    End Sub
    Private Sub llenaCombos()
        Dim tabla As New DataTable
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        tabla = EntidadConfiguracionParametros.TablaConsulta
        CbDestino.DataSource = tabla
        CbDestino.ValueMember = "database_id"
        CbDestino.DisplayMember = "name"
        CbDestino.SelectedIndex = -1

        CbOrigen.DataSource = tabla
        CbOrigen.ValueMember = "database_id"
        CbOrigen.DisplayMember = "name"
        CbOrigen.SelectedIndex = -1
    End Sub


End Class