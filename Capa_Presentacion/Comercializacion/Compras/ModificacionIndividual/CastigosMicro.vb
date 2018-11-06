Imports Capa_Operacion.Configuracion
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

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.VentaPacasContrato
        TablaCastigoMicros.Clear()
        Dim TablaRenglonAInsertar As DataRow
        For Each row As DataGridViewRow In DgvCastigoMicros.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            TablaRenglonAInsertar = TablaCastigoMicros.NewRow()
            TablaRenglonAInsertar("IdMicro") = DgvCastigoMicros.Rows(Index).Cells("IdMicro").Value
            TablaRenglonAInsertar("Rango1") = DgvCastigoMicros.Rows(Index).Cells("Rango1").Value
            TablaRenglonAInsertar("Rango2") = DgvCastigoMicros.Rows(Index).Cells("Rango2").Value
            TablaRenglonAInsertar("castigo") = DgvCastigoMicros.Rows(Index).Cells("castigo").Value
            TablaCastigoMicros.Rows.Add(TablaRenglonAInsertar)
        Next
        Tabla = TablaCastigoMicros
        Close()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
End Class