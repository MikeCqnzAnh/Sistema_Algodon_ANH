Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class CompraPacas
    Private Sub CompraPacas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCombos()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub CargaCombos()
        '---Plantas--
        Dim EntidadCompraPacas As New Capa_Entidad.VentaPacas
        Dim NegocioCompraPacas As New Capa_Negocio.VentaPacas
        Dim Tabla As New DataTable
        EntidadCompraPacas.Consulta = Consulta.ConsultaExterna
        NegocioCompraPacas.Consultar(EntidadCompraPacas)
        Tabla = EntidadCompraPacas.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = 1
        '---Productores---
        Dim Tabla2 As New DataTable
        EntidadCompraPacas.Consulta = Consulta.ConsultaProductores
        NegocioCompraPacas.Consultar(EntidadCompraPacas)
        Tabla2 = EntidadCompraPacas.TablaConsulta
        CbProductor.DataSource = Tabla2
        CbProductor.ValueMember = "IdCliente"
        CbProductor.DisplayMember = "Nombre"
        CbProductor.SelectedValue = 1
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

    End Sub
End Class