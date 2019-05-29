Imports Capa_Operacion.Configuracion
Public Class Almacenes
    Private Sub Almacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        LlenaCombos()
        Consultar()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbIdBodega.Text = ""
        TbDescripcion.Text = ""
        CbTipo.SelectedIndex = -1
        TbCalle.Text = ""
        TbNumero.Text = ""
        TbCodigoPostal.Text = ""
        TbColonia.Text = ""
        CbCiudad.SelectedIndex = -1
        CbEstado.SelectedIndex = -1
        NuCapacidad.Value = 0
    End Sub
    Private Sub AgregarTipoDeAlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarTipoDeAlmacenToolStripMenuItem.Click
        TipoAlmacen.ShowDialog()
        LlenaCombos()
    End Sub
    Private Sub Guardar()
        Try
            If TbDescripcion.Text <> "" Then
                Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
                Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
                EntidadAlmacenes.IdTipoAlmacen = IIf(TbIdBodega.Text = "", 0, TbIdBodega.Text)
                EntidadAlmacenes.Descripcion = TbDescripcion.Text
                EntidadAlmacenes.IdTipoAlmacen = CbTipo.SelectedValue
                EntidadAlmacenes.Calle = TbCalle.Text
                EntidadAlmacenes.Numero = TbNumero.Text
                EntidadAlmacenes.CodigoPostal = TbCodigoPostal.Text
                EntidadAlmacenes.Colonia = TbColonia.Text
                EntidadAlmacenes.Ciudad = CbCiudad.SelectedValue
                EntidadAlmacenes.Estado = CbEstado.SelectedValue
                EntidadAlmacenes.Capacidad = NuCapacidad.Value
                EntidadAlmacenes.Actualiza = Actuliza.ActualizaAlmacen
                NegocioAlmacenes.Guardar(EntidadAlmacenes)
                TbIdBodega.Text = EntidadAlmacenes.IdTipoAlmacen
                Consultar()
            Else
                MessageBox.Show("El campo descripcion no puede estar vacio.", "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Consultar()
        Try
            Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
            Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
            Dim Tabla As New DataTable
            EntidadAlmacenes.Consulta = Consulta.ConsultaAlmacen
            NegocioAlmacenes.Consultar(EntidadAlmacenes)
            DgvBodegas.DataSource = EntidadAlmacenes.TablaConsulta
            FormatoDatagrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FormatoDatagrid()
        DgvBodegas.Columns("IdAlmacen").Visible = False
        DgvBodegas.Columns("IdTipoAlmacen").Visible = False
        DgvBodegas.Columns("Calle").Visible = False
        DgvBodegas.Columns("Numero").Visible = False
        DgvBodegas.Columns("CodigoPostal").Visible = False
        DgvBodegas.Columns("Colonia").Visible = False
        DgvBodegas.Columns("Estado").Visible = False
        DgvBodegas.Columns("Ciudad").Visible = False
    End Sub
    Private Sub LlenaCombos()
        Dim tabla As New DataTable
        Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
        Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
        EntidadAlmacenes.IdTipoAlmacen = CbTipo.SelectedValue
        EntidadAlmacenes.Consulta = Consulta.ConsultaBasica
        NegocioAlmacenes.Consultar(EntidadAlmacenes)
        tabla = EntidadAlmacenes.TablaConsulta
        CbTipo.DataSource = tabla
        CbTipo.ValueMember = "IdTipoAlmacen"
        CbTipo.DisplayMember = "Descripcion"
        CbTipo.SelectedIndex = -1

        '---------------------------CONSULTA ESTADOS
        Dim tabla1 As New DataTable
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        EntidadClientes.Consulta = Consulta.ConsultaEstado
        NegocioClientes.Consultar(EntidadClientes)
        tabla1 = EntidadClientes.TablaConsulta
        CbEstado.DataSource = tabla1
        CbEstado.ValueMember = "IdEstado"
        CbEstado.DisplayMember = "Descripcion"
        CbEstado.SelectedIndex = -1

    End Sub
    Private Sub CargaComboMunicipios()
        '---------------------------CONSULTA MUNICIPIOS       
        Dim tabla2 As New DataTable
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        EntidadClientes.IdEstadoFisica = CbEstado.SelectedValue
        EntidadClientes.Consulta = Consulta.ConsultaMunicipio
        NegocioClientes.Consultar(EntidadClientes)
        tabla2 = EntidadClientes.TablaConsulta
        CbCiudad.DataSource = tabla2
        CbCiudad.ValueMember = "IdMunicipio"
        CbCiudad.DisplayMember = "Descripcion"
        CbCiudad.SelectedIndex = -1
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
        Consultar()
    End Sub
    Private Sub DgvBodegas_DoubleClick(sender As Object, e As EventArgs) Handles DgvBodegas.DoubleClick

        If DgvBodegas.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvBodegas.CurrentCell.RowIndex
            TbIdBodega.Text = DgvBodegas.Rows(index).Cells("IdAlmacen").Value
            TbDescripcion.Text = DgvBodegas.Rows(index).Cells("Descripcion").Value
            CbTipo.SelectedValue = DgvBodegas.Rows(index).Cells("IdTipoAlmacen").Value
            TbCalle.Text = DgvBodegas.Rows(index).Cells("Calle").Value
            TbNumero.Text = DgvBodegas.Rows(index).Cells("Numero").Value
            TbCodigoPostal.Text = DgvBodegas.Rows(index).Cells("CodigoPostal").Value
            TbColonia.Text = DgvBodegas.Rows(index).Cells("Colonia").Value
            CbEstado.SelectedValue = DgvBodegas.Rows(index).Cells("Estado").Value
            CargaComboMunicipios()
            CbCiudad.SelectedValue = DgvBodegas.Rows(index).Cells("Ciudad").Value
            NuCapacidad.Value = DgvBodegas.Rows(index).Cells("Capacidad").Value
        End If
    End Sub
    Private Sub CbEstado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbEstado.SelectionChangeCommitted
        CargaComboMunicipios()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class