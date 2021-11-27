Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class CastigosResistenciaFibraVenta
    Public TablaCastigoResistenciaFibra As New DataTable
    Private Sub CastigosResistenciaFibra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaCastigoResistenciaFibra.Columns.Clear()
        TablaCastigoResistenciaFibra.Columns.Add(New DataColumn("IdResistenciaFibra", System.Type.GetType("System.Int32")))
        TablaCastigoResistenciaFibra.Columns.Add(New DataColumn("Rango1", System.Type.GetType("System.Double")))
        TablaCastigoResistenciaFibra.Columns.Add(New DataColumn("Rango2", System.Type.GetType("System.Double")))
        TablaCastigoResistenciaFibra.Columns.Add(New DataColumn("castigo", System.Type.GetType("System.Double")))
        ConsultarResistenciaFibra()
    End Sub
    Private Sub ConsultarResistenciaFibra()
        Dim EntidadConsultaCastigos As New Capa_Entidad.ConsultaCastigos
        Dim NegocioConsultaCastigos As New Capa_Negocio.ConsultaCastigos
        EntidadConsultaCastigos.Consulta = Consulta.ConsultaResistenciaFibra
        'EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
        NegocioConsultaCastigos.Consultar(EntidadConsultaCastigos)
        Tabla = EntidadConsultaCastigos.TablaConsulta
        DgvCastigoResistenciaFibra.DataSource = Tabla
    End Sub
End Class