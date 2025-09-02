Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class CastigosUniformidad
    Public TablaCastigoUniformidad As New DataTable
    Private Sub CastigosUniformidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaCastigoUniformidad.Columns.Clear()
        TablaCastigoUniformidad.Columns.Add(New DataColumn("IdResistenciaFibra", System.Type.GetType("System.Int32")))
        TablaCastigoUniformidad.Columns.Add(New DataColumn("Rango1", System.Type.GetType("System.Double")))
        TablaCastigoUniformidad.Columns.Add(New DataColumn("Rango2", System.Type.GetType("System.Double")))
        TablaCastigoUniformidad.Columns.Add(New DataColumn("castigo", System.Type.GetType("System.Double")))
        ConsultarResistenciaFibra()
    End Sub

    Private Sub ConsultarResistenciaFibra()
        Dim EntidadConsultaCastigos As New Capa_Entidad.ConsultaCastigos
        Dim NegocioConsultaCastigos As New Capa_Negocio.ConsultaCastigos
        EntidadConsultaCastigos.Consulta = Consulta.ConsultaUniformidad
        'EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
        NegocioConsultaCastigos.Consultar(EntidadConsultaCastigos)
        Tabla = EntidadConsultaCastigos.TablaConsulta
        DgvCastigoUniformidad.DataSource = Tabla
    End Sub
End Class