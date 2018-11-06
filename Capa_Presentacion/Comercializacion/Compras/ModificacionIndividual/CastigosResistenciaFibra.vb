Imports Capa_Operacion.Configuracion
Public Class CastigosResistenciaFibra
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

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.VentaPacasContrato
        TablaCastigoResistenciaFibra.Clear()
        Dim TablaRenglonAInsertar As DataRow
        For Each row As DataGridViewRow In DgvCastigoResistenciaFibra.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            TablaRenglonAInsertar = TablaCastigoResistenciaFibra.NewRow()
            TablaRenglonAInsertar("IdResistenciaFibra") = DgvCastigoResistenciaFibra.Rows(Index).Cells("IdResistenciaFibra").Value
            TablaRenglonAInsertar("Rango1") = DgvCastigoResistenciaFibra.Rows(Index).Cells("Rango1").Value
            TablaRenglonAInsertar("Rango2") = DgvCastigoResistenciaFibra.Rows(Index).Cells("Rango2").Value
            TablaRenglonAInsertar("castigo") = DgvCastigoResistenciaFibra.Rows(Index).Cells("castigo").Value
            TablaCastigoResistenciaFibra.Rows.Add(TablaRenglonAInsertar)
        Next
        Tabla = TablaCastigoResistenciaFibra
        Close()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
End Class