Imports Capa_Operacion.Configuracion
Public Class MatExtCompras
    Private Sub MatExtCompras_Load(sender As Object, e As EventArgs) Handles Me.Load
        limpiar()
        CastigosMatExt()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub CastigosMatExt()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        Dim Tabla As New DataTable
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoMatExtCompra
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        NuBarkLevel1.Value = Tabla.Rows(0).Item("Nivel1").ToString
        NuPrepLevel1.Value = Tabla.Rows(1).Item("Nivel1").ToString
        NuOtherLevel1.Value = Tabla.Rows(2).Item("Nivel1").ToString
        NuPlasticLevel1.Value = Tabla.Rows(3).Item("Nivel1").ToString
        NuBarkLevel2.Value = Tabla.Rows(0).Item("Nivel2").ToString
        NuPrepLevel2.Value = Tabla.Rows(1).Item("Nivel2").ToString
        NuOtherLevel2.Value = Tabla.Rows(2).Item("Nivel2").ToString
        NuPlasticLevel2.Value = Tabla.Rows(3).Item("Nivel2").ToString
    End Sub
    Private Sub limpiar()
        RbSinCastigoLevel1.Checked = True
        RbSinCastigoLevel2.Checked = True
        'NuBarkLevel1.Value = 0
        'NuBarkLevel2.Value = 0
        'NuPrepLevel1.Value = 0
        'NuPrepLevel2.Value = 0
        'NuOtherLevel1.Value = 0
        'NuOtherLevel2.Value = 0
        'NuPlasticLevel1.Value = 0
        'NuPlasticLevel2.Value = 0
        TbNoPaca.Text = ""
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class