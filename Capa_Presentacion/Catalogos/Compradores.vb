Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
Public Class Compradores
    Private Sub Compradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        ConsultaBasicaComprador()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadCompradores As New Capa_Entidad.Compradores
        Dim NegocioCompradores As New Capa_Negocio.Compradores
        EntidadCompradores.IdComprador = IIf(TbIdComprador.Text = "", 0, TbIdComprador.Text)
        EntidadCompradores.Nombre = TbNombre.Text
        EntidadCompradores.Rfc = TbRfc.Text
        EntidadCompradores.Curp = TbCurp.Text
        EntidadCompradores.Domicilio = TbDomicilio.Text
        EntidadCompradores.IdEstado = CbEstado.SelectedValue
        EntidadCompradores.idMunicipio = CbMunicipio.SelectedValue
        EntidadCompradores.Telefono = TbTelefono.Text
        EntidadCompradores.Correo = TbCorreo.Text
        EntidadCompradores.IdEstatus = CbEstatus.SelectedValue
        EntidadCompradores.IdUsuarioCreacion = 1
        EntidadCompradores.FechaCreacion = Now
        NegocioCompradores.Guardar(EntidadCompradores)
        TbIdComprador.Text = EntidadCompradores.IdComprador
        MsgBox("Realizado Correctamente")
        ConsultaBasicaComprador()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Limpiar()
        TbIdComprador.Text = ""
        TbNombre.Text = ""
        TbRfc.Text = ""
        TbCurp.Text = ""
        TbDomicilio.Text = ""
        CbEstado.SelectedValue = 6
        CbMunicipio.SelectedValue = 1
        TbTelefono.Text = ""
        TbCorreo.Text = ""
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

    End Sub

    Private Sub ConsultaBasicaComprador()
        Dim EntidadCompradores As New Capa_Entidad.Compradores
        Dim NegocioCompradores As New Capa_Negocio.Compradores
        Dim Tabla As New DataTable
        'EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadCompradores.Consulta = Consulta.ConsultaBasica
        NegocioCompradores.Consultar(EntidadCompradores)
        DgvCompradores.DataSource = EntidadCompradores.TablaConsulta
    End Sub

    Private Sub DgvCompradores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCompradores.CellContentDoubleClick

    End Sub

    Private Sub LlenarCombos()
        '---------------------------CONSULTA ESTADOS
        Dim tabla As New DataTable
        Dim EntidadCompradores As New Capa_Entidad.Compradores
        Dim NegocioCompradores As New Capa_Negocio.Compradores
        EntidadCompradores.Consulta = Consulta.ConsultaEstado
        NegocioCompradores.Consultar(EntidadCompradores)
        tabla = EntidadCompradores.TablaConsulta
        CbEstado.DataSource = tabla
        CbEstado.ValueMember = "IdEstado"
        CbEstado.DisplayMember = "Descripcion"
        CbEstado.SelectedValue = 6
        '---------------------------CONSULTA MUNICIPIOS       
        Dim tabla2 As New DataTable
        EntidadCompradores.IdEstado = CbEstado.SelectedValue
        EntidadCompradores.Consulta = Consulta.ConsultaMunicipio
        NegocioCompradores.Consultar(EntidadCompradores)
        tabla2 = EntidadCompradores.TablaConsulta
        CbMunicipio.DataSource = tabla2
        CbMunicipio.ValueMember = "IdMunicipio"
        CbMunicipio.DisplayMember = "Descripcion"
        CbMunicipio.SelectedValue = 1
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "2"
        dr("Descripcion") = "Inactivo"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Id"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedValue = 1
    End Sub
End Class