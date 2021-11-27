Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class CastigosLargoFibraVenta
    Public TablaCastigoLargoFibra As New DataTable
    Private Sub CastigosLargoFibra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaCastigoLargoFibra.Columns.Clear()
        TablaCastigoLargoFibra.Columns.Add(New DataColumn("IdLargoFibra", System.Type.GetType("System.Int32")))
        TablaCastigoLargoFibra.Columns.Add(New DataColumn("Rango1", System.Type.GetType("System.Double")))
        TablaCastigoLargoFibra.Columns.Add(New DataColumn("Rango2", System.Type.GetType("System.Double")))
        TablaCastigoLargoFibra.Columns.Add(New DataColumn("ColorGrade", System.Type.GetType("System.String")))
        TablaCastigoLargoFibra.Columns.Add(New DataColumn("castigo", System.Type.GetType("System.Double")))
        ConsultarLargoFibra()
    End Sub

    Private Sub ConsultarLargoFibra()
        Dim EntidadConsultaCastigos As New Capa_Entidad.ConsultaCastigos
        Dim NegocioConsultaCastigos As New Capa_Negocio.ConsultaCastigos
        EntidadConsultaCastigos.Consulta = Consulta.ConsultaLargoFibra
        'EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
        NegocioConsultaCastigos.Consultar(EntidadConsultaCastigos)
        Tabla = EntidadConsultaCastigos.TablaConsulta
        DgvCastigoLargoFibra.DataSource = Tabla
    End Sub
End Class