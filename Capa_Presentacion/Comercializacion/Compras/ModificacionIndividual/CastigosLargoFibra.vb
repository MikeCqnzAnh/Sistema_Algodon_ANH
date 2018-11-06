Imports Capa_Operacion.Configuracion
Public Class CastigosLargoFibra
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

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.VentaPacasContrato
        TablaCastigoLargoFibra.Clear()
        Dim TablaRenglonAInsertar As DataRow
        For Each row As DataGridViewRow In DgvCastigoLargoFibra.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            TablaRenglonAInsertar = TablaCastigoLargoFibra.NewRow()
            TablaRenglonAInsertar("IdLargoFibra") = DgvCastigoLargoFibra.Rows(Index).Cells("IdLargoFibra").Value
            TablaRenglonAInsertar("Rango1") = DgvCastigoLargoFibra.Rows(Index).Cells("Rango1").Value
            TablaRenglonAInsertar("Rango2") = DgvCastigoLargoFibra.Rows(Index).Cells("Rango2").Value
            TablaRenglonAInsertar("ColorGrade") = DgvCastigoLargoFibra.Rows(Index).Cells("ColorGrade").Value
            TablaRenglonAInsertar("castigo") = DgvCastigoLargoFibra.Rows(Index).Cells("castigo").Value
            TablaCastigoLargoFibra.Rows.Add(TablaRenglonAInsertar)
        Next
        Tabla = TablaCastigoLargoFibra
        Close()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
End Class