Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class CastigosMicro
    Public TablaCastigoMicros As New DataTable
    Private Sub CastigosMicro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaCastigoMicros.Columns.Clear()
        TablaCastigoMicros.Columns.Add(New DataColumn("IdMicro", System.Type.GetType("System.Int32")))
        TablaCastigoMicros.Columns.Add(New DataColumn("Rango1", System.Type.GetType("System.Double")))
        TablaCastigoMicros.Columns.Add(New DataColumn("Rango2", System.Type.GetType("System.Double")))
        TablaCastigoMicros.Columns.Add(New DataColumn("castigo", System.Type.GetType("System.Double")))
        ConsultarMicros()
    End Sub
    Private Sub ConsultarMicros()
        Dim EntidadConsultaCastigos As New Capa_Entidad.ConsultaCastigos
        Dim NegocioConsultaCastigos As New Capa_Negocio.ConsultaCastigos
        EntidadConsultaCastigos.Consulta = Consulta.ConsultaMicros
        'EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
        NegocioConsultaCastigos.Consultar(EntidadConsultaCastigos)
        Tabla = EntidadConsultaCastigos.TablaConsulta
        DgvCastigoMicros.DataSource = Tabla
    End Sub
End Class