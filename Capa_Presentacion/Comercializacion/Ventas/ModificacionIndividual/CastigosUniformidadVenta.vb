Imports Capa_Operacion.Configuracion
Public Class CastigosUniformidadVenta
    Private Sub ConsultaModosDetalleParametro(ByVal Id As Integer)
        Dim EntidadCastigoResistenciaFibra As New Capa_Entidad.CastigoResistenciaFibra
        Dim NegocioCastigoResistenciaFibra As New Capa_Negocio.CastigoResistenciaFibra
        Dim Tabla As New DataTable
        EntidadCastigoResistenciaFibra.Consulta = Consulta.ConsultaDetallada
        EntidadCastigoResistenciaFibra.IdResistenciaEncabezado = Id
        NegocioCastigoResistenciaFibra.Consultar(EntidadCastigoResistenciaFibra)
        DgvCastigosUniformidad.DataSource = EntidadCastigoResistenciaFibra.TablaConsulta
        'DgvDetallePropiedades()
    End Sub
End Class