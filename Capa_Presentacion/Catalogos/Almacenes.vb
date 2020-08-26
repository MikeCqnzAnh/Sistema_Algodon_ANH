Imports Capa_Operacion.Configuracion
Public Class Almacenes
    Private Sub Almacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        LlenaCombos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbIdAlmacen.Text = ""
        TbDescripcion.Text = ""
        TbColumnas.Text = ""
        TbFilas.Text = ""
        CbTipo.SelectedIndex = -1
        TbCantidadLotes.Text = ""
        TbCantidadNiveles.Text = ""
        TbCalle.Text = ""
        TbNumero.Text = ""
        TbCodigoPostal.Text = ""
        TbColonia.Text = ""
        CbCiudad.SelectedIndex = -1
        CbEstado.SelectedIndex = -1
        NuCapacidad.Value = 0
        Consultar()
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
            EntidadAlmacenes.IdAlmacenEncabezado = IIf(TbIdAlmacen.Text = "", 0, TbIdAlmacen.Text)
            EntidadAlmacenes.Descripcion = TbDescripcion.Text
            EntidadAlmacenes.IdTipoAlmacen = CbTipo.SelectedValue
            EntidadAlmacenes.CantidadLotes = Val(TbCantidadLotes.Text)
            EntidadAlmacenes.CantidadNiveles = Val(TbCantidadNiveles.Text)
            EntidadAlmacenes.Columnas = Val(TbColumnas.Text)
            EntidadAlmacenes.filas = Val(TbFilas.Text)
            EntidadAlmacenes.FechaAlta = DtFecha.Value
            EntidadAlmacenes.Actualiza = Actualiza.ActualizaAlmacenEnc
            NegocioAlmacenes.Guardar(EntidadAlmacenes)
            TbIdAlmacen.Text = EntidadAlmacenes.IdAlmacenEncabezado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarDetalle(ByVal IdLote As Integer, ByVal Nivel As String, ByVal Columna As Integer, ByVal Fila As Integer)
        Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
        Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
        Try
            EntidadAlmacenes.IdAlmacenDetalle = 0
            EntidadAlmacenes.IdAlmacenEncabezado = Val(TbIdAlmacen.Text)
            EntidadAlmacenes.IdLote = IdLote
            EntidadAlmacenes.Nivel = Nivel
            EntidadAlmacenes.PosicionColumna = Columna
            EntidadAlmacenes.PosicionFila = Fila
            'EntidadAlmacenes.BaleID = IIf(tb) TbColonia.Text
            EntidadAlmacenes.Actualiza = Actualiza.ActualizaAlmacenDet
            NegocioAlmacenes.Guardar(EntidadAlmacenes)
            TbIdAlmacen.Text = EntidadAlmacenes.IdAlmacenEncabezado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Consultar()
        Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
        Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
        Dim Tabla As New DataTable
        Try
            EntidadAlmacenes.IdAlmacenEncabezado = IIf(TbIdAlmacen.Text = "", 0, TbIdAlmacen.Text)
            EntidadAlmacenes.Descripcion = ""
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
        If CbTipo.SelectedText = "" And Val(TbCantidadLotes.Text) = 0 And Val(TbCantidadNiveles.Text) = 0 And Val(TbColumnas.Text) = 0 And Val(TbFilas.Text) = 0 Then
            MsgBox("No se permiten campos en blanco, revisar", MsgBoxStyle.Information, "Aviso")
        Else
            guardarencabezado()
            Dim Lote As Integer = 0
            Dim Nivel As String = ""
            Dim Columna As Integer = 0
            Dim Fila As Integer = 0
            Dim ArrayCadena() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
            For i = 0 To Val(TbCantidadLotes.Text) - 1 Step 1
                Lote = i + 1
                For j = 0 To Val(TbCantidadNiveles.Text) - 1 Step 1
                    Nivel = ArrayCadena(j)
                    For k = 0 To Val(TbColumnas.Text) - 1 Step 1
                        Columna = k
                        For l = 0 To Val(TbFilas.Text) - 1 Step 1
                            Fila = l
                            GuardarDetalle(Lote, Nivel, Columna, Fila)
                        Next
                    Next
                Next
            Next
        End If
        Limpiar()
        Consultar()
    End Sub
    Private Sub DgvBodegas_DoubleClick(sender As Object, e As EventArgs) Handles DgvBodegas.DoubleClick
        If DgvBodegas.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvBodegas.CurrentCell.RowIndex
            TbIdAlmacen.Text = DgvBodegas.Rows(index).Cells("IdAlmacenEncabezado").Value
            TbDescripcion.Text = DgvBodegas.Rows(index).Cells("Descripcion").Value
            CbTipo.SelectedValue = DgvBodegas.Rows(index).Cells("TipoAlmacen").Value
            TbCantidadLotes.Text = DgvBodegas.Rows(index).Cells("Cantidadlotes").Value
            TbCantidadNiveles.Text = DgvBodegas.Rows(index).Cells("CantidadNiveles").Value
            TbColumnas.Text = DgvBodegas.Rows(index).Cells("Columnas").Value
            TbFilas.Text = DgvBodegas.Rows(index).Cells("Filas").Value
            DtFecha.Value = DgvBodegas.Rows(index).Cells("FechaAlta").Value
            'CargaComboMunicipios()
            'CbCiudad.SelectedValue = DgvBodegas.Rows(index).Cells("Ciudad").Value
            'NuCapacidad.Value = DgvBodegas.Rows(index).Cells("Capacidad").Value
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