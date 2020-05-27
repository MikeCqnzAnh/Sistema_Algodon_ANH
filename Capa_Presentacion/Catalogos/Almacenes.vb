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
        Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
        Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
        Try
            If TbDescripcion.Text <> "" Then

                'EntidadAlmacenes.IdAlmacenEncabezado = IIf(TbIdBodega.Text = "", 0, TbIdBodega.Text)
                'EntidadAlmacenes.TipoAlmacen = TbDescripcion.Text
                'EntidadAlmacenes.CantidadLotes = CbTipo.SelectedValue
                'EntidadAlmacenes.CantidadNiveles = TbCalle.Text
                'EntidadAlmacenes.Columnas = TbNumero.Text
                'EntidadAlmacenes.filas = TbCodigoPostal.Text
                'EntidadAlmacenes.FechaAlta = TbColonia.Text
                'EntidadAlmacenes.Ciudad = CbCiudad.SelectedValue
                'EntidadAlmacenes.Estado = CbEstado.SelectedValue
                'EntidadAlmacenes.Capacidad = NuCapacidad.Value
                'EntidadAlmacenes.Actualiza = Actuliza.ActualizaAlmacen
                'NegocioAlmacenes.Guardar(EntidadAlmacenes)
                'TbIdBodega.Text = EntidadAlmacenes.IdTipoAlmacen
                'Consultar()
            Else
                MessageBox.Show("El campo descripcion no puede estar vacio.", "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub guardarencabezado()
        Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
        Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
        Try
            EntidadAlmacenes.IdAlmacenEncabezado = IIf(TbIdBodega.Text = "", 0, TbIdBodega.Text)
            EntidadAlmacenes.IdTipoAlmacen = CbTipo.SelectedValue
            EntidadAlmacenes.CantidadLotes = Val(TbCantidadRack.Text)
            EntidadAlmacenes.CantidadNiveles = Val(TbCantidadNiveles.Text)
            EntidadAlmacenes.Columnas = Val(TbColumnas.Text)
            EntidadAlmacenes.filas = Val(TbFilas.Text)
            EntidadAlmacenes.FechaAlta = DtFecha.Value
            EntidadAlmacenes.Actualiza = Actualiza.ActualizaAlmacenEnc
            NegocioAlmacenes.Guardar(EntidadAlmacenes)
            TbIdBodega.Text = EntidadAlmacenes.IdAlmacenEncabezado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarDetalle()
        Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
        Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
        Try
            EntidadAlmacenes.IdAlmacenDetalle = 0
            EntidadAlmacenes.IdAlmacenEncabezado = Val(TbIdBodega.Text)
            EntidadAlmacenes.IdLote = Val(TbCantidadRack.Text)
            'EntidadAlmacenes.Nivel = Val(TbCantidadNiveles.Text)
            'EntidadAlmacenes.PosicionColumna = DBNull.Value 'TbNumero.Text
            'EntidadAlmacenes.PosicionFila = DBNull.Value ' TbCodigoPostal.Text
            'EntidadAlmacenes.BaleID = IIf(tb) TbColonia.Text
            EntidadAlmacenes.Actualiza = Actualiza.ActualizaAlmacenDet
            NegocioAlmacenes.Guardar(EntidadAlmacenes)
            TbIdBodega.Text = EntidadAlmacenes.IdAlmacenEncabezado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Consultar()
        Try
            Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
            Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
            Dim Tabla As New DataTable
            EntidadAlmacenes.IdAlmacenEncabezado = IIf(TbIdBodega.Text = "", 0, TbIdBodega.Text)
            EntidadAlmacenes.Consulta = Consulta.ConsultaAlmacen
            NegocioAlmacenes.Consultar(EntidadAlmacenes)
            DgvBodegas.DataSource = EntidadAlmacenes.TablaConsulta
            'FormatoDatagrid()
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
        'Guardar()
        If CbTipo.SelectedText = "" And Val(TbCantidadRack.Text) = 0 And Val(TbCantidadNiveles.Text) = 0 And Val(TbColumnas.Text) = 0 And Val(TbFilas.Text) = 0 Then
            MsgBox("No se permiten campos en blanco, revisar", MsgBoxStyle.Information, "Aviso")
        Else
            guardarencabezado()
            For i = 0 To Val(TbCantidadRack.Text) - 1 Step 1
                For j = 0 To Val(TbCantidadNiveles.Text) - 1 Step 1
                    GuardarDetalle()
                Next
            Next
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class